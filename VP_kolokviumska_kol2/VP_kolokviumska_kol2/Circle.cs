using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kolokviumska_kol2
{
    internal class Circle
    {
        public int Radius { get; set; } = 25;
        public Color Color { get; set; } = Color.Red;
        public Point Center { get; set; }
        public bool Safe { get; set; } = false;
        public bool Danger { get; set; } = false;

        public Circle(Point center)
        {
            this.Center = center;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();

            if (Safe)
            {
                Pen p = new Pen(Color.Yellow, 2);
                g.DrawEllipse(p, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            }

            if (Danger)
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawEllipse(p, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            }
        }

        public bool IsHit(Point point)
        {
            return Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2)) <= Radius;
        }

        public bool Overlap(Circle circle)
        {
            return Math.Sqrt(Math.Pow(Center.X - circle.Center.X, 2) + Math.Pow(Center.Y - circle.Center.Y, 2)) <= (Radius + circle.Radius);

        }
    }
}
