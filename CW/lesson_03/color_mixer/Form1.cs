using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_mixer
{
    public partial class Form1 : Form
    {
        int _R, _G, _B;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            pictureBoxMixerRes.BackColor = Color.Gray;
            trackBarRed.BackColor = Color.Red;
            labelRed.ForeColor = Color.Red;
            trackBarGreen.BackColor = Color.Green;
            labelGreen.ForeColor = Color.Green;
            trackBarBlue.BackColor = Color.Blue;
            labelBlue.ForeColor = Color.Blue;
            DisplayColor();
        }

        private void DisplayColor()
        {
            _R = trackBarRed.Value;
            _G = trackBarGreen.Value;
            _B = trackBarBlue.Value;
            pictureBoxMixerRes.BackColor = Color.FromArgb(_R, _G, _B);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TrackBarRed_Scroll(object sender, EventArgs e)
        {
            labelRed.Text = $"R: {trackBarRed.Value }";
            DisplayColor();
        }

        private void TrackBarGreen_Scroll(object sender, EventArgs e)
        {
            labelGreen.Text = $"G: {trackBarGreen.Value }";
            DisplayColor();
        }

        private void TrackBarBlue_Scroll(object sender, EventArgs e)
        {
            labelBlue.Text = $"B: {trackBarBlue.Value }";
            DisplayColor();
        }
    }
}
