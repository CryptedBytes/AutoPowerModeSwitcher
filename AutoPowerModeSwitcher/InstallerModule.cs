using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using Microsoft.VisualBasic;

namespace AutoPowerModeSwitcher
{
    public partial class InstallerModule
    {
        public InstallerModule()
        {
            InitializeComponent();
        }


        private void Installer_Tick(object sender, EventArgs e)
        {
            ButtonCancel.Enabled = false;
            ButtonInstall.Enabled = false;
            CheckBox1.Enabled = false;
            InstallDialog.Visible = true;
            try
            {
                string ProgramFilesPath;
                ProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (!Directory.Exists(ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher"))
                {
                    Directory.CreateDirectory(ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher");
                    StatusDetail.Text = "Created workfolders";
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    // already installed code here
                }
                StatusDetail.Text = "Creating executables";
                string location = Environment.GetCommandLineArgs()[0];
                string appName = Path.GetFileName(location);
                string sourcepath = My.MyProject.Application.Info.DirectoryPath + @"\" + appName;

                string DestPath = ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher";
                // My.Computer.FileSystem.CopyDirectory(sourcepath, DestPath)
                My.MyProject.Computer.FileSystem.CopyFile(sourcepath, DestPath);
                // FileCopy(sourcepath, DestPath)
                System.Threading.Thread.Sleep(500);
                string renamepath = ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher";
                string searchPattern = "*.exe";
                int i = 0;
                foreach (string fileName in Directory.GetFiles(sourcepath, searchPattern, SearchOption.AllDirectories))
                    System.IO.File.Move(Path.Combine(sourcepath, fileName), Path.Combine(sourcepath, "AutoPowerModeSwitcher" + ".exe"));
                if (CheckBox1.Checked == true)
                {
                    StatusDetail.Text = "Creating shortcuts";
                    System.Threading.Thread.Sleep(250);
                    var WshShell = new WshShellClass();
                    IWshShortcut MyShortcut;
                    // The shortcut will be created on the desktop
                    string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    MyShortcut = (IWshShortcut)WshShell.CreateShortcut(DesktopFolder + @"\AutoPowerModeSwitcher.ink");
                    MyShortcut.TargetPath = ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher" + "AutoPowerModeSwitcher" + ".exe\"";
                    MyShortcut.Save();
                }

                else
                {

                }

                StatusDetail.Visible = false;

                Installer.Stop();
                StatusLabel.Text = "Successfully installed!";
                InstallationCompleteDialog.Visible = true;
            }



            catch (Exception ex)
            {
                StatusLabel.Text = "An error occured!";
                StatusDetail.Text = ex.ToString();
                InstallDialog.Visible = false;
                StatusDetail.Visible = false;

                ErrorDialog.Show();

            }


        }



        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            StatusLabel.Visible = true;
            // Installer.Start()





            ButtonCancel.Enabled = false;
            ButtonInstall.Enabled = false;
            CheckBox1.Enabled = false;
            InstallDialog.Visible = true;
            try
            {
                string ProgramFilesPath;
                ProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (!Directory.Exists(ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher"))
                {
                    Directory.CreateDirectory(ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher");
                    StatusDetail.Text = "Created workfolders";
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    // already installed code here
                }
                StatusDetail.Text = "Creating executables";
                string location = Environment.GetCommandLineArgs()[0];
                string appName = Path.GetFileName(location);
                string sourcepath = My.MyProject.Application.Info.DirectoryPath + @"\" + appName;

                string DestPath = ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher";
                // My.Computer.FileSystem.CopyDirectory(sourcepath, DestPath)
                try
                {
                    My.MyProject.Computer.FileSystem.CopyFile(sourcepath, DestPath, true);
                }
                catch (Exception ex)
                {

                }

                // FileCopy(sourcepath, DestPath)
                System.Threading.Thread.Sleep(500);
                // Dim renamepath As String = ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher"
                // Dim searchPattern As String = "*.exe"
                // Dim i As Integer = 0
                // For Each fileName As String In Directory.GetFiles(sourcepath, searchPattern, SearchOption.AllDirectories)
                // System.IO.File.Move(Path.Combine(sourcepath, fileName), Path.Combine(sourcepath, "AutoPowerModeSwitcher" + ".exe"))
                // Next
                if (CheckBox1.Checked == true)
                {
                    StatusDetail.Text = "Creating shortcuts";
                    System.Threading.Thread.Sleep(250);
                    var WshShell = new WshShellClass();
                    IWshShortcut MyShortcut;
                    // The shortcut will be created on the desktop
                    string DesktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    MyShortcut = (IWshShortcut)WshShell.CreateShortcut(DesktopFolder + @"\AutoPowerModeSwitcher.ink");
                    MyShortcut.TargetPath = ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher" + "AutoPowerModeSwitcher" + ".exe\"";
                    MyShortcut.Save();
                }

                else
                {

                }

                StatusDetail.Visible = false;

                Installer.Stop();
                StatusLabel.Text = "Successfully installed!";
                InstallationCompleteDialog.Visible = true;
            }



            catch (Exception ex)
            {
                StatusLabel.Text = "An error occured!";
                StatusDetail.Text = ex.ToString();
                InstallDialog.Visible = false;
                StatusDetail.Visible = false;

                ErrorDialog.Show();

            }


        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void StatusDetail_TextChanged(object sender, EventArgs e)
        {
            StatusDetail.Visible = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.UserInterface.Show();
            Dispose();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void InstallerModule_Load(object sender, EventArgs e)
        {

            ErrorDialog.Location = new Point(1, 2);
            InstallationCompleteDialog.Location = new Point(1, 2);
            InstallDialog.Location = new Point(1, 2);
            My.MyProject.Forms.UserInterface.Close();
            My.MyProject.Forms.BootManager.Dispose();
            My.MyProject.Forms.SettingsDatabase.Dispose();
            My.MyProject.Forms.UserPreferencesModule.Close();
            string ProgramFilesPath;
            ProgramFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            Label12.Text = Label12.Text + ProgramFilesPath + @"\CryptedBytes\AutoPowerModeSwitcher";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox(StatusDetail.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            My.MyProject.Computer.Clipboard.SetText(StatusDetail.Text);
            Button4.Enabled = false;

        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            My.MyProject.Forms.UserInterface.Show();
            Close();

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Panel1.Visible = false;

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(0);

        }
    }
}