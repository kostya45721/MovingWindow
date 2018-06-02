using System;
using System.Windows.Forms;

namespace MovingWindow
{
    public partial class MovingWindow : Form
    {
        private int y;
        private int x;

        public MovingWindow()
        {
            InitializeComponent();
        }

        private void AllTimerKeyStop()
        {
            timerKeyDown.Stop();
            timerKeyUp.Stop();
            timerKeyLeft.Stop();
            timerKeyRight.Stop();
        }

        private void MovingWindow_KeyUp(object sender, KeyEventArgs e)
        {
            y = Location.Y;
            x = Location.X;

            if (e.KeyData == Keys.Up)
            {
                AllTimerKeyStop();
                timerKeyUp.Start();
            }
            else if (e.KeyData == Keys.Down)
            {
                AllTimerKeyStop();
                timerKeyDown.Start();
            }
            else if (e.KeyData == Keys.Left)
            {
                AllTimerKeyStop();
                timerKeyLeft.Start();
            }
            else if (e.KeyData == Keys.Right)
            {
                AllTimerKeyStop();
                timerKeyRight.Start();
            }
            else if (e.KeyData == Keys.Enter)
            {
                AllTimerKeyStop();
                CenterToScreen();
            }
        }
        
        private void TimerKeyDown_Tick(object sender, EventArgs e)
        {
            y += 6;
            SetDesktopLocation(x, y);
            if (Location.Y > Screen.PrimaryScreen.Bounds.Height - Height)
            {
                timerKeyDown.Stop();
                timerKeyUp.Start();
            }
        }

        private void TimerKeyLeft_Tick(object sender, EventArgs e)
        {
            x -= 6;
            SetDesktopLocation(x, y);
            if (Location.X < 0)
            {
                timerKeyLeft.Stop();
                timerKeyRight.Start();
            }
        }

        private void TimerKeyRight_Tick(object sender, EventArgs e)
        {
            x += 6;
            SetDesktopLocation(x, y);
            if (Location.X > Screen.PrimaryScreen.Bounds.Width - Width)
            {
                timerKeyRight.Stop();
                timerKeyLeft.Start();
            }
        }

        private void TimerKeyUp_Tick(object sender, EventArgs e)
        {
            y -= 6;
            SetDesktopLocation(x, y);
            if (Location.Y < 0)
            {
                timerKeyUp.Stop();
                timerKeyDown.Start();
            }

        }
    }
}