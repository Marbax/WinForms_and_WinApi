using System;
using System.Windows.Forms;

namespace useless_file_editor
{

    public partial class Form2EditWindow : Form
    {
        public event EventHandler eventReturnText;
        public string TextEditBox
        {
            get { return textBoxFileText.Text; }
            set { textBoxFileText.Text = value; }
        }


        public Form2EditWindow()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            eventReturnText(sender, new MyEventArgs(TextEditBox));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
