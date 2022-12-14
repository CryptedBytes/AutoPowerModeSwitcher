<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BootManagerUXPort
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.timeLeftEngine = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timeLeft = New System.Windows.Forms.Label()
        Me.timePast = New System.Windows.Forms.Label()
        Me.Timeout = New System.Windows.Forms.Timer(Me.components)
        Me.ProcessLabel = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Animation = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Engine = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 8.0!)
        Me.Button2.Location = New System.Drawing.Point(295, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 45)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'timeLeftEngine
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Auto start in:"
        '
        'timeLeft
        '
        Me.timeLeft.AutoSize = True
        Me.timeLeft.Location = New System.Drawing.Point(184, 108)
        Me.timeLeft.Name = "timeLeft"
        Me.timeLeft.Size = New System.Drawing.Size(19, 13)
        Me.timeLeft.TabIndex = 21
        Me.timeLeft.Text = "13"
        '
        'timePast
        '
        Me.timePast.AutoSize = True
        Me.timePast.Location = New System.Drawing.Point(190, 95)
        Me.timePast.Name = "timePast"
        Me.timePast.Size = New System.Drawing.Size(13, 13)
        Me.timePast.TabIndex = 19
        Me.timePast.Text = "0"
        Me.timePast.Visible = False
        '
        'Timeout
        '
        Me.Timeout.Enabled = True
        Me.Timeout.Interval = 1000
        '
        'ProcessLabel
        '
        Me.ProcessLabel.AutoSize = True
        Me.ProcessLabel.Location = New System.Drawing.Point(13, 49)
        Me.ProcessLabel.Name = "ProcessLabel"
        Me.ProcessLabel.Size = New System.Drawing.Size(32, 13)
        Me.ProcessLabel.TabIndex = 23
        Me.ProcessLabel.Text = "False"
        Me.ProcessLabel.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(291, 102)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 18
        Me.ProgressBar1.Visible = False
        '
        'Animation
        '
        Me.Animation.Interval = 1
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(250, 79)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox3.TabIndex = 17
        Me.CheckBox3.Text = "Prefect iTunes"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(12, 79)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.Text = "Prefect Google's Chrome"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Prefetch application data to make them launch faster"
        '
        'Engine
        '
        Me.Engine.Interval = 750
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 17.0!)
        Me.Button1.Location = New System.Drawing.Point(56, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 45)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Prefect now"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BootManagerUXPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(357, 125)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.timeLeft)
        Me.Controls.Add(Me.timePast)
        Me.Controls.Add(Me.ProcessLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BootManagerUXPort"
        Me.Text = "BootManagerUXPort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents timeLeftEngine As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents timeLeft As Label
    Friend WithEvents timePast As Label
    Friend WithEvents Timeout As Timer
    Friend WithEvents ProcessLabel As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Animation As Timer
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Engine As Timer
    Friend WithEvents Button1 As Button
End Class
