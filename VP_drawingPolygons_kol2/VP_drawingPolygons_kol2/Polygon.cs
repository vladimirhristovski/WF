using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_drawingPolygons_kol2
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public bool IsCompleted { get; set; } = false;
        public Point Cursor { get; set; }
        public Color Color { get; set; }

        public Polygon(Color color)
        {
            Points = new List<Point>();
            this.Color = color;
        }

        public void addPoint(Point point)
        {
            if (NearStart())
            {
                Points.Add(Points[0]);
                IsCompleted = true;
            }
            else
            {
                Points.Add(point);
            }
        }

        public bool NearStart()
        {
            if (Points.Count >= 3)
            {
                return Math.Sqrt(Math.Pow(Points[0].X - Cursor.X, 2) + Math.Pow(Points[0].Y - Cursor.Y, 2)) < 15;
            }
            return false;
        }

        public void Draw(Graphics g)
        {
            if (Points.Count >= 2)
            {
                Pen p = new Pen(Color.Black, 2);
                g.DrawLines(p, Points.ToArray());
                p.Dispose();

                if (IsCompleted)
                {
                    Brush brush = new SolidBrush(Color);
                    g.FillPolygon(brush, Points.ToArray());
                    brush.Dispose();
                }

                if (NearStart() && !IsCompleted)
                {
                    Pen p1 = new Pen(Color.Green, 2);
                    g.DrawEllipse(p1, Points[0].X - 5, Points[0].Y - 5, 10, 10);
                    p1.Dispose();
                }
            }
        }

        internal void MoveLeft()
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X - 5, Points[i].Y);
            }
        }

        internal void MoveRight()
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + 5, Points[i].Y);
            }
        }
    }
}
