using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AutoPilotPopup : Form
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
            String1 = new Label();
            String2 = new Label();
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Label3 = new Label();
            Timer2 = new Timer(components);
            Timer2.Tick += new EventHandler(Timer2_Tick);
            Panel1 = new Panel();
            Label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.KTnby6jTq;
            PictureBox1.Location = new Point(12, 26);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(114, 95);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 0;
            PictureBox1.TabStop = false;
            // 
            // String1
            // 
            String1.AutoSize = true;
            String1.Font = new Font("Segoe UI Light", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            String1.Location = new Point(132, 37);
            String1.Name = "String1";
            String1.Size = new Size(268, 40);
            String1.TabIndex = 1;
            String1.Text = "AutoPilot is enabled!";
            // 
            // String2
            // 
            String2.AutoSize = true;
            String2.Font = new Font("Segoe UI Light", 12f);
            String2.Location = new Point(132, 77);
            String2.Name = "String2";
            String2.Size = new Size(304, 21);
            String2.TabIndex = 2;
            String2.Text = "Your system is now being actively monitored";
            // 
            // Timer1
            // 
            Timer1.Interval = 2100;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(203, 2);
            Label3.Name = "Label3";
            Label3.Size = new Size(29, 13);
            Label3.TabIndex = 3;
            Label3.Text = "True";
            Label3.Visible = false;
            // 
            // Timer2
            // 
            Timer2.Enabled = true;
            Timer2.Interval = 1;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label4);
            Panel1.Location = new Point(163, 130);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(114, 100);
            Panel1.TabIndex = 4;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Light", 60.75f);
            Label4.Location = new Point(21, -11);
            Label4.Name = "Label4";
            Label4.Size = new Size(86, 108);
            Label4.TabIndex = 5;
            Label4.Text = ":(";
            // 
            // AutoPilotPopup
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(436, 143);
            Controls.Add(Panel1);
            Controls.Add(Label3);
            Controls.Add(String2);
            Controls.Add(String1);
            Controls.Add(PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AutoPilotPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(AutoPilotPopup_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal PictureBox PictureBox1;
        internal Label String1;
        internal Label String2;
        internal Timer Timer1;
        internal Label Label3;
        internal Timer Timer2;
        internal Panel Panel1;
        internal Label Label4;
    }
}