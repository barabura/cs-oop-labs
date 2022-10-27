using System.Drawing;
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
            hypocycloid.DrawPoint(e.Graphics);
            hypocycloid.scale = tbarFTrajectorySize.Value * scaleMultiplier;
            hypocycloid.frequency = tbarFFrequency.Value * 2;
            hypocycloid.speed = tbarPointSpeed.Value;
            hypocycloid.pulse = tbarPointPulse.Value;

            //movingPoint.DrawPoint(pboxWorkSpace, e.Graphics);
            //movingPoint.scale = tbarFTrajectorySize.Value * scaleMultiplier;

            pboxWorkSpace.Invalidate();
        }

        private void btStart_Click(object sender, System.EventArgs e)
        {
            hypocycloid.RunPoint();
        }
    }
}
