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
    public partial class FormAddProduct : Form
    {
        public List<Category> Categories
        {
            set
            {
                comboBoxProductCategory.Items.AddRange(value.ToArray());
                if (comboBoxProductCategory.Items.Count > 0)
                    comboBoxProductCategory.SelectedIndex = 0;
            }
        }
        public List<Provider> Providers
        {
            set
            {
                comboBoxProductProvider.Items.AddRange(value.ToArray());
                if (comboBoxProductProvider.Items.Count > 0)
                    comboBoxProductProvider.SelectedIndex = 0;
            }
        }

        public string NewProductName { get => textBoxProductName.Text; }

        public decimal ProductValue { get => numericUpDownProductValue.Value; }

        public int ProductCount { get => (int)numericUpDownProductCount.Value; }

        public Category SelectedCategory { get => (Category)comboBoxProductCategory.SelectedItem; }

        public Provider SelectedProvider { get => (Provider)comboBoxProductProvider.SelectedItem; }

        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            numericUpDownProductValue.Maximum = numericUpDownProductCount.Maximum = decimal.MaxValue;
            comboBoxProductProvider.DisplayMember = comboBoxProductCategory.DisplayMember = "Name";
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxProductName.Text.Trim(' ')) && comboBoxProductCategory.SelectedIndex != -1 && comboBoxProductProvider.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
