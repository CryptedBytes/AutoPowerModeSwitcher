Imports System.IO
Imports System.Security.Principal

Public Class CoreForm
    Public Shared Function IsRunningAsAdmin() As Boolean
        Dim principal As New WindowsPrincipal(WindowsIdentity.GetCurrent)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CoreForm checked for Admin rights.")
    End Function
    Public shared prefetchingUserPreferences As boolean = true
    Private sub startApplication
        
        UserPreferencesModule.show
        Threading.Thread.Sleep(500)
        UserInterface.show
        UserPreferencesModule.hide()
      prefetchingUserPreferences = false
    End sub
    Public shared sub errorLoggingSystem
        Try

           dim  w = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated\criticalerrors.log", FileMode.Append)
   
            w.WriteLine(errorLoggingText)
   
        w.Close()
              errorLoggingText = ""
        Catch ex As Exception
        
        End Try
      
    End sub
    Private sub enableLogging
          try
                
            If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & ("\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated")) = False
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated")
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory: DriverGenerated Database.")
        Else

        End If

                  Dim Str As New FileStream(My.Computer.FileSystem.SpecialDirectories.MyDocuments & ("\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated\AutoPowerModeSwitcher.log"), FileMode.Append)
        Dim DebugFile As New StreamWriter(Str)
        Dim Listener = New TextWriterTraceListener(DebugFile)
        
        Debug.Listeners.Add(Listener)
        Debug.AutoFlush = True
        Debug.WriteLine("#####################################################################")
        Debug.WriteLine("AutoPowerModeSwitcher logging started: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"))
        Debug.WriteLine("#####################################################################")


            Catch ex As Exception

                end
            End Try
    End sub


    Public shared errorLoggingText As String = "Nan"
   
    

    Private Sub CoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created thread.")
        ErrorLoggingLabel.Text = ""
      My.Settings.DisableSizeChangedEventChecks = False
        Height = 167
            Width = 449
        If My.Settings.RedirectConsoleToFile = True then
            If My.Settings.FlushConsoleAtStartup = True Then
                   My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.MyDocuments & ("\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated\AutoPowerModeSwitcher.log"))
            Else

            End If
         threading.Thread.sleep(100)
            Call enableLogging
        Else

        End If

        If My.Settings.SafemodeEnabled = True '//EXTRAORDINARY CONDITIONS AS SAFEMODE IS ENABLED
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Safemode is enabled!")
            StatusLabel.Text = "Safemode is active."
            Cloak.stop
           

            timesTick.Visible = true
           SafemodeActivePanel.Location = New Point(31, 1)
            My.Settings.Reset
            My.Settings.SafemodeEnabled = True
            My.Settings.Save
            UserInterface.Show()
            DebugUI.Show()
            UserPreferencesModule.Show()




        Else '// NORMAL CONDITIONS IF SAFEMODE IS NOT ENABLED
 If My.Settings.DisableCoreForm = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Experimental flag Disable CoreForm has been enabled! Skipping all checks of CoreForm and starting Form1.")
            UserInterface.Show()
            Hide()
        Else
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "AutoPowerModeSwitcher has arrived.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intializing CoreForm")


                Try
                Dim CurrentProcess As Process = Process.GetCurrentProcess
                CurrentProcess.PriorityClass = ProcessPriorityClass.Idle
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Application priority is set to IDLE.")
            Catch ex As Exception
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Unable to set priority")
                     CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Unable to set self priority to IDLE."
        Call CoreForm.errorLoggingSystem
            End Try

            Engine.Start()

                If Environment.GetCommandLineArgs.Count <> 1 Then

                    Try
                        If Environment.GetCommandLineArgs(1) = "/onboot" Then
                            If My.Settings.BootManagerEnabled = True Then
                                StatusLabel.Text = "Loading BootManager"
                            Else
                                StatusLabel.Text = "AutoPowerModeSwitcher"
                            End If
                        ElseIf Environment.GetCommandLineArgs(1) = "/install" Then
                            StatusLabel.Text = "Preparing for installation."
                        ElseIf Environment.GetCommandLineArgs(1) = "/ShowSettings" Then
                            StatusLabel.Text = "Loading Settings Panel."
                        ElseIf Environment.GetCommandLineArgs(1) = "/EnableAutoPilot" Then
                            StatusLabel.Text = "Enabling AutoPilot. Please wait."
                        ElseIf Environment.GetCommandLineArgs(1) = "/Uninstall" Then
                            StatusLabel.Text = "Preparing for uninstallation."
                        ElseIf Environment.GetCommandLineArgs(1) = "/asInvoker" Then
                            StatusLabel.Text = "Starting application in Invoker mode."
                        ElseIf Environment.GetCommandLineArgs(1) = "/SilentEnableAutoPilot" Then
                            StatusLabel.Text = "Processing your request..."
                        ElseIf Environment.GetCommandLineArgs(1) = "/DisableAutoPilot" Then
                            StatusLabel.Text = "Disabling AutoPilot..."
                        Else
                            StatusLabel.Text = "Unknown Argument. Cannot start!"
                            CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: CoreForm was unable to start application. Reason: Unknown argument is called. Shortcut is corrupted."
                            Call CoreForm.errorLoggingSystem()

                            Dim strings_argerror_argnotfiltered As String = Environment.GetCommandLineArgs(1).ToString

                            Dim strings_argerror_argfiltered = strings_argerror_argnotfiltered.Replace("/", "")

                            MsgBox("AutoPowerModeSwitcher has just been called with an unregistred argument. APMS cannot determine what actions to trigger with this argument, therefore it won't be able to start unless you reset the arguments or pass another argument. Keep in mind that, APMS no longer supports multi-argument inputs, only the first argument will be processed, therefore make sure you follow CryptedBytes Development Guidelines when passing arguments." & Environment.NewLine & "Argument that has caused this problem to occur: '" & strings_argerror_argfiltered & "'", MsgBoxStyle.Critical, "Argument '" & Environment.GetCommandLineArgs(1).ToString & "' cannot be determined!")
                        End If



                    Catch ex As Exception
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: Cannot get command line arguments. Application may not be able to start.")
                        CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: CoreForm was unable to start application. Reason: Unable to get startup arguments. Your operating system is probably unsupported. Application will try to start but probably will not be able to."
                        Call CoreForm.errorLoggingSystem()
                    End Try



                End If
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core form is intialized")


                End If
            End If




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Engine.Tick
        If My.Settings.SafemodeEnabled = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SAFEMODE IS ACTIVE!!!! DO NOT RUN COREFORM ENGINE!!")
        Else

            timesTick.Text = timesTick.Text + 1
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CoreForm's engine is ticked")
            My.Settings.AllowQuit = False
            My.Settings.save
            If timesTick.Text < 2 Then
                Try


                    If Environment.GetCommandLineArgs.Count <> 1 Then
                        Try
                            If Environment.GetCommandLineArgs(1) = "/onboot" Then
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /onboot. Probably called by Windows on startup.")
                                StartedonBoot.Text = "True"
                                If My.Settings.BootManagerEnabled = True Then
                                    BootManager.Show()
                                    'BootManagerUXPort.Show()

                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core form is starting BootManager.")
                                Else
                                    ' Form1.Show()
                                    Call startApplication()
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core form is starting Form1")
                                End If



                            ElseIf Environment.GetCommandLineArgs(1) = "/install" Then
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /install. User requested an installation.")
                                If (Not IsRunningAsAdmin()) Then
                                    ' Launch itself as administrator
                                    Dim proc As New ProcessStartInfo
                                    proc.UseShellExecute = True
                                    proc.WorkingDirectory = Environment.CurrentDirectory
                                    proc.FileName = Application.ExecutablePath
                                    proc.Verb = "runas"
                                    proc.Arguments = "/install"
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restarting application with admin rights.")
                                    Try
                                        Process.Start(proc)
                                    Catch
                                        MsgBox("Cannot install without elevation") ' The user refused the elevation.
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User denied the elevation. (UAC)")
                                        CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "INSTALLER: Failed to elevate. Either user denied the elevation or user is not an admin."
                                        Call CoreForm.errorLoggingSystem()
                                        Return

                                    End Try

                                    Environment.Exit(0) ' Quit itself

                                Else

                                    'The process is already running as administrator

                                    InstallerModule.Show()
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Admin rights are already given. Installer module has been started. (Unsupported)")
                                End If
                            ElseIf Environment.GetCommandLineArgs(1) = "/ShowSettings" Then
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /ShowSettings. Showing settings with TabIndex(2) selected.")
                                UserInterface.Show()
                                UserPreferencesModule.Show()
                                UserInterface.Hide()
                                UserPreferencesModule.TabControl1.SelectTab(2)
                                UserPreferencesModule.Opacity = 100
                            ElseIf Environment.GetCommandLineArgs(1) = "/DisableAutoPilot" Then
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /DisableAutoPilot.")
                                Dim ask As String
                                ask = MsgBox("Are you sure want to disable AutoPilot?", vbYesNo, "Disabling AutoPilot")
                                If ask = vbYes Then
                                    My.Settings.AutoPilotEnabled = Not True
                                    UserPreferencesModule.Userdetect.Checked = Not True
                                    My.Settings.Save()
                                    Dispose()
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Disabled Autopilot by commandline argument.")
                                Else
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Hooray! User cancelled the request. AutoPilot is not disabled.")
                                    Dispose()
                                End If






                            ElseIf Environment.GetCommandLineArgs(1) = "/EnableAutoPilot" Then
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /EnableAutoPilot.")
                                UserInterface.Show()
                                UserPreferencesModule.Show()
                                'UserInterface.Hide()
                                UserPreferencesModule.TabControl1.SelectTab(1)
                                UserPreferencesModule.Userdetect.Checked = True
                                UserInterface.NotifyIcon1.Visible = False
                                UserPreferencesModule.Hide()
                                My.Settings.Save()
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Successfully enabled!")
                                Dispose()
                            ElseIf Environment.GetCommandLineArgs(1) = "/SilentEnableAutoPilot" Then
                                My.Settings.AutoPilotEnabled = True
                                UserPreferencesModule.Userdetect.Checked = True
                                UserInterface.NotifyIcon1.Visible = False
                                My.Settings.Save()
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /SilentEnableAutoPilot. Enabling AutoPilot and the UI is hidden.")
                                Dispose()
                            ElseIf Environment.GetCommandLineArgs(1) = "/Uninstall" Then
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /Uninstall.")
                                If (Not IsRunningAsAdmin()) Then
                                    ' Launch itself as administrator
                                    Dim proc As New ProcessStartInfo
                                    proc.UseShellExecute = True
                                    proc.WorkingDirectory = Environment.CurrentDirectory
                                    proc.FileName = Application.ExecutablePath
                                    proc.Verb = "runas"
                                    proc.Arguments = "/Uninstall"
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restarting application with admin rights.")
                                    Try
                                        Process.Start(proc)
                                    Catch
                                        MsgBox("Cannot uninstall without elevation") ' The user refused the elevation.
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User denied the elevation. (UAC)")
                                        Return

                                    End Try

                                    Environment.Exit(0) ' Quit itself
                                Else

                                    'The process is already running as administrator

                                    UserInterface.Show()
                                    UserPreferencesModule.Show()
                                    UserInterface.Close()
                                    UserPreferencesModule.TabControl1.SelectTab(4)
                                    UserPreferencesModule.UninstallPanel.Visible = True
                                    UserPreferencesModule.UninstallPanel.Location = New Point(6, 2)
                                    UserPreferencesModule.Text = "Uninstall AutoPowerModeSwitcher"
                                    UserPreferencesModule.UninstallCancelButton.Visible = False
                                    UserPreferencesModule.Button3.PerformClick()
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Uninstall panel is shown. Uninstalling conditions are enabled.")

                                End If

                            ElseIf Environment.GetCommandLineArgs(1) = "/asInvoker" Then
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: Application started with argument: /asInvoker. Granting admin rights.")
                                If (Not IsRunningAsAdmin()) Then
                                    ' Launch itself as administrator
                                    Dim proc As New ProcessStartInfo
                                    proc.UseShellExecute = True
                                    proc.WorkingDirectory = Environment.CurrentDirectory
                                    proc.FileName = Application.ExecutablePath
                                    proc.Verb = "runas"
                                    proc.Arguments = "/asInvoker"
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Uninstall panel is shown. Uninstalling controls are enabled.")
                                    Try
                                        Process.Start(proc)
                                    Catch
                                        MsgBox("asInvoker parameter requires admin permissions to run application invoked.") ' The user refused the elevation.
                                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User denied the elevation. (UAC)")
                                        Return

                                    End Try

                                    Environment.Exit(0) ' Quit itself
                                Else

                                    'The process is already running as administrator

                                    UserInterface.Show()
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Successfully granted admin rights.")

                                End If
                            End If








                        Catch ex As Exception
                            MsgBox("An exception occured: " + ex.ToString)
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured: " + ex.ToString)
                            CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CoreForm malfunctioned. Critical error occured. Error details: " + ex.ToString
                            Call CoreForm.errorLoggingSystem()
                        End Try


                    Else
                        StartedonBoot.Text = "False"
                        'no args called
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Application started without any arguments.")
                        Call startApplication
                        ' Form1.Show()
                    End If



                Catch ex As Exception
                    MsgBox("An exception occured: " + ex.ToString)
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured: " + ex.ToString)

                    CoreForm.errorLoggingText = DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CoreForm malfunctioned. Critical error occured. Application will not start. Error details: " + ex.ToString
                    Call CoreForm.errorLoggingSystem
                End Try




            Else
                ' Hide()
                EngineStopper.Start()




            End If

        End If

    End Sub

    Private Sub EngineStopper_Tick(sender As Object, e As EventArgs) Handles EngineStopper.Tick
        Engine.Stop()
   
        EngineStopper.Stop()

    End Sub

    Private Sub CoreForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
   
        
    '    Application.Exit()


    End Sub


    Private Sub Cloak_Tick(sender As Object, e As EventArgs) Handles Cloak.Tick
        If Application.OpenForms.Count > 1 Then
            Hide()
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Coreform has finished loading AutoPowerModeSwitcher.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "COREFORM: CloakForm detected an open form. CoreForm is now hidden.")
            Cloak.Stop()

        Else

        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminating process")
        Engine.Stop()
        Environment.Exit(0)
        'Environment.FailFast(0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User is clicking the PictureBox. Why panicked?")
    End Sub

    Private Sub StatusLabel_Click(sender As Object, e As EventArgs) Handles StatusLabel.Click
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked CoreForm's label. Why panicked?")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "[CRITICAL EVENT] User enabled SafeMode!!!")

        Dim path = IO.Path.Combine("C:\Users\cryptedbytes\AppData\Local\CryptedBytes_Software")

    Dim filter = "AutoPowerModeSwitcher"
    Dim files =
        From fl In IO.Directory.GetFiles(path)
        Where fl.Contains(filter)
        Select fl

    For Each fl In files
        IO.File.Delete(fl)
    Next

        My.Settings.SafemodeEnabled = True
        Application.Restart

    End Sub

    Private Sub SafemodeDialog_Tick(sender As Object, e As EventArgs) Handles SafemodeDialog.Tick
        SafemodePromptPanel.Visible = True
        SafemodeDialog.stop
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        My.Settings.SafemodeEnabled = False
        My.Settings.Save
        UserInterface.dispose
        UserPreferencesModule.dispose
        DebugUI.dispose
    Application.restart
    End Sub
End Class