using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop_lab_1
{
    internal class Hypocycloid
    {
        private float r;
        private float R;
        private PointF basePoint;
        protected PointF[] points = new PointF[100];

        private float floatFi;
        private float floatDeltaFi;

        public float scale = 0.5f;
        public int frequency = 6;

        public void Draw(PictureBox pbox, Graphics g)
        {
            R = (pbox.Height < pbox.Width ? pbox.Height : pbox.Width) * scale / 2;
            r = R / frequency;
            basePoint = new PointF(pbox.Width / 2, pbox.Height / 2);

            Pen pen = new Pen(Color.Black, .1f);

            floatFi = 0;
            floatDeltaFi = 2 * (float)Math.PI / points.Length;

            for (int i = 0; i < points.Length; i++)
            {
                float x = (float)(basePoint.X + (R - r) * Math.Cos(floatFi) + r * Math.Cos((R - r) / r * floatFi));
                float y = (float)(basePoint.Y + (R - r) * Math.Sin(floatFi) - r * Math.Sin((R - r) / r * floatFi));

                if (floatFi < (float)Math.PI * -1)
                {
                    y = basePoint.Y;
                }

                points[i] = new PointF(x, y);
                 
                floatFi = floatFi - floatDeltaFi;
            }
            g.DrawPolygon(pen, points);
        }
    }
}