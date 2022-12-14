using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Debugging : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Debugging));
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click_1);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click_1);
            Label1 = new Label();
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Label4 = new Label();
            GroupBox1 = new GroupBox();
            CheckBox3 = new CheckBox();
            CheckBox3.CheckedChanged += new EventHandler(CheckBox3_CheckedChanged);
            CheckBox4 = new CheckBox();
            CheckBox4.CheckedChanged += new EventHandler(CheckBox4_CheckedChanged);
            CheckBox2 = new CheckBox();
            CheckBox2.CheckedChanged += new EventHandler(CheckBox2_CheckedChanged);
            CheckBox1 = new CheckBox();
            CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            GroupBox2 = new GroupBox();
            Label3 = new Label();
            CheckBox5 = new CheckBox();
            CheckBox5.CheckedChanged += new EventHandler(CheckBox5_CheckedChanged);
            CheckBox6 = new CheckBox();
            CheckBox6.CheckedChanged += new EventHandler(CheckBox6_CheckedChanged);
            CheckBox7 = new CheckBox();
            CheckBox7.CheckedChanged += new EventHandler(CheckBox7_CheckedChanged);
            CheckBox8 = new CheckBox();
            CheckBox8.CheckedChanged += new EventHandler(CheckBox8_CheckedChanged);
            Panel1 = new Panel();
            CheckBox9 = new CheckBox();
            CheckBox9.CheckedChanged += new EventHandler(CheckBox9_CheckedChanged);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            Label5 = new Label();
            LinkLabel1 = new LinkLabel();
            LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            LinkLabel2 = new LinkLabel();
            LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button3
            // 
            Button3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.ForeColor = Color.Black;
            Button3.Location = new Point(12, 61);
            Button3.Name = "Button3";
            Button3.Size = new Size(125, 54);
            Button3.TabIndex = 48;
            Button3.Text = "Access to " + '\r' + '\n' + "Settings Database (Deprecated)" + '\r' + '\n';
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.ForeColor = Color.Black;
            Button2.Location = new Point(154, 61);
            Button2.Name = "Button2";
            Button2.Size = new Size(118, 54);
            Button2.TabIndex = 49;
            Button2.Text = "Throw an Unxpected Exception";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.25f);
            Label1.Location = new Point(169, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(175, 20);
            Label1.TabIndex = 50;
            Label1.Text = "Debug this application";
            // 
            // Button4
            // 
            Button4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button4.ForeColor = Color.Black;
            Button4.Location = new Point(12, 121);
            Button4.Name = "Button4";
            Button4.Size = new Size(125, 54);
            Button4.TabIndex = 55;
            Button4.Text = "Access to " + '\r' + '\n' + "Statistics Database";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
            Button5.ForeColor = Color.Red;
            Button5.Location = new Point(154, 121);
            Button5.Name = "Button5";
            Button5.Size = new Size(118, 54);
            Button5.TabIndex = 56;
            Button5.Text = "RESET Settings";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = Color.Red;
            Label4.Location = new Point(170, 174);
            Label4.Name = "Label4";
            Label4.Size = new Size(89, 13);
            Label4.TabIndex = 57;
            Label4.Text = "Use with caution.";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(CheckBox3);
            GroupBox1.Controls.Add(CheckBox4);
            GroupBox1.Controls.Add(CheckBox2);
            GroupBox1.Controls.Add(CheckBox1);
            GroupBox1.Location = new Point(415, 61);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(107, 150);
            GroupBox1.TabIndex = 58;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Load/unload unused forms ";
            // 
            // CheckBox3
            // 
            CheckBox3.AutoSize = true;
            CheckBox3.Location = new Point(5, 104);
            CheckBox3.Name = "CheckBox3";
            CheckBox3.Size = new Size(110, 17);
            CheckBox3.TabIndex = 3;
            CheckBox3.Text = "SettingsDatabase";
            CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox4
            // 
            CheckBox4.AutoSize = true;
            CheckBox4.Location = new Point(6, 81);
            CheckBox4.Name = "CheckBox4";
            CheckBox4.Size = new Size(97, 17);
            CheckBox4.TabIndex = 2;
            CheckBox4.Text = "InstallerModule";
            CheckBox4.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Location = new Point(6, 59);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(103, 17);
            CheckBox2.TabIndex = 1;
            CheckBox2.Text = "BootManUXPort";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(7, 36);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(85, 17);
            CheckBox1.TabIndex = 0;
            CheckBox1.Text = "PreBootMan";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Label3);
            GroupBox2.Controls.Add(CheckBox5);
            GroupBox2.Controls.Add(CheckBox6);
            GroupBox2.Controls.Add(CheckBox7);
            GroupBox2.Controls.Add(CheckBox8);
            GroupBox2.Location = new Point(302, 61);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(107, 150);
            GroupBox2.TabIndex = 59;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Load/unload forms";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = Color.Red;
            Label3.Location = new Point(1, 29);
            Label3.Name = "Label3";
            Label3.Size = new Size(104, 13);
            Label3.TabIndex = 60;
            Label3.Text = "May cause instability";
            // 
            // CheckBox5
            // 
            CheckBox5.AutoSize = true;
            CheckBox5.Location = new Point(5, 113);
            CheckBox5.Name = "CheckBox5";
            CheckBox5.Size = new Size(47, 17);
            CheckBox5.TabIndex = 3;
            CheckBox5.Text = "APS";
            CheckBox5.UseVisualStyleBackColor = true;
            // 
            // CheckBox6
            // 
            CheckBox6.AutoSize = true;
            CheckBox6.Location = new Point(6, 90);
            CheckBox6.Name = "CheckBox6";
            CheckBox6.Size = new Size(140, 17);
            CheckBox6.TabIndex = 2;
            CheckBox6.Text = "UserPreferencesModule";
            CheckBox6.UseVisualStyleBackColor = true;
            // 
            // CheckBox7
            // 
            CheckBox7.AutoSize = true;
            CheckBox7.Location = new Point(6, 68);
            CheckBox7.Name = "CheckBox7";
            CheckBox7.Size = new Size(71, 17);
            CheckBox7.TabIndex = 1;
            CheckBox7.Text = "CoreForm";
            CheckBox7.UseVisualStyleBackColor = true;
            // 
            // CheckBox8
            // 
            CheckBox8.AutoSize = true;
            CheckBox8.Location = new Point(7, 45);
            CheckBox8.Name = "CheckBox8";
            CheckBox8.Size = new Size(55, 17);
            CheckBox8.TabIndex = 0;
            CheckBox8.Text = "Form1";
            CheckBox8.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(LinkLabel1);
            Panel1.Controls.Add(CheckBox9);
            Panel1.Controls.Add(Button6);
            Panel1.Controls.Add(Label5);
            Panel1.Location = new Point(1, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(518, 229);
            Panel1.TabIndex = 60;
            // 
            // CheckBox9
            // 
            CheckBox9.AutoSize = true;
            CheckBox9.Location = new Point(178, 129);
            CheckBox9.Name = "CheckBox9";
            CheckBox9.Size = new Size(154, 17);
            CheckBox9.TabIndex = 2;
            CheckBox9.Text = "I've read it all, let me to see";
            CheckBox9.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.Font = new Font("Microsoft Sans Serif", 13.25f);
            Button6.Location = new Point(137, 152);
            Button6.Name = "Button6";
            Button6.Size = new Size(255, 58);
            Button6.TabIndex = 1;
            Button6.Text = "No way! I'm leaving";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.Red;
            Label5.Location = new Point(14, 42);
            Label5.Name = "Label5";
            Label5.Size = new Size(488, 75);
            Label5.TabIndex = 0;
            Label5.Text = resources.GetString("Label5.Text");
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(4, 24);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(41, 13);
            LinkLabel1.TabIndex = 3;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Reveal";
            // 
            // LinkLabel2
            // 
            LinkLabel2.AutoSize = true;
            LinkLabel2.Location = new Point(-2, 13);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(29, 13);
            LinkLabel2.TabIndex = 61;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "Hide";
            // 
            // Debugging
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 246);
            Controls.Add(Panel1);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(Label4);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Label1);
            Controls.Add(Button2);
            Controls.Add(Button3);
            Controls.Add(LinkLabel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Debugging";
            ShowIcon = false;
            Text = "Old debug panel";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Debugging_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Button3;
        internal Button Button2;
        internal Label Label1;
        internal Button Button4;
        internal Button Button5;
        internal Label Label4;
        internal GroupBox GroupBox1;
        internal CheckBox CheckBox3;
        internal CheckBox CheckBox4;
        internal CheckBox CheckBox2;
        internal CheckBox CheckBox1;
        internal GroupBox GroupBox2;
        internal CheckBox CheckBox5;
        internal CheckBox CheckBox6;
        internal CheckBox CheckBox7;
        internal CheckBox CheckBox8;
        internal Label Label3;
        internal Panel Panel1;
        internal CheckBox CheckBox9;
        internal Button Button6;
        internal Label Label5;
        internal LinkLabel LinkLabel1;
        internal LinkLabel LinkLabel2;
    }
}