using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{
    public partial class MemoryLeakTestingLab
    {
        public MemoryLeakTestingLab()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                PenTest1.Start();
            }
            else if (RadioButton2.Checked == true)
            {
                PenTest2.Start();
            }

            else if (RadioButton3.Checked == true)
            {
                PenTest3.Start();
            }
            else if (RadioButton4.Checked == true)
            {
                PenTest4.Start();
            }
            else
            {

                Interaction.MsgBox("Check at least one vulnerability");
            }
        }

        private void PenTest1_Tick(object sender, EventArgs e)
        {
            try
            {
                NotifyIcon1.Visible = true;
                NotifyIcon2.Visible = true;
                NotifyIcon3.Visible = true;
                NotifyIcon4.Visible = true;
                NotifyIcon1.Icon = My.Resources.Resources.AppIcon;
                NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_cpu22;
                NotifyIcon2.Icon = My.Resources.Resources.AppIcon;
                NotifyIcon3.Icon = My.Resources.Resources.NotifyIcon_cpu22;
                NotifyIcon2.Icon = My.Resources.Resources.AppIcon;
                NotifyIcon3.Icon = My.Resources.Resources.NotifyIcon_cpu22;
                NotifyIcon4.Icon = My.Resources.Resources.AppIcon;
                NotifyIcon4.Icon = My.Resources.Resources.NotifyIcon_cpu22;
            }
            catch (Exception ex)
            {

            }

        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PenTest1.Stop();
            PenTest3.Stop();
            PenTest2.Stop();

            NotifyIcon1.Dispose();

        }

        private void PenTest2_Tick(object sender, EventArgs e)
        {
            PictureBox1.Image = My.Resources.Resources.CryptedBytesLogo;
            PictureBox1.Image = My.Resources.Resources.tumblr_inline_np9hcuZr931qd3uu5_540;
        }

        private void PenTest3_Tick(object sender, EventArgs e)
        {
            Opacity = 50d;
            Visible = false;
            Visible = true;
            Opacity = 99d;

        }

        private static Random random = new Random();

        private void PenTest4_Tick(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i <= 5; i++)

                Label1.Text = Convert.ToString(random.Next(1, 600));
            Width = Conversions.ToInteger(Label1.Text);
            Height = Conversions.ToInteger(Label1.Text);
        }

        private void MemoryLeakTestingLab_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User entered MemoryLeaksTestingLab.");
        }
    }
}