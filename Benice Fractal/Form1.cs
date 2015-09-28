using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spirograph_Generator
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        // An bitmap will hold the locations of where the fractal is drawn
        Bitmap Fractal;

        // This is the previously drawn point
        Point previousPoint;

        // This boolean holds whether or not a point has been drawn
        bool hasDrawn;

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize the fractal bitmap
            Fractal = new Bitmap(pctbOutput.Width, pctbOutput.Height);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            // Reset the has drawn boolean
            hasDrawn = false;

            // Reset the fractal bitmap
            Fractal = new Bitmap(pctbOutput.Width, pctbOutput.Height);

            // Graphics must be created in order to draw to the picturebox
            Graphics g = Graphics.FromHwnd(pctbOutput.Handle);

            // Loop through one full revolution of an angle (theta) and draw the circles accordingly
            for (double theta = 0; theta <= 2 * Math.PI; theta = theta + (double)(1 / nudResolution.Value) * 0.01 /* the speed of the is inversely proportional to the program dot resolution  */)
            {
                // Draw the fractal
                pctbOutput.Invalidate();
                pctbOutput.Update();

                // Draw the recursive circles
                RecursiveCircles(theta, (int)nudMultiplier.Value, (int)nudDivisor.Value, (int)nudIterations.Value, pctbOutput.Width / 2, pctbOutput.Height / 2, pctbOutput.Width / 6, g, Fractal);
            }
        }

        private void RecursiveCircles(double theta /* this is the progressive angle the fractal will draw according to */, int mult /* this is the value that the angle will be multiplied by every iteration */, int div /* this is the value that the size of the   circles will be divided by every iteration */,
          int n /* this is the number of circles that will be drawn / the number of iterations the method will run through */, int a /* this is the x-coordinate of the center of the circle */, int b /* this is the y-coordinate of the center of the circle */, int radius /* this is the radius of the circle */, Graphics g /* this is the graphics that the Fractal will be drawn to */, Bitmap fractal /* this is the fractal array */)
        {
            // Draw the current circle
            g.DrawEllipse(new Pen(Color.Green), a - radius, b - radius, 2 * radius, 2 * radius);

            // At the last circle, set the location of the circle to the fractal image and end recursive iteration
            if (n == 1)
            {
                if (hasDrawn == false)
                {
                    // Draw the new point and update the previous point
                    previousPoint = new Point(a, b);
                    fractal.SetPixel(a, b, Color.Red);
                    hasDrawn = true;
                }
                else
                {
                    // These graphics will be used to connect the dots drawn in the fractal image
                    Graphics d = Graphics.FromImage(fractal);
                    
                    // Draw the new point and connect it with the previous point
                    fractal.SetPixel(a, b, Color.Red);
                    d.DrawLine(new Pen(Color.Red), previousPoint, new Point(a, b));
                    previousPoint = new Point(a, b);
                }
                // This is the final circle, do not continue recursive iteration
                return;
            }

            // These is the center of the next circle
            Point Center = new Point();
            Center.X = (int)((double)a - (radius + radius / div) * Math.Sin((double)theta));
            Center.Y = (int)((double)b - (radius + radius / div) * Math.Cos((double)theta));

            // Recursivly run through the method
            RecursiveCircles(mult * theta, mult, div, n - 1, Center.X, Center.Y, radius / div, g, fractal);
        }

        private void pctbOutput_Paint(object sender, PaintEventArgs e)
        {
            // The background is black
            e.Graphics.Clear(Color.Black);

            // Draw the fractal
            e.Graphics.DrawImage(Fractal, 0, 0);
        }
    }
}
