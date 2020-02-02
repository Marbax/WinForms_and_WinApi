using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // can run another process\file

namespace winForms_timer
{
    public partial class Form1 : Form
    {
        private DateTime _alarm = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;
            timer1.Enabled = true;
            numericUpDownHour.Focus();
        }

        private void DisplayTime()
        {
            this.labelCurTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void AlarmSoundPlay()
        {
            using (Process proc = new Process())
            {
                //proc.StartInfo.FileName = "calc.exe";
                proc.StartInfo.FileName = @"..\..\sound\Twin-bell-alarm-clock.mp3";
                proc.Start();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DisplayTime();
            if (DateTime.Now.ToLongTimeString() == _alarm.ToLongTimeString())
            {
                _alarm = default;
                AlarmSoundPlay();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            try
            {
                _alarm = DateTime.Parse($"{numericUpDownHour.Value}:{numericUpDownMinute.Value}:{numericUpDownSecond.Value}");
                MessageBox.Show("Succesffully");
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Wrong input", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            numericUpDownHour.Value = DateTime.Now.Hour;
            numericUpDownMinute.Value = DateTime.Now.Minute;
            numericUpDownSecond.Value = DateTime.Now.Second;
            _alarm = default;
        }


    }
}
