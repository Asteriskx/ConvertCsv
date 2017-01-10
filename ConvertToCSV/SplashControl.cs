using System.Drawing;
using System.Windows.Forms;

namespace ConvertToCSV
{
    public class SplashControl : Form
    {
        public SplashControl()
        {
            InitializeComponent();
        }

        private void SplashPaint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            ControlPaint.DrawBorder3D(e.Graphics, rect, Border3DStyle.Raised);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SplashControl
            // 
            this.BackgroundImage = Properties.Resources.icon_256;
            this.ClientSize = new　Size(256, 241);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "SplashControl";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}
