using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_drawingLines_kol2
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Width, this.Height);
            this.DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                scene.AddPoint(e.Location);
                Invalidate();
                this.UpdateStatusLabel();
                scene.UndoStack.Clear();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                scene.Color = dlg.Color;
            }
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            scene.Thickness = 1;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
            thickToolStripMenuItem.Checked = false;
            scene.Thickness = 2;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = true;
            scene.Thickness = 3;
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
            scene.Positioner = !scene.Positioner;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.Cursor = e.Location;
            Invalidate();
        }

        private void UpdateStatusLabel()
        {
            tslNumberOfLines.Text = $"Lines: {scene.Lines.Count}";
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Undo();
            Invalidate();
            UpdateStatusLabel();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Redo(); 
            Invalidate();
            UpdateStatusLabel();
        }
    }
}
