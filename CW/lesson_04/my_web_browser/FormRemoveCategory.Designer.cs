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
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(16, 15);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxCategories.Size = new System.Drawing.Size(377, 244);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategories_SelectedIndexChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(43, 268);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(100, 28);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(280, 304);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonSaveAndCancel
            // 
            this.buttonSaveAndCancel.Location = new System.Drawing.Point(223, 268);
            this.buttonSaveAndCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAndCancel.Name = "buttonSaveAndCancel";
            this.buttonSaveAndCancel.Size = new System.Drawing.Size(157, 28);
            this.buttonSaveAndCancel.TabIndex = 3;
            this.buttonSaveAndCancel.Text = "Save And Cancel";
            this.buttonSaveAndCancel.UseVisualStyleBackColor = true;
            this.buttonSaveAndCancel.Click += new System.EventHandler(this.ButtonSaveAndCancel_Click);
            // 
            // FormRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 342);
            this.Controls.Add(this.buttonSaveAndCancel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listBoxCategories);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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