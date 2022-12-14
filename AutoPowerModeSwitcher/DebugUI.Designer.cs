using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DebugUI : Form
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
            Label1 = new Label();
            CheckPowerPlanTickCount = new Label();
            Label2 = new Label();
            SetPowerPlanTickCount = new Label();
            MemOptimizer = new Label();
            MemOptimizerTickCount = new Label();
            ProcessDetectorTickCount = new Label();
            Label4 = new Label();
            SetPowerPlanAlternateTickCount = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label10 = new Label();
            AutoPilotDetectionTickCount = new Label();
            Label5 = new Label();
            Label3 = new Label();
            Label9 = new Label();
            CheckBox13 = new CheckBox();
            CheckBox13.CheckedChanged += new EventHandler(CheckBox13_CheckedChanged);
            CheckBox24 = new CheckBox();
            CheckBox24.CheckedChanged += new EventHandler(CheckBox24_CheckedChanged);
            GroupBox2 = new GroupBox();
            Panel2 = new Panel();
            Label15 = new Label();
            LinkLabel1 = new LinkLabel();
            LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            CheckBox15 = new CheckBox();
            Label11 = new Label();
            CheckBox5 = new CheckBox();
            CheckBox5.CheckedChanged += new EventHandler(CheckBox5_CheckedChanged);
            CheckBox6 = new CheckBox();
            CheckBox6.CheckedChanged += new EventHandler(CheckBox6_CheckedChanged);
            CheckBox7 = new CheckBox();
            CheckBox7.CheckedChanged += new EventHandler(CheckBox7_CheckedChanged);
            CheckBox8 = new CheckBox();
            CheckBox8.CheckedChanged += new EventHandler(CheckBox8_CheckedChanged);
            GroupBox1 = new GroupBox();
            CheckBox16 = new CheckBox();
            CheckBox16.CheckedChanged += new EventHandler(CheckBox16_CheckedChanged);
            CheckBox3 = new CheckBox();
            CheckBox3.CheckedChanged += new EventHandler(CheckBox3_CheckedChanged);
            CheckBox1 = new CheckBox();
            CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            CheckBox2 = new CheckBox();
            CheckBox2.CheckedChanged += new EventHandler(CheckBox2_CheckedChanged);
            CheckBox9 = new CheckBox();
            CheckBox9.CheckedChanged += new EventHandler(CheckBox9_CheckedChanged);
            Label12 = new Label();
            GroupBox3 = new GroupBox();
            CheckBox22 = new CheckBox();
            CheckBox22.CheckedChanged += new EventHandler(CheckBox22_CheckedChanged);
            CheckBox21 = new CheckBox();
            CheckBox21.CheckedChanged += new EventHandler(CheckBox21_CheckedChanged);
            CheckBox20 = new CheckBox();
            CheckBox20.CheckedChanged += new EventHandler(CheckBox20_CheckedChanged);
            CheckBox19 = new CheckBox();
            CheckBox19.CheckedChanged += new EventHandler(CheckBox19_CheckedChanged);
            CheckBox18 = new CheckBox();
            CheckBox18.CheckedChanged += new EventHandler(CheckBox18_CheckedChanged);
            CheckBox14 = new CheckBox();
            CheckBox14.CheckedChanged += new EventHandler(CheckBox14_CheckedChanged);
            CheckBox4 = new CheckBox();
            CheckBox4.CheckedChanged += new EventHandler(CheckBox4_CheckedChanged_1);
            CheckBox10 = new CheckBox();
            CheckBox10.CheckedChanged += new EventHandler(CheckBox10_CheckedChanged);
            CheckBox11 = new CheckBox();
            CheckBox11.CheckedChanged += new EventHandler(CheckBox11_CheckedChanged);
            CheckBox12 = new CheckBox();
            CheckBox12.CheckedChanged += new EventHandler(CheckBox12_CheckedChanged);
            Panel1 = new Panel();
            LinkLabel2 = new LinkLabel();
            LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            Label13 = new Label();
            GetOpenForms = new Timer(components);
            GetOpenForms.Tick += new EventHandler(Timer1_Tick);
            Label14 = new Label();
            CheckBox17 = new CheckBox();
            CheckBox17.CheckedChanged += new EventHandler(CheckBox17_CheckedChanged);
            Label16 = new Label();
            PowerPlanChangeTrigger = new Label();
            VerboseAutoPilot = new Label();
            Label18 = new Label();
            Label19 = new Label();
            CheckBox23 = new CheckBox();
            CheckBox23.CheckedChanged += new EventHandler(CheckBox23_CheckedChanged);
            GroupBox2.SuspendLayout();
            Panel2.SuspendLayout();
            GroupBox1.SuspendLayout();
            GroupBox3.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label1.Location = new Point(12, 91);
            Label1.Name = "Label1";
            Label1.Size = new Size(111, 16);
            Label1.TabIndex = 0;
            Label1.Text = "CheckPowerPlan";
            // 
            // CheckPowerPlanTickCount
            // 
            CheckPowerPlanTickCount.AutoSize = true;
            CheckPowerPlanTickCount.Font = new Font("Microsoft Sans Serif", 9.25f);
            CheckPowerPlanTickCount.Location = new Point(211, 91);
            CheckPowerPlanTickCount.Name = "CheckPowerPlanTickCount";
            CheckPowerPlanTickCount.Size = new Size(15, 16);
            CheckPowerPlanTickCount.TabIndex = 1;
            CheckPowerPlanTickCount.Text = "0";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label2.Location = new Point(12, 119);
            Label2.Name = "Label2";
            Label2.Size = new Size(176, 16);
            Label2.TabIndex = 2;
            Label2.Text = "SetPowerPlan (Deprecated)";
            // 
            // SetPowerPlanTickCount
            // 
            SetPowerPlanTickCount.AutoSize = true;
            SetPowerPlanTickCount.Font = new Font("Microsoft Sans Serif", 9.25f);
            SetPowerPlanTickCount.Location = new Point(210, 119);
            SetPowerPlanTickCount.Name = "SetPowerPlanTickCount";
            SetPowerPlanTickCount.Size = new Size(15, 16);
            SetPowerPlanTickCount.TabIndex = 3;
            SetPowerPlanTickCount.Text = "0";
            // 
            // MemOptimizer
            // 
            MemOptimizer.AutoSize = true;
            MemOptimizer.Font = new Font("Microsoft Sans Serif", 9.25f);
            MemOptimizer.Location = new Point(13, 176);
            MemOptimizer.Name = "MemOptimizer";
            MemOptimizer.Size = new Size(94, 16);
            MemOptimizer.TabIndex = 4;
            MemOptimizer.Text = "MemOptimizer";
            // 
            // MemOptimizerTickCount
            // 
            MemOptimizerTickCount.AutoSize = true;
            MemOptimizerTickCount.Font = new Font("Microsoft Sans Serif", 9.25f);
            MemOptimizerTickCount.Location = new Point(211, 176);
            MemOptimizerTickCount.Name = "MemOptimizerTickCount";
            MemOptimizerTickCount.Size = new Size(15, 16);
            MemOptimizerTickCount.TabIndex = 5;
            MemOptimizerTickCount.Text = "0";
            // 
            // ProcessDetectorTickCount
            // 
            ProcessDetectorTickCount.AutoSize = true;
            ProcessDetectorTickCount.Font = new Font("Microsoft Sans Serif", 9.25f);
            ProcessDetectorTickCount.Location = new Point(210, 204);
            ProcessDetectorTickCount.Name = "ProcessDetectorTickCount";
            ProcessDetectorTickCount.Size = new Size(15, 16);
            ProcessDetectorTickCount.TabIndex = 7;
            ProcessDetectorTickCount.Text = "0";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label4.Location = new Point(12, 204);
            Label4.Name = "Label4";
            Label4.Size = new Size(109, 16);
            Label4.TabIndex = 6;
            Label4.Text = "ProcessDetector";
            // 
            // SetPowerPlanAlternateTickCount
            // 
            SetPowerPlanAlternateTickCount.AutoSize = true;
            SetPowerPlanAlternateTickCount.Font = new Font("Microsoft Sans Serif", 9.25f);
            SetPowerPlanAlternateTickCount.Location = new Point(210, 148);
            SetPowerPlanAlternateTickCount.Name = "SetPowerPlanAlternateTickCount";
            SetPowerPlanAlternateTickCount.Size = new Size(15, 16);
            SetPowerPlanAlternateTickCount.TabIndex = 9;
            SetPowerPlanAlternateTickCount.Text = "0";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label6.Location = new Point(12, 148);
            Label6.Name = "Label6";
            Label6.Size = new Size(146, 16);
            Label6.TabIndex = 8;
            Label6.Text = "SetPowerPlanAlternate";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(12, 69);
            Label7.Name = "Label7";
            Label7.Size = new Size(94, 15);
            Label7.TabIndex = 10;
            Label7.Text = "Engine Name";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(182, 69);
            Label8.Name = "Label8";
            Label8.Size = new Size(74, 15);
            Label8.TabIndex = 11;
            Label8.Text = "Tick Count";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.ForeColor = Color.Black;
            Label10.Location = new Point(8, 9);
            Label10.Name = "Label10";
            Label10.Size = new Size(360, 19);
            Label10.TabIndex = 12;
            Label10.Text = "CryptedBytes Authorized Debugging Interface";
            // 
            // AutoPilotDetectionTickCount
            // 
            AutoPilotDetectionTickCount.AutoSize = true;
            AutoPilotDetectionTickCount.Font = new Font("Microsoft Sans Serif", 9.25f);
            AutoPilotDetectionTickCount.Location = new Point(211, 225);
            AutoPilotDetectionTickCount.Name = "AutoPilotDetectionTickCount";
            AutoPilotDetectionTickCount.Size = new Size(15, 16);
            AutoPilotDetectionTickCount.TabIndex = 14;
            AutoPilotDetectionTickCount.Text = "0";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label5.Location = new Point(13, 226);
            Label5.Name = "Label5";
            Label5.Size = new Size(118, 16);
            Label5.TabIndex = 13;
            Label5.Text = "AutoPilotDetection";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label3.Location = new Point(211, 248);
            Label3.Name = "Label3";
            Label3.Size = new Size(15, 16);
            Label3.TabIndex = 16;
            Label3.Text = "0";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label9.Location = new Point(13, 248);
            Label9.Name = "Label9";
            Label9.Size = new Size(63, 16);
            Label9.TabIndex = 15;
            Label9.Text = "UIEngine";
            // 
            // CheckBox13
            // 
            CheckBox13.AutoSize = true;
            CheckBox13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckBox13.ForeColor = Color.Red;
            CheckBox13.Location = new Point(349, 302);
            CheckBox13.Name = "CheckBox13";
            CheckBox13.Size = new Size(195, 17);
            CheckBox13.TabIndex = 61;
            CheckBox13.Text = "FORCE user-tracking features";
            CheckBox13.UseVisualStyleBackColor = true;
            CheckBox13.Visible = false;
            // 
            // CheckBox24
            // 
            CheckBox24.AutoSize = true;
            CheckBox24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckBox24.ForeColor = Color.Red;
            CheckBox24.Location = new Point(12, 298);
            CheckBox24.Name = "CheckBox24";
            CheckBox24.Size = new Size(331, 17);
            CheckBox24.TabIndex = 60;
            CheckBox24.Text = "DO NOT let user override target process on main form";
            CheckBox24.UseVisualStyleBackColor = true;
            CheckBox24.Visible = false;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Panel2);
            GroupBox2.Controls.Add(CheckBox15);
            GroupBox2.Controls.Add(Label11);
            GroupBox2.Controls.Add(CheckBox5);
            GroupBox2.Controls.Add(CheckBox6);
            GroupBox2.Controls.Add(CheckBox7);
            GroupBox2.Controls.Add(CheckBox8);
            GroupBox2.Location = new Point(283, 91);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(107, 157);
            GroupBox2.TabIndex = 62;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Load/unload common forms";
            // 
            // Panel2
            // 
            Panel2.Controls.Add(Label15);
            Panel2.Controls.Add(LinkLabel1);
            Panel2.Location = new Point(2, 28);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(105, 123);
            Panel2.TabIndex = 67;
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.ForeColor = Color.Red;
            Label15.Location = new Point(7, 4);
            Label15.Name = "Label15";
            Label15.Size = new Size(83, 91);
            Label15.TabIndex = 0;
            Label15.Text = "This feature is " + '\r' + '\n' + "reported to be" + '\r' + '\n' + "causing serious " + '\r' + '\n' + "crashes. Please" + '\r' + '\n' + "keep it disa" + "bled" + '\r' + '\n' + "However, you" + '\r' + '\n' + "can enable it";
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(8, 99);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(89, 13);
            LinkLabel1.TabIndex = 1;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Enable and show";
            // 
            // CheckBox15
            // 
            CheckBox15.AutoSize = true;
            CheckBox15.Location = new Point(4, 134);
            CheckBox15.Name = "CheckBox15";
            CheckBox15.Size = new Size(100, 17);
            CheckBox15.TabIndex = 61;
            CheckBox15.Text = "DebugInterface";
            CheckBox15.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.ForeColor = Color.Red;
            Label11.Location = new Point(17, 28);
            Label11.Name = "Label11";
            Label11.Size = new Size(71, 13);
            Label11.TabIndex = 60;
            Label11.Text = "May not work";
            // 
            // CheckBox5
            // 
            CheckBox5.AutoSize = true;
            CheckBox5.Location = new Point(5, 113);
            CheckBox5.Name = "CheckBox5";
            CheckBox5.Size = new Size(119, 17);
            CheckBox5.TabIndex = 3;
            CheckBox5.Text = "AutoPowerSwitcher";
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
            // GroupBox1
            // 
            GroupBox1.Controls.Add(CheckBox16);
            GroupBox1.Controls.Add(CheckBox3);
            GroupBox1.Controls.Add(CheckBox1);
            GroupBox1.Controls.Add(CheckBox2);
            GroupBox1.Controls.Add(CheckBox9);
            GroupBox1.Location = new Point(419, 91);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(125, 157);
            GroupBox1.TabIndex = 61;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Load/unload unused forms ";
            // 
            // CheckBox16
            // 
            CheckBox16.AutoSize = true;
            CheckBox16.Location = new Point(2, 123);
            CheckBox16.Name = "CheckBox16";
            CheckBox16.Size = new Size(126, 17);
            CheckBox16.TabIndex = 4;
            CheckBox16.Text = "MemoryLeakTestLab";
            CheckBox16.UseVisualStyleBackColor = true;
            // 
            // CheckBox3
            // 
            CheckBox3.AutoSize = true;
            CheckBox3.Location = new Point(5, 104);
            CheckBox3.Name = "CheckBox3";
            CheckBox3.Size = new Size(101, 17);
            CheckBox3.TabIndex = 3;
            CheckBox3.Text = "Debugger_OLD";
            CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(6, 81);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(97, 17);
            CheckBox1.TabIndex = 2;
            CheckBox1.Text = "InstallerModule";
            CheckBox1.UseVisualStyleBackColor = true;
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
            // CheckBox9
            // 
            CheckBox9.AutoSize = true;
            CheckBox9.Location = new Point(7, 36);
            CheckBox9.Name = "CheckBox9";
            CheckBox9.Size = new Size(85, 17);
            CheckBox9.TabIndex = 0;
            CheckBox9.Text = "PreBootMan";
            CheckBox9.UseVisualStyleBackColor = true;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label12.Location = new Point(313, 45);
            Label12.Name = "Label12";
            Label12.Size = new Size(175, 15);
            Label12.TabIndex = 63;
            Label12.Text = "GLOBAL FORM MANAGER";
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(CheckBox23);
            GroupBox3.Controls.Add(CheckBox22);
            GroupBox3.Controls.Add(CheckBox21);
            GroupBox3.Controls.Add(CheckBox20);
            GroupBox3.Controls.Add(CheckBox19);
            GroupBox3.Controls.Add(CheckBox18);
            GroupBox3.Controls.Add(CheckBox14);
            GroupBox3.Controls.Add(CheckBox4);
            GroupBox3.Controls.Add(CheckBox10);
            GroupBox3.Controls.Add(CheckBox11);
            GroupBox3.Controls.Add(CheckBox12);
            GroupBox3.Location = new Point(553, 71);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(384, 193);
            GroupBox3.TabIndex = 63;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Commands";
            // 
            // CheckBox22
            // 
            CheckBox22.AutoSize = true;
            CheckBox22.Location = new Point(250, 42);
            CheckBox22.Name = "CheckBox22";
            CheckBox22.Size = new Size(107, 17);
            CheckBox22.TabIndex = 73;
            CheckBox22.Text = "Throw testing log";
            CheckBox22.UseVisualStyleBackColor = true;
            // 
            // CheckBox21
            // 
            CheckBox21.AutoSize = true;
            CheckBox21.Location = new Point(250, 19);
            CheckBox21.Name = "CheckBox21";
            CheckBox21.Size = new Size(128, 17);
            CheckBox21.TabIndex = 72;
            CheckBox21.Text = "Call GarbageCollector";
            CheckBox21.UseVisualStyleBackColor = true;
            // 
            // CheckBox20
            // 
            CheckBox20.AutoSize = true;
            CheckBox20.Location = new Point(5, 175);
            CheckBox20.Name = "CheckBox20";
            CheckBox20.Size = new Size(152, 17);
            CheckBox20.TabIndex = 71;
            CheckBox20.Text = "Test FailFast() conditioning";
            CheckBox20.UseVisualStyleBackColor = true;
            // 
            // CheckBox19
            // 
            CheckBox19.AutoSize = true;
            CheckBox19.Location = new Point(5, 157);
            CheckBox19.Name = "CheckBox19";
            CheckBox19.Size = new Size(135, 17);
            CheckBox19.TabIndex = 70;
            CheckBox19.Text = "Enable legacy services";
            CheckBox19.UseVisualStyleBackColor = true;
            // 
            // CheckBox18
            // 
            CheckBox18.AutoSize = true;
            CheckBox18.Location = new Point(5, 134);
            CheckBox18.Name = "CheckBox18";
            CheckBox18.Size = new Size(127, 17);
            CheckBox18.TabIndex = 69;
            CheckBox18.Text = "Disable ResizingForm";
            CheckBox18.UseVisualStyleBackColor = true;
            // 
            // CheckBox14
            // 
            CheckBox14.AutoSize = true;
            CheckBox14.Location = new Point(5, 110);
            CheckBox14.Name = "CheckBox14";
            CheckBox14.Size = new Size(105, 17);
            CheckBox14.TabIndex = 4;
            CheckBox14.Text = "Disable coreform";
            CheckBox14.UseVisualStyleBackColor = true;
            // 
            // CheckBox4
            // 
            CheckBox4.AutoSize = true;
            CheckBox4.Location = new Point(6, 86);
            CheckBox4.Name = "CheckBox4";
            CheckBox4.Size = new Size(126, 17);
            CheckBox4.TabIndex = 3;
            CheckBox4.Text = "FORCE user-tracking";
            CheckBox4.UseVisualStyleBackColor = true;
            // 
            // CheckBox10
            // 
            CheckBox10.AutoSize = true;
            CheckBox10.Location = new Point(5, 63);
            CheckBox10.Name = "CheckBox10";
            CheckBox10.Size = new Size(216, 17);
            CheckBox10.TabIndex = 2;
            CheckBox10.Text = "DO NOT let user override target process";
            CheckBox10.UseVisualStyleBackColor = true;
            // 
            // CheckBox11
            // 
            CheckBox11.AutoSize = true;
            CheckBox11.Location = new Point(6, 42);
            CheckBox11.Name = "CheckBox11";
            CheckBox11.Size = new Size(106, 17);
            CheckBox11.TabIndex = 1;
            CheckBox11.Text = "Throw Exception";
            CheckBox11.UseVisualStyleBackColor = true;
            // 
            // CheckBox12
            // 
            CheckBox12.AutoSize = true;
            CheckBox12.Location = new Point(6, 19);
            CheckBox12.Name = "CheckBox12";
            CheckBox12.Size = new Size(114, 17);
            CheckBox12.TabIndex = 0;
            CheckBox12.Text = "RESET all settings";
            CheckBox12.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(LinkLabel2);
            Panel1.Location = new Point(604, 268);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(541, 40);
            Panel1.TabIndex = 64;
            // 
            // LinkLabel2
            // 
            LinkLabel2.AutoSize = true;
            LinkLabel2.Location = new Point(15, 11);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(59, 13);
            LinkLabel2.TabIndex = 0;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "Hide Panel";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label13.Location = new Point(550, 45);
            Label13.Name = "Label13";
            Label13.Size = new Size(154, 15);
            Label13.TabIndex = 65;
            Label13.Text = "EXECUTE COMMANDS";
            // 
            // GetOpenForms
            // 
            GetOpenForms.Enabled = true;
            GetOpenForms.Interval = 1;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(550, 291);
            Label14.Name = "Label14";
            Label14.Size = new Size(32, 13);
            Label14.TabIndex = 66;
            Label14.Text = "False";
            Label14.Visible = false;
            // 
            // CheckBox17
            // 
            CheckBox17.AutoSize = true;
            CheckBox17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckBox17.ForeColor = Color.Red;
            CheckBox17.Location = new Point(349, 279);
            CheckBox17.Name = "CheckBox17";
            CheckBox17.Size = new Size(164, 17);
            CheckBox17.TabIndex = 68;
            CheckBox17.Text = "FORCE enable AutoPilot";
            CheckBox17.UseVisualStyleBackColor = true;
            CheckBox17.Visible = false;
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Font = new Font("Microsoft Sans Serif", 9.25f);
            Label16.Location = new Point(12, 272);
            Label16.Name = "Label16";
            Label16.Size = new Size(164, 16);
            Label16.TabIndex = 69;
            Label16.Text = "PowerPlanChangeTrigger";
            // 
            // PowerPlanChangeTrigger
            // 
            PowerPlanChangeTrigger.AutoSize = true;
            PowerPlanChangeTrigger.Font = new Font("Microsoft Sans Serif", 9.25f);
            PowerPlanChangeTrigger.Location = new Point(211, 272);
            PowerPlanChangeTrigger.Name = "PowerPlanChangeTrigger";
            PowerPlanChangeTrigger.Size = new Size(15, 16);
            PowerPlanChangeTrigger.TabIndex = 69;
            PowerPlanChangeTrigger.Text = "0";
            // 
            // VerboseAutoPilot
            // 
            VerboseAutoPilot.AutoSize = true;
            VerboseAutoPilot.Location = new Point(1016, 90);
            VerboseAutoPilot.Name = "VerboseAutoPilot";
            VerboseAutoPilot.Size = new Size(89, 13);
            VerboseAutoPilot.TabIndex = 71;
            VerboseAutoPilot.Text = "No data received";
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label18.Location = new Point(59, 45);
            Label18.Name = "Label18";
            Label18.Size = new Size(181, 15);
            Label18.TabIndex = 10;
            Label18.Text = "ENGINE VERBOSE UTILITY";
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label19.Location = new Point(970, 45);
            Label19.Name = "Label19";
            Label19.Size = new Size(207, 15);
            Label19.TabIndex = 65;
            Label19.Text = "AUTOPILOT STATUS CHECKER";
            // 
            // CheckBox23
            // 
            CheckBox23.AutoSize = true;
            CheckBox23.Location = new Point(250, 65);
            CheckBox23.Name = "CheckBox23";
            CheckBox23.Size = new Size(123, 17);
            CheckBox23.TabIndex = 74;
            CheckBox23.Text = "Show Form1 bounds";
            CheckBox23.UseVisualStyleBackColor = true;
            // 
            // DebugUI
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 320);
            Controls.Add(VerboseAutoPilot);
            Controls.Add(PowerPlanChangeTrigger);
            Controls.Add(Label16);
            Controls.Add(CheckBox17);
            Controls.Add(Label14);
            Controls.Add(Label19);
            Controls.Add(Label13);
            Controls.Add(Panel1);
            Controls.Add(GroupBox3);
            Controls.Add(Label12);
            Controls.Add(GroupBox1);
            Controls.Add(GroupBox2);
            Controls.Add(CheckBox13);
            Controls.Add(CheckBox24);
            Controls.Add(Label3);
            Controls.Add(Label9);
            Controls.Add(AutoPilotDetectionTickCount);
            Controls.Add(Label5);
            Controls.Add(Label10);
            Controls.Add(Label8);
            Controls.Add(Label18);
            Controls.Add(Label7);
            Controls.Add(SetPowerPlanAlternateTickCount);
            Controls.Add(Label6);
            Controls.Add(ProcessDetectorTickCount);
            Controls.Add(Label4);
            Controls.Add(MemOptimizerTickCount);
            Controls.Add(MemOptimizer);
            Controls.Add(SetPowerPlanTickCount);
            Controls.Add(Label2);
            Controls.Add(CheckPowerPlanTickCount);
            Controls.Add(Label1);
            MaximizeBox = false;
            Name = "DebugUI";
            ShowIcon = false;
            Text = "Debugger User Interface";
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Statistics_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label CheckPowerPlanTickCount;
        internal Label Label2;
        internal Label SetPowerPlanTickCount;
        internal Label MemOptimizer;
        internal Label MemOptimizerTickCount;
        internal Label ProcessDetectorTickCount;
        internal Label Label4;
        internal Label SetPowerPlanAlternateTickCount;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label10;
        internal Label AutoPilotDetectionTickCount;
        internal Label Label5;
        internal Label Label3;
        internal Label Label9;
        internal CheckBox CheckBox13;
        internal CheckBox CheckBox24;
        internal GroupBox GroupBox2;
        internal Label Label11;
        internal CheckBox CheckBox5;
        internal CheckBox CheckBox6;
        internal CheckBox CheckBox7;
        internal CheckBox CheckBox8;
        internal GroupBox GroupBox1;
        internal CheckBox CheckBox3;
        internal CheckBox CheckBox1;
        internal CheckBox CheckBox2;
        internal CheckBox CheckBox9;
        internal Label Label12;
        internal GroupBox GroupBox3;
        internal CheckBox CheckBox4;
        internal CheckBox CheckBox10;
        internal CheckBox CheckBox11;
        internal CheckBox CheckBox12;
        internal Panel Panel1;
        internal Label Label13;
        internal CheckBox CheckBox14;
        internal Timer GetOpenForms;
        internal CheckBox CheckBox15;
        internal Label Label14;
        internal Panel Panel2;
        internal LinkLabel LinkLabel1;
        internal Label Label15;
        internal CheckBox CheckBox16;
        internal CheckBox CheckBox17;
        internal CheckBox CheckBox18;
        internal LinkLabel LinkLabel2;
        internal Label Label16;
        internal Label PowerPlanChangeTrigger;
        internal CheckBox CheckBox19;
        internal CheckBox CheckBox20;
        internal CheckBox CheckBox21;
        internal CheckBox CheckBox22;
        internal Label VerboseAutoPilot;
        internal Label Label18;
        internal Label Label19;
        internal CheckBox CheckBox23;
    }
}