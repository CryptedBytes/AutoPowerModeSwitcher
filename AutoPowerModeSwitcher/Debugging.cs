using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    public partial class Debugging
    {
        public Debugging()
        {
            InitializeComponent();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.SettingsDatabase.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            throw new Exception("You have thrown an exception");
        }





        private void Button5_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.Reset();
            My.MySettingsProperty.Settings.Save();

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                My.MyProject.Forms.PreBootManager.Show();
            }
            else
            {
                My.MyProject.Forms.PreBootManager.Dispose();
                GC.Collect();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                My.MyProject.Forms.BootManagerUXPort.Show();
            }
            else
            {
                My.MyProject.Forms.BootManagerUXPort.Dispose();
                GC.Collect();
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                My.MyProject.Forms.InstallerModule.Show();
            }

            else
            {
                My.MyProject.Forms.InstallerModule.Dispose();
                GC.Collect();
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox8.Checked == true)
            {
                My.MyProject.Forms.UserInterface.Show();
            }
            else
            {
                My.MyProject.Forms.UserInterface.Dispose();

            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox7.Checked == true)
            {
                My.MyProject.Forms.CoreForm.Show();
            }
            else
            {
                My.MyProject.Forms.CoreForm.Dispose();



            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox8.Checked == true)
            {
                My.MyProject.Forms.UserPreferencesModule.Show();
            }
            else
            {
                My.MyProject.Forms.UserPreferencesModule.Dispose();
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox8.Checked == true)
            {
                My.MyProject.Forms.AutoPowerSwitcher.Show();
            }
            else
            {
                My.MyProject.Forms.AutoPowerSwitcher.Dispose();


            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (CheckBox9.Checked == true)
            {
                Panel1.Dispose();
                My.MyProject.Forms.DebugUI.Show();
                Close();
            }
            else
            {
                My.MySettingsProperty.Settings.EnableExperimentalFeatures = false;
                My.MySettingsProperty.Settings.Save();

                Dispose();
            }

        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            Button6.Text = "Continue";

        }

        private void Debugging_Load(object sender, EventArgs e)
        {
            Panel1.Location = new Point(6, 12);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.DebugUI.Show();

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                My.MyProject.Forms.SettingsDatabase.Show();
            }


            else
            {
                My.MyProject.Forms.SettingsDatabase.Dispose();
                GC.Collect();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel1.Visible = false;
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel1.Visible = true;
        }
    }
}