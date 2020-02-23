using System;
using System.Windows.Forms;

namespace comp_pereph_company
{
    public partial class FormComponentsInfo : Form
    {
        public string ProdName { get => textBoxProdName.Text; set => textBoxProdName.Text = value; }

        public string ProdSpecifications { get => textBoxSpecifications.Text; set => textBoxSpecifications.Text = value; }

        public string ProdDescription { get => textBoxDescription.Text; set => textBoxDescription.Text = value; }

        public decimal ProdValue
        {
            get
            {
                decimal tmp = 0;
                try
                {
                    tmp = decimal.Parse(textBoxValue.Text);
                }
                catch (Exception)
                {

                }
                return tmp;

            }
            set => textBoxValue.Text = value.ToString();
        }

        public FormComponentsInfo()
        {
            InitializeComponent();
        }

        private void FormComponentsInfo_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tmp_Check = decimal.Parse(textBoxValue.Text);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
