namespace image_viewer
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.buttonLoadanImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxChoosenPicture = new System.Windows.Forms.PictureBox();
            this.buttonPreveous = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonFlush = new System.Windows.Forms.Button();
            this.numericUpDownIntervalChange = new System.Windows.Forms.NumericUpDown();
            this.timerPicTick = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoosenPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalChange)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBoxImages);
            this.panel1.Controls.Add(this.buttonLoadanImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 687);
            this.panel1.TabIndex = 0;
            // 
            // listBoxImages
            // 
            this.listBoxImages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 20;
            this.listBoxImages.Location = new System.Drawing.Point(0, 81);
            this.listBoxImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(324, 604);
            this.listBoxImages.TabIndex = 1;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.ListBoxImages_SelectedIndexChanged);
            // 
            // buttonLoadanImage
            // 
            this.buttonLoadanImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoadanImage.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadanImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoadanImage.Name = "buttonLoadanImage";
            this.buttonLoadanImage.Size = new System.Drawing.Size(324, 74);
            this.buttonLoadanImage.TabIndex = 0;
            this.buttonLoadanImage.Text = "Load an Image";
            this.buttonLoadanImage.UseVisualStyleBackColor = true;
            this.buttonLoadanImage.Click += new System.EventHandler(this.ButtonLoadanImage_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numericUpDownIntervalChange);
            this.panel2.Controls.Add(this.buttonFlush);
            this.panel2.Controls.Add(this.buttonStop);
            this.panel2.Controls.Add(this.buttonStart);
            this.panel2.Controls.Add(this.buttonNext);
            this.panel2.Controls.Add(this.buttonPreveous);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(326, 631);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 56);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBoxChoosenPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(326, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(881, 631);
            this.panel3.TabIndex = 2;
            // 
            // pictureBoxChoosenPicture
            // 
            this.pictureBoxChoosenPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxChoosenPicture.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxChoosenPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxChoosenPicture.Name = "pictureBoxChoosenPicture";
            this.pictureBoxChoosenPicture.Size = new System.Drawing.Size(879, 629);
            this.pictureBoxChoosenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChoosenPicture.TabIndex = 0;
            this.pictureBoxChoosenPicture.TabStop = false;
            // 
            // buttonPreveous
            // 
            this.buttonPreveous.Location = new System.Drawing.Point(20, 4);
            this.buttonPreveous.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPreveous.Name = "buttonPreveous";
            this.buttonPreveous.Size = new System.Drawing.Size(112, 35);
            this.buttonPreveous.TabIndex = 0;
            this.buttonPreveous.Text = "Preveous <<";
            this.buttonPreveous.UseVisualStyleBackColor = true;
            this.buttonPreveous.Click += new System.EventHandler(this.ButtonPreveous_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(135, 4);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 35);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">> Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(314, 5);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 35);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(430, 4);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 35);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonFlush
            // 
            this.buttonFlush.Location = new System.Drawing.Point(579, 4);
            this.buttonFlush.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFlush.Name = "buttonFlush";
            this.buttonFlush.Size = new System.Drawing.Size(112, 35);
            this.buttonFlush.TabIndex = 4;
            this.buttonFlush.Text = "Flush";
            this.buttonFlush.UseVisualStyleBackColor = true;
            this.buttonFlush.Click += new System.EventHandler(this.ButtonFlush_Click);
            // 
            // numericUpDownIntervalChange
            // 
            this.numericUpDownIntervalChange.Location = new System.Drawing.Point(727, 9);
            this.numericUpDownIntervalChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownIntervalChange.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIntervalChange.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownIntervalChange.Name = "numericUpDownIntervalChange";
            this.numericUpDownIntervalChange.Size = new System.Drawing.Size(80, 26);
            this.numericUpDownIntervalChange.TabIndex = 5;
            this.numericUpDownIntervalChange.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownIntervalChange.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // timerPicTick
            // 
            this.timerPicTick.Interval = 2000;
            this.timerPicTick.Tick += new System.EventHandler(this.TimerPicTick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 687);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChoosenPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button buttonLoadanImage;
        private System.Windows.Forms.PictureBox pictureBoxChoosenPicture;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalChange;
        private System.Windows.Forms.Button buttonFlush;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPreveous;
        private System.Windows.Forms.Timer timerPicTick;
    }
}

