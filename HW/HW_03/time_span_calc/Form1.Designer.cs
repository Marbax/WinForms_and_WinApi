namespace time_span_calc
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
            this.buttonShowInfo = new System.Windows.Forms.Button();
            this.radioButtonSeconds = new System.Windows.Forms.RadioButton();
            this.radioButtonMinutes = new System.Windows.Forms.RadioButton();
            this.radioButtonDays = new System.Windows.Forms.RadioButton();
            this.radioButtonMonths = new System.Windows.Forms.RadioButton();
            this.radioButtonYears = new System.Windows.Forms.RadioButton();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelPeekDate = new System.Windows.Forms.Label();
            this.textBoxInputEndDate = new System.Windows.Forms.TextBox();
            this.labelInputDate = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.timerChekAndRun = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonShowInfo
            // 
            this.buttonShowInfo.Location = new System.Drawing.Point(491, -1);
            this.buttonShowInfo.Name = "buttonShowInfo";
            this.buttonShowInfo.Size = new System.Drawing.Size(26, 24);
            this.buttonShowInfo.TabIndex = 7;
            this.buttonShowInfo.Text = "?";
            this.buttonShowInfo.UseVisualStyleBackColor = true;
            this.buttonShowInfo.Click += new System.EventHandler(this.buttonShowInfo_Click);
            // 
            // radioButtonSeconds
            // 
            this.radioButtonSeconds.AutoSize = true;
            this.radioButtonSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSeconds.Location = new System.Drawing.Point(349, 116);
            this.radioButtonSeconds.Name = "radioButtonSeconds";
            this.radioButtonSeconds.Size = new System.Drawing.Size(167, 24);
            this.radioButtonSeconds.TabIndex = 4;
            this.radioButtonSeconds.TabStop = true;
            this.radioButtonSeconds.Text = "Convert to Seconds";
            this.radioButtonSeconds.UseVisualStyleBackColor = true;
            this.radioButtonSeconds.CheckedChanged += new System.EventHandler(this.radioButtonSeconds_CheckedChanged);
            // 
            // radioButtonMinutes
            // 
            this.radioButtonMinutes.AutoSize = true;
            this.radioButtonMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMinutes.Location = new System.Drawing.Point(349, 93);
            this.radioButtonMinutes.Name = "radioButtonMinutes";
            this.radioButtonMinutes.Size = new System.Drawing.Size(160, 24);
            this.radioButtonMinutes.TabIndex = 3;
            this.radioButtonMinutes.TabStop = true;
            this.radioButtonMinutes.Text = "Convert to Minutes";
            this.radioButtonMinutes.UseVisualStyleBackColor = true;
            this.radioButtonMinutes.CheckedChanged += new System.EventHandler(this.radioButtonMinutes_CheckedChanged);
            // 
            // radioButtonDays
            // 
            this.radioButtonDays.AutoSize = true;
            this.radioButtonDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDays.Location = new System.Drawing.Point(349, 70);
            this.radioButtonDays.Name = "radioButtonDays";
            this.radioButtonDays.Size = new System.Drawing.Size(140, 24);
            this.radioButtonDays.TabIndex = 2;
            this.radioButtonDays.TabStop = true;
            this.radioButtonDays.Text = "Convert to Days";
            this.radioButtonDays.UseVisualStyleBackColor = true;
            this.radioButtonDays.CheckedChanged += new System.EventHandler(this.radioButtonDays_CheckedChanged);
            // 
            // radioButtonMonths
            // 
            this.radioButtonMonths.AutoSize = true;
            this.radioButtonMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMonths.Location = new System.Drawing.Point(349, 47);
            this.radioButtonMonths.Name = "radioButtonMonths";
            this.radioButtonMonths.Size = new System.Drawing.Size(152, 24);
            this.radioButtonMonths.TabIndex = 1;
            this.radioButtonMonths.TabStop = true;
            this.radioButtonMonths.Text = "Conver to Months";
            this.radioButtonMonths.UseVisualStyleBackColor = true;
            this.radioButtonMonths.CheckedChanged += new System.EventHandler(this.radioButtonMonthes_CheckedChanged);
            // 
            // radioButtonYears
            // 
            this.radioButtonYears.AutoSize = true;
            this.radioButtonYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYears.Location = new System.Drawing.Point(349, 24);
            this.radioButtonYears.Name = "radioButtonYears";
            this.radioButtonYears.Size = new System.Drawing.Size(146, 24);
            this.radioButtonYears.TabIndex = 0;
            this.radioButtonYears.TabStop = true;
            this.radioButtonYears.Text = "Convert to Years";
            this.radioButtonYears.UseVisualStyleBackColor = true;
            this.radioButtonYears.CheckedChanged += new System.EventHandler(this.radioButtonYears_CheckedChanged);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(13, 23);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(311, 26);
            this.dateTimePickerEndDate.TabIndex = 1;
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(13, 129);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(311, 26);
            this.textBoxResult.TabIndex = 2;
            // 
            // labelPeekDate
            // 
            this.labelPeekDate.AutoSize = true;
            this.labelPeekDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeekDate.Location = new System.Drawing.Point(12, 0);
            this.labelPeekDate.Name = "labelPeekDate";
            this.labelPeekDate.Size = new System.Drawing.Size(115, 20);
            this.labelPeekDate.TabIndex = 3;
            this.labelPeekDate.Text = "Peek end Date";
            // 
            // textBoxInputEndDate
            // 
            this.textBoxInputEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputEndDate.Location = new System.Drawing.Point(13, 73);
            this.textBoxInputEndDate.Name = "textBoxInputEndDate";
            this.textBoxInputEndDate.Size = new System.Drawing.Size(311, 26);
            this.textBoxInputEndDate.TabIndex = 4;
            this.textBoxInputEndDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelInputDate
            // 
            this.labelInputDate.AutoSize = true;
            this.labelInputDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputDate.Location = new System.Drawing.Point(12, 52);
            this.labelInputDate.Name = "labelInputDate";
            this.labelInputDate.Size = new System.Drawing.Size(135, 20);
            this.labelInputDate.TabIndex = 5;
            this.labelInputDate.Text = "Or input end Date";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(135, 105);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            // 
            // timerChekAndRun
            // 
            this.timerChekAndRun.Tick += new System.EventHandler(this.timerChekAndRun_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 156);
            this.Controls.Add(this.buttonShowInfo);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.radioButtonSeconds);
            this.Controls.Add(this.labelInputDate);
            this.Controls.Add(this.radioButtonMinutes);
            this.Controls.Add(this.textBoxInputEndDate);
            this.Controls.Add(this.radioButtonDays);
            this.Controls.Add(this.labelPeekDate);
            this.Controls.Add(this.radioButtonMonths);
            this.Controls.Add(this.radioButtonYears);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonYears;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.RadioButton radioButtonSeconds;
        private System.Windows.Forms.RadioButton radioButtonMinutes;
        private System.Windows.Forms.RadioButton radioButtonDays;
        private System.Windows.Forms.RadioButton radioButtonMonths;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelPeekDate;
        private System.Windows.Forms.TextBox textBoxInputEndDate;
        private System.Windows.Forms.Label labelInputDate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonShowInfo;
        private System.Windows.Forms.Timer timerChekAndRun;
    }
}

