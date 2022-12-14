<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallerModule
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
        Me.Installer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonInstall = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.StatusDetail = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.InstallDialog = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InstallationCompleteDialog = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorDialog = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.InstallDialog.SuspendLayout
        Me.InstallationCompleteDialog.SuspendLayout
        Me.ErrorDialog.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Installer
        '
        Me.Installer.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "It will be installed to"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 13.25!)
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "You are about to install"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 15.25!)
        Me.Label3.Location = New System.Drawing.Point(53, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(385, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AutoPowerModeSwitcher by CryptedBytes"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(13, 123)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(90, 27)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = true
        '
        'ButtonInstall
        '
        Me.ButtonInstall.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInstall.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.ButtonInstall.Location = New System.Drawing.Point(400, 123)
        Me.ButtonInstall.Name = "ButtonInstall"
        Me.ButtonInstall.Size = New System.Drawing.Size(90, 27)
        Me.ButtonInstall.TabIndex = 4
        Me.ButtonInstall.Text = "INSTALL"
        Me.ButtonInstall.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Click install to continue. No network connection needed to install"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = true
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI Light", 15.25!)
        Me.StatusLabel.ForeColor = System.Drawing.Color.Red
        Me.StatusLabel.Location = New System.Drawing.Point(193, 119)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(103, 30)
        Me.StatusLabel.TabIndex = 6
        Me.StatusLabel.Text = "Installing..."
        Me.StatusLabel.Visible = false
        '
        'StatusDetail
        '
        Me.StatusDetail.AutoSize = true
        Me.StatusDetail.Font = New System.Drawing.Font("Segoe UI Light", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.StatusDetail.Location = New System.Drawing.Point(180, 153)
        Me.StatusDetail.Name = "StatusDetail"
        Me.StatusDetail.Size = New System.Drawing.Size(56, 15)
        Me.StatusDetail.TabIndex = 7
        Me.StatusDetail.Text = "%Status%"
        Me.StatusDetail.Visible = false
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.Checked = true
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(400, 153)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(103, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Create shortcuts"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'InstallDialog
        '
        Me.InstallDialog.Controls.Add(Me.Label5)
        Me.InstallDialog.Controls.Add(Me.Label7)
        Me.InstallDialog.Controls.Add(Me.Label6)
        Me.InstallDialog.Location = New System.Drawing.Point(41, 156)
        Me.InstallDialog.Name = "InstallDialog"
        Me.InstallDialog.Size = New System.Drawing.Size(477, 107)
        Me.InstallDialog.TabIndex = 9
        Me.InstallDialog.Visible = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 15.25!)
        Me.Label5.Location = New System.Drawing.Point(45, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(385, 30)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "AutoPowerModeSwitcher by CryptedBytes"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 13.25!)
        Me.Label7.Location = New System.Drawing.Point(164, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 25)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Now installing"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 11!)
        Me.Label6.Location = New System.Drawing.Point(90, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Hold on! It will be ready for you any time soon!"
        '
        'InstallationCompleteDialog
        '
        Me.InstallationCompleteDialog.Controls.Add(Me.Button1)
        Me.InstallationCompleteDialog.Controls.Add(Me.Label8)
        Me.InstallationCompleteDialog.Controls.Add(Me.Label9)
        Me.InstallationCompleteDialog.Location = New System.Drawing.Point(58, 166)
        Me.InstallationCompleteDialog.Name = "InstallationCompleteDialog"
        Me.InstallationCompleteDialog.Size = New System.Drawing.Size(477, 107)
        Me.InstallationCompleteDialog.TabIndex = 13
        Me.InstallationCompleteDialog.Visible = false
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Button1.Location = New System.Drawing.Point(132, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Click here to get started"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 15.25!)
        Me.Label8.Location = New System.Drawing.Point(43, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(385, 30)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "AutoPowerModeSwitcher by CryptedBytes"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 13.25!)
        Me.Label9.Location = New System.Drawing.Point(146, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Successfully installed"
        '
        'ErrorDialog
        '
        Me.ErrorDialog.Controls.Add(Me.Button4)
        Me.ErrorDialog.Controls.Add(Me.Button3)
        Me.ErrorDialog.Controls.Add(Me.Button2)
        Me.ErrorDialog.Controls.Add(Me.Label11)
        Me.ErrorDialog.Controls.Add(Me.Label10)
        Me.ErrorDialog.Location = New System.Drawing.Point(38, 171)
        Me.ErrorDialog.Name = "ErrorDialog"
        Me.ErrorDialog.Size = New System.Drawing.Size(474, 105)
        Me.ErrorDialog.TabIndex = 16
        Me.ErrorDialog.Visible = false
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(346, 62)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Copy error details"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(216, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Show error details"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(131, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Please exit application now and retry later"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(120, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "An error occured during installation process."
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162,Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 15)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Installation Path:  "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LinkLabel3)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(496, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 153)
        Me.Panel1.TabIndex = 18
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = true
        Me.LinkLabel3.Location = New System.Drawing.Point(338, 95)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(74, 13)
        Me.LinkLabel3.TabIndex = 4
        Me.LinkLabel3.TabStop = true
        Me.LinkLabel3.Text = "Relaunch app"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = true
        Me.LinkLabel2.Location = New System.Drawing.Point(120, 95)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(189, 13)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = true
        Me.LinkLabel2.Text = "I understand the risk, continue anyway"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Location = New System.Drawing.Point(46, 95)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Exit app"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(157, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Things you can do:"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(43, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(401, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "This installer is no longer supported and may cause serious problems on your syst"& _ 
    "em"
        '
        'InstallerModule
        '
        Me.AcceptButton = Me.ButtonInstall
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(502, 173)
        Me.ControlBox = false
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ErrorDialog)
        Me.Controls.Add(Me.InstallationCompleteDialog)
        Me.Controls.Add(Me.InstallDialog)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.StatusDetail)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonInstall)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Name = "InstallerModule"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Install AutoPowerModeSwicher"
        Me.InstallDialog.ResumeLayout(false)
        Me.InstallDialog.PerformLayout
        Me.InstallationCompleteDialog.ResumeLayout(false)
        Me.InstallationCompleteDialog.PerformLayout
        Me.ErrorDialog.ResumeLayout(false)
        Me.ErrorDialog.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Installer As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonInstall As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents StatusDetail As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents InstallDialog As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InstallationCompleteDialog As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrorDialog As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
