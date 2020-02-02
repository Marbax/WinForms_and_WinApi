namespace winForms_timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClockImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCurTime = new System.Windows.Forms.Label();
            this.labelStaticAlarm = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSecond = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClockImg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxClockImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 135);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxClockImg
            // 
            this.pictureBoxClockImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxClockImg.Image = global::winForms_timer.Properties.Resources.index;
            this.pictureBoxClockImg.InitialImage = global::winForms_timer.Properties.Resources.index;
            this.pictureBoxClockImg.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxClockImg.Name = "pictureBoxClockImg";
            this.pictureBoxClockImg.Size = new System.Drawing.Size(141, 135);
            this.pictureBoxClockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClockImg.TabIndex = 0;
            this.pictureBoxClockImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownSecond);
            this.panel2.Controls.Add(this.numericUpDownMinute);
            this.panel2.Controls.Add(this.numericUpDownHour);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.buttonSet);
            this.panel2.Controls.Add(this.labelStaticAlarm);
            this.panel2.Controls.Add(this.labelCurTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(142, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 135);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelCurTime
            // 
            this.labelCurTime.AutoSize = true;
            this.labelCurTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurTime.Location = new System.Drawing.Point(28, 9);
            this.labelCurTime.Name = "labelCurTime";
            this.labelCurTime.Size = new System.Drawing.Size(124, 42);
            this.labelCurTime.TabIndex = 0;
            this.labelCurTime.Text = "label1";
            this.labelCurTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStaticAlarm
            // 
            this.labelStaticAlarm.AutoSize = true;
            this.labelStaticAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStaticAlarm.Location = new System.Drawing.Point(64, 51);
            this.labelStaticAlarm.Name = "labelStaticAlarm";
            this.labelStaticAlarm.Size = new System.Drawing.Size(91, 24);
            this.labelStaticAlarm.TabIndex = 1;
            this.labelStaticAlarm.Text = "Set Alarm";
            // 
            // buttonSet
            // 
            this.buttonSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSet.Location = new System.Drawing.Point(54, 100);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(57, 23);
            this.buttonSet.TabIndex = 3;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Location = new System.Drawing.Point(111, 100);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(57, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.Button1_Click);
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(54, 74);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownHour.TabIndex = 5;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(90, 74);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMinute.TabIndex = 6;
            // 
            // numericUpDownSecond
            // 
            this.numericUpDownSecond.Location = new System.Drawing.Point(128, 74);
            this.numericUpDownSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSecond.Name = "numericUpDownSecond";
            this.numericUpDownSecond.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownSecond.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 135);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ololo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClockImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClockImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCurTime;
        private System.Windows.Forms.Label labelStaticAlarm;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.NumericUpDown numericUpDownSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
    }
}

