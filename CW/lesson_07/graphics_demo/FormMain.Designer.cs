namespace graphics_demo
{
    partial class FormMain
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
            this.panelBtns = new System.Windows.Forms.Panel();
            this.comboBoxPens = new System.Windows.Forms.ComboBox();
            this.buttonBrushes = new System.Windows.Forms.Button();
            this.buttonElipses = new System.Windows.Forms.Button();
            this.buttonRectangles = new System.Windows.Forms.Button();
            this.buttonLines = new System.Windows.Forms.Button();
            this.panelPicBox = new System.Windows.Forms.Panel();
            this.pictureBoxDrawArea = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPies = new System.Windows.Forms.Button();
            this.panelBtns.SuspendLayout();
            this.panelPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.buttonPies);
            this.panelBtns.Controls.Add(this.buttonClear);
            this.panelBtns.Controls.Add(this.comboBoxPens);
            this.panelBtns.Controls.Add(this.buttonBrushes);
            this.panelBtns.Controls.Add(this.buttonElipses);
            this.panelBtns.Controls.Add(this.buttonRectangles);
            this.panelBtns.Controls.Add(this.buttonLines);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtns.Location = new System.Drawing.Point(0, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(200, 550);
            this.panelBtns.TabIndex = 0;
            this.panelBtns.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBtns_Paint);
            // 
            // comboBoxPens
            // 
            this.comboBoxPens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPens.FormattingEnabled = true;
            this.comboBoxPens.Location = new System.Drawing.Point(14, 167);
            this.comboBoxPens.Name = "comboBoxPens";
            this.comboBoxPens.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPens.TabIndex = 4;
            this.comboBoxPens.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPens_SelectedIndexChanged);
            // 
            // buttonBrushes
            // 
            this.buttonBrushes.Location = new System.Drawing.Point(14, 109);
            this.buttonBrushes.Name = "buttonBrushes";
            this.buttonBrushes.Size = new System.Drawing.Size(173, 23);
            this.buttonBrushes.TabIndex = 3;
            this.buttonBrushes.Text = "Brushes";
            this.buttonBrushes.UseVisualStyleBackColor = true;
            this.buttonBrushes.Click += new System.EventHandler(this.ButtonBrushes_Click);
            // 
            // buttonElipses
            // 
            this.buttonElipses.Location = new System.Drawing.Point(14, 80);
            this.buttonElipses.Name = "buttonElipses";
            this.buttonElipses.Size = new System.Drawing.Size(173, 23);
            this.buttonElipses.TabIndex = 2;
            this.buttonElipses.Text = "Elipses";
            this.buttonElipses.UseVisualStyleBackColor = true;
            this.buttonElipses.Click += new System.EventHandler(this.ButtonElipses_Click);
            // 
            // buttonRectangles
            // 
            this.buttonRectangles.Location = new System.Drawing.Point(14, 51);
            this.buttonRectangles.Name = "buttonRectangles";
            this.buttonRectangles.Size = new System.Drawing.Size(173, 23);
            this.buttonRectangles.TabIndex = 1;
            this.buttonRectangles.Text = "Rectangles";
            this.buttonRectangles.UseVisualStyleBackColor = true;
            this.buttonRectangles.Click += new System.EventHandler(this.ButtonRectangles_Click);
            // 
            // buttonLines
            // 
            this.buttonLines.Location = new System.Drawing.Point(14, 22);
            this.buttonLines.Name = "buttonLines";
            this.buttonLines.Size = new System.Drawing.Size(91, 23);
            this.buttonLines.TabIndex = 0;
            this.buttonLines.Text = "Lines";
            this.buttonLines.UseVisualStyleBackColor = true;
            this.buttonLines.Click += new System.EventHandler(this.ButtonLines_Click);
            // 
            // panelPicBox
            // 
            this.panelPicBox.Controls.Add(this.pictureBoxDrawArea);
            this.panelPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicBox.Location = new System.Drawing.Point(200, 0);
            this.panelPicBox.Name = "panelPicBox";
            this.panelPicBox.Size = new System.Drawing.Size(649, 550);
            this.panelPicBox.TabIndex = 1;
            // 
            // pictureBoxDrawArea
            // 
            this.pictureBoxDrawArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxDrawArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDrawArea.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDrawArea.Name = "pictureBoxDrawArea";
            this.pictureBoxDrawArea.Size = new System.Drawing.Size(649, 550);
            this.pictureBoxDrawArea.TabIndex = 0;
            this.pictureBoxDrawArea.TabStop = false;
            this.pictureBoxDrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxDrawArea_Paint);
            this.pictureBoxDrawArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxDrawArea_MouseClick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(111, 22);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(76, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonPies
            // 
            this.buttonPies.Location = new System.Drawing.Point(14, 138);
            this.buttonPies.Name = "buttonPies";
            this.buttonPies.Size = new System.Drawing.Size(173, 23);
            this.buttonPies.TabIndex = 6;
            this.buttonPies.Text = "Pies";
            this.buttonPies.UseVisualStyleBackColor = true;
            this.buttonPies.Click += new System.EventHandler(this.ButtonPies_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 550);
            this.Controls.Add(this.panelPicBox);
            this.Controls.Add(this.panelBtns);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBtns.ResumeLayout(false);
            this.panelPicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Button buttonBrushes;
        private System.Windows.Forms.Button buttonElipses;
        private System.Windows.Forms.Button buttonRectangles;
        private System.Windows.Forms.Button buttonLines;
        private System.Windows.Forms.Panel panelPicBox;
        private System.Windows.Forms.PictureBox pictureBoxDrawArea;
        private System.Windows.Forms.ComboBox comboBoxPens;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPies;
    }
}

