Public Class AutoPowerSwitcher
    Private Sub renderUserLabel

        If userLabel.Text.Contains("0 hours") Then
                userLabel.Text = userLabel.Text.Replace("0 hours,", "")
            End If
            
             If userLabel.Text.Contains("0 minutes") Then
                userLabel.Text = userLabel.Text.Replace("0 minutes ", "")
            End If


         If userLabel.Text.Contains("0 seconds") Then
                userLabel.Text = userLabel.Text.Replace("and 0 seconds, ", "")
            End If
            
             If HourTextbox.Text = "1" then
                userLabel.Text = userLabel.Text.Replace("1 hours", "A hour")
            End If

             If MinuteTextbox.Text = "1" then
                userLabel.Text = userLabel.Text.Replace("1 minutes", "a minute")
            End If

             If SecondTextbox.Text = "1"
                userLabel.Text = userLabel.Text.Replace("1 seconds", "a second")
            End If

    End Sub

    Private Sub SecondTextbox_TextChanged(sender As Object, e As EventArgs) Handles SecondTextbox.TextChanged
        If SecondTextbox.Text = "" Then
SecondTextbox.Text = "0" 
            Button1.Focus()
            SecondTextbox.Focus()
            Else
   CalculateValues.Start()
        End If
     

    End Sub

    Private Sub CalculateValues_Tick(sender As Object, e As EventArgs) Handles CalculateValues.Tick
        Try
              ValueInSecondsLabel.Text = SecondTextbox.Text + MinuteTextbox.Text * 60 + HourTextbox.Text * 3600
        If ValueInSecondsLabel.Text.Contains("E") Then
            ErrorLabel.Visible = True
            Button1.Enabled = False

            ' HourTextbox.Text = 0
            'MinuteTextbox.Text = 0
            'SecondTextbox.Text = 0
        Else
            ErrorLabel.Visible = Not True
            Button1.Enabled = Not False
        End If
        CalculateValues.Stop()
        Catch ex As Exception
         
            HourTextbox.Text = "0"
            MinuteTextbox.Text = "0"
            secondtextbox.Text = "0"
               MsgBox("Only numbers are allowed!!", MsgBoxStyle.Critical, "An error occured.")
        End Try
      

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Calculating shutdown timer in seconds")
        CalculateValues.Start()

        Threading.Thread.Sleep(170)
        'MsgBox("shutdown -s -t " & ValueInSecondsLabel.Text)
        If ValueInSecondsLabel.Text = 0 Then
            MsgBox("You cannot schedule a shutdown equal or lower than a zero value!")
        Else
            Dim a = ValueInSecondsLabel.Text
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Shell("shutdown -s -t " & ValueInSecondsLabel.Text)
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
              Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.")
            Button2.Enabled = True

            Label6.Visible = True

        End If


    End Sub

    Private Sub MinuteTextbox_TextChanged(sender As Object, e As EventArgs) Handles MinuteTextbox.TextChanged
        If MinuteTextbox.Text = "" Then
MinuteTextbox.Text = "0"
              Button1.Focus()
            minutetextbox.Focus()
        Else
 CalculateValues.Start()
        End If
       
    End Sub

    Private Sub HourTextbox_TextChanged(sender As Object, e As EventArgs) Handles HourTextbox.TextChanged
        If HourTextbox.Text = "" Then
            HourTextbox.Text = 0
              Button1.Focus()
           hourtextbox.Focus()
        Else

            CalculateValues.Start()
            
        End If
       
      
    End Sub

    Private Sub AutoPowerSwitcher_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        CalculateValues.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("shutdown -a")
        System.Threading.Thread.Sleep(200)
        Shell("shutdown -a")
        Label6.Visible = False
        Button2.Enabled = False
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")

        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")

        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")

        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")

        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")

        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED")


    End Sub

    Private Sub AutoPowerSwitcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "AutoPowerSwitcher is intialized.")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles userLabel.Click

    End Sub

    Private Sub UIEngine_Tick(sender As Object, e As EventArgs) Handles UIEngine.Tick
        If HourTextbox.Text = 0 And MinuteTextbox.Text = 0 And SecondTextbox.Text = 0 Then
            userLabel.Visible = False

        Else
                userLabel.Visible = true
        
        If RadioButton1.Checked = True Then
            userLabel.Text = "After " & HourTextbox.Text & " hours, " & MinuteTextbox.Text & " minutes and " & SecondTextbox.Text & " seconds, I will shutdown your PC!"
                renderUserLabel
            
            Else
              userLabel.Text = "After " & HourTextbox.Text & " hours, " & MinuteTextbox.Text & " minutes and " & SecondTextbox.Text & " seconds, I will hibernate your PC!"
                renderUserLabel
        End If
        End If
    End Sub
End Class