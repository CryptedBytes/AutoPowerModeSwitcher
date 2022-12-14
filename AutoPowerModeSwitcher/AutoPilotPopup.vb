Public Class AutoPilotPopup
    Private Sub AutoPilotPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.start
     
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = My.Settings.AutoPilotEnabled
        If Label3.Text = "True" Then
            String1.Text = "AutoPilot is enabled!"
            String2.Text = "We will take care of you!"
            Panel1.Visible = false
            String2.Location = New Point(178, 77)
       
        Else
Panel1.Location = New Point(12, 21)
           
            Panel1.Visible = true
            String1.Text = "AutoPilot is disabled!"
            String2.Text = "Turn it back on for optimal experience!"
             String2.Location = New Point(135, 77)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dispose()
    End Sub

   
End Class