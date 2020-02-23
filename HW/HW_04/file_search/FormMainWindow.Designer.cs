namespace file_search
{
    partial class FormMainWindow
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
            this.buttonOpenSearchWindow = new System.Windows.Forms.Button();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonOpenSearchWindow
            // 
            this.buttonOpenSearchWindow.Location = new System.Drawing.Point(21, 19);
            this.buttonOpenSearchWindow.Name = "buttonOpenSearchWindow";
            this.buttonOpenSearchWindow.Size = new System.Drawing.Size(157, 37);
            this.buttonOpenSearchWindow.TabIndex = 0;
            this.buttonOpenSearchWindow.Text = "Open Search Window";
            this.buttonOpenSearchWindow.UseVisualStyleBackColor = true;
            this.buttonOpenSearchWindow.Click += new System.EventHandler(this.buttonOpenSearchWindow_Click);
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Location = new System.Drawing.Point(180, 0);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(13, 13);
            this.linkLabelHelp.TabIndex = 1;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "&?";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHelp_LinkClicked);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 72);
            this.Controls.Add(this.linkLabelHelp);
            this.Controls.Add(this.buttonOpenSearchWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.FormMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenSearchWindow;
        private System.Windows.Forms.LinkLabel linkLabelHelp;
    }
}

