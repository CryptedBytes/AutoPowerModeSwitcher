'//LOGGING SYSTEM EXAMPLE CODE SNIPPET
'//Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Log here")
'// Error logging system example code snippet (writes errors to a output file)
'// CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Example"
'// Call CoreForm.errorLoggingSystem
'//default designer view 952; 529
'//extended user view 313; 529
'//default user view 313; 180

'// show notification
  '// NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher"
    '//                        NotifyIcon1.BalloonTipText = "You have quit the game. APMS is restoring your system to its normal conditions"
       '//                     NotifyIcon1.ShowBalloonTip(2800)

Public Class UserInterface
    Dim declareTargetProcessAsRunningValue = False
    Dim allowBenchmarking As Boolean = False
    Dim w As IO.StreamWriter 'needed for creating the database
    Dim r As IO.StreamReader
    Dim regValueToCheck As String = "NAN"
    Dim benchmarkTime As Integer = 0
    Dim variable_regvaluedoesnotexist As String = "This must be overrriden before throwing."
    Dim variable_regvalueexists As String = "This must be overrriden before throwing."
    Dim variable_byte_regexistsaction = 0
    Dim variable_regvalueexiststitle As String = "This must be overrriden before throwing."
    Dim variable_regdeletednotifytext As String = "This must be overrriden before throwing."
    Private m_PerformanceCounter As New _
      System.Diagnostics.PerformanceCounter(
          "Processor", "% Processor Time", "_Total") 'CPU usage tracking code
    Private sub declareTargetProcessAsRunning 
         declareTargetProcessAsRunningValue = true
          Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Declared Target Process As Running!)")
    End sub
    Private sub changePowerMode


         If My.Settings.AllowPowermodeControl = false Then
            Else

     
        If ProcessLabel.Text = "True" Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process have started running just now.")
            '#########################################################################################################################################
            '#########################################################################################################################################
            '######################################################### WARNING #######################################################################
            '############## TARGET PROCESS HAS JUST STARTED RUNNING. CALL POWER CHANGING CODES HERE AS THE TIMER IS NO LONGER BEING USED #############
            '#########################################################################################################################################
            '#########################################################################################################################################
            '#########################################################################################################################################
       '   MemorizedPowerModeLabel.Text =  ActivePlanLabel.Text 
        'Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Memorized user's preferred powermode. Value is: " & MemorizedPowerModeLabel.text)
           'Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "TESTING: REMEMBER POWER MODE ENGINE IS NOW DISPOSED")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to High Performance. Reason: Target process is now running.")
                Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide)
            
      


            If My.Settings.NoImpactEnabled = True Then
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "NoImpact is enabled and now setting conditions")
                    ' UserPreferencesModule.DetectionEngine.Interval = 60000
                    CheckPowerPlan.Interval = 5000
                    'SetPowerPlanAlternate.Interval = 6200
                    VisualStudioDetector.Dispose()
                    UserPreferencesModule.DetectionEngine.Stop()

                    UserPreferencesModule.NoImpactCheckbox.Enabled = False
                    UserPreferencesModule.Label38.Text = "Exit game first to alter this setting and/or get more info about it."
                    If UserPreferencesModule.Interval1.Checked = True Then
                        UserPreferencesModule.memory3.Text = "1"
                        UserPreferencesModule.Interval2.Checked = True
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Interval 1 was selected. Memory value is set to 1")
                    End If

                    If UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked = True Then
                        UserPreferencesModule.memory4.Text = "True"
                        UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked = False
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Resource savings started. UserTracking in now less precise.")
                    End If


                    ' If UserPreferencesModule.UserTrackingCheckbox.Checked = True Then
                    'UserPreferencesModule.memory4.Text = "True"
                    'UserPreferencesModule.UserTrackingCheckbox.Checked = False
                    'Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "UserTracking was enabled. Memory value is set to True")
                    'Else
                    '   UserPreferencesModule.memory4.Text = "False"
                    'End If
                    'was buggy, disabled.
                Else

                End If


                If UserPreferencesModule.SimulateProcessRunningCheckbox.Checked = True Then 'if simulating (check UserPreferencesModule)

                    NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher"
                    NotifyIcon1.BalloonTipText = "Currently simulating target process as running. Have fun as APMS is optimizing your system for your confort!"
                    NotifyIcon1.ShowBalloonTip(2800)
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing notification: " + NotifyIcon1.BalloonTipText.ToString)
                Else 'if not simulating 
                    NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher"
                    NotifyIcon1.BalloonTipText = "Currently playing: " + TargetProcessBox.Text + ". APMS has optimized your system!"
                    NotifyIcon1.ShowBalloonTip(2800)
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing notification: " + NotifyIcon1.BalloonTipText.ToString)
                End If

            Else

            '#########################################################################################################################################
            '#########################################################################################################################################
            '######################################################### WARNING #######################################################################
            '############## TARGET PROCESS HAS JUST STOPPED RUNNING. CALL POWER CHANGING CODES HERE AS THE TIMER IS NO LONGER BEING USED #############
            '#########################################################################################################################################
            '#########################################################################################################################################
            '#########################################################################################################################################
            If balancedBugFix.Text > "1" Then

                   If MemorizedPowerModeLabel.Text.Contains("High") Then
                Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide)

            elseif MemorizedPowerModeLabel.Text.Contains("Balance") Then
                Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide)
                elseif MemorizedPowerModeLabel.Text.Contains("Power") Then
                Shell("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a", AppWinStyle.Hide)
                Else
                    Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide)

                 Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "MemorizedPowerMode is corrupted. Overriden to balanced. It was: " & MemorizedPowerModeLabel.text)
                MemorizedPowerModeLabel.Text = "Balanced"
                CoreForm.errorLoggingText = "Debug: MemorizedPowerMode is corrupted. Overriden to balanced. It was: " & MemorizedPowerModeLabel.text
                Call CoreForm.errorLoggingSystem
              
            End If

                Else

                balancedBugFix.Text = "an error has occured"

            End If
         
         
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is NOT running.")
            If My.Settings.NoImpactEnabled = True Then
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "NoImpact is enabled. Restoring normal conditions")
                UserPreferencesModule.NoImpactCheckbox.Enabled = Not False
                'UserPreferencesModule.DetectionEngine.Interval = 6500
                UserPreferencesModule.DetectionEngine.Start()
                CheckPowerPlan.Interval = 1750
                ' SetPowerPlanAlternate.Interval = 2400
                UserPreferencesModule.Label38.Text = "Minimize resource usage and CPU utilization by slowing down application runtime elements"

                If UserPreferencesModule.memory3.Text = "1" Then
                    UserPreferencesModule.Interval1.Checked = True
                End If

                If UserPreferencesModule.memory4.Text = "True" Then
                    UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked = True
                    'UserPreferencesModule.UserTrackingCheckbox.Checked = True

                ElseIf UserPreferencesModule.memory4.Text = "False" Then
                    UserPreferencesModule.UserTrackingHighSpeedCheckbox.Checked = False
                    ' UserPreferencesModule.UserTrackingCheckbox.Checked = False
                Else


                End If
                VisualStudioDetector.Dispose()
            Else

          
            End If

        End If
               End If



    End sub
    Private sub checkRegistryKeys
         Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Function CheckRegistryKeys received the call and is now functioning.")
        Try
             If  My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue(regValueToCheck) = Nothing then 'reg key doesnt exist
            'MsgBox(variable_regvaluedoesnotexist)
                 Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Requested reg key does not exist!")
            Else  ' it exists
                 Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Requested reg key does exist!")
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System is now showing a messagebox to user.")
                Dim reply = MsgBox(variable_regvalueexists, MsgBoxStyle.YesNo, variable_regvalueexiststitle)
             
            If reply = MsgBoxResult.Yes Then
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, user replied yes to the message box.")
                  If variable_byte_regexistsaction = 1 Then

                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("QuickPowerModeSwitcher")
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System has successfully deleted the requested reg key, " & regValueToCheck)
                    BallonTipClickActionByte.Text = "2893573752"
                    NotifyIcon1.BalloonTipTitle = "Thank you."
                   NotifyIcon1.BalloonTipText = variable_regdeletednotifytext
                  NotifyIcon1.ShowBalloonTip(2000)
                      
                    Else
                
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, no action is assigned to this byte!!!!!")
            End If
                    Else
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, user replied no to the message box.")
            End If
          
       End If
        Catch ex As Exception
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System, has encountered an error!")
        End Try
       
    End sub
    
    Private sub memorizePowerPlan
      
       memorizePowerPlanEngine.start
    End sub
    Private sub startBenchmarking
         Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: STARTING BENCHMARK")
        RuntimeBenchmarkOutput.Text = "Runtime Timer: 0ms"
     
        allowBenchmarking = true
        RuntimeBenchmarkEngine.Start
  
    End sub
   
    Private sub stopBenchmarking
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "INFO: STOPPING BENCHMARK")
        allowBenchmarking = false
        RuntimeBenchmarkEngine.Stop
     
       
    
    End sub
    Private sub msgboxBenchmarkValue
        MsgBox(RuntimeBenchmarkOutput.text, MsgBoxStyle.Information, "Returned")
    End sub

    Public sub readDatabase
         Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called readDatabase.")
        'Read values from database and write them to GameDetectionCollection listbox
        Try
              r = New IO.StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes")
        While (r.Peek() > -1)
            UserPreferencesModule.gamedetectioncollection.Items.Add(r.ReadLine)
        End While
        r.Close()
        Catch ex As Exception
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "GameDetectionIdentifier is either corrupted or does not exist.")
        CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "GameDetectionIdentifier is either corrupted or does not exist."
        Call CoreForm.errorLoggingSystem
        End Try

    End sub

     Public sub writeDatabase
         Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called writeDatabase")
        Dim i As Integer
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated") = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Function writeDatabase checked for required directories and successfully found them. No need to create new ones.")
        Else
              My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated")
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Directory does not exist, creating new one.")
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory: UserGenerated Database.")

        End If
      

        
       
            If userpreferencesmodule.GameDetectionCollection.Items.Count = 0 Then 'gameDetectionCollection is empty, do not save it.

            Else

            Try
                w = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes")
        For i = 0 To userpreferencesmodule.GameDetectionCollection.Items.Count - 1
            w.WriteLine(userpreferencesmodule.GameDetectionCollection.Items.Item(i))
        Next
        w.Close()
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved listbox items to UserGenerated Database and closed StreamWriter's thread.")

        Catch ex As Exception
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "An error occured while saving listbox items to UserGenerated Database. Exception is suppressed.")
                CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "An error occured while saving listbox items to UserGenerated Database."
        Call CoreForm.errorLoggingSystem
        End Try
      

            End If
         
     

    End Sub
  Private Sub applyHighPerformanceConditions

        ActivePlanLabel.Text = "High performance"
            '    PowerModeHighPerf.Checked = True
            buttonquicksetPerformance.ForeColor = Color.red
            buttonquicksetBalanced.ForeColor = Color.Black
            buttonquicksetPowerSave.ForeColor = Color.Black
            buttonquicksetPerformance.Enabled = False
            buttonquicksetBalanced.Enabled = True
            buttonquicksetPowerSave.Enabled = True
            BalancedLabel.Visible = Not True
            PowerSaveLabel.Visible = False
            HighPerfLabel.Visible = True
        NotifyIcon1.Icon = My.Resources.NotifyIcon_HighPerformance
  End Sub

  Private Sub applyBalancedConditions

         ActivePlanLabel.Text = "Balanced"
              buttonquicksetPerformance.ForeColor = Color.Black
            buttonquicksetBalanced.ForeColor = Color.red
            buttonquicksetPowerSave.ForeColor = Color.Black
             buttonquicksetPerformance.Enabled = True
            buttonquicksetBalanced.Enabled = False
            buttonquicksetPowerSave.Enabled = True
             BalancedLabel.Visible = True
            PowerSaveLabel.Visible = False
            HighPerfLabel.Visible = false
           NotifyIcon1.Icon = My.Resources.NotifyIcon_balanced
  End Sub

    Private Sub applyPowerSaverConditions

        ActivePlanLabel.Text = "Power Saver"
              buttonquicksetPerformance.ForeColor = Color.Black
            buttonquicksetBalanced.ForeColor = Color.Black
            buttonquicksetPowerSave.ForeColor = Color.red
            ActivePlanLabel.Text = "Power Saver"
              buttonquicksetPerformance.Enabled = True
            buttonquicksetBalanced.Enabled = True
            buttonquicksetPowerSave.Enabled = False

             BalancedLabel.Visible = Not True
            PowerSaveLabel.Visible = Not False
            HighPerfLabel.Visible = False
        NotifyIcon1.Icon = My.Resources.NotifyIcon_PowerSaver
    End Sub

     Public sub AutoPilotController
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called AutoPilotController")
        If AutoPilotStatus.Text = "True" And My.Settings.AutoPilotEnabled = True Then 'autopilot is active
            UserPreferencesModule.StartonBoot.Checked = True
            'UserPreferencesModule.StartonBoot.Enabled = Not True
            UserPreferencesModule.Label24.Text = "Let the application to start on boot. This feature is currently being contolled by AutoPilot"
            UserPreferencesModule.Label32.Visible = Not True
            UserPreferencesModule.Label31.Visible = Not True
            UserPreferencesModule.Label3.Visible = True
            UserPreferencesModule.Panel3.Dispose()
            UserPreferencesModule.GameBoosterEnabled.Checked = True
    '        My.Settings.TaskManagerEnabled = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Autopilot is now controlling some user settings")
            UserPreferencesModule.hidegamedetectionpanel.Visible = False
            DebugUI.verboseautopilot.Text = "AutoPilot is now enabled"


        Else 'autopilot is disabled

            UserPreferencesModule.StartonBoot.Enabled = True
            UserPreferencesModule.Label24.Text = "Let the application to start on boot."
            UserPreferencesModule.Label32.Visible = True
            UserPreferencesModule.Label31.Visible = True
            UserPreferencesModule.Label3.Visible = Not True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Autopilot is no longer controlling user settings")
            UserPreferencesModule.hidegamedetectionpanel.Visible = True
             DebugUI.verboseautopilot.Text = "AutoPilot is now disabled"
        End If
    End sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load







        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Form1 is loaded into memory.")
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intializing Form1.")
        StartMinimized.Start()
        'CoreForm.Engine.Stop()
        ' CoreForm.Hide()


        ' set size at startup as the designer value may differ
        'designer size 1166; 437
        'user size
        Height = My.Settings.UI_DefaultHeight
        Width = My.Settings.UI_DefaultWidth


'        Call readDatabase


        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Resized form. New Height= " + Height.ToString + " New Width= " + Width.ToString)
        'SetPowerPlan.start()
        if my.Settings.AllowPowermodeControl = True Then
            AllowPowermodeControl.Checked = True
            Else
            AllowPowermodeControl.checked = false
        End If
        UserPreferencesModule.Show()
        UserPreferencesModule.Hide()
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Getting and setting user settings. (Form1)")
        '// SETTING USER PREFERENCES 

        
      

        'old power plan saving
        'If My.Settings.PreferredPowerModeEqualsBalanced = True Then
         '   PowerModeBalanced.Checked = True

'        Else
 '           PowerModeHighPerf.Checked = True
  '      End If
        My.Settings.AllowQuit= True

        'new powerplan saving
        If My.Settings.PreferredCPUModeAsByte= "0" Then
            PowerModeHighPerf.Checked = True
            ElseIf My.Settings.PreferredCPUModeAsByte= "1" then
            PowerModeBalanced.Checked = True 
            ElseIf My.Settings.PreferredCPUModeAsByte= "2" then
            PowerModeBattery.Checked = True
            Else
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: Setting PrefferedCPUMode is empty! Setting it to the default value. (Balanced)")
             My.Settings.PreferredCPUModeAsByte = 1
          '  MsgBox("WARNING: Setting PrefferedCPUMode is empty! Setting it to the default value. (Balanced)")
            My.Settings.Save()
         
            CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "WARNING: Setting PrefferedCPUMode is corrupted! Setting it to the default value. (Balanced)" 
Call CoreForm.errorLoggingSystem
        End If


       ' If My.Settings.GamingPowerModeEquals70Freq = True Then
        '    GamingModeLowFreq.Checked = True
        'Else
         '   GamingModeDoNotAlter.Checked = True
        'End If

        If My.Settings.CheckInvertalEqualsFrequent = True Then
            UserPreferencesModule.Interval1.Checked = True
        Else
            UserPreferencesModule.Interval2.Checked = True
        End If

        TargetProcessBox.Text = My.Settings.TargetProcess
        If My.Settings.StartOnBootEnabled = True Then
            UserPreferencesModule.StartonBoot.Checked = True
        Else
            UserPreferencesModule.StartonBoot.Checked = False

        End If


        ' get if the system is just started or running for a while to determine if the app is started by the user or the system itself
        ' EnvironmentTickCount.Text = Environment.TickCount ' get the tick count
        'If EnvironmentTickCount.Text < 670000 Then 'if system is started in 670 seconds before the APP launch
        'Hide()
        'Else
        'End If

        If My.Settings.TopMost = True Then
            UserPreferencesModule.TopMostCheckbox.Checked = True
            TopMost = True
        Else
            TopMost = False
            UserPreferencesModule.TopMostCheckbox.Checked = False
        End If



     '   NotifyIcon1.Icon = My.Resources.AppIcon
     '   Icon = My.Resources.AppIcon
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized NotifyIcon")
        If UserPreferencesModule.StartonBoot.Checked Then
            'start on boot
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath & " /onboot")
            Catch ex As Exception
                'UserPreferencesModule.StartonBoot.Checked = False
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Cannot set registry key (Startup reg)")
                   '   CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Cannot set registry key (Startup reg)."
        ' Call CoreForm.errorLoggingSystem
            End Try
        Else
            'DO NOT start on boot
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            Catch ex As Exception
                'UserPreferencesModule.StartonBoot.Checked = True
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Cannot set registry key. (Uninstall reg key from startup reg)")
                 CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Cannot set registry key (Uninstall reg key from startup reg)."
        Call CoreForm.errorLoggingSystem
            End Try
        End If


        If Environment.GetCommandLineArgs.Count <> 1 Then
            Try
                ArgumentsLabel.Text = Environment.GetCommandLineArgs(1).ToString()
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Started with argument= " + ArgumentsLabel.Text)
            Catch ex As Exception
                ArgumentsLabel.Text = "ERR"
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Cannot retrieve arguments")
                   CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: Cannot retrieve startup argument. ."
        Call CoreForm.errorLoggingSystem
            End Try

        Else
            ArgumentsLabel.Text = "NONE"
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Started with no arguments")
        End If
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized all components of Form1")

        If My.Settings.DisableDeveloperDetectorService = True Then
  Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Not calling VisualStudioDetector. FLAGDisableDeveloperDetectorService is set to true.")
        Else
              VisualStudioDetector.Show()
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Called VisualStudioDetector")
        End If
      
      

        My.Settings.DisableSizeChangedEventChecks = false
        My.Settings.DisableLegacyServices = True
        'revert to normalised settings if altered by debugger
       EnableFastCheck.start
        My.Settings.LastCpuModeFriendlyName = "0"
        My.Settings.save

           If My.Settings.SafemodeEnabled = True Then
            Button2.Location = New Point(4, 79)
            Me.Text = Me.Text & " - Safemode is enabled"
               CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "SAFEMODE: Application has started with safemode conditions."
        Call CoreForm.errorLoggingSystem
            CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "SAFEMODE: Application has started with safemode conditions."
              Call CoreForm.errorLoggingSystem
            CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "SAFEMODE: Application has started with safemode conditions."
              Call CoreForm.errorLoggingSystem
        Else

        End If
        NotifyIcon1.Text = "AutoPowerModeSwitcher"
     
    End Sub

    Private Sub CheckPowerPlan_Tick(sender As Object, e As EventArgs) Handles CheckPowerPlan.Tick
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "CheckPowerPlan timer ticked. Interval: " + CheckPowerPlan.Interval.ToString + "ms")
        DebugUI.CheckPowerPlanTickCount.Text = DebugUI.CheckPowerPlanTickCount.Text + 1
        Dim currentPowerPlan As String = My.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control").OpenSubKey("Power").OpenSubKey("User").OpenSubKey("PowerSchemes").GetValue("ActivePowerScheme")
        CurrentPowerPlanLabel.Text = currentPowerPlan


        If CurrentPowerPlanLabel.Text = "8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c" Then
         Call applyHighPerformanceConditions

          

        ElseIf CurrentPowerPlanLabel.Text = "381b4222-f694-41f0-9685-ff5bb260df2e" Then
        call applyBalancedConditions


            '     PowerModeBalanced.Checked = True
        ElseIf CurrentPowerPlanLabel.Text = My.Settings.LowFreqGUID Then
            ActivePlanLabel.Text = "Low freq. mode"
            'PowerModeLowFreq.Checked = True

        Elseif currentPowerPlanlabel.Text = "a1841308-3541-4fab-bc81-f71556f20b4a" then
          call  applyPowerSaverConditions

        Else


            ActivePlanLabel.Text = "Unsupported"
            NotifyIcon1.Icon = My.Resources.NotifyIcon_error
            CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "Unsupported powermode detected. APMS may not be able to control it and the core application functions may act unexpectedly."
        Call CoreForm.errorLoggingSystem
        End If

     

        'CheckPowerPlan.Interval = 1750
    End Sub

    Private Sub SetPowerPlan_Tick(sender As Object, e As EventArgs) Handles SetPowerPlan.Tick
        If My.Settings.DisableLegacyServices = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer is no longer used. Disposing...")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer is no longer used. Disposing...")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer is no longer used. Disposing...")

            SetPowerPlan.Dispose()
        Else
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlan timer ticked.Interval: " + SetPowerPlan.Interval.ToString + "ms")
            DebugUI.SetPowerPlanTickCount.Text = DebugUI.SetPowerPlanTickCount.Text + 1
            '////interval should be low as the timer only executed once per call.
            If UserPreferencesModule.EngineMode2.Checked = True Then
                If ConfilictLabel.Text = "True" Then 'if bootoptimizer is running then
                    'do nothing as bootoptimizer is working and they may confilict if working together
                    EngineStatusLabel.Text = "Not running"
                Else
                    'if bootoptimizer isn't working go on and run the code
                    EngineStatusLabel.Text = "Running"
                    If ProcessLabel.Text = "True" Then 'if game is running
                        If GamingModeLowFreq.Checked Then 'if 70 mode selected
                            GamingModeDoNotAlter.Checked = False           'lowfreq mode no longer works for desktop systems.
                            Shell("powercfg /s " + My.Settings.LowFreqGUID, AppWinStyle.Hide)
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to LowFreq.")

                        Else 'if DO NOT ALTER is selected
                            GamingModeLowFreq.Checked = False

                        End If
                    Else 'if not running

                        If PowerModeHighPerf.Checked Then 'if high performance mode is requested by user
                            PowerModeBalanced.Checked = False
                            Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide)
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to high performance.")


                        Else 'if balanced is requested
                            PowerModeHighPerf.Checked = False
                            Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide)
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Set system's powermode to Balanced")
                        End If
                    End If

                    SetPowerPlan.Stop() 'so this makes the code only execute ONCE per call
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Stopped SetPowerPlan engine.")
                    'BUG Stopping engine will cause system instability as (rapidly) changing powermodes from control panel will make app and system show different values from each other

                End If
            Else
            End If
        End If
      
    End Sub

    Private Sub ProcessCheck_Tick(sender As Object, e As EventArgs) Handles ProcessDetector.Tick

        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ProcessCheck timer ticked. Interval: " + ProcessDetector.Interval.ToString + "ms")
        DebugUI.ProcessDetectorTickCount.Text = DebugUI.ProcessDetectorTickCount.Text + 1
        If My.Settings.AllowPowermodeControl = False Then
            Else
             Dim p() As Process
        p = Process.GetProcessesByName(TargetProcessBox.Text)
        If p.Count > 0 Then
            ProcessLabel.Text = "True"       ' Process is running
            If CurrentGameLabel.Text = "NULL" Then

                CurrentGameLabel.Text = TargetProcessBox.Text
            Else

            End If
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is now running.")
        Else
            ProcessLabel.Text = "False"  ' Process is not running
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Target process is NOT running.")
            CurrentGameLabel.Text = "NULL"
        End If
   End If
    End Sub
 
       
    Private Sub FormSizeControl_Tick(sender As Object, e As EventArgs) Handles FormSizeControl.Tick
        'NO LONGER IN-USE
        'Instead of a timer the app now watches SizeChanged event
        'FormHeightLabel.Text = Height
        'Width = 315
        'If FormHeightLabel.Text > 416 Then
        'Height = 416
        '-REMOVED size changed counter 
        ' SIZECHANGEDCOUNTER.Text = SIZECHANGEDCOUNTER.Text + 1 
        'Else

        'End If
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: FormSize Control timer ticked. THIS TIMER SHOULD NOT TICK. CHECK!!!!!")
         CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: ."
        Call CoreForm.errorLoggingSystem
    End Sub
   

    Private Sub ProcessLabel_TextChanged(sender As Object, e As EventArgs) Handles ProcessLabel.TextChanged
        'SetPowerPlan.start() 'so when the process running status changed powermode will be set
        If ProcessLabel.Text = "True" Then
            declareTargetProcessAsRunning()
            Label28.Visible = True
            Call changePowerMode
        Else
            Label28.Visible = False
             Call changePowerMode
            declareTargetProcessAsRunningValue = False

        End If
        If My.Settings.TaskManagerEnabled = True Then 'if user enabled game booster
            If UserPreferencesModule.KillProcessesCheckBox.Checked = True Then 'if user enabled game booster
                If ProcessLabel.Text = "True" Then 'if game is running (in this code snippet it acts as if game started)

                    'killer code here
                 
                    Shell("taskkill -f /im LiveUpdate.exe", AppWinStyle.Hide)
                    Shell("taskkill -f /im Rainmeter.exe", AppWinStyle.Hide)
                   
                  
                    Shell("taskkill -f /im UninstallMonitor.exe", AppWinStyle.Hide)
           
                   
                    Shell("taskkill -f /im IDMan.exe", AppWinStyle.Hide)
                    Shell("taskkill -f /im IEMonitor.exe", AppWinStyle.Hide)
             
    
             
                   ' Shell("taskkill -f /im spoolsv.exe", AppWinStyle.Hide)
                    'If UserPreferencesModule.PrioritizeTargetProcessCheckBox.Checked = True Then instead of checking UserPreferencesModule check my.settings
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "TaskManager: Killed processes as the user checked KillProcessesCheckBox.")
                    If My.Settings.TaskManagerPrioritize = True Then

                        Dim psList() As Process
                        Try
                            psList = Process.GetProcesses()
                            For Each p As Process In psList
                                If p.ProcessName = TargetProcessBox.Text + ".exe" Then
                                    p.PriorityClass = ProcessPriorityClass.High
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Prioritized target process as the user checked TaskManagerPrioritize checkbox.")
                                End If
                            Next p
                        Catch
                             CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "pslist failed to prioritize target process."
        Call CoreForm.errorLoggingSystem
                        End Try
                    End If
                Else
                    If Label30.Text < 1 Then
                        Label30.Text = Label30.Text + 1
                        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Bug fixer code had been executed just now. Skipped RestartAfterSession as a result. (Value is < 1)")
                    Else

                        If UserPreferencesModule.RestartAfterSessionCheckBox.Checked = True Then
                            NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher"
                            NotifyIcon1.BalloonTipText = "You have quit the game. APMS is restoring your system to its normal conditions"
                            NotifyIcon1.ShowBalloonTip(2800)
                            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "End of game session. Restarting killed processes.")
                            ' Dim OneDrive() As Process
                            'OneDrive = Process.GetProcessesByName("OneDrive")
                            'If OneDrive.Count > 0 Then   ' Process is running
                            'Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "OneDrive is already running, no need to restart.")
                            'Else      ' Process is not running

                            'Try
                            ' Process.Start("C:\Users\cspr\AppData\Local\Microsoft\OneDrive\OneDrive.exe /background")
                            'Dim proc As New ProcessStartInfo
                            'proc.UseShellExecute = True
                            'proc.FileName = "C:\Users\cspr\AppData\Local\Microsoft\OneDrive\OneDrive.exe"
                            '        proc.Verb = "runas"
                            'proc.Arguments = "/background"
                            'Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "OneDrive is started successfully.")
                            ' Catch ex As Exception
                            'Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "OneDrive process cannot be started. Probably executable not found")
                            'End Try
                            'End If


                            Dim Rainmeter() As Process
                            Rainmeter = Process.GetProcessesByName("Rainmeter")
                            If Rainmeter.Count > 0 Then   ' Process is running
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Rainmeter is already running, no need to restart.")
                            Else      ' Process is not running

                                Try
                                    Process.Start("C:\Program Files\Rainmeter\Rainmeter.exe")
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Rainmeter is started successfully.")
                                Catch ex As Exception
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Rainmeter process cannot be started. Probably executable not found")
                                End Try

                            End If

                            Dim Dropbox() As Process
                            Dropbox = Process.GetProcessesByName("Dropbox")
                            If Dropbox.Count > 0 Then   ' Process is running
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Dropbox is already running, no need to restart.")
                            Else      ' Process is not running

                                Try
                                    Process.Start("C:\Program Files (x86)\Dropbox\Client\Dropbox.exe", "/systemstartup")
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Dropbox is started successfully.")
                                Catch ex As Exception
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Dropbox process cannot be started. Probably executable not found")
                                End Try

                            End If

                            Dim iCloud() As Process
                            iCloud = Process.GetProcessesByName("iCloud")
                            If iCloud.Count > 0 Then   ' Process is running
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "iCloud is already running, no need to restart.")
                            Else      ' Process is not running
                                Try
                                    Process.Start("C:\Program Files (x86)\Common Files\Apple\Internet Services\iCloudServices.exe")
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "iCloudServices process is started successfully.")
                                Catch ex As Exception
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "iCloudServices process cannot be started. Probably executable not found")
                                End Try

                            End If

                            Dim Lightshot() As Process
                            Lightshot = Process.GetProcessesByName("Lightshot")
                            If Lightshot.Count > 0 Then   ' Process is running
                                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Ligtshot is already running, no need to restart.")
                            Else      ' Process is not running

                                Try
                                    Process.Start("C:\Program Files (x86)\Skillbrains\lightshot\Lightshot.exe")
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Lightshot is started successfully.")
                                Catch ex As Exception
                                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Lightshot process cannot be started. Probably executable not found")
                                End Try
                            End If

                        Else

                        End If




                    End If


                End If
            End If
        Else

        End If
    End Sub
    Private Sub MemoryOptimizer_Tick(sender As Object, e As EventArgs) Handles MemoryOptimizer.Tick
        DebugUI.MemOptimizerTickCount.Text = DebugUI.MemOptimizerTickCount.Text
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "MemoryOptimizer engine ticked.")
        ''SetPowerPlan.start() 'execute powermode switcher codes every 60 (was 30) seconds
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
     
        My.Settings.AllowQuit= True
             My.Settings.Save()
        AllowQuit.Text = "True"
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User requested termination with an toolstip item. Allowing...")
       ' Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminating application because AllowQuit returned True.")
       ' Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Terminated application.")
    Close()

    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If Visible = True Then
            Hide()
            '   ToolStripMenuItem1.Text = ("Show App")
        Else
            Show()
            '  ToolStripMenuItem1.Text = ("Hide App")
        End If
    End Sub

    Private Sub BootOptimizerConflictFixer_Tick(sender As Object, e As EventArgs) Handles BootOptimizerConflictFixer.Tick
        'Keep this disabled as we no longer use BootOptimizer
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "BootOptimizer Confilict fixer timer ticked!.")
        Dim p() As Process
        p = Process.GetProcessesByName("BootOptimizer")
        If p.Count > 0 Then
            ConfilictLabel.Text = "True"       ' BootOptimizer is running

            If TimesHidden.Text > 3 Then 'hide form if bootoptimizer is running (pc has just started)

            Else
                Hide()
                TimesHidden.Text = TimesHidden.Text + 1
            End If

        Else
            ConfilictLabel.Text = "False"  ' Bootoptimizer is not running
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        If DebugUI.CheckBox24.Checked = True Then
            MsgBox("User control is disabled. Check settings for more info")
        Else
            TargetProcessBox.Text = "GTA5"
            TargetProcessBox.Enabled = True
        End If

    End Sub

    Private Sub SettingsEngine_Tick(sender As Object, e As EventArgs) Handles SettingsEngine.Tick
        'this timer checks your actions and saves them as a setting to load on next startup of app
        'this timer ticks every 360 seconds to save your preferences AUTOMATICLY
        If My.Settings.DisableLegacyServices = True Then
            SettingsEngine.Stop()
        Else
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Settings saver timer ticked. Interval: " + SettingsEngine.Interval.ToString + "ms")
            If PowerModeHighPerf.Checked Then My.Settings.PreferredPowerModeEqualsBalanced = False
            If PowerModeBalanced.Checked Then My.Settings.PreferredPowerModeEqualsBalanced = True
            If GamingModeLowFreq.Checked Then My.Settings.GamingPowerModeEquals70Freq = True
            If GamingModeDoNotAlter.Checked Then My.Settings.GamingPowerModeEquals70Freq = False
            If UserPreferencesModule.Interval1.Checked Then My.Settings.CheckInvertalEqualsFrequent = True
            If UserPreferencesModule.Interval2.Checked Then My.Settings.CheckInvertalEqualsFrequent = False
            My.Settings.TargetProcess = TargetProcessBox.Text
            If UserPreferencesModule.StartonBoot.Checked = True Then
                My.Settings.StartOnBootEnabled = True
            Else
                My.Settings.StartOnBootEnabled = False
            End If
            If UserPreferencesModule.StartMinimized.Checked = True Then
                My.Settings.StartMinimized = True
            Else
                My.Settings.StartMinimized = False
            End If
            If UserPreferencesModule.TopMostCheckbox.Checked = True Then
                My.Settings.TopMost = True
            Else
                My.Settings.TopMost = False
            End If

            My.Settings.Save()
            SettingsEngine.Stop()

        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


        If AllowQuit.Text = "True" Then 'if user tried to exit app via taskbar icon then let user exit
            'APPLICATION IS BEING TERMINATED!

            'e.Cancel = true
            My.Settings.AllowQuit = True
            My.Settings.Save()
            If overflowCurseBlocker.Text > 2 Then

            Else
                 Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked X button. Application is preparing to shutdown because AllowQuit returned True")
                overflowCurseBlocker.Text =  overflowCurseBlocker.Text + 1
                Call writeDatabase
                NotifyIcon1.Visible = False



                NotifyIcon1.Visible = False
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saving user preferences and shutting down.")
            My.Settings.Save()
            
            CoreForm.close
            Threading.Thread.Sleep(200)


                UserPreferencesModule.Close
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Goodbye!!")
                Application.Exit()
            End If
            



        Else 'if user clicked X button DO NOT LET user to exit app instead Hide the app and notify the user about it
            e.Cancel = True

            If My.Settings.FirstTimeClosing = True Then
               ' MsgBox("Clicking 'X' button only minimizes the app to the taskbar for the best user experience. If you want to terminate the app right click on the icon on the notification bar and click exit. This help message is won't be shown again.",MsgBoxStyle.OkOnly, "AutoPowerModeSwitcher TIP")
                NotifyIcon1.BalloonTipText = "Application is still running in the background, right click notification and click on 'Exit' to quit."
                NotifyIcon1.BalloonTipTitle = "APMS is minimized to taskbar"
                NotifyIcon1.ShowBalloonTip(3000)
                My.Settings.FirstTimeClosing = False
                My.Settings.Save()
                Hide()
                GameList.close
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing notification= " + NotifyIcon1.BalloonTipTitle.ToString)
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked X button. Application is minimized because AllowQuit returned False.")
            Else
                'NotifyIcon1.BalloonTipText = "Application is still running in the background"
                'NotifyIcon1.BalloonTipTitle = "APMS is minimized to taskbar"
                'NotifyIcon1.ShowBalloonTip(3000)
                Hide()
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked X button. Application is minimized because AllowQuit returned False.")
            End If


        End If

    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
        'this sub itself does nothing
    End Sub
    Private Sub StartMinimized_Tick(sender As Object, e As EventArgs) Handles StartMinimized.Tick
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "StartMinimized timer ticked.")
        If My.Settings.StartMinimized = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Application Started Minimized!")
            UserPreferencesModule.StartMinimized.Checked = True
            Hide()
            'NotifyIcon1.BalloonTipText = "Application is started minimized according to your preferences, you can change this on settings menu."
            'NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher is working in background"
            'NotifyIcon1.ShowBalloonTip(3000)
        Else

            UserPreferencesModule.StartMinimized.Checked = False
        End If
        StartMinimized.Stop() 'run once per call (only being called on app startup)
    End Sub
    Private Sub ContextEngine_Tick(sender As Object, e As EventArgs) Handles ContextEngine.Tick
        'if me.visible = true then
        'ToolStripMenuItem1.Text = "Hide app"
        '   Else 
        'ToolStripMenuItem1.Text = "Show app"
        'End If
        'no longer used
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        UserPreferencesModule.Show()
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User clicked settings button.")
    End Sub

    Private Sub SetPowerPlanAlternate_Tick(sender As Object, e As EventArgs) Handles SetPowerPlanAlternate.Tick
        '######################### THIS TIMER SHOULD NOT BE USED ANYMORE #################################
        If My.Settings.DisableLegacyServices = True Then

            SetPowerPlanAlternate.Dispose()

        Else

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "SetPowerPlanAlternate timer ticked.")
            '  If UserPreferencesModule.EngineMode1.Checked = True Then
            DebugUI.SetPowerPlanAlternateTickCount.Text = DebugUI.SetPowerPlanAlternateTickCount.Text + 1
            If My.Settings.CoreEngineModeEqualsOptimized = False Then


                If ConfilictLabel.Text = "True" Then 'if bootoptimizer is running then
                    'do nothing as bootoptimizer is working and they may confilict if working together
                    EngineStatusLabel.Text = "Not running"
                Else
                    'if bootoptimizer isn't working go on and run the code
                    EngineStatusLabel.Text = "Running"
                    If ProcessLabel.Text = "True" Then 'if game is running
                        If GamingModeLowFreq.Checked Then 'if 70 mode selected
                            GamingModeDoNotAlter.Checked = False
                            Shell("powercfg /s " + My.Settings.LowFreqGUID, AppWinStyle.Hide)


                        Else 'if DO NOT ALTER is selected
                            GamingModeLowFreq.Checked = False

                        End If
                    Else 'if not running

                        If PowerModeHighPerf.Checked Then 'if high performance mode is requested by user
                            PowerModeBalanced.Checked = False
                            Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide)



                        Else 'if balanced is requested
                            PowerModeHighPerf.Checked = False
                            Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide)
                        End If
                    End If

                    ' SetPowerPlan.Stop() 'so this makes the code only execute ONCE per call
                    'BUG Stopping engine will cause system instability as (rapidly) changing powermodes from control panel will make app and system show different values from each other

                End If

            Else
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Core engine mode is set in the Optimized mode. Stopping SetPowerPlanAlternate engine.")
                SetPowerPlanAlternate.Stop()

            End If
        End If




    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        UserPreferencesModule.Show()
    End Sub


    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ContextMenuStrip has been opened.")
        If ToolStripMenuItem3.Text.Contains("wait") Then

            CheckPowerPlan.Interval = 1
            Threading.Thread.Sleep(5)


        End If
    End Sub

    Private Sub SetToHighPerfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetToHighPerfToolStripMenuItem.Click
        Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide)
        NotifyIcon1.BalloonTipText = "Set powermode to High Performance!"
        NotifyIcon1.BalloonTipTitle = "APMS Quick Setting Toggle"
        NotifyIcon1.ShowBalloonTip(100)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick Setting Toggle, Set powermode to High Performance")
    End Sub


    Private Sub SetPowermodeToBalancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPowermodeToBalancedToolStripMenuItem.Click
        Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide)
        NotifyIcon1.BalloonTipText = "Set powermode to Balanced!"
        NotifyIcon1.BalloonTipTitle = "APMS Quick Setting Toggle"
        NotifyIcon1.ShowBalloonTip(100)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick Setting Toggle, Set powermode to Balanced")
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then
            ToolStripMenuItem1.Text = "Hide app"
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's visibility changed. It's visible.")
        Else
            ToolStripMenuItem1.Text = "Show app"
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's visibility changed. It's NOT visible.")
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If My.Settings.DisableSizeChangedEventChecks = True Then 'do not alter user's size. debug flag

            FormHeightLabel.Text = "Disabled by policy"

        Else
            Dim formHeight As Integer  = My.Settings.UI_DefaultHeight
            Dim formWidth As Integer = My.Settings.UI_DefaultWidth
            Dim formMaxHeight As Integer = My.Settings.UI_MaxHeight
            Dim formMaxWidth As Integer = My.Settings.UI_MaxWidth
        Dim formMinHeight As Integer = My.Settings.UI_MinHeight
            FormHeightLabel.Text = Height
        FormWidthLabel.Text = Width
        'new allowed size = 608,300
       
            If FormWidthLabel.Text > formMaxWidth Then
                Width = formMaxWidth
  
            Else

            End If
            ' Width = 315
            If FormHeightLabel.Text > formMaxHeight Then
                Height = formMaxHeight

                If ConsoleFloodCounter.Text > 8 Then
                     ConsoleFloodCounter.Text =  ConsoleFloodCounter.Text - 1
                Else
                      Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's size changed. It was over max limit and set to the allowed max size. (" & formHeight & ")")
                     ConsoleFloodCounter.Text =  ConsoleFloodCounter.Text + 2
                End If
             
                '-REMOVED size changed counter 
                ' SIZECHANGEDCOUNTER.Text = SIZECHANGEDCOUNTER.Text + 1 
            Else 'MIN VALUE
                If FormHeightLabel.Text < formMinHeight Then
                  Height = formMinHeight

                     If ConsoleFloodCounter.Text > 8 Then
                     ConsoleFloodCounter.Text =  ConsoleFloodCounter.Text - 1
                Else
                    Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Main Form's size changed. It was over min limit and set to the allowed min size. (unmeasured)")
                         ConsoleFloodCounter.Text =  ConsoleFloodCounter.Text + 2
                    End If

                        Else

                End If

            End If

        End If

        

        If FormWidthLabel.Text < 310 Then 'MIN VALUE
            Width = 310
        End If
      
       
    End Sub


    Private Sub FreeSpaceChecker_Tick(sender As Object, e As EventArgs) Handles FreeSpaceChecker.Tick
        If My.Settings.UserTrackingEnabled = True Then
            If My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace.ToString() > FreeSpaceLabel.Text Then
                IOLabel.Text = "INCR"
                IOLabel.ForeColor = Color.Green
            ElseIf My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace.ToString() = FreeSpaceLabel.Text Then
                IOLabel.Text = "EQUAL"
                IOLabel.ForeColor = Color.Purple
            Else
                IOLabel.Text = "DECR"
                IOLabel.ForeColor = Color.Purple
            End If
            FreeSpaceLabel.Text = My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace.ToString() + " bytes"


        Else
            FreeSpaceChecker.Dispose()
            FreeSpaceLabel.Text = "Disabled by user"
            IOLabel.Text = "NONE"
            IOLabel.ForeColor = Color.Red

        End If

    End Sub

    Private Sub AutoPilotStatus_TextChanged(sender As Object, e As EventArgs) Handles AutoPilotStatus.TextChanged
     Call AutoPilotController
    End Sub


    Private Sub CPUTracker_Tick(sender As Object, e As EventArgs) Handles CPUTracker.Tick
        If My.Settings.UserTrackingEnabled = True Then
            CPUUsageLabel.Text = (CInt(m_PerformanceCounter.NextValue())
             )
        Else
            CPUTracker.Dispose()
            CPUUsageLabel.Text = "Disabled by user"

        End If


    End Sub

    Private Sub CPUUsageLabel_TextChanged(sender As Object, e As EventArgs) Handles CPUUsageLabel.TextChanged

        Try
            If CPUUsageLabel.Text > 99 Then

                NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher"
                NotifyIcon1.BalloonTipText = "Warning: CPU usage is too high if you are not running any CPU-demanding apps at the time and still seeing this, your PC may be infected by a malware."
                NotifyIcon1.ShowBalloonTip(25000)
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: CPU utilization is over 99 percentage.")
            End If
        Catch ex As Exception 'its not critical and is caused when user disables cpu tracking. conversion from string to double is not vaild.
         '   Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Exception occured while measuring CPU usage.")
          '   CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "An error occured while measuring CPU usage percentage. Exception details: " & ex.ToString
        'Call CoreForm.errorLoggingSystem
        End Try

    End Sub



    Private Sub EnvTickCounter_Tick(sender As Object, e As EventArgs) Handles EnvTickCounter.Tick
        If My.Settings.UserTrackingEnabled = True Then
            EnvironmentTickCount.Text = Environment.TickCount
        Else
            EnvTickCounter.Dispose()
            EnvironmentTickCount.Text = "Disabled by user"

        End If

    End Sub
    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        If My.Settings.UserTrackingEnabled = True Then
            FormLocationLabel.Text = Location.ToString
        Else
            FormLocationLabel.Text = "Disabled by user"

        End If

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        CoreForm.Show()

    End Sub

    Private Sub TargetProcessBox_TextChanged(sender As Object, e As EventArgs) Handles TargetProcessBox.TextChanged
        If TargetProcessBox.Text.Contains(".exe") Then
            TargetProcessBox.Text = ""
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User typed an extension in the target process box. Reset.")
        Else
            My.Settings.TargetProcess = TargetProcessBox.Text
            My.Settings.Save()
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "New target registered")
        End If
    End Sub

    Private Sub Label28_VisibleChanged(sender As Object, e As EventArgs) Handles Label28.VisibleChanged
       If Visible = True Then
            declareTargetProcessAsRunning
            Else
            declareTargetProcessAsRunningValue = false
       End If
    End Sub

    Private Sub TargetProcessBox_Leave(sender As Object, e As EventArgs) Handles TargetProcessBox.Leave
        My.Settings.TargetProcess = TargetProcessBox.Text
        My.Settings.Save()
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved target process value")
    End Sub

    Private Sub TargetProcessBox_EnabledChanged(sender As Object, e As EventArgs) Handles TargetProcessBox.EnabledChanged
        My.Settings.TargetProcess = TargetProcessBox.Text
        My.Settings.Save()
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved target process value")
    End Sub

    Private Sub ShowAutoPowerSwitcherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAutoPowerSwitcherToolStripMenuItem.Click
        AutoPowerSwitcher.Show()
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Showing AutoPowerSwitcher")
    End Sub
    Private Sub NotifyIcon1_BalloonTipShown(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipShown
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notification is being displayed at the moment. The notification text is: " + NotifyIcon1.BalloonTipText.ToString)
    End Sub

    Private Sub NotifyIcon1_BalloonTipClosed(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClosed
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notification is no longer being displayed.")
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User paid attention and clicked on the notification.")
        If ActivePlanLabel.text.Contains("High") Then
            If BallonTipClickActionByte.text = "0" Then 
            Show()
  Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Click action: Only show APMS")
        Else
            show()
            EnableFastCheck.start
        Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide)
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to Balanced from the notification")
     call memorizePowerPlan
                  Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Click action: Change powermode to Balanced.")
            hide

               NotifyIcon1.BalloonTipTitle = "Greenified Your System"
                            NotifyIcon1.BalloonTipText = "Thanks for paying attention, we have set your powermode to Balanced."
                            NotifyIcon1.ShowBalloonTip(1000)
            BallonTipClickActionByte.Text = "0"
                
        End If
            Else
           BallonTipClickActionByte.text = "0" 
            Show()
            
        End If
        
    End Sub

    Private Sub ActivePlanLabel_TextChanged(sender As Object, e As EventArgs) Handles ActivePlanLabel.TextChanged, Label38.TextChanged
     
        If ActivePlanLabel.Text.Contains("Balanced") Then
             ToolStripMenuItem3.Text = "Current: Balanced"
            ElseIf ActivePlanLabel.Text.Contains("High") Then
               ToolStripMenuItem3.Text = "Current: HighPerf"
             ElseIf ActivePlanLabel.Text.Contains("Freq") Then
               ToolStripMenuItem3.Text = "Currently Gaming!"
             ElseIf ActivePlanLabel.Text.Contains("Save") Then
            ToolStripMenuItem3.Text = "Current: PowerSaver"
        Else
            ToolStripMenuItem3.Text = "Current: Unsupported"
        End If
               Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ContextMenu ActivePlanLabel has been changed. Is now set to: " & ToolStripMenuItem3.text)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles FormWidthLabel.Click, Label5.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        DebugUI.Show()

    End Sub

    Private Sub FreeSpaceLabel_Click(sender As Object, e As EventArgs) Handles FreeSpaceLabel.Click

    End Sub

    Private Sub IOLabel_Click(sender As Object, e As EventArgs) Handles IOLabel.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PowerModeHighPerf_CheckedChanged(sender As Object, e As EventArgs) Handles PowerModeHighPerf.CheckedChanged
        My.Settings.PreferredCPUModeAsByte = 0
        My.Settings.Save()


    End Sub

    Private Sub PowerModeBalanced_CheckedChanged(sender As Object, e As EventArgs) Handles PowerModeBalanced.CheckedChanged
        My.Settings.PreferredCPUModeAsByte = 1
        My.Settings.Save()


    End Sub

    Private Sub PowerModeBattery_CheckedChanged(sender As Object, e As EventArgs) Handles PowerModeBattery.CheckedChanged
        My.Settings.PreferredCPUModeAsByte = 2
        My.Settings.Save()


    End Sub

    Private Sub CurrentGameLabel_TextChanged(sender As Object, e As EventArgs) Handles CurrentGameLabel.TextChanged
        If CurrentGameLabel.Text = "NULL" Then
            CurrentGameLabel.Visible = Not True
            Label12.Visible = Not True
        Else
            CurrentGameLabel.Visible = True
            Label12.Visible = True

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    

    Private Sub Label12_VisibleChanged(sender As Object, e As EventArgs) Handles Label12.VisibleChanged
        If Label12.Visible = True Then
            Label26.Visible = false
        Else
            Label26.Visible = not false
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        GameList.show
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles buttonquicksetBalanced.Click

        EnableFastCheck.start
        Shell("powercfg /s 381b4222-f694-41f0-9685-ff5bb260df2e", AppWinStyle.Hide)
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to Balanced from the UI")
     call memorizePowerPlan
   
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles buttonquicksetPerformance.Click

        EnableFastCheck.start
        Shell("powercfg /s 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c", AppWinStyle.Hide)     
                      Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to High Performance from the UI")
    call memorizePowerPlan
             HighPerformanceWarning.Stop
 HighPerformanceWarning.start
  
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles buttonquicksetPowerSave.Click

        EnableFastCheck.start
        Shell("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a", AppWinStyle.Hide)
                      Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick power mode set to PowerSaver from the UI")
        call memorizePowerPlan
     
    End Sub

    Private Sub PowerSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PowerSaveToolStripMenuItem.Click
          Shell("powercfg /s a1841308-3541-4fab-bc81-f71556f20b4a", AppWinStyle.Hide)
         NotifyIcon1.BalloonTipText = "Set powermode to Power Saver!"
        NotifyIcon1.BalloonTipTitle = "APMS Quick Setting Toggle"
        NotifyIcon1.ShowBalloonTip(100)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Quick Setting Toggle, Set powermode to Power Saver")
    End Sub

    Private Sub EnableFastCheck_Tick(sender As Object, e As EventArgs) Handles EnableFastCheck.Tick
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "ENABLED FAST CHECK")
        CheckPowerPlan.Interval = My.Settings.FastCheckConditionCheckPowerModeEngineInterval
        FastCheckDeadline.start
        EnableFastCheck.dispose
    End Sub

    Private Sub DisableFastCheck_Tick(sender As Object, e As EventArgs) Handles FastCheckDeadline.Tick
           Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DISABLED FAST CHECK")
        Dim normalisedinterval As Integer =  My.Settings.CheckPowerPlanInterval
        CheckPowerPlan.Interval = normalisedinterval
        FastCheckDeadline.stop
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox2.Checked = False
        Height = My.Settings.UI_DefaultHeight
        Width = My.Settings.UI_DefaultWidth
    End Sub

    Private Sub CheckBox3_CheckedChanged_2(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            My.Settings.DisableSizeChangedEventChecks = True
            Else
             My.Settings.DisableSizeChangedEventChecks = not True
            Height = Height + 1
        End If
    End Sub
    Private Sub NotifyFunctionEngine_Tick(sender As Object, e As EventArgs) Handles NotifyFunctionEngine.Tick
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "NotifyFunctionEngine ticked!")

        If NotifyFunctionCounter.Text = 1 Then
            NotifyIcon1.BalloonTipText = "APMS QuickPowerMode Display"
        NotifyIcon1.BalloonTipTitle = "Current powerplan is " & ActivePlanLabel.Text & "!"
        NotifyIcon1.ShowBalloonTip(1)
            notifyFunctionCounter.Text = 0
        Elseif NotifyFunctionCounter.Text > 1 Then

          

        TopMost = True
              Me.show
        Threading.Thread.Sleep(5)

        TopMost = False
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User double-clicked the notifyicon from taskbar")
             notifyFunctionCounter.Text = 0
           
        End If

        NotifyFunctionEngine.Stop()

    End Sub

    Private Sub NotifyFunctionCounter_TextChanged(sender As Object, e As EventArgs) Handles NotifyFunctionCounter.TextChanged
        NotifyFunctionEngine.start
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick

        If e.Button = MouseButtons.Left then
 
 NotifyFunctionCounter.Text =  NotifyFunctionCounter.text + 1
        Else
            
  End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
          If e.Button = MouseButtons.Left then
   NotifyFunctionCounter.Text =  NotifyFunctionCounter.text + 2
        Else

  End If
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("To disable safemode, head to the CoreForm and read the instructions.")

    End Sub

    Private Sub HighPerformanceWarning_Tick(sender As Object, e As EventArgs) Handles HighPerformanceWarning.Tick
        If declareTargetProcessAsRunningvalue = false Then 'user not in game
            if ActivePlanLabel.Text.Contains("High") Then
             BallonTipClickActionByte.Text = "1"
                NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher"
                            NotifyIcon1.BalloonTipText = "It's been 30 minutes since you've activated High Performance mode. Current energy usage is very high. You may have forgot it on, do you want to toggle it off?" 'too long for Win10 Environment
                            NotifyIcon1.ShowBalloonTip(6000)
          ResetNotificationBuffer.start

                Else
                 BallonTipClickActionByte.Text = "0" 'powermode is NOT high perf
            End If
            Else
            'user is in game
              BallonTipClickActionByte.Text = "0"
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) 
        Shell("C:\Program Files\iTunes\iTunes.exe", AppWinStyle.Hide)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) 
        Shell("C:\Program Files\iTunes\iTunes.exe", AppWinStyle.MinimizedFocus)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
         Shell("C:\Program Files\iTunes\iTunes.exe", AppWinStyle.MinimizedNoFocus)
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
         Shell("C:\Program Files\iTunes\iTunes.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
         Shell("C:\Program Files\iTunes\iTunes.exe", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        NotifyIcon1.Icon = My.Resources.NotifyIcon_balanced
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        NotifyIcon1.Icon = My.Resources.NotifyIcon_HighPerformance
   
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
       MsgBox( UserPreferencesModule.gamedetectioncollection.Items.Count.tostring )
    End Sub

    Private Sub memorizePowerPlanEngine_Tick(sender As Object, e As EventArgs) Handles memorizePowerPlanEngine.Tick
         MemorizedPowerModeLabel.Text =  ActivePlanLabel.Text 
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Memorized user's preferred powermode. Value is: " & MemorizedPowerModeLabel.text)
        memorizePowerPlanEngine.stop
    End Sub

    Private Sub AllowPowermodeControl_CheckedChanged(sender As Object, e As EventArgs) Handles AllowPowermodeControl.CheckedChanged
         if AllowPowermodeControl.checked = True Then
            My.Settings.AllowPowermodeControl = True
            Else
  My.Settings.AllowPowermodeControl = false 
            End If
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        startBenchmarking
        Dim i As integer = 0
       
               
                Do Until i = 7250

                i = i + 1
             Label47.Text = i
        Loop
                 stopBenchmarking
        call msgboxBenchmarkValue
        End Sub

    Private Sub RuntimeTimingEngine_Tick(sender As Object, e As EventArgs) Handles RuntimeBenchmarkEngine.Tick


                If allowBenchmarking = True Then
        
        RuntimeBenchmarkOutput.Text = RuntimeBenchmarkOutput.Text.Replace("Runtime Timer: ", "")
        RuntimeBenchmarkOutput.Text = RuntimeBenchmarkOutput.Text.Replace("ms", "")
         RuntimeBenchmarkOutput.Text =  RuntimeBenchmarkOutput.Text + 1
       Dim newVal As integer =  RuntimeBenchmarkOutput.Text
         RuntimeBenchmarkOutput.Text = "Runtime Timer: " & newVal & "ms"

        Else
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "RuntimeBenchmarkEngine is called but flag allowBenchmarking is false! Cannot start benchmarking now.")
        End If
      
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        startBenchmarking
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        stopBenchmarking
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        HighPerformanceWarning.Interval = 15000
        MsgBox("HighPerformanceWarning.Interval = 15000",MsgBoxStyle.Information, "Set!")
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
           NotifyIcon1.BalloonTipTitle = "AutoPowerModeSwitcher debug"
                            NotifyIcon1.BalloonTipText = "debug, it is."
                            NotifyIcon1.ShowBalloonTip(2800)
    End Sub

    Private Sub BallonTipClickActionByte_TextChanged(sender As Object, e As EventArgs) Handles BallonTipClickActionByte.TextChanged
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Notification click action has just been changed. New action byte is: " & BallonTipClickActionByte.Text)
    End Sub

    Private Sub ResetNotificationBuffer_Tick(sender As Object, e As EventArgs) Handles ResetNotificationBuffer.Tick
        BallonTipClickActionByte.text = "0"
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Resetting notification buffer! Value BallonTipClickActionByte.text is now 0")
        
        ResetNotificationBuffer.stop

    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
          NotifyIcon1.Dispose

        Label31.Text = Label31.Text + 1
    End Sub

    Private Sub CheckUserBehavior_Tick(sender As Object, e As EventArgs) Handles CheckUserBehavior.Tick
        'My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath & " /onboot")
         Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System is now called.")
        regValueToCheck = "QuickPowerModeSwitcher"
        variable_byte_regexistsaction = 1
        variable_regvaluedoesnotexist = "NAN"
        variable_regvalueexists = "QuickPowerModeSwitcher is running on startup, too. AutoPowerModeSwitcher is a better replacement for it by CryptedBytes. No need to run them both as they MAY conflict to each other and MAY slow down your system, do you want us to disable it?"
        variable_regvalueexiststitle = "Conflict found!"
        variable_regdeletednotifytext =  "We have just disabled QuickPowerModeSwitcher for you."
     CheckUserBehavior.Stop
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Registry Key Checking System variables set.")
        checkRegistryKeys()

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        CheckUserBehavior.Interval = 1000
        CheckUserBehavior.start
    End Sub


End Class
