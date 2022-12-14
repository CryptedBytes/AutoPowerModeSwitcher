Public Class Debugging

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        SettingsDatabase.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Throw New System.Exception("You have thrown an exception")
    End Sub

 

 

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Settings.Reset()
        My.Settings.Save()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PreBootManager.Show()
        Else
            PreBootManager.Dispose()
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

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            InstallerModule.Show()

        Else
            InstallerModule.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            UserInterface.Show()
        Else
            UserInterface.Dispose()

        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CoreForm.Show()
        Else
            CoreForm.Dispose()



        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox8.Checked = True Then
            UserPreferencesModule.Show()
        Else
            UserPreferencesModule.Dispose()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox8.Checked = True Then
            AutoPowerSwitcher.Show()
        Else
            AutoPowerSwitcher.Dispose()


        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckBox9.Checked = True Then
            Panel1.Dispose()
            DebugUI.Show()
            Close()
        Else
            My.Settings.EnableExperimentalFeatures = False
            My.Settings.Save()

            Dispose()
        End If
        
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        Button6.Text = "Continue"

    End Sub

    Private Sub Debugging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(6, 12)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DebugUI.show()

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
           If CheckBox3.Checked = True Then
            SettingsDatabase.show


        Else
       SettingsDatabase.Dispose()
            GC.Collect()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel1.Visible = false
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel1.Visible = true
    End Sub
End Class