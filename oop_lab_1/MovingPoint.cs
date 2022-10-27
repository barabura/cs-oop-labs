using System.Drawing;
using Timer = System.Timers.Timer;

namespace oop_lab_1
{
    internal class MovingPoint : Hypocycloid
    {
        protected PointF mpBasePoint;
        private Timer timer;
        private bool visible = false;

        public void DrawPoint(Graphics g)
        {
            int i = 0;
            timer = new Timer();
            timer.Interval = 100;
            timer.Elapsed += (_, __) =>
            {
                if (i >= points.Length - 1)
                    i = 0;
                mpBasePoint = points[i];
                ++i;
            };

            if (!visible)
                return;

            Pen greenPen = new Pen(Color.Green, 3);
            int d = 10;
            g.DrawEllipse(greenPen, mpBasePoint.X - d / 2, mpBasePoint.Y - d / 2, d, d);
        }

        public void RunPoint()
        {
            visible = true;
            timer.Start();
        }
    }
}
