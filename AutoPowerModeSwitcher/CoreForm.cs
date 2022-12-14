using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{

    public partial class CoreForm
    {
        public CoreForm()
        {
            InitializeComponent();
        }
        public static bool IsRunningAsAdmin()
        {
            var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CoreForm checked for Admin rights.");
        }
        public static bool prefetchingUserPreferences = true;
        private void startApplication()
        {

            My.MyProject.Forms.UserPreferencesModule.Show();
            System.Threading.Thread.Sleep(500);
            My.MyProject.Forms.UserInterface.Show();
            My.MyProject.Forms.UserPreferencesModule.Hide();
            prefetchingUserPreferences = false;
        }
        public static void errorLoggingSystem()
        {
            try
            {

                var w = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated\criticalerrors.log", Conversions.ToBoolean(FileMode.Append));

                w.WriteLine(errorLoggingText);

                w.Close();
                errorLoggingText = "";
            }
            catch (Exception ex)
            {

            }

        }
        private void enableLogging()
        {
            try
            {

                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated") == false)
                {
                    My.MyProject.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated");
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory: DriverGenerated Database.");
                }
                else
                {

                }

                var Str = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated\AutoPowerModeSwitcher.log", FileMode.Append);
                var DebugFile = new StreamWriter(Str);
                var Listener = new TextWriterTraceListener(DebugFile);

                Debug.Listeners.Add(Listener);
                Debug.AutoFlush = true;
                Debug.WriteLine("#####################################################################");
                Debug.WriteLine("AutoPowerModeSwitcher logging started: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                Debug.WriteLine("#####################################################################");
            }


            catch (Exception ex)
            {

                Environment.Exit(0);
            }
        }


        public static string errorLoggingText = "Nan";



        private void CoreForm_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created thread.");
            ErrorLoggingLabel.Text = "";
            My.MySettingsProperty.Settings.DisableSizeChangedEventChecks = false;
            Height = 167;
            Width = 449;
            if (My.MySettingsProperty.Settings.RedirectConsoleToFile == true)
            {
                if (My.MySettingsProperty.Settings.FlushConsoleAtStartup == true)
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated\AutoPowerModeSwitcher.log");
                }
                else
                {

                }
                System.Threading.Thread.Sleep(100);
                enableLogging();
            }
            else
            {

            }

            if (My.MySettingsProperty.Settings.SafemodeEnabled == true) // //EXTRAORDINARY CONDITIONS AS SAFEMODE IS ENABLED
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Safemode is enabled!");
                StatusLabel.Text = "Safemode is active.";
                Cloak.Stop();


                timesTick.Visible = true;
                SafemodeActivePanel.Location = new Point(31, 1);
                My.MySettingsProperty.Settings.Reset();
                My.MySettingsProperty.Settings.SafemodeEnabled = true;
                My.MySettingsProperty.Settings.Save();
                My.MyProject.Forms.UserInterface.Show();
                My.MyProject.Forms.DebugUI.Show();
                My.MyProject.Forms.UserPreferencesModule.Show();
            }




            else if (My.MySettingsProperty.Settings.DisableCoreForm == true) // // NORMAL CONDITIONS IF SAFEMODE IS NOT ENABLED
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Experimental flag Disable CoreForm has been enabled! Skipping all checks of CoreForm and starting Form1.");
                My.MyProject.Forms.UserInterface.Show();
                Hide();
            }
            else
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "AutoPowerModeSwitcher has arrived.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intializing CoreForm");


                try
                {
                    var CurrentProcess = Process.GetCurrentProcess();
                    CurrentProcess.PriorityClass = ProcessPriorityClass.Idle;
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Application priority is set to IDLE.");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Unable to set priority");
                    errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Unable to set self priority to IDLE.";
                    errorLoggingSystem();
                }

                Engine.Start();

                if (Environment.GetCommandLineArgs().Count() != 1)
                {

                    try
                    {
                        if (Environment.GetCommandLineArgs()[1] == "/onboot")
                        {
                            if (My.MySettingsProperty.Settings.BootManagerEnabled == true)
                            {
                                StatusLabel.Text = "Loading BootManager";
                            }
                            else
                            {
                                StatusLabel.Text = "AutoPowerModeSwitcher";
                            }
                        }
                        else if (Environment.GetCommandLineArgs()[1] == "/install")
                        {
                            StatusLabel.Text = "Preparing for installation.";
                        }
                        else if (Environment.GetCommandLineArgs()[1] == "/ShowSettings")
                        {
                            StatusLabel.Text = "Loading Settings Panel.";
                        }
                        else if (Environment.GetCommandLineArgs()[1] == "/EnableAutoPilot")
                        {
                            StatusLabel.Text = "Enabling AutoPilot. Please wait.";
                        }
                        else if (Environment.GetCommandLineArgs()[1] == "/Uninstall")
                        {
                            StatusLabel.Text = "Preparing for uninstallation.";
                        }
                        else if (Environment.GetCommandLineArgs()[1] == "/asInvoker")
                        {
                            StatusLabel.Text = "Starting application in Invoker mode.";
                        }
                        else if (Environment.GetCommandLineArgs()[1] == "/SilentEnableAutoPilot")
                        {
                            StatusLabel.Text = "Processing your request...";
                        }
                        else if (Environment.GetCommandLineArgs()[1] == "/DisableAutoPilot")
                        {
                            StatusLabel.Text = "Disabling AutoPilot...";
                        }
                        else
                        {
                            StatusLabel.Text = "Unknown Argument. Cannot start!";
                            errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: CoreForm was unable to start application. Reason: Unknown argument is called. Shortcut is corrupted.";
                            errorLoggingSystem();

                            string strings_argerror_argnotfiltered = Environment.GetCommandLineArgs()[1].ToString();

                            string strings_argerror_argfiltered = strings_argerror_argnotfiltered.Replace("/", "");

                            Interaction.MsgBox("AutoPowerModeSwitcher has just been called with an unregistred argument. APMS cannot determine what actions to trigger with this argument, therefore it won't be able to start unless you reset the arguments or pass another argument. Keep in mind that, APMS no longer supports multi-argument inputs, only the first argument will be processed, therefore make sure you follow CryptedBytes Development Guidelines when passing arguments." + Environment.NewLine + "Argument that has caused this problem to occur: '" + strings_argerror_argfiltered + "'", MsgBoxStyle.Critical, "Argument '" + Environment.GetCommandLineArgs()[1].ToString() + "' cannot be determined!");
                        }
                    }



                    catch (Exception ex)
                    {
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: Cannot get command line arguments. Application may not be able to start.");
                        errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: CoreForm was unable to start application. Reason: Unable to get startup arguments. Your operating system is probably unsupported. Application will try to start but probably will not be able to.";
                        errorLoggingSystem();
                    }



                }
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core form is intialized");


            }




        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (My.MySettingsProperty.Settings.SafemodeEnabled == true)
            {
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SAFEMODE IS ACTIVE!!!! DO NOT RUN COREFORM ENGINE!!");
            }
            else
            {

                timesTick.Text = (Conversions.ToDouble(timesTick.Text) + 1d).ToString();
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CoreForm's engine is ticked");
                My.MySettingsProperty.Settings.AllowQuit = false;
                My.MySettingsProperty.Settings.Save();
                if (Conversions.ToDouble(timesTick.Text) < 2d)
                {
                    try
                    {


                        if (Environment.GetCommandLineArgs().Count() != 1)
                        {
                            try
                            {
                                if (Environment.GetCommandLineArgs()[1] == "/onboot")
                                {
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /onboot. Probably called by Windows on startup.");
                                    StartedonBoot.Text = "True";
                                    if (My.MySettingsProperty.Settings.BootManagerEnabled == true)
                                    {
                                        My.MyProject.Forms.BootManager.Show();
                                        // BootManagerUXPort.Show()

                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core form is starting BootManager.");
                                    }
                                    else
                                    {
                                        // Form1.Show()
                                        startApplication();
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core form is starting Form1");
                                    }
                                }



                                else if (Environment.GetCommandLineArgs()[1] == "/install")
                                {
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /install. User requested an installation.");
                                    if (!IsRunningAsAdmin())
                                    {
                                        // Launch itself as administrator
                                        var proc = new ProcessStartInfo();
                                        proc.UseShellExecute = true;
                                        proc.WorkingDirectory = Environment.CurrentDirectory;
                                        proc.FileName = Application.ExecutablePath;
                                        proc.Verb = "runas";
                                        proc.Arguments = "/install";
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restarting application with admin rights.");
                                        try
                                        {
                                            Process.Start(proc);
                                        }
                                        catch
                                        {
                                            Interaction.MsgBox("Cannot install without elevation"); // The user refused the elevation.
                                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User denied the elevation. (UAC)");
                                            errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "INSTALLER: Failed to elevate. Either user denied the elevation or user is not an admin.";
                                            errorLoggingSystem();
                                            return;

                                        }

                                        Environment.Exit(0); // Quit itself
                                    }

                                    else
                                    {

                                        // The process is already running as administrator

                                        My.MyProject.Forms.InstallerModule.Show();
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Admin rights are already given. Installer module has been started. (Unsupported)");
                                    }
                                }
                                else if (Environment.GetCommandLineArgs()[1] == "/ShowSettings")
                                {
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /ShowSettings. Showing settings with TabIndex(2) selected.");
                                    My.MyProject.Forms.UserInterface.Show();
                                    My.MyProject.Forms.UserPreferencesModule.Show();
                                    My.MyProject.Forms.UserInterface.Hide();
                                    My.MyProject.Forms.UserPreferencesModule.TabControl1.SelectTab(2);
                                    My.MyProject.Forms.UserPreferencesModule.Opacity = 100d;
                                }
                                else if (Environment.GetCommandLineArgs()[1] == "/DisableAutoPilot")
                                {
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /DisableAutoPilot.");
                                    string ask;
                                    ask = ((int)Interaction.MsgBox("Are you sure want to disable AutoPilot?", Constants.vbYesNo, "Disabling AutoPilot")).ToString();
                                    if (Conversions.ToDouble(ask) == (double)Constants.vbYes)
                                    {
                                        My.MySettingsProperty.Settings.AutoPilotEnabled = !true;
                                        My.MyProject.Forms.UserPreferencesModule.Userdetect.Checked = !true;
                                        My.MySettingsProperty.Settings.Save();
                                        Dispose();
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Disabled Autopilot by commandline argument.");
                                    }
                                    else
                                    {
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Hooray! User cancelled the request. AutoPilot is not disabled.");
                                        Dispose();
                                    }
                                }






                                else if (Environment.GetCommandLineArgs()[1] == "/EnableAutoPilot")
                                {
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /EnableAutoPilot.");
                                    My.MyProject.Forms.UserInterface.Show();
                                    My.MyProject.Forms.UserPreferencesModule.Show();
                                    // UserInterface.Hide()
                                    My.MyProject.Forms.UserPreferencesModule.TabControl1.SelectTab(1);
                                    My.MyProject.Forms.UserPreferencesModule.Userdetect.Checked = true;
                                    My.MyProject.Forms.UserInterface.NotifyIcon1.Visible = false;
                                    My.MyProject.Forms.UserPreferencesModule.Hide();
                                    My.MySettingsProperty.Settings.Save();
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Successfully enabled!");
                                    Dispose();
                                }
                                else if (Environment.GetCommandLineArgs()[1] == "/SilentEnableAutoPilot")
                                {
                                    My.MySettingsProperty.Settings.AutoPilotEnabled = true;
                                    My.MyProject.Forms.UserPreferencesModule.Userdetect.Checked = true;
                                    My.MyProject.Forms.UserInterface.NotifyIcon1.Visible = false;
                                    My.MySettingsProperty.Settings.Save();
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /SilentEnableAutoPilot. Enabling AutoPilot and the UI is hidden.");
                                    Dispose();
                                }
                                else if (Environment.GetCommandLineArgs()[1] == "/Uninstall")
                                {
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /Uninstall.");
                                    if (!IsRunningAsAdmin())
                                    {
                                        // Launch itself as administrator
                                        var proc = new ProcessStartInfo();
                                        proc.UseShellExecute = true;
                                        proc.WorkingDirectory = Environment.CurrentDirectory;
                                        proc.FileName = Application.ExecutablePath;
                                        proc.Verb = "runas";
                                        proc.Arguments = "/Uninstall";
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restarting application with admin rights.");
                                        try
                                        {
                                            Process.Start(proc);
                                        }
                                        catch
                                        {
                                            Interaction.MsgBox("Cannot uninstall without elevation"); // The user refused the elevation.
                                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User denied the elevation. (UAC)");
                                            return;

                                        }

                                        Environment.Exit(0); // Quit itself
                                    }
                                    else
                                    {

                                        // The process is already running as administrator

                                        My.MyProject.Forms.UserInterface.Show();
                                        My.MyProject.Forms.UserPreferencesModule.Show();
                                        My.MyProject.Forms.UserInterface.Close();
                                        My.MyProject.Forms.UserPreferencesModule.TabControl1.SelectTab(4);
                                        My.MyProject.Forms.UserPreferencesModule.UninstallPanel.Visible = true;
                                        My.MyProject.Forms.UserPreferencesModule.UninstallPanel.Location = new Point(6, 2);
                                        My.MyProject.Forms.UserPreferencesModule.Text = "Uninstall AutoPowerModeSwitcher";
                                        My.MyProject.Forms.UserPreferencesModule.UninstallCancelButton.Visible = false;
                                        My.MyProject.Forms.UserPreferencesModule.Button3.PerformClick();
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Uninstall panel is shown. Uninstalling conditions are enabled.");

                                    }
                                }

                                else if (Environment.GetCommandLineArgs()[1] == "/asInvoker")
                                {
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /asInvoker. Granting admin rights.");
                                    if (!IsRunningAsAdmin())
                                    {
                                        // Launch itself as administrator
                                        var proc = new ProcessStartInfo();
                                        proc.UseShellExecute = true;
                                        proc.WorkingDirectory = Environment.CurrentDirectory;
                                        proc.FileName = Application.ExecutablePath;
                                        proc.Verb = "runas";
                                        proc.Arguments = "/asInvoker";
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Uninstall panel is shown. Uninstalling controls are enabled.");
                                        try
                                        {
                                            Process.Start(proc);
                                        }
                                        catch
                                        {
                                            Interaction.MsgBox("asInvoker parameter requires admin permissions to run application invoked."); // The user refused the elevation.
                                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User denied the elevation. (UAC)");
                                            return;

                                        }

                                        Environment.Exit(0); // Quit itself
                                    }
                                    else
                                    {

                                        // The process is already running as administrator

                                        My.MyProject.Forms.UserInterface.Show();
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Successfully granted admin rights.");

                                    }
                                }
                            }








                            catch (Exception ex)
                            {
                                Interaction.MsgBox("An exception occured: " + ex.ToString());
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured: " + ex.ToString());
                                errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CoreForm malfunctioned. Critical error occured. Error details: " + ex.ToString();
                                errorLoggingSystem();
                            }
                        }


                        else
                        {
                            StartedonBoot.Text = "False";
                            // no args called
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Application started without any arguments.");
                            startApplication();
                            // Form1.Show()
                        }
                    }



                    catch (Exception ex)
                    {
                        Interaction.MsgBox("An exception occured: " + ex.ToString());
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured: " + ex.ToString());

                        errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CoreForm malfunctioned. Critical error occured. Application will not start. Error details: " + ex.ToString();
                        errorLoggingSystem();
                    }
                }




                else
                {
                    // Hide()
                    EngineStopper.Start();




                }

            }

        }

        private void EngineStopper_Tick(object sender, EventArgs e)
        {
            Engine.Stop();

            EngineStopper.Stop();

        }

        private void CoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {


            // Application.Exit()


        }


        private void Cloak_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                Hide();
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Coreform has finished loading AutoPowerModeSwitcher.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "COREFORM: CloakForm detected an open form. CoreForm is now hidden.");
                Cloak.Stop();
            }

            else
            {

            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminating process");
            Engine.Stop();
            Environment.Exit(0);
            // Environment.FailFast(0)
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User is clicking the PictureBox. Why panicked?");
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked CoreForm's label. Why panicked?");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "[CRITICAL EVENT] User enabled SafeMode!!!");

            string path = Path.Combine(@"C:\Users\cryptedbytes\AppData\Local\CryptedBytes_Software");

            string filter = "AutoPowerModeSwitcher";
            var files = from fl in Directory.GetFiles(path)
                        where fl.Contains(filter)
                        select fl;

            foreach (var fl in files)
                File.Delete(fl);

            My.MySettingsProperty.Settings.SafemodeEnabled = true;
            Application.Restart();

        }

        private void SafemodeDialog_Tick(object sender, EventArgs e)
        {
            SafemodePromptPanel.Visible = true;
            SafemodeDialog.Stop();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MySettingsProperty.Settings.SafemodeEnabled = false;
            My.MySettingsProperty.Settings.Save();
            My.MyProject.Forms.UserInterface.Dispose();
            My.MyProject.Forms.UserPreferencesModule.Dispose();
            My.MyProject.Forms.DebugUI.Dispose();
            Application.Restart();
        }
    }
}