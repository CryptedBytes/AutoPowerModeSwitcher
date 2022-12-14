using System;
using AutoPowerModeSwitcher.My;

namespace AutoPowerModeSwitcher
{

    public partial class SettingsDatabase
    {
        public SettingsDatabase()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                TopMost = true;
            }

            else
            {
                TopMost = false;

            }
        }

        private void Engine_Tick(object sender, EventArgs e)
        {
            Label1.Text = "TopMost= " + MySettingsProperty.Settings.TopMost;
            Label2.Text = "CheckInvertalEqualsFrequent= " + MySettingsProperty.Settings.CheckInvertalEqualsFrequent;
            Label3.Text = "PreferredPowerModeEqualsBalanced= " + MySettingsProperty.Settings.PreferredPowerModeEqualsBalanced;
            Label4.Text = "GamingPowerModeEquals70Freq= " + MySettingsProperty.Settings.GamingPowerModeEquals70Freq;
            Label5.Text = "TargetProcessToString= " + MySettingsProperty.Settings.TargetProcess;
            Label6.Text = "StartOnBootEnabled= " + MySettingsProperty.Settings.StartOnBootEnabled;
            Label7.Text = "StartMinimized= " + MySettingsProperty.Settings.StartMinimized;
            Label8.Text = "TopMost= " + MySettingsProperty.Settings.TopMost;
        }
    }
}