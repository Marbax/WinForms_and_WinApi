using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace animated_clock
{
    public partial class FormMain : Form
    {
        private Pen _pHr, _pMin, _pSec, _pAlarm;
        private Matrix _mHr, _mMin, _mSec, _mAllarm;
        private float _cur_hr, _cur_min, _cur_sec, _targ_hr, _targ_min, _targ_sec;

        private float _angleHr, _angleMin, _angleSec, _angleAllarm;
        private bool _allarmSetted = false;

        private float _centX, _centY;
        private PointF _pointCent;
        private float _sumCurTime, _sumTargetTime;
        private DateTime _dt;

        public FormMain()
        {
            InitializeComponent();
            CustomInit();
        }

        private void CustomInit()
        {
            _dt = DateTime.Now;

            _pHr = new Pen(Color.Black, 8);
            _pMin = new Pen(Color.Black, 6);
            _pSec = new Pen(Color.Black, 4);
            _pAlarm = new Pen(Color.Red, 2);

            _mHr = new Matrix();
            _mMin = new Matrix();
            _mSec = new Matrix();
            _mAllarm = new Matrix();

            _centX = pictureBoxClock.Width / 2;
            _centY = pictureBoxClock.Height / 2;
            _pointCent = new PointF(_centX, _centY);

            timerClock.Interval = 1000;
            timerClock.Enabled = true;
            timerClock_Tick(this, default);
        }

        private void pictureBoxClock_Paint(object sender, PaintEventArgs e)
        {
            DrawHourArrow(e.Graphics);
            DrawMinuteArrow(e.Graphics);
            DrawSecondArrow(e.Graphics);
            DrawAllarmArrow(e.Graphics);
        }

        private void DrawHourArrow(Graphics graphics)
        {
            _mHr.RotateAt(_angleHr, _pointCent);
            graphics.Transform = _mHr;
            graphics.DrawLine(_pHr, _centX, _centY, _centX, _centY - (_centY * 0.55f));
            _mHr.Reset();
        }

        private void DrawMinuteArrow(Graphics graphics)
        {
            _mMin.RotateAt(_angleMin, _pointCent);
            graphics.Transform = _mMin;
            graphics.DrawLine(_pMin, _centX, _centY, _centX, _centY - (_centY * 0.65f));
            _mMin.Reset();
        }
        private void DrawSecondArrow(Graphics graphics)
        {
            _mSec.RotateAt(_angleSec, _pointCent);
            graphics.Transform = _mSec;
            graphics.DrawLine(_pSec, _centX, _centY, _centX, _centY - (_centY * 0.8f));
            _mSec.Reset();

        }

        private void DrawAllarmArrow(Graphics graphics)
        {
            if (_allarmSetted == true)
            {
                _mAllarm.RotateAt(_angleAllarm, _pointCent);
                graphics.Transform = _mAllarm;
                graphics.DrawLine(_pAlarm, _centX, _centY, _centX, _centY - (_centY * 0.95f));
                _mAllarm.Reset();
            }

        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            CalculateParams();
            if (_sumCurTime == _sumTargetTime)
                MessageBox.Show("Erron Don Don", "Allarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBoxClock.Invalidate();
        }
        private void setAllarmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSetAllarm fsa = new FormSetAllarm() { Hr = _cur_hr, Min = _cur_min, Sec = _cur_sec };
            if (fsa.ShowDialog() == DialogResult.OK)
            {
                _targ_hr = fsa.Hr;
                _targ_min = fsa.Min;
                _targ_sec = fsa.Sec;
                _allarmSetted = true;
            }
        }
        private void resetAllarmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _allarmSetted = false;
        }

        private void CalculateParams()
        {
            _dt = DateTime.Now;
            _cur_hr = _dt.Hour;
            _cur_min = _dt.Minute;
            _cur_sec = _dt.Second;

            _angleHr = (_cur_hr + _cur_min / 60 + _cur_sec / 3600) * 30;
            _angleMin = (_cur_min + _cur_sec / 60) * 6;
            _angleSec = _cur_sec * 6;
            _angleAllarm = ((_targ_hr + _targ_min / 60 + _targ_sec / 3600) * 30);

            _sumCurTime = _cur_hr * 3600 + _cur_min * 60 + _cur_sec;
            _sumTargetTime = _targ_hr * 3600 + _targ_min * 60 + _targ_sec;
        }
    }
}
