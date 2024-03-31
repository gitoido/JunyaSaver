
namespace JunyaSaver
{
    public partial class ScreenSaverForm : Form
    {
        private Point mouseLocation;

        private Random rand = new Random();

        public ScreenSaverForm(Rectangle bounds)
        {
            InitializeComponent();
            Bounds = bounds;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

           // moveTimer.Interval = 3000;
           // moveTimer.Tick += new EventHandler(moveTimer_Tick);
           // moveTimer.Start();
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                if (
                    Math.Abs(e.X - mouseLocation.X) > 5 ||
                    Math.Abs(e.Y - mouseLocation.Y) > 5
                ) {
                    Application.Exit();
                }
            }

            mouseLocation = e.Location;
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
