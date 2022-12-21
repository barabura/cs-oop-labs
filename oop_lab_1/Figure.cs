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
        private Point[] _vertexes;

        public int speed = 1;
        public int pulse = 1;
        public Color figureColor = Color.Green;

        private Point[] HandleVertexes(string[] input)
        {
            Point[] handledVertexes = new Point[input.Length];

            for (int i = 0; i < handledVertexes.Length; i++)
            {
                try
                {
                    string[] splitted = input[i].Split(',');

                    handledVertexes[i] = new Point(Int32.Parse(splitted[0]), Int32.Parse(splitted[1]));
                }
                catch
                {
                    MessageBox.Show("Invalid input! You can only use digits, '+', '-' and ', ' as a delimiter.", "Error");
                    return null;
                }
            }
            return handledVertexes;
        }

        public string[] Vertexes
        {
            set
            { _vertexes = this.HandleVertexes(value); }
        }

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
                delta = Math.Abs((float)Math.Cos(angle * pulse));
                // delta = Math.Abs((float)Math.Cos(angle * pulse) * 20);

                i = i + speed / 3;
                pbox.Invalidate();
            };

            if (!visible)
                return;

            // float scaledDelta = delta * scale;

            Pen myPen = new Pen(figureColor, 2);

            if (fgBasePoint.X == 0 && fgBasePoint.Y == 0)
                return;
            
            /* 
             * Figure drawing
             */
            // top line for 2 blocks --
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[1].X * scale * delta,
                fgBasePoint.Y + _vertexes[1].Y * scale * delta,
                fgBasePoint.X + _vertexes[4].X * scale * delta,
                fgBasePoint.Y + _vertexes[4].Y * scale * delta
            );
            // right line for 2 blocks |
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[4].X * scale * delta,
                fgBasePoint.Y + _vertexes[4].Y * scale * delta,
                fgBasePoint.X + _vertexes[5].X * scale * delta,
                fgBasePoint.Y + _vertexes[5].Y * scale * delta
            );
            // bottom line for 2 blocks __
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[5].X * scale * delta,
                fgBasePoint.Y + _vertexes[5].Y * scale * delta,
                fgBasePoint.X + _vertexes[0].X * scale * delta,
                fgBasePoint.Y + _vertexes[0].Y * scale * delta
            );
            // left line for 2 blocks |
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[0].X * scale * delta,
                fgBasePoint.Y + _vertexes[0].Y * scale * delta,
                fgBasePoint.X + _vertexes[1].X * scale * delta,
                fgBasePoint.Y + _vertexes[1].Y * scale * delta
            );
            // middle line for 2 blocks
            g.DrawLine(
                myPen,
                fgBasePoint.X + (_vertexes[1].X + _vertexes[4].X) * scale * delta / 2,
                fgBasePoint.Y + (_vertexes[1].Y + _vertexes[4].Y) * scale * delta / 2,
                fgBasePoint.X + (_vertexes[0].X + _vertexes[5].X) * scale * delta / 2,
                fgBasePoint.Y + (_vertexes[0].Y + _vertexes[5].Y) * scale * delta / 2
            );
            
            // left line for top block |
            g.DrawLine(
                myPen,
                fgBasePoint.X + (_vertexes[1].X + (_vertexes[1].X + _vertexes[4].X) / 2) * scale * delta / 2,
                fgBasePoint.Y + (_vertexes[1].Y + (_vertexes[1].Y + _vertexes[4].Y) / 2) * scale * delta / 2,
                fgBasePoint.X + _vertexes[2].X * scale * delta,
                fgBasePoint.Y + _vertexes[2].Y * scale * delta
            );
            // top line for top block -
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[2].X * scale * delta,
                fgBasePoint.Y + _vertexes[2].Y * scale * delta,
                fgBasePoint.X + _vertexes[3].X * scale * delta,
                fgBasePoint.Y + _vertexes[3].Y * scale * delta
            );
            // right line for top block |
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[3].X * scale * delta,
                fgBasePoint.Y + _vertexes[3].Y * scale * delta,
                fgBasePoint.X + (_vertexes[4].X + (_vertexes[1].X + _vertexes[4].X) / 2) * scale * delta / 2,
                fgBasePoint.Y + (_vertexes[4].Y + (_vertexes[1].Y + _vertexes[4].Y) / 2) * scale * delta / 2
            );
            // right line for bottom block |
            g.DrawLine(
                myPen,
                fgBasePoint.X + (_vertexes[5].X + (_vertexes[0].X + _vertexes[5].X) / 2) * scale * delta / 2,
                fgBasePoint.Y + (_vertexes[5].Y + (_vertexes[0].Y + _vertexes[5].Y) / 2) * scale * delta / 2,
                fgBasePoint.X + _vertexes[6].X * scale * delta,
                fgBasePoint.Y + _vertexes[6].Y * scale * delta
            );
            // bottom line for bottom block _
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[6].X * scale * delta,
                fgBasePoint.Y + _vertexes[6].Y * scale * delta,
                fgBasePoint.X + _vertexes[7].X * scale * delta,
                fgBasePoint.Y + _vertexes[7].Y * scale * delta
            );
            // left line for bottom block |
            g.DrawLine(
                myPen,
                fgBasePoint.X + _vertexes[7].X * scale * delta,
                fgBasePoint.Y + _vertexes[7].Y * scale * delta,
                fgBasePoint.X + (_vertexes[0].X + (_vertexes[0].X + _vertexes[5].X) / 2) * scale * delta / 2,
                fgBasePoint.Y + (_vertexes[0].Y + (_vertexes[0].Y + _vertexes[5].Y) / 2) * scale * delta / 2
            );

            Font vertexesFont = new Font("Microsoft Sans Serif", 20 * delta * scale);
            Brush fontBrush = new SolidBrush(Color.Black); //??????????

            /* 
             * Vertexes setting 
             */
            g.DrawString(
                "0",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + (_vertexes[0].X - 20) * scale * delta,
                fgBasePoint.Y + _vertexes[0].Y * scale * delta
            );
            g.DrawString(
                "1",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + (_vertexes[1].X - 20) * scale * delta,
                fgBasePoint.Y + (_vertexes[1].Y - 35) * scale * delta
            );
            g.DrawString(
                "2",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + (_vertexes[2].X - 20) * scale * delta,
                fgBasePoint.Y + (_vertexes[2].Y - 35) * scale * delta
            );
            g.DrawString(
                "3",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + _vertexes[3].X * scale * delta,
                fgBasePoint.Y + (_vertexes[3].Y - 35) * scale * delta
            );
            g.DrawString(
                "4",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + _vertexes[4].X * scale * delta,
                fgBasePoint.Y + (_vertexes[4].Y - 35) * scale * delta
            );
            g.DrawString(
                "5",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + _vertexes[5].X * scale * delta,
                fgBasePoint.Y + _vertexes[5].Y * scale * delta
            );
            g.DrawString(
                "6",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + _vertexes[6].X * scale * delta,
                fgBasePoint.Y + _vertexes[6].Y * scale * delta
            );
            g.DrawString(
                "7",
                vertexesFont,
                fontBrush,
                fgBasePoint.X + (_vertexes[7].X - 20) * scale * delta,
                fgBasePoint.Y + _vertexes[7].Y * scale * delta
            );
        }

        public void RunPoint()
        {
            visible = true;
            timer.Start();
        }
    }
}
