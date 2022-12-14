<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoreForm
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
        Me.StartedonBoot = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Engine = New System.Windows.Forms.Timer(Me.components)
        Me.timesTick = New System.Windows.Forms.Label()
        Me.EngineStopper = New System.Windows.Forms.Timer(Me.components)
        Me.Cloak = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SafemodeDialog = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SafemodePromptPanel = New System.Windows.Forms.Panel()
        Me.SafemodeActivePanel = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorLoggingLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SafemodePromptPanel.SuspendLayout
        Me.SafemodeActivePanel.SuspendLayout
        Me.SuspendLayout
        '
        'StartedonBoot
        '
        Me.StartedonBoot.AutoSize = true
        Me.StartedonBoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.StartedonBoot.Location = New System.Drawing.Point(147, 97)
        Me.StartedonBoot.Name = "StartedonBoot"
        Me.StartedonBoot.Size = New System.Drawing.Size(57, 20)
        Me.StartedonBoot.TabIndex = 0
        Me.StartedonBoot.Text = "NONE"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(134, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Started on boot:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(74, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "This is the core process of APMS"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "if you are reading this"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(334, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "either your system is so slow or an exception has occured"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutoPowerModeSwitcher.My.Resources.Resources.CryptedBytesLogo
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(463, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = false
        '
        'StatusLabel
        '
        Me.StatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(66,Byte),Integer), CType(CType(66,Byte),Integer), CType(CType(65,Byte),Integer))
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.Location = New System.Drawing.Point(1, 130)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(447, 25)
        Me.StatusLabel.TabIndex = 6
        Me.StatusLabel.Text = "AutoPowerModeSwitcher"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Engine
        '
        Me.Engine.Interval = 1000
        '
        'timesTick
        '
        Me.timesTick.AutoSize = true
        Me.timesTick.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.timesTick.ForeColor = System.Drawing.Color.White
        Me.timesTick.Location = New System.Drawing.Point(12, 4)
        Me.timesTick.Name = "timesTick"
        Me.timesTick.Size = New System.Drawing.Size(13, 13)
        Me.timesTick.TabIndex = 7
        Me.timesTick.Text = "0"
        Me.timesTick.Visible = false
        '
        'EngineStopper
        '
        Me.EngineStopper.Interval = 2500
        '
        'Cloak
        '
        Me.Cloak.Enabled = true
        Me.Cloak.Interval = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(416, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 24)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(100, 1)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(92, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Enable safemode."
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'SafemodeDialog
        '
        Me.SafemodeDialog.Enabled = True
        Me.SafemodeDialog.Interval = 4000
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Having problems?"
        '
        'SafemodePromptPanel
        '
        Me.SafemodePromptPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.SafemodePromptPanel.Controls.Add(Me.Label5)
        Me.SafemodePromptPanel.Controls.Add(Me.LinkLabel1)
        Me.SafemodePromptPanel.Location = New System.Drawing.Point(119, 3)
        Me.SafemodePromptPanel.Name = "SafemodePromptPanel"
        Me.SafemodePromptPanel.Size = New System.Drawing.Size(196, 22)
        Me.SafemodePromptPanel.TabIndex = 11
        Me.SafemodePromptPanel.Visible = false
        '
        'SafemodeActivePanel
        '
        Me.SafemodeActivePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.SafemodeActivePanel.Controls.Add(Me.LinkLabel2)
        Me.SafemodeActivePanel.Controls.Add(Me.Label6)
        Me.SafemodeActivePanel.Location = New System.Drawing.Point(443, 130)
        Me.SafemodeActivePanel.Name = "SafemodeActivePanel"
        Me.SafemodeActivePanel.Size = New System.Drawing.Size(417, 40)
        Me.SafemodeActivePanel.TabIndex = 12
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Violet
        Me.LinkLabel2.AutoSize = true
        Me.LinkLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(128, 23)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(181, 13)
        Me.LinkLabel2.TabIndex = 13
        Me.LinkLabel2.TabStop = true
        Me.LinkLabel2.Text = "click this to disable Safemode."
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.White
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Safe mode is active. Do not close this dialog or you might get stuck in Safemode."& _ 
    ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"When you done cheking, "
        '
        'ErrorLoggingLabel
        '
        Me.ErrorLoggingLabel.AutoSize = true
        Me.ErrorLoggingLabel.Location = New System.Drawing.Point(12, 194)
        Me.ErrorLoggingLabel.Name = "ErrorLoggingLabel"
        Me.ErrorLoggingLabel.Size = New System.Drawing.Size(46, 13)
        Me.ErrorLoggingLabel.TabIndex = 13
        Me.ErrorLoggingLabel.Text = "exWriter"
        '
        'CoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 168)
        Me.Controls.Add(Me.ErrorLoggingLabel)
        Me.Controls.Add(Me.SafemodeActivePanel)
        Me.Controls.Add(Me.SafemodePromptPanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.timesTick)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartedonBoot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "CoreForm"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CoreForm"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SafemodePromptPanel.ResumeLayout(false)
        Me.SafemodePromptPanel.PerformLayout
        Me.SafemodeActivePanel.ResumeLayout(false)
        Me.SafemodeActivePanel.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents StartedonBoot As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Engine As System.Windows.Forms.Timer
    Friend WithEvents timesTick As System.Windows.Forms.Label
    Friend WithEvents EngineStopper As System.Windows.Forms.Timer
    Friend WithEvents Cloak As System.Windows.Forms.Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents SafemodeDialog As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents SafemodePromptPanel As Panel
    Friend WithEvents SafemodeActivePanel As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorLoggingLabel As Label
End Class
