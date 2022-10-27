using System;
using System.Drawing;
using Timer = System.Timers.Timer;

namespace oop_lab_1
{
    internal class Figure : Hypocycloid
    {
        protected PointF fgBasePoint;

        private Timer timer;
        private bool visible = false;
        private float delta = 20;

        public int speed = 1;
        public int pulse = 1;

        public void DrawPoint(Graphics g)
        {

            int i = 0;

            float angle = 0;
            float deltaAngle = 2 * (float)Math.PI / points.Length;

            timer = new Timer();
            timer.Interval = 100;
            timer.Elapsed += (_, __) =>
            {
                if (i >= points.Length - speed / 3)
                    i = 0;
                fgBasePoint = points[i];
                
                angle = angle - deltaAngle;
                delta = Math.Abs((float)Math.Cos(angle * pulse) * 20);

                i = i + speed / 3;
            };

            if (!visible)
                return;

            float scaledDelta = delta * scale;

            Pen greenPen = new Pen(Color.Green, 2);
            g.DrawLine(
                greenPen, 
                fgBasePoint.X, 
                fgBasePoint.Y + scaledDelta * 0.5f, 
                fgBasePoint.X + scaledDelta * 4, 
                fgBasePoint.Y + scaledDelta * 0.5f
            );
            g.DrawLine(
                greenPen,
                fgBasePoint.X + scaledDelta * 4,
                fgBasePoint.Y + scaledDelta * 0.5f,
                fgBasePoint.X + scaledDelta * 4,
                fgBasePoint.Y - scaledDelta
            );
            g.DrawLine(
                greenPen,
                fgBasePoint.X + scaledDelta * 4,
                fgBasePoint.Y - scaledDelta,
                fgBasePoint.X,
                fgBasePoint.Y - scaledDelta
            );
            g.DrawLine(
                greenPen,
                fgBasePoint.X,
                fgBasePoint.Y - scaledDelta,
                fgBasePoint.X,
                fgBasePoint.Y + scaledDelta * 0.5f
            );
            // to be continued
        }

        public void RunPoint()
        {
            visible = true;
            timer.Start();
        }

    }
}
