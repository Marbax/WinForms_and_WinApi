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
    public partial class FormAddCategory : Form
    {
        public string CategoryName { get; set; }
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {

        }

        private void ButtonRefuse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCategoryName.Text.Trim(' ')))
            {
                CategoryName = textBoxCategoryName.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
