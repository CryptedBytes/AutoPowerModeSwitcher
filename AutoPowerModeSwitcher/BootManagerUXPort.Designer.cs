using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class BootManagerUXPort : Form
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
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            timeLeftEngine = new Timer(components);
            timeLeftEngine.Tick += new EventHandler(timeLeftEngine_Tick);
            Label2 = new Label();
            timeLeft = new Label();
            timePast = new Label();
            timePast.TextChanged += new EventHandler(timePast_TextChanged);
            Timeout = new Timer(components);
            Timeout.Tick += new EventHandler(Timeout_Tick);
            ProcessLabel = new Label();
            ProgressBar1 = new ProgressBar();
            Animation = new Timer(components);
            Animation.Tick += new EventHandler(Animation_Tick);
            CheckBox3 = new CheckBox();
            CheckBox2 = new CheckBox();
            Label1 = new Label();
            Label1.Click += new EventHandler(Label1_Click);
            Engine = new Timer(components);
            Engine.Tick += new EventHandler(Engine_Tick);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            SuspendLayout();
            // 
            // Button2
            // 
            Button2.BackColor = Color.White;
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Segoe UI Light", 8.0f);
            Button2.Location = new Point(295, 32);
            Button2.Name = "Button2";
            Button2.Size = new Size(56, 45);
            Button2.TabIndex = 24;
            Button2.Text = "CANCEL";
            Button2.UseVisualStyleBackColor = false;
            // 
            // timeLeftEngine
            // 
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(115, 108);
            Label2.Name = "Label2";
            Label2.Size = new Size(66, 13);
            Label2.TabIndex = 22;
            Label2.Text = "Auto start in:";
            // 
            // timeLeft
            // 
            timeLeft.AutoSize = true;
            timeLeft.Location = new Point(184, 108);
            timeLeft.Name = "timeLeft";
            timeLeft.Size = new Size(19, 13);
            timeLeft.TabIndex = 21;
            timeLeft.Text = "13";
            // 
            // timePast
            // 
            timePast.AutoSize = true;
            timePast.Location = new Point(190, 95);
            timePast.Name = "timePast";
            timePast.Size = new Size(13, 13);
            timePast.TabIndex = 19;
            timePast.Text = "0";
            timePast.Visible = false;
            // 
            // Timeout
            // 
            Timeout.Enabled = true;
            Timeout.Interval = 1000;
            // 
            // ProcessLabel
            // 
            ProcessLabel.AutoSize = true;
            ProcessLabel.Location = new Point(13, 49);
            ProcessLabel.Name = "ProcessLabel";
            ProcessLabel.Size = new Size(32, 13);
            ProcessLabel.TabIndex = 23;
            ProcessLabel.Text = "False";
            ProcessLabel.Visible = false;
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(291, 102);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(100, 23);
            ProgressBar1.TabIndex = 18;
            ProgressBar1.Visible = false;
            // 
            // Animation
            // 
            Animation.Interval = 1;
            // 
            // CheckBox3
            // 
            CheckBox3.AutoSize = true;
            CheckBox3.Checked = true;
            CheckBox3.CheckState = CheckState.Checked;
            CheckBox3.Location = new Point(250, 79);
            CheckBox3.Name = "CheckBox3";
            CheckBox3.Size = new Size(95, 17);
            CheckBox3.TabIndex = 17;
            CheckBox3.Text = "Prefect iTunes";
            CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Checked = true;
            CheckBox2.CheckState = CheckState.Checked;
            CheckBox2.Location = new Point(12, 79);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(143, 17);
            CheckBox2.TabIndex = 16;
            CheckBox2.Text = "Prefect Google's Chrome";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Light", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(12, 7);
            Label1.Name = "Label1";
            Label1.Size = new Size(334, 20);
            Label1.TabIndex = 14;
            Label1.Text = "Prefetch application data to make them launch faster";
            // 
            // Engine
            // 
            Engine.Interval = 750;
            // 
            // Button1
            // 
            Button1.BackColor = Color.White;
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Segoe UI Light", 17.0f);
            Button1.Location = new Point(56, 32);
            Button1.Name = "Button1";
            Button1.Size = new Size(231, 45);
            Button1.TabIndex = 13;
            Button1.Text = "Prefect now";
            Button1.UseVisualStyleBackColor = false;
            // 
            // BootManagerUXPort
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(357, 125);
            Controls.Add(Button2);
            Controls.Add(Label2);
            Controls.Add(timeLeft);
            Controls.Add(timePast);
            Controls.Add(ProcessLabel);
            Controls.Add(ProgressBar1);
            Controls.Add(CheckBox3);
            Controls.Add(CheckBox2);
            Controls.Add(Label1);
            Controls.Add(Button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BootManagerUXPort";
            Text = "BootManagerUXPort";
            Load += new EventHandler(Form2_Load);
            FormClosing += new FormClosingEventHandler(Form2_FormClosing);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Button2;
        internal Timer timeLeftEngine;
        internal Label Label2;
        internal Label timeLeft;
        internal Label timePast;
        internal Timer Timeout;
        internal Label ProcessLabel;
        internal ProgressBar ProgressBar1;
        internal Timer Animation;
        internal CheckBox CheckBox3;
        internal CheckBox CheckBox2;
        internal Label Label1;
        internal Timer Engine;
        internal Button Button1;
    }
}