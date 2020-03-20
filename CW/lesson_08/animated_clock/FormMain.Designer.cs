namespace animated_clock
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.setAllarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.contextMenuStripClock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAllarmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllarmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.contextMenuStripClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAllarmToolStripMenuItem,
            this.resetAllarmToolStripMenuItem});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Name = "menuStripMain";
            // 
            // setAllarmToolStripMenuItem
            // 
            this.setAllarmToolStripMenuItem.Name = "setAllarmToolStripMenuItem";
            resources.ApplyResources(this.setAllarmToolStripMenuItem, "setAllarmToolStripMenuItem");
            this.setAllarmToolStripMenuItem.Click += new System.EventHandler(this.setAllarmToolStripMenuItem_Click_1);
            // 
            // resetAllarmToolStripMenuItem
            // 
            this.resetAllarmToolStripMenuItem.Name = "resetAllarmToolStripMenuItem";
            resources.ApplyResources(this.resetAllarmToolStripMenuItem, "resetAllarmToolStripMenuItem");
            this.resetAllarmToolStripMenuItem.Click += new System.EventHandler(this.resetAllarmToolStripMenuItem_Click);
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.ContextMenuStrip = this.contextMenuStripClock;
            resources.ApplyResources(this.pictureBoxClock, "pictureBoxClock");
            this.pictureBoxClock.Image = global::animated_clock.Properties.Resources.clock;
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.TabStop = false;
            this.pictureBoxClock.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxClock_Paint);
            // 
            // contextMenuStripClock
            // 
            this.contextMenuStripClock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAllarmToolStripMenuItem1,
            this.resetAllarmToolStripMenuItem1});
            this.contextMenuStripClock.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStripClock, "contextMenuStripClock");
            // 
            // setAllarmToolStripMenuItem1
            // 
            this.setAllarmToolStripMenuItem1.Name = "setAllarmToolStripMenuItem1";
            resources.ApplyResources(this.setAllarmToolStripMenuItem1, "setAllarmToolStripMenuItem1");
            this.setAllarmToolStripMenuItem1.Click += new System.EventHandler(this.setAllarmToolStripMenuItem_Click_1);
            // 
            // resetAllarmToolStripMenuItem1
            // 
            this.resetAllarmToolStripMenuItem1.Name = "resetAllarmToolStripMenuItem1";
            resources.ApplyResources(this.resetAllarmToolStripMenuItem1, "resetAllarmToolStripMenuItem1");
            this.resetAllarmToolStripMenuItem1.Click += new System.EventHandler(this.resetAllarmToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxClock);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.contextMenuStripClock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem setAllarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllarmToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClock;
        private System.Windows.Forms.ToolStripMenuItem setAllarmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetAllarmToolStripMenuItem1;
    }
}

