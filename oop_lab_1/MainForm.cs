using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace oop_labs
{
    public partial class frmMain : Form
    {
        private Figure hypocycloid;
        private float scaleMultiplier = 0.02f;
        private string[] defaultFigureVertexes = ConfigurationManager.AppSettings.Get("defaultFigureVertexes").Split(';'); // = {"-120, 20", "-120, -20", "-60, -60", "60, -60", "120, -20", "120, 20", "60, 60", "-60, 60"};

        public frmMain()
        {
            InitializeComponent();
            hypocycloid = new Figure(); // load?
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            //string[] defaultFigureVertexes = { "-120, 20", "-120, -20", "-60, -60", "60, -60", "120, -20", "120, 20", "60, 60", "-60, 60" };
            tboxVertexes.Lines = defaultFigureVertexes;
            hypocycloid.Vertexes = tboxVertexes.Lines;
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

        private void pboxWorkSpace_SizeChanged(object sender, System.EventArgs e)
        {
            pboxWorkSpace.Invalidate();
        }

        private void btnRedrawFigure_Click(object sender, System.EventArgs e)
        {
            hypocycloid.Vertexes = tboxVertexes.Lines;
        }

        private void btnDefaultFigure_Click(object sender, System.EventArgs e)
        {
            tboxVertexes.Lines = defaultFigureVertexes;
            hypocycloid.Vertexes = tboxVertexes.Lines;
        }

        private void btnCopyToClipboard_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(tboxVertexes.Text);
        }

        private void btnPasteFromClipboard_Click(object sender, System.EventArgs e)
        {
            tboxVertexes.Text = Clipboard.GetText();
            hypocycloid.Vertexes = tboxVertexes.Lines;
        }
    }
}
