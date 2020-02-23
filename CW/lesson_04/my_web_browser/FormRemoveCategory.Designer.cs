namespace my_web_browser
{
    partial class FormRemoveCategory
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
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveAndCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(12, 12);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxCategories.Size = new System.Drawing.Size(284, 199);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategories_SelectedIndexChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(32, 218);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(210, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSaveAndCancel
            // 
            this.buttonSaveAndCancel.Location = new System.Drawing.Point(167, 218);
            this.buttonSaveAndCancel.Name = "buttonSaveAndCancel";
            this.buttonSaveAndCancel.Size = new System.Drawing.Size(118, 23);
            this.buttonSaveAndCancel.TabIndex = 3;
            this.buttonSaveAndCancel.Text = "Save And Cancel";
            this.buttonSaveAndCancel.UseVisualStyleBackColor = true;
            this.buttonSaveAndCancel.Click += new System.EventHandler(this.ButtonSaveAndCancel_Click);
            // 
            // FormRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 278);
            this.Controls.Add(this.buttonSaveAndCancel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxCategories);
            this.Name = "FormRemoveCategory";
            this.Text = "FormRemoveCategory";
            this.Load += new System.EventHandler(this.FormRemoveCategory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveAndCancel;
    }
}