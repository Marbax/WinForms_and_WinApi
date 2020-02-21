using System;
using System.Diagnostics;
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
            Form2EditWindow _fEdit = new Form2EditWindow() { TextEditBox = textBoxFileText.Text };
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


        public void EditText(object sender, EventArgs e)
        {
            this.textBoxFileText.Text = ((MyEventArgs)e).Text;
        }

        private void linkLabelHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Process proc = new Process())
            {
                proc.StartInfo.FileName = "https://github.com/Marbax/WinForms_and_WinApi/tree/master/HW/HW_04/useless_file_editor";
                proc.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip _tTip = new ToolTip();
            _tTip.IsBalloon = true;
            _tTip.SetToolTip(linkLabelHelp, "Приложение состоит из двух форм. \nПервая форма содержит TextBox доступный только для чтения и две кнопки «загрузить файл» и «редактировать». \nКнопка «редактировать» изначально неактивна. \nПри нажатии на первую кнопку, открывается диалог и пользователю предлагают выбрать текстовый файл. \nВыбранный файл загружается в TextBox и кнопка «редактировать» становится активной. \nПри нажатии на вторую кнопку открывается вторая форма (не модально), которая содержит TextBox доступный для редактирования и две кнопки «Сохранить» и «Отменить». \nПри нажатии на первую кнопку  изменения отображаются в TextBox первой формы.");
        }
    }
}
