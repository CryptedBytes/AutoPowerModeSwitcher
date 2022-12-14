Public Class BootManager

    Private Sub Engine_Tick(sender As Object, e As EventArgs) Handles Engine.Tick
        ProgressBar1.Increment(1)
          If ProgressBar1.Value = 50 Then

            Shell("C:\Program Files\iTunes\iTunes.exe", AppWinStyle.MinimizedFocus)
     '      Shell("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", AppWinStyle.MinimizedFocus)

            Try
                
            Catch ex As Exception
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "BOOTMANAGER: An exception occured when starting apps. Ex: " + ex.ToString)
            End Try




        End If


        If ProgressBar1.Value = 100 Then
            UserInterface.Show()
            Me.Dispose()



        End If

    End Sub

    Private Sub BootManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Icon = My.Resources.NotifyIcon_cpu22

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.BootManagerEnabled = False
        UserInterface.Show()
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
    End Sub
End Class