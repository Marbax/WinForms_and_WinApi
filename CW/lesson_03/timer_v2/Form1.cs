using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_v2
{
    public partial class Form1 : Form
    {
        private bool _timerOn = false;
        private TimeSpan _tm_span = new TimeSpan();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer1.Start();
            numericUpDownMinutes.Focus();
            buttonStop.Enabled = false;
            buttonContinue.Enabled = false;
        }
        private void DisplayTime()
        {
            this.labelTime.Text = DateTime.Now.ToLongTimeString();
            this.labelTimeLeft.Text = $"{_tm_span.ToString()}";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (_timerOn == true)
            {
                _tm_span = _tm_span.Subtract(new TimeSpan(0, 0, 0, 0, timer1.Interval));
                progressBarTimeLeft.Value += timer1.Interval;//check it
            }
            DisplayTime();

        }

        private void ButtonSetTimer_Click(object sender, EventArgs e)
        {
            try
            {
                _tm_span = new TimeSpan(days: 0,
                    hours: 0,
                    minutes: (int)numericUpDownMinutes.Value,
                    seconds: (int)numericUpDownSeconds.Value,
                    milliseconds: (int)numericUpDownMiliSeconds.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.Wrong input\n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            buttonSetTimer.Enabled = false;
            buttonResetTimer.Enabled = true;
            buttonStop.Enabled = true;
            _timerOn = true;
            progressBarTimeLeft.Maximum = (int)_tm_span.TotalMilliseconds;
            progressBarTimeLeft.Value = 0;
        }

        private void ButtonResetTimer_Click(object sender, EventArgs e)
        {
            numericUpDownMinutes.Value = 0;
            numericUpDownSeconds.Value = 0;
            numericUpDownMiliSeconds.Value = 0;
            _tm_span = default;
            buttonResetTimer.Enabled = true;
            buttonSetTimer.Enabled = true;
            buttonStop.Enabled = false;
            _timerOn = false;

        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            buttonSetTimer.Enabled = true;
            buttonContinue.Enabled = true;
            _timerOn = false;
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = true;
            buttonContinue.Enabled = false;
            _timerOn = true;
        }
    }
}
