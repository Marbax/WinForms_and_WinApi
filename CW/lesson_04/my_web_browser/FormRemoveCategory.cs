using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace my_web_browser
{
    public partial class FormRemoveCategory : Form
    {
        private List<Category> _categories = new List<Category>();

        public List<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }


        private List<Category> _toRemoveCat = new List<Category>();

        public List<Category> ToRemoveCat
        {
            get { return _toRemoveCat; }
            set { _toRemoveCat = value; }
        }

        public FormRemoveCategory()
        {
            InitializeComponent();
        }

        private void ListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRemoveCategory_Load(object sender, EventArgs e)
        {
            UpdateListBoxCat();
            listBoxCategories.DisplayMember = "Name";
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            foreach (Category item in listBoxCategories.SelectedItems)
            {
                Categories.Remove(item);
                ToRemoveCat.Add(item);
            }
            listBoxCategories.Items.Clear();
            UpdateListBoxCat();
        }
        private void UpdateListBoxCat()
        {
            foreach (var item in Categories)
            {
                listBoxCategories.Items.Add(item);
            }

            if (listBoxCategories.Items.Count > 0)
                listBoxCategories.SelectedIndex = 0;
        }

        private void ButtonSaveAndCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
