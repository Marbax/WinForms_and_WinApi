namespace my_web_browser
{
    partial class FormAddCategory
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
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonRefuse = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(69, 12);
            this.labelCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(136, 16);
            this.labelCategoryName.TabIndex = 0;
            this.labelCategoryName.Text = "New Category Name:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(20, 31);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(255, 22);
            this.textBoxCategoryName.TabIndex = 1;
            // 
            // buttonRefuse
            // 
            this.buttonRefuse.Location = new System.Drawing.Point(163, 59);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(100, 25);
            this.buttonRefuse.TabIndex = 2;
            this.buttonRefuse.Text = "Refuse";
            this.buttonRefuse.UseVisualStyleBackColor = true;
            this.buttonRefuse.Click += new System.EventHandler(this.ButtonRefuse_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(32, 59);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 25);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 103);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRefuse);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelCategoryName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCategory";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.FormAddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonRefuse;
        private System.Windows.Forms.Button buttonSave;
    }
}