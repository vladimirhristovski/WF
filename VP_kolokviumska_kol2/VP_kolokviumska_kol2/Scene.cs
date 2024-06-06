using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_kolokviumska_kol2
{
    internal class Scene
    {
        public List<Circle> Circles { get; set; }
        public int Points { get; set; }
        public Random random { get; set; } = new Random();
        public Scene()
        {
            this.Circles = new List<Circle>();
            this.Points = 0;
        }

        public void AddCircle(Circle c)
        {
            foreach (Circle circle in Circles)
            {
                if (circle.Overlap(c))
                {
                    return;
                }
            }
            this.Circles.Add(c);
        }

        public void Draw(Graphics g)
        {
            foreach (Circle circle in Circles)
            {
                circle.Draw(g);
            }
        }

        internal void Click(Point location)
        {
            foreach (Circle circle in Circles)
            {
                if (circle.IsHit(location) && !circle.Danger && !circle.Safe)
                {
                    circle.Safe = true;
                    Points += 5;
                    return;
                }
            }
        }

        internal void PickCircle()
        {
            if (GameOver() && !Circles.Where(c=>c.Danger).Any())
            {
                return;
            }

            List<Circle> remove1 = Circles.Where(c => c.Danger && !c.Safe).ToList();
            if (remove1.Count > 0)
            {
                Circles.Remove(remove1[0]);
            }

            List<Circle> notSafe = Circles.Where(c => !c.Safe && !c.Danger).ToList();
            if (notSafe.Count > 0)
            {
                Circle delete = notSafe[random.Next(0, notSafe.Count)];
                delete.Danger = true;
                Points -= 10;
            }
        }

        public bool GameOver()
        {
            return !Circles.Where(c => !c.Safe && !c.Danger).Any();
        }
    }
}
