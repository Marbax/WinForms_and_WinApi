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

namespace graphics_demo
{
    public partial class FormMain : Form
    {
        private Point _lmc = new Point();
        private Point _rmc = new Point();
        private DashStyle _ds = DashStyle.Solid;

        List<KeyValuePair<Point, Point>> _lines = new List<KeyValuePair<Point, Point>>();

        private Modes _mode = Modes.Lines;

        private enum Modes
        {
            Lines = 0, Rectangles = 1, Elispses = 2, Brushes = 3, Pies = 4

        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitComboBoxPens()
        {
            comboBoxPens.Items.Add("Dot");
            comboBoxPens.Items.Add("Solid");
            comboBoxPens.Items.Add("Dash");
            comboBoxPens.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitComboBoxPens();
        }

        private void ButtonLines_Click(object sender, EventArgs e)
        {
            _mode = Modes.Lines;
            pictureBoxDrawArea.Invalidate();
        }

        private void ButtonRectangles_Click(object sender, EventArgs e)
        {
            _mode = Modes.Rectangles;
            pictureBoxDrawArea.Invalidate();
        }

        private void ButtonElipses_Click(object sender, EventArgs e)
        {
            _mode = Modes.Elispses;
            pictureBoxDrawArea.Invalidate();
        }

        private void ButtonBrushes_Click(object sender, EventArgs e)
        {
            _mode = Modes.Brushes;
            pictureBoxDrawArea.Invalidate();
        }
        private void ButtonPies_Click(object sender, EventArgs e)
        {
            _mode = Modes.Pies;
            pictureBoxDrawArea.Invalidate();
        }

        private void PictureBoxDrawArea_Paint(object sender, PaintEventArgs e)
        {
            switch (_mode)
            {
                case Modes.Lines:
                    DrawShapesLines(e.Graphics);
                    break;
                case Modes.Rectangles:
                    DrawShapesRectangles(e.Graphics);
                    break;
                case Modes.Elispses:
                    DrawShapesElipses(e.Graphics);
                    break;
                case Modes.Brushes:
                    DrawShapesBrushes(e.Graphics);
                    break;
                case Modes.Pies:
                    DrawShapesPies(e.Graphics);
                    break;
                default:
                    break;
            }
        }

        private void DrawShapesLines(Graphics graphics)
        {
            Pen pLine = new Pen(Color.Purple, 3);
            pLine.DashStyle = _ds;
            foreach (var item in _lines)
                graphics.DrawLine(pLine, item.Key, item.Value);

        }
        private void DrawShapesRectangles(Graphics graphics)
        {
            //Pen pLine = new Pen(Color.Purple, 3);
            //pLine.DashStyle = _ds;
            foreach (var item in _lines)
            {
                graphics.FillRectangle(Brushes.Blue, new Rectangle((int)item.Key.X, (int)item.Key.Y, (int)item.Value.X - (int)item.Key.X, (int)item.Value.Y - (int)item.Key.Y));
            }
        }
        private void DrawShapesElipses(Graphics graphics)
        {
            Pen pLine = new Pen(Color.Purple, 3);
            pLine.DashStyle = _ds;
            foreach (var item in _lines)
            {
                graphics.FillEllipse(Brushes.Blue, new Rectangle((int)item.Key.X, (int)item.Key.Y, (int)item.Value.X - (int)item.Key.X, (int)item.Value.Y - (int)item.Key.Y));
            }
        }
        private void DrawShapesBrushes(Graphics graphics)
        {
            HatchBrush hb = new HatchBrush(HatchStyle.LightVertical, Color.Red, Color.Black);
            LinearGradientBrush lgb = new LinearGradientBrush(new Rectangle(20,20,20,40), Color.Red, Color.Black, 45);
            foreach (var item in _lines)
            {
                graphics.FillRectangle(lgb, new Rectangle((int)item.Key.X, (int)item.Key.Y, (int)item.Value.X - (int)item.Key.X, (int)item.Value.Y - (int)item.Key.Y));
            }
        }
        private void DrawShapesPies(Graphics graphics)
        {
            foreach (var item in _lines)
                graphics.FillPie(Brushes.Gray, new Rectangle((int)item.Key.X, (int)item.Key.Y, (int)item.Value.X - (int)item.Key.X, (int)item.Value.Y - (int)item.Key.Y), 360 - 90 - 90, 90);
        }

        private void PictureBoxDrawArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _lmc = pictureBoxDrawArea.PointToClient(new Point(MousePosition.X, MousePosition.Y));
                this.Text = $"{_lmc} - {_rmc}";
            }
            else if (e.Button == MouseButtons.Right)
            {
                _rmc = pictureBoxDrawArea.PointToClient(new Point(MousePosition.X, MousePosition.Y));
                this.Text = $"{_lmc} - {_rmc}";
                _lines.Add(new KeyValuePair<Point, Point>(_lmc, _rmc));
            }

        }

        private void PanelBtns_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBoxPens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPens.SelectedIndex == 0)
            {
                _ds = DashStyle.Dot;
                ButtonLines_Click(sender, e);
            }
            else if (comboBoxPens.SelectedIndex == 1)
            {
                _ds = DashStyle.Solid;
                ButtonLines_Click(sender, e);
            }
            else if (comboBoxPens.SelectedIndex == 2)
            {
                _ds = DashStyle.Dash;
                ButtonLines_Click(sender, e);
            }

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            _lines.Clear();
            ButtonLines_Click(sender, e);
        }

    }
}
