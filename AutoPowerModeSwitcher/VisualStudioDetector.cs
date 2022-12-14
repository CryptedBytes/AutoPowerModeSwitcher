using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{
    public partial class VisualStudioDetector
    {
        public VisualStudioDetector()
        {
            InitializeComponent();
        }
        private void Engine_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "VisualStudio Detector's engine ticked");
            Label3.Text = (Conversions.ToDouble(Label3.Text) + 1d).ToString();
            Process[] VS;
            VS = Process.GetProcessesByName("AutoPowerModeSwitcher.vshost");
            if (VS.Count() > 0)   // Process is running
            {

                if (Conversions.ToDouble(Label3.Text) <= 1d)
                {
                    Engine.Stop();
                    Dispose();
                }

                else
                {
                    Show();
                }
            }



            else      // Process is not running
            {
                Hide();
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void HideThisFormEngine_Tick(object sender, EventArgs e)
        {
            Hide();

            if (My.MySettingsProperty.Settings.DisableDeveloperDetectorService == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DisableDeveloperDetectorService flag is set to True. Disabled VisualStudioDetector Services.");
                Dispose();
                HideThisFormEngine.Stop();
            }
            else
            {
                Engine.Start();
                HideThisFormEngine.Stop();
            }

        }

        private void VisualStudioDetector_Load(object sender, EventArgs e)
        {

            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized VisualStudioDetector");

        }
    }
}