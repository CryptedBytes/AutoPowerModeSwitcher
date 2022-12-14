using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PreBootManager : Form
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
            ProgressBar1 = new ProgressBar();
            Engine = new Timer(components);
            Engine.Tick += new EventHandler(Engine_Tick);
            Timeout = new Timer(components);
            CheckBox4 = new CheckBox();
            Button2 = new Button();
            Label2 = new Label();
            Label1 = new Label();
            Label1.Click += new EventHandler(Label1_Click);
            CheckBox3 = new CheckBox();
            CheckBox1 = new CheckBox();
            CheckBox2 = new CheckBox();
            Button1 = new Button();
            SuspendLayout();
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(12, 12);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(100, 23);
            ProgressBar1.TabIndex = 19;
            // 
            // Engine
            // 
            // 
            // CheckBox4
            // 
            CheckBox4.AutoSize = true;
            CheckBox4.Location = new Point(89, 185);
            CheckBox4.Name = "CheckBox4";
            CheckBox4.Size = new Size(161, 17);
            CheckBox4.TabIndex = 18;
            CheckBox4.Text = "And do not display this again";
            CheckBox4.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Location = new Point(430, 142);
            Button2.Name = "Button2";
            Button2.Size = new Size(151, 37);
            Button2.TabIndex = 17;
            Button2.Text = "Prefetch selected ones";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Light", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(98, 114);
            Label2.Name = "Label2";
            Label2.Size = new Size(442, 21);
            Label2.TabIndex = 16;
            Label2.Text = "If you do not respond in 6 seconds , we will automatically prefect.";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Light", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(13, 24);
            Label1.Name = "Label1";
            Label1.Size = new Size(576, 42);
            Label1.TabIndex = 14;
            Label1.Text = "                                                 Your system has just started." + '\r' + '\n' + "C" + "hoose applications which we should prefetch before you start to use your compute" + "r";
            // 
            // CheckBox3
            // 
            CheckBox3.AutoSize = true;
            CheckBox3.Checked = true;
            CheckBox3.CheckState = CheckState.Checked;
            CheckBox3.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox3.Location = new Point(453, 86);
            CheckBox3.Name = "CheckBox3";
            CheckBox3.Size = new Size(74, 25);
            CheckBox3.TabIndex = 10;
            CheckBox3.Text = "iTunes";
            CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = CheckState.Checked;
            CheckBox1.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox1.Location = new Point(67, 86);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(150, 25);
            CheckBox1.TabIndex = 8;
            CheckBox1.Text = "Google's Chrome";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Checked = true;
            CheckBox2.CheckState = CheckState.Checked;
            CheckBox2.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox2.Location = new Point(248, 86);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(159, 25);
            CheckBox2.TabIndex = 9;
            CheckBox2.Text = "Visual Studio 2015";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(89, 142);
            Button1.Name = "Button1";
            Button1.Size = new Size(151, 37);
            Button1.TabIndex = 15;
            Button1.Text = "Do not prefetch";
            Button1.UseVisualStyleBackColor = true;
            // 
            // PreBootManager
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 212);
            Controls.Add(ProgressBar1);
            Controls.Add(CheckBox4);
            Controls.Add(Button2);
            Controls.Add(Label2);
            Controls.Add(Button1);
            Controls.Add(Label1);
            Controls.Add(CheckBox2);
            Controls.Add(CheckBox1);
            Controls.Add(CheckBox3);
            Name = "PreBootManager";
            Text = "PreBootManager";
            Load += new EventHandler(PreBootManager_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal ProgressBar ProgressBar1;
        internal Timer Engine;
        internal Timer Timeout;
        internal CheckBox CheckBox4;
        internal Button Button2;
        internal Label Label2;
        internal Label Label1;
        internal CheckBox CheckBox3;
        internal CheckBox CheckBox1;
        internal CheckBox CheckBox2;
        internal Button Button1;
    }
}