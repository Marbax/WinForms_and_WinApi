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
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] files = di.GetFiles(@"*.png");
            }
        }
    }
}
