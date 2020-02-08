namespace statistic_calc
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
            this.listBoxCollection = new System.Windows.Forms.ListBox();
            this.labelLegend = new System.Windows.Forms.Label();
            this.textBoxLegend = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonAddtoList = new System.Windows.Forms.Button();
            this.buttonRemovefromList = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxCollection
            // 
            this.listBoxCollection.FormattingEnabled = true;
            this.listBoxCollection.Location = new System.Drawing.Point(4, 82);
            this.listBoxCollection.Name = "listBoxCollection";
            this.listBoxCollection.Size = new System.Drawing.Size(202, 238);
            this.listBoxCollection.TabIndex = 0;
            // 
            // labelLegend
            // 
            this.labelLegend.AutoSize = true;
            this.labelLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLegend.Location = new System.Drawing.Point(4, 9);
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(63, 20);
            this.labelLegend.TabIndex = 1;
            this.labelLegend.Text = "Legend";
            // 
            // textBoxLegend
            // 
            this.textBoxLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLegend.Location = new System.Drawing.Point(73, 9);
            this.textBoxLegend.Name = "textBoxLegend";
            this.textBoxLegend.Size = new System.Drawing.Size(133, 26);
            this.textBoxLegend.TabIndex = 2;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(73, 41);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(133, 26);
            this.textBoxResult.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(4, 41);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 20);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Result";
            // 
            // buttonAddtoList
            // 
            this.buttonAddtoList.Location = new System.Drawing.Point(233, 35);
            this.buttonAddtoList.Name = "buttonAddtoList";
            this.buttonAddtoList.Size = new System.Drawing.Size(158, 26);
            this.buttonAddtoList.TabIndex = 5;
            this.buttonAddtoList.Text = "Add to List";
            this.buttonAddtoList.UseVisualStyleBackColor = true;
            this.buttonAddtoList.Click += new System.EventHandler(this.ButtonAddtoList_Click);
            // 
            // buttonRemovefromList
            // 
            this.buttonRemovefromList.Location = new System.Drawing.Point(233, 65);
            this.buttonRemovefromList.Name = "buttonRemovefromList";
            this.buttonRemovefromList.Size = new System.Drawing.Size(158, 26);
            this.buttonRemovefromList.TabIndex = 6;
            this.buttonRemovefromList.Text = "Remove item from List";
            this.buttonRemovefromList.UseVisualStyleBackColor = true;
            this.buttonRemovefromList.Click += new System.EventHandler(this.ButtonRemovefromList_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(233, 155);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(158, 26);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(233, 125);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(158, 26);
            this.buttonClearList.TabIndex = 8;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(233, 95);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(158, 26);
            this.buttonClearFields.TabIndex = 9;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReport.Location = new System.Drawing.Point(210, 187);
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(204, 133);
            this.textBoxReport.TabIndex = 11;
            this.textBoxReport.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 323);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonRemovefromList);
            this.Controls.Add(this.buttonAddtoList);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxLegend);
            this.Controls.Add(this.labelLegend);
            this.Controls.Add(this.listBoxCollection);
            this.Name = "Form1";
            this.Text = "Statistic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCollection;
        private System.Windows.Forms.Label labelLegend;
        private System.Windows.Forms.TextBox textBoxLegend;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonAddtoList;
        private System.Windows.Forms.Button buttonRemovefromList;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.RichTextBox textBoxReport;
    }
}

