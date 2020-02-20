namespace useless_file_editor
{
    partial class Form2EditWindow
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelText = new System.Windows.Forms.Panel();
            this.textBoxFileText = new System.Windows.Forms.TextBox();
            this.panelLeftMargin = new System.Windows.Forms.Panel();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelControls.SuspendLayout();
            this.panelText.SuspendLayout();
            this.panelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.panelBtns);
            this.panelControls.Controls.Add(this.panelLeftMargin);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 399);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(742, 58);
            this.panelControls.TabIndex = 0;
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.textBoxFileText);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(742, 399);
            this.panelText.TabIndex = 1;
            // 
            // textBoxFileText
            // 
            this.textBoxFileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileText.Location = new System.Drawing.Point(0, 0);
            this.textBoxFileText.Multiline = true;
            this.textBoxFileText.Name = "textBoxFileText";
            this.textBoxFileText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFileText.Size = new System.Drawing.Size(742, 399);
            this.textBoxFileText.TabIndex = 1;
            // 
            // panelLeftMargin
            // 
            this.panelLeftMargin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeftMargin.Location = new System.Drawing.Point(466, 0);
            this.panelLeftMargin.Name = "panelLeftMargin";
            this.panelLeftMargin.Size = new System.Drawing.Size(276, 58);
            this.panelLeftMargin.TabIndex = 0;
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.buttonCancel);
            this.panelBtns.Controls.Add(this.buttonSave);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtns.Location = new System.Drawing.Point(266, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(200, 58);
            this.panelBtns.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 28);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCancel.Location = new System.Drawing.Point(0, 28);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form2EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 457);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panelControls);
            this.Name = "Form2EditWindow";
            this.Text = "Edit Text";
            this.panelControls.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panelBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelLeftMargin;
        private System.Windows.Forms.TextBox textBoxFileText;
    }
}