using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace time_span_calc
{

    /// <summary>
    ///  Написать программу, вычисляющую сколько осталось времени до указанной даты (дата вводится с клавиатуры в Edit). 
    ///  Предусмотреть возможность выдачи результата в годах, месяцах, днях, минутах, секундах (для первых двух вариантов ответ дробный). 
    ///  Для переключения между вариантами желательно использовать переключатели (RadioButton).
    /// </summary>
    public partial class Form1 : Form
    {
        private TimeSpan _tm_span = new TimeSpan();
        private int _months = 0;
        private int _days = 0;
        Regex _regexDate = new Regex(@"^([0-2][0-9]|(3)[0-1])(\.)|(\/)|(\-)(((0)[0-9])|((1)[0-2]))(\.)|(\/)|(\-)\d{0,4}$");
        private int _bounces = 0;
        private int _max_bounces = 5;

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Calculate time span";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerChekAndRun.Interval = 10;
            timerChekAndRun.Enabled = true;
            timerChekAndRun.Start();
        }

        private void UpdateResult()
        {
            if (radioButtonYears.Checked)
            {
                textBoxResult.Text = $"{(_tm_span.Days / 365)} years , {_tm_span.Days % 365} days ({Math.Round(_tm_span.TotalDays / 365, 3)})";
            }
            else if (radioButtonMonths.Checked)
            {
                textBoxResult.Text = $"{_months} months {_days} days ({Math.Round(_tm_span.TotalDays / 30.4, 3)})";
            }
            else if (radioButtonDays.Checked)
            {
                textBoxResult.Text = $"{_tm_span.Days} days";
            }
            else if (radioButtonMinutes.Checked)
            {
                textBoxResult.Text = $"{Math.Round(_tm_span.TotalMinutes)} minutes";
            }
            else if (radioButtonSeconds.Checked)
            {
                textBoxResult.Text = $"{Math.Round(_tm_span.TotalSeconds)} seconds";
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _tm_span = dateTimePickerEndDate.Value.Subtract(DateTime.Now);

            _months = (dateTimePickerEndDate.Value.Month - DateTime.Now.Month) + (dateTimePickerEndDate.Value.Year - DateTime.Now.Year) * 12;

            _days = (dateTimePickerEndDate.Value.Day - DateTime.Now.Day) >= 0 ? (dateTimePickerEndDate.Value.Day - DateTime.Now.Day) : 0;

            if (dateTimePickerEndDate.Value < DateTime.Now)
            {
                _months += (dateTimePickerEndDate.Value.Day > DateTime.Now.Day && _months <= 0) ? 1 : 0;
                _days = dateTimePickerEndDate.Value.Day <= DateTime.Now.Day ? (dateTimePickerEndDate.Value.Day - DateTime.Now.Day)
                    : (DateTime.DaysInMonth(dateTimePickerEndDate.Value.Year, dateTimePickerEndDate.Value.Month + 1) - (dateTimePickerEndDate.Value.Day - DateTime.Now.Day));
            }
            else
            {
                _months -= (dateTimePickerEndDate.Value.Day < DateTime.Now.Day && _months > 0) ? 1 : 0;
                _days = dateTimePickerEndDate.Value.Day >= DateTime.Now.Day ? (dateTimePickerEndDate.Value.Day - DateTime.Now.Day)
                    : (DateTime.DaysInMonth(dateTimePickerEndDate.Value.Year, dateTimePickerEndDate.Value.Month - 1) - (DateTime.Now.Day - dateTimePickerEndDate.Value.Day));
            }
            UpdateResult();
        }

        private void radioButtonYears_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void radioButtonMonthes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void radioButtonDays_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void radioButtonMinutes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void radioButtonSeconds_CheckedChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_regexDate.IsMatch(textBoxInputEndDate.Text))
                {
                    DateTime _tmp_dt = DateTime.Parse(textBoxInputEndDate.Text);
                    _tm_span = _tmp_dt.Subtract(DateTime.Now);
                    _months = (_tmp_dt.Month - DateTime.Now.Month) + (_tmp_dt.Year - DateTime.Now.Year) * 12;

                    _days = (_tmp_dt.Day - DateTime.Now.Day) >= 0 ? (_tmp_dt.Day - DateTime.Now.Day) : 0;

                    if (_tmp_dt < DateTime.Now)
                    {
                        _months += (_tmp_dt.Day > DateTime.Now.Day && _months <= 0) ? 1 : 0;
                        _days = _tmp_dt.Day <= DateTime.Now.Day ? (_tmp_dt.Day - DateTime.Now.Day)
                            : (DateTime.DaysInMonth(_tmp_dt.Year, _tmp_dt.Month + 1) - (_tmp_dt.Day - DateTime.Now.Day));
                    }
                    else
                    {
                        _months -= (_tmp_dt.Day < DateTime.Now.Day && _months > 0) ? 1 : 0;
                        _days = _tmp_dt.Day >= DateTime.Now.Day ? (_tmp_dt.Day - DateTime.Now.Day)
                            : (DateTime.DaysInMonth(_tmp_dt.Year, _tmp_dt.Month - 1) - (DateTime.Now.Day - _tmp_dt.Day));
                    }

                    UpdateResult();
                }
            }
            catch (Exception)
            {
                //none//
            }
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            buttonShowInfo.Location = this.PointToClient(new Point(this.Location.X + this.Width - buttonShowInfo.Width - 10, this.Location.Y + 10 + buttonShowInfo.Height));
            _bounces = 0;
            MessageBox.Show("You can input some end date and calculate how many time left for that date as seconds ,minutes,days etc.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timerChekAndRun_Tick(object sender, EventArgs e)
        {
            int margin = 25;
            Random rnd = new Random();
            int x = 0;
            int y = 0;

            Point pTL = new Point();
            pTL = buttonShowInfo.PointToScreen(pTL);
            pTL.X -= margin;
            pTL.Y -= margin;

            Point pBR = new Point();
            pBR = buttonShowInfo.PointToScreen(pBR);
            pBR.X += margin + buttonShowInfo.Width;
            pBR.Y += margin + buttonShowInfo.Height;

            if ((MousePosition.X > pTL.X && MousePosition.Y > pTL.Y)
                && (MousePosition.X < pBR.X && MousePosition.Y < pBR.Y)
                && _bounces < _max_bounces)
            {
                x = rnd.Next(this.Location.X + buttonShowInfo.Width, this.Location.X + this.Width - buttonShowInfo.Width - 10);
                y = rnd.Next(this.Location.Y + buttonShowInfo.Height + 10, this.Location.Y + this.Height - buttonShowInfo.Height);
                buttonShowInfo.Location = this.PointToClient(new Point(x, y));
                _bounces++;
            }
        }
    }
}
