namespace timer_v2
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
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSetTimer = new System.Windows.Forms.Label();
            this.numericUpDownMiliSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.progressBarTimeLeft = new System.Windows.Forms.ProgressBar();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.panelTopTime = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSetTimer = new System.Windows.Forms.Button();
            this.buttonResetTimer = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiliSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            this.panelTopTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(59, 25);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time";
            // 
            // labelSetTimer
            // 
            this.labelSetTimer.AutoSize = true;
            this.labelSetTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSetTimer.Location = new System.Drawing.Point(170, 91);
            this.labelSetTimer.Name = "labelSetTimer";
            this.labelSetTimer.Size = new System.Drawing.Size(83, 24);
            this.labelSetTimer.TabIndex = 1;
            this.labelSetTimer.Text = "Set timer";
            // 
            // numericUpDownMiliSeconds
            // 
            this.numericUpDownMiliSeconds.Location = new System.Drawing.Point(234, 118);
            this.numericUpDownMiliSeconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownMiliSeconds.Name = "numericUpDownMiliSeconds";
            this.numericUpDownMiliSeconds.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownMiliSeconds.TabIndex = 2;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(150, 118);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownMinutes.TabIndex = 3;
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.Location = new System.Drawing.Point(192, 118);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownSeconds.TabIndex = 4;
            // 
            // progressBarTimeLeft
            // 
            this.progressBarTimeLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarTimeLeft.Location = new System.Drawing.Point(0, 144);
            this.progressBarTimeLeft.Name = "progressBarTimeLeft";
            this.progressBarTimeLeft.Size = new System.Drawing.Size(426, 23);
            this.progressBarTimeLeft.TabIndex = 5;
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeLeft.Location = new System.Drawing.Point(330, 0);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(96, 25);
            this.labelTimeLeft.TabIndex = 6;
            this.labelTimeLeft.Text = "00:00:00";
            // 
            // panelTopTime
            // 
            this.panelTopTime.Controls.Add(this.labelTime);
            this.panelTopTime.Controls.Add(this.labelTimeLeft);
            this.panelTopTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTime.Location = new System.Drawing.Point(0, 0);
            this.panelTopTime.Name = "panelTopTime";
            this.panelTopTime.Size = new System.Drawing.Size(426, 67);
            this.panelTopTime.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // buttonSetTimer
            // 
            this.buttonSetTimer.Location = new System.Drawing.Point(69, 115);
            this.buttonSetTimer.Name = "buttonSetTimer";
            this.buttonSetTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTimer.TabIndex = 8;
            this.buttonSetTimer.Text = "Set Timer";
            this.buttonSetTimer.UseVisualStyleBackColor = true;
            this.buttonSetTimer.Click += new System.EventHandler(this.ButtonSetTimer_Click);
            // 
            // buttonResetTimer
            // 
            this.buttonResetTimer.Location = new System.Drawing.Point(276, 115);
            this.buttonResetTimer.Name = "buttonResetTimer";
            this.buttonResetTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonResetTimer.TabIndex = 9;
            this.buttonResetTimer.Text = "Reset Timer";
            this.buttonResetTimer.UseVisualStyleBackColor = true;
            this.buttonResetTimer.Click += new System.EventHandler(this.ButtonResetTimer_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(234, 73);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "Stop Timer";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(128, 73);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 11;
            this.buttonContinue.Text = "Continue Timer";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 167);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonResetTimer);
            this.Controls.Add(this.buttonSetTimer);
            this.Controls.Add(this.panelTopTime);
            this.Controls.Add(this.progressBarTimeLeft);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.numericUpDownMiliSeconds);
            this.Controls.Add(this.labelSetTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiliSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            this.panelTopTime.ResumeLayout(false);
            this.panelTopTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSetTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownMiliSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.ProgressBar progressBarTimeLeft;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.Panel panelTopTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSetTimer;
        private System.Windows.Forms.Button buttonResetTimer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonContinue;
    }
}

