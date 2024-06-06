using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_aud_drawingForms_kol2
{
    public class Scene
    {
        public List<Shape> shapes { get; set; }
        public Shape selectedShape { get; set; }

        public Scene()
        {
            this.shapes = new List<Shape>();
            selectedShape = null;
        }

        public void addShape(Shape shape)
        {
            this.shapes.Add(shape);
        }

        public void drawAll(Graphics g)
        {
            foreach (Shape shape in this.shapes)
            {
                shape.Draw(g);
            }
        }

        internal void click(Point location, string shapeType)
        {
            bool found = false;
            foreach (Shape shape in this.shapes)
            {
                if (shape.IsHit(location))
                {
                    found = true;
                    shape.selected = !shape.selected;
                }
                else
                {
                    shape.selected = false;
                }
            }

            if (!found)
            {
                if (shapeType.Equals("CIRCLE"))
                {
                    shapes.Add(new Circle(Color.Red, 30, location));
                }
                else
                {
                    shapes.Add(new Square(Color.Red, 60, location));
                }
            }
        }

        public void Hit(Point location)
        {
            foreach (var item in shapes)
            {
                if (item.IsHit(location))
                {
                    if(selectedShape == null)
                    {
                        selectedShape = item;
                        item.selected = !item.selected;
                    }
                    else
                    {
                        selectedShape.selected = false;
                        selectedShape = item;
                        selectedShape.selected = true;
                    }
                }
            }
        }

        public void Pulse()
        {
            foreach (Shape s in shapes)
            {
                s.Pulse();
            }
        }
    }
}
