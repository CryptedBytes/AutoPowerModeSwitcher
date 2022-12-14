<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemoryLeakTestingLab
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PenTest3 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PenTest1 = New System.Windows.Forms.Timer(Me.components)
        Me.PenTest2 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon3 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyIcon4 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PenTest4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(604, 320)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Peneration"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stop Peneration"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 180)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(346, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "0"
        Me.Label1.Visible = false
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = true
        Me.RadioButton4.Location = New System.Drawing.Point(13, 83)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(320, 17)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = true
        Me.RadioButton4.Text = "Form Visibility Render Memory Leak (WARNING: Unstoppable)"
        Me.RadioButton4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(189, 101)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 51)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "FORCE Call GC"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = true
        Me.RadioButton3.Location = New System.Drawing.Point(13, 58)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(320, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = true
        Me.RadioButton3.Text = "Form Visibility Render Memory Leak (WARNING: Unstoppable)"
        Me.RadioButton3.UseVisualStyleBackColor = true
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = true
        Me.RadioButton2.Location = New System.Drawing.Point(13, 35)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(206, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = true
        Me.RadioButton2.Text = "PictureBox Image Buffer Memory Leak"
        Me.RadioButton2.UseVisualStyleBackColor = true
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = true
        Me.RadioButton1.Location = New System.Drawing.Point(13, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(175, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = true
        Me.RadioButton1.Text = "NotifyIcon Memory Leak (Slow )"
        Me.RadioButton1.UseVisualStyleBackColor = true
        '
        'PenTest3
        '
        Me.PenTest3.Interval = 1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "PenTest1"
        Me.NotifyIcon1.Visible = true
        '
        'PenTest1
        '
        Me.PenTest1.Interval = 1
        '
        'PenTest2
        '
        Me.PenTest2.Interval = 1
        '
        'NotifyIcon2
        '
        Me.NotifyIcon2.Text = "NotifyIcon2"
        Me.NotifyIcon2.Visible = true
        '
        'NotifyIcon3
        '
        Me.NotifyIcon3.Text = "NotifyIcon3"
        Me.NotifyIcon3.Visible = true
        '
        'NotifyIcon4
        '
        Me.NotifyIcon4.Text = "NotifyIcon4"
        Me.NotifyIcon4.Visible = true
        '
        'PenTest4
        '
        Me.PenTest4.Interval = 10
        '
        'MemoryLeakTestingLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 305)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "MemoryLeakTestingLab"
        Me.Text = "MemoryLeakTestingLab"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PenTest3 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents PenTest1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents PenTest2 As Timer
    Friend WithEvents NotifyIcon2 As NotifyIcon
    Friend WithEvents NotifyIcon3 As NotifyIcon
    Friend WithEvents NotifyIcon4 As NotifyIcon
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents PenTest4 As Timer
    Friend WithEvents Label1 As Label
End Class
