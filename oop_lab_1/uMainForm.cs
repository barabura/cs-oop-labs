using System.Drawing;
using System.Windows.Forms;

namespace oop_lab_1
{
    public partial class frmMain : Form
    {
        private Hypocycloid hypocycloid;
        private float scaleMultiplier = 0.02f;

        public frmMain()
        {
            InitializeComponent();
            hypocycloid = new Hypocycloid();
        }

        private void pboxWorkSpace_Paint(object sender, PaintEventArgs e)
        {
            hypocycloid.Draw(pboxWorkSpace, e.Graphics);
            hypocycloid.scale = tbarFTrajectorySize.Value * scaleMultiplier;
            hypocycloid.frequency = tbarFFrequency.Value * 2;

            pboxWorkSpace.Invalidate();
        }
    }
}
