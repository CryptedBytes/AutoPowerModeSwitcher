<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoPowerSwitcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HourTextbox = New System.Windows.Forms.TextBox()
        Me.MinuteTextbox = New System.Windows.Forms.TextBox()
        Me.SecondTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CalculateValues = New System.Windows.Forms.Timer(Me.components)
        Me.ValueInSecondsLabel = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.UIEngine = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(9, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Schedule"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'HourTextbox
        '
        Me.HourTextbox.Location = New System.Drawing.Point(12, 46)
        Me.HourTextbox.Name = "HourTextbox"
        Me.HourTextbox.Size = New System.Drawing.Size(50, 20)
        Me.HourTextbox.TabIndex = 1
        Me.HourTextbox.Text = "0"
        '
        'MinuteTextbox
        '
        Me.MinuteTextbox.Location = New System.Drawing.Point(86, 46)
        Me.MinuteTextbox.Name = "MinuteTextbox"
        Me.MinuteTextbox.Size = New System.Drawing.Size(50, 20)
        Me.MinuteTextbox.TabIndex = 2
        Me.MinuteTextbox.Text = "0"
        '
        'SecondTextbox
        '
        Me.SecondTextbox.Location = New System.Drawing.Point(161, 46)
        Me.SecondTextbox.Name = "SecondTextbox"
        Me.SecondTextbox.Size = New System.Drawing.Size(50, 20)
        Me.SecondTextbox.TabIndex = 3
        Me.SecondTextbox.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 11.75!)
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hours"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(84, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Minutes"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(158, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Seconds"
        '
        'CalculateValues
        '
        Me.CalculateValues.Enabled = true
        Me.CalculateValues.Interval = 10
        '
        'ValueInSecondsLabel
        '
        Me.ValueInSecondsLabel.AutoSize = true
        Me.ValueInSecondsLabel.Location = New System.Drawing.Point(310, 5)
        Me.ValueInSecondsLabel.Name = "ValueInSecondsLabel"
        Me.ValueInSecondsLabel.Size = New System.Drawing.Size(13, 13)
        Me.ValueInSecondsLabel.TabIndex = 9
        Me.ValueInSecondsLabel.Text = "0"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = true
        Me.ErrorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(69, 178)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(201, 13)
        Me.ErrorLabel.TabIndex = 10
        Me.ErrorLabel.Text = "An error occured while calculating"
        Me.ErrorLabel.Visible = false
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = true
        Me.RadioButton1.Checked = true
        Me.RadioButton1.Location = New System.Drawing.Point(16, 100)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = true
        Me.RadioButton1.Text = "Shutdown"
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(125, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Scheduled!"
        Me.Label6.Visible = false
        '
        'Button2
        '
        Me.Button2.Enabled = false
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(191, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 28)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = true
        Me.RadioButton2.Location = New System.Drawing.Point(95, 100)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = true
        Me.RadioButton2.Text = "Hibernate"
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(13, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "When should I take action?"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(9, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "What should I do?"
        '
        'userLabel
        '
        Me.userLabel.AutoSize = true
        Me.userLabel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.userLabel.Location = New System.Drawing.Point(1, 127)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(78, 17)
        Me.userLabel.TabIndex = 17
        Me.userLabel.Text = "convertables"
        '
        'UIEngine
        '
        Me.UIEngine.Enabled = true
        Me.UIEngine.Interval = 1
        '
        'AutoPowerSwitcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(381, 206)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.ValueInSecondsLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SecondTextbox)
        Me.Controls.Add(Me.MinuteTextbox)
        Me.Controls.Add(Me.HourTextbox)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "AutoPowerSwitcher"
        Me.ShowIcon = false
        Me.Text = "AutoPowerSwitcher"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents HourTextbox As TextBox
    Friend WithEvents MinuteTextbox As TextBox
    Friend WithEvents SecondTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CalculateValues As Timer
    Friend WithEvents ValueInSecondsLabel As Label
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents userLabel As Label
    Friend WithEvents UIEngine As Timer
End Class
