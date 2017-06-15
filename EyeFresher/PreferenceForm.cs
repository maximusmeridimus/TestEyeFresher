using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace EyeFresher
{
    public partial class PreferenceForm : MetroForm
    {
        int opacity = Properties.Settings.Default.OpacityPercentage;
        int dimming = Properties.Settings.Default.DimmingPercentage;
        int delayTime = Properties.Settings.Default.TimeDelay;
        bool autorun = Properties.Settings.Default.AutoRun;

        public PreferenceForm()
        {
            InitializeComponent();
        }
        private void PreferenceForm_Load(object sender, EventArgs e)
        {
            lbOpacityPercentage.Text = String.Format("{0}%", opacity);
            lbDimmingPercentage.Text = String.Format("{0}%", dimming);

            tbDimming.Value = opacity;
            tbOpacity.Value = opacity;

            tbDelayTime.Text = String.Format("{0}", delayTime);
            tgAutoRun.Enabled = autorun;
        }

        private void tbOpacity_Scroll(object sender, ScrollEventArgs e)
        {
            opacity = tbOpacity.Value;
            Properties.Settings.Default.OpacityPercentage = opacity;
            lbOpacityPercentage.Text = String.Format("{0}%", opacity);
            Save();
        }

        private void tbDimming_Scroll(object sender, ScrollEventArgs e)
        {
            dimming = tbDimming.Value;
            Properties.Settings.Default.DimmingPercentage = dimming;
            lbDimmingPercentage.Text = String.Format("{0}%", dimming);
            Save();
        }

        private void tbDelayTime_Click(object sender, EventArgs e)
        {
            delayTime = int.Parse(tbDelayTime.Text);
            Properties.Settings.Default.TimeDelay = delayTime;
            Save();
        }
        private void tgAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            autorun = tgAutoRun.Enabled;
            Properties.Settings.Default.AutoRun = autorun;
            Save();

            if(autorun)
            {
                AutoRun.AddToAutorun();
            }
            else
            {
                AutoRun.DeleteFromAutorun();
            }
        }

        private void Save()
        {
            Properties.Settings.Default.Save();
        }
    }
}
