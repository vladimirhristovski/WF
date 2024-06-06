using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_kolokviumska_kol2
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            this.scene = new Scene();
            this.DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    scene.Click(e.Location);
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    scene.AddCircle(new Circle(e.Location));
                }
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.PickCircle();
            Invalidate();
            tslPoints.Text = $"Points: {scene.Points}";

            if (scene.GameOver())
            {
                scene.PickCircle();
                Invalidate();
                timer1.Stop();
                if (MessageBox.Show("Game over", "Game over", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scene = new Scene();
                    tslPoints.Text = "Points: 0";
                    Invalidate();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
