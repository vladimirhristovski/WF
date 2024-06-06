using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_aud_drawingForms_kol2
{
    public abstract class Shape
    {
        public Color color { get; set; }
        public int size { get; set; }
        public Point center { get; set; }
        public bool selected { get; set; }

        protected Shape(Color color, int size, Point center)
        {
            this.color = color;
            this.size = size;
            this.center = center;
            selected = false;
        }

        public abstract void Draw(Graphics g);
        public abstract void Pulse();
        public abstract bool IsHit(Point p);
    }
}
