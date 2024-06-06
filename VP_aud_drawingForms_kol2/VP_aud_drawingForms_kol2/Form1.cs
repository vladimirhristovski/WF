using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_aud_drawingForms_kol2
{
    public partial class Form1 : Form
    {
        public Scene scene { get; set; }
        public string shapeType { get; set; } = "CIRCLE";
        public Form1()
        {
            InitializeComponent();
            this.scene = new Scene();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //this.scene.click(e.Location, shapeType); se se deshava so lev klik i select i draw
            if (e.Button == MouseButtons.Left)
            {
                if (shapeType.Equals("CIRCLE"))
                {
                    this.scene.addShape(new Circle(Color.Red, 30, e.Location));
                }
                else
                {
                    this.scene.addShape(new Square(Color.Red, 60, e.Location));
                }
            }
            else
            {
                this.scene.Hit(e.Location);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.scene.drawAll(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.scene.Pulse();
            Invalidate();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.shapeType = "SQUARE";
            squareToolStripMenuItem.Checked = true;
            circleToolStripMenuItem.Checked = false;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.shapeType = "CIRCLE";
            squareToolStripMenuItem.Checked = false;
            circleToolStripMenuItem.Checked = true;
        }
    }
}
