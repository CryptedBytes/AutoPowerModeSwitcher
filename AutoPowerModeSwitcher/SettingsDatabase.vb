Imports AutoPowerModeSwitcher.My

Public Class SettingsDatabase
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TopMost = true

            else
            topmost = false

        End If
    End Sub

    Private Sub Engine_Tick(sender As Object, e As EventArgs) Handles Engine.Tick
        Label1.Text = "TopMost= " & My.Settings.TopMost
        Label2.Text = "CheckInvertalEqualsFrequent= " & My.Settings.CheckInvertalEqualsFrequent
        Label3.Text = "PreferredPowerModeEqualsBalanced= " & My.Settings.PreferredPowerModeEqualsBalanced
        Label4.Text = "GamingPowerModeEquals70Freq= " & My.Settings.GamingPowerModeEquals70Freq
        Label5.Text = "TargetProcessToString= " & My.Settings.TargetProcess
        Label6.Text = "StartOnBootEnabled= " & My.Settings.StartOnBootEnabled
        Label7.Text = "StartMinimized= " & My.Settings.StartMinimized
        Label8.Text = "TopMost= " & My.Settings.TopMost
    End Sub
End Class