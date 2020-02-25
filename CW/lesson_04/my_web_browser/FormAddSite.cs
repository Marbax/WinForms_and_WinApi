using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_web_browser
{
    public partial class FormAddSite : Form
    {
        public string SiteName { get => textBoxSiteName.Text; set => textBoxSiteName.Text = value; }

        public string SiteUrl { get => textBoxSiteURL.Text; set => textBoxSiteURL.Text = value; }

        public List<Category> Categories
        {
            set
            {
                comboBoxCategories.Items.Clear();
                value.ForEach(c => comboBoxCategories.Items.Add(c));
            }
        }

        public int SelectedCategory { get => ((Category)comboBoxCategories.SelectedItem).Id; }

        public FormAddSite()
        {
            InitializeComponent();
        }

        private void FormAddSite_Load(object sender, EventArgs e)
        {
            textBoxSiteURL.Text = SiteUrl;

            if (string.IsNullOrEmpty(SiteName))
                textBoxSiteName.Text = "Enter name there";

            if (comboBoxCategories.Items.Count > 0)
                comboBoxCategories.SelectedIndex = 0;

            comboBoxCategories.DisplayMember = "Name";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSiteName.Text.Trim(' ')) && !string.IsNullOrEmpty(textBoxSiteURL.Text.Trim(' ')) && comboBoxCategories.SelectedIndex != -1)
                this.DialogResult = DialogResult.OK;
        }

        private void ButtonRefuse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
