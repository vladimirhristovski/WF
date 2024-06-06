using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_aud_drawingForms_kol2
{
    public class Circle : Shape
    {
        private int qoef = -1;
        public Circle(Color color, int size, Point center) : base(color, size, center)
        {
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.color);
            g.FillEllipse(b, center.X - this.size, center.Y - this.size, 2 * this.size, 2 * this.size);
            b.Dispose();
            if (selected)
            {
                Pen p = new Pen(Color.Yellow, 5);
                g.DrawEllipse(p, center.X - this.size, center.Y - this.size, 2 * this.size, 2 * this.size);
                p.Dispose();
            }
        }

        public override bool IsHit(Point p)
        {
            return Math.Sqrt(Math.Pow(this.center.X - p.X, 2) + Math.Pow(this.center.Y - p.Y, 2)) <= this.size;
        }

        public override void Pulse()
        {
            this.size += (qoef * 3);
            if (this.size >= 30 || this.size <= 6)
            {
                this.qoef *= -1;
            }
        }
    }
}
