using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaManager
{
    public partial class FormMain : Form
    {
        FileInfo[] _files;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
                if (ofd.ShowDialog() == DialogResult.OK)
                    axWindowsMediaPlayer1.URL = ofd.FileName;
        }

        private void buttonOpenDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                    _files = di.GetFiles().Where(f => f.Extension == ".mp3" || f.Extension == ".mp4" || f.Extension == ".avi").ToArray();
                    listBoxFileList.Items.Clear();
                    foreach (FileInfo item in _files)
                    {
                        listBoxFileList.Items.Add(item.Name);
                    }
                }
            }
        }

        private void listBoxFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = _files[listBoxFileList.SelectedIndex].FullName;
        }

    }
}
