Public Class PreBootManager
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub



    Private Sub Engine_Tick(sender As Object, e As EventArgs) Handles Engine.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 5 Then
            If CheckBox1.Checked = True Then
                Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
            End If
            If CheckBox2.Checked = True Then
                Process.Start("C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe")
            End If

        End If
    End Sub

    Private Sub PreBootManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("PreBootManager is not supported!")
    End Sub
End Class