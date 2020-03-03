namespace GoodsCatalog
{
    partial class FormAddProduct
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
            this.numericUpDownProductValue = new System.Windows.Forms.NumericUpDown();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.numericUpDownProductCount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxProductProvider = new System.Windows.Forms.ComboBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductValue = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.labelProductCategory = new System.Windows.Forms.Label();
            this.labelProductProvider = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownProductValue
            // 
            this.numericUpDownProductValue.Location = new System.Drawing.Point(11, 90);
            this.numericUpDownProductValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownProductValue.Name = "numericUpDownProductValue";
            this.numericUpDownProductValue.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownProductValue.TabIndex = 0;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(12, 31);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(160, 22);
            this.textBoxProductName.TabIndex = 1;
            // 
            // numericUpDownProductCount
            // 
            this.numericUpDownProductCount.Location = new System.Drawing.Point(12, 150);
            this.numericUpDownProductCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownProductCount.Name = "numericUpDownProductCount";
            this.numericUpDownProductCount.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownProductCount.TabIndex = 2;
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Location = new System.Drawing.Point(215, 29);
            this.comboBoxProductCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProductCategory.TabIndex = 3;
            // 
            // comboBoxProductProvider
            // 
            this.comboBoxProductProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductProvider.FormattingEnabled = true;
            this.comboBoxProductProvider.Location = new System.Drawing.Point(215, 90);
            this.comboBoxProductProvider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProductProvider.Name = "comboBoxProductProvider";
            this.comboBoxProductProvider.Size = new System.Drawing.Size(160, 24);
            this.comboBoxProductProvider.TabIndex = 4;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(8, 11);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(94, 16);
            this.labelProductName.TabIndex = 5;
            this.labelProductName.Text = "Product Name";
            // 
            // labelProductValue
            // 
            this.labelProductValue.AutoSize = true;
            this.labelProductValue.Location = new System.Drawing.Point(8, 70);
            this.labelProductValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductValue.Name = "labelProductValue";
            this.labelProductValue.Size = new System.Drawing.Size(92, 16);
            this.labelProductValue.TabIndex = 6;
            this.labelProductValue.Text = "Product Value";
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Location = new System.Drawing.Point(9, 130);
            this.labelProductCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(91, 16);
            this.labelProductCount.TabIndex = 7;
            this.labelProductCount.Text = "Product Count";
            // 
            // labelProductCategory
            // 
            this.labelProductCategory.AutoSize = true;
            this.labelProductCategory.Location = new System.Drawing.Point(212, 9);
            this.labelProductCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductCategory.Name = "labelProductCategory";
            this.labelProductCategory.Size = new System.Drawing.Size(112, 16);
            this.labelProductCategory.TabIndex = 8;
            this.labelProductCategory.Text = "Product Category";
            // 
            // labelProductProvider
            // 
            this.labelProductProvider.AutoSize = true;
            this.labelProductProvider.Location = new System.Drawing.Point(212, 70);
            this.labelProductProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductProvider.Name = "labelProductProvider";
            this.labelProductProvider.Size = new System.Drawing.Size(108, 16);
            this.labelProductProvider.TabIndex = 9;
            this.labelProductProvider.Text = "Product Provider";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(215, 149);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 10;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(300, 149);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 184);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelProductProvider);
            this.Controls.Add(this.labelProductCategory);
            this.Controls.Add(this.labelProductCount);
            this.Controls.Add(this.labelProductValue);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.comboBoxProductProvider);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.numericUpDownProductCount);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.numericUpDownProductValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownProductValue;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.NumericUpDown numericUpDownProductCount;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.ComboBox comboBoxProductProvider;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductValue;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.Label labelProductCategory;
        private System.Windows.Forms.Label labelProductProvider;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonCancel;
    }
}