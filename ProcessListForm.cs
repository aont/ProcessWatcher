using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProcessWatcher
{
    public partial class ProcessListForm : Form
    {
        public ProcessListForm()
        {
            InitializeComponent();
            this.EnumerateProcesses();
        }


        bool watchall = false;
        bool watching
        {
            get
            {
                return this.timer1.Enabled;
            }
            set
            {
                this.timer1.Enabled = value;
            }
        }
        int Interval
        {
            get
            {
                return this.timer1.Interval / 1000;
            }
            set
            {
                this.timer1.Interval = value * 1000;
            }
        }

        void EnumerateProcesses()
        {
            this.listBox1.Items.Clear();

            var processes = Process.GetProcesses();
            if (onlywindow)
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.MainWindowHandle != IntPtr.Zero)
                        this.listBox1.Items.Add(new ProcessWatch(p));
                }
            }
            else
            {
                foreach (Process p in Process.GetProcesses())
                {

                    this.listBox1.Items.Add(new ProcessWatch(p));
                }
            }
        }
        private void enumerateProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnumerateProcesses();
        }

        private void watchTypeToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (watchall)
            {
                this.allToolStripMenuItem.Checked = true;
                this.anyToolStripMenuItem.Checked = false;
            }
            else
            {
                this.allToolStripMenuItem.Checked = false;
                this.anyToolStripMenuItem.Checked = true;
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.watchall = true;
        }

        private void anyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.watchall = false;
        }


        private void intervalsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.toolStripTextBox1.Text = this.Interval.ToString();
        }

        private void intervalsToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                this.Interval = int.Parse(this.toolStripTextBox1.Text);
            }
            catch
            { }
        }


        private void watchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.watching = !this.watching;
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.watchToolStripMenuItem.Checked = this.watching;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.StandByPrevent();
            this.timer1.Start();
        }

        void StandByPrevent()
        {
            if (watchall)
            {
                bool flag = true;
                foreach (ProcessWatch p in this.listBox1.SelectedItems)
                {
                    if (p.HasExited)
                        flag = false;
                }
                if (flag)
                    SetThreadExecutionState(Required);
            }
            else
            {
                foreach (ProcessWatch p in this.listBox1.SelectedItems)
                {
                    if (!p.HasExited)
                    {
                        SetThreadExecutionState(Required);
                        break;
                    }
                }
            }
        }

        [DllImport("kernel32.dll")]
        extern static ExecutionState SetThreadExecutionState(ExecutionState esFlags);

        bool onlywindow = true;
        private void listOnlyWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.onlywindow = !this.onlywindow;
        }


        private void settingsToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.listOnlyWindowToolStripMenuItem.Checked = this.onlywindow;
            this.keepScreenToolStripMenuItem.Checked = this.keepscreen;

        }

        bool keepscreen = false;
        private void keepScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.keepscreen = !this.keepscreen;
        }

        ExecutionState Required
        {
            get
            {
                if (this.keepscreen)
                {
                    return ExecutionState.DisplayRequired;
                }
                else
                {
                    return ExecutionState.SystemRequired;
                }
            }
        }

    }

    [FlagsAttribute]
    public enum ExecutionState : uint
    {
        // 関数が失敗した時の戻り値
        Null = 0,
        // スタンバイを抑止
        SystemRequired = 1,
        // 画面OFFを抑止
        DisplayRequired = 2,
        // 効果を永続させる。ほかオプションと併用する。
        Continuous = 0x80000000,
    }
}
