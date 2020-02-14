using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace profile_feeller
{
    /// <summary>
    /// 2. Написать приложение — анкету, которую предлагается заполнить пользователю,
    ///     все данные отображаются на результирующем текстовом поле.
    /// </summary>
    public partial class Form1 : Form
    {

        ToolTip _tTipInfo;
        Regex _regexText = new Regex(@"^([a-zA-Z]{3,10}[a-zA-Z ]{0,10})$");

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            radioButtonMarried.AutoCheck = false;
            radioButtonMarried.Checked = true;

            timer1.Interval = 1000;
            timer1.Start();

            statusStrip1.RightToLeft = RightToLeft.Yes;

            richTextBoxResult.ReadOnly = true;
            richTextBoxResult.BorderStyle = BorderStyle.Fixed3D;
            InitInfoToolTips();
            InitProgressBar();
            InitCheckBoxes();
        }

        private void InitInfoToolTips()
        {
            _tTipInfo = new ToolTip();
            _tTipInfo.SetToolTip(textBoxName, "Input name, necessary field");
            _tTipInfo.SetToolTip(textBoxSurname, "Input surname, necessary field");
            _tTipInfo.SetToolTip(textBoxMiddleName, "Input surname, necessary field");
            _tTipInfo.SetToolTip(radioButtonMarried, "Switch on if married");
            _tTipInfo.SetToolTip(radioButtonMale, "Choose your gender");
            _tTipInfo.SetToolTip(radioButtonFemale, "Choose your gender");
            _tTipInfo.SetToolTip(numericUpDownAge, "Choose your age");
            _tTipInfo.SetToolTip(progressBarProfile, "Progress of profile's feeling.");
        }

        private void InitProgressBar()
        {
            progressBarProfile.Minimum = 0;
            progressBarProfile.Maximum = 6;
            progressBarProfile.Step = 1;
            progressBarProfile.Style = ProgressBarStyle.Continuous;
        }

        private void InitCheckBoxes()
        {
            checkBoxName.Enabled = false;
            checkBoxSurname.Enabled = false;
            checkBoxMiddleName.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStatusStrip();
            UpdateProgressBar();
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButtonMarried.Checked = radioButtonMarried.Checked == true ? false : true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateStatusStrip();
            UpdateProgressBar();
        }
        private void UpdateStatusStrip()
        {
            toolStripStatusLabel1.Text = $"{DateTime.Now.ToShortDateString()}";
            toolStripStatusLabel2.Text = $"{DateTime.Now.ToLongTimeString()}";
            toolStripStatusLabel3.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void UpdateProgressBar()
        {
            progressBarProfile.Value = CheckDataFields();
            labelProgress.Text = $"{(progressBarProfile.Value * 100 / progressBarProfile.Maximum).ToString()}%";
            if (progressBarProfile.Value == progressBarProfile.Maximum)
            {
                buttonMakeProfile.Enabled = true;
                buttonMakeProfile.BackColor = Color.LimeGreen;
            }
            else
            {
                buttonMakeProfile.Enabled = false;
                buttonMakeProfile.BackColor = default;
            }
        }

        private int CheckDataFields()
        {
            int checked_fields = 0;
            if (_regexText.IsMatch(textBoxName.Text))
            {
                checked_fields += 1;
                checkBoxName.Checked = true;
            }
            else
                checkBoxName.Checked = false;

            if (_regexText.IsMatch(textBoxSurname.Text))
            {
                checked_fields += 1;
                checkBoxSurname.Checked = true;
            }
            else
                checkBoxSurname.Checked = false;

            if (_regexText.IsMatch(textBoxMiddleName.Text))
            {
                checked_fields += 1;
                checkBoxMiddleName.Checked = true;
            }
            else
                checkBoxMiddleName.Checked = false;

            checked_fields += radioButtonMarried.Enabled ? 1 : 0;
            checked_fields += (radioButtonMale.Checked || radioButtonFemale.Checked) ? 1 : 0;
            checked_fields += numericUpDownAge.Enabled ? 1 : 0;

            return checked_fields;
        }

        private void buttonMakeProfile_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = $"{textBoxSurname.Text} {textBoxName.Text} {textBoxMiddleName.Text}\n";
            richTextBoxResult.Text += radioButtonMarried.Checked ? "Married\n" : "Not Married\n";
            richTextBoxResult.Text += radioButtonMale.Checked ? radioButtonMale.Text : radioButtonFemale.Text;
            richTextBoxResult.Text += $"\n{numericUpDownAge.Value.ToString()} y.o.";
        }
    }
}

