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
        public string SiteName { get; set; }

        public string SiteUrl { get; set; }

        public FormAddSite()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void FormAddSite_Load(object sender, EventArgs e)
        {
            textBoxSiteURL.Text = SiteUrl;
            textBoxSiteName.Text = "Enter name there";
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSiteName.Text) && !string.IsNullOrEmpty(textBoxSiteURL.Text))
            {
                SiteName = textBoxSiteName.Text;
                SiteUrl = textBoxSiteURL.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ButtonRefuse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
