Public Class MemoryLeakTestingLab
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            PenTest1.start
            ElseIf RadioButton2.Checked = True then
            PenTest2.Start

            ElseIf RadioButton3.Checked = True then
            PenTest3.start
            Elseif RadioButton4.Checked = True then
            PenTest4.start
            Else

            MsgBox("Check at least one vulnerability")
        End If
    End Sub

    Private Sub PenTest1_Tick(sender As Object, e As EventArgs) Handles PenTest1.Tick
        Try
               NotifyIcon1.Visible = true
           NotifyIcon2.Visible = true
            NotifyIcon3.Visible = true
            NotifyIcon4.Visible = true
        NotifyIcon1.Icon = My.Resources.AppIcon
        NotifyIcon1.Icon = My.Resources.NotifyIcon_cpu22
              NotifyIcon2.Icon = My.Resources.AppIcon
        NotifyIcon3.Icon = My.Resources.NotifyIcon_cpu22
            NotifyIcon2.Icon = My.Resources.AppIcon
        NotifyIcon3.Icon = My.Resources.NotifyIcon_cpu22
            NotifyIcon4.Icon = My.Resources.AppIcon
        NotifyIcon4.Icon = My.Resources.NotifyIcon_cpu22
        Catch ex As Exception

        End Try
     
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GC.collect
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PenTest1.Stop
        PenTest3.Stop
        PenTest2.Stop

        NotifyIcon1.Dispose

    End Sub

    Private Sub PenTest2_Tick(sender As Object, e As EventArgs) Handles PenTest2.Tick
        PictureBox1.Image = My.Resources.CryptedBytesLogo
          PictureBox1.Image = My.Resources.tumblr_inline_np9hcuZr931qd3uu5_540
    End Sub

    Private Sub PenTest3_Tick(sender As Object, e As EventArgs) Handles PenTest3.Tick
              Me.Opacity = 50
        Me.Visible = False
        Me.Visible = True
  Me.Opacity = 99

    End Sub

 Shared random As New Random()

    Private Sub PenTest4_Tick(sender As Object, e As EventArgs) Handles PenTest4.Tick
          Dim i As Integer
        For i = 0 To 5
           label1.Text = (Convert.ToString(random.Next(1, 600)))
         
        Next
 Me.Width = Label1.Text
        Me.Height = Label1.text
    End Sub

    Private Sub MemoryLeakTestingLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User entered MemoryLeaksTestingLab.")
    End Sub
End class