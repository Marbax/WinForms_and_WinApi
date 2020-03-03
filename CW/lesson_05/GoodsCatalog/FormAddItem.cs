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
    public partial class FormAddItem : Form
    {

        public string ItemName
        {
            get { return textBoxItemName.Text; }
            set { textBoxItemName.Text = value; }
        }

        public FormAddItem()
        {
            InitializeComponent();
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxItemName.Text.Trim(' ')))
                this.DialogResult = DialogResult.OK;
        }

        private void textBoxItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonSave_Click(sender, e);
        }
    }
}
