Public Class BootManagerUXPort

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)


        animateWin(Me, True)
        End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.PerformClick()

        Timeout.Stop()

            Hide()

        End Sub

        Private Sub Animation_Tick(sender As Object, e As EventArgs) Handles Animation.Tick
            For FadeIn = 0.0 To 1.1 Step 0.1
                Me.Opacity = FadeIn
                Me.Refresh()
                Threading.Thread.Sleep(100)
            Next
            Animation.Stop()

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub
        Public Enum AnimateWindowFlags
            AW_HOR_POSITIVE = &H1
            AW_HOR_NEGATIVE = &H2
            AW_VER_POSITIVE = &H4
            AW_VER_NEGATIVE = &H8
            AW_CENTER = &H10
            AW_HIDE = &H10000
            AW_ACTIVATE = &H20000
            AW_SLIDE = &H40000
            AW_BLEND = &H80000
        End Enum
        Dim f1 As Form
        Public Declare Auto Function AnimateWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimateWindowFlags) As Boolean
        Sub Main()
            Dim xx As Integer = Screen.PrimaryScreen.Bounds.Width - f1.Size.Width
            Dim yy As Integer = Screen.PrimaryScreen.Bounds.Height / 2 - (f1.Size.Height / 2)
            f1.Location = New Point(xx, yy)
            Application.Run(f1)
        End Sub
        Sub animateWin(ByVal frmToAnimate As Form, ByVal showForm As Boolean)
            f1 = frmToAnimate
            If showForm Then
                AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
            Else
                AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_HIDE)
            End If
        End Sub

        Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            animateWin(Me, False)
        End Sub

        Private Sub Engine_Tick(sender As Object, e As EventArgs) Handles Engine.Tick
            Timeout.Stop()

            ProgressBar1.Increment(1)
            If ProgressBar1.Value = 2 Then
                'check if the chrome is started before the app launch 
                Dim p() As Process
                p = Process.GetProcessesByName("chrome.exe")
                If p.Count > 0 Then
                    ProcessLabel.Text = "True"       ' Process is running
                Else
                    ProcessLabel.Text = "False"  ' Process is not running
                End If
            End If
            If ProgressBar1.Value = 3 Then
                If ProcessLabel.Text = True Then
                    'if chrome is already running do not prefect it
                Else
                    Try 'prefect chrome
                    Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
                Catch ex As Exception
                    Debug.WriteLine("BOOTMANAGER: failed to start chrome")
                End Try
            End If


            If CheckBox3.Checked = True Then 'prefect itunes
                Try
                    Process.Start("C:\Program Files\iTunes\iTunes.exe")
                Catch ex As Exception
                    Debug.WriteLine("BOOTMANAGER: failed to start itunes")
                End Try
            Else

            End If
            End If
            If ProgressBar1.Value = 22 Then 'now kill the prefected apps
                If ProcessLabel.Text = True Then
                    'if chrome launched by user before app start do not kill it
                Else
                    Shell("taskkill -f /im chrome.exe", AppWinStyle.Hide)
                End If

            Shell("taskkill -f /im iTunes.exe", AppWinStyle.Hide)
        End If
            If ProgressBar1.Value = 25 Then
            BootManager.Show()
            Me.Close()


        End If
        End Sub

        Private Sub Timeout_Tick(sender As Object, e As EventArgs) Handles Timeout.Tick
            timePast.Text = timePast.Text + 1
            If timePast.Text > 12 Then


            Engine.Start()
            Timeout.Stop()

        End If

            'timeLeft.text = timeLeft.Text - timePast.text

        End Sub

        Private Sub timePast_TextChanged(sender As Object, e As EventArgs) Handles timePast.TextChanged
            timeLeftEngine.Start()

        End Sub

        Private Sub timeLeftEngine_Tick(sender As Object, e As EventArgs) Handles timeLeftEngine.Tick
            timeLeft.Text = timeLeft.Text - 1
            timeLeftEngine.Stop()


        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BootManager.Show()


        Close()
            Engine.Stop()
        End Sub
    End Class
