Imports System.IO
Imports IWshRuntimeLibrary
Public Class InstallerModule


    Private Sub Installer_Tick(sender As Object, e As EventArgs) Handles Installer.Tick
        ButtonCancel.Enabled = False
        ButtonInstall.Enabled = False
        CheckBox1.Enabled = False
        InstallDialog.Visible = True
        Try
            Dim ProgramFilesPath As String
            ProgramFilesPath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
            If (Not System.IO.Directory.Exists(ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher")) Then
                System.IO.Directory.CreateDirectory(ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher")
                StatusDetail.Text = "Created workfolders"
                Threading.Thread.Sleep(500)
            Else
                'already installed code here
            End If
            StatusDetail.Text = "Creating executables"
            Dim location As String = System.Environment.GetCommandLineArgs()(0)
            Dim appName As String = System.IO.Path.GetFileName(location)
            Dim sourcepath As String = My.Application.Info.DirectoryPath + "\" + appName

            Dim DestPath As String = ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher"
            'My.Computer.FileSystem.CopyDirectory(sourcepath, DestPath)
            My.Computer.FileSystem.CopyFile(sourcepath, DestPath)
            'FileCopy(sourcepath, DestPath)
            Threading.Thread.Sleep(500)
            Dim renamepath As String = ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher"
            Dim searchPattern As String = "*.exe"
            Dim i As Integer = 0
            For Each fileName As String In Directory.GetFiles(sourcepath, searchPattern, SearchOption.AllDirectories)
                System.IO.File.Move(Path.Combine(sourcepath, fileName), Path.Combine(sourcepath, "AutoPowerModeSwitcher" + ".exe"))
            Next
            If CheckBox1.Checked = True Then
                StatusDetail.Text = "Creating shortcuts"
                Threading.Thread.Sleep(250)
                Dim WshShell As WshShellClass = New WshShellClass
                Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut
                ' The shortcut will be created on the desktop
                Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                MyShortcut = CType(WshShell.CreateShortcut(DesktopFolder & "\AutoPowerModeSwitcher.ink"), IWshRuntimeLibrary.IWshShortcut)
                MyShortcut.TargetPath = ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher" + "AutoPowerModeSwitcher" + ".exe"""
                MyShortcut.Save()

            Else

            End If

            StatusDetail.Visible = False

            Installer.Stop()
            StatusLabel.Text = "Successfully installed!"
            InstallationCompleteDialog.Visible = True



        Catch ex As Exception
            StatusLabel.Text = "An error occured!"
            StatusDetail.Text = ex.ToString
            InstallDialog.Visible = False
            StatusDetail.Visible = False

            ErrorDialog.Show()

        End Try
        
       
    End Sub



    Private Sub ButtonInstall_Click(sender As Object, e As EventArgs) Handles ButtonInstall.Click
        StatusLabel.Visible = True
        'Installer.Start()





        ButtonCancel.Enabled = False
        ButtonInstall.Enabled = False
        CheckBox1.Enabled = False
        InstallDialog.Visible = True
        Try
            Dim ProgramFilesPath As String
            ProgramFilesPath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
            If (Not System.IO.Directory.Exists(ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher")) Then
                System.IO.Directory.CreateDirectory(ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher")
                StatusDetail.Text = "Created workfolders"
                Threading.Thread.Sleep(500)
            Else
                'already installed code here
            End If
            StatusDetail.Text = "Creating executables"
            Dim location As String = System.Environment.GetCommandLineArgs()(0)
            Dim appName As String = System.IO.Path.GetFileName(location)
            Dim sourcepath As String = My.Application.Info.DirectoryPath + "\" + appName

            Dim DestPath As String = ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher"
            'My.Computer.FileSystem.CopyDirectory(sourcepath, DestPath)
            Try
                My.Computer.FileSystem.CopyFile(sourcepath, DestPath, True
                                                )
            Catch ex As Exception

            End Try

            'FileCopy(sourcepath, DestPath)
            Threading.Thread.Sleep(500)
            'Dim renamepath As String = ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher"
            'Dim searchPattern As String = "*.exe"
            'Dim i As Integer = 0
            '   For Each fileName As String In Directory.GetFiles(sourcepath, searchPattern, SearchOption.AllDirectories)
            'System.IO.File.Move(Path.Combine(sourcepath, fileName), Path.Combine(sourcepath, "AutoPowerModeSwitcher" + ".exe"))
            'Next
            If CheckBox1.Checked = True Then
                StatusDetail.Text = "Creating shortcuts"
                Threading.Thread.Sleep(250)
                Dim WshShell As WshShellClass = New WshShellClass
                Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut
                ' The shortcut will be created on the desktop
                Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                MyShortcut = CType(WshShell.CreateShortcut(DesktopFolder & "\AutoPowerModeSwitcher.ink"), IWshRuntimeLibrary.IWshShortcut)
                MyShortcut.TargetPath = ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher" + "AutoPowerModeSwitcher" + ".exe"""
                MyShortcut.Save()

            Else

            End If

            StatusDetail.Visible = False

            Installer.Stop()
            StatusLabel.Text = "Successfully installed!"
            InstallationCompleteDialog.Visible = True



        Catch ex As Exception
            StatusLabel.Text = "An error occured!"
            StatusDetail.Text = ex.ToString
            InstallDialog.Visible = False
            StatusDetail.Visible = False

            ErrorDialog.Show()

        End Try


    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        Environment.Exit(0)
    End Sub

    Private Sub StatusDetail_TextChanged(sender As Object, e As EventArgs) Handles StatusDetail.TextChanged
        StatusDetail.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserInterface.Show()
        Me.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Environment.Exit(0)

    End Sub

    Private Sub InstallerModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        ErrorDialog.Location = New Point(1, 2)
        InstallationCompleteDialog.Location = New Point(1, 2)
        InstallDialog.Location = New Point(1, 2)
        UserInterface.Close()
        BootManager.Dispose()
        SettingsDatabase.Dispose()
        UserPreferencesModule.Close()
        Dim ProgramFilesPath As String
        ProgramFilesPath = My.Computer.FileSystem.SpecialDirectories.ProgramFiles
        Label12.Text = Label12.Text + ProgramFilesPath + "\CryptedBytes\AutoPowerModeSwitcher"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(StatusDetail.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Clipboard.SetText(StatusDetail.Text)
        Button4.Enabled = False

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        UserInterface.Show()
        Me.Close()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel1.Visible = False

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Environment.Exit(0)

    End Sub
End Class