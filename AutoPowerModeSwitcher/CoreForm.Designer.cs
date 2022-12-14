using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CoreForm : Form
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
            StartedonBoot = new Label();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            StatusLabel = new Label();
            StatusLabel.Click += new EventHandler(StatusLabel_Click);
            Engine = new Timer(components);
            Engine.Tick += new EventHandler(Timer1_Tick);
            timesTick = new Label();
            EngineStopper = new Timer(components);
            EngineStopper.Tick += new EventHandler(EngineStopper_Tick);
            Cloak = new Timer(components);
            Cloak.Tick += new EventHandler(Cloak_Tick);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            LinkLabel1 = new LinkLabel();
            LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            SafemodeDialog = new Timer(components);
            SafemodeDialog.Tick += new EventHandler(SafemodeDialog_Tick);
            Label5 = new Label();
            SafemodePromptPanel = new Panel();
            SafemodeActivePanel = new Panel();
            LinkLabel2 = new LinkLabel();
            LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            Label6 = new Label();
            ErrorLoggingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SafemodePromptPanel.SuspendLayout();
            SafemodeActivePanel.SuspendLayout();
            SuspendLayout();
            // 
            // StartedonBoot
            // 
            StartedonBoot.AutoSize = true;
            StartedonBoot.Font = new Font("Microsoft Sans Serif", 12.25f);
            StartedonBoot.Location = new Point(147, 97);
            StartedonBoot.Name = "StartedonBoot";
            StartedonBoot.Size = new Size(57, 20);
            StartedonBoot.TabIndex = 0;
            StartedonBoot.Text = "NONE";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(134, 84);
            Label1.Name = "Label1";
            Label1.Size = new Size(83, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Started on boot:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 162);
            Label2.ForeColor = Color.Red;
            Label2.Location = new Point(74, 117);
            Label2.Name = "Label2";
            Label2.Size = new Size(237, 16);
            Label2.TabIndex = 2;
            Label2.Text = "This is the core process of APMS";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
            Label3.Location = new Point(96, 41);
            Label3.Name = "Label3";
            Label3.Size = new Size(130, 13);
            Label3.TabIndex = 3;
            Label3.Text = "if you are reading this";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
            Label4.Location = new Point(12, 54);
            Label4.Name = "Label4";
            Label4.Size = new Size(334, 13);
            Label4.TabIndex = 4;
            Label4.Text = "either your system is so slow or an exception has occured";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.CryptedBytesLogo;
            PictureBox1.Location = new Point(-7, -2);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(463, 172);
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            PictureBox1.TabIndex = 5;
            PictureBox1.TabStop = false;
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = Color.FromArgb(66, 66, 65);
            StatusLabel.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 162);
            StatusLabel.ForeColor = Color.White;
            StatusLabel.Location = new Point(1, 130);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(447, 25);
            StatusLabel.TabIndex = 6;
            StatusLabel.Text = "AutoPowerModeSwitcher" + '\r' + '\n';
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Engine
            // 
            Engine.Interval = 1000;
            // 
            // timesTick
            // 
            timesTick.AutoSize = true;
            timesTick.BackColor = Color.FromArgb(64, 64, 64);
            timesTick.ForeColor = Color.White;
            timesTick.Location = new Point(12, 4);
            timesTick.Name = "timesTick";
            timesTick.Size = new Size(13, 13);
            timesTick.TabIndex = 7;
            timesTick.Text = "0";
            timesTick.Visible = false;
            // 
            // EngineStopper
            // 
            EngineStopper.Interval = 2500;
            // 
            // Cloak
            // 
            Cloak.Enabled = true;
            Cloak.Interval = 1;
            // 
            // Button1
            // 
            Button1.BackColor = Color.Red;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 162);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(416, 1);
            Button1.Name = "Button1";
            Button1.Size = new Size(32, 24);
            Button1.TabIndex = 8;
            Button1.Text = "X";
            Button1.UseVisualStyleBackColor = false;
            // 
            // LinkLabel1
            // 
            LinkLabel1.ActiveLinkColor = Color.Red;
            LinkLabel1.AutoSize = true;
            LinkLabel1.BackColor = Color.FromArgb(64, 64, 64);
            LinkLabel1.DisabledLinkColor = Color.White;
            LinkLabel1.ForeColor = SystemColors.ControlLightLight;
            LinkLabel1.LinkColor = Color.White;
            LinkLabel1.Location = new Point(100, 1);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(92, 13);
            LinkLabel1.TabIndex = 9;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Enable safemode.";
            LinkLabel1.VisitedLinkColor = Color.White;
            // 
            // SafemodeDialog
            // 
            SafemodeDialog.Enabled = true;
            SafemodeDialog.Interval = 4000;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.FromArgb(64, 64, 64);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(10, 1);
            Label5.Name = "Label5";
            Label5.Size = new Size(92, 13);
            Label5.TabIndex = 10;
            Label5.Text = "Having problems?";
            // 
            // SafemodePromptPanel
            // 
            SafemodePromptPanel.BackColor = Color.FromArgb(64, 64, 64);
            SafemodePromptPanel.Controls.Add(Label5);
            SafemodePromptPanel.Controls.Add(LinkLabel1);
            SafemodePromptPanel.Location = new Point(119, 3);
            SafemodePromptPanel.Name = "SafemodePromptPanel";
            SafemodePromptPanel.Size = new Size(196, 22);
            SafemodePromptPanel.TabIndex = 11;
            SafemodePromptPanel.Visible = false;
            // 
            // SafemodeActivePanel
            // 
            SafemodeActivePanel.BackColor = Color.FromArgb(64, 64, 64);
            SafemodeActivePanel.Controls.Add(LinkLabel2);
            SafemodeActivePanel.Controls.Add(Label6);
            SafemodeActivePanel.Location = new Point(443, 130);
            SafemodeActivePanel.Name = "SafemodeActivePanel";
            SafemodeActivePanel.Size = new Size(417, 40);
            SafemodeActivePanel.TabIndex = 12;
            // 
            // LinkLabel2
            // 
            LinkLabel2.ActiveLinkColor = Color.Violet;
            LinkLabel2.AutoSize = true;
            LinkLabel2.BackColor = Color.FromArgb(64, 64, 64);
            LinkLabel2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabel2.LinkColor = Color.White;
            LinkLabel2.Location = new Point(128, 23);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(181, 13);
            LinkLabel2.TabIndex = 13;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "click this to disable Safemode.";
            LinkLabel2.VisitedLinkColor = Color.White;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.FromArgb(64, 64, 64);
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(4, 9);
            Label6.Name = "Label6";
            Label6.Size = new Size(388, 26);
            Label6.TabIndex = 10;
            Label6.Text = "Safe mode is active. Do not close this dialog or you might get stuck in Safemode." + "" + '\r' + '\n' + "When you done cheking, ";
            // 
            // ErrorLoggingLabel
            // 
            ErrorLoggingLabel.AutoSize = true;
            ErrorLoggingLabel.Location = new Point(12, 194);
            ErrorLoggingLabel.Name = "ErrorLoggingLabel";
            ErrorLoggingLabel.Size = new Size(46, 13);
            ErrorLoggingLabel.TabIndex = 13;
            ErrorLoggingLabel.Text = "exWriter";
            // 
            // CoreForm
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 168);
            Controls.Add(ErrorLoggingLabel);
            Controls.Add(SafemodeActivePanel);
            Controls.Add(SafemodePromptPanel);
            Controls.Add(Button1);
            Controls.Add(timesTick);
            Controls.Add(StatusLabel);
            Controls.Add(PictureBox1);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(StartedonBoot);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CoreForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoreForm";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            SafemodePromptPanel.ResumeLayout(false);
            SafemodePromptPanel.PerformLayout();
            SafemodeActivePanel.ResumeLayout(false);
            SafemodeActivePanel.PerformLayout();
            Load += new EventHandler(CoreForm_Load);
            FormClosing += new FormClosingEventHandler(CoreForm_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label StartedonBoot;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal PictureBox PictureBox1;
        internal Label StatusLabel;
        internal Timer Engine;
        internal Label timesTick;
        internal Timer EngineStopper;
        internal Timer Cloak;
        internal Button Button1;
        internal LinkLabel LinkLabel1;
        internal Timer SafemodeDialog;
        internal Label Label5;
        internal Panel SafemodePromptPanel;
        internal Panel SafemodeActivePanel;
        internal LinkLabel LinkLabel2;
        internal Label Label6;
        internal Label ErrorLoggingLabel;
    }
}