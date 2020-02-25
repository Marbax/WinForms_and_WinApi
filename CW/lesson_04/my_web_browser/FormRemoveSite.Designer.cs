namespace my_web_browser
{
    partial class FormRemoveSite
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
            this.buttonSaveAndCancel = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxSites = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSaveAndCancel
            // 
            this.buttonSaveAndCancel.Location = new System.Drawing.Point(220, 266);
            this.buttonSaveAndCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAndCancel.Name = "buttonSaveAndCancel";
            this.buttonSaveAndCancel.Size = new System.Drawing.Size(157, 28);
            this.buttonSaveAndCancel.TabIndex = 7;
            this.buttonSaveAndCancel.Text = "Save And Cancel";
            this.buttonSaveAndCancel.UseVisualStyleBackColor = true;
            this.buttonSaveAndCancel.Click += new System.EventHandler(this.buttonSaveAndCancel_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(277, 302);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(40, 266);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 28);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxSites
            // 
            this.listBoxSites.FormattingEnabled = true;
            this.listBoxSites.Location = new System.Drawing.Point(13, 13);
            this.listBoxSites.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSites.Name = "listBoxSites";
            this.listBoxSites.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSites.Size = new System.Drawing.Size(377, 238);
            this.listBoxSites.TabIndex = 4;
            // 
            // FormRemoveSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 339);
            this.Controls.Add(this.buttonSaveAndCancel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxSites);
            this.Name = "FormRemoveSite";
            this.Text = "FormRemoveSite";
            this.Load += new System.EventHandler(this.FormRemoveSite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveAndCancel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxSites;
    }
}