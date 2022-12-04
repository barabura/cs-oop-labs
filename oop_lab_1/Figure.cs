using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace oop_labs
{
    internal class Figure : Hypocycloid
    {
        protected PointF fgBasePoint;

        private Timer timer;
        private bool visible = false;
        private float delta = 20;

        public int speed = 1;
        public int pulse = 1;
        public Color figureColor = Color.Green;

        public void DrawFigure(PictureBox pbox, Graphics g)
        {
            int i = 0;

            float angle = 0;
            float deltaAngle = 2 * (float)Math.PI / points.Length;

            timer = new Timer();
            timer.Interval = 100;
            timer.Elapsed += (_, __) =>
            {
                if (i >= points.Length - speed / 3)
                {
                    i = 0;
                    return;
                }

                fgBasePoint = points[i];

                angle = angle - deltaAngle;
                delta = Math.Abs((float)Math.Cos(angle * pulse) * 20);

                i = i + speed / 3;
                pbox.Invalidate();
            };

            if (!visible)
                return;

            float scaledDelta = delta * scale;

            Pen myPen = new Pen(figureColor, 2);

            if (fgBasePoint.X != 0 && fgBasePoint.Y != 0)
            {
                // top line for 2 blocks --
                g.DrawLine(
                    myPen,
                    fgBasePoint.X - scaledDelta * 6,
                    fgBasePoint.Y - scaledDelta,
                    fgBasePoint.X + scaledDelta * 6,
                    fgBasePoint.Y - scaledDelta
                );
                // right line for 2 blocks |
                g.DrawLine(
                   myPen,
                   fgBasePoint.X + scaledDelta * 6,
                   fgBasePoint.Y - scaledDelta,
                   fgBasePoint.X + scaledDelta * 6,
                   fgBasePoint.Y + scaledDelta
                );
                // bottom line for 2 blocks __
                g.DrawLine(
                   myPen,
                   fgBasePoint.X + scaledDelta * 6,
                   fgBasePoint.Y + scaledDelta,
                   fgBasePoint.X - scaledDelta * 6,
                   fgBasePoint.Y + scaledDelta
                );
                // left line for 2 blocks |
                g.DrawLine(
                   myPen,
                   fgBasePoint.X - scaledDelta * 6,
                   fgBasePoint.Y + scaledDelta,
                   fgBasePoint.X - scaledDelta * 6,
                   fgBasePoint.Y - scaledDelta
                );
                // middle line for 2 blocks |
                g.DrawLine(
                   myPen,
                   fgBasePoint.X,
                   fgBasePoint.Y + scaledDelta,
                   fgBasePoint.X,
                   fgBasePoint.Y - scaledDelta
                );
                // left line for top block |
                g.DrawLine(
                   myPen,
                   fgBasePoint.X - scaledDelta * 3,
                   fgBasePoint.Y - scaledDelta,
                   fgBasePoint.X - scaledDelta * 3,
                   fgBasePoint.Y - scaledDelta * 3
                );
                // top line for top block -
                g.DrawLine(
                   myPen,
                   fgBasePoint.X - scaledDelta * 3,
                   fgBasePoint.Y - scaledDelta * 3,
                   fgBasePoint.X + scaledDelta * 3,
                   fgBasePoint.Y - scaledDelta * 3
                );
                // right line for top block |
                g.DrawLine(
                   myPen,
                   fgBasePoint.X + scaledDelta * 3,
                   fgBasePoint.Y - scaledDelta * 3,
                   fgBasePoint.X + scaledDelta * 3,
                   fgBasePoint.Y - scaledDelta
                );
                // right line for bottom block |
                g.DrawLine(
                   myPen,
                   fgBasePoint.X + scaledDelta * 3,
                   fgBasePoint.Y + scaledDelta,
                   fgBasePoint.X + scaledDelta * 3,
                   fgBasePoint.Y + scaledDelta * 3
                );
                // bottom line for bottom block _
                g.DrawLine(
                   myPen,
                   fgBasePoint.X + scaledDelta * 3,
                   fgBasePoint.Y + scaledDelta * 3,
                   fgBasePoint.X - scaledDelta * 3,
                   fgBasePoint.Y + scaledDelta * 3
                );
                // left line for bottom block |
                g.DrawLine(
                   myPen,
                   fgBasePoint.X - scaledDelta * 3,
                   fgBasePoint.Y + scaledDelta * 3,
                   fgBasePoint.X - scaledDelta * 3,
                   fgBasePoint.Y + scaledDelta
                );
            }
        }

        public void RunPoint()
        {
            visible = true;
            timer.Start();
        }
    }
}
