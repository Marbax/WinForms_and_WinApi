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
    public partial class FormRemoveCategory : Form
    {
        private List<Category> _categories;

        public List<Category> Categories
        {
            set
            {
                _categories = value;
                listBoxCategories.Items.Clear();
                value.ForEach(i => listBoxCategories.Items.Add(i));
            }
        }

        private List<Category> _toRemoveCategories = new List<Category>();

        public List<Category> ToRemoveCategories
        {
            get { return _toRemoveCategories; }
        }


        public FormRemoveCategory()
        {
            InitializeComponent();
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            listBoxCategories.DisplayMember = "Name";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (Category item in listBoxCategories.SelectedItems)
            {
                _categories.Remove(item);
                _toRemoveCategories.Add(item);
            }
            Categories = _categories;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_toRemoveCategories.Count == 0)
                this.DialogResult = DialogResult.Cancel;
            else if (MessageBox.Show("There will be deleted products of that category too", "Ettention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
