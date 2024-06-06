using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_aud_drawingForms_kol2
{
    public class Square : Shape
    {
        private int qoef = -1;
        public Square(Color color, int size, Point center) : base(color, size, center)
        {
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(this.color);
            g.FillRectangle(b, center.X - this.size / 2, center.Y - this.size / 2, this.size, this.size);
            b.Dispose();
            if (selected)
            {
                Pen p = new Pen(Color.Yellow, 5);
                g.DrawRectangle(p, center.X - this.size / 2, center.Y - this.size / 2, this.size, this.size);
                p.Dispose();
            }
        }

        public override bool IsHit(Point p)
        {
            Rectangle r = new Rectangle(center.X - this.size / 2, center.Y - this.size / 2, this.size, this.size);
            return r.Contains(p);
        }

        public override void Pulse()
        {
            this.size += (qoef * 3);
            if (this.size >= 60 || this.size <= 6)
            {
                this.qoef *= -1;
            }
        }
    }
}
