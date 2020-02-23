namespace GoodsCatalog
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxGoodsList = new System.Windows.Forms.GroupBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listViewGoods = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provider = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonAddProvider = new System.Windows.Forms.Button();
            this.buttonRemoveProvider = new System.Windows.Forms.Button();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxGoodsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelHeader);
            this.panelInfo.Controls.Add(this.pictureBoxLogo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(862, 55);
            this.panelInfo.TabIndex = 0;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.buttonSelect);
            this.groupBoxFilters.Controls.Add(this.numericUpDown1);
            this.groupBoxFilters.Controls.Add(this.labelValue);
            this.groupBoxFilters.Controls.Add(this.comboBoxProvider);
            this.groupBoxFilters.Controls.Add(this.labelProvider);
            this.groupBoxFilters.Controls.Add(this.comboBoxCategories);
            this.groupBoxFilters.Controls.Add(this.labelCategory);
            this.groupBoxFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilters.Location = new System.Drawing.Point(0, 55);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(862, 74);
            this.groupBoxFilters.TabIndex = 1;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonRemoveProduct);
            this.groupBoxControls.Controls.Add(this.buttonAddProduct);
            this.groupBoxControls.Controls.Add(this.buttonRemoveProvider);
            this.groupBoxControls.Controls.Add(this.buttonAddProvider);
            this.groupBoxControls.Controls.Add(this.buttonRemoveCategory);
            this.groupBoxControls.Controls.Add(this.buttonAddCategory);
            this.groupBoxControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxControls.Location = new System.Drawing.Point(0, 379);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(862, 100);
            this.groupBoxControls.TabIndex = 2;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Operations";
            // 
            // groupBoxGoodsList
            // 
            this.groupBoxGoodsList.Controls.Add(this.listViewGoods);
            this.groupBoxGoodsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGoodsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGoodsList.Location = new System.Drawing.Point(0, 129);
            this.groupBoxGoodsList.Name = "groupBoxGoodsList";
            this.groupBoxGoodsList.Size = new System.Drawing.Size(862, 250);
            this.groupBoxGoodsList.TabIndex = 3;
            this.groupBoxGoodsList.TabStop = false;
            this.groupBoxGoodsList.Text = "Goods list";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = global::GoodsCatalog.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(177, 55);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.LightSalmon;
            this.labelHeader.Location = new System.Drawing.Point(244, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(340, 31);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Authomatizated Goods List";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(13, 30);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(77, 20);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "Category:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(116, 30);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCategories.TabIndex = 1;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(335, 30);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(121, 28);
            this.comboBoxProvider.TabIndex = 3;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(259, 33);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(70, 20);
            this.labelProvider.TabIndex = 2;
            this.labelProvider.Text = "Provider:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(500, 33);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(54, 20);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "Value:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(580, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 5;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(734, 29);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(77, 29);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // listViewGoods
            // 
            this.listViewGoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ProductName,
            this.Category,
            this.Provider,
            this.Value,
            this.Count});
            this.listViewGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewGoods.Location = new System.Drawing.Point(3, 22);
            this.listViewGoods.Name = "listViewGoods";
            this.listViewGoods.Size = new System.Drawing.Size(856, 225);
            this.listViewGoods.TabIndex = 0;
            this.listViewGoods.UseCompatibleStateImageBehavior = false;
            this.listViewGoods.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 200;
            // 
            // Provider
            // 
            this.Provider.Text = "Provider";
            this.Provider.Width = 200;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 100;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 100;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 150;
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(295, 25);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(145, 33);
            this.buttonAddCategory.TabIndex = 0;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Location = new System.Drawing.Point(295, 61);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(145, 33);
            this.buttonRemoveCategory.TabIndex = 1;
            this.buttonRemoveCategory.Text = "Remove Category";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // buttonAddProvider
            // 
            this.buttonAddProvider.Location = new System.Drawing.Point(485, 25);
            this.buttonAddProvider.Name = "buttonAddProvider";
            this.buttonAddProvider.Size = new System.Drawing.Size(145, 33);
            this.buttonAddProvider.TabIndex = 2;
            this.buttonAddProvider.Text = "Add Provider";
            this.buttonAddProvider.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveProvider
            // 
            this.buttonRemoveProvider.Location = new System.Drawing.Point(485, 61);
            this.buttonRemoveProvider.Name = "buttonRemoveProvider";
            this.buttonRemoveProvider.Size = new System.Drawing.Size(145, 33);
            this.buttonRemoveProvider.TabIndex = 3;
            this.buttonRemoveProvider.Text = "Remove Provider";
            this.buttonRemoveProvider.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(98, 61);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(145, 33);
            this.buttonRemoveProduct.TabIndex = 5;
            this.buttonRemoveProduct.Text = "Remove Product";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(98, 25);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(145, 33);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.groupBoxGoodsList);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.panelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Goods Catalog";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxGoodsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.GroupBox groupBoxGoodsList;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonRemoveProvider;
        private System.Windows.Forms.Button buttonAddProvider;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.ListView listViewGoods;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Provider;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Button buttonAddProduct;
    }
}

