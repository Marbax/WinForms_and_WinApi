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
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.labelCategorySelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(28, 166);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonRefuse
            // 
            this.buttonRefuse.Location = new System.Drawing.Point(208, 166);
            this.buttonRefuse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(133, 30);
            this.buttonRefuse.TabIndex = 6;
            this.buttonRefuse.Text = "Refuse";
            this.buttonRefuse.UseVisualStyleBackColor = true;
            this.buttonRefuse.Click += new System.EventHandler(this.ButtonRefuse_Click);
            // 
            // textBoxSiteName
            // 
            this.textBoxSiteName.Location = new System.Drawing.Point(16, 74);
            this.textBoxSiteName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSiteName.Name = "textBoxSiteName";
            this.textBoxSiteName.Size = new System.Drawing.Size(340, 22);
            this.textBoxSiteName.TabIndex = 5;
            // 
            // labelSiteName
            // 
            this.labelSiteName.AutoSize = true;
            this.labelSiteName.Location = new System.Drawing.Point(119, 54);
            this.labelSiteName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSiteName.Name = "labelSiteName";
            this.labelSiteName.Size = new System.Drawing.Size(104, 16);
            this.labelSiteName.TabIndex = 4;
            this.labelSiteName.Text = "New Site Name:";
            // 
            // textBoxSiteURL
            // 
            this.textBoxSiteURL.Location = new System.Drawing.Point(16, 134);
            this.textBoxSiteURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSiteURL.Name = "textBoxSiteURL";
            this.textBoxSiteURL.Size = new System.Drawing.Size(338, 22);
            this.textBoxSiteURL.TabIndex = 8;
            // 
            // labelSiteURL
            // 
            this.labelSiteURL.AutoSize = true;
            this.labelSiteURL.Location = new System.Drawing.Point(128, 114);
            this.labelSiteURL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSiteURL.Name = "labelSiteURL";
            this.labelSiteURL.Size = new System.Drawing.Size(94, 16);
            this.labelSiteURL.TabIndex = 9;
            this.labelSiteURL.Text = "New Site URL:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(196, 15);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCategories.TabIndex = 10;
            // 
            // labelCategorySelect
            // 
            this.labelCategorySelect.AutoSize = true;
            this.labelCategorySelect.Location = new System.Drawing.Point(12, 18);
            this.labelCategorySelect.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCategorySelect.Name = "labelCategorySelect";
            this.labelCategorySelect.Size = new System.Drawing.Size(118, 16);
            this.labelCategorySelect.TabIndex = 11;
            this.labelCategorySelect.Text = "Select a Category:";
            // 
            // FormAddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 210);
            this.Controls.Add(this.labelCategorySelect);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.labelSiteURL);
            this.Controls.Add(this.textBoxSiteURL);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRefuse);
            this.Controls.Add(this.textBoxSiteName);
            this.Controls.Add(this.labelSiteName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label labelCategorySelect;
    }
}