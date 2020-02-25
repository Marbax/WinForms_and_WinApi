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
            comboBoxCategories.DisplayMember = "Name";
            listBoxSites.DisplayMember = "Name";
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
            if (comboBoxCategories.Items.Count > 0)
                comboBoxCategories.SelectedIndex = 0;
        }

        private void UpdateListBoxSites()
        {
            listBoxSites.Items.Clear();

            if (_dm.Sites.Count() > 0 && comboBoxCategories.SelectedIndex != -1)
                foreach (Site item in _dm.Sites)
                {
                    if (item.Category_Id == ((Category)comboBoxCategories.SelectedItem).Id)
                        listBoxSites.Items.Add(item);
                }

            if (listBoxSites.Items.Count > 0)
                listBoxSites.SelectedIndex = 0;
        }

        private void RemoveCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dm.Categories.Count() > 0)
            {
                FormRemoveCategory fRemCat = new FormRemoveCategory();
                foreach (Category item in _dm.Categories)
                {
                    fRemCat.Categories.Add(item);
                }
                if (fRemCat.ShowDialog() == DialogResult.OK)
                {
                    List<int> cat_ids = new List<int>();
                    cat_ids.AddRange(fRemCat.ToRemoveCat.Select(c => c.Id));

                    List<Site> to_del = new List<Site>();
                    cat_ids.ForEach(id => to_del.AddRange(_dm.Sites.Where(s => s.Category_Id == id)));

                    if (to_del.Count > 0)
                    {
                        _dm.Sites.RemoveRange(to_del);
                        UpdateListBoxSites();
                    }
                    _dm.Categories.RemoveRange(fRemCat.ToRemoveCat);
                    _dm.SaveChanges();
                    UpdateComboBoxCategories();
                }
            }
        }

        private void AddSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddSite fAddSite = new FormAddSite() { SiteUrl = webBrowser1.Url.ToString(), Categories = _dm.Categories.ToList() };
            if (fAddSite.ShowDialog() == DialogResult.OK)
            {
                _dm.Sites.Add(new Site() { Name = fAddSite.SiteName, Url = fAddSite.SiteUrl, Category_Id = fAddSite.SelectedCategory });
                _dm.SaveChanges();
                UpdateListBoxSites();
            }
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


        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxSites();
        }

        private void removeSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dm.Sites.Count() > 0)
            {
                FormRemoveSite fRemSite = new FormRemoveSite() { Sites = _dm.Sites.ToList() };
                if (fRemSite.ShowDialog() == DialogResult.OK)
                {
                    _dm.Sites.RemoveRange(fRemSite.ToRemoveSites);
                    _dm.SaveChanges();
                    UpdateListBoxSites();
                }
            }
        }

        private void listBoxSites_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int _lb_item_index = this.listBoxSites.IndexFromPoint(e.Location);

            if (_lb_item_index != -1)
                webBrowser1.Navigate(((Site)listBoxSites.Items[_lb_item_index]).Url);
        }
    }
}
