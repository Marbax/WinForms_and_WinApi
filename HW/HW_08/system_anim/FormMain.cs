using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using system_anim.Properties;
using System.Drawing.Drawing2D;

namespace system_anim
{
    public partial class FormMain : Form
    {
        private Sun _sun;

        private List<Planet> _planets = new List<Planet>();

        private readonly PointF _center;
        Matrix _matrix = new Matrix();

        private float _size_eq = 0.5f;
        private float _current_size_eq;

        private float _speed_eq = 20f;
        private float _current_speed_eq;

        public FormMain()
        {
            InitializeComponent();

            _center = new PointF(pictureBoxSystem.Width / 2, pictureBoxSystem.Height / 2);


            _current_size_eq = _size_eq;
            _current_speed_eq = _speed_eq;
            LoadCelestialBodies();

            timerAnim.Interval = 60;
            timerAnim.Enabled = true;

        }
        private void LoadCelestialBodies()
        {
            if (_planets.Count > 0)
                _planets.Clear();
            _sun = new Sun(@"..\..\img\Sun.png", pictureBoxSystem, _center, 12963f, _current_size_eq);

            float distanceX = _sun.Destination.Right + _sun.Size / 2;
            _planets.Add(new Planet(@"..\..\img\Mercury.png", pictureBoxSystem, distanceX, _center.Y, 844f, 0.387f, 47.87f, _current_size_eq));
            distanceX += _planets[0].Size * 3;
            _planets.Add(new Planet(@"..\..\img\Venus.png", pictureBoxSystem, distanceX, _center.Y, 2405f, 0.723f, 35.02f, _current_size_eq));
            distanceX += _planets[1].Size * 2;
            _planets.Add(new Planet(@"..\..\img\Earth.png", pictureBoxSystem, distanceX, _center.Y, 2437f, 1f, 29.76f, _current_size_eq));
            distanceX += _planets[2].Size * 2;
            _planets.Add(new Planet(@"..\..\img\Mars.png", pictureBoxSystem, distanceX, _center.Y, 1239f, 1.52f, 24.13f, _current_size_eq));
            distanceX += _planets[3].Size * 4;
            _planets.Add(new Planet(@"..\..\img\Jupiter.png", pictureBoxSystem, distanceX, _center.Y, 7149f, 5.2f, 13.07f, _current_size_eq));
            distanceX += _planets[4].Size * 2;
            _planets.Add(new Planet(@"..\..\img\Saturn.png", pictureBoxSystem, distanceX, _center.Y, 6027f, 9.54f, 9.67f, _current_size_eq));
            distanceX += _planets[5].Size * 2;
            _planets.Add(new Planet(@"..\..\img\Uranus.png", pictureBoxSystem, distanceX, _center.Y, 2556f, 19.19f, 6.84f, _current_size_eq));
            distanceX += _planets[6].Size * 2;
            _planets.Add(new Planet(@"..\..\img\Neptune.png", pictureBoxSystem, distanceX, _center.Y, 2476f, 30.07f, 5.48f, _current_size_eq));
            distanceX += _planets[7].Size * 2;
            _planets.Add(new Planet(@"..\..\img\Pluto.png", pictureBoxSystem, distanceX, _center.Y, 844f, 39.07f, 4.75f, _current_size_eq));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBoxSystem_Paint(object sender, PaintEventArgs e)
        {
            DrawSun(e.Graphics);
            //DrawOrbits(e.Graphics);
            DrawPlanets(e.Graphics);
        }
        private void DrawSun(Graphics graphics)
        {
            graphics.DrawImage(_sun.Bitmap, _sun.Destination, _sun.Source, GraphicsUnit.Pixel);
        }
        private void DrawPlanets(Graphics graphics)
        {

            for (int i = 0; i < _planets.Count; i++)
            {
                _matrix.RotateAt(_planets[i].MoveTick() / _current_speed_eq, _center);
                graphics.Transform = _matrix;
                graphics.DrawImage(_planets[i].Bitmap, _planets[i].Destination, _planets[i].Source, GraphicsUnit.Pixel);
                _matrix.Reset();
            }
        }

        private void DrawOrbits(Graphics graphics)
        {
            Pen pen = new Pen(Brushes.White, 3);
            pen.DashStyle = DashStyle.Dash;

            //graphics.DrawEllipse(pen, new RectangleF(_sun_dest.X - _sun_size, _sun_dest.Y - _sun_size / 2, _sun_size * 3, _sun_size * 1.5f));
            //graphics.DrawEllipse(pen, new RectangleF(_sun_dest.X - _sun_size * 2, _sun_dest.Y - _sun_size, _sun_size * 6, _sun_size * 2));
            //graphics.DrawEllipse(pen, new RectangleF(_sun_dest.X - _sun_size * 2, _sun_dest.Y - _sun_size * 2, _sun_size * 6, _sun_size * 2));
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
        }

        private void timerAnim_Tick(object sender, EventArgs e)
        {
            pictureBoxSystem.Invalidate();
        }

        private void numericUpDownPlanetsSpeed_ValueChanged(object sender, EventArgs e)
        {
            _current_speed_eq = _speed_eq / (float)numericUpDownPlanetsSpeed.Value;
        }

        private void numericUpDownPlanetsSize_ValueChanged(object sender, EventArgs e)
        {
            _current_size_eq = _size_eq / (float)numericUpDownPlanetsSize.Value;
            LoadCelestialBodies();
        }
    }
}
