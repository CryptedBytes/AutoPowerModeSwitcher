Public Class DebugUI
    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked = True Then
            UserPreferencesModule.OverrideWarningLabel.Visible = True
            UserInterface.TargetProcessBox.Enabled = False
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DO NOT let user override target process on main form = True")
        Else
            UserInterface.TargetProcessBox.Enabled = True
            UserPreferencesModule.OverrideWarningLabel.Visible = Not True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DO NOT let user override target process on main form = False")
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            UserPreferencesModule.UserTrackingCheckbox.Checked = True
            UserPreferencesModule.UserTrackingCheckbox.Enabled = False
            UserPreferencesModule.OverrideWarningLabel.Visible = True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Now FORCING user-tracking features")
        Else
            UserPreferencesModule.UserTrackingCheckbox.Enabled = Not False
            UserPreferencesModule.OverrideWarningLabel.Visible = Not True
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "No longer forcing user-tracking features")
        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            InstallerModule.Show()
        Else
            InstallerModule.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            BootManagerUXPort.Show()
        Else
            BootManagerUXPort.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If Label14.Text = "True" Then
            If CheckBox8.Checked = True Then
                UserInterface.Show()
            Else
                UserInterface.Dispose()

            End If
        Else

        End If

    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If Label14.Text = "True" Then
            If CheckBox7.Checked = True Then
                CoreForm.Show()
            Else
                CoreForm.Dispose()



            End If
        Else

        End If

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If Label14.Text = "True" Then
            If CheckBox8.Checked = True Then
                UserPreferencesModule.Show()
            Else
                UserPreferencesModule.Dispose()
            End If
        Else
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged

        If CheckBox8.Checked = True Then
            AutoPowerSwitcher.Show()
        Else
            AutoPowerSwitcher.Dispose()


        End If


    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged

        Select Case MsgBox("Are you sure want to reset all the settings?", MsgBoxStyle.YesNo, "CryptedBytes Debugging Interface")
            Case MsgBoxResult.Yes
                My.Settings.Reset()
                My.Settings.Save()

            Case MsgBoxResult.No

        End Select


        CheckBox12.Checked = False

    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        CheckBox11.Checked = False

        Throw New Exception("You have thrown an exception")

    End Sub

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DeveloperForm is loaded into memory.")
        If My.Settings.DisableCoreForm = True Then
            CheckBox14.Checked = True
        Else
            CheckBox14.Checked = Not True

        End If
        Panel1.Location = New Point(12, 291)
        If My.Settings.DisableLegacyServices = True Then
            CheckBox19.Checked = not True
        Else
            CheckBox19.Checked = Not False
        End If

        If My.Settings.GroupPolicyForceAutoPilot = True Then
            CheckBox17.Checked = true
        End If
        If My.Settings.DisableSizeChangedEventChecks = True Then
CheckBox18.Checked = True

        End If
        ' Panel2.Location = New Point(4, 29)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DeveloperForm is intialized.")
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            CheckBox24.Checked = True
        Else
            CheckBox24.Checked = False


        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            CheckBox13.Checked = True
        Else
            CheckBox13.Checked = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles GetOpenForms.Tick
        If Application.OpenForms().OfType(Of UserInterface).Any Then
            CheckBox8.Checked = True
        Else
            CheckBox8.Checked = Not True

        End If
        If Application.OpenForms().OfType(Of CoreForm).Any Then
            CheckBox7.Checked = True
        Else
            CheckBox7.Checked = Not True

        End If
        If Application.OpenForms().OfType(Of UserPreferencesModule).Any Then
            CheckBox6.Checked = True
        Else
            CheckBox6.Checked = Not True

            If Application.OpenForms().OfType(Of AutoPowerSwitcher).Any Then
                CheckBox6.Checked = True
            Else
                CheckBox6.Checked = Not True

            End If
        End If
        Label14.Text = "True"
        GetOpenForms.Stop()
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            BootManager.Show()
        Else
            BootManager.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel2.Dispose()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Debugging.Show()
        Else
            Debugging.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            MemoryLeakTestingLab.Show()
        Else
            MemoryLeakTestingLab.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            My.Settings.DisableCoreForm = True
        Else
            My.Settings.DisableCoreForm = False

        End If
        My.Settings.Save()

    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked Then
            My.Settings.GroupPolicyForceAutoPilot = True
            UserPreferencesModule.userdetect.Checked = True
            UserPreferencesModule.userdetect.Enabled = False
            UserPreferencesModule.usernodetect.Checked = False
            UserPreferencesModule.usernodetect.Enabled = False
        Else
            UserPreferencesModule.userdetect.Checked = False
            UserPreferencesModule.userdetect.Enabled = True
            UserPreferencesModule.usernodetect.Checked = False
            UserPreferencesModule.usernodetect.Enabled = True
            My.Settings.GroupPolicyForceAutoPilot = False

        End If

        My.Settings.Save()


    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel1.Dispose()
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            My.Settings.DisableLegacyServices = False
            MsgBox("My.Settings.DisableLegacyServices = False", MsgBoxStyle.Exclamation, "Boolean Value Set")
        Else
            My.Settings.DisableLegacyServices = True
            MsgBox(" My.Settings.DisableLegacyServices = True", MsgBoxStyle.Exclamation, "Boolean Value Set")
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
                My.Settings.DisableSizeChangedEventChecks = True 
        Else
                My.Settings.DisableSizeChangedEventChecks = false
        End If
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
      

    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        Environment.failfast(1)
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
      
        If CheckBox21.Checked = True Then
               GC.Collect
     MsgBox("Succesful.")
              CheckBox21.Checked = False
            Else

        End If
     
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked = True Then
              CoreForm.errorLoggingText =  DateTime.Now.ToString("dd.MM.yyyy HH:mm.ss") + ": " + "CRITICAL: User thrown an exception" 
Call CoreForm.errorLoggingSystem
            CheckBox22.Checked = False

        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
          MsgBox("Form1's exact size is: " & UserInterface.formheightlabel.Text & " , " & UserInterface.formwidthlabel.text & " and is copied to your clipboard.")
        My.Computer.Clipboard.SetText(UserInterface.formheightlabel.Text & " , " & UserInterface.formwidthlabel.text)
        CheckBox23.Checked = false
    End Sub
End Class