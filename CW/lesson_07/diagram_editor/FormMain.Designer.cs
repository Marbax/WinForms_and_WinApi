namespace diagram_editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelDataInput = new System.Windows.Forms.Panel();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listViewRecords = new System.Windows.Forms.ListView();
            this.Legend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxLegend = new System.Windows.Forms.TextBox();
            this.labelLegend = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.richTextBoxStat = new System.Windows.Forms.RichTextBox();
            this.panelPicBoxes = new System.Windows.Forms.Panel();
            this.pictureBoxPieChart = new System.Windows.Forms.PictureBox();
            this.pictureBoxShema = new System.Windows.Forms.PictureBox();
            this.pictureBoxBarChart = new System.Windows.Forms.PictureBox();
            this.panelBottomBtns = new System.Windows.Forms.Panel();
            this.panelDataInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.panelStatistic.SuspendLayout();
            this.panelPicBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarChart)).BeginInit();
            this.panelBottomBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataInput
            // 
            this.panelDataInput.Controls.Add(this.panelBottomBtns);
            this.panelDataInput.Controls.Add(this.numericUpDownValue);
            this.panelDataInput.Controls.Add(this.listViewRecords);
            this.panelDataInput.Controls.Add(this.buttonAdd);
            this.panelDataInput.Controls.Add(this.textBoxLegend);
            this.panelDataInput.Controls.Add(this.labelLegend);
            this.panelDataInput.Controls.Add(this.labelValue);
            this.panelDataInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDataInput.Location = new System.Drawing.Point(0, 0);
            this.panelDataInput.Name = "panelDataInput";
            this.panelDataInput.Size = new System.Drawing.Size(200, 561);
            this.panelDataInput.TabIndex = 0;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.DecimalPlaces = 3;
            this.numericUpDownValue.Location = new System.Drawing.Point(82, 13);
            this.numericUpDownValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownValue.TabIndex = 9;
            this.numericUpDownValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(16, 70);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(166, 23);
            this.buttonBuild.TabIndex = 8;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.ButtonBuild_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(17, 41);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(166, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(17, 12);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(166, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // listViewRecords
            // 
            this.listViewRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Legend,
            this.Value});
            this.listViewRecords.HideSelection = false;
            this.listViewRecords.Location = new System.Drawing.Point(3, 129);
            this.listViewRecords.MultiSelect = false;
            this.listViewRecords.Name = "listViewRecords";
            this.listViewRecords.Size = new System.Drawing.Size(194, 319);
            this.listViewRecords.TabIndex = 5;
            this.listViewRecords.UseCompatibleStateImageBehavior = false;
            this.listViewRecords.View = System.Windows.Forms.View.Details;
            // 
            // Legend
            // 
            this.Legend.Text = "Legend";
            this.Legend.Width = 91;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 96;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 89);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(166, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxLegend
            // 
            this.textBoxLegend.Location = new System.Drawing.Point(82, 52);
            this.textBoxLegend.Name = "textBoxLegend";
            this.textBoxLegend.Size = new System.Drawing.Size(100, 22);
            this.textBoxLegend.TabIndex = 3;
            // 
            // labelLegend
            // 
            this.labelLegend.AutoSize = true;
            this.labelLegend.Location = new System.Drawing.Point(13, 52);
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(57, 16);
            this.labelLegend.TabIndex = 2;
            this.labelLegend.Text = "Legend:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(13, 13);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(46, 16);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "Value:";
            // 
            // panelStatistic
            // 
            this.panelStatistic.Controls.Add(this.richTextBoxStat);
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelStatistic.Location = new System.Drawing.Point(644, 0);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(200, 561);
            this.panelStatistic.TabIndex = 1;
            // 
            // richTextBoxStat
            // 
            this.richTextBoxStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStat.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxStat.Name = "richTextBoxStat";
            this.richTextBoxStat.Size = new System.Drawing.Size(200, 561);
            this.richTextBoxStat.TabIndex = 0;
            this.richTextBoxStat.Text = "";
            // 
            // panelPicBoxes
            // 
            this.panelPicBoxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPicBoxes.Controls.Add(this.pictureBoxPieChart);
            this.panelPicBoxes.Controls.Add(this.pictureBoxShema);
            this.panelPicBoxes.Controls.Add(this.pictureBoxBarChart);
            this.panelPicBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicBoxes.Location = new System.Drawing.Point(200, 0);
            this.panelPicBoxes.Name = "panelPicBoxes";
            this.panelPicBoxes.Size = new System.Drawing.Size(444, 561);
            this.panelPicBoxes.TabIndex = 2;
            // 
            // pictureBoxPieChart
            // 
            this.pictureBoxPieChart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxPieChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPieChart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPieChart.ErrorImage = null;
            this.pictureBoxPieChart.InitialImage = null;
            this.pictureBoxPieChart.Location = new System.Drawing.Point(168, 266);
            this.pictureBoxPieChart.Name = "pictureBoxPieChart";
            this.pictureBoxPieChart.Size = new System.Drawing.Size(272, 291);
            this.pictureBoxPieChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPieChart.TabIndex = 2;
            this.pictureBoxPieChart.TabStop = false;
            this.pictureBoxPieChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPieChart_Paint);
            // 
            // pictureBoxShema
            // 
            this.pictureBoxShema.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxShema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxShema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxShema.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxShema.ErrorImage = null;
            this.pictureBoxShema.InitialImage = null;
            this.pictureBoxShema.Location = new System.Drawing.Point(0, 266);
            this.pictureBoxShema.Name = "pictureBoxShema";
            this.pictureBoxShema.Size = new System.Drawing.Size(168, 291);
            this.pictureBoxShema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShema.TabIndex = 1;
            this.pictureBoxShema.TabStop = false;
            this.pictureBoxShema.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxShema_Paint);
            // 
            // pictureBoxBarChart
            // 
            this.pictureBoxBarChart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxBarChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBarChart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBarChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxBarChart.ErrorImage = null;
            this.pictureBoxBarChart.InitialImage = null;
            this.pictureBoxBarChart.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBarChart.Name = "pictureBoxBarChart";
            this.pictureBoxBarChart.Size = new System.Drawing.Size(440, 266);
            this.pictureBoxBarChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBarChart.TabIndex = 0;
            this.pictureBoxBarChart.TabStop = false;
            this.pictureBoxBarChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxBarChart_Paint);
            // 
            // panelBottomBtns
            // 
            this.panelBottomBtns.Controls.Add(this.buttonRemove);
            this.panelBottomBtns.Controls.Add(this.buttonClear);
            this.panelBottomBtns.Controls.Add(this.buttonBuild);
            this.panelBottomBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBtns.Location = new System.Drawing.Point(0, 461);
            this.panelBottomBtns.Name = "panelBottomBtns";
            this.panelBottomBtns.Size = new System.Drawing.Size(200, 100);
            this.panelBottomBtns.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.panelPicBoxes);
            this.Controls.Add(this.panelStatistic);
            this.Controls.Add(this.panelDataInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "Diagram Editor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.panelDataInput.ResumeLayout(false);
            this.panelDataInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.panelStatistic.ResumeLayout(false);
            this.panelPicBoxes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarChart)).EndInit();
            this.panelBottomBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataInput;
        private System.Windows.Forms.TextBox textBoxLegend;
        private System.Windows.Forms.Label labelLegend;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.RichTextBox richTextBoxStat;
        private System.Windows.Forms.Panel panelPicBoxes;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListView listViewRecords;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Legend;
        private System.Windows.Forms.PictureBox pictureBoxBarChart;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
        private System.Windows.Forms.PictureBox pictureBoxPieChart;
        private System.Windows.Forms.PictureBox pictureBoxShema;
        private System.Windows.Forms.Panel panelBottomBtns;
    }
}

