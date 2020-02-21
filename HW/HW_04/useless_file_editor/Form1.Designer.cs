namespace useless_file_editor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxFileText = new System.Windows.Forms.TextBox();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonEditFile = new System.Windows.Forms.Button();
            this.panelRightMarg = new System.Windows.Forms.Panel();
            this.panelLeftMarg = new System.Windows.Forms.Panel();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelBtns.SuspendLayout();
            this.panelRightMarg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.Controls.Add(this.textBoxFileText);
            this.panelMain.Controls.Add(this.panelControls);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(692, 512);
            this.panelMain.TabIndex = 0;
            // 
            // textBoxFileText
            // 
            this.textBoxFileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileText.Location = new System.Drawing.Point(0, 0);
            this.textBoxFileText.Multiline = true;
            this.textBoxFileText.Name = "textBoxFileText";
            this.textBoxFileText.ReadOnly = true;
            this.textBoxFileText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFileText.Size = new System.Drawing.Size(692, 450);
            this.textBoxFileText.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControls.Controls.Add(this.panelBtns);
            this.panelControls.Controls.Add(this.panelRightMarg);
            this.panelControls.Controls.Add(this.panelLeftMarg);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 450);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(692, 62);
            this.panelControls.TabIndex = 9;
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.buttonLoadFile);
            this.panelBtns.Controls.Add(this.buttonEditFile);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtns.Location = new System.Drawing.Point(200, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(305, 58);
            this.panelBtns.TabIndex = 5;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadFile.Location = new System.Drawing.Point(0, 29);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(305, 29);
            this.buttonLoadFile.TabIndex = 2;
            this.buttonLoadFile.Text = "Load File";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonEditFile
            // 
            this.buttonEditFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditFile.Enabled = false;
            this.buttonEditFile.Location = new System.Drawing.Point(0, 0);
            this.buttonEditFile.Name = "buttonEditFile";
            this.buttonEditFile.Size = new System.Drawing.Size(305, 29);
            this.buttonEditFile.TabIndex = 3;
            this.buttonEditFile.Text = "Edit File";
            this.buttonEditFile.UseVisualStyleBackColor = true;
            this.buttonEditFile.Click += new System.EventHandler(this.buttonEditFile_Click);
            // 
            // panelRightMarg
            // 
            this.panelRightMarg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRightMarg.Controls.Add(this.label1);
            this.panelRightMarg.Controls.Add(this.linkLabelHelp);
            this.panelRightMarg.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightMarg.Location = new System.Drawing.Point(505, 0);
            this.panelRightMarg.Name = "panelRightMarg";
            this.panelRightMarg.Size = new System.Drawing.Size(183, 58);
            this.panelRightMarg.TabIndex = 5;
            // 
            // panelLeftMarg
            // 
            this.panelLeftMarg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLeftMarg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMarg.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMarg.Name = "panelLeftMarg";
            this.panelLeftMarg.Size = new System.Drawing.Size(200, 58);
            this.panelLeftMarg.TabIndex = 4;
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.linkLabelHelp.Location = new System.Drawing.Point(172, 47);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(13, 13);
            this.linkLabelHelp.TabIndex = 0;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "&?";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 512);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelBtns.ResumeLayout(false);
            this.panelRightMarg.ResumeLayout(false);
            this.panelRightMarg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonEditFile;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.TextBox textBoxFileText;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Panel panelRightMarg;
        private System.Windows.Forms.Panel panelLeftMarg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
    }
}

