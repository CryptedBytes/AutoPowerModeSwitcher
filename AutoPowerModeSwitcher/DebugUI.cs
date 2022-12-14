using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AutoPowerModeSwitcher
{
    public partial class DebugUI
    {
        public DebugUI()
        {
            InitializeComponent();
        }
        private void CheckBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox24.Checked == true)
            {
                My.MyProject.Forms.UserPreferencesModule.OverrideWarningLabel.Visible = true;
                My.MyProject.Forms.UserInterface.TargetProcessBox.Enabled = false;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DO NOT let user override target process on main form = True");
            }
            else
            {
                My.MyProject.Forms.UserInterface.TargetProcessBox.Enabled = true;
                My.MyProject.Forms.UserPreferencesModule.OverrideWarningLabel.Visible = !true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DO NOT let user override target process on main form = False");
            }
        }

        private void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox13.Checked == true)
            {
                My.MyProject.Forms.UserPreferencesModule.UserTrackingCheckbox.Checked = true;
                My.MyProject.Forms.UserPreferencesModule.UserTrackingCheckbox.Enabled = false;
                My.MyProject.Forms.UserPreferencesModule.OverrideWarningLabel.Visible = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Now FORCING user-tracking features");
            }
            else
            {
                My.MyProject.Forms.UserPreferencesModule.UserTrackingCheckbox.Enabled = !false;
                My.MyProject.Forms.UserPreferencesModule.OverrideWarningLabel.Visible = !true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "No longer forcing user-tracking features");
            }
        }



        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                My.MyProject.Forms.InstallerModule.Show();
            }
            else
            {
                My.MyProject.Forms.InstallerModule.Dispose();
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

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (Label14.Text == "True")
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
            else
            {

            }

        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (Label14.Text == "True")
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
            else
            {

            }

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (Label14.Text == "True")
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
            else
            {
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

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {

            switch (Interaction.MsgBox("Are you sure want to reset all the settings?", MsgBoxStyle.YesNo, "CryptedBytes Debugging Interface"))
            {
                case MsgBoxResult.Yes:
                    {
                        My.MySettingsProperty.Settings.Reset();
                        My.MySettingsProperty.Settings.Save();
                        break;
                    }

                case MsgBoxResult.No:
                    {
                        break;
                    }

            }


            CheckBox12.Checked = false;

        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox11.Checked = false;

            throw new Exception("You have thrown an exception");

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DeveloperForm is loaded into memory.");
            if (My.MySettingsProperty.Settings.DisableCoreForm == true)
            {
                CheckBox14.Checked = true;
            }
            else
            {
                CheckBox14.Checked = !true;

            }
            Panel1.Location = new Point(12, 291);
            if (My.MySettingsProperty.Settings.DisableLegacyServices == true)
            {
                CheckBox19.Checked = !true;
            }
            else
            {
                CheckBox19.Checked = !false;
            }

            if (My.MySettingsProperty.Settings.GroupPolicyForceAutoPilot == true)
            {
                CheckBox17.Checked = true;
            }
            if (My.MySettingsProperty.Settings.DisableSizeChangedEventChecks == true)
            {
                CheckBox18.Checked = true;

            }
            // Panel2.Location = New Point(4, 29)
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DeveloperForm is intialized.");
        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox10.Checked == true)
            {
                CheckBox24.Checked = true;
            }
            else
            {
                CheckBox24.Checked = false;


            }
        }

        private void CheckBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBox4.Checked)
            {
                CheckBox13.Checked = true;
            }
            else
            {
                CheckBox13.Checked = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<UserInterface>().Any())
            {
                CheckBox8.Checked = true;
            }
            else
            {
                CheckBox8.Checked = !true;

            }
            if (Application.OpenForms.OfType<CoreForm>().Any())
            {
                CheckBox7.Checked = true;
            }
            else
            {
                CheckBox7.Checked = !true;

            }
            if (Application.OpenForms.OfType<UserPreferencesModule>().Any())
            {
                CheckBox6.Checked = true;
            }
            else
            {
                CheckBox6.Checked = !true;

                if (Application.OpenForms.OfType<AutoPowerSwitcher>().Any())
                {
                    CheckBox6.Checked = true;
                }
                else
                {
                    CheckBox6.Checked = !true;

                }
            }
            Label14.Text = "True";
            GetOpenForms.Stop();
        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox9.Checked)
            {
                My.MyProject.Forms.BootManager.Show();
            }
            else
            {
                My.MyProject.Forms.BootManager.Dispose();
                GC.Collect();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel2.Dispose();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked)
            {
                My.MyProject.Forms.Debugging.Show();
            }
            else
            {
                My.MyProject.Forms.Debugging.Dispose();
                GC.Collect();
            }
        }

        private void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox16.Checked)
            {
                My.MyProject.Forms.MemoryLeakTestingLab.Show();
            }
            else
            {
                My.MyProject.Forms.MemoryLeakTestingLab.Dispose();
                GC.Collect();
            }
        }

        private void CheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox14.Checked)
            {
                My.MySettingsProperty.Settings.DisableCoreForm = true;
            }
            else
            {
                My.MySettingsProperty.Settings.DisableCoreForm = false;

            }
            My.MySettingsProperty.Settings.Save();

        }

        private void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox17.Checked)
            {
                My.MySettingsProperty.Settings.GroupPolicyForceAutoPilot = true;
                My.MyProject.Forms.UserPreferencesModule.Userdetect.Checked = true;
                My.MyProject.Forms.UserPreferencesModule.Userdetect.Enabled = false;
                My.MyProject.Forms.UserPreferencesModule.UserNOdetect.Checked = false;
                My.MyProject.Forms.UserPreferencesModule.UserNOdetect.Enabled = false;
            }
            else
            {
                My.MyProject.Forms.UserPreferencesModule.Userdetect.Checked = false;
                My.MyProject.Forms.UserPreferencesModule.Userdetect.Enabled = true;
                My.MyProject.Forms.UserPreferencesModule.UserNOdetect.Checked = false;
                My.MyProject.Forms.UserPreferencesModule.UserNOdetect.Enabled = true;
                My.MySettingsProperty.Settings.GroupPolicyForceAutoPilot = false;

            }

            My.MySettingsProperty.Settings.Save();


        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel1.Dispose();
        }

        private void CheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox19.Checked == true)
            {
                My.MySettingsProperty.Settings.DisableLegacyServices = false;
                Interaction.MsgBox("My.Settings.DisableLegacyServices = False", MsgBoxStyle.Exclamation, "Boolean Value Set");
            }
            else
            {
                My.MySettingsProperty.Settings.DisableLegacyServices = true;
                Interaction.MsgBox(" My.Settings.DisableLegacyServices = True", MsgBoxStyle.Exclamation, "Boolean Value Set");
            }

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox18.Checked == true)
            {
                My.MySettingsProperty.Settings.DisableSizeChangedEventChecks = true;
            }
            else
            {
                My.MySettingsProperty.Settings.DisableSizeChangedEventChecks = false;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {


        }

        private void CheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            Environment.FailFast(1.ToString());
        }

        private void CheckBox21_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckBox21.Checked == true)
            {
                GC.Collect();
                Interaction.MsgBox("Succesful.");
                CheckBox21.Checked = false;
            }
            else
            {

            }

        }

        private void CheckBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox22.Checked == true)
            {
                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: User thrown an exception";
                CoreForm.errorLoggingSystem();
                CheckBox22.Checked = false;

            }
        }

        private void CheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            Interaction.MsgBox("Form1's exact size is: " + My.MyProject.Forms.UserInterface.FormHeightLabel.Text + " , " + My.MyProject.Forms.UserInterface.FormWidthLabel.Text + " and is copied to your clipboard.");
            My.MyProject.Computer.Clipboard.SetText(My.MyProject.Forms.UserInterface.FormHeightLabel.Text + " , " + My.MyProject.Forms.UserInterface.FormWidthLabel.Text);
            CheckBox23.Checked = false;
        }
    }
}