using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animated_clock
{
    public partial class FormSetAllarm : Form
    {
        public float Hr { get => (float)numericUpDownHours.Value; set => numericUpDownHours.Value = (decimal)value; }

        public float Min { get => (float)numericUpDownMinutes.Value; set => numericUpDownMinutes.Value = (decimal)value; }

        public float Sec { get => (float)numericUpDownSeconds.Value; set => numericUpDownSeconds.Value = (decimal)value; }

        public FormSetAllarm()
        {
            InitializeComponent();
        }

        private void FormSetAllarm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
