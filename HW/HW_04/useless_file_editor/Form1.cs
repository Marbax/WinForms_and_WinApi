using System;
using System.IO;
using System.Windows.Forms;

namespace useless_file_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            Form2EditWindow _fEdit = new Form2EditWindow() { TextEditBox = textBoxFileText.Text};
            _fEdit.eventReturnText += new EventHandler(EditText);
            _fEdit.Show(this);
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog _opf = new OpenFileDialog())
            {
                _opf.Filter = "Text Files(*.txt)|*.txt||";

                if (_opf.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader _sr = File.OpenText(_opf.FileName))
                    {
                        textBoxFileText.Text = _sr.ReadToEnd();
                    }
                    buttonEditFile.Enabled = true;
                }
            }
        }


        public void EditText(object sender,EventArgs e)
        {
            this.textBoxFileText.Text = ((MyEventArgs)e).Text;
        }

    }
}
