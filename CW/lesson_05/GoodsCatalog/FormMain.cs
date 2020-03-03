using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsCatalog
{
    public partial class FormMain : Form
    {
        private DataManager _dm = new DataManager();

        public FormMain()
        {
            InitializeComponent();
            CustomInit();
        }
        private void CustomInit()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.numericUpDownProdValue.Maximum = decimal.MaxValue;
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.ValueMember = "Id";
            comboBoxProvider.DisplayMember = "Name";
            comboBoxProvider.ValueMember = "Id";
        }

        private void UpdateListViewGoods()
        {
            listViewGoods.Items.Clear();
            if (_dm.Products.Count() > 0)
            {
                List<Product> _sel_prods = _dm.Products.ToList();
                //_sel_prods = _dm.Products.Where(c => c.Category_Id == ((Category)comboBoxCategories.SelectedItem).Id).Where(p => p.Provider_Id == ((Provider)comboBoxProvider.SelectedItem).Id).Where(v => v.Value <= numericUpDownProdValue.Value).ToList<Product>();
                if (comboBoxCategories.SelectedIndex != 0)
                    _sel_prods = _dm.Products.Where(c => c.Category_Id == ((Category)comboBoxCategories.SelectedItem).Id).ToList<Product>();
                if (comboBoxProvider.SelectedIndex != 0)
                    _sel_prods = _sel_prods.Where(p => p.Provider_Id == ((Provider)comboBoxProvider.SelectedItem).Id).ToList<Product>();
                if (numericUpDownProdValue.Value != 0)
                    _sel_prods = _sel_prods.Where(v => v.Value <= numericUpDownProdValue.Value).ToList<Product>();

                foreach (Product item in _sel_prods)
                {
                    ListViewItem field = listViewGoods.Items.Add(item.Id.ToString());
                    field.SubItems.Add(item.Name);
                    field.SubItems.Add(_dm.Categories.FirstOrDefault(c => c.Id == item.Category_Id).Name);
                    field.SubItems.Add(_dm.Providers.FirstOrDefault(p => p.Id == item.Provider_Id).Name);
                    field.SubItems.Add(item.Value.ToString("F"));
                    field.SubItems.Add(item.Count.ToString());
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateComboBoxCategories();
            UpdateComboBoxProviders();
            UpdateListViewGoods();
        }

        private void UpdateComboBoxCategories()
        {
            comboBoxCategories.Items.Clear();

            comboBoxCategories.Items.Add("All Categories");
            comboBoxCategories.SelectedIndex = 0;
            if (_dm.Categories.Count() > 0)
            {
                foreach (Category item in _dm.Categories)
                {
                    comboBoxCategories.Items.Add(item);
                }
            }
        }

        private void UpdateComboBoxProviders()
        {
            comboBoxProvider.Items.Clear();

            comboBoxProvider.Items.Add("All Providers");
            comboBoxProvider.SelectedIndex = 0;
            if (_dm.Providers.Count() > 0)
            {
                foreach (Provider item in _dm.Providers)
                {
                    comboBoxProvider.Items.Add(item);
                }
            }
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            UpdateListViewGoods();
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            FormAddItem formAddItem = new FormAddItem() { Text = "Add new Category" };
            if (formAddItem.ShowDialog() == DialogResult.OK)
            {
                _dm.Categories.Add(new Category() { Name = formAddItem.ItemName });
                _dm.SaveChanges();
                UpdateComboBoxCategories();
                UpdateListViewGoods();
            }
        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            if (_dm.Categories.Count() > 0)
            {
                FormRemoveCategory fRC = new FormRemoveCategory() { Categories = _dm.Categories.ToList() };
                if (fRC.ShowDialog() == DialogResult.OK)
                {
                    int[] cat_ids = fRC.ToRemoveCategories.Select(c => c.Id).ToArray();

                    List<Product> _toRemoveProducts = _dm.Products.Where(p => cat_ids.Contains(p.Category_Id)).ToList();
                    _dm.Products.RemoveRange(_toRemoveProducts);

                    _dm.Categories.RemoveRange(fRC.ToRemoveCategories);
                    _dm.SaveChanges();
                    UpdateComboBoxCategories();
                    UpdateListViewGoods();
                }
            }
            else
                MessageBox.Show("There no Categories to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (_dm.Categories.Count() > 0)
            {
                if (_dm.Providers.Count() > 0)
                {
                    FormAddProduct fAP = new FormAddProduct() { Categories = _dm.Categories.ToList(), Providers = _dm.Providers.ToList() };
                    if (fAP.ShowDialog() == DialogResult.OK)
                    {
                        _dm.Products.Add(new Product() { Name = fAP.NewProductName, Value = fAP.ProductValue, Count = fAP.ProductCount, Category_Id = fAP.SelectedCategory.Id, Provider_Id = fAP.SelectedProvider.Id });
                        _dm.SaveChanges();
                        UpdateListViewGoods();
                    }
                }
                else
                    MessageBox.Show("There no Providers\nPlease add at least one provider", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("There no Categories\nPlease add at least one category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            FormAddItem formAddItem = new FormAddItem() { Text = "Add new Provider" };
            if (formAddItem.ShowDialog() == DialogResult.OK)
            {
                _dm.Providers.Add(new Provider() { Name = formAddItem.ItemName });
                _dm.SaveChanges();
                UpdateComboBoxProviders();
                UpdateListViewGoods();
            }
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            if (_dm.Products.Count() > 0)
            {
                FormRemoveProduct fRP = new FormRemoveProduct() { Products = _dm.Products.ToList() };
                if (fRP.ShowDialog() == DialogResult.OK)
                {
                    _dm.Products.RemoveRange(fRP.ToRemoveProducts);
                    _dm.SaveChanges();
                    UpdateListViewGoods();
                }
            }
            else
                MessageBox.Show("There no Products to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonRemoveProvider_Click(object sender, EventArgs e)
        {
            if (_dm.Providers.Count() > 0)
            {
                FormRemoveProvider fRP = new FormRemoveProvider() { Providers = _dm.Providers.ToList() };
                if (fRP.ShowDialog() == DialogResult.OK)
                {
                    int[] prov_ids = fRP.ToRemoveProviders.Select(c => c.Id).ToArray();

                    List<Product> _toRemoveProducts = _dm.Products.Where(p => prov_ids.Contains(p.Provider_Id)).ToList();
                    _dm.Products.RemoveRange(_toRemoveProducts);

                    _dm.Providers.RemoveRange(fRP.ToRemoveProviders);
                    _dm.SaveChanges();
                    UpdateComboBoxProviders();
                    UpdateListViewGoods();
                }
            }
            else
                MessageBox.Show("There no Providers to remove", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
