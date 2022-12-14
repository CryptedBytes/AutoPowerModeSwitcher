using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace AutoPowerModeSwitcher
{
    public partial class BootManager
    {
        public BootManager()
        {
            InitializeComponent();
        }

        private void Engine_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(1);
            if (ProgressBar1.Value == 50)
            {

                Interaction.Shell(@"C:\Program Files\iTunes\iTunes.exe", AppWinStyle.MinimizedFocus);
                // Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", AppWinStyle.MinimizedFocus)

                try
                {
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "BOOTMANAGER: An exception occured when starting apps. Ex: " + ex.ToString());
                }




            }


            if (ProgressBar1.Value == 100)
            {
                My.MyProject.Forms.UserInterface.Show();
                Dispose();



            }

        }

        private void BootManager_Load(object sender, EventArgs e)
        {
            NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_cpu22;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.BootManagerEnabled = false;
            My.MyProject.Forms.UserInterface.Show();
            Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}