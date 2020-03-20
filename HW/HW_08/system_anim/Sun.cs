using System;
using System.Drawing;

namespace system_anim
{
    public class Sun
    {
        private float _size_equalent;
        private readonly Bitmap _bitmap;
        public Bitmap Bitmap { get => _bitmap; }
        private readonly RectangleF _src;
        public RectangleF Source { get => _src; }
        private RectangleF _dest;
        public RectangleF Destination { get => _dest; }
        private float _radius;
        private float _size;
        public float Size { get => _size; }
        private System.Windows.Forms.Control _drawing_zone;

        public Sun(string imgPath, System.Windows.Forms.Control drawingZone, PointF drawPoint, float radius, float sizeEqualent = 6f)
        {
            _bitmap = new Bitmap(imgPath);
            _drawing_zone = drawingZone;
            _size_equalent = sizeEqualent;
            _radius = radius;
            _src = new RectangleF(0, 0, _bitmap.Width, _bitmap.Height);
            CalculateSize(sizeEqualent);
            CalculateDestination(drawPoint);
        }
        public void CalculateSize(float sizeEqualent)
        {
            _size_equalent = sizeEqualent;
            _size = _radius / Math.Min(_drawing_zone.Height, _drawing_zone.Width) / _size_equalent;
        }
        public void CalculateDestination(PointF dest)
        {
            _dest = new RectangleF(dest.X - _size / 2, dest.Y - _size / 2, _size, _size);
        }

    }
}
