namespace converter_of_temp
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTempFahrenh = new System.Windows.Forms.Label();
            this.textBoxTempFahrenh = new System.Windows.Forms.TextBox();
            this.textBoxTempCelsium = new System.Windows.Forms.TextBox();
            this.labelTempCelsium = new System.Windows.Forms.Label();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::converter_of_temp.Properties.Resources.term;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTempFahrenh
            // 
            this.labelTempFahrenh.AutoSize = true;
            this.labelTempFahrenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTempFahrenh.Location = new System.Drawing.Point(267, 22);
            this.labelTempFahrenh.Name = "labelTempFahrenh";
            this.labelTempFahrenh.Size = new System.Drawing.Size(215, 24);
            this.labelTempFahrenh.TabIndex = 1;
            this.labelTempFahrenh.Text = "Fahrenheit Temperature";
            // 
            // textBoxTempFahrenh
            // 
            this.textBoxTempFahrenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTempFahrenh.Location = new System.Drawing.Point(270, 53);
            this.textBoxTempFahrenh.Name = "textBoxTempFahrenh";
            this.textBoxTempFahrenh.Size = new System.Drawing.Size(191, 26);
            this.textBoxTempFahrenh.TabIndex = 2;
            // 
            // textBoxTempCelsium
            // 
            this.textBoxTempCelsium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTempCelsium.Location = new System.Drawing.Point(272, 120);
            this.textBoxTempCelsium.Name = "textBoxTempCelsium";
            this.textBoxTempCelsium.Size = new System.Drawing.Size(189, 26);
            this.textBoxTempCelsium.TabIndex = 4;
            // 
            // labelTempCelsium
            // 
            this.labelTempCelsium.AutoSize = true;
            this.labelTempCelsium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTempCelsium.Location = new System.Drawing.Point(269, 89);
            this.labelTempCelsium.Name = "labelTempCelsium";
            this.labelTempCelsium.Size = new System.Drawing.Size(192, 24);
            this.labelTempCelsium.TabIndex = 3;
            this.labelTempCelsium.Text = "Celsium Temperature";
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFtoC.Location = new System.Drawing.Point(526, 62);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(182, 28);
            this.radioButtonFtoC.TabIndex = 5;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "Farenh to Celsium";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            this.radioButtonFtoC.CheckedChanged += new System.EventHandler(this.RadioButtonFtoC_CheckedChanged);
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCtoF.Location = new System.Drawing.Point(526, 90);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(182, 28);
            this.radioButtonCtoF.TabIndex = 6;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "Celsium to Farenh";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            this.radioButtonCtoF.CheckedChanged += new System.EventHandler(this.RadioButtonCtoF_CheckedChanged);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(269, 172);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(192, 44);
            this.buttonCount.TabIndex = 7;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(467, 172);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(192, 44);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 228);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.radioButtonCtoF);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.textBoxTempCelsium);
            this.Controls.Add(this.labelTempCelsium);
            this.Controls.Add(this.textBoxTempFahrenh);
            this.Controls.Add(this.labelTempFahrenh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTempFahrenh;
        private System.Windows.Forms.TextBox textBoxTempFahrenh;
        private System.Windows.Forms.TextBox textBoxTempCelsium;
        private System.Windows.Forms.Label labelTempCelsium;
        private System.Windows.Forms.RadioButton radioButtonFtoC;
        private System.Windows.Forms.RadioButton radioButtonCtoF;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonReset;
    }
}

