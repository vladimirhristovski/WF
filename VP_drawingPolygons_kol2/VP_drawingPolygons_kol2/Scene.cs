using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_drawingPolygons_kol2
{
    [Serializable]
    internal class Scene
    {
        public List<Polygon> Polygons { get; set; }
        public Polygon CurrentPolygon { get; set; }
        public Color Color { get; set; } = Color.Blue;
        public Scene()
        {
            Polygons = new List<Polygon>();
            CurrentPolygon = new Polygon(Color);
        }

        public void AddPoint(Point p)
        {
            if (CurrentPolygon.IsCompleted)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon(Color);
                CurrentPolygon.addPoint(p);
            }
            else
            {
                CurrentPolygon.addPoint(p);
            }
        }

        public void Draw(Graphics g)
        {
            CurrentPolygon.Draw(g);
            foreach (var item in Polygons)
            {
                item.Draw(g);
            }
        }

        internal void UpdateColor(Color color)
        {
            this.Color = color;
            CurrentPolygon.Color = color;
        }
    }
}
