using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiAppProject
{
    public partial class DrawingForm : Form
    {
        private bool isDrawing;
        private Point lastPoint;

        public DrawingForm()
        {
            InitializeComponent();
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
