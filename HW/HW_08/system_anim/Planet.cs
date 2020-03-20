using System;
using System.Drawing;

namespace system_anim
{
    class Planet
    {
        private float _size_equalent;
        private readonly Bitmap _bitmap;
        public Bitmap Bitmap { get => _bitmap; }
        private readonly RectangleF _src;
        public RectangleF Source { get => _src; }
        private RectangleF _dest;
        public RectangleF Destination { get => _dest; }
        private float _size;
        public float Size { get => _size; }
        private System.Windows.Forms.Control _drawing_zone;
        private float _average_speed;
        public float AverageSpeed { get => _average_speed; }
        private float _disatance_from_sun;
        public float DistanceFromSun { get => _disatance_from_sun; }
        private float _radius;
        public float Radius { get => _radius; }

        public float CurrentPosition { get; set; }
        public Planet(string imgPath, System.Windows.Forms.Control drawingZone, PointF drawPoint, float radius, float disatanceFromSun, float averageSpeed, float sizeEqualent = 6f)
        {
            _bitmap = new Bitmap(imgPath);
            _drawing_zone = drawingZone;
            _radius = radius;
            _disatance_from_sun = disatanceFromSun;
            _average_speed = averageSpeed;
            _size_equalent = sizeEqualent;
            _src = new RectangleF(0, 0, _bitmap.Width, _bitmap.Height);
            CurrentPosition = _average_speed;
            CalculateSize(sizeEqualent);
            CalculateDestination(drawPoint);
        }
        public Planet(string imgPath, System.Windows.Forms.Control drawingZone, float drawPointX, float drawPointY, float radius, float disatanceFromSun, float averageSpeed, float sizeEqualent = 6f)
        {
            _bitmap = new Bitmap(imgPath);
            _drawing_zone = drawingZone;
            _radius = radius;
            _disatance_from_sun = disatanceFromSun;
            _average_speed = averageSpeed;
            _size_equalent = sizeEqualent;
            _src = new RectangleF(0, 0, _bitmap.Width, _bitmap.Height);
            CalculateSize(sizeEqualent);
            CalculateDestination(new PointF(drawPointX, drawPointY));
        }
        public void CalculateSize(float sizeEqualent = 1)
        {
            _size_equalent = sizeEqualent;
            _size = _radius / Math.Min(_drawing_zone.Height, _drawing_zone.Width) / _size_equalent;
        }
        private void CalculateDestination(PointF drawPoint)
        {
            _dest = new RectangleF(drawPoint.X - _size / 2, drawPoint.Y - _size / 2, _size, _size);
        }

        public float MoveTick()
        {
            if (CurrentPosition >= _average_speed * 361)
                CurrentPosition = _average_speed;
            CurrentPosition += _average_speed;
            return CurrentPosition;
        }

    }
}
