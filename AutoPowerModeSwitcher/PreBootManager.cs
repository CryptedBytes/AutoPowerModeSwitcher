using System;
using System.Diagnostics;

namespace AutoPowerModeSwitcher
{
    public partial class PreBootManager
    {
        public PreBootManager()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {


        }



        private void Engine_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(1);
            if (ProgressBar1.Value == 5)
            {
                if (CheckBox1.Checked == true)
                {
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                }
                if (CheckBox2.Checked == true)
                {
                    Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe");
                }

            }
        }

        private void PreBootManager_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("PreBootManager is not supported!");
        }
    }
}