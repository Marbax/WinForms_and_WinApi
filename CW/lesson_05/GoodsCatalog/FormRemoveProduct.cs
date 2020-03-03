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
    public partial class FormRemoveProduct : Form
    {
        private List<Product> _products;

        public List<Product> Products
        {
            set
            {
                _products = value;
                listBoxProducts.Items.Clear();
                listBoxProducts.Items.AddRange(value.ToArray());
            }
        }

        private List<Product> _toRemoveProducts = new List<Product>();

        public List<Product> ToRemoveProducts
        {
            get { return _toRemoveProducts; }
        }


        public FormRemoveProduct()
        {
            InitializeComponent();
        }

        private void FormRemoveProduct_Load(object sender, EventArgs e)
        {
            listBoxProducts.DisplayMember = "Name";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (Product item in listBoxProducts.SelectedItems)
            {
                _products.Remove(item);
                _toRemoveProducts.Add(item);
            }
            Products = _products;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
