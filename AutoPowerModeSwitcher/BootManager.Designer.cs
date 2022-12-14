using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BootManager : Form
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
            Status = new Label();
            Engine = new Timer(components);
            Engine.Tick += new EventHandler(Engine_Tick);
            ProgressBar1 = new ProgressBar();
            PictureBox1 = new PictureBox();
            NotifyIcon1 = new NotifyIcon(components);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI Light", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Status.Location = new Point(89, 15);
            Status.Name = "Status";
            Status.Size = new Size(167, 20);
            Status.TabIndex = 0;
            Status.Text = "BootManager is working...";
            // 
            // Engine
            // 
            Engine.Enabled = true;
            Engine.Interval = 50;
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(93, 1);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(147, 11);
            ProgressBar1.TabIndex = 1;
            ProgressBar1.Visible = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.tumblr_inline_np9hcuZr931qd3uu5_540;
            PictureBox1.Location = new Point(3, 1);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(71, 61);
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            // 
            // NotifyIcon1
            // 
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            NotifyIcon1.Text = "BootOptimizer is running!";
            NotifyIcon1.Visible = true;
            // 
            // Button1
            // 
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(200, 47);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 3;
            Button1.Text = "Hide";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Location = new Point(93, 47);
            Button2.Name = "Button2";
            Button2.Size = new Size(101, 23);
            Button2.TabIndex = 4;
            Button2.Text = "Do not start again";
            Button2.UseVisualStyleBackColor = true;
            // 
            // BootManager
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 73);
            ControlBox = false;
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(PictureBox1);
            Controls.Add(ProgressBar1);
            Controls.Add(Status);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BootManager";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "BootManager";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Load += new EventHandler(BootManager_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label Status;
        internal Timer Engine;
        internal ProgressBar ProgressBar1;
        internal PictureBox PictureBox1;
        internal NotifyIcon NotifyIcon1;
        internal Button Button1;
        internal Button Button2;
    }
}