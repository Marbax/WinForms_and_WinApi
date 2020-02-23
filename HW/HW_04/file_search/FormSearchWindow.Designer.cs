namespace file_search
{
    partial class FormSearchWindow
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.textBoxMask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(111, 257);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(289, 212);
            this.listBoxFiles.TabIndex = 1;
            // 
            // textBoxMask
            // 
            this.textBoxMask.Location = new System.Drawing.Point(12, 231);
            this.textBoxMask.Name = "textBoxMask";
            this.textBoxMask.Size = new System.Drawing.Size(289, 20);
            this.textBoxMask.TabIndex = 2;
            this.textBoxMask.Text = "*.txt";
            // 
            // FormSearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 281);
            this.Controls.Add(this.textBoxMask);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.buttonSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearchWindow";
            this.Text = "Search Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox textBoxMask;
    }
}