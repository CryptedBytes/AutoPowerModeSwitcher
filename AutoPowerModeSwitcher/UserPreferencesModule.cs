using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{

    public partial class UserPreferencesModule
    {
        private System.IO.StreamWriter w; // needed for creating the database
        private System.IO.StreamReader r;

        public UserPreferencesModule()
        {
            InitializeComponent();
        }




        private void GameChooser_Load(object sender, EventArgs e)
        {

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserPreferencesModule is loaded into memory.");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Getting and setting user settings (UserPreferencesModule)");
            TabControl1.TabPages.Remove(TabPage1);
            if (My.MySettingsProperty.Settings.AutoPilotEnabled == true)
            {
                Userdetect.Checked = true;
            }

            else
            {
                UserNOdetect.Checked = true;

            }


            if (Userdetect.Checked == true)
            {
                DetectionEngine.Start();
                GroupBox2.Visible = true;
                My.MySettingsProperty.Settings.AutoPilotEnabled = true;
                My.MySettingsProperty.Settings.Save();
            }

            else
            {

                GroupBox2.Visible = false;
                DetectionEngine.Stop();
                My.MySettingsProperty.Settings.AutoPilotEnabled = false;
                My.MySettingsProperty.Settings.Save();


            }
            if (My.MySettingsProperty.Settings.CoreEngineModeEqualsOptimized == true)
            {
                EngineMode2.Checked = true;
            }
            else
            {
                EngineMode1.Checked = true;
            }
            if (My.MySettingsProperty.Settings.UserTrackingEnabled == true)
            {
                UserTrackingCheckbox.Checked = true;
                UserTrackingHighSpeedCheckbox.Visible = true;
            }
            else
            {
                UserTrackingCheckbox.Checked = !true;
                UserTrackingHighSpeedCheckbox.Visible = !true;
            }
            if (My.MySettingsProperty.Settings.TaskManagerEnabled == true)
            {
                GameBoosterEnabled.Checked = true;
            }
            else
            {
                GameBoosterEnabled.Checked = !true;
            }
            if (My.MySettingsProperty.Settings.TaskManagerWarningRemoved == true)
            {
                Panel3.Dispose();
            }
            else
            {

            }
            if (GameBoosterEnabled.Checked == true)
            {
                KillProcessesCheckBox.Checked = true;
            }
            else
            {
                KillProcessesCheckBox.Checked = !true;
            }
            if (My.MySettingsProperty.Settings.TaskManagerRestartAfterSession == true)
            {
                RestartAfterSessionCheckBox.Checked = true;
            }
            else
            {
                RestartAfterSessionCheckBox.Checked = !true;
            }

            if (My.MySettingsProperty.Settings.BootManagerEnabled == true)
            {
                EnableBootManagerCheck.Checked = true;
            }
            else
            {
                EnableBootManagerCheck.Checked = !true;
            }
            if (My.MySettingsProperty.Settings.NoImpactEnabled == true)
            {
                NoImpactCheckbox.Checked = true;
            }
            else
            {
                NoImpactCheckbox.Checked = false;

            }
            PrivacyStatementPanel.Location = new Point(6, 171);
            if (StartonBoot.Checked == false)
            {
                EnableBootManagerCheck.Enabled = false;
            }
            else
            {
                EnableBootManagerCheck.Enabled = !false;
            }
            if (My.MySettingsProperty.Settings.TaskManagerPrioritize == true)
            {
                PrioritizeTargetProcessCheckBox.Checked = true;
            }
            else
            {
                PrioritizeTargetProcessCheckBox.Checked = !true;
            }
            if (My.MySettingsProperty.Settings.EnableExperimentalFeatures == true)
            {
                EnableExperimentalFeatuesCheckBox.Checked = true;
            }
            else
            {
                EnableExperimentalFeatuesCheckBox.Checked = !true;
            }

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "New location set to = '9, 6' for Panel6");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized all components of UserPreferencesModule.");

            HideLegacySettingsPanel1.Location = new Point(7, 9);
            HideGameDetectionPanel.Location = new Point(6, 6);

            if (My.MySettingsProperty.Settings.SafemodeEnabled == true)
            {

                Text = Text + " - Safemode is enabled";
            }
            else
            {

            }
            Panel7.Location = new Point(0, 0);
            Panel10.Location = new Point(0, 0);
            HideLegacySettingsPanel1.Location = new Point(0, 0);
            My.MyProject.Forms.UserInterface.AutoPilotController();
            My.MyProject.Forms.UserInterface.readDatabase();

        }


        private void Engine_Tick(object sender, EventArgs e)
        {
            // get processes
            if (My.MySettingsProperty.Settings.AllowPowermodeControl == false)
            {

                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG AllowPowerModeControl is disabled!!!! UserPreferencesModule engine is ticked but won't apply anything!");
            }
            else if (My.MySettingsProperty.Settings.enableGameDetection == true)
            {
                Panel10.Visible = false;
                // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "flagEnableGameDetection bool value equals true. Enabled GameDetectionUtility.")
                if (My.MySettingsProperty.Settings.DisableLegacyCheckboxStyleDetectionSystem == true)
                {

                    My.MyProject.Forms.DebugUI.AutoPilotDetectionTickCount.Text = (Conversions.ToDouble(My.MyProject.Forms.DebugUI.AutoPilotDetectionTickCount.Text) + 1d).ToString();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is enabled. Detection engine is now running in listbox mode!");
                    if (My.MySettingsProperty.Settings.AutoPilotEnabled == true)
                    {
                        for (int i = 0, loopTo = GameDetectionCollection.Items.Count - 1; i <= loopTo; i++)
                        {
                            Process[] target;
                            target = Process.GetProcessesByName(Conversions.ToString(GameDetectionCollection.Items[i]));

                            // verbose
                            Debug.WriteLine(Operators.ConcatenateObject(DateTime.Now.ToString("HH.mm.ss") + ": " + "DETECTION ENGINE VERBOSE: Currently checking process ", GameDetectionCollection.Items[i]));

                            // end verbose

                            if (target.Count() > 0)
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = Conversions.ToString(GameDetectionCollection.Items[i]);
                                Debug.WriteLine(Operators.ConcatenateObject(Operators.ConcatenateObject(DateTime.Now.ToString("HH.mm.ss") + ": " + "DETECTION ENGINE VERBOSE: Process ", GameDetectionCollection.Items[i]), " is running. Set targetprocessbox accordingly."));
                            }
                            else
                            {

                            }

                        }
                    }
                }

                else
                {
                    My.MyProject.Forms.DebugUI.AutoPilotDetectionTickCount.Text = (Conversions.ToDouble(My.MyProject.Forms.DebugUI.AutoPilotDetectionTickCount.Text) + 1d).ToString();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. WARNING: Legacy mode MAY cause problems.");
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. Detection engine is now running in LEGACY checkbox mode!");
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. Detection engine is now running in LEGACY checkbox mode!");
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. Detection engine is now running in LEGACY checkbox mode!");
                    if (My.MySettingsProperty.Settings.AutoPilotEnabled == true)
                    {
                        if (CheckBox1.Checked == true)
                        {
                            Process[] fallout;
                            fallout = Process.GetProcessesByName("Fallout4");
                            if (fallout.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "Fallout4";
                            }


                            else
                            {

                            }      // Process is not running
                        }
                        else
                        {

                        }

                        if (CheckBox2.Checked == true)
                        {
                            Process[] GTAV;
                            GTAV = Process.GetProcessesByName("GTA5");
                            if (GTAV.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "GTA5";
                                My.MyProject.Forms.UserInterface.CurrentGameLabel.Text = "Grand Theft Auto V";
                            }
                            else
                            {

                            }      // Process is not running
                        }

                        if (CheckBox3.Checked == true)
                        {
                            Process[] BF3;
                            BF3 = Process.GetProcessesByName("bf3");
                            if (BF3.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "bf3";
                            }
                            else
                            {

                            }      // Process is not running
                        }
                        else
                        {


                        }
                        if (CheckBox5.Checked == true)
                        {
                            Process[] FC3;
                            FC3 = Process.GetProcessesByName("farcry3_d3d11");
                            if (FC3.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "farcry3_d3d11";
                            }
                            else
                            {

                            }      // Process is not running
                            Process[] FC3_2;
                            FC3_2 = Process.GetProcessesByName("farcry3");
                            if (FC3_2.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "farcry3";
                            }
                            else
                            {

                            }      // Process is not running
                        }
                        else
                        {

                        }

                        if (CheckBox11.Checked == true)
                        {
                            Process[] BF4;
                            BF4 = Process.GetProcessesByName("bf4");
                            if (BF4.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "bf4";
                            }
                            else
                            {

                            }      // Process is not running


                        }

                        if (CheckBox12.Checked == true)
                        {
                            Process[] GTAIV;
                            GTAIV = Process.GetProcessesByName("GTAIV");
                            if (GTAIV.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "GTAIV";
                            }
                            else
                            {

                            }      // Process is not running
                        }


                        if (CheckBox12.Checked == true)
                        {
                            Process[] EFLC;
                            EFLC = Process.GetProcessesByName("EFLC");
                            if (EFLC.Count() > 0)   // Process is running
                            {
                                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "EFLC";
                            }
                            else
                            {

                            }      // Process is not running
                        }
                        Label41.Text = (Conversions.ToDouble(Label41.Text) + 1d).ToString();
                    }
                    else
                    {

                    }


                }
            }
            else
            {
                Panel10.Visible = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "flagEnableGameDetection bool value equals false. Disabled GameDetectionUtility.");

            }
        }



        private void UserPreferencesModule_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (My.MySettingsProperty.Settings.AllowQuit == true)
            {
            }

            // Close() 




            else
            {
                e.Cancel = true;
                Hide();

            }





        }


        private void Userdetect_CheckedChanged(object sender, EventArgs e)
        {
            // default size = 383, 320
            if (Conversions.ToDouble(Label56.Text) == 0d)
            {
                Label56.Text = 1.ToString();
                Label56.Visible = false;
            }
            else
            {
                My.MyProject.Forms.AutoPilotPopup.Timer1.Stop();
                My.MyProject.Forms.AutoPilotPopup.Timer1.Start();
                My.MyProject.Forms.AutoPilotPopup.Show();
            }
            if (Userdetect.Checked == true) // if AUTOPILOT IS ENABLED
            {
                // My.Settings.enableGameDetection = true
                DetectionEngine.Start();
                GroupBox2.Visible = true;
                My.MySettingsProperty.Settings.AutoPilotEnabled = true;

                Label3.Visible = true;
                My.MyProject.Forms.UserInterface.Label3.Visible = true;
                My.MyProject.Forms.UserInterface.AutoPilotStatus.Text = "True";
                PrivacyStatementPanel.Visible = false;
                // UserTrackingCheckbox.Checked = True
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "AUTOPILOT IS ENABLED");
                My.MySettingsProperty.Settings.Save();
            }

            // Height = 286
            else                // if AUTOPILOT IS DISABLED
            {

                GroupBox2.Visible = false;
                DetectionEngine.Dispose();
                My.MySettingsProperty.Settings.AutoPilotEnabled = false;
                My.MySettingsProperty.Settings.Save();
                Label3.Visible = false;
                My.MyProject.Forms.UserInterface.Label3.Visible = false;
                My.MyProject.Forms.UserInterface.AutoPilotStatus.Text = "False";
                PrivacyStatementPanel.Visible = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 1)");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 2)");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 3)");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 4)");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 5)");
                // Height = 129
            }
        }
        private void Invertal1_CheckedChanged(object sender, EventArgs e)
        {

            // doesnt work
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interaction.MsgBox("This engine sets your powerplan according to your preferences every 500 miliseconds. Not listening to any events or intents, it just overrides system's powerplan with your desired one.");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interaction.MsgBox("This engine sets your powerplan according to your preferences only when planned events occur. For example when system's powerplan is changed outside of the app we reset it and override it by your prefered powerplan.");
        }



        public static bool IsRunningAsAdmin()
        {
            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }


        private void TopMostCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (TopMostCheckbox.Checked)
            {
                My.MyProject.Forms.UserInterface.TopMost = true;
                TopMost = true;
            }

            else
            {
                My.MyProject.Forms.UserInterface.TopMost = false;
                TopMost = false;

            }
        }

        private void EngineMode2_CheckedChanged(object sender, EventArgs e)
        {
            if (EngineMode2.Checked == true)
            {
                My.MySettingsProperty.Settings.CoreEngineModeEqualsOptimized = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CryptedEngine working mode is now set to Optimized.");
            }

            else
            {
                My.MySettingsProperty.Settings.CoreEngineModeEqualsOptimized = false;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CryptedEngine working mode is now set to Performance Focused.");
                My.MyProject.Forms.UserInterface.SetPowerPlanAlternate.Start();
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Enabling performance-focused engine.");
            }
            My.MySettingsProperty.Settings.Save();

        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableExperimentalFeatuesCheckBox.Checked == true)
            {
                My.MySettingsProperty.Settings.EnableExperimentalFeatures = true;
                My.MySettingsProperty.Settings.Save();
                LinkLabel3.Visible = true;
                TabControl1.TabPages.Add(TabPage1);
                Label54.Visible = true;
                memory4.Visible = true;

                Label42.Visible = true;
                Label41.Visible = true;

                memory.Visible = true;
                isAlreadyRunningLabel.Visible = true;
                UIEngineLabel.Visible = true;
                CheckingSpeedPanel.Visible = true;
                Label53.Visible = true;
                Label50.Visible = true;
                memory2.Visible = true;

                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Enabled experimental features.");
            }
            else
            {
                My.MySettingsProperty.Settings.EnableExperimentalFeatures = false;
                My.MySettingsProperty.Settings.Save();
                LinkLabel3.Visible = false;
                TabControl1.TabPages.Remove(TabPage1);

                Label42.Visible = !true;
                Label41.Visible = !true;
                Label54.Visible = !true;
                memory4.Visible = !true;
                memory.Visible = !true;
                isAlreadyRunningLabel.Visible = !true;
                UIEngineLabel.Visible = !true;
                CheckingSpeedPanel.Visible = !true;
                Label53.Visible = !true;
                Label50.Visible = !true;
                memory2.Visible = !true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Disabled experimental features.");
            }
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            My.MyProject.Forms.Debugging.Show();
        }

        private void GameBoosterEnabled_CheckedChanged(object sender, EventArgs e)
        {

            if (GameBoosterEnabled.Checked == true)
            {
                RestartAfterSessionCheckBox.Enabled = true;
                KillProcessesCheckBox.Enabled = true;
            }
            // My.Settings.TaskManagerEnabled = True
            else
            {
                RestartAfterSessionCheckBox.Enabled = false;
                KillProcessesCheckBox.Enabled = false;
                // My.Settings.TaskManagerEnabled = Not True
            }
            // If GameBoosterEnabled.Checked = False Then
            // '        If Userdetect.Checked = True Then
            // '         MsgBox("AutoPilot is enabled, you cannot disable this feature as it's currently in-use by application environment. Disable AutoPilot first to disable this feature.", MsgBoxStyle.Exclamation, "AutoPilot is preventing you from disabling this feature")
            // Else

            // End If


            // End If

        }


        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (GameBoosterEnabled.Checked == true)
            {
            }
            // KillProcessesCheckBox.Checked = True
            else
            {
                KillProcessesCheckBox.Checked = !true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


            if (LowFreqGUID.Text.Length == 36)
            {
                WarnLabel.Visible = false;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Low Frequency Powermode GUID is VALID!");
            }
            else
            {
                WarnLabel.Visible = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: Low Frequency Powermode GUID is INVALID!");
            }
            My.MySettingsProperty.Settings.LowFreqGUID = LowFreqGUID.Text;
            My.MySettingsProperty.Settings.Save();

        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LowFreqGUID.Text = "31377a3e-f393-4dfd-bb39-490b8e811f2b";
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Low Frequency Powermode GUID is RESET!");
        }

        private void LowFreqGUID_Click(object sender, EventArgs e)
        {
            if (ShowWarn.Text == "1")
            {
                Interaction.MsgBox("Changing GUID may cause application unstability as the app will not reconise system components if you enter a wrong GUID and continue using application with it so some CORE featrues MAY NOT WORK afterwards. Only change GUID if you REALLY and REALLY know what you are doing and how to revert it if something goes wrong. However click OK to continue.", MsgBoxStyle.Exclamation, "Things may go all the way wrong, you have been warned!");

                ShowWarn.Text = "0";
            }
            else
            {

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.Reset();
            My.MySettingsProperty.Settings.Save();
            UIEngineLabel.Text = "21";
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UIEngine Memory's value = 21");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restored default settings.");
            Label21.Visible = true;
            UIEngine.Start();

        }

        private void UIEngine_Tick(object sender, EventArgs e)
        {
            if (UIEngineLabel.Text == "21")
            {
                Label21.Visible = false;
            }
            else if (UIEngineLabel.Text == "51")
            {
                Label51.Visible = false;
            }

            if (My.MySettingsProperty.Settings.AllowPowermodeControl == true)
            {
                Panel7.Visible = false;
            }
            else if (My.MySettingsProperty.Settings.AllowPowermodeControl == !true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG AllowPowerModeControl is disabled! Applying conditions.");
                Panel7.Visible = true;
                Label60.Text = "Game Detection Utility cannot work at the moment.";
                Label60.ForeColor = Color.Black;




            }


        }


        private void Invertal2_CheckedChanged(object sender, EventArgs e)
        {
            if (Interval1.Checked == true)
            {

                // SetPowerPlan.Interval = "500" // this timer is run only once per call, so inveral should NOT affect system performance
                My.MyProject.Forms.UserInterface.ProcessDetector.Interval = Conversions.ToInteger("1550");
                IntervalWarning.Visible = false;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Process Detector Engine's interval is set to 1550");
            }
            else
            {
                My.MyProject.Forms.UserInterface.CheckPowerPlan.Interval = Conversions.ToInteger("6222");
                // SetPowerPlan.Interval = "6200" // this timer is run only once per call, so inveral should NOT affect system performance
                My.MyProject.Forms.UserInterface.ProcessDetector.Interval = Conversions.ToInteger("6222");
                // MsgBox("Frequent checks are strongly RECOMMENDED.")
                IntervalWarning.Visible = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Process Detector and Check Powerplan Engine's interval is set to 6222");
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (UserTrackingCheckbox.Checked == true)
            {
                My.MySettingsProperty.Settings.UserTrackingEnabled = true;
                My.MyProject.Forms.UserInterface.FreeSpaceChecker.Start();
                My.MyProject.Forms.UserInterface.CPUTracker.Start();
                My.MyProject.Forms.UserInterface.EnvTickCounter.Start();
                My.MyProject.Forms.UserInterface.FormLocationLabel.Text = My.MyProject.Forms.UserInterface.Location.ToString();
                My.MyProject.Forms.UserInterface.CPUUsageLabel.Text = "Measuring...";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FreeSpaceTracker, CPUTracker, EnvironmentTickCounter and FormLocationTracker is enabled. Tracking system info.");
                UserTrackingHighSpeedCheckbox.Visible = true;
            }
            else
            {
                My.MySettingsProperty.Settings.UserTrackingEnabled = false;
                My.MyProject.Forms.UserInterface.FormLocationLabel.Text = "Disabled by user";
                My.MyProject.Forms.UserInterface.CPUUsageLabel.Text = "Stopping engine";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FreeSpaceTracker, CPUTracker, EnvironmentTickCounter and FormLocationTracker is disabled. NOT tracking system info");
                UserTrackingHighSpeedCheckbox.Visible = false;

            }
        }
        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel3.Dispose();
            if (CheckBox6.Checked == true)
            {
                My.MySettingsProperty.Settings.TaskManagerWarningRemoved = true;
            }
            else
            {
                My.MySettingsProperty.Settings.TaskManagerWarningRemoved = !true;
            }
        }

        private void RestartAfterSessionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RestartAfterSessionCheckBox.Checked == true)
            {
                My.MySettingsProperty.Settings.TaskManagerRestartAfterSession = true;
            }
            else
            {
                My.MySettingsProperty.Settings.TaskManagerRestartAfterSession = !true;
            }
        }

        private void EnableBootManagerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableBootManagerCheck.Checked == true)
            {
                My.MySettingsProperty.Settings.BootManagerEnabled = true;
            }

            else
            {
                My.MySettingsProperty.Settings.BootManagerEnabled = !true;
            }

            if (EnableBootManagerCheck.Checked == true)
            {
                memory2.Text = "True";
            }
            else
            {
                memory2.Text = "False";
            }
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            Panel5.Dispose();
        }

        private void TabPage5_Enter(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Entered Uninstall tab.");
            Panel5.Location = new Point(249, 278);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Panel5's location is changed");
            var W_Id = WindowsIdentity.GetCurrent();
            var WP = new WindowsPrincipal(W_Id);
            bool isAdmin = WP.IsInRole(WindowsBuiltInRole.Administrator);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Checking admin rights");
            if (isAdmin == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Returned True, user is privileged");
            }

            else
            {
                Button3.Enabled = false;
                Label37.Visible = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Returned False, user is NOT privileged");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User's ability to uninstall application is disabled");
            }
        }

        private void DelayStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (NoImpactCheckbox.Checked == true)
            {
                My.MySettingsProperty.Settings.NoImpactEnabled = true;
            }
            else
            {
                My.MySettingsProperty.Settings.NoImpactEnabled = !true;
            }
        }

        private void StartonBoot_Click(object sender, EventArgs e, string args = "/ShowSettings")
        {

            // Elevate the process if it is not run as administrator.
            if (!IsRunningAsAdmin())
            {
                // Launch itself as administrator
                var proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.WorkingDirectory = Environment.CurrentDirectory;
                proc.FileName = Application.ExecutablePath;
                proc.Verb = "runas";
                proc.Arguments = args;

                try
                {
                    Process.Start(proc);
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restarting application in elevated mode");
                }
                catch
                {
                    Interaction.MsgBox("Cannot alter this setting without elevation"); // The user refused the elevation.
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "USERPREFERENCESMODULE: User refused the elevation");
                    return;
                }
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Killing process, ignore 'clicked X button' logs as they are not valid.");
                My.MyProject.Forms.CoreForm.Dispose();
                Application.Exit();  // Quit itself 'maybe the issue is that application is one-instance only
            }
            else
            {

                // The process is already running as administrator

                if (StartonBoot.Checked == true)       // //THIS IS THE LOGIC
                {
                    StartonBoot.Checked = false;
                }
                else
                {
                    StartonBoot.Checked = true;
                }

                if (StartonBoot.Checked)
                {
                    // start on boot
                    try
                    {
                        My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).SetValue(Application.ProductName, Application.ExecutablePath + " /onboot");

                        EnableBootManagerCheck.Enabled = true;
                        StartonBoot.Checked = true;
                        My.MySettingsProperty.Settings.StartOnBootEnabled = true;
                    }

                    catch (Exception ex)
                    {

                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured while setting reg key: " + ex.ToString());

                    }
                }
                else
                {
                    // DO NOT start on boot
                    try
                    {
                        My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue(Application.ProductName);
                        EnableBootManagerCheck.Checked = false;
                        EnableBootManagerCheck.Enabled = false;
                        StartonBoot.Checked = !true;
                        My.MySettingsProperty.Settings.StartOnBootEnabled = !true;
                    }
                    catch (Exception ex)
                    {


                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured while setting reg key: " + ex.ToString());
                    }

                }
            }
            CheckboxDisabler.Start();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Label46.Visible = true;

            ProcessingAnimator.Start();
            System.Threading.Thread.Sleep(2000);
            if (CheckBox9.Checked == true)
            {
                try
                {
                    Process.Start("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del " + Application.ExecutablePath);
                }
                catch (Exception ex)
                {
                    Label11.Text = (Conversions.ToDouble(Label11.Text) + 1d).ToString();
                }
            }

            else
            {

            }
            if (CheckBox8.Checked == true)
            {
                try
                {
                    My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue(Application.ProductName);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Failed to delete REGKEYS. More info about the exception: " + ex.ToString());
                    Label11.Text = (Conversions.ToDouble(Label11.Text) + 1d).ToString();
                }
            }


            else
            {

            }
            if (CheckBox10.Checked == true)
            {
                My.MySettingsProperty.Settings.Reload();

                My.MySettingsProperty.Settings.Reset();
            }
            else
            {

            }
            if (CheckBox9.Checked == false & CheckBox10.Checked == false & CheckBox8.Checked == false)
            {
                Interaction.MsgBox("No components selected for uninstall process!");
                Label46.Visible = false;
            }
            else if (Conversions.ToDouble(Label11.Text) > 0d)
            {
                Interaction.MsgBox("Successfully removed application, however some errors occured during the uninstallation so you may need to manually remove some leftovers.");
                Environment.Exit(0);
            }
            else
            {
                Interaction.MsgBox("Success!");
                Label46.Visible = false;

                Environment.Exit(0);

            }
        }


        private void Panel3_VisibleChanged(object sender, EventArgs e)
        {
            // If Panel3.Visible = True Then
            // Panel3.Visible = False
            // Else
            // End If
        }





        private void Button7_Click(object sender, EventArgs e)
        {
            Label51.Visible = true;
            UIEngineLabel.Text = "51";
            UIEngine.Start();
            My.MySettingsProperty.Settings.Save();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved user settings.");
        }

        private void UninstallCancelButton_Click(object sender, EventArgs e)
        {
            UninstallPanel.Dispose();
            My.MyProject.Forms.UserInterface.Show();
            TabControl1.SelectTab(1);
            Hide();
            Text = "AutoPowerModeSwitcher Settings";
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User has cancelled uninstallation. Restoring normal app conditions.");
        }

        private void ProcessingAnimator_Tick(object sender, EventArgs e)
        {
            Label46.Text = Label46.Text + ".";
            if (Label46.Text == "Processing....")
            {
                Label46.Text = "Processing";
            }

        }

        private void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (SimulateProcessRunningCheckbox.Checked == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Starting simulation");
                System.Threading.Thread.Sleep(1000);
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intializing memory content.");
                memory.Text = My.MyProject.Forms.UserInterface.TargetProcessBox.Text;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Memorized data= " + memory.Text);
                My.MyProject.Forms.UserInterface.TargetProcessBox.Enabled = false;
                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "notepad";
                My.MySettingsProperty.Settings.TargetProcess = "notepad";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is set to 'notepad'");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User's ability to interact with target process textbox is prohibited");
                My.MySettingsProperty.Settings.Save();
                Label49.Visible = true;


                Process[] Notepad;
                Notepad = Process.GetProcessesByName("notepad");
                if (Notepad.Count() > 0)   // Process is running
                {

                    isAlreadyRunningLabel.Text = "True";
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notepad is already running, noted.");
                }

                else      // Process is not running
                {
                    isAlreadyRunningLabel.Text = "False";
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notepad is not running, noted.");
                }

                try
                {
                    var p = new Process();
                    var psi = new ProcessStartInfo();

                    psi.WindowStyle = ProcessWindowStyle.Hidden;
                    psi.FileName = "notepad.exe";
                    psi.UseShellExecute = true;
                    p.StartInfo = psi;
                    p.Start();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Starting notepad, hidden and with no arguments.");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Failed to start notepad. Additional details are provided by a MsgBox");
                    Interaction.MsgBox("Failed to start simulating app. Please try again. Additional info about the exception: " + ex.ToString());
                    SimulateProcessRunningCheckbox.Checked = false;

                }
            }
            else
            {

                My.MyProject.Forms.UserInterface.TargetProcessBox.Enabled = true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User's ability to interact with target process textbox is re-enabled");
                My.MyProject.Forms.UserInterface.TargetProcessBox.Text = memory.Text;

                My.MySettingsProperty.Settings.TargetProcess = memory.Text;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is set back to memorized process, " + memory.Text);
                My.MySettingsProperty.Settings.Save();

                Label49.Visible = !true;

                if (isAlreadyRunningLabel.Text == "True")
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notepad was already running before the simulation. Cannot terminate user started application.");
                }
                else
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminating notepad");
                    Interaction.Shell("taskkill -f /im Notepad.exe", AppWinStyle.Hide);
                    Interaction.Shell("taskkill -f /im notepad.exe", AppWinStyle.Hide);

                }
            }



        }



        private void PrioritizeTargetProcessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PrioritizeTargetProcessCheckBox.Checked == true)
            {
                My.MySettingsProperty.Settings.TaskManagerPrioritize = true;
            }

            else
            {
                My.MySettingsProperty.Settings.TaskManagerPrioritize = !true;
            }
            My.MySettingsProperty.Settings.Save();
        }

        private void StartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            if (StartMinimized.Checked == true)
            {
                My.MySettingsProperty.Settings.StartMinimized = true;
            }
            else
            {
                My.MySettingsProperty.Settings.StartMinimized = !true;
            }
            My.MySettingsProperty.Settings.Save();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void PrivacyStatementPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (PrivacyStatementPanel.Visible == false)
            {
                if (My.MySettingsProperty.Settings.EnableExperimentalFeatures == true)
                {
                    CheckingSpeedPanel.Visible = true;

                }
            }

            else
            {
                CheckingSpeedPanel.Visible = !true;
            }
        }

        private void TabControl1_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Tab index changed. Current tab index= " + TabControl1.SelectedIndex.ToString());
        }

        private void UserPreferencesModule_VisibleChanged(object sender, EventArgs e)
        {
            if (CoreForm.prefetchingUserPreferences == true)
            {
                Opacity = 0d;
            }
            else
            {
                Opacity = 100d;
            }
            if (Visible == true)
            {

                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserPreferencesModule visibilty changed. It's visible.");
            }
            else
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserPreferencesModule visibilty changed. It's NOT visible.");
            }


        }

        private void ConsoleEngine_Tick(object sender, EventArgs e)
        {
            if (StartonBoot.Checked == true)
            {

                EnableBootManagerCheck.Enabled = true;
                if (memory2.Text == "True")
                {
                    EnableBootManagerCheck.Checked = true;
                }
                else if (memory2.Text == "False")
                {
                    EnableBootManagerCheck.Checked = !true;
                }
                else
                {

                }
            }
            else
            {


                EnableBootManagerCheck.Checked = false;
                EnableBootManagerCheck.Enabled = false;

            }
            CheckboxDisabler.Stop();

        }

        private void UserTrackingHighSpeedCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if (UserTrackingHighSpeedCheckbox.Checked == true)
            {
                My.MyProject.Forms.UserInterface.CPUTracker.Interval = 560; // 750
                My.MyProject.Forms.UserInterface.FreeSpaceChecker.Interval = 10; // 45
                My.MyProject.Forms.UserInterface.EnvTickCounter.Interval = 10; // 200
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User tracking is now *MORE* precise");
            }
            else
            {
                My.MyProject.Forms.UserInterface.CPUTracker.Interval = 750;
                My.MyProject.Forms.UserInterface.FreeSpaceChecker.Interval = 45;
                My.MyProject.Forms.UserInterface.EnvTickCounter.Interval = 200;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User tracking is now *LESS* precise");
            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            My.MyProject.Forms.GameList.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            GameDetectionCollection.Items.Clear();
            GameDetectionCollection.Items.Add("GTA5");
            GameDetectionCollection.Items.Add("Fallout4");
            GameDetectionCollection.Items.Add("GTAIV");
            // GameDetectionCollection.Items.Add("farcry3_d3d11")
            GameDetectionCollection.Items.Add("farcry3");
            GameDetectionCollection.Items.Add("farcry4");
            GameDetectionCollection.Items.Add("bf3");
            GameDetectionCollection.Items.Add("bf4");
            GameDetectionCollection.Items.Add("witcher3");
            GameDetectionCollection.Items.Add("DyingLightGame");
            GameDetectionCollection.Items.Add("DeadIslandGame");
            GameDetectionCollection.Items.Add("watch_dogs");


            My.MyProject.Forms.UserInterface.writeDatabase();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((My.MyProject.Forms.UserInterface.TargetProcessBox.Text ?? "") == (GameDetectionCollection.SelectedItem.ToString() ?? ""))
                {
                    My.MyProject.Forms.UserInterface.TargetProcessBox.Text = "GTA5";
                }
                else
                {


                }
                GameDetectionCollection.Items.Remove(GameDetectionCollection.SelectedItem);
                My.MyProject.Forms.UserInterface.writeDatabase();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Select an item first!", MsgBoxStyle.Information, "Failed to remove selected item.");
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.enableGameDetection = false;
            System.Threading.Thread.Sleep(2000);
            Panel10.Visible = true;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = TabPage7;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = TabPage2;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = TabPage4;
        }

        private void TextBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (Conversions.ToDouble(TextBox1.Text) < 0d)
            {
                TextBox1.Text = 2000.ToString();
                Interaction.MsgBox("Detection engine's check intervals cannot be equal or lower than a zero value. Reverted back to the default value", MsgBoxStyle.Critical, "An error occured");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Detection engine interval cannot be equal or lower than a zero value. Reset.");
            }
            else if (TextBox1.Text == " ")
            {

                TextBox1.Text = 2000.ToString();
                Interaction.MsgBox("Detection engine's check intervals cannot be equal or lower than a zero value. Reverted back to the default value", MsgBoxStyle.Critical, "An error occured");
            }
            else
            {

                DetectionEngine.Interval = Conversions.ToInteger(TextBox1.Text);
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Detection Engine's interval value has been user-modified. New value is = " + DetectionEngine.Interval.ToString() + "ms");
            }

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            GameDetectionCollection.Items.Clear();
            My.MyProject.Forms.UserInterface.writeDatabase();

        }

        private void Button14_Click(object sender, EventArgs e)
        {

            Interaction.MsgBox("Changing any value may lead application to misbehave!");
            HideLegacySettingsPanel1.Visible = false;
            Interaction.MsgBox("Cannot find required GUID libraries! Testing GUID will not be available.", MsgBoxStyle.Critical, "CryptedBytes AutoPowerModeSwitcher has encountered a critical error.");
        }


        private void Button9_Click(object sender, EventArgs e)
        {
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("http://cryptedbytes.comxa.com/files/ApplicationFiles/RemoteControl/LoremIpsumTest");
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            var sr = new System.IO.StreamReader(response.GetResponseStream());
            string HelpTextString = sr.ReadToEnd();
            Interaction.MsgBox(HelpTextString);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            GameDetectionCollection.Items.Clear();
            My.MyProject.Forms.UserInterface.readDatabase();
        }

        private void HideGameDetectionPanel_VisibleChanged(object sender, EventArgs e)
        {

            // Call recheckAutoPilotService

        }
        private void recheckAutoPilotService()
        {
            if (Userdetect.Checked == true)
            {
                My.MySettingsProperty.Settings.AutoPilotEnabled = true;
                HideGameDetectionPanel.Visible = false;
            }
            else
            {

                My.MySettingsProperty.Settings.AutoPilotEnabled = false;
                HideGameDetectionPanel.Visible = true;
            }
        }


        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recheckAutoPilotService();
        }

        private void Button15_Click(object sender, EventArgs e)
        {

        }

        private void Button15_Click_1(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.AllowPowermodeControl = true;
            My.MySettingsProperty.Settings.Save();
            Label60.Text = "  Please wait, Game Detection Engine is initializing...";
            Label60.ForeColor = Color.Red;

            My.MyProject.Forms.UserInterface.AllowPowermodeControl.Checked = true;

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.enableGameDetection = true;
            My.MySettingsProperty.Settings.Save();
            Panel10.Visible = false;

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            TabControl1.TabPages.Remove(TabPage1);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            TabControl1.TabPages.Add(TabPage1);
        }


    }
}