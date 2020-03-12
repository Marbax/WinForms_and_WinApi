using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diagram_editor
{
    public partial class FormMain : Form
    {
        private List<KeyValuePair<string, decimal>> _records = new List<KeyValuePair<string, decimal>>();
        private List<KeyValuePair<string, decimal>> _sortedRecords = new List<KeyValuePair<string, decimal>>();

        private List<HatchBrush> _brushes = new List<HatchBrush>();

        private bool _drawable = false;

        public FormMain()
        {
            InitializeComponent();
            numericUpDownValue.Maximum = decimal.MaxValue;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckButtonsAndDrawable();

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxLegend.Text.Trim(' ')))
            {
                textBoxLegend.ForeColor = Color.Black;
                _records.Add(new KeyValuePair<string, decimal>(textBoxLegend.Text, numericUpDownValue.Value));
                ListViewAddItem(_records[_records.Count - 1]);
                CheckButtonsAndDrawable();
            }
            else
            {
                textBoxLegend.ForeColor = Color.Red;
            }
        }
        private void ListViewAddItem(KeyValuePair<string, decimal> _item)
        {
            ListViewItem lvi = new ListViewItem(_item.Key);
            lvi.SubItems.Add(_item.Value.ToString());
            listViewRecords.Items.Add(lvi);

            //MessageBox.Show($"{listViewRecords.Items[listViewRecords.Items.Count - 1].Text}  -  {listViewRecords.Items[listViewRecords.Items.Count - 1].SubItems[1].Text}\n{_records[_records.Count - 1].Key}  -  {_records[_records.Count - 1].Value}");
        }

        private void CheckButtonsAndDrawable()
        {
            if (_records.Count <= 0)
                buttonRemove.Enabled = buttonClear.Enabled = buttonBuild.Enabled = _drawable = false;
            else if (_records.Count == 1)
            {
                buttonRemove.Enabled = buttonClear.Enabled = true;
                buttonBuild.Enabled = _drawable = false;
            }
            if (_records.Count > 1)
                buttonBuild.Enabled = _drawable = true;

        }
        private void UpdateListViewRecords()
        {
            listViewRecords.Items.Clear();
            foreach (KeyValuePair<string, decimal> pair in _records)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewRecords.Items.Add(lvi);
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (listViewRecords.SelectedIndices.Count > 0)
                foreach (int index in listViewRecords.SelectedIndices)
                    _records.RemoveAt(index);

            UpdateListViewRecords();
            CheckButtonsAndDrawable();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            _records.Clear();
            listViewRecords.Items.Clear();
            richTextBoxStat.Clear();
            textBoxLegend.Text = "";
            numericUpDownValue.Value = numericUpDownValue.Minimum;
            CheckButtonsAndDrawable();
            this.Refresh();
        }

        private void ButtonBuild_Click(object sender, EventArgs e)
        {
            Random _rnd = new Random();
            _brushes.Clear();
            for (int i = 0; i < _records.Count; i++)
            {
                HatchBrush tmp_brush = new HatchBrush(HatchStyle.Percent90, Color.FromArgb(_rnd.Next(0, 255), _rnd.Next(0, 255), _rnd.Next(0, 255)));
                //LinearGradientBrush tmp_lgb = new LinearGradientBrush(new Rectangle(_rnd.Next(1, 40), _rnd.Next(1, 40), _rnd.Next(1, 40), _rnd.Next(1, 40)), Color.FromArgb(_rnd.Next(0, 255), _rnd.Next(0, 255), _rnd.Next(0, 255)), Color.FromArgb(_rnd.Next(0, 255), _rnd.Next(0, 255), _rnd.Next(0, 255)), _rnd.Next(15, 90));
                _brushes.Add(tmp_brush);
            }
            _sortedRecords.Clear();
            _sortedRecords.AddRange(_records);
            _sortedRecords.Sort(Comparer<KeyValuePair<string, decimal>>.Create((x, y) => y.Value.CompareTo(x.Value)));

            pictureBoxBarChart.Invalidate();
            pictureBoxShema.Invalidate();
            pictureBoxPieChart.Invalidate();
            MakeStatistic();
        }

        private void DrawDiagramSchema(Graphics graphics)
        {
            float minSide = pictureBoxShema.Height >= pictureBoxShema.Width ? pictureBoxShema.Width : pictureBoxShema.Height;
            float separator = minSide / 100;
            float barWidth = minSide / _records.Count();
            float margin = 5;
            float fontSize = barWidth / 2;
            Font font = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Italic);

            int index = 0;
            foreach (var item in _sortedRecords)
            {
                graphics.FillRectangle(_brushes[index], new RectangleF(margin, separator, barWidth, barWidth));
                graphics.DrawString($"{item.Key}", font, _brushes[index], margin * 2 + barWidth, separator - fontSize + barWidth / 2);
                separator += margin * 2 + barWidth;
                index++;
            }

        }
        private void DrawBarChart(Graphics graphics)
        {
            float barWidth = pictureBoxBarChart.Width / _records.Count() / 2;
            Font font = new Font(FontFamily.GenericSansSerif, barWidth / 4, FontStyle.Italic);
            float separator = 10;

            float margin = 50;
            float ratio = FindRatioForBarChart(pictureBoxBarChart, margin);
            int index = 0;
            float barTop = 0;
            float barHeight = 0;

            foreach (KeyValuePair<string, decimal> pair in _sortedRecords)
            {
                barTop = pictureBoxBarChart.Height - (float)pair.Value / ratio - margin / 2;
                barHeight = pictureBoxBarChart.Height - barTop - margin / 2;
                graphics.FillRectangle(_brushes[index], new RectangleF(separator, barTop, barWidth, barHeight));

                graphics.DrawString($"{pair.Value}", font, _brushes[index], separator, barTop - font.Height);

                separator += barWidth * 2;
                index++;
            }
        }

        private float FindRatioForBarChart(Control control, float margin)
        {
            float maxValue = (float)_records.Max(r => r.Value);
            float heightWithMargins = control.Height - margin;

            float ration = 1;
            while (maxValue / ration >= heightWithMargins)
                ration++;

            return ration;
        }

        private void DrawPieChart(Graphics graphics)
        {
            float startAngle = 0;
            float itemAngle = 0;
            int index = 0;
            foreach (KeyValuePair<string, decimal> pair in _sortedRecords)
            {
                itemAngle = FindItemAngleInPie(pair.Value);
                graphics.FillPie(_brushes[index], FindRegualrRectangle(pictureBoxPieChart), startAngle, itemAngle);
                startAngle += itemAngle;
                index++;
            }

        }

        private Rectangle FindRegualrRectangle(Control control)
        {
            int marginX = control.Width / 10;
            int marginY = control.Height / 10;
            int minSide = control.Width >= control.Height ? control.Height : control.Width;
            int minMargin = marginX >= marginY ? marginY : marginX;
            return new Rectangle(marginX, marginY, minSide - minMargin * 2, minSide - minMargin * 2);
        }

        private float FindItemAngleInPie(decimal value)
        {
            decimal sum = _sortedRecords.Sum(r => r.Value);
            float percentOfAll = (float)(value / sum * 100);

            return 360 * (percentOfAll / 100);
        }

        private void MakeStatistic()
        {
            richTextBoxStat.Clear();
            richTextBoxStat.Text = $"Minimum value is {_sortedRecords.Last().Key} - {Math.Round(_sortedRecords.Last().Value, 3)}";
            richTextBoxStat.Text += $"\nMaximum value is {_sortedRecords.First().Key} - {Math.Round(_sortedRecords.First().Value, 3)}";
            richTextBoxStat.Text += $"\nAverage value is {Math.Round(_records.Average(r => r.Value), 3)}";
            richTextBoxStat.Text += $"\nValues sum is {Math.Round(_records.Sum(r => r.Value), 3)}";
        }

        private void pictureBoxShema_Paint(object sender, PaintEventArgs e)
        {
            if (_drawable)
                DrawDiagramSchema(e.Graphics);
            else
                e.Graphics.Clear(this.pictureBoxShema.BackColor);
        }

        private void pictureBoxBarChart_Paint(object sender, PaintEventArgs e)
        {
            if (_drawable)
                DrawBarChart(e.Graphics);
            else
                e.Graphics.Clear(this.pictureBoxBarChart.BackColor);
        }

        private void pictureBoxPieChart_Paint(object sender, PaintEventArgs e)
        {
            if (_drawable)
                DrawPieChart(e.Graphics);
            else
                e.Graphics.Clear(this.pictureBoxPieChart.BackColor);
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxShema.Width = this.panelPicBoxes.Width / 3;
            pictureBoxBarChart.Height = this.Height / 3;
            listViewRecords.Height = this.Height - this.listViewRecords.Top - this.panelBottomBtns.Height - 50;
        }
    }
}
