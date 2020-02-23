using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//using System.Data.SqlClient;


namespace my_web_browser
{
    public partial class FormMain : Form
    {
        private Regex _regexWebPath = new Regex(@"^(https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|www\.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9]+\.[^\s]{2,}|www\.[a-zA-Z0-9]+\.[^\s]{2,})$");

        private DataManager _dm = new DataManager();

        public FormMain()
        {
            InitializeComponent();
            CustomInit();
        }

        private void CustomInit()
        {
            panel2.Height -= 4;

            foreach (Control item in panel2.Controls)
                item.BackColor = Color.White;

            foreach (Control item in panelUrlBtns.Controls)
                item.BackColor = Color.White;

            foreach (Control item in panelUrl.Controls)
                item.BackColor = Color.White;

            foreach (Control item in panelGOBtn.Controls)
                item.BackColor = Color.White;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComboBoxCategories();
            UpdateListBoxSites();
        }

        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBoxUrl.Text = webBrowser1.Url.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            //webBrowser1.Navigate(new Uri("https://google.com"));
        }

        private void TextBoxUrl_Click(object sender, EventArgs e)
        {
            textBoxUrl.SelectAll();
        }

        private void ButtonGO_Click(object sender, EventArgs e)
        {
            GoToSite();
        }

        private void GoToSite()
        {
            if (!string.IsNullOrEmpty(textBoxUrl.Text))
            {
                if (_regexWebPath.IsMatch(textBoxUrl.Text))
                    webBrowser1.Navigate(new Uri($"{textBoxUrl.Text}"));
                else
                    webBrowser1.Navigate(new Uri($"http://google.com/search?q={textBoxUrl.Text}"));
            }
        }

        private void TextBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GoToSite();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void ButtonForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            if (formAddCategory.ShowDialog() == DialogResult.OK)
            {
                _dm.Categories.Add(new Category() { Name = formAddCategory.CategoryName });
                _dm.SaveChanges();
                UpdateComboBoxCategories();
            }
        }

        private void UpdateComboBoxCategories()
        {
            comboBoxCategories.Items.Clear();
            foreach (var item in _dm.Categories)
            {
                comboBoxCategories.Items.Add(item);
            }
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.SelectedIndex = 0;
        }

        private void UpdateListBoxSites()
        {
            listBoxSites.Items.Clear();
            foreach (var item in _dm.Sites)
            {
                listBoxSites.Items.Add(item);
            }
            listBoxSites.DisplayMember = "Name";
            listBoxSites.SelectedIndex = 0;
        }

        private void RemoveCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dm.Categories.Count() > 0)
            {
                FormRemoveCategory fRemCat = new FormRemoveCategory();
                foreach (var item in _dm.Categories)
                {
                    fRemCat.Categories.Add(item);
                }
                if (fRemCat.ShowDialog() == DialogResult.OK)
                {
                    _dm.Categories.RemoveRange(fRemCat.ToRemoveCat);
                    _dm.SaveChanges();
                    UpdateComboBoxCategories();
                }
            }
        }

        private void AddSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSite fAddSite = new FormAddSite() { SiteUrl = webBrowser1.Url.ToString() };
            if (fAddSite.ShowDialog() == DialogResult.OK)
            {
                _dm.Sites.Add(new Site() { Name = fAddSite.SiteName, Url = fAddSite.SiteUrl });
                _dm.SaveChanges();
                UpdateListBoxSites();
            }

        }
    }
}
