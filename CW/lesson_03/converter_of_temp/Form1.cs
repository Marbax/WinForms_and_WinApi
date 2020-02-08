using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter_of_temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonFtoC.Checked = true;
            textBoxTempCelsium.ReadOnly = true;
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonCtoF.Checked == true)
                {
                    double cel = double.Parse(textBoxTempCelsium.Text);
                    textBoxTempFahrenh.Text = $"{32 + cel * 1.8 }";
                    textBoxTempCelsium.Focus();
                }
                else if (radioButtonFtoC.Checked == true)
                {
                    double fah = double.Parse(textBoxTempFahrenh.Text);
                    textBoxTempCelsium.Text = $"{(fah - 32) * 5 / 9 }";
                    textBoxTempFahrenh.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input");
            }

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            textBoxTempCelsium.Clear();
            textBoxTempFahrenh.Clear();
            if (radioButtonCtoF.Checked == true)
                textBoxTempCelsium.Focus();
            else if (radioButtonFtoC.Checked == true)
                textBoxTempFahrenh.Focus();

        }

        private void RadioButtonCtoF_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTempFahrenh.ReadOnly = true;
            textBoxTempCelsium.ReadOnly = false;
            textBoxTempCelsium.Focus();

        }

        private void RadioButtonFtoC_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTempCelsium.ReadOnly = true;
            textBoxTempFahrenh.ReadOnly = false;
            textBoxTempFahrenh.Focus();
        }
    }
}
