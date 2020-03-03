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
    public partial class FormRemoveProvider : Form
    {
        private List<Provider> _providers;

        public List<Provider> Providers
        {
            set
            {
                _providers = value;
                listBoxProviders.Items.Clear();
                listBoxProviders.Items.AddRange(value.ToArray());
            }
        }

        private List<Provider> _toRemoveProviders = new List<Provider>();

        public List<Provider> ToRemoveProviders
        {
            get { return _toRemoveProviders; }
        }


        public FormRemoveProvider()
        {
            InitializeComponent();
        }

        private void FormRemoveProvider_Load(object sender, EventArgs e)
        {
            this.listBoxProviders.DisplayMember = "Name";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (Provider item in listBoxProviders.SelectedItems)
            {
                _providers.Remove(item);
                _toRemoveProviders.Add(item);
            }
            Providers = _providers;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_toRemoveProviders.Count == 0)
                this.DialogResult = DialogResult.Cancel;
            else if (MessageBox.Show("There will be deleted products of that provider too", "Ettention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
