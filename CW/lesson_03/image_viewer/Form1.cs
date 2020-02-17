using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // work with folders

namespace image_viewer
{
    public partial class Form1 : Form
    {
        private List<string> _pictureName = new List<string>();
        private List<string> _picturePath = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listBoxImages.ScrollAlwaysVisible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLoadanImage_Click(object sender, EventArgs e)
        {
            /*
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] files = di.GetFiles(@"*.png");
            }
            */
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp|GIF(*.gif)|*.gif|ALL(*.*)|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBoxImages.Items.Clear();
                _pictureName.AddRange(ofd.SafeFileNames);
                _picturePath.AddRange(ofd.FileNames);
                _pictureName.ForEach(x => listBoxImages.Items.Add(x));
            }
        }

        private void ListBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex > -1)
            {
                pictureBoxChoosenPicture.ImageLocation = _picturePath[listBoxImages.SelectedIndex];
            }
        }

        private void ButtonPreveous_Click(object sender, EventArgs e)
        {
            if (_picturePath.Count > 0)
            {
                if (listBoxImages.SelectedIndex == -1 || listBoxImages.SelectedIndex <= 0)
                    listBoxImages.SelectedIndex = listBoxImages.Items.Count - 1;
                else
                {
                    listBoxImages.SelectedIndex--;
                }
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (_picturePath.Count > 0)
            {
                if (listBoxImages.SelectedIndex == -1 || listBoxImages.SelectedIndex >= listBoxImages.Items.Count - 1)
                    listBoxImages.SelectedIndex = 0;
                else
                {
                    listBoxImages.SelectedIndex++;
                }
            }
        }

        private void TimerPicTick_Tick(object sender, EventArgs e)
        {
            if (_picturePath.Count > 0)
                ButtonNext_Click(sender, e);
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timerPicTick.Interval = (int)numericUpDownIntervalChange.Value * 1000;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            timerPicTick.Enabled = true;
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            timerPicTick.Enabled = false;
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void ButtonFlush_Click(object sender, EventArgs e)
        {
            if (_picturePath.Count > 0)
            {
                _picturePath.Clear();
                _pictureName.Clear();
                listBoxImages.Items.Clear();
                pictureBoxChoosenPicture.Image = default;
                ButtonStop_Click(sender, e);
            }
        }
    }
}
