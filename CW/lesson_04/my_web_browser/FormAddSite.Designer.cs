namespace my_web_browser
{
    partial class FormAddSite
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRefuse = new System.Windows.Forms.Button();
            this.textBoxSiteName = new System.Windows.Forms.TextBox();
            this.labelSiteName = new System.Windows.Forms.Label();
            this.textBoxSiteURL = new System.Windows.Forms.TextBox();
            this.labelSiteURL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(35, 115);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 25);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonRefuse
            // 
            this.buttonRefuse.Location = new System.Drawing.Point(169, 115);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(100, 25);
            this.buttonRefuse.TabIndex = 6;
            this.buttonRefuse.Text = "Refuse";
            this.buttonRefuse.UseVisualStyleBackColor = true;
            this.buttonRefuse.Click += new System.EventHandler(this.ButtonRefuse_Click);
            // 
            // textBoxSiteName
            // 
            this.textBoxSiteName.Location = new System.Drawing.Point(25, 40);
            this.textBoxSiteName.Name = "textBoxSiteName";
            this.textBoxSiteName.Size = new System.Drawing.Size(255, 20);
            this.textBoxSiteName.TabIndex = 5;
            // 
            // labelSiteName
            // 
            this.labelSiteName.AutoSize = true;
            this.labelSiteName.Location = new System.Drawing.Point(103, 24);
            this.labelSiteName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiteName.Name = "labelSiteName";
            this.labelSiteName.Size = new System.Drawing.Size(84, 13);
            this.labelSiteName.TabIndex = 4;
            this.labelSiteName.Text = "New Site Name:";
            // 
            // textBoxSiteURL
            // 
            this.textBoxSiteURL.Location = new System.Drawing.Point(25, 89);
            this.textBoxSiteURL.Name = "textBoxSiteURL";
            this.textBoxSiteURL.Size = new System.Drawing.Size(255, 20);
            this.textBoxSiteURL.TabIndex = 8;
            // 
            // labelSiteURL
            // 
            this.labelSiteURL.AutoSize = true;
            this.labelSiteURL.Location = new System.Drawing.Point(109, 73);
            this.labelSiteURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSiteURL.Name = "labelSiteURL";
            this.labelSiteURL.Size = new System.Drawing.Size(78, 13);
            this.labelSiteURL.TabIndex = 9;
            this.labelSiteURL.Text = "New Site URL:";
            // 
            // FormAddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 158);
            this.Controls.Add(this.labelSiteURL);
            this.Controls.Add(this.textBoxSiteURL);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRefuse);
            this.Controls.Add(this.textBoxSiteName);
            this.Controls.Add(this.labelSiteName);
            this.Name = "FormAddSite";
            this.Text = "Add Site";
            this.Load += new System.EventHandler(this.FormAddSite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefuse;
        private System.Windows.Forms.TextBox textBoxSiteName;
        private System.Windows.Forms.Label labelSiteName;
        private System.Windows.Forms.TextBox textBoxSiteURL;
        private System.Windows.Forms.Label labelSiteURL;
    }
}