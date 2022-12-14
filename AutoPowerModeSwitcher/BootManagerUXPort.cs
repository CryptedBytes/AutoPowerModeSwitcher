using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{
    public partial class BootManagerUXPort
    {
        public BootManagerUXPort()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);


            animateWin(this, true);
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Button1.PerformClick();

            Timeout.Stop();

            Hide();

        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            for (double FadeIn = 0.0d; FadeIn <= 1.1d; FadeIn += 0.1d)
            {
                Opacity = FadeIn;
                Refresh();
                System.Threading.Thread.Sleep(100);
            }
            Animation.Stop();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        public enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x1,
            AW_HOR_NEGATIVE = 0x2,
            AW_VER_POSITIVE = 0x4,
            AW_VER_NEGATIVE = 0x8,
            AW_CENTER = 0x10,
            AW_HIDE = 0x10000,
            AW_ACTIVATE = 0x20000,
            AW_SLIDE = 0x40000,
            AW_BLEND = 0x80000
        }
        private Form f1;
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(IntPtr hwnd, int time, AnimateWindowFlags flags);
        public void Main()
        {
            int xx = Screen.PrimaryScreen.Bounds.Width - f1.Size.Width;
            int yy = (int)Math.Round(Screen.PrimaryScreen.Bounds.Height / 2d - f1.Size.Height / 2d);
            f1.Location = new Point(xx, yy);
            Application.Run(f1);
        }
        public void animateWin(Form frmToAnimate, bool showForm)
        {
            f1 = frmToAnimate;
            if (showForm)
            {
                AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_NEGATIVE | AnimateWindowFlags.AW_SLIDE);
            }
            else
            {
                AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_POSITIVE | AnimateWindowFlags.AW_HIDE);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            animateWin(this, false);
        }

        private void Engine_Tick(object sender, EventArgs e)
        {
            Timeout.Stop();

            ProgressBar1.Increment(1);
            if (ProgressBar1.Value == 2)
            {
                // check if the chrome is started before the app launch 
                Process[] p;
                p = Process.GetProcessesByName("chrome.exe");
                if (p.Count() > 0)
                {
                    ProcessLabel.Text = "True";       // Process is running
                }
                else
                {
                    ProcessLabel.Text = "False";
                }  // Process is not running
            }
            if (ProgressBar1.Value == 3)
            {
                if (Conversions.ToBoolean(ProcessLabel.Text) == true)
                {
                }
                // if chrome is already running do not prefect it
                else
                {
                    try // prefect chrome
                    {
                        Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("BOOTMANAGER: failed to start chrome");
                    }
                }


                if (CheckBox3.Checked == true) // prefect itunes
                {
                    try
                    {
                        Process.Start(@"C:\Program Files\iTunes\iTunes.exe");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("BOOTMANAGER: failed to start itunes");
                    }
                }
                else
                {

                }
            }
            if (ProgressBar1.Value == 22) // now kill the prefected apps
            {
                if (Conversions.ToBoolean(ProcessLabel.Text) == true)
                {
                }
                // if chrome launched by user before app start do not kill it
                else
                {
                    Interaction.Shell("taskkill -f /im chrome.exe", AppWinStyle.Hide);
                }

                Interaction.Shell("taskkill -f /im iTunes.exe", AppWinStyle.Hide);
            }
            if (ProgressBar1.Value == 25)
            {
                My.MyProject.Forms.BootManager.Show();
                Close();


            }
        }

        private void Timeout_Tick(object sender, EventArgs e)
        {
            timePast.Text = (Conversions.ToDouble(timePast.Text) + 1d).ToString();
            if (Conversions.ToDouble(timePast.Text) > 12d)
            {


                Engine.Start();
                Timeout.Stop();

            }

            // timeLeft.text = timeLeft.Text - timePast.text

        }

        private void timePast_TextChanged(object sender, EventArgs e)
        {
            timeLeftEngine.Start();

        }

        private void timeLeftEngine_Tick(object sender, EventArgs e)
        {
            timeLeft.Text = (Conversions.ToDouble(timeLeft.Text) - 1d).ToString();
            timeLeftEngine.Stop();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.BootManager.Show();


            Close();
            Engine.Stop();
        }
    }
}