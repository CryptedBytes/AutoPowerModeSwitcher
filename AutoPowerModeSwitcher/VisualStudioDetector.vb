Public Class VisualStudioDetector
    Private Sub Engine_Tick(sender As Object, e As EventArgs) Handles Engine.Tick
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "VisualStudio Detector's engine ticked")
        Label3.Text = Label3.Text + 1
        Dim VS() As Process
        VS = Process.GetProcessesByName("AutoPowerModeSwitcher.vshost")
        If VS.Count > 0 Then   ' Process is running

            If Label3.Text <= 1 Then
                Engine.Stop()
                Dispose()

            Else
                Show()
            End If



        Else      ' Process is not running
            Hide()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Environment.Exit(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub HideThisFormEngine_Tick(sender As Object, e As EventArgs) Handles HideThisFormEngine.Tick
        Hide()

        If My.Settings.DisableDeveloperDetectorService = True Then
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "DisableDeveloperDetectorService flag is set to True. Disabled VisualStudioDetector Services.")
            Dispose()
            HideThisFormEngine.Stop()
        Else
            Engine.Start()
            HideThisFormEngine.Stop()
        End If

    End Sub

    Private Sub VisualStudioDetector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Intialized VisualStudioDetector")

    End Sub
End Class