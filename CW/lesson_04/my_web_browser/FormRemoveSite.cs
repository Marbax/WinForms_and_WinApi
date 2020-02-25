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
    public partial class FormRemoveSite : Form
    {
        private List<Site> _sites = new List<Site>();
        public List<Site> Sites
        {
            get
            {
                return _sites;
            }
            set
            {
                _sites = value;
                listBoxSites.Items.Clear();
                value.ForEach(s => listBoxSites.Items.Add(s));

            }
        }

        private List<Site> _toRemoveSites = new List<Site>();
        public List<Site> ToRemoveSites
        {
            get { return _toRemoveSites; }
        }


        public FormRemoveSite()
        {
            InitializeComponent();
        }

        private void FormRemoveSite_Load(object sender, EventArgs e)
        {
            listBoxSites.DisplayMember = "Name";
            if (listBoxSites.Items.Count > 0)
                listBoxSites.SelectedIndex = 0;

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (Site item in listBoxSites.SelectedItems)
            {
                _sites.Remove(item);
                ToRemoveSites.Add(item);
            }
            Sites = _sites;

        }

        private void buttonSaveAndCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
