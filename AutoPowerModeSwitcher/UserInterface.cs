using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{
    // //LOGGING SYSTEM EXAMPLE CODE SNIPPET
    // //Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Log here")
    // // Error logging system example code snippet (writes errors to a output file)
    // // CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Example"
    // // Call CoreForm.errorLoggingSystem
    // //default designer view 952; 529
    // //extended user view 313; 529
    // //default user view 313; 180

    // // show notification
    // // NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher"
    // //                        NotifyIcon1.BalloonTipText = "You have quit the game. APMS is restoring your system to its normal conditions"
    // //                     NotifyIcon1.ShowBalloonTip(2800)

    public partial class UserInterface
    {
        private object declareTargetProcessAsRunningValue = false;
        private bool allowBenchmarking = false;
        private System.IO.StreamWriter w; // needed for creating the database
        private System.IO.StreamReader r;
        private string regValueToCheck = "NAN";
        private int benchmarkTime = 0;
        private string variable_regvaluedoesnotexist = "This must be overrriden before throwing.";
        private string variable_regvalueexists = "This must be overrriden before throwing.";
        private object variable_byte_regexistsaction = 0;
        private string variable_regvalueexiststitle = "This must be overrriden before throwing.";
        private string variable_regdeletednotifytext = "This must be overrriden before throwing.";
        private PerformanceCounter m_PerformanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        // CPU usage tracking code

        public UserInterface()
        {
            InitializeComponent();
        }
        private void declareTargetProcessAsRunning()
        {
            declareTargetProcessAsRunningValue = true;
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Declared Target Process As Running!)");
        }
        private void changePowerMode()
        {


            if (My.MySettingsProperty.Settings.AllowPowermodeControl == false)
            {
            }


            else if (ProcessLabel.Text == "True")
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process have started running just now.");
                // #########################################################################################################################################
                // #########################################################################################################################################
                // ######################################################### WARNING #######################################################################
                // ############## TARGET PROCESS HAS JUST STARTED RUNNING. CALL POWER CHANGING CODES HERE AS THE TIMER IS NO LONGER BEING USED #############
                // #########################################################################################################################################
                // #########################################################################################################################################
                // #########################################################################################################################################
                // MemorizedPowerModeLabel.Text =  ActivePlanLabel.Text 
                // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Memorized user's preferred powermode. Value is: " & MemorizedPowerModeLabel.text)
                // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "TESTING: REMEMBER POWER MODE ENGINE IS NOW DISPOSED")
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to High Performance. Reason: Target process is now running.");
                Interaction.Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide);




                if (My.MySettingsProperty.Settings.NoImpactEnabled == true)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "NoImpact is enabled and now setting conditions");
                    // UserPreferencesModule.DetectionEngine.Interval = 60000
                    CheckPowerPlan.Interval = 5000;
                    // SetPowerPlanAlternate.Interval = 6200
                    My.MyProject.Forms.VisualStudioDetector.Dispose();
                    My.MyProject.Forms.UserPreferencesModule.DetectionEngine.Stop();

                    My.MyProject.Forms.UserPreferencesModule.NoImpactCheckbox.Enabled = false;
                    My.MyProject.Forms.UserPreferencesModule.Label38.Text = "Exit game first to alter this setting and/or get more info about it.";
                    if (My.MyProject.Forms.UserPreferencesModule.Interval1.Checked == true)
                    {
                        My.MyProject.Forms.UserPreferencesModule.memory3.Text = "1";
                        My.MyProject.Forms.UserPreferencesModule.Interval2.Checked = true;
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Interval 1 was selected. Memory value is set to 1");
                    }

                    if (My.MyProject.Forms.UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked == true)
                    {
                        My.MyProject.Forms.UserPreferencesModule.memory4.Text = "True";
                        My.MyProject.Forms.UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked = false;
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Resource savings started. UserTracking in now less precise.");
                    }
                }


                // If UserPreferencesModule.UserTrackingCheckbox.Checked = True Then
                // UserPreferencesModule.memory4.Text = "True"
                // UserPreferencesModule.UserTrackingCheckbox.Checked = False
                // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserTracking was enabled. Memory value is set to True")
                // Else
                // UserPreferencesModule.memory4.Text = "False"
                // End If
                // was buggy, disabled.
                else
                {

                }


                if (My.MyProject.Forms.UserPreferencesModule.SimulateProcessRunningCheckbox.Checked == true) // if simulating (check UserPreferencesModule)
                {

                    NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher";
                    NotifyIcon1.BalloonTipText = "Currently simulating target process as running. Have fun as APMS is optimizing your system for your confort!";
                    NotifyIcon1.ShowBalloonTip(2800);
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing notification: " + NotifyIcon1.BalloonTipText.ToString());
                }
                else // if not simulating 
                {
                    NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher";
                    NotifyIcon1.BalloonTipText = "Currently playing: " + TargetProcessBox.Text + ". APMS has optimized your system!";
                    NotifyIcon1.ShowBalloonTip(2800);
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing notification: " + NotifyIcon1.BalloonTipText.ToString());
                }
            }

            else
            {

                // #########################################################################################################################################
                // #########################################################################################################################################
                // ######################################################### WARNING #######################################################################
                // ############## TARGET PROCESS HAS JUST STOPPED RUNNING. CALL POWER CHANGING CODES HERE AS THE TIMER IS NO LONGER BEING USED #############
                // #########################################################################################################################################
                // #########################################################################################################################################
                // #########################################################################################################################################
                if (Operators.CompareString(balancedBugFix.Text, "1", false) > 0)
                {

                    if (MemorizedPowerModeLabel.Text.Contains("High"))
                    {
                        Interaction.Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide);
                    }

                    else if (MemorizedPowerModeLabel.Text.Contains("Balance"))
                    {
                        Interaction.Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide);
                    }
                    else if (MemorizedPowerModeLabel.Text.Contains("Power"))
                    {
                        Interaction.Shell("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a", AppWinStyle.Hide);
                    }
                    else
                    {
                        Interaction.Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide);

                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "MemorizedPowerMode is corrupted. Overriden to balanced. It was: " + MemorizedPowerModeLabel.Text);
                        MemorizedPowerModeLabel.Text = "Balanced";
                        CoreForm.errorLoggingText = "Debug: MemorizedPowerMode is corrupted. Overriden to balanced. It was: " + MemorizedPowerModeLabel.Text;
                        CoreForm.errorLoggingSystem();

                    }
                }

                else
                {

                    balancedBugFix.Text = "an error has occured";

                }


                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is NOT running.");
                if (My.MySettingsProperty.Settings.NoImpactEnabled == true)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "NoImpact is enabled. Restoring normal conditions");
                    My.MyProject.Forms.UserPreferencesModule.NoImpactCheckbox.Enabled = !false;
                    // UserPreferencesModule.DetectionEngine.Interval = 6500
                    My.MyProject.Forms.UserPreferencesModule.DetectionEngine.Start();
                    CheckPowerPlan.Interval = 1750;
                    // SetPowerPlanAlternate.Interval = 2400
                    My.MyProject.Forms.UserPreferencesModule.Label38.Text = "Minimize resource usage and CPU utilization by slowing down application runtime elements";

                    if (My.MyProject.Forms.UserPreferencesModule.memory3.Text == "1")
                    {
                        My.MyProject.Forms.UserPreferencesModule.Interval1.Checked = true;
                    }

                    if (My.MyProject.Forms.UserPreferencesModule.memory4.Text == "True")
                    {
                        My.MyProject.Forms.UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked = true;
                    }
                    // UserPreferencesModule.UserTrackingCheckbox.Checked = True

                    else if (My.MyProject.Forms.UserPreferencesModule.memory4.Text == "False")
                    {
                        My.MyProject.Forms.UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked = false;
                    }
                    // UserPreferencesModule.UserTrackingCheckbox.Checked = False
                    else
                    {


                    }
                    My.MyProject.Forms.VisualStudioDetector.Dispose();
                }
                else
                {


                }

            }



        }
        private void checkRegistryKeys()
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Function CheckRegistryKeys received the call and is now functioning.");
            try
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).GetValue(regValueToCheck), null, false))) // reg key doesnt exist
                {
                    // MsgBox(variable_regvaluedoesnotexist)
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Requested reg key does not exist!");
                }
                else  // it exists
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Requested reg key does exist!");
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System is now showing a messagebox to user.");
                    var reply = Interaction.MsgBox(variable_regvalueexists, MsgBoxStyle.YesNo, variable_regvalueexiststitle);

                    if (reply == MsgBoxResult.Yes)
                    {
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, user replied yes to the message box.");
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(variable_byte_regexistsaction, 1, false)))
                        {

                            My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue("QuickPowerModeSwitcher");
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System has successfully deleted the requested reg key, " + regValueToCheck);
                            BallonTipClickActionByte.Text = "2893573752";
                            NotifyIcon1.BalloonTipTitle = "Thank you.";
                            NotifyIcon1.BalloonTipText = variable_regdeletednotifytext;
                            NotifyIcon1.ShowBalloonTip(2000);
                        }

                        else
                        {

                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, no action is assigned to this byte!!!!!");
                        }
                    }
                    else
                    {
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, user replied no to the message box.");
                    }

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, has encountered an error!");
            }

        }

        private void memorizePowerPlan()
        {

            memorizePowerPlanEngine.Start();
        }
        private void startBenchmarking()
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: STARTING BENCHMARK");
            RuntimeBenchmarkOutput.Text = "Runtime Timer: 0ms";

            allowBenchmarking = true;
            RuntimeBenchmarkEngine.Start();

        }

        private void stopBenchmarking()
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: STOPPING BENCHMARK");
            allowBenchmarking = false;
            RuntimeBenchmarkEngine.Stop();



        }
        private void msgboxBenchmarkValue()
        {
            Interaction.MsgBox(RuntimeBenchmarkOutput.Text, MsgBoxStyle.Information, "Returned");
        }

        public void readDatabase()
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called readDatabase.");
            // Read values from database and write them to GameDetectionCollection listbox
            try
            {
                r = new System.IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes");
                while (r.Peek() > -1)
                    My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items.Add(r.ReadLine());
                r.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "GameDetectionIdentifier is either corrupted or does not exist.");
                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "GameDetectionIdentifier is either corrupted or does not exist.";
                CoreForm.errorLoggingSystem();
            }

        }

        public void writeDatabase()
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called writeDatabase");
            int i;
            if (System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated") == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Function writeDatabase checked for required directories and successfully found them. No need to create new ones.");
            }
            else
            {
                My.MyProject.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Directory does not exist, creating new one.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory: UserGenerated Database.");

            }




            if (My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items.Count == 0) // gameDetectionCollection is empty, do not save it.
            {
            }

            else
            {

                try
                {
                    w = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes");
                    var loopTo = My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items.Count - 1;
                    for (i = 0; i <= loopTo; i++)
                        w.WriteLine(My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items[i]);
                    w.Close();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved listbox items to UserGenerated Database and closed StreamWriter's thread.");
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An error occured while saving listbox items to UserGenerated Database. Exception is suppressed.");
                    CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "An error occured while saving listbox items to UserGenerated Database.";
                    CoreForm.errorLoggingSystem();
                }


            }



        }
        private void applyHighPerformanceConditions()
        {

            ActivePlanLabel.Text = "High performance";
            // PowerModeHighPerf.Checked = True
            buttonquicksetPerformance.ForeColor = Color.Red;
            buttonquicksetBalanced.ForeColor = Color.Black;
            buttonquicksetPowerSave.ForeColor = Color.Black;
            buttonquicksetPerformance.Enabled = false;
            buttonquicksetBalanced.Enabled = true;
            buttonquicksetPowerSave.Enabled = true;
            BalancedLabel.Visible = !true;
            PowerSaveLabel.Visible = false;
            HighPerfLabel.Visible = true;
            NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_HighPerformance;
        }

        private void applyBalancedConditions()
        {

            ActivePlanLabel.Text = "Balanced";
            buttonquicksetPerformance.ForeColor = Color.Black;
            buttonquicksetBalanced.ForeColor = Color.Red;
            buttonquicksetPowerSave.ForeColor = Color.Black;
            buttonquicksetPerformance.Enabled = true;
            buttonquicksetBalanced.Enabled = false;
            buttonquicksetPowerSave.Enabled = true;
            BalancedLabel.Visible = true;
            PowerSaveLabel.Visible = false;
            HighPerfLabel.Visible = false;
            NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_balanced;
        }

        private void applyPowerSaverConditions()
        {

            ActivePlanLabel.Text = "Power Saver";
            buttonquicksetPerformance.ForeColor = Color.Black;
            buttonquicksetBalanced.ForeColor = Color.Black;
            buttonquicksetPowerSave.ForeColor = Color.Red;
            ActivePlanLabel.Text = "Power Saver";
            buttonquicksetPerformance.Enabled = true;
            buttonquicksetBalanced.Enabled = true;
            buttonquicksetPowerSave.Enabled = false;

            BalancedLabel.Visible = !true;
            PowerSaveLabel.Visible = !false;
            HighPerfLabel.Visible = false;
            NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_PowerSaver;
        }

        public void AutoPilotController()
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called AutoPilotController");
            if (AutoPilotStatus.Text == "True" & My.MySettingsProperty.Settings.AutoPilotEnabled == true) // autopilot is active
            {
                My.MyProject.Forms.UserPreferencesModule.StartonBoot.Checked = true;
                // UserPreferencesModule.StartonBoot.Enabled = Not True
                My.MyProject.Forms.UserPreferencesModule.Label24.Text = "Let the application to start on boot. This feature is currently being contolled by AutoPilot";
                My.MyProject.Forms.UserPreferencesModule.Label32.Visible = !true;
                My.MyProject.Forms.UserPreferencesModule.Label31.Visible = !true;
                My.MyProject.Forms.UserPreferencesModule.Label3.Visible = true;
                My.MyProject.Forms.UserPreferencesModule.Panel3.Dispose();
                My.MyProject.Forms.UserPreferencesModule.GameBoosterEnabled.Checked = true;
                // My.Settings.TaskManagerEnabled = True
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Autopilot is now controlling some user settings");
                My.MyProject.Forms.UserPreferencesModule.HideGameDetectionPanel.Visible = false;
                My.MyProject.Forms.DebugUI.VerboseAutoPilot.Text = "AutoPilot is now enabled";
            }


            else // autopilot is disabled
            {

                My.MyProject.Forms.UserPreferencesModule.StartonBoot.Enabled = true;
                My.MyProject.Forms.UserPreferencesModule.Label24.Text = "Let the application to start on boot.";
                My.MyProject.Forms.UserPreferencesModule.Label32.Visible = true;
                My.MyProject.Forms.UserPreferencesModule.Label31.Visible = true;
                My.MyProject.Forms.UserPreferencesModule.Label3.Visible = !true;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Autopilot is no longer controlling user settings");
                My.MyProject.Forms.UserPreferencesModule.HideGameDetectionPanel.Visible = true;
                My.MyProject.Forms.DebugUI.VerboseAutoPilot.Text = "AutoPilot is now disabled";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {







            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Form1 is loaded into memory.");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intializing Form1.");
            StartMinimized.Start();
            // CoreForm.Engine.Stop()
            // CoreForm.Hide()


            // set size at startup as the designer value may differ
            // designer size 1166; 437
            // user size
            Height = My.MySettingsProperty.Settings.UI_DefaultHeight;
            Width = My.MySettingsProperty.Settings.UI_DefaultWidth;


            // Call readDatabase


            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Resized form. New Height= " + Height.ToString() + " New Width= " + Width.ToString());
            // SetPowerPlan.start()
            if (My.MySettingsProperty.Settings.AllowPowermodeControl == true)
            {
                AllowPowermodeControl.Checked = true;
            }
            else
            {
                AllowPowermodeControl.Checked = false;
            }
            My.MyProject.Forms.UserPreferencesModule.Show();
            My.MyProject.Forms.UserPreferencesModule.Hide();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Getting and setting user settings. (Form1)");
            // // SETTING USER PREFERENCES 




            // old power plan saving
            // If My.Settings.PreferredPowerModeEqualsBalanced = True Then
            // PowerModeBalanced.Checked = True

            // Else
            // PowerModeHighPerf.Checked = True
            // End If
            My.MySettingsProperty.Settings.AllowQuit = true;

            // new powerplan saving
            if (My.MySettingsProperty.Settings.PreferredCPUModeAsByte == Conversions.ToDouble("0"))
            {
                PowerModeHighPerf.Checked = true;
            }
            else if (My.MySettingsProperty.Settings.PreferredCPUModeAsByte == Conversions.ToDouble("1"))
            {
                PowerModeBalanced.Checked = true;
            }
            else if (My.MySettingsProperty.Settings.PreferredCPUModeAsByte == Conversions.ToDouble("2"))
            {
                PowerModeBattery.Checked = true;
            }
            else
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: Setting PrefferedCPUMode is empty! Setting it to the default value. (Balanced)");
                My.MySettingsProperty.Settings.PreferredCPUModeAsByte = 1;
                // MsgBox("WARNING: Setting PrefferedCPUMode is empty! Setting it to the default value. (Balanced)")
                My.MySettingsProperty.Settings.Save();

                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "WARNING: Setting PrefferedCPUMode is corrupted! Setting it to the default value. (Balanced)";
                CoreForm.errorLoggingSystem();
            }


            // If My.Settings.GamingPowerModeEquals70Freq = True Then
            // GamingModeLowFreq.Checked = True
            // Else
            // GamingModeDoNotAlter.Checked = True
            // End If

            if (My.MySettingsProperty.Settings.CheckInvertalEqualsFrequent == true)
            {
                My.MyProject.Forms.UserPreferencesModule.Interval1.Checked = true;
            }
            else
            {
                My.MyProject.Forms.UserPreferencesModule.Interval2.Checked = true;
            }

            TargetProcessBox.Text = My.MySettingsProperty.Settings.TargetProcess;
            if (My.MySettingsProperty.Settings.StartOnBootEnabled == true)
            {
                My.MyProject.Forms.UserPreferencesModule.StartonBoot.Checked = true;
            }
            else
            {
                My.MyProject.Forms.UserPreferencesModule.StartonBoot.Checked = false;

            }


            // get if the system is just started or running for a while to determine if the app is started by the user or the system itself
            // EnvironmentTickCount.Text = Environment.TickCount ' get the tick count
            // If EnvironmentTickCount.Text < 670000 Then 'if system is started in 670 seconds before the APP launch
            // Hide()
            // Else
            // End If

            if (My.MySettingsProperty.Settings.TopMost == true)
            {
                My.MyProject.Forms.UserPreferencesModule.TopMostCheckbox.Checked = true;
                TopMost = true;
            }
            else
            {
                TopMost = false;
                My.MyProject.Forms.UserPreferencesModule.TopMostCheckbox.Checked = false;
            }



            // NotifyIcon1.Icon = My.Resources.AppIcon
            // Icon = My.Resources.AppIcon
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized NotifyIcon");
            if (My.MyProject.Forms.UserPreferencesModule.StartonBoot.Checked)
            {
                // start on boot
                try
                {
                    My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).SetValue(Application.ProductName, Application.ExecutablePath + " /onboot");
                }
                catch (Exception ex)
                {
                    // UserPreferencesModule.StartonBoot.Checked = False
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Cannot set registry key (Startup reg)");
                    // CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Cannot set registry key (Startup reg)."
                    // Call CoreForm.errorLoggingSystem
                }
            }
            else
            {
                // DO NOT start on boot
                try
                {
                    My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true).DeleteValue(Application.ProductName);
                }
                catch (Exception ex)
                {
                    // UserPreferencesModule.StartonBoot.Checked = True
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Cannot set registry key. (Uninstall reg key from startup reg)");
                    CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Cannot set registry key (Uninstall reg key from startup reg).";
                    CoreForm.errorLoggingSystem();
                }
            }


            if (Environment.GetCommandLineArgs().Count() != 1)
            {
                try
                {
                    ArgumentsLabel.Text = Environment.GetCommandLineArgs()[1].ToString();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Started with argument= " + ArgumentsLabel.Text);
                }
                catch (Exception ex)
                {
                    ArgumentsLabel.Text = "ERR";
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Cannot retrieve arguments");
                    CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: Cannot retrieve startup argument. .";
                    CoreForm.errorLoggingSystem();
                }
            }

            else
            {
                ArgumentsLabel.Text = "NONE";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Started with no arguments");
            }
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized all components of Form1");

            if (My.MySettingsProperty.Settings.DisableDeveloperDetectorService == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Not calling VisualStudioDetector. FLAGDisableDeveloperDetectorService is set to true.");
            }
            else
            {
                My.MyProject.Forms.VisualStudioDetector.Show();
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called VisualStudioDetector");
            }



            My.MySettingsProperty.Settings.DisableSizeChangedEventChecks = false;
            My.MySettingsProperty.Settings.DisableLegacyServices = true;
            // revert to normalised settings if altered by debugger
            EnableFastCheck.Start();
            My.MySettingsProperty.Settings.LastCpuModeFriendlyName = "0";
            My.MySettingsProperty.Settings.Save();

            if (My.MySettingsProperty.Settings.SafemodeEnabled == true)
            {
                Button2.Location = new Point(4, 79);
                Text = Text + " - Safemode is enabled";
                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "SAFEMODE: Application has started with safemode conditions.";
                CoreForm.errorLoggingSystem();
                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "SAFEMODE: Application has started with safemode conditions.";
                CoreForm.errorLoggingSystem();
                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "SAFEMODE: Application has started with safemode conditions.";
                CoreForm.errorLoggingSystem();
            }
            else
            {

            }
            NotifyIcon1.Text = "AutoPowerModeSwitcher";

        }

        private void CheckPowerPlan_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CheckPowerPlan timer ticked. Interval: " + CheckPowerPlan.Interval.ToString() + "ms");
            My.MyProject.Forms.DebugUI.CheckPowerPlanTickCount.Text = (Conversions.ToDouble(My.MyProject.Forms.DebugUI.CheckPowerPlanTickCount.Text) + 1d).ToString();
            string currentPowerPlan = Conversions.ToString(My.MyProject.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control").OpenSubKey("Power").OpenSubKey("User").OpenSubKey("PowerSchemes").GetValue("ActivePowerScheme"));
            CurrentPowerPlanLabel.Text = currentPowerPlan;


            if (CurrentPowerPlanLabel.Text == "8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c")
            {
                applyHighPerformanceConditions();
            }



            else if (CurrentPowerPlanLabel.Text == "381b4222-f694-41f0-9685-ff5bb260df2e")
            {
                applyBalancedConditions();
            }


            // PowerModeBalanced.Checked = True
            else if ((CurrentPowerPlanLabel.Text ?? "") == (My.MySettingsProperty.Settings.LowFreqGUID ?? ""))
            {
                ActivePlanLabel.Text = "Low freq. mode";
            }
            // PowerModeLowFreq.Checked = True

            else if (CurrentPowerPlanLabel.Text == "a1841308-3541-4fab-bc81-f71556f20b4a")
            {
                applyPowerSaverConditions();
            }

            else
            {


                ActivePlanLabel.Text = "Unsupported";
                NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_error;
                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Unsupported powermode detected. APMS may not be able to control it and the core application functions may act unexpectedly.";
                CoreForm.errorLoggingSystem();
            }



            // CheckPowerPlan.Interval = 1750
        }

        private void SetPowerPlan_Tick(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.DisableLegacyServices == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer is no longer used. Disposing...");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer is no longer used. Disposing...");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer is no longer used. Disposing...");

                SetPowerPlan.Dispose();
            }
            else
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer ticked.Interval: " + SetPowerPlan.Interval.ToString() + "ms");
                My.MyProject.Forms.DebugUI.SetPowerPlanTickCount.Text = (Conversions.ToDouble(My.MyProject.Forms.DebugUI.SetPowerPlanTickCount.Text) + 1d).ToString();
                // ////interval should be low as the timer only executed once per call.
                if (My.MyProject.Forms.UserPreferencesModule.EngineMode2.Checked == true)
                {
                    if (ConfilictLabel.Text == "True") // if bootoptimizer is running then
                    {
                        // do nothing as bootoptimizer is working and they may confilict if working together
                        EngineStatusLabel.Text = "Not running";
                    }
                    else
                    {
                        // if bootoptimizer isn't working go on and run the code
                        EngineStatusLabel.Text = "Running";
                        if (ProcessLabel.Text == "True") // if game is running
                        {
                            if (GamingModeLowFreq.Checked) // if 70 mode selected
                            {
                                GamingModeDoNotAlter.Checked = false;           // lowfreq mode no longer works for desktop systems.
                                Interaction.Shell("powercfg /s " + My.MySettingsProperty.Settings.LowFreqGUID, AppWinStyle.Hide);
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to LowFreq.");
                            }

                            else // if DO NOT ALTER is selected
                            {
                                GamingModeLowFreq.Checked = false;

                            }
                        }

                        else if (PowerModeHighPerf.Checked) // if not running
                                                            // if high performance mode is requested by user
                        {
                            PowerModeBalanced.Checked = false;
                            Interaction.Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide);
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to high performance.");
                        }


                        else // if balanced is requested
                        {
                            PowerModeHighPerf.Checked = false;
                            Interaction.Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide);
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to Balanced");
                        }

                        SetPowerPlan.Stop(); // so this makes the code only execute ONCE per call
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Stopped SetPowerPlan engine.");
                        // BUG Stopping engine will cause system instability as (rapidly) changing powermodes from control panel will make app and system show different values from each other

                    }
                }
                else
                {
                }
            }

        }

        private void ProcessCheck_Tick(object sender, EventArgs e)
        {

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ProcessCheck timer ticked. Interval: " + ProcessDetector.Interval.ToString() + "ms");
            My.MyProject.Forms.DebugUI.ProcessDetectorTickCount.Text = (Conversions.ToDouble(My.MyProject.Forms.DebugUI.ProcessDetectorTickCount.Text) + 1d).ToString();
            if (My.MySettingsProperty.Settings.AllowPowermodeControl == false)
            {
            }
            else
            {
                Process[] p;
                p = Process.GetProcessesByName(TargetProcessBox.Text);
                if (p.Count() > 0)
                {
                    ProcessLabel.Text = "True";       // Process is running
                    if (CurrentGameLabel.Text == "NULL")
                    {

                        CurrentGameLabel.Text = TargetProcessBox.Text;
                    }
                    else
                    {

                    }
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is now running.");
                }
                else
                {
                    ProcessLabel.Text = "False";  // Process is not running
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is NOT running.");
                    CurrentGameLabel.Text = "NULL";
                }
            }
        }


        private void FormSizeControl_Tick(object sender, EventArgs e)
        {
            // NO LONGER IN-USE
            // Instead of a timer the app now watches SizeChanged event
            // FormHeightLabel.Text = Height
            // Width = 315
            // If FormHeightLabel.Text > 416 Then
            // Height = 416
            // -REMOVED size changed counter 
            // SIZECHANGEDCOUNTER.Text = SIZECHANGEDCOUNTER.Text + 1 
            // Else

            // End If
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: FormSize Control timer ticked. THIS TIMER SHOULD NOT TICK. CHECK!!!!!");
            CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: .";
            CoreForm.errorLoggingSystem();
        }


        private void ProcessLabel_TextChanged(object sender, EventArgs e)
        {
            // SetPowerPlan.start() 'so when the process running status changed powermode will be set
            if (ProcessLabel.Text == "True")
            {
                declareTargetProcessAsRunning();
                Label28.Visible = true;
                changePowerMode();
            }
            else
            {
                Label28.Visible = false;
                changePowerMode();
                declareTargetProcessAsRunningValue = false;

            }
            if (My.MySettingsProperty.Settings.TaskManagerEnabled == true) // if user enabled game booster
            {
                if (My.MyProject.Forms.UserPreferencesModule.KillProcessesCheckBox.Checked == true) // if user enabled game booster
                {
                    if (ProcessLabel.Text == "True") // if game is running (in this code snippet it acts as if game started)
                    {

                        // killer code here

                        Interaction.Shell("taskkill -f /im LiveUpdate.exe", AppWinStyle.Hide);
                        Interaction.Shell("taskkill -f /im Rainmeter.exe", AppWinStyle.Hide);


                        Interaction.Shell("taskkill -f /im UninstallMonitor.exe", AppWinStyle.Hide);


                        Interaction.Shell("taskkill -f /im IDMan.exe", AppWinStyle.Hide);
                        Interaction.Shell("taskkill -f /im IEMonitor.exe", AppWinStyle.Hide);



                        // Shell("taskkill -f /im spoolsv.exe", AppWinStyle.Hide)
                        // If UserPreferencesModule.PrioritizeTargetProcessCheckBox.Checked = True Then instead of checking UserPreferencesModule check my.settings
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "TaskManager: Killed processes as the user checked KillProcessesCheckBox.");
                        if (My.MySettingsProperty.Settings.TaskManagerPrioritize == true)
                        {

                            Process[] psList;
                            try
                            {
                                psList = Process.GetProcesses();
                                foreach (Process p in psList)
                                {
                                    if ((p.ProcessName ?? "") == (TargetProcessBox.Text + ".exe" ?? ""))
                                    {
                                        p.PriorityClass = ProcessPriorityClass.High;
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Prioritized target process as the user checked TaskManagerPrioritize checkbox.");
                                    }
                                }
                            }
                            catch
                            {
                                CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "pslist failed to prioritize target process.";
                                CoreForm.errorLoggingSystem();
                            }
                        }
                    }
                    else if (Conversions.ToDouble(Label30.Text) < 1d)
                    {
                        Label30.Text = (Conversions.ToDouble(Label30.Text) + 1d).ToString();
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Bug fixer code had been executed just now. Skipped RestartAfterSession as a result. (Value is < 1)");
                    }

                    else if (My.MyProject.Forms.UserPreferencesModule.RestartAfterSessionCheckBox.Checked == true)
                    {
                        NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher";
                        NotifyIcon1.BalloonTipText = "You have quit the game. APMS is restoring your system to its normal conditions";
                        NotifyIcon1.ShowBalloonTip(2800);
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "End of game session. Restarting killed processes.");
                        // Dim OneDrive() As Process
                        // OneDrive = Process.GetProcessesByName("OneDrive")
                        // If OneDrive.Count > 0 Then   ' Process is running
                        // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "OneDrive is already running, no need to restart.")
                        // Else      ' Process is not running

                        // Try
                        // Process.Start("C:\Users\cspr\AppData\Local\Microsoft\OneDrive\OneDrive.exe /background")
                        // Dim proc As New ProcessStartInfo
                        // proc.UseShellExecute = True
                        // proc.FileName = "C:\Users\cspr\AppData\Local\Microsoft\OneDrive\OneDrive.exe"
                        // proc.Verb = "runas"
                        // proc.Arguments = "/background"
                        // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "OneDrive is started successfully.")
                        // Catch ex As Exception
                        // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "OneDrive process cannot be started. Probably executable not found")
                        // End Try
                        // End If


                        Process[] Rainmeter;
                        Rainmeter = Process.GetProcessesByName("Rainmeter");
                        if (Rainmeter.Count() > 0)   // Process is running
                        {
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Rainmeter is already running, no need to restart.");
                        }
                        else      // Process is not running
                        {

                            try
                            {
                                Process.Start(@"C:\Program Files\Rainmeter\Rainmeter.exe");
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Rainmeter is started successfully.");
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Rainmeter process cannot be started. Probably executable not found");
                            }

                        }

                        Process[] Dropbox;
                        Dropbox = Process.GetProcessesByName("Dropbox");
                        if (Dropbox.Count() > 0)   // Process is running
                        {
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Dropbox is already running, no need to restart.");
                        }
                        else      // Process is not running
                        {

                            try
                            {
                                Process.Start(@"C:\Program Files (x86)\Dropbox\Client\Dropbox.exe", "/systemstartup");
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Dropbox is started successfully.");
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Dropbox process cannot be started. Probably executable not found");
                            }

                        }

                        Process[] iCloud;
                        iCloud = Process.GetProcessesByName("iCloud");
                        if (iCloud.Count() > 0)   // Process is running
                        {
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "iCloud is already running, no need to restart.");
                        }
                        else      // Process is not running
                        {
                            try
                            {
                                Process.Start(@"C:\Program Files (x86)\Common Files\Apple\Internet Services\iCloudServices.exe");
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "iCloudServices process is started successfully.");
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "iCloudServices process cannot be started. Probably executable not found");
                            }

                        }

                        Process[] Lightshot;
                        Lightshot = Process.GetProcessesByName("Lightshot");
                        if (Lightshot.Count() > 0)   // Process is running
                        {
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Ligtshot is already running, no need to restart.");
                        }
                        else      // Process is not running
                        {

                            try
                            {
                                Process.Start(@"C:\Program Files (x86)\Skillbrains\lightshot\Lightshot.exe");
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Lightshot is started successfully.");
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Lightshot process cannot be started. Probably executable not found");
                            }
                        }
                    }

                    else
                    {







                    }
                }
            }
            else
            {

            }
        }
        private void MemoryOptimizer_Tick(object sender, EventArgs e)
        {
            My.MyProject.Forms.DebugUI.MemOptimizerTickCount.Text = My.MyProject.Forms.DebugUI.MemOptimizerTickCount.Text;
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "MemoryOptimizer engine ticked.");
            // 'SetPowerPlan.start() 'execute powermode switcher codes every 60 (was 30) seconds
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            My.MySettingsProperty.Settings.AllowQuit = true;
            My.MySettingsProperty.Settings.Save();
            AllowQuit.Text = "True";
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User requested termination with an toolstip item. Allowing...");
            // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminating application because AllowQuit returned True.")
            // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminated application.")
            Close();

        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                Hide();
            }
            // ToolStripMenuItem1.Text = ("Show App")
            else
            {
                Show();
                // ToolStripMenuItem1.Text = ("Hide App")
            }
        }

        private void BootOptimizerConflictFixer_Tick(object sender, EventArgs e)
        {
            // Keep this disabled as we no longer use BootOptimizer
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "BootOptimizer Confilict fixer timer ticked!.");
            Process[] p;
            p = Process.GetProcessesByName("BootOptimizer");
            if (p.Count() > 0)
            {
                ConfilictLabel.Text = "True";       // BootOptimizer is running

                if (Conversions.ToDouble(TimesHidden.Text) > 3d) // hide form if bootoptimizer is running (pc has just started)
                {
                }

                else
                {
                    Hide();
                    TimesHidden.Text = (Conversions.ToDouble(TimesHidden.Text) + 1d).ToString();
                }
            }

            else
            {
                ConfilictLabel.Text = "False";
            }  // Bootoptimizer is not running
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.DebugUI.CheckBox24.Checked == true)
            {
                Interaction.MsgBox("User control is disabled. Check settings for more info");
            }
            else
            {
                TargetProcessBox.Text = "GTA5";
                TargetProcessBox.Enabled = true;
            }

        }

        private void SettingsEngine_Tick(object sender, EventArgs e)
        {
            // this timer checks your actions and saves them as a setting to load on next startup of app
            // this timer ticks every 360 seconds to save your preferences AUTOMATICLY
            if (My.MySettingsProperty.Settings.DisableLegacyServices == true)
            {
                SettingsEngine.Stop();
            }
            else
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Settings saver timer ticked. Interval: " + SettingsEngine.Interval.ToString() + "ms");
                if (PowerModeHighPerf.Checked)
                    My.MySettingsProperty.Settings.PreferredPowerModeEqualsBalanced = false;
                if (PowerModeBalanced.Checked)
                    My.MySettingsProperty.Settings.PreferredPowerModeEqualsBalanced = true;
                if (GamingModeLowFreq.Checked)
                    My.MySettingsProperty.Settings.GamingPowerModeEquals70Freq = true;
                if (GamingModeDoNotAlter.Checked)
                    My.MySettingsProperty.Settings.GamingPowerModeEquals70Freq = false;
                if (My.MyProject.Forms.UserPreferencesModule.Interval1.Checked)
                    My.MySettingsProperty.Settings.CheckInvertalEqualsFrequent = true;
                if (My.MyProject.Forms.UserPreferencesModule.Interval2.Checked)
                    My.MySettingsProperty.Settings.CheckInvertalEqualsFrequent = false;
                My.MySettingsProperty.Settings.TargetProcess = TargetProcessBox.Text;
                if (My.MyProject.Forms.UserPreferencesModule.StartonBoot.Checked == true)
                {
                    My.MySettingsProperty.Settings.StartOnBootEnabled = true;
                }
                else
                {
                    My.MySettingsProperty.Settings.StartOnBootEnabled = false;
                }
                if (My.MyProject.Forms.UserPreferencesModule.StartMinimized.Checked == true)
                {
                    My.MySettingsProperty.Settings.StartMinimized = true;
                }
                else
                {
                    My.MySettingsProperty.Settings.StartMinimized = false;
                }
                if (My.MyProject.Forms.UserPreferencesModule.TopMostCheckbox.Checked == true)
                {
                    My.MySettingsProperty.Settings.TopMost = true;
                }
                else
                {
                    My.MySettingsProperty.Settings.TopMost = false;
                }

                My.MySettingsProperty.Settings.Save();
                SettingsEngine.Stop();

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (AllowQuit.Text == "True") // if user tried to exit app via taskbar icon then let user exit
            {
                // APPLICATION IS BEING TERMINATED!

                // e.Cancel = true
                My.MySettingsProperty.Settings.AllowQuit = true;
                My.MySettingsProperty.Settings.Save();
                if (Conversions.ToDouble(overflowCurseBlocker.Text) > 2d)
                {
                }

                else
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked X button. Application is preparing to shutdown because AllowQuit returned True");
                    overflowCurseBlocker.Text = (Conversions.ToDouble(overflowCurseBlocker.Text) + 1d).ToString();
                    writeDatabase();
                    NotifyIcon1.Visible = false;



                    NotifyIcon1.Visible = false;
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saving user preferences and shutting down.");
                    My.MySettingsProperty.Settings.Save();

                    My.MyProject.Forms.CoreForm.Close();
                    System.Threading.Thread.Sleep(200);


                    My.MyProject.Forms.UserPreferencesModule.Close();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Goodbye!!");
                    Application.Exit();
                }
            }




            else // if user clicked X button DO NOT LET user to exit app instead Hide the app and notify the user about it
            {
                e.Cancel = true;

                if (My.MySettingsProperty.Settings.FirstTimeClosing == true)
                {
                    // MsgBox("Clicking 'X' button only minimizes the app to the taskbar for the best user experience. If you want to terminate the app right click on the icon on the notification bar and click exit. This help message is won't be shown again.",MsgBoxStyle.OkOnly, "AutoPowerModeSwitcher TIP")
                    NotifyIcon1.BalloonTipText = "Application is still running in the background, right click notification and click on 'Exit' to quit.";
                    NotifyIcon1.BalloonTipTitle = "APMS is minimized to taskbar";
                    NotifyIcon1.ShowBalloonTip(3000);
                    My.MySettingsProperty.Settings.FirstTimeClosing = false;
                    My.MySettingsProperty.Settings.Save();
                    Hide();
                    My.MyProject.Forms.GameList.Close();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing notification= " + NotifyIcon1.BalloonTipTitle.ToString());
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked X button. Application is minimized because AllowQuit returned False.");
                }
                else
                {
                    // NotifyIcon1.BalloonTipText = "Application is still running in the background"
                    // NotifyIcon1.BalloonTipTitle = "APMS is minimized to taskbar"
                    // NotifyIcon1.ShowBalloonTip(3000)
                    Hide();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked X button. Application is minimized because AllowQuit returned False.");
                }


            }

        }
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            // this sub itself does nothing
        }
        private void StartMinimized_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "StartMinimized timer ticked.");
            if (My.MySettingsProperty.Settings.StartMinimized == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Application Started Minimized!");
                My.MyProject.Forms.UserPreferencesModule.StartMinimized.Checked = true;
                Hide();
            }
            // NotifyIcon1.BalloonTipText = "Application is started minimized according to your preferences, you can change this on settings menu."
            // NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher is working in background"
            // NotifyIcon1.ShowBalloonTip(3000)
            else
            {

                My.MyProject.Forms.UserPreferencesModule.StartMinimized.Checked = false;
            }
            StartMinimized.Stop(); // run once per call (only being called on app startup)
        }
        private void ContextEngine_Tick(object sender, EventArgs e)
        {
            // if me.visible = true then
            // ToolStripMenuItem1.Text = "Hide app"
            // Else 
            // ToolStripMenuItem1.Text = "Show app"
            // End If
            // no longer used
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {


            My.MyProject.Forms.UserPreferencesModule.Show();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked settings button.");
        }

        private void SetPowerPlanAlternate_Tick(object sender, EventArgs e)
        {
            // ######################### THIS TIMER SHOULD NOT BE USED ANYMORE #################################
            if (My.MySettingsProperty.Settings.DisableLegacyServices == true)
            {

                SetPowerPlanAlternate.Dispose();
            }

            else
            {

                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlanAlternate timer ticked.");
                // If UserPreferencesModule.EngineMode1.Checked = True Then
                My.MyProject.Forms.DebugUI.SetPowerPlanAlternateTickCount.Text = (Conversions.ToDouble(My.MyProject.Forms.DebugUI.SetPowerPlanAlternateTickCount.Text) + 1d).ToString();
                if (My.MySettingsProperty.Settings.CoreEngineModeEqualsOptimized == false)
                {


                    if (ConfilictLabel.Text == "True") // if bootoptimizer is running then
                    {
                        // do nothing as bootoptimizer is working and they may confilict if working together
                        EngineStatusLabel.Text = "Not running";
                    }
                    else
                    {
                        // if bootoptimizer isn't working go on and run the code
                        EngineStatusLabel.Text = "Running";
                        if (ProcessLabel.Text == "True") // if game is running
                        {
                            if (GamingModeLowFreq.Checked) // if 70 mode selected
                            {
                                GamingModeDoNotAlter.Checked = false;
                                Interaction.Shell("powercfg /s " + My.MySettingsProperty.Settings.LowFreqGUID, AppWinStyle.Hide);
                            }


                            else // if DO NOT ALTER is selected
                            {
                                GamingModeLowFreq.Checked = false;

                            }
                        }

                        else if (PowerModeHighPerf.Checked) // if not running
                                                            // if high performance mode is requested by user
                        {
                            PowerModeBalanced.Checked = false;
                            Interaction.Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide);
                        }



                        else // if balanced is requested
                        {
                            PowerModeHighPerf.Checked = false;
                            Interaction.Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide);
                        }

                        // SetPowerPlan.Stop() 'so this makes the code only execute ONCE per call
                        // BUG Stopping engine will cause system instability as (rapidly) changing powermodes from control panel will make app and system show different values from each other

                    }
                }

                else
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core engine mode is set in the Optimized mode. Stopping SetPowerPlanAlternate engine.");
                    SetPowerPlanAlternate.Stop();

                }
            }




        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UserPreferencesModule.Show();
        }


        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ContextMenuStrip has been opened.");
            if (ToolStripMenuItem3.Text.Contains("wait"))
            {

                CheckPowerPlan.Interval = 1;
                System.Threading.Thread.Sleep(5);


            }
        }

        private void SetToHighPerfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide);
            NotifyIcon1.BalloonTipText = "Set powermode to High Performance!";
            NotifyIcon1.BalloonTipTitle = "APMS Quick Setting Toggle";
            NotifyIcon1.ShowBalloonTip(100);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick Setting Toggle, Set powermode to High Performance");
        }


        private void SetPowermodeToBalancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide);
            NotifyIcon1.BalloonTipText = "Set powermode to Balanced!";
            NotifyIcon1.BalloonTipTitle = "APMS Quick Setting Toggle";
            NotifyIcon1.ShowBalloonTip(100);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick Setting Toggle, Set powermode to Balanced");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                ToolStripMenuItem1.Text = "Hide app";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's visibility changed. It's visible.");
            }
            else
            {
                ToolStripMenuItem1.Text = "Show app";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's visibility changed. It's NOT visible.");
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.DisableSizeChangedEventChecks == true) // do not alter user's size. debug flag
            {

                FormHeightLabel.Text = "Disabled by policy";
            }

            else
            {
                int formHeight = My.MySettingsProperty.Settings.UI_DefaultHeight;
                int formWidth = My.MySettingsProperty.Settings.UI_DefaultWidth;
                int formMaxHeight = Conversions.ToInteger(My.MySettingsProperty.Settings.UI_MaxHeight);
                int formMaxWidth = Conversions.ToInteger(My.MySettingsProperty.Settings.UI_MaxWidth);
                int formMinHeight = Conversions.ToInteger(My.MySettingsProperty.Settings.UI_MinHeight);
                FormHeightLabel.Text = Height.ToString();
                FormWidthLabel.Text = Width.ToString();
                // new allowed size = 608,300

                if (Conversions.ToDouble(FormWidthLabel.Text) > formMaxWidth)
                {
                    Width = formMaxWidth;
                }

                else
                {

                }
                // Width = 315
                if (Conversions.ToDouble(FormHeightLabel.Text) > formMaxHeight)
                {
                    Height = formMaxHeight;

                    if (Conversions.ToDouble(ConsoleFloodCounter.Text) > 8d)
                    {
                        ConsoleFloodCounter.Text = (Conversions.ToDouble(ConsoleFloodCounter.Text) - 1d).ToString();
                    }
                    else
                    {
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's size changed. It was over max limit and set to the allowed max size. (" + formHeight + ")");
                        ConsoleFloodCounter.Text = (Conversions.ToDouble(ConsoleFloodCounter.Text) + 2d).ToString();
                    }
                }

                // -REMOVED size changed counter 
                // SIZECHANGEDCOUNTER.Text = SIZECHANGEDCOUNTER.Text + 1 
                else if (Conversions.ToDouble(FormHeightLabel.Text) < formMinHeight) // MIN VALUE
                {
                    Height = formMinHeight;

                    if (Conversions.ToDouble(ConsoleFloodCounter.Text) > 8d)
                    {
                        ConsoleFloodCounter.Text = (Conversions.ToDouble(ConsoleFloodCounter.Text) - 1d).ToString();
                    }
                    else
                    {
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's size changed. It was over min limit and set to the allowed min size. (unmeasured)");
                        ConsoleFloodCounter.Text = (Conversions.ToDouble(ConsoleFloodCounter.Text) + 2d).ToString();
                    }
                }

                else
                {


                }

            }



            if (Conversions.ToDouble(FormWidthLabel.Text) < 310d) // MIN VALUE
            {
                Width = 310;
            }


        }


        private void FreeSpaceChecker_Tick(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.UserTrackingEnabled == true)
            {
                if (Operators.CompareString(My.MyProject.Computer.FileSystem.Drives[0].AvailableFreeSpace.ToString(), FreeSpaceLabel.Text, false) > 0)
                {
                    IOLabel.Text = "INCR";
                    IOLabel.ForeColor = Color.Green;
                }
                else if ((My.MyProject.Computer.FileSystem.Drives[0].AvailableFreeSpace.ToString() ?? "") == (FreeSpaceLabel.Text ?? ""))
                {
                    IOLabel.Text = "EQUAL";
                    IOLabel.ForeColor = Color.Purple;
                }
                else
                {
                    IOLabel.Text = "DECR";
                    IOLabel.ForeColor = Color.Purple;
                }
                FreeSpaceLabel.Text = My.MyProject.Computer.FileSystem.Drives[0].AvailableFreeSpace.ToString() + " bytes";
            }


            else
            {
                FreeSpaceChecker.Dispose();
                FreeSpaceLabel.Text = "Disabled by user";
                IOLabel.Text = "NONE";
                IOLabel.ForeColor = Color.Red;

            }

        }

        private void AutoPilotStatus_TextChanged(object sender, EventArgs e)
        {
            AutoPilotController();
        }


        private void CPUTracker_Tick(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.UserTrackingEnabled == true)
            {
                CPUUsageLabel.Text = ((int)Math.Round(m_PerformanceCounter.NextValue())).ToString();
            }
            else
            {
                CPUTracker.Dispose();
                CPUUsageLabel.Text = "Disabled by user";

            }


        }

        private void CPUUsageLabel_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (Conversions.ToDouble(CPUUsageLabel.Text) > 99d)
                {

                    NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher";
                    NotifyIcon1.BalloonTipText = "Warning: CPU usage is too high if you are not running any CPU-demanding apps at the time and still seeing this, your PC may be infected by a malware.";
                    NotifyIcon1.ShowBalloonTip(25000);
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: CPU utilization is over 99 percentage.");
                }
            }
            catch (Exception ex)
            {
                // Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Exception occured while measuring CPU usage.")
                // CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "An error occured while measuring CPU usage percentage. Exception details: " & ex.ToString
                // Call CoreForm.errorLoggingSystem
            } // its not critical and is caused when user disables cpu tracking. conversion from string to double is not vaild.

        }



        private void EnvTickCounter_Tick(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.UserTrackingEnabled == true)
            {
                EnvironmentTickCount.Text = Environment.TickCount.ToString();
            }
            else
            {
                EnvTickCounter.Dispose();
                EnvironmentTickCount.Text = "Disabled by user";

            }

        }
        private void Form1_Move(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.UserTrackingEnabled == true)
            {
                FormLocationLabel.Text = Location.ToString();
            }
            else
            {
                FormLocationLabel.Text = "Disabled by user";

            }

        }

        private void Label23_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CoreForm.Show();

        }

        private void TargetProcessBox_TextChanged(object sender, EventArgs e)
        {
            if (TargetProcessBox.Text.Contains(".exe"))
            {
                TargetProcessBox.Text = "";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User typed an extension in the target process box. Reset.");
            }
            else
            {
                My.MySettingsProperty.Settings.TargetProcess = TargetProcessBox.Text;
                My.MySettingsProperty.Settings.Save();
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "New target registered");
            }
        }

        private void Label28_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                declareTargetProcessAsRunning();
            }
            else
            {
                declareTargetProcessAsRunningValue = false;
            }
        }

        private void TargetProcessBox_Leave(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.TargetProcess = TargetProcessBox.Text;
            My.MySettingsProperty.Settings.Save();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved target process value");
        }

        private void TargetProcessBox_EnabledChanged(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.TargetProcess = TargetProcessBox.Text;
            My.MySettingsProperty.Settings.Save();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved target process value");
        }

        private void ShowAutoPowerSwitcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AutoPowerSwitcher.Show();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing AutoPowerSwitcher");
        }
        private void NotifyIcon1_BalloonTipShown(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notification is being displayed at the moment. The notification text is: " + NotifyIcon1.BalloonTipText.ToString());
        }

        private void NotifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notification is no longer being displayed.");
        }

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User paid attention and clicked on the notification.");
            if (ActivePlanLabel.Text.Contains("High"))
            {
                if (BallonTipClickActionByte.Text == "0")
                {
                    Show();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Click action: Only show APMS");
                }
                else
                {
                    Show();
                    EnableFastCheck.Start();
                    Interaction.Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide);
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to Balanced from the notification");
                    memorizePowerPlan();
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Click action: Change powermode to Balanced.");
                    Hide();

                    NotifyIcon1.BalloonTipTitle = "Greenified Your System";
                    NotifyIcon1.BalloonTipText = "Thanks for paying attention, we have set your powermode to Balanced.";
                    NotifyIcon1.ShowBalloonTip(1000);
                    BallonTipClickActionByte.Text = "0";

                }
            }
            else
            {
                BallonTipClickActionByte.Text = "0";
                Show();

            }

        }

        private void ActivePlanLabel_TextChanged(object sender, EventArgs e)
        {

            if (ActivePlanLabel.Text.Contains("Balanced"))
            {
                ToolStripMenuItem3.Text = "Current: Balanced";
            }
            else if (ActivePlanLabel.Text.Contains("High"))
            {
                ToolStripMenuItem3.Text = "Current: HighPerf";
            }
            else if (ActivePlanLabel.Text.Contains("Freq"))
            {
                ToolStripMenuItem3.Text = "Currently Gaming!";
            }
            else if (ActivePlanLabel.Text.Contains("Save"))
            {
                ToolStripMenuItem3.Text = "Current: PowerSaver";
            }
            else
            {
                ToolStripMenuItem3.Text = "Current: Unsupported";
            }
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ContextMenu ActivePlanLabel has been changed. Is now set to: " + ToolStripMenuItem3.Text);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            My.MyProject.Forms.DebugUI.Show();

        }

        private void FreeSpaceLabel_Click(object sender, EventArgs e)
        {

        }

        private void IOLabel_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label30_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void PowerModeHighPerf_CheckedChanged(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.PreferredCPUModeAsByte = 0;
            My.MySettingsProperty.Settings.Save();


        }

        private void PowerModeBalanced_CheckedChanged(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.PreferredCPUModeAsByte = 1;
            My.MySettingsProperty.Settings.Save();


        }

        private void PowerModeBattery_CheckedChanged(object sender, EventArgs e)
        {
            My.MySettingsProperty.Settings.PreferredCPUModeAsByte = 2;
            My.MySettingsProperty.Settings.Save();


        }

        private void CurrentGameLabel_TextChanged(object sender, EventArgs e)
        {
            if (CurrentGameLabel.Text == "NULL")
            {
                CurrentGameLabel.Visible = !true;
                Label12.Visible = !true;
            }
            else
            {
                CurrentGameLabel.Visible = true;
                Label12.Visible = true;

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }



        private void Label12_VisibleChanged(object sender, EventArgs e)
        {
            if (Label12.Visible == true)
            {
                Label26.Visible = false;
            }
            else
            {
                Label26.Visible = !false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.GameList.Show();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            EnableFastCheck.Start();
            Interaction.Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to Balanced from the UI");
            memorizePowerPlan();

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            EnableFastCheck.Start();
            Interaction.Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to High Performance from the UI");
            memorizePowerPlan();
            HighPerformanceWarning.Stop();
            HighPerformanceWarning.Start();

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            EnableFastCheck.Start();
            Interaction.Shell("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a", AppWinStyle.Hide);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to PowerSaver from the UI");
            memorizePowerPlan();

        }

        private void PowerSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.Shell("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a", AppWinStyle.Hide);
            NotifyIcon1.BalloonTipText = "Set powermode to Power Saver!";
            NotifyIcon1.BalloonTipTitle = "APMS Quick Setting Toggle";
            NotifyIcon1.ShowBalloonTip(100);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick Setting Toggle, Set powermode to Power Saver");
        }

        private void EnableFastCheck_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ENABLED FAST CHECK");
            CheckPowerPlan.Interval = Conversions.ToInteger(My.MySettingsProperty.Settings.FastCheckConditionCheckPowerModeEngineInterval);
            FastCheckDeadline.Start();
            EnableFastCheck.Dispose();
        }

        private void DisableFastCheck_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DISABLED FAST CHECK");
            int normalisedinterval = My.MySettingsProperty.Settings.CheckPowerPlanInterval;
            CheckPowerPlan.Interval = normalisedinterval;
            FastCheckDeadline.Stop();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox2.Checked = false;
            Height = My.MySettingsProperty.Settings.UI_DefaultHeight;
            Width = My.MySettingsProperty.Settings.UI_DefaultWidth;
        }

        private void CheckBox3_CheckedChanged_2(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                My.MySettingsProperty.Settings.DisableSizeChangedEventChecks = true;
            }
            else
            {
                My.MySettingsProperty.Settings.DisableSizeChangedEventChecks = !true;
                Height = Height + 1;
            }
        }
        private void NotifyFunctionEngine_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "NotifyFunctionEngine ticked!");

            if (Conversions.ToDouble(NotifyFunctionCounter.Text) == 1d)
            {
                NotifyIcon1.BalloonTipText = "APMS QuickPowerMode Display";
                NotifyIcon1.BalloonTipTitle = "Current powerplan is " + ActivePlanLabel.Text + "!";
                NotifyIcon1.ShowBalloonTip(1);
                NotifyFunctionCounter.Text = 0.ToString();
            }
            else if (Conversions.ToDouble(NotifyFunctionCounter.Text) > 1d)
            {



                TopMost = true;
                Show();
                System.Threading.Thread.Sleep(5);

                TopMost = false;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User double-clicked the notifyicon from taskbar");
                NotifyFunctionCounter.Text = 0.ToString();

            }

            NotifyFunctionEngine.Stop();

        }

        private void NotifyFunctionCounter_TextChanged(object sender, EventArgs e)
        {
            NotifyFunctionEngine.Start();
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                NotifyFunctionCounter.Text = (Conversions.ToDouble(NotifyFunctionCounter.Text) + 1d).ToString();
            }
            else
            {

            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NotifyFunctionCounter.Text = (Conversions.ToDouble(NotifyFunctionCounter.Text) + 2d).ToString();
            }
            else
            {

            }
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            Interaction.MsgBox("To disable safemode, head to the CoreForm and read the instructions.");

        }

        private void HighPerformanceWarning_Tick(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(declareTargetProcessAsRunningValue, false, false))) // user not in game
            {
                if (ActivePlanLabel.Text.Contains("High"))
                {
                    BallonTipClickActionByte.Text = "1";
                    NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher";
                    NotifyIcon1.BalloonTipText = "It's been 30 minutes since you've activated High Performance mode. Current energy usage is very high. You may have forgot it on, do you want to toggle it off?"; // too long for Win10 Environment
                    NotifyIcon1.ShowBalloonTip(6000);
                    ResetNotificationBuffer.Start();
                }

                else
                {
                    BallonTipClickActionByte.Text = "0";
                } // powermode is NOT high perf
            }
            else
            {
                // user is in game
                BallonTipClickActionByte.Text = "0";
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Interaction.Shell(@"C:\Program Files\iTunes\iTunes.exe", AppWinStyle.Hide);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Interaction.Shell(@"C:\Program Files\iTunes\iTunes.exe", AppWinStyle.MinimizedFocus);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Interaction.Shell(@"C:\Program Files\iTunes\iTunes.exe", AppWinStyle.MinimizedNoFocus);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Interaction.Shell(@"C:\Program Files\iTunes\iTunes.exe", AppWinStyle.NormalFocus);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Interaction.Shell(@"C:\Program Files\iTunes\iTunes.exe", AppWinStyle.NormalNoFocus);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_balanced;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            NotifyIcon1.Icon = My.Resources.Resources.NotifyIcon_HighPerformance;

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox(My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items.Count.ToString());
        }

        private void memorizePowerPlanEngine_Tick(object sender, EventArgs e)
        {
            MemorizedPowerModeLabel.Text = ActivePlanLabel.Text;
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Memorized user's preferred powermode. Value is: " + MemorizedPowerModeLabel.Text);
            memorizePowerPlanEngine.Stop();
        }

        private void AllowPowermodeControl_CheckedChanged(object sender, EventArgs e)
        {
            if (AllowPowermodeControl.Checked == true)
            {
                My.MySettingsProperty.Settings.AllowPowermodeControl = true;
            }
            else
            {
                My.MySettingsProperty.Settings.AllowPowermodeControl = false;
            }
            My.MySettingsProperty.Settings.Save();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            startBenchmarking();
            int i = 0;


            while (i != 7250)
            {

                i = i + 1;
                Label47.Text = i.ToString();
            }
            stopBenchmarking();
            msgboxBenchmarkValue();
        }

        private void RuntimeTimingEngine_Tick(object sender, EventArgs e)
        {


            if (allowBenchmarking == true)
            {

                RuntimeBenchmarkOutput.Text = RuntimeBenchmarkOutput.Text.Replace("Runtime Timer: ", "");
                RuntimeBenchmarkOutput.Text = RuntimeBenchmarkOutput.Text.Replace("ms", "");
                RuntimeBenchmarkOutput.Text = (Conversions.ToDouble(RuntimeBenchmarkOutput.Text) + 1d).ToString();
                int newVal = Conversions.ToInteger(RuntimeBenchmarkOutput.Text);
                RuntimeBenchmarkOutput.Text = "Runtime Timer: " + newVal + "ms";
            }

            else
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "RuntimeBenchmarkEngine is called but flag allowBenchmarking is false! Cannot start benchmarking now.");
            }

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            startBenchmarking();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            stopBenchmarking();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            HighPerformanceWarning.Interval = 15000;
            Interaction.MsgBox("HighPerformanceWarning.Interval = 15000", MsgBoxStyle.Information, "Set!");
        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
            NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher debug";
            NotifyIcon1.BalloonTipText = "debug, it is.";
            NotifyIcon1.ShowBalloonTip(2800);
        }

        private void BallonTipClickActionByte_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notification click action has just been changed. New action byte is: " + BallonTipClickActionByte.Text);
        }

        private void ResetNotificationBuffer_Tick(object sender, EventArgs e)
        {
            BallonTipClickActionByte.Text = "0";
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Resetting notification buffer! Value BallonTipClickActionByte.text is now 0");

            ResetNotificationBuffer.Stop();

        }

        private void Button4_Click_2(object sender, EventArgs e)
        {
            NotifyIcon1.Dispose();

            Label31.Text = (Conversions.ToDouble(Label31.Text) + 1d).ToString();
        }

        private void CheckUserBehavior_Tick(object sender, EventArgs e)
        {
            // My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath & " /onboot")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System is now called.");
            regValueToCheck = "QuickPowerModeSwitcher";
            variable_byte_regexistsaction = 1;
            variable_regvaluedoesnotexist = "NAN";
            variable_regvalueexists = "QuickPowerModeSwitcher is running on startup, too. AutoPowerModeSwitcher is a better replacement for it by CryptedBytes. No need to run them both as they MAY conflict to each other and MAY slow down your system, do you want us to disable it?";
            variable_regvalueexiststitle = "Conflict found!";
            variable_regdeletednotifytext = "We have just disabled QuickPowerModeSwitcher for you.";
            CheckUserBehavior.Stop();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System variables set.");
            checkRegistryKeys();

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            CheckUserBehavior.Interval = 1000;
            CheckUserBehavior.Start();
        }


    }
}