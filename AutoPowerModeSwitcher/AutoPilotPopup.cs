using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{
    public partial class AutoPilotPopup
    {
        public AutoPilotPopup()
        {
            InitializeComponent();
        }
        private void AutoPilotPopup_Load(object sender, EventArgs e)
        {
            Timer1.Start();

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Label3.Text = Conversions.ToString(My.MySettingsProperty.Settings.AutoPilotEnabled);
            if (Label3.Text == "True")
            {
                String1.Text = "AutoPilot is enabled!";
                String2.Text = "We will take care of you!";
                Panel1.Visible = false;
                String2.Location = new Point(178, 77);
            }

            else
            {
                Panel1.Location = new Point(12, 21);

                Panel1.Visible = true;
                String1.Text = "AutoPilot is disabled!";
                String2.Text = "Turn it back on for optimal experience!";
                String2.Location = new Point(135, 77);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}