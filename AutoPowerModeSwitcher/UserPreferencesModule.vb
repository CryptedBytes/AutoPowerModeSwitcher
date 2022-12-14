Imports System.Security.Principal
Imports AutoPowerModeSwitcher.UserInterface

Public Class UserPreferencesModule
      Dim w As IO.StreamWriter 'needed for creating the database
    Dim r As IO.StreamReader


   
   
    Private Sub GameChooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserPreferencesModule is loaded into memory.")
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Getting and setting user settings (UserPreferencesModule)")
   TabControl1.TabPages.Remove(TabPage1)
        If My.Settings.AutoPilotEnabled = True Then
            Userdetect.Checked = True

        Else
            UserNOdetect.Checked = True

        End If


        If Userdetect.Checked = True Then
            DetectionEngine.Start()
            GroupBox2.Visible = True
            My.Settings.AutoPilotEnabled = True
            My.Settings.Save()

        Else

            GroupBox2.Visible = False
            DetectionEngine.Stop()
            My.Settings.AutoPilotEnabled = False
            My.Settings.Save()


        End If
        If My.Settings.CoreEngineModeEqualsOptimized = True Then
            EngineMode2.Checked = True
        Else
            EngineMode1.Checked = True
        End If
        If My.Settings.UserTrackingEnabled = True Then
            UserTrackingCheckbox.Checked = True
            UserTrackingHighSpeedCheckbox.Visible = true
        Else
            UserTrackingCheckbox.Checked = Not True
                    UserTrackingHighSpeedCheckbox.Visible = not true
        End If
        If My.Settings.TaskManagerEnabled = True Then
            GameBoosterEnabled.Checked = True
        Else
            GameBoosterEnabled.Checked = Not True
        End If
        If My.Settings.TaskManagerWarningRemoved = True Then
            Panel3.Dispose()
        Else

        End If
        If GameBoosterEnabled.Checked = True Then
            KillProcessesCheckBox.Checked = True
        Else
            KillProcessesCheckBox.Checked = Not True
        End If
        If My.Settings.TaskManagerRestartAfterSession = True Then
            RestartAfterSessionCheckBox.Checked = True
        Else
            RestartAfterSessionCheckBox.Checked = Not True
        End If

        If My.Settings.BootManagerEnabled = True Then
            EnableBootManagerCheck.Checked = True
        Else
            EnableBootManagerCheck.Checked = Not True
        End If
        If My.Settings.NoImpactEnabled = True Then
            NoImpactCheckbox.Checked = True
        Else
            NoImpactCheckbox.Checked = False

        End If
        PrivacyStatementPanel.Location = New Point(6, 171)
        If StartonBoot.Checked = False Then
            EnableBootManagerCheck.Enabled = False
        Else
            EnableBootManagerCheck.Enabled = Not False
        End If
        If My.Settings.TaskManagerPrioritize = True Then
            PrioritizeTargetProcessCheckBox.Checked = True
        Else
            PrioritizeTargetProcessCheckBox.Checked = Not True
        End If
        If My.Settings.EnableExperimentalFeatures = True Then
            EnableExperimentalFeatuesCheckBox.Checked = True
        Else
            EnableExperimentalFeatuesCheckBox.Checked = Not True
        End If
        
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "New location set to = '9, 6' for Panel6")
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized all components of UserPreferencesModule.")
      
        HideLegacySettingsPanel1.Location = New Point(7, 9)
     HideGameDetectionPanel.Location = New Point(6, 6)

        If My.Settings.SafemodeEnabled = True Then

            Me.Text = Me.Text & " - Safemode is enabled"
        Else

        End If
        Panel7.Location = New Point(0,0)
        Panel10.Location = New Point(0,0)
        HideLegacySettingsPanel1.location = New Point(0,0)
        Call UserInterface.AutoPilotController
        Call UserInterface.readDatabase
         
    End Sub


    Private Sub Engine_Tick(sender As Object, e As EventArgs) Handles DetectionEngine.Tick
        'get processes
        if My.Settings.AllowPowermodeControl = False Then

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG AllowPowerModeControl is disabled!!!! UserPreferencesModule engine is ticked but won't apply anything!")
            Else
      If My.Settings.enableGameDetection = True Then
                Panel10.Visible = false
               ' Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "flagEnableGameDetection bool value equals true. Enabled GameDetectionUtility.")
        If My.Settings.DisableLegacyCheckboxStyleDetectionSystem = True Then

            DebugUI.AutoPilotDetectionTickCount.Text = DebugUI.AutoPilotDetectionTickCount.Text + 1
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is enabled. Detection engine is now running in listbox mode!")
             If My.Settings.AutoPilotEnabled = True Then
            For i As Integer = 0 To GameDetectionCollection.Items.Count - 1
                    Dim target() as Process
                target =  Process.GetProcessesByName(GameDetectionCollection.Items(i))
                
                'verbose
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DETECTION ENGINE VERBOSE: Currently checking process " & GameDetectionCollection.Items(i))
               
                'end verbose

                If target.count > 0 Then
                    UserInterface.TargetProcessBox.Text = (GameDetectionCollection.Items(i))
                     Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DETECTION ENGINE VERBOSE: Process " & GameDetectionCollection.Items(i) & " is running. Set targetprocessbox accordingly.")
                Else

                End If
         
Next
End If

        Else
              DebugUI.AutoPilotDetectionTickCount.Text = DebugUI.AutoPilotDetectionTickCount.Text + 1
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. WARNING: Legacy mode MAY cause problems.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. Detection engine is now running in LEGACY checkbox mode!")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. Detection engine is now running in LEGACY checkbox mode!")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG DisableLegacyCheckboxStyleDetectionSystem is disabled. Detection engine is now running in LEGACY checkbox mode!")
            If My.Settings.AutoPilotEnabled = True Then
            If CheckBox1.Checked = True Then
                Dim fallout() As Process
                fallout = Process.GetProcessesByName("Fallout4")
                If fallout.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "Fallout4"


                Else      ' Process is not running

                End If
            Else

            End If

            If CheckBox2.Checked = True Then
                Dim GTAV() As Process
                GTAV = Process.GetProcessesByName("GTA5")
                If GTAV.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "GTA5"
                    UserInterface.CurrentGameLabel.Text = "Grand Theft Auto V"
                Else      ' Process is not running

                End If
            End If

            If CheckBox3.Checked = True Then
                Dim BF3() As Process
                BF3 = Process.GetProcessesByName("bf3")
                If BF3.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "bf3"
                Else      ' Process is not running

                End If
            Else


            End If
            If CheckBox5.Checked = True Then
                Dim FC3() As Process
                FC3 = Process.GetProcessesByName("farcry3_d3d11")
                If FC3.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "farcry3_d3d11"
                Else      ' Process is not running

                End If
                Dim FC3_2() As Process
                FC3_2 = Process.GetProcessesByName("farcry3")
                If FC3_2.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "farcry3"
                Else      ' Process is not running

                End If
            Else

            End If

            If CheckBox11.Checked = True Then
                Dim BF4() As Process
                BF4 = Process.GetProcessesByName("bf4")
                If BF4.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "bf4"
                Else      ' Process is not running

                End If


            End If

            If CheckBox12.Checked = True Then
                Dim GTAIV() As Process
                GTAIV = Process.GetProcessesByName("GTAIV")
                If GTAIV.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "GTAIV"
                Else      ' Process is not running

                End If
            End If


            If CheckBox12.Checked = True Then
                Dim EFLC() As Process
                EFLC = Process.GetProcessesByName("EFLC")
                If EFLC.Count > 0 Then   ' Process is running
                    UserInterface.TargetProcessBox.Text = "EFLC"
                Else      ' Process is not running

                End If
            End If
            Label41.Text = Label41.Text + 1
        Else

        End If


        End If
                  Else
                Panel10.Visible = true
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "flagEnableGameDetection bool value equals false. Disabled GameDetectionUtility.")
End If

        End If
    End Sub



    Private Sub UserPreferencesModule_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If My.Settings.AllowQuit = True

           ' Close() 
     
        
       

        Else
             e.Cancel = True
     Hide()
          
     End If

     
       


    End Sub


    Private Sub Userdetect_CheckedChanged(sender As Object, e As EventArgs) Handles Userdetect.CheckedChanged
        ' default size = 383, 320
        If Label56.Text = 0 Then
            Label56.Text = 1
            Label56.Visible = False
        Else
            AutoPilotPopup.Timer1.Stop()
            AutoPilotPopup.Timer1.Start()
            AutoPilotPopup.Show()
        End If
        If Userdetect.Checked = True Then 'if AUTOPILOT IS ENABLED
           ' My.Settings.enableGameDetection = true
            DetectionEngine.Start()
            GroupBox2.Visible = True
            My.Settings.AutoPilotEnabled = True
          
            Label3.Visible = True
            UserInterface.Label3.Visible = True
            UserInterface.AutoPilotStatus.Text = "True"
            PrivacyStatementPanel.Visible = False
            '   UserTrackingCheckbox.Checked = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "AUTOPILOT IS ENABLED")
              My.Settings.Save()

            '  Height = 286
        Else                'if AUTOPILOT IS DISABLED

            GroupBox2.Visible = False
            DetectionEngine.Dispose()
            My.Settings.AutoPilotEnabled = False
            My.Settings.Save()
            Label3.Visible = False
            UserInterface.Label3.Visible = False
            UserInterface.AutoPilotStatus.Text = "False"
            PrivacyStatementPanel.Visible = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 1)")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 2)")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 3)")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 4)")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Warning: AUTOPILOT IS DISABLED (warning 5)")
            '  Height = 129
        End If
    End Sub
    Private Sub Invertal1_CheckedChanged(sender As Object, e As EventArgs)

        'doesnt work
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("This engine sets your powerplan according to your preferences every 500 miliseconds. Not listening to any events or intents, it just overrides system's powerplan with your desired one.")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("This engine sets your powerplan according to your preferences only when planned events occur. For example when system's powerplan is changed outside of the app we reset it and override it by your prefered powerplan.")
    End Sub



    Public Shared Function IsRunningAsAdmin() As Boolean
        Dim principal As New WindowsPrincipal(WindowsIdentity.GetCurrent)
        Return principal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function


    Private Sub TopMostCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostCheckbox.CheckedChanged
        If TopMostCheckbox.Checked Then
            UserInterface.TopMost = True
            TopMost = True

        Else
            UserInterface.TopMost = False
            TopMost = false

        End If
    End Sub

    Private Sub EngineMode2_CheckedChanged(sender As Object, e As EventArgs) Handles EngineMode2.CheckedChanged
        If EngineMode2.Checked = True Then
            My.Settings.CoreEngineModeEqualsOptimized = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CryptedEngine working mode is now set to Optimized.")

        Else
            My.Settings.CoreEngineModeEqualsOptimized = False
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CryptedEngine working mode is now set to Performance Focused.")
            UserInterface.SetPowerPlanAlternate.Start()
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Enabling performance-focused engine.")
        End If
        My.Settings.Save()

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles EnableExperimentalFeatuesCheckBox.CheckedChanged
        If EnableExperimentalFeatuesCheckBox.Checked = True Then
            My.Settings.EnableExperimentalFeatures = True
            My.Settings.Save()
            LinkLabel3.Visible = True
                TabControl1.TabPages.add(TabPage1)
            Label54.Visible = true
            memory4.Visible= True
           
            Label42.Visible = True
            Label41.Visible = True

            memory.Visible = True
            isAlreadyRunningLabel.Visible = True
            UIEngineLabel.Visible = True
            CheckingSpeedPanel.Visible = True
            Label53.Visible = True
            Label50.Visible = True
            memory2.Visible = True

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Enabled experimental features.")
        Else
            My.Settings.EnableExperimentalFeatures = False
            My.Settings.Save()
            LinkLabel3.Visible = False
                TabControl1.TabPages.Remove(TabPage1)
    
            Label42.Visible = Not True
            Label41.Visible = Not True
             Label54.Visible = not true
            memory4.Visible= not True
            memory.Visible = Not True
            isAlreadyRunningLabel.Visible = Not True
            UIEngineLabel.Visible = Not True
            CheckingSpeedPanel.Visible = Not True
            Label53.Visible = Not True
            Label50.Visible = Not True
            memory2.Visible = Not True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Disabled experimental features.")
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        Debugging.Show()
    End Sub

    Private Sub GameBoosterEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles GameBoosterEnabled.CheckedChanged

        If GameBoosterEnabled.Checked = True Then
            RestartAfterSessionCheckBox.Enabled = True
            KillProcessesCheckBox.Enabled = True
            'My.Settings.TaskManagerEnabled = True
        Else
            RestartAfterSessionCheckBox.Enabled = False
            KillProcessesCheckBox.Enabled = False
       '     My.Settings.TaskManagerEnabled = Not True
        End If
   '     If GameBoosterEnabled.Checked = False Then
    ''        If Userdetect.Checked = True Then
      ''         MsgBox("AutoPilot is enabled, you cannot disable this feature as it's currently in-use by application environment. Disable AutoPilot first to disable this feature.", MsgBoxStyle.Exclamation, "AutoPilot is preventing you from disabling this feature")
        '    Else

          ' End If
   

     '  End If

    End Sub


    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles KillProcessesCheckBox.CheckedChanged
        If GameBoosterEnabled.Checked = True Then
            'KillProcessesCheckBox.Checked = True
        Else
            KillProcessesCheckBox.Checked = Not True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LowFreqGUID.TextChanged


        If LowFreqGUID.Text.Length = 36 Then
            WarnLabel.Visible = False
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Low Frequency Powermode GUID is VALID!")
        Else
            WarnLabel.Visible = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: Low Frequency Powermode GUID is INVALID!")
        End If
        My.Settings.LowFreqGUID = LowFreqGUID.Text
        My.Settings.Save()

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        LowFreqGUID.Text = "31377a3e-f393-4dfd-bb39-490b8e811f2b"
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Low Frequency Powermode GUID is RESET!")
    End Sub

    Private Sub LowFreqGUID_Click(sender As Object, e As EventArgs) Handles LowFreqGUID.Click
        If ShowWarn.Text = "1" Then
            MsgBox("Changing GUID may cause application unstability as the app will not reconise system components if you enter a wrong GUID and continue using application with it so some CORE featrues MAY NOT WORK afterwards. Only change GUID if you REALLY and REALLY know what you are doing and how to revert it if something goes wrong. However click OK to continue.", MsgBoxStyle.Exclamation, "Things may go all the way wrong, you have been warned!")

            ShowWarn.Text = "0"
        Else

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Reset()
        My.Settings.Save()
        UIEngineLabel.Text = "21"
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UIEngine Memory's value = 21")
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restored default settings.")
        Label21.Visible = True
        UIEngine.Start()

    End Sub

    Private Sub UIEngine_Tick(sender As Object, e As EventArgs) Handles UIEngine.Tick
        If UIEngineLabel.Text = "21" Then
            Label21.Visible = False
        ElseIf UIEngineLabel.Text = "51" Then
            Label51.Visible = False
        End If

        If My.Settings.AllowPowermodeControl = True
            Panel7.Visible = False
        Elseif My.Settings.AllowPowermodeControl = not True
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FLAG AllowPowerModeControl is disabled! Applying conditions.")
            Panel7.Visible = True
            Label60.Text = "Game Detection Utility cannot work at the moment."
            Label60.ForeColor = Color.black
     
            
                    

        End If


    End Sub


    Private Sub Invertal2_CheckedChanged(sender As Object, e As EventArgs) Handles Interval2.CheckedChanged
        If Interval1.Checked = True Then

            ' SetPowerPlan.Interval = "500" // this timer is run only once per call, so inveral should NOT affect system performance
            UserInterface.ProcessDetector.Interval = "1550"
            IntervalWarning.Visible = False
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Process Detector Engine's interval is set to 1550")
        Else
            UserInterface.CheckPowerPlan.Interval = "6222"
            'SetPowerPlan.Interval = "6200" // this timer is run only once per call, so inveral should NOT affect system performance
            UserInterface.ProcessDetector.Interval = "6222"
            ' MsgBox("Frequent checks are strongly RECOMMENDED.")
            IntervalWarning.Visible = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Process Detector and Check Powerplan Engine's interval is set to 6222")
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles UserTrackingCheckbox.CheckedChanged
        If UserTrackingCheckbox.Checked = True Then
            My.Settings.UserTrackingEnabled = True
            UserInterface.FreeSpaceChecker.Start()
            UserInterface.CPUTracker.Start()
            UserInterface.EnvTickCounter.Start()
            UserInterface.FormLocationLabel.Text = UserInterface.Location.ToString
            UserInterface.CPUUsageLabel.Text = "Measuring..."
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FreeSpaceTracker, CPUTracker, EnvironmentTickCounter and FormLocationTracker is enabled. Tracking system info.")
            UserTrackingHighSpeedCheckbox.Visible = true
        Else
            My.Settings.UserTrackingEnabled = False
            UserInterface.FormLocationLabel.Text = "Disabled by user"
            UserInterface.CPUUsageLabel.Text = "Stopping engine"
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "FreeSpaceTracker, CPUTracker, EnvironmentTickCounter and FormLocationTracker is disabled. NOT tracking system info")
            UserTrackingHighSpeedCheckbox.Visible =False

        End If
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Panel3.Dispose()
        If CheckBox6.Checked = True Then
            My.Settings.TaskManagerWarningRemoved = True
        Else
            My.Settings.TaskManagerWarningRemoved = Not True
        End If
    End Sub

    Private Sub RestartAfterSessionCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RestartAfterSessionCheckBox.CheckedChanged
        If RestartAfterSessionCheckBox.Checked = True Then
            My.Settings.TaskManagerRestartAfterSession = True
        Else
            My.Settings.TaskManagerRestartAfterSession = Not True
        End If
    End Sub

    Private Sub EnableBootManagerCheck_CheckedChanged(sender As Object, e As EventArgs) Handles EnableBootManagerCheck.CheckedChanged
        If EnableBootManagerCheck.Checked = True Then
            My.Settings.BootManagerEnabled = True

        Else
            My.Settings.BootManagerEnabled = Not True
        End If

        If EnableBootManagerCheck.Checked = True Then
            memory2.Text = "True"
        Else
            memory2.Text = "False"
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel5.Dispose()
    End Sub

    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Entered Uninstall tab.")
        Panel5.Location = New Point(249, 278)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Panel5's location is changed")
        Dim W_Id = WindowsIdentity.GetCurrent()
        Dim WP = New WindowsPrincipal(W_Id)
        Dim isAdmin As Boolean = WP.IsInRole(WindowsBuiltInRole.Administrator)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Checking admin rights")
        If isAdmin = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Returned True, user is privileged")

        Else
            Button3.Enabled = False
            Label37.Visible = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Returned False, user is NOT privileged")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User's ability to uninstall application is disabled")
        End If
    End Sub

    Private Sub DelayStartup_CheckedChanged(sender As Object, e As EventArgs) Handles NoImpactCheckbox.CheckedChanged
        If NoImpactCheckbox.Checked = True Then
            My.Settings.NoImpactEnabled = True
        Else
            My.Settings.NoImpactEnabled = Not True
        End If
    End Sub

    Private Sub StartonBoot_Click(sender As Object, e As EventArgs, Optional ByVal args As String = "/ShowSettings") Handles StartonBoot.Click

        ' Elevate the process if it is not run as administrator.
        If (Not IsRunningAsAdmin()) Then
            ' Launch itself as administrator
            Dim proc As New ProcessStartInfo
            proc.UseShellExecute = True
            proc.WorkingDirectory = Environment.CurrentDirectory
            proc.FileName = Application.ExecutablePath
            proc.Verb = "runas"
            proc.Arguments = args

            Try
                Process.Start(proc)
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Restarting application in elevated mode")
            Catch
                MsgBox("Cannot alter this setting without elevation") ' The user refused the elevation.
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "USERPREFERENCESMODULE: User refused the elevation")
                Return
            End Try
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Killing process, ignore 'clicked X button' logs as they are not valid.")
            CoreForm.Dispose()
            Application.Exit()  ' Quit itself 'maybe the issue is that application is one-instance only
        Else

            'The process is already running as administrator

            If StartonBoot.Checked = True Then       '//THIS IS THE LOGIC
                StartonBoot.Checked = False
            Else
                StartonBoot.Checked = True
            End If

            If StartonBoot.Checked Then
                'start on boot
                Try
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath & " /onboot")

                    EnableBootManagerCheck.Enabled = True
                    StartonBoot.Checked = True
                    My.Settings.StartOnBootEnabled = True

                Catch ex As Exception

                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured while setting reg key: " + ex.ToString)

                End Try
            Else
                'DO NOT start on boot
                Try
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                    EnableBootManagerCheck.Checked = False
                    EnableBootManagerCheck.Enabled = False
                    StartonBoot.Checked = Not True
                    My.Settings.StartOnBootEnabled = Not True
                Catch ex As Exception


                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An exception occured while setting reg key: " + ex.ToString)
                End Try

            End If
        End If
        CheckboxDisabler.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label46.Visible = True

        ProcessingAnimator.Start()
        System.Threading.Thread.Sleep(2000)
        If CheckBox9.Checked = True Then
            Try
                Process.Start("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del " +
        Application.ExecutablePath)
            Catch ex As Exception
                Label11.Text = Label11.Text + 1
            End Try

        Else

        End If
        If CheckBox8.Checked = True Then
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            Catch ex As Exception
                MsgBox("Failed to delete REGKEYS. More info about the exception: " + ex.ToString)
                Label11.Text = Label11.Text + 1
            End Try


        Else

        End If
        If CheckBox10.Checked = True Then
            My.Settings.Reload()

            My.Settings.Reset()
        Else

        End If
        If CheckBox9.Checked = False And CheckBox10.Checked = False And CheckBox8.Checked = False Then
            MsgBox("No components selected for uninstall process!")
            Label46.Visible = False
        Else
            If Label11.Text > 0 Then
                MsgBox("Successfully removed application, however some errors occured during the uninstallation so you may need to manually remove some leftovers.")
                Environment.Exit(0)
            Else
                MsgBox("Success!")
                Label46.Visible = False

                Environment.Exit(0)
            End If

        End If
    End Sub
    
 
    Private Sub Panel3_VisibleChanged(sender As Object, e As EventArgs) Handles Panel3.VisibleChanged
        '  If Panel3.Visible = True Then
        ' Panel3.Visible = False
        'Else
        'End If
    End Sub





    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label51.Visible = True
        UIEngineLabel.Text = "51"
        UIEngine.Start()
        My.Settings.Save()
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved user settings.")
    End Sub

    Private Sub UninstallCancelButton_Click(sender As Object, e As EventArgs) Handles UninstallCancelButton.Click
        UninstallPanel.Dispose()
        UserInterface.Show()
        TabControl1.SelectTab(1)
        Hide()
        Text = "AutoPowerModeSwitcher Settings"
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User has cancelled uninstallation. Restoring normal app conditions.")
    End Sub

    Private Sub ProcessingAnimator_Tick(sender As Object, e As EventArgs) Handles ProcessingAnimator.Tick
        Label46.Text = Label46.Text + "."
        If Label46.Text = "Processing...." Then
            Label46.Text = "Processing"
        End If

    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles SimulateProcessRunningCheckbox.CheckedChanged
        If SimulateProcessRunningCheckbox.Checked = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Starting simulation")
            Threading.Thread.Sleep(1000)
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intializing memory content.")
            memory.Text = UserInterface.TargetProcessBox.Text
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Memorized data= " + memory.Text)
            UserInterface.TargetProcessBox.Enabled = False
            UserInterface.TargetProcessBox.Text = "notepad"
            My.Settings.TargetProcess = "notepad"
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is set to 'notepad'")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User's ability to interact with target process textbox is prohibited")
            My.Settings.Save()
            Label49.Visible = True


            Dim Notepad() As Process
            Notepad = Process.GetProcessesByName("notepad")
            If Notepad.Count > 0 Then   ' Process is running

                isAlreadyRunningLabel.Text = "True"
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notepad is already running, noted.")

            Else      ' Process is not running
                isAlreadyRunningLabel.Text = "False"
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notepad is not running, noted.")
            End If

            Try
                Dim p As New Process
                Dim psi As New ProcessStartInfo

                psi.WindowStyle = ProcessWindowStyle.Hidden
                psi.FileName = "notepad.exe"
                psi.UseShellExecute = True
                p.StartInfo = psi
                p.Start()
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Starting notepad, hidden and with no arguments.")
            Catch ex As Exception
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Failed to start notepad. Additional details are provided by a MsgBox")
                MsgBox("Failed to start simulating app. Please try again. Additional info about the exception: " + ex.ToString)
                SimulateProcessRunningCheckbox.Checked = False

            End Try
        Else

            UserInterface.TargetProcessBox.Enabled = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User's ability to interact with target process textbox is re-enabled")
            UserInterface.TargetProcessBox.Text = memory.Text

            My.Settings.TargetProcess = memory.Text
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is set back to memorized process, " + memory.Text)
            My.Settings.Save()

            Label49.Visible = Not True

            If isAlreadyRunningLabel.Text = "True" Then
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notepad was already running before the simulation. Cannot terminate user started application.")
            Else
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminating notepad")
                Shell("taskkill -f /im Notepad.exe", AppWinStyle.Hide)
                Shell("taskkill -f /im notepad.exe", AppWinStyle.Hide)

            End If
        End If



    End Sub



    Private Sub PrioritizeTargetProcessCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles PrioritizeTargetProcessCheckBox.CheckedChanged
        If PrioritizeTargetProcessCheckBox.Checked = True Then
            My.Settings.TaskManagerPrioritize = True

        Else
            My.Settings.TaskManagerPrioritize = Not True
        End If
        My.Settings.Save()
    End Sub

    Private Sub StartMinimized_CheckedChanged(sender As Object, e As EventArgs) Handles StartMinimized.CheckedChanged
        If StartMinimized.Checked = True Then
            My.Settings.StartMinimized = True
        Else
            My.Settings.StartMinimized = Not True
        End If
        My.Settings.Save()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub PrivacyStatementPanel_VisibleChanged(sender As Object, e As EventArgs) Handles PrivacyStatementPanel.VisibleChanged
        If PrivacyStatementPanel.Visible = False Then
            If My.Settings.EnableExperimentalFeatures = True Then
                CheckingSpeedPanel.Visible = True

            End If

        Else
            CheckingSpeedPanel.Visible = Not True
        End If
    End Sub

    Private Sub TabControl1_TabStopChanged(sender As Object, e As EventArgs) Handles TabControl1.TabStopChanged

    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Tab index changed. Current tab index= " + TabControl1.SelectedIndex.ToString)
    End Sub

    Private Sub UserPreferencesModule_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If   CoreForm.prefetchingUserPreferences = true Then
            Opacity = 0
            Else
            Opacity = 100
        End If
        If Visible = True Then

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserPreferencesModule visibilty changed. It's visible.")
        Else
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserPreferencesModule visibilty changed. It's NOT visible.")
        End If


    End Sub

    Private Sub ConsoleEngine_Tick(sender As Object, e As EventArgs) Handles CheckboxDisabler.Tick
        If StartonBoot.Checked = True Then

            EnableBootManagerCheck.Enabled = True
            If memory2.Text = "True" Then
                EnableBootManagerCheck.Checked = True
            ElseIf memory2.Text = "False" Then
                EnableBootManagerCheck.Checked = Not True
            Else

            End If
        Else


            EnableBootManagerCheck.Checked = False
            EnableBootManagerCheck.Enabled = False

        End If
        CheckboxDisabler.Stop()

    End Sub

    Private Sub UserTrackingHighSpeedCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles UserTrackingHighSpeedCheckbox.CheckedChanged

        If UserTrackingHighSpeedCheckbox.Checked = True Then
            UserInterface.CPUTracker.Interval = 560 '750
            UserInterface.FreeSpaceChecker.Interval = 10 '45
            UserInterface.EnvTickCounter.Interval = 10 '200
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User tracking is now *MORE* precise")
        Else
            UserInterface.CPUTracker.Interval = 750
            UserInterface.FreeSpaceChecker.Interval = 45
            UserInterface.EnvTickCounter.Interval = 200
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User tracking is now *LESS* precise")
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        GameList.show
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
            GameDetectionCollection.Items.clear
            GameDetectionCollection.Items.Add("GTA5")
            GameDetectionCollection.Items.Add("Fallout4")
            GameDetectionCollection.Items.Add("GTAIV")
        '    GameDetectionCollection.Items.Add("farcry3_d3d11")
            GameDetectionCollection.Items.Add("farcry3")
            GameDetectionCollection.Items.Add("farcry4")
            GameDetectionCollection.Items.Add("bf3")
            GameDetectionCollection.Items.Add("bf4")
            GameDetectionCollection.Items.Add("witcher3")
            GameDetectionCollection.Items.Add("DyingLightGame")
            GameDetectionCollection.Items.Add("DeadIslandGame")
            GameDetectionCollection.Items.Add("watch_dogs")
     

         Call UserInterface.writeDatabase
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
             If UserInterface.targetprocessbox.Text = GameDetectionCollection.SelectedItem.tostring
            UserInterface.targetprocessbox.Text = "GTA5"
            Else


        End If
        GameDetectionCollection.Items.Remove(GameDetectionCollection.SelectedItem)
     Call UserInterface.writeDatabase
        Catch ex As Exception
            MsgBox("Select an item first!", MsgBoxStyle.Information, "Failed to remove selected item.")
        End Try
       
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Settings.enableGameDetection = False
        Threading.Thread.Sleep(2000)
        Panel10.Visible = true
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TabControl1.SelectedTab = tabpage7
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TabControl1.SelectedTab = tabpage2
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControl1.SelectedTab = tabpage4
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
                If TextBox1.Text < 0 Then
            TextBox1.Text = 2000
            MsgBox("Detection engine's check intervals cannot be equal or lower than a zero value. Reverted back to the default value", MsgBoxStyle.Critical, "An error occured")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Detection engine interval cannot be equal or lower than a zero value. Reset.")
        ElseIf TextBox1.Text = " " Then

            TextBox1.Text = 2000
            MsgBox("Detection engine's check intervals cannot be equal or lower than a zero value. Reverted back to the default value", MsgBoxStyle.Critical, "An error occured")
        Else

            DetectionEngine.Interval = TextBox1.Text
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Detection Engine's interval value has been user-modified. New value is = " + DetectionEngine.Interval.ToString + "ms")
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        GameDetectionCollection.Items.clear
        Call UserInterface.writeDatabase

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        
        MsgBox("Changing any value may lead application to misbehave!")
        HideLegacySettingsPanel1.Visible = False
        MsgBox("Cannot find required GUID libraries! Testing GUID will not be available." , MsgBoxStyle.Critical, "CryptedBytes AutoPowerModeSwitcher has encountered a critical error.")
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
         Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://cryptedbytes.comxa.com/files/ApplicationFiles/RemoteControl/LoremIpsumTest")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim HelpTextString As String = sr.ReadToEnd()
                MsgBox(HelpTextString)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        GameDetectionCollection.Items.Clear
        Call UserInterface.readDatabase 
    End Sub

    Private Sub HideGameDetectionPanel_VisibleChanged(sender As Object, e As EventArgs) Handles HideGameDetectionPanel.VisibleChanged
   
   ' Call recheckAutoPilotService
 
    End Sub
    Private Sub recheckAutoPilotService 
        If Userdetect.Checked = True Then
            My.Settings.AutoPilotEnabled = True
            HideGameDetectionPanel.Visible = False
        Else

            My.Settings.AutoPilotEnabled = False
            HideGameDetectionPanel.Visible = True
        End If
    End Sub


    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
         recheckAutoPilotService
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        My.Settings.AllowPowermodeControl = True
        My.Settings.Save
        Label60.Text = "  Please wait, Game Detection Engine is initializing..."
        Label60.ForeColor = Color.red
  
        UserInterface.allowpowermodecontrol.Checked = True
   
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        My.Settings.enableGameDetection = True
        My.Settings.save
        Panel10.Visible = False

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) 
         TabControl1.TabPages.Remove(TabPage1)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) 
            TabControl1.TabPages.add(TabPage1)
    End Sub


End Class
