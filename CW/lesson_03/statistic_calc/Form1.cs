using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statistic_calc
{
    public partial class Form1 : Form
    {
        private List<string> _legends;
        private List<double> _results;


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.BackColor = Color.LightGray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLegend.Focus();
            _legends = new List<string>();
            _results = new List<double>();
        }

        private void ButtonAddtoList_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLegend.Text == "" || textBoxResult.Text == "")
                    throw new ApplicationException();
                else
                {
                    _results.Add(double.Parse(textBoxResult.Text));
                    _legends.Add(textBoxLegend.Text);
                    listBoxCollection.Items.Add($"{textBoxLegend.Text} - {textBoxResult.Text} ");
                    textBoxLegend.Clear();
                    textBoxResult.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Legend or Result are clear or there wrong data into them!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonRemovefromList_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show($"{listBoxCollection.SelectedIndex}");
                if (listBoxCollection.SelectedIndex == -1) { }
                else
                {
                    _legends.RemoveAt(listBoxCollection.SelectedIndex);
                    _results.RemoveAt(listBoxCollection.SelectedIndex);
                    listBoxCollection.Items.RemoveAt(listBoxCollection.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClearFields_Click(object sender, EventArgs e)
        {
            textBoxLegend.Clear();
            textBoxResult.Clear();
            textBoxReport.Clear();
        }

        private void ButtonClearList_Click(object sender, EventArgs e)
        {
            ButtonClearFields_Click(sender, e);
            listBoxCollection.Items.Clear();
            _results.Clear();
            _legends.Clear();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            if (listBoxCollection.Items.Count > 0)
            {
                StringBuilder str_tmp = new StringBuilder($"Average: {_results.Average()}" +
                    $"\nMin: {_legends[_results.FindIndex(x => x == _results.Min())]} - {_results.Min()}" +
                    $"\nMax: {_legends[_results.FindIndex(x => x == _results.Max())]} - {_results.Max()}");
                textBoxReport.Text = str_tmp.ToString();

            }
        }
    }
}
