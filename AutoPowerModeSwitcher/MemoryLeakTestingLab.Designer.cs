using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MemoryLeakTestingLab : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PictureBox1 = new PictureBox();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Panel1 = new Panel();
            Label1 = new Label();
            RadioButton4 = new RadioButton();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            RadioButton3 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton1 = new RadioButton();
            PenTest3 = new Timer(components);
            PenTest3.Tick += new EventHandler(PenTest3_Tick);
            NotifyIcon1 = new NotifyIcon(components);
            NotifyIcon1.MouseDoubleClick += new MouseEventHandler(NotifyIcon1_MouseDoubleClick);
            PenTest1 = new Timer(components);
            PenTest1.Tick += new EventHandler(PenTest1_Tick);
            PenTest2 = new Timer(components);
            PenTest2.Tick += new EventHandler(PenTest2_Tick);
            NotifyIcon2 = new NotifyIcon(components);
            NotifyIcon3 = new NotifyIcon(components);
            NotifyIcon4 = new NotifyIcon(components);
            PenTest4 = new Timer(components);
            PenTest4.Tick += new EventHandler(PenTest4_Tick);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Location = new Point(-6, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(604, 320);
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // Button1
            // 
            Button1.Location = new Point(13, 100);
            Button1.Name = "Button1";
            Button1.Size = new Size(170, 23);
            Button1.TabIndex = 1;
            Button1.Text = "Start Peneration";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(13, 129);
            Button2.Name = "Button2";
            Button2.Size = new Size(170, 23);
            Button2.TabIndex = 1;
            Button2.Text = "Stop Peneration";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(RadioButton4);
            Panel1.Controls.Add(Button3);
            Panel1.Controls.Add(RadioButton3);
            Panel1.Controls.Add(RadioButton2);
            Panel1.Controls.Add(RadioButton1);
            Panel1.Controls.Add(Button1);
            Panel1.Controls.Add(Button2);
            Panel1.Location = new Point(12, 12);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(574, 180);
            Panel1.TabIndex = 5;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(346, 85);
            Label1.Name = "Label1";
            Label1.Size = new Size(13, 13);
            Label1.TabIndex = 7;
            Label1.Text = "0";
            Label1.Visible = false;
            // 
            // RadioButton4
            // 
            RadioButton4.AutoSize = true;
            RadioButton4.Location = new Point(13, 83);
            RadioButton4.Name = "RadioButton4";
            RadioButton4.Size = new Size(320, 17);
            RadioButton4.TabIndex = 5;
            RadioButton4.TabStop = true;
            RadioButton4.Text = "Form Visibility Render Memory Leak (WARNING: Unstoppable)";
            RadioButton4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(189, 101);
            Button3.Name = "Button3";
            Button3.Size = new Size(170, 51);
            Button3.TabIndex = 6;
            Button3.Text = "FORCE Call GC";
            Button3.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Location = new Point(13, 58);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(320, 17);
            RadioButton3.TabIndex = 5;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "Form Visibility Render Memory Leak (WARNING: Unstoppable)";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(13, 35);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(206, 17);
            RadioButton2.TabIndex = 5;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "PictureBox Image Buffer Memory Leak";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Location = new Point(13, 13);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(175, 17);
            RadioButton1.TabIndex = 5;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "NotifyIcon Memory Leak (Slow )";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // PenTest3
            // 
            PenTest3.Interval = 1;
            // 
            // NotifyIcon1
            // 
            NotifyIcon1.Text = "PenTest1";
            NotifyIcon1.Visible = true;
            // 
            // PenTest1
            // 
            PenTest1.Interval = 1;
            // 
            // PenTest2
            // 
            PenTest2.Interval = 1;
            // 
            // NotifyIcon2
            // 
            NotifyIcon2.Text = "NotifyIcon2";
            NotifyIcon2.Visible = true;
            // 
            // NotifyIcon3
            // 
            NotifyIcon3.Text = "NotifyIcon3";
            NotifyIcon3.Visible = true;
            // 
            // NotifyIcon4
            // 
            NotifyIcon4.Text = "NotifyIcon4";
            NotifyIcon4.Visible = true;
            // 
            // PenTest4
            // 
            PenTest4.Interval = 10;
            // 
            // MemoryLeakTestingLab
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 305);
            Controls.Add(Panel1);
            Controls.Add(PictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MemoryLeakTestingLab";
            Text = "MemoryLeakTestingLab";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(MemoryLeakTestingLab_Load);
            ResumeLayout(false);

        }

        internal PictureBox PictureBox1;
        internal Button Button1;
        internal Button Button2;
        internal Panel Panel1;
        internal RadioButton RadioButton3;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton1;
        internal Timer PenTest3;
        internal NotifyIcon NotifyIcon1;
        internal Timer PenTest1;
        internal Button Button3;
        internal Timer PenTest2;
        internal NotifyIcon NotifyIcon2;
        internal NotifyIcon NotifyIcon3;
        internal NotifyIcon NotifyIcon4;
        internal RadioButton RadioButton4;
        internal Timer PenTest4;
        internal Label Label1;
    }
}