namespace ProcessWatcher
{
    partial class ProcessListForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enumerateProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.listOnlyWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.keepScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(264, 232);
            this.listBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.watchToolStripMenuItem.Text = "Watch";
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.watchToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enumerateProcessToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // enumerateProcessToolStripMenuItem
            // 
            this.enumerateProcessToolStripMenuItem.Name = "enumerateProcessToolStripMenuItem";
            this.enumerateProcessToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.enumerateProcessToolStripMenuItem.Text = "Enumerate Process";
            this.enumerateProcessToolStripMenuItem.Click += new System.EventHandler(this.enumerateProcessToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchTypeToolStripMenuItem,
            this.intervalsToolStripMenuItem,
            this.listOnlyWindowToolStripMenuItem,
            this.keepScreenToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.settingsToolStripMenuItem_DropDownOpening);
            // 
            // watchTypeToolStripMenuItem
            // 
            this.watchTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.anyToolStripMenuItem});
            this.watchTypeToolStripMenuItem.Name = "watchTypeToolStripMenuItem";
            this.watchTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.watchTypeToolStripMenuItem.Text = "Watch &Type";
            this.watchTypeToolStripMenuItem.DropDownOpening += new System.EventHandler(this.watchTypeToolStripMenuItem_DropDownOpening);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // anyToolStripMenuItem
            // 
            this.anyToolStripMenuItem.Name = "anyToolStripMenuItem";
            this.anyToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.anyToolStripMenuItem.Text = "Any";
            this.anyToolStripMenuItem.Click += new System.EventHandler(this.anyToolStripMenuItem_Click);
            // 
            // intervalsToolStripMenuItem
            // 
            this.intervalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.intervalsToolStripMenuItem.Name = "intervalsToolStripMenuItem";
            this.intervalsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.intervalsToolStripMenuItem.Text = "&Interval (s)";
            this.intervalsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.intervalsToolStripMenuItem_DropDownOpening);
            this.intervalsToolStripMenuItem.DropDownClosed += new System.EventHandler(this.intervalsToolStripMenuItem_DropDownClosed);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // listOnlyWindowToolStripMenuItem
            // 
            this.listOnlyWindowToolStripMenuItem.Checked = true;
            this.listOnlyWindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.listOnlyWindowToolStripMenuItem.Name = "listOnlyWindowToolStripMenuItem";
            this.listOnlyWindowToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listOnlyWindowToolStripMenuItem.Text = "List Only &Window";
            this.listOnlyWindowToolStripMenuItem.Click += new System.EventHandler(this.listOnlyWindowToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // keepScreenToolStripMenuItem
            // 
            this.keepScreenToolStripMenuItem.Name = "keepScreenToolStripMenuItem";
            this.keepScreenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.keepScreenToolStripMenuItem.Text = "Keep &Screen";
            this.keepScreenToolStripMenuItem.Click += new System.EventHandler(this.keepScreenToolStripMenuItem_Click);
            // 
            // ProcessListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProcessListForm";
            this.Text = "Process Watcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enumerateProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem listOnlyWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepScreenToolStripMenuItem;

    }
}

