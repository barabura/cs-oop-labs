﻿using System.Drawing;
using System.Windows.Forms;

namespace oop_lab_1
{
    public partial class frmMain : Form
    {
        private Figure hypocycloid;
        private float scaleMultiplier = 0.02f;

        public frmMain()
        {
            InitializeComponent();
            hypocycloid = new Figure();
        }

        private void pboxWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            hypocycloid.Draw(pboxWorkSpace, e.Graphics);
            hypocycloid.DrawFigure(pboxWorkSpace, e.Graphics);
            hypocycloid.scale = tbarFTrajectorySize.Value * scaleMultiplier;
            hypocycloid.frequency = tbarFFrequency.Value * 2;
            hypocycloid.speed = tbarPointSpeed.Value;
            hypocycloid.pulse = tbarPointPulse.Value;

            //movingPoint.DrawPoint(pboxWorkSpace, e.Graphics);
            //movingPoint.scale = tbarFTrajectorySize.Value * scaleMultiplier;
            //pboxWorkSpace.Invalidate();
        }

        private void btStart_Click(object sender, System.EventArgs e)
        {
            hypocycloid.RunPoint();
            pboxWorkSpace.Invalidate();
        }

        private void btnFigureColor_Click(object sender, System.EventArgs e)
        {
            if (cdFigureColor.ShowDialog() == DialogResult.OK)
            {
                hypocycloid.figureColor = cdFigureColor.Color;
                pboxWorkSpace.Invalidate();
            }
        }

        private void tbarFTrajectorySize_ValueChanged(object sender, System.EventArgs e)
        {
            pboxWorkSpace.Invalidate();
        }

        private void tbarFFrequency_ValueChanged(object sender, System.EventArgs e)
        {
            pboxWorkSpace.Invalidate();
        }

        private void tbarPointSpeed_ValueChanged(object sender, System.EventArgs e)
        {
            pboxWorkSpace.Invalidate();
        }

        private void tbarPointPulse_ValueChanged(object sender, System.EventArgs e)
        {
            pboxWorkSpace.Invalidate();
        }

        private void btnBackgroundColor_Click(object sender, System.EventArgs e)
        {
            if (cdBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                pboxWorkSpace.BackColor = cdBackgroundColor.Color;
                pboxWorkSpace.Invalidate();
            }
        }

        private void btnTrajectoryColor_Click(object sender, System.EventArgs e)
        {
            if (cdTrajectoryColor.ShowDialog() == DialogResult.OK)
            {
                hypocycloid.trajectoryColor = cdTrajectoryColor.Color;
                pboxWorkSpace.Invalidate();
            }
        }
    }
}
