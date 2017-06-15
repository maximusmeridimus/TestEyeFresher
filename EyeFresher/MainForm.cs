using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace EyeFresher
{
    public partial class MainForm : MetroForm
    {
        //1 ms = 1 tick
        //1 sec = 1000 tick
        //1 min = 60'000 tick
        //1 h = 3600'000 tick
        //1d = 86'400'000 tick
        //int seconds = Environment.TickCount / 1000;
        int seconds = 0;
        int days = 0;
        int hours = 0;
        int minutes = 0;
        int timeDelay = Properties.Settings.Default.TimeDelay; //delay in minutes

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            days = seconds / 86400;
            hours = (seconds % 86400) / 3600;
            minutes = (seconds % 3600) / 60;
            seconds = (seconds % 60);

            timer.Enabled = true;

            notificationTimer.Interval = timeDelay * 1000 * 60;
            notificationTimer.Enabled = true;

        }

        

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes > 59)
            {
                minutes = 0;
                hours++;
            }
            if (hours > 12)
            {
                hours = 0;
                days++;
            }

            lbTimer.Text = String.Format("{0}:{1}:{2}:{3}",
                ToFormat00(days), ToFormat00(hours), ToFormat00(minutes), ToFormat00(seconds));
        }
        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            Notificate();
        }
        private string ToFormat00(int a)
        {
            if (a < 10)
            {
                return String.Format("0{0}", a);
            }
            return String.Format("{0}", a);
        }

        private void Notificate()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is NotificationForm) return;
            }

            //dimming
            ushort currentBrightness = BrightnessWork.GetMonitorBrightness();
            int chosedBrightness = Properties.Settings.Default.DimmingPercentage;
            if (currentBrightness > chosedBrightness)
            {
                BrightnessWork.SetMonitorBrightness((ushort)(currentBrightness - chosedBrightness));
            }
            else
            {
                BrightnessWork.SetMonitorBrightness(0);
            }

            //notification

            NotificationForm notificationForm = new NotificationForm();
            notificationForm.StartPosition = FormStartPosition.Manual;
            notificationForm.Location = new Point(1920 - notificationForm.Width,
                1040 - notificationForm.Height);
            notificationForm.Opacity = (100 - Properties.Settings.Default.OpacityPercentage) / 100.0;
            Color nfBackColor = PixelWork.CalculateAverageColor();
            Color nfForeColor = PixelWork.CalculateContrastColor(nfBackColor);
            notificationForm.BackColor = nfBackColor;
            notificationForm.ForeColor = nfForeColor;
            notificationForm.Show();
        }


        private void btnPreferences_Click(object sender, EventArgs e)
        {
            PreferenceForm pf = new PreferenceForm();
            pf.Location = new Point(Location.X + Size.Width, Location.Y);
            pf.Show();
        }

        private void btnShowSample_Click(object sender, EventArgs e)
        {
            Notificate();
        }

        private void tgDontDisturb_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DontDisturb = tgDontDisturb.Enabled;
        }

        private void tgStop1h_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Stop1h = tgStop1h.Enabled;
        }

        private void tgStop2h_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Stop2h = tgStop2h.Enabled;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Show();
                notifyIcon.Visible = false;
                WindowState = FormWindowState.Normal;
            }
        }

      
    }
}
