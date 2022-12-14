using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserInterface : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            CurrentPowerPlanLabel = new Label();
            CheckPowerPlan = new Timer(components);
            CheckPowerPlan.Tick += new EventHandler(CheckPowerPlan_Tick);
            PowerModeHighPerf = new RadioButton();
            PowerModeHighPerf.CheckedChanged += new EventHandler(PowerModeHighPerf_CheckedChanged);
            PowerModeBalanced = new RadioButton();
            PowerModeBalanced.CheckedChanged += new EventHandler(PowerModeBalanced_CheckedChanged);
            Label1 = new Label();
            Label2 = new Label();
            GamingModeLowFreq = new RadioButton();
            GamingModeDoNotAlter = new RadioButton();
            Label4 = new Label();
            SetPowerPlan = new Timer(components);
            SetPowerPlan.Tick += new EventHandler(SetPowerPlan_Tick);
            ProcessDetector = new Timer(components);
            ProcessDetector.Tick += new EventHandler(ProcessCheck_Tick);
            ProcessLabel = new Label();
            ProcessLabel.TextChanged += new EventHandler(ProcessLabel_TextChanged);
            GroupBox1 = new GroupBox();
            GroupBox1.Enter += new EventHandler(GroupBox1_Enter);
            Label29 = new Label();
            Label28 = new Label();
            Label28.VisibleChanged += new EventHandler(Label28_VisibleChanged);
            PowerModeBattery = new RadioButton();
            PowerModeBattery.CheckedChanged += new EventHandler(PowerModeBattery_CheckedChanged);
            Panel2 = new Panel();
            Label6 = new Label();
            Label25 = new Label();
            buttonquicksetPowerSave = new Button();
            buttonquicksetPowerSave.Click += new EventHandler(Button4_Click);
            buttonquicksetPerformance = new Button();
            buttonquicksetPerformance.Click += new EventHandler(Button3_Click);
            buttonquicksetBalanced = new Button();
            buttonquicksetBalanced.Click += new EventHandler(Button2_Click_1);
            Label33 = new Label();
            ActivePlanLabel = new Label();
            ActivePlanLabel.TextChanged += new EventHandler(ActivePlanLabel_TextChanged);
            Label3 = new Label();
            Label12 = new Label();
            Label12.VisibleChanged += new EventHandler(Label12_VisibleChanged);
            CurrentGameLabel = new Label();
            CurrentGameLabel.TextChanged += new EventHandler(CurrentGameLabel_TextChanged);
            Label26 = new Label();
            PowerModeLowFreq = new RadioButton();
            GroupBox2 = new GroupBox();
            GamingModeHighPerf = new RadioButton();
            GamingModeBalanced = new RadioButton();
            FormSizeControl = new Timer(components);
            FormSizeControl.Tick += new EventHandler(FormSizeControl_Tick);
            FormHeightLabel = new Label();
            MemoryOptimizer = new Timer(components);
            MemoryOptimizer.Tick += new EventHandler(MemoryOptimizer_Tick);
            NotifyIcon1 = new NotifyIcon(components);
            NotifyIcon1.BalloonTipShown += new EventHandler(NotifyIcon1_BalloonTipShown);
            NotifyIcon1.BalloonTipClosed += new EventHandler(NotifyIcon1_BalloonTipClosed);
            NotifyIcon1.BalloonTipClicked += new EventHandler(NotifyIcon1_BalloonTipClicked);
            NotifyIcon1.MouseClick += new MouseEventHandler(NotifyIcon1_MouseClick);
            NotifyIcon1.MouseDoubleClick += new MouseEventHandler(NotifyIcon1_MouseDoubleClick);
            ContextMenuStrip1 = new ContextMenuStrip(components);
            ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(ContextMenuStrip1_Opening);
            ToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem1.Click += new EventHandler(ToolStripMenuItem1_Click);
            SettingsToolStripMenuItem = new ToolStripMenuItem();
            SettingsToolStripMenuItem.Click += new EventHandler(SettingsToolStripMenuItem_Click);
            ShowAutoPowerSwitcherToolStripMenuItem = new ToolStripMenuItem();
            ShowAutoPowerSwitcherToolStripMenuItem.Click += new EventHandler(ShowAutoPowerSwitcherToolStripMenuItem_Click);
            ToolStripSeparator1 = new ToolStripSeparator();
            SetPowermodeToToolStripMenuItem = new ToolStripMenuItem();
            SetPowermodeToBalancedToolStripMenuItem = new ToolStripMenuItem();
            SetPowermodeToBalancedToolStripMenuItem.Click += new EventHandler(SetPowermodeToBalancedToolStripMenuItem_Click);
            SetToHighPerfToolStripMenuItem = new ToolStripMenuItem();
            SetToHighPerfToolStripMenuItem.Click += new EventHandler(SetToHighPerfToolStripMenuItem_Click);
            PowerSaveToolStripMenuItem = new ToolStripMenuItem();
            PowerSaveToolStripMenuItem.Click += new EventHandler(PowerSaveToolStripMenuItem_Click);
            ToolStripMenuItem3 = new ToolStripMenuItem();
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripMenuItem2.Click += new EventHandler(ToolStripMenuItem2_Click);
            BootOptimizerConflictFixer = new Timer(components);
            BootOptimizerConflictFixer.Tick += new EventHandler(BootOptimizerConflictFixer_Tick);
            Label14 = new Label();
            Label13 = new Label();
            ConfilictLabel = new Label();
            Label15 = new Label();
            EngineStatusLabel = new Label();
            Label16 = new Label();
            TargetProcessBox = new TextBox();
            TargetProcessBox.TextChanged += new EventHandler(TargetProcessBox_TextChanged);
            TargetProcessBox.Leave += new EventHandler(TargetProcessBox_Leave);
            TargetProcessBox.EnabledChanged += new EventHandler(TargetProcessBox_EnabledChanged);
            Label17 = new Label();
            SettingsEngine = new Timer(components);
            SettingsEngine.Tick += new EventHandler(SettingsEngine_Tick);
            Label18 = new Label();
            Label19 = new Label();
            EnvironmentTickCount = new Label();
            StartMinimized = new Timer(components);
            StartMinimized.Tick += new EventHandler(StartMinimized_Tick);
            ContextEngine = new Timer(components);
            ContextEngine.Tick += new EventHandler(ContextEngine_Tick);
            TimesHidden = new Label();
            Label8 = new Label();
            AllowQuit = new Label();
            PictureBox1 = new PictureBox();
            PictureBox1.Click += new EventHandler(PictureBox1_Click);
            SetPowerPlanAlternate = new Timer(components);
            SetPowerPlanAlternate.Tick += new EventHandler(SetPowerPlanAlternate_Tick);
            Label9 = new Label();
            AutoPilotStatus = new Label();
            AutoPilotStatus.TextChanged += new EventHandler(AutoPilotStatus_TextChanged);
            Label11 = new Label();
            Label20 = new Label();
            FreeSpaceLabel = new Label();
            FreeSpaceLabel.Click += new EventHandler(FreeSpaceLabel_Click);
            FreeSpaceChecker = new Timer(components);
            FreeSpaceChecker.Tick += new EventHandler(FreeSpaceChecker_Tick);
            CPUTracker = new Timer(components);
            CPUTracker.Tick += new EventHandler(CPUTracker_Tick);
            CPUUsageLabel = new Label();
            CPUUsageLabel.TextChanged += new EventHandler(CPUUsageLabel_TextChanged);
            Label21 = new Label();
            Label21.Click += new EventHandler(Label21_Click);
            IOLabel = new Label();
            IOLabel.Click += new EventHandler(IOLabel_Click);
            Label23 = new Label();
            Label23.Click += new EventHandler(Label23_Click);
            EnvTickCounter = new Timer(components);
            EnvTickCounter.Tick += new EventHandler(EnvTickCounter_Tick);
            Label22 = new Label();
            FormLocationLabel = new Label();
            Label27 = new Label();
            Label30 = new Label();
            Label30.Click += new EventHandler(Label30_Click);
            ArgumentsLabel = new Label();
            FormWidthLabel = new Label();
            FormWidthLabel.Click += new EventHandler(Label5_Click);
            Label5 = new Label();
            Label5.Click += new EventHandler(Label5_Click);
            CheckBox1 = new CheckBox();
            CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            Panel1 = new Panel();
            Label36 = new Label();
            MemorizedPowerModeLabel = new Label();
            Label39 = new Label();
            NotifyFunctionCounter = new Label();
            NotifyFunctionCounter.TextChanged += new EventHandler(NotifyFunctionCounter_TextChanged);
            CheckBox3 = new CheckBox();
            CheckBox3.CheckedChanged += new EventHandler(CheckBox3_CheckedChanged_2);
            CheckBox2 = new CheckBox();
            CheckBox2.CheckedChanged += new EventHandler(CheckBox2_CheckedChanged);
            Label37 = new Label();
            BallonTipClickActionByte = new Label();
            BallonTipClickActionByte.TextChanged += new EventHandler(BallonTipClickActionByte_TextChanged);
            Label32 = new Label();
            Label41 = new Label();
            balancedBugFix = new Label();
            Label10 = new Label();
            Label7 = new Label();
            ConsoleFloodCounter = new Label();
            Panel3 = new Panel();
            AllowPowermodeControl = new CheckBox();
            AllowPowermodeControl.CheckedChanged += new EventHandler(AllowPowermodeControl_CheckedChanged);
            Label24 = new Label();
            Label34 = new Label();
            EnableFastCheck = new Timer(components);
            EnableFastCheck.Tick += new EventHandler(EnableFastCheck_Tick);
            FastCheckDeadline = new Timer(components);
            FastCheckDeadline.Tick += new EventHandler(DisableFastCheck_Tick);
            Label35 = new Label();
            version = new Label();
            overflowCurseBlocker = new Label();
            NotifyFunctionEngine = new Timer(components);
            NotifyFunctionEngine.Tick += new EventHandler(NotifyFunctionEngine_Tick);
            Label38 = new Label();
            Label38.TextChanged += new EventHandler(ActivePlanLabel_TextChanged);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click_2);
            HighPerformanceWarning = new Timer(components);
            HighPerformanceWarning.Tick += new EventHandler(HighPerformanceWarning_Tick);
            BalancedLabel = new Label();
            HighPerfLabel = new Label();
            PowerSaveLabel = new Label();
            Label40 = new Label();
            Label42 = new Label();
            Label43 = new Label();
            Label44 = new Label();
            Label45 = new Label();
            Label46 = new Label();
            Button8 = new Button();
            Button8.Click += new EventHandler(Button8_Click);
            Button9 = new Button();
            Button9.Click += new EventHandler(Button9_Click);
            Testing = new Timer(components);
            Button10 = new Button();
            Button10.Click += new EventHandler(Button10_Click);
            memorizePowerPlanEngine = new Timer(components);
            memorizePowerPlanEngine.Tick += new EventHandler(memorizePowerPlanEngine_Tick);
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label47 = new Label();
            RuntimeBenchmarkOutput = new Label();
            RuntimeBenchmarkEngine = new Timer(components);
            RuntimeBenchmarkEngine.Tick += new EventHandler(RuntimeTimingEngine_Tick);
            Button11 = new Button();
            Button11.Click += new EventHandler(Button11_Click);
            Button12 = new Button();
            Button12.Click += new EventHandler(Button12_Click);
            Button13 = new Button();
            Button13.Click += new EventHandler(Button13_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click_2);
            ResetNotificationBuffer = new Timer(components);
            ResetNotificationBuffer.Tick += new EventHandler(ResetNotificationBuffer_Tick);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click_2);
            Label31 = new Label();
            CheckUserBehavior = new Timer(components);
            CheckUserBehavior.Tick += new EventHandler(CheckUserBehavior_Tick);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click_1);
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            Panel1.SuspendLayout();
            Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // CurrentPowerPlanLabel
            // 
            CurrentPowerPlanLabel.AutoSize = true;
            CurrentPowerPlanLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
            CurrentPowerPlanLabel.Location = new Point(5, 165);
            CurrentPowerPlanLabel.Name = "CurrentPowerPlanLabel";
            CurrentPowerPlanLabel.Size = new Size(164, 13);
            CurrentPowerPlanLabel.TabIndex = 1;
            CurrentPowerPlanLabel.Text = "Getting required data from engine";
            // 
            // CheckPowerPlan
            // 
            CheckPowerPlan.Enabled = true;
            CheckPowerPlan.Interval = 2000;
            // 
            // PowerModeHighPerf
            // 
            PowerModeHighPerf.AutoSize = true;
            PowerModeHighPerf.Font = new Font("Segoe UI Light", 10.0f);
            PowerModeHighPerf.Location = new Point(21, 28);
            PowerModeHighPerf.Name = "PowerModeHighPerf";
            PowerModeHighPerf.Size = new Size(133, 23);
            PowerModeHighPerf.TabIndex = 2;
            PowerModeHighPerf.Text = "High Performance";
            PowerModeHighPerf.UseVisualStyleBackColor = true;
            // 
            // PowerModeBalanced
            // 
            PowerModeBalanced.AutoSize = true;
            PowerModeBalanced.Font = new Font("Segoe UI Light", 10.0f);
            PowerModeBalanced.Location = new Point(21, 51);
            PowerModeBalanced.Name = "PowerModeBalanced";
            PowerModeBalanced.Size = new Size(80, 23);
            PowerModeBalanced.TabIndex = 3;
            PowerModeBalanced.Text = "Balanced";
            PowerModeBalanced.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Light", 15.0f);
            Label1.Location = new Point(56, -5);
            Label1.Name = "Label1";
            Label1.Size = new Size(185, 28);
            Label1.TabIndex = 4;
            Label1.Text = "Preferred CPU mode";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Light", 15.0f);
            Label2.Location = new Point(52, -3);
            Label2.Name = "Label2";
            Label2.Size = new Size(171, 28);
            Label2.TabIndex = 5;
            Label2.Text = "Gaming CPU mode";
            // 
            // GamingModeLowFreq
            // 
            GamingModeLowFreq.AutoSize = true;
            GamingModeLowFreq.Checked = true;
            GamingModeLowFreq.Font = new Font("Segoe UI Light", 10.0f);
            GamingModeLowFreq.Location = new Point(714, 91);
            GamingModeLowFreq.Name = "GamingModeLowFreq";
            GamingModeLowFreq.Size = new Size(81, 23);
            GamingModeLowFreq.TabIndex = 6;
            GamingModeLowFreq.TabStop = true;
            GamingModeLowFreq.Text = "Low Freq";
            GamingModeLowFreq.UseVisualStyleBackColor = true;
            // 
            // GamingModeDoNotAlter
            // 
            GamingModeDoNotAlter.AutoSize = true;
            GamingModeDoNotAlter.Font = new Font("Segoe UI Light", 10.0f);
            GamingModeDoNotAlter.Location = new Point(714, 112);
            GamingModeDoNotAlter.Name = "GamingModeDoNotAlter";
            GamingModeDoNotAlter.Size = new Size(97, 23);
            GamingModeDoNotAlter.TabIndex = 7;
            GamingModeDoNotAlter.Text = "Do not alter";
            GamingModeDoNotAlter.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 8.25f);
            Label4.Location = new Point(3, 153);
            Label4.Name = "Label4";
            Label4.Size = new Size(131, 13);
            Label4.TabIndex = 11;
            Label4.Text = "Current PowerMode GUID";
            // 
            // SetPowerPlan
            // 
            SetPowerPlan.Interval = 1;
            // 
            // ProcessDetector
            // 
            ProcessDetector.Enabled = true;
            ProcessDetector.Interval = 5000;
            // 
            // ProcessLabel
            // 
            ProcessLabel.AutoSize = true;
            ProcessLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProcessLabel.ForeColor = Color.Red;
            ProcessLabel.Location = new Point(127, 67);
            ProcessLabel.Name = "ProcessLabel";
            ProcessLabel.Size = new Size(61, 13);
            ProcessLabel.TabIndex = 12;
            ProcessLabel.Text = "WAITING";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label29);
            GroupBox1.Controls.Add(Label28);
            GroupBox1.Controls.Add(PowerModeBattery);
            GroupBox1.Controls.Add(PowerModeHighPerf);
            GroupBox1.Controls.Add(PowerModeBalanced);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(Panel2);
            GroupBox1.Controls.Add(Label6);
            GroupBox1.Controls.Add(Label25);
            GroupBox1.Location = new Point(362, 90);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(299, 249);
            GroupBox1.TabIndex = 13;
            GroupBox1.TabStop = false;
            // 
            // Label29
            // 
            Label29.AutoSize = true;
            Label29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label29.ForeColor = Color.FromArgb(255, 128, 0);
            Label29.Location = new Point(156, 207);
            Label29.Name = "Label29";
            Label29.Size = new Size(75, 13);
            Label29.TabIndex = 70;
            Label29.Text = "Not in-game";
            // 
            // Label28
            // 
            Label28.AutoSize = true;
            Label28.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label28.ForeColor = Color.FromArgb(0, 192, 0);
            Label28.Location = new Point(36, 207);
            Label28.Name = "Label28";
            Label28.Size = new Size(105, 13);
            Label28.TabIndex = 69;
            Label28.Text = "Currently in-game";
            Label28.Visible = false;
            // 
            // PowerModeBattery
            // 
            PowerModeBattery.AutoSize = true;
            PowerModeBattery.Font = new Font("Segoe UI Light", 10.0f);
            PowerModeBattery.Location = new Point(21, 74);
            PowerModeBattery.Name = "PowerModeBattery";
            PowerModeBattery.Size = new Size(99, 23);
            PowerModeBattery.TabIndex = 2;
            PowerModeBattery.Text = "Power Saver";
            PowerModeBattery.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            Panel2.Location = new Point(21, 223);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(251, 16);
            Panel2.TabIndex = 76;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(58, 119);
            Label6.Name = "Label6";
            Label6.Size = new Size(143, 65);
            Label6.TabIndex = 81;
            Label6.Text = "PreferredCPUMode Keys:" + '\r' + '\n' + "High Perf  = 0" + '\r' + '\n' + "Balanced   = 1" + '\r' + '\n' + "BatterySav = 2" + '\r' + '\n' + "Default V" + "alue = 1 (Balanced)";
            // 
            // Label25
            // 
            Label25.AutoSize = true;
            Label25.Location = new Point(77, 100);
            Label25.Name = "Label25";
            Label25.Size = new Size(195, 13);
            Label25.TabIndex = 79;
            Label25.Text = "This won't alter your current powermode";
            // 
            // buttonquicksetPowerSave
            // 
            buttonquicksetPowerSave.Cursor = Cursors.Default;
            buttonquicksetPowerSave.FlatStyle = FlatStyle.Flat;
            buttonquicksetPowerSave.Location = new Point(213, 50);
            buttonquicksetPowerSave.Name = "buttonquicksetPowerSave";
            buttonquicksetPowerSave.Size = new Size(79, 23);
            buttonquicksetPowerSave.TabIndex = 82;
            buttonquicksetPowerSave.Text = "Power Saver";
            buttonquicksetPowerSave.UseVisualStyleBackColor = true;
            // 
            // buttonquicksetPerformance
            // 
            buttonquicksetPerformance.Cursor = Cursors.Default;
            buttonquicksetPerformance.FlatStyle = FlatStyle.Flat;
            buttonquicksetPerformance.Font = new Font("Microsoft Sans Serif", 8.25f);
            buttonquicksetPerformance.ForeColor = Color.Red;
            buttonquicksetPerformance.Location = new Point(108, 50);
            buttonquicksetPerformance.Name = "buttonquicksetPerformance";
            buttonquicksetPerformance.Size = new Size(102, 23);
            buttonquicksetPerformance.TabIndex = 81;
            buttonquicksetPerformance.Text = "High Performance";
            buttonquicksetPerformance.UseVisualStyleBackColor = true;
            // 
            // buttonquicksetBalanced
            // 
            buttonquicksetBalanced.Cursor = Cursors.Default;
            buttonquicksetBalanced.FlatStyle = FlatStyle.Flat;
            buttonquicksetBalanced.ForeColor = Color.Black;
            buttonquicksetBalanced.Location = new Point(11, 50);
            buttonquicksetBalanced.Name = "buttonquicksetBalanced";
            buttonquicksetBalanced.Size = new Size(94, 23);
            buttonquicksetBalanced.TabIndex = 80;
            buttonquicksetBalanced.Text = "Balanced";
            buttonquicksetBalanced.UseVisualStyleBackColor = true;
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.Font = new Font("Segoe UI Light", 15.0f);
            Label33.Location = new Point(52, 15);
            Label33.Name = "Label33";
            Label33.Size = new Size(195, 28);
            Label33.TabIndex = 4;
            Label33.Text = "Quick set powermode";
            // 
            // ActivePlanLabel
            // 
            ActivePlanLabel.AutoSize = true;
            ActivePlanLabel.Font = new Font("Segoe UI Light", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActivePlanLabel.ForeColor = Color.Black;
            ActivePlanLabel.Location = new Point(143, 87);
            ActivePlanLabel.Name = "ActivePlanLabel";
            ActivePlanLabel.Size = new Size(89, 21);
            ActivePlanLabel.TabIndex = 29;
            ActivePlanLabel.Text = "Getting info";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.FromArgb(0, 192, 0);
            Label3.Location = new Point(54, 140);
            Label3.Name = "Label3";
            Label3.Size = new Size(183, 13);
            Label3.TabIndex = 52;
            Label3.Text = "Awesome news, AutoPilot is enabled.";
            Label3.Visible = false;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI Light", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 162);
            Label12.Location = new Point(8, 110);
            Label12.Name = "Label12";
            Label12.Size = new Size(127, 21);
            Label12.TabIndex = 78;
            Label12.Text = "Currently playing:";
            Label12.Visible = false;
            // 
            // CurrentGameLabel
            // 
            CurrentGameLabel.AutoSize = true;
            CurrentGameLabel.Font = new Font("Segoe UI Light", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 162);
            CurrentGameLabel.Location = new Point(135, 110);
            CurrentGameLabel.Name = "CurrentGameLabel";
            CurrentGameLabel.Size = new Size(45, 21);
            CurrentGameLabel.TabIndex = 78;
            CurrentGameLabel.Text = "NULL";
            CurrentGameLabel.Visible = false;
            // 
            // Label26
            // 
            Label26.AutoSize = true;
            Label26.Font = new Font("Segoe UI Light", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 162);
            Label26.Location = new Point(8, 108);
            Label26.Name = "Label26";
            Label26.Size = new Size(158, 21);
            Label26.TabIndex = 79;
            Label26.Text = "Currently not in-game";
            // 
            // PowerModeLowFreq
            // 
            PowerModeLowFreq.AutoSize = true;
            PowerModeLowFreq.Font = new Font("Segoe UI Light", 10.0f);
            PowerModeLowFreq.Location = new Point(714, 70);
            PowerModeLowFreq.Name = "PowerModeLowFreq";
            PowerModeLowFreq.Size = new Size(81, 23);
            PowerModeLowFreq.TabIndex = 3;
            PowerModeLowFreq.Text = "Low Freq";
            PowerModeLowFreq.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(GamingModeHighPerf);
            GroupBox2.Controls.Add(Label2);
            GroupBox2.Location = new Point(687, 185);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(237, 61);
            GroupBox2.TabIndex = 14;
            GroupBox2.TabStop = false;
            // 
            // GamingModeHighPerf
            // 
            GamingModeHighPerf.AutoSize = true;
            GamingModeHighPerf.Font = new Font("Segoe UI Light", 10.0f);
            GamingModeHighPerf.Location = new Point(57, 28);
            GamingModeHighPerf.Name = "GamingModeHighPerf";
            GamingModeHighPerf.Size = new Size(133, 23);
            GamingModeHighPerf.TabIndex = 2;
            GamingModeHighPerf.Text = "High Performance";
            GamingModeHighPerf.UseVisualStyleBackColor = true;
            // 
            // GamingModeBalanced
            // 
            GamingModeBalanced.AutoSize = true;
            GamingModeBalanced.Font = new Font("Segoe UI Light", 10.0f);
            GamingModeBalanced.Location = new Point(715, 141);
            GamingModeBalanced.Name = "GamingModeBalanced";
            GamingModeBalanced.Size = new Size(80, 23);
            GamingModeBalanced.TabIndex = 3;
            GamingModeBalanced.Text = "Balanced";
            GamingModeBalanced.UseVisualStyleBackColor = true;
            // 
            // FormSizeControl
            // 
            // 
            // FormHeightLabel
            // 
            FormHeightLabel.AutoSize = true;
            FormHeightLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            FormHeightLabel.Location = new Point(110, 177);
            FormHeightLabel.Name = "FormHeightLabel";
            FormHeightLabel.Size = new Size(29, 13);
            FormHeightLabel.TabIndex = 21;
            FormHeightLabel.Text = "size";
            // 
            // MemoryOptimizer
            // 
            MemoryOptimizer.Interval = 60000;
            // 
            // NotifyIcon1
            // 
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            NotifyIcon1.ContextMenuStrip = ContextMenuStrip1;
            NotifyIcon1.Icon = (Icon)resources.GetObject("NotifyIcon1.Icon");
            NotifyIcon1.Text = "An error occured!";
            NotifyIcon1.Visible = true;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImeMode = ImeMode.NoControl;
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem1, SettingsToolStripMenuItem, ShowAutoPowerSwitcherToolStripMenuItem, ToolStripSeparator1, SetPowermodeToToolStripMenuItem, SetPowermodeToBalancedToolStripMenuItem, SetToHighPerfToolStripMenuItem, PowerSaveToolStripMenuItem, ToolStripMenuItem3, ToolStripSeparator2, ToolStripMenuItem2 });
            ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip1.ShowImageMargin = false;
            ContextMenuStrip1.Size = new Size(186, 214);
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(185, 22);
            ToolStripMenuItem1.Text = "Hide app";
            // 
            // SettingsToolStripMenuItem
            // 
            SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            SettingsToolStripMenuItem.Size = new Size(185, 22);
            SettingsToolStripMenuItem.Text = "Settings";
            // 
            // ShowAutoPowerSwitcherToolStripMenuItem
            // 
            ShowAutoPowerSwitcherToolStripMenuItem.Name = "ShowAutoPowerSwitcherToolStripMenuItem";
            ShowAutoPowerSwitcherToolStripMenuItem.Size = new Size(185, 22);
            ShowAutoPowerSwitcherToolStripMenuItem.Text = "Show AutoPowerSwitcher";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(182, 6);
            // 
            // SetPowermodeToToolStripMenuItem
            // 
            SetPowermodeToToolStripMenuItem.Enabled = false;
            SetPowermodeToToolStripMenuItem.Name = "SetPowermodeToToolStripMenuItem";
            SetPowermodeToToolStripMenuItem.Size = new Size(185, 22);
            SetPowermodeToToolStripMenuItem.Text = "Set powermode to";
            // 
            // SetPowermodeToBalancedToolStripMenuItem
            // 
            SetPowermodeToBalancedToolStripMenuItem.Name = "SetPowermodeToBalancedToolStripMenuItem";
            SetPowermodeToBalancedToolStripMenuItem.Size = new Size(185, 22);
            SetPowermodeToBalancedToolStripMenuItem.Text = "Balanced";
            // 
            // SetToHighPerfToolStripMenuItem
            // 
            SetToHighPerfToolStripMenuItem.Name = "SetToHighPerfToolStripMenuItem";
            SetToHighPerfToolStripMenuItem.Size = new Size(185, 22);
            SetToHighPerfToolStripMenuItem.Text = "High Performance";
            // 
            // PowerSaveToolStripMenuItem
            // 
            PowerSaveToolStripMenuItem.Name = "PowerSaveToolStripMenuItem";
            PowerSaveToolStripMenuItem.Size = new Size(185, 22);
            PowerSaveToolStripMenuItem.Text = "Power Save";
            // 
            // ToolStripMenuItem3
            // 
            ToolStripMenuItem3.Enabled = false;
            ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            ToolStripMenuItem3.Size = new Size(185, 22);
            ToolStripMenuItem3.Text = "Please wait...";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(182, 6);
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.Size = new Size(185, 22);
            ToolStripMenuItem2.Text = "Exit";
            // 
            // BootOptimizerConflictFixer
            // 
            BootOptimizerConflictFixer.Interval = 2000;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(2, 67);
            Label14.Name = "Label14";
            Label14.Size = new Size(128, 13);
            Label14.TabIndex = 30;
            Label14.Text = "Target Process Running?";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(3, 84);
            Label13.Name = "Label13";
            Label13.Size = new Size(76, 13);
            Label13.TabIndex = 31;
            Label13.Text = "EnvArguments";
            // 
            // ConfilictLabel
            // 
            ConfilictLabel.AutoSize = true;
            ConfilictLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfilictLabel.ForeColor = Color.Red;
            ConfilictLabel.Location = new Point(85, 193);
            ConfilictLabel.Name = "ConfilictLabel";
            ConfilictLabel.Size = new Size(37, 13);
            ConfilictLabel.TabIndex = 32;
            ConfilictLabel.Text = "False";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(3, 100);
            Label15.Name = "Label15";
            Label15.Size = new Size(70, 13);
            Label15.TabIndex = 34;
            Label15.Text = "EngineStatus";
            // 
            // EngineStatusLabel
            // 
            EngineStatusLabel.AutoSize = true;
            EngineStatusLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            EngineStatusLabel.ForeColor = Color.Red;
            EngineStatusLabel.Location = new Point(74, 100);
            EngineStatusLabel.Name = "EngineStatusLabel";
            EngineStatusLabel.Size = new Size(61, 13);
            EngineStatusLabel.TabIndex = 35;
            EngineStatusLabel.Text = "WAITING";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(41, 2);
            Label16.Name = "Label16";
            Label16.Size = new Size(101, 13);
            Label16.TabIndex = 36;
            Label16.Text = "The Target Process";
            // 
            // TargetProcessBox
            // 
            TargetProcessBox.Location = new Point(30, 16);
            TargetProcessBox.Name = "TargetProcessBox";
            TargetProcessBox.Size = new Size(131, 20);
            TargetProcessBox.TabIndex = 37;
            TargetProcessBox.Text = "GTA5";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(17, 38);
            Label17.Name = "Label17";
            Label17.Size = new Size(169, 13);
            Label17.TabIndex = 39;
            Label17.Text = "This can be overriden by AutoPilot";
            // 
            // SettingsEngine
            // 
            SettingsEngine.Interval = 1;
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Microsoft Sans Serif", 6.25f);
            Label18.ForeColor = SystemColors.ControlDarkDark;
            Label18.Location = new Point(2, 0);
            Label18.Name = "Label18";
            Label18.Size = new Size(107, 12);
            Label18.TabIndex = 41;
            Label18.Text = "CryptedBytes 2015-2016" + '\r' + '\n';
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Location = new Point(2, 113);
            Label19.Name = "Label19";
            Label19.Size = new Size(75, 13);
            Label19.TabIndex = 43;
            Label19.Text = "EnvTickCount";
            // 
            // EnvironmentTickCount
            // 
            EnvironmentTickCount.AutoSize = true;
            EnvironmentTickCount.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnvironmentTickCount.ForeColor = Color.Red;
            EnvironmentTickCount.Location = new Point(74, 114);
            EnvironmentTickCount.Name = "EnvironmentTickCount";
            EnvironmentTickCount.Size = new Size(101, 13);
            EnvironmentTickCount.TabIndex = 44;
            EnvironmentTickCount.Text = "Disabled by user";
            // 
            // StartMinimized
            // 
            StartMinimized.Interval = 1;
            // 
            // ContextEngine
            // 
            ContextEngine.Interval = 1000;
            // 
            // TimesHidden
            // 
            TimesHidden.AutoSize = true;
            TimesHidden.Location = new Point(277, 9);
            TimesHidden.Name = "TimesHidden";
            TimesHidden.Size = new Size(13, 13);
            TimesHidden.TabIndex = 49;
            TimesHidden.Text = "0";
            TimesHidden.Visible = false;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(4, 127);
            Label8.Name = "Label8";
            Label8.Size = new Size(57, 13);
            Label8.TabIndex = 50;
            Label8.Text = "AllowQuit()";
            // 
            // AllowQuit
            // 
            AllowQuit.AutoSize = true;
            AllowQuit.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllowQuit.ForeColor = Color.Red;
            AllowQuit.Location = new Point(74, 127);
            AllowQuit.Name = "AllowQuit";
            AllowQuit.Size = new Size(74, 13);
            AllowQuit.TabIndex = 51;
            AllowQuit.Text = "Not allowed";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(271, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(23, 24);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 8;
            PictureBox1.TabStop = false;
            // 
            // SetPowerPlanAlternate
            // 
            SetPowerPlanAlternate.Interval = 2400;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(2, 53);
            Label9.Name = "Label9";
            Label9.Size = new Size(96, 13);
            Label9.TabIndex = 53;
            Label9.Text = "Is autopilot active?";
            // 
            // AutoPilotStatus
            // 
            AutoPilotStatus.AutoSize = true;
            AutoPilotStatus.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            AutoPilotStatus.ForeColor = Color.Red;
            AutoPilotStatus.Location = new Point(102, 53);
            AutoPilotStatus.Name = "AutoPilotStatus";
            AutoPilotStatus.Size = new Size(61, 13);
            AutoPilotStatus.TabIndex = 54;
            AutoPilotStatus.Text = "WAITING";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label11.Location = new Point(5, 177);
            Label11.Name = "Label11";
            Label11.Size = new Size(107, 13);
            Label11.TabIndex = 55;
            Label11.Text = "Visible Form Size:";
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Location = new Point(3, 23);
            Label20.Name = "Label20";
            Label20.Size = new Size(116, 13);
            Label20.TabIndex = 56;
            Label20.Text = "FreeSpace on DRIVE0";
            // 
            // FreeSpaceLabel
            // 
            FreeSpaceLabel.AutoSize = true;
            FreeSpaceLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            FreeSpaceLabel.ForeColor = Color.Red;
            FreeSpaceLabel.Location = new Point(125, 23);
            FreeSpaceLabel.Name = "FreeSpaceLabel";
            FreeSpaceLabel.Size = new Size(101, 13);
            FreeSpaceLabel.TabIndex = 57;
            FreeSpaceLabel.Text = "Disabled by user";
            // 
            // FreeSpaceChecker
            // 
            FreeSpaceChecker.Interval = 45;
            // 
            // CPUTracker
            // 
            CPUTracker.Interval = 750;
            // 
            // CPUUsageLabel
            // 
            CPUUsageLabel.AutoSize = true;
            CPUUsageLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            CPUUsageLabel.ForeColor = Color.Red;
            CPUUsageLabel.Location = new Point(94, 39);
            CPUUsageLabel.Name = "CPUUsageLabel";
            CPUUsageLabel.Size = new Size(101, 13);
            CPUUsageLabel.TabIndex = 59;
            CPUUsageLabel.Text = "Disabled by user";
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Location = new Point(2, 39);
            Label21.Name = "Label21";
            Label21.Size = new Size(86, 13);
            Label21.TabIndex = 60;
            Label21.Text = "CPU0 Usage (%)";
            // 
            // IOLabel
            // 
            IOLabel.AutoSize = true;
            IOLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            IOLabel.ForeColor = Color.Purple;
            IOLabel.Location = new Point(247, 23);
            IOLabel.Name = "IOLabel";
            IOLabel.Size = new Size(26, 13);
            IOLabel.TabIndex = 61;
            IOLabel.Text = "I/O";
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.Location = new Point(253, 8);
            Label23.Name = "Label23";
            Label23.Size = new Size(23, 13);
            Label23.TabIndex = 62;
            Label23.Text = "I/O";
            // 
            // EnvTickCounter
            // 
            EnvTickCounter.Interval = 200;
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Location = new Point(3, 140);
            Label22.Name = "Label22";
            Label22.Size = new Size(74, 13);
            Label22.TabIndex = 63;
            Label22.Text = "FormLocation:";
            // 
            // FormLocationLabel
            // 
            FormLocationLabel.AutoSize = true;
            FormLocationLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormLocationLabel.ForeColor = Color.Red;
            FormLocationLabel.Location = new Point(75, 140);
            FormLocationLabel.Name = "FormLocationLabel";
            FormLocationLabel.Size = new Size(101, 13);
            FormLocationLabel.TabIndex = 64;
            FormLocationLabel.Text = "Disabled by user";
            // 
            // Label27
            // 
            Label27.AutoSize = true;
            Label27.Font = new Font("Microsoft Sans Serif", 24.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label27.Location = new Point(45, 531);
            Label27.Name = "Label27";
            Label27.Size = new Size(458, 37);
            Label27.TabIndex = 68;
            Label27.Text = "Out of bounds of user interface";
            // 
            // Label30
            // 
            Label30.AutoSize = true;
            Label30.Location = new Point(284, 4);
            Label30.Name = "Label30";
            Label30.Size = new Size(13, 13);
            Label30.TabIndex = 71;
            Label30.Text = "0";
            // 
            // ArgumentsLabel
            // 
            ArgumentsLabel.AutoSize = true;
            ArgumentsLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ArgumentsLabel.ForeColor = Color.Red;
            ArgumentsLabel.Location = new Point(85, 84);
            ArgumentsLabel.Name = "ArgumentsLabel";
            ArgumentsLabel.Size = new Size(61, 13);
            ArgumentsLabel.TabIndex = 72;
            ArgumentsLabel.Text = "WAITING";
            // 
            // FormWidthLabel
            // 
            FormWidthLabel.AutoSize = true;
            FormWidthLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            FormWidthLabel.Location = new Point(147, 177);
            FormWidthLabel.Name = "FormWidthLabel";
            FormWidthLabel.Size = new Size(29, 13);
            FormWidthLabel.TabIndex = 21;
            FormWidthLabel.Text = "size";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            Label5.Location = new Point(137, 177);
            Label5.Name = "Label5";
            Label5.Size = new Size(11, 13);
            Label5.TabIndex = 21;
            Label5.Text = ",";
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(442, 76);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(73, 17);
            CheckBox1.TabIndex = 73;
            CheckBox1.Text = "DevMenu";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Label36);
            Panel1.Controls.Add(MemorizedPowerModeLabel);
            Panel1.Controls.Add(Label39);
            Panel1.Controls.Add(NotifyFunctionCounter);
            Panel1.Controls.Add(CheckBox3);
            Panel1.Controls.Add(CheckBox2);
            Panel1.Controls.Add(Label37);
            Panel1.Controls.Add(BallonTipClickActionByte);
            Panel1.Controls.Add(Label32);
            Panel1.Controls.Add(Label41);
            Panel1.Controls.Add(CPUUsageLabel);
            Panel1.Controls.Add(CurrentPowerPlanLabel);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(ArgumentsLabel);
            Panel1.Controls.Add(ProcessLabel);
            Panel1.Controls.Add(FormHeightLabel);
            Panel1.Controls.Add(FormWidthLabel);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(FormLocationLabel);
            Panel1.Controls.Add(Label14);
            Panel1.Controls.Add(balancedBugFix);
            Panel1.Controls.Add(Label10);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(Label22);
            Panel1.Controls.Add(Label13);
            Panel1.Controls.Add(Label23);
            Panel1.Controls.Add(ConsoleFloodCounter);
            Panel1.Controls.Add(ConfilictLabel);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(IOLabel);
            Panel1.Controls.Add(Panel3);
            Panel1.Controls.Add(EngineStatusLabel);
            Panel1.Controls.Add(Label21);
            Panel1.Controls.Add(Label19);
            Panel1.Controls.Add(EnvironmentTickCount);
            Panel1.Controls.Add(FreeSpaceLabel);
            Panel1.Controls.Add(Label8);
            Panel1.Controls.Add(Label20);
            Panel1.Controls.Add(AllowQuit);
            Panel1.Controls.Add(AllowPowermodeControl);
            Panel1.Controls.Add(Label9);
            Panel1.Controls.Add(Label11);
            Panel1.Controls.Add(AutoPilotStatus);
            Panel1.Location = new Point(4, 156);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(296, 370);
            Panel1.TabIndex = 74;
            // 
            // Label36
            // 
            Label36.AutoSize = true;
            Label36.Location = new Point(156, 220);
            Label36.Name = "Label36";
            Label36.Size = new Size(84, 13);
            Label36.TabIndex = 91;
            Label36.Text = "BalancedBugFix";
            // 
            // MemorizedPowerModeLabel
            // 
            MemorizedPowerModeLabel.AutoSize = true;
            MemorizedPowerModeLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemorizedPowerModeLabel.ForeColor = Color.Red;
            MemorizedPowerModeLabel.Location = new Point(84, 232);
            MemorizedPowerModeLabel.Name = "MemorizedPowerModeLabel";
            MemorizedPowerModeLabel.Size = new Size(60, 13);
            MemorizedPowerModeLabel.TabIndex = 88;
            MemorizedPowerModeLabel.Text = "Balanced";
            // 
            // Label39
            // 
            Label39.AutoSize = true;
            Label39.Location = new Point(3, 233);
            Label39.Name = "Label39";
            Label39.Size = new Size(79, 13);
            Label39.TabIndex = 86;
            Label39.Text = "NonGamingPM";
            // 
            // NotifyFunctionCounter
            // 
            NotifyFunctionCounter.AutoSize = true;
            NotifyFunctionCounter.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            NotifyFunctionCounter.ForeColor = Color.Red;
            NotifyFunctionCounter.Location = new Point(87, 220);
            NotifyFunctionCounter.Name = "NotifyFunctionCounter";
            NotifyFunctionCounter.Size = new Size(14, 13);
            NotifyFunctionCounter.TabIndex = 87;
            NotifyFunctionCounter.Text = "0";
            // 
            // CheckBox3
            // 
            CheckBox3.AutoSize = true;
            CheckBox3.Location = new Point(135, 248);
            CheckBox3.Name = "CheckBox3";
            CheckBox3.Size = new Size(113, 17);
            CheckBox3.TabIndex = 86;
            CheckBox3.Text = "Disable Size Limits";
            CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Location = new Point(7, 248);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(126, 17);
            CheckBox2.TabIndex = 85;
            CheckBox2.Text = "Revert to default size";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Label37
            // 
            Label37.AutoSize = true;
            Label37.Location = new Point(3, 220);
            Label37.Name = "Label37";
            Label37.Size = new Size(75, 13);
            Label37.TabIndex = 76;
            Label37.Text = "NotifyFunction";
            // 
            // BallonTipClickActionByte
            // 
            BallonTipClickActionByte.AutoSize = true;
            BallonTipClickActionByte.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            BallonTipClickActionByte.ForeColor = Color.Red;
            BallonTipClickActionByte.Location = new Point(277, 207);
            BallonTipClickActionByte.Name = "BallonTipClickActionByte";
            BallonTipClickActionByte.Size = new Size(14, 13);
            BallonTipClickActionByte.TabIndex = 90;
            BallonTipClickActionByte.Text = "0";
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.Location = new Point(1, 207);
            Label32.Name = "Label32";
            Label32.Size = new Size(85, 13);
            Label32.TabIndex = 76;
            Label32.Text = "NoFloodConsole";
            // 
            // Label41
            // 
            Label41.AutoSize = true;
            Label41.Location = new Point(156, 207);
            Label41.Name = "Label41";
            Label41.Size = new Size(115, 13);
            Label41.TabIndex = 89;
            Label41.Text = "BallonTipClickFunction";
            // 
            // balancedBugFix
            // 
            balancedBugFix.AutoSize = true;
            balancedBugFix.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            balancedBugFix.ForeColor = Color.Red;
            balancedBugFix.Location = new Point(242, 221);
            balancedBugFix.Name = "balancedBugFix";
            balancedBugFix.Size = new Size(14, 13);
            balancedBugFix.TabIndex = 85;
            balancedBugFix.Text = "2";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(6, 4);
            Label10.Name = "Label10";
            Label10.Size = new Size(81, 13);
            Label10.TabIndex = 75;
            Label10.Text = "Advanced Stuff";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(5, 194);
            Label7.Name = "Label7";
            Label7.Size = new Size(74, 13);
            Label7.TabIndex = 63;
            Label7.Text = "ConfilictFound";
            // 
            // ConsoleFloodCounter
            // 
            ConsoleFloodCounter.AutoSize = true;
            ConsoleFloodCounter.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConsoleFloodCounter.ForeColor = Color.Red;
            ConsoleFloodCounter.Location = new Point(92, 207);
            ConsoleFloodCounter.Name = "ConsoleFloodCounter";
            ConsoleFloodCounter.Size = new Size(14, 13);
            ConsoleFloodCounter.TabIndex = 32;
            ConsoleFloodCounter.Text = "0";
            // 
            // Panel3
            // 
            Panel3.Controls.Add(TargetProcessBox);
            Panel3.Controls.Add(Label16);
            Panel3.Controls.Add(Label17);
            Panel3.Location = new Point(39, 271);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(192, 58);
            Panel3.TabIndex = 77;
            // 
            // AllowPowermodeControl
            // 
            AllowPowermodeControl.AutoSize = true;
            AllowPowermodeControl.Checked = true;
            AllowPowermodeControl.CheckState = CheckState.Checked;
            AllowPowermodeControl.Location = new Point(97, 4);
            AllowPowermodeControl.Name = "AllowPowermodeControl";
            AllowPowermodeControl.Size = new Size(92, 17);
            AllowPowermodeControl.TabIndex = 79;
            AllowPowermodeControl.Text = "Active Control";
            AllowPowermodeControl.UseVisualStyleBackColor = true;
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Font = new Font("Microsoft Sans Serif", 14.25f);
            Label24.Location = new Point(691, 15);
            Label24.Name = "Label24";
            Label24.Size = new Size(171, 24);
            Label24.TabIndex = 80;
            Label24.Text = "Removed Features";
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.Font = new Font("Microsoft Sans Serif", 14.25f);
            Label34.Location = new Point(397, 15);
            Label34.Name = "Label34";
            Label34.Size = new Size(151, 24);
            Label34.TabIndex = 83;
            Label34.Text = "Hidden Features";
            // 
            // EnableFastCheck
            // 
            EnableFastCheck.Interval = 10;
            // 
            // FastCheckDeadline
            // 
            FastCheckDeadline.Interval = 50;
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.Font = new Font("Microsoft Sans Serif", 10.25f);
            Label35.ForeColor = Color.Red;
            Label35.Location = new Point(392, 390);
            Label35.Name = "Label35";
            Label35.Size = new Size(460, 68);
            Label35.TabIndex = 82;
            Label35.Text = resources.GetString("Label35.Text");
            // 
            // version
            // 
            version.AutoSize = true;
            version.Font = new Font("Microsoft Sans Serif", 6.25f);
            version.Location = new Point(113, 0);
            version.Name = "version";
            version.Size = new Size(31, 12);
            version.TabIndex = 84;
            version.Text = "0.9.98";
            // 
            // overflowCurseBlocker
            // 
            overflowCurseBlocker.AutoSize = true;
            overflowCurseBlocker.Location = new Point(819, 465);
            overflowCurseBlocker.Name = "overflowCurseBlocker";
            overflowCurseBlocker.Size = new Size(13, 13);
            overflowCurseBlocker.TabIndex = 85;
            overflowCurseBlocker.Text = "0";
            // 
            // NotifyFunctionEngine
            // 
            NotifyFunctionEngine.Interval = 372;
            // 
            // Label38
            // 
            Label38.AutoSize = true;
            Label38.Font = new Font("Segoe UI Light", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label38.ForeColor = Color.Black;
            Label38.Location = new Point(8, 87);
            Label38.Name = "Label38";
            Label38.Size = new Size(140, 21);
            Label38.TabIndex = 29;
            Label38.Text = "Current powerplan:";
            // 
            // Button2
            // 
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Font = new Font("Microsoft Sans Serif", 15.0f);
            Button2.Location = new Point(383, 335);
            Button2.Name = "Button2";
            Button2.Size = new Size(296, 52);
            Button2.TabIndex = 86;
            Button2.Text = "SafeMode is active. ";
            Button2.UseVisualStyleBackColor = true;
            // 
            // HighPerformanceWarning
            // 
            HighPerformanceWarning.Enabled = true;
            HighPerformanceWarning.Interval = 1800000;
            // 
            // BalancedLabel
            // 
            BalancedLabel.AutoSize = true;
            BalancedLabel.Location = new Point(40, 76);
            BalancedLabel.Name = "BalancedLabel";
            BalancedLabel.Size = new Size(37, 13);
            BalancedLabel.TabIndex = 91;
            BalancedLabel.Text = "Active";
            BalancedLabel.Visible = false;
            // 
            // HighPerfLabel
            // 
            HighPerfLabel.AutoSize = true;
            HighPerfLabel.Location = new Point(136, 74);
            HighPerfLabel.Name = "HighPerfLabel";
            HighPerfLabel.Size = new Size(37, 13);
            HighPerfLabel.TabIndex = 91;
            HighPerfLabel.Text = "Active";
            HighPerfLabel.Visible = false;
            // 
            // PowerSaveLabel
            // 
            PowerSaveLabel.AutoSize = true;
            PowerSaveLabel.Location = new Point(233, 76);
            PowerSaveLabel.Name = "PowerSaveLabel";
            PowerSaveLabel.Size = new Size(37, 13);
            PowerSaveLabel.TabIndex = 91;
            PowerSaveLabel.Text = "Active";
            PowerSaveLabel.Visible = false;
            // 
            // Label40
            // 
            Label40.AutoSize = true;
            Label40.Location = new Point(398, 39);
            Label40.Name = "Label40";
            Label40.Size = new Size(222, 26);
            Label40.TabIndex = 92;
            Label40.Text = "Hidden features are still being used by APMS " + '\r' + '\n' + "but they are restricted to user";
            // 
            // Label42
            // 
            Label42.AutoSize = true;
            Label42.Location = new Point(692, 39);
            Label42.Name = "Label42";
            Label42.Size = new Size(206, 26);
            Label42.TabIndex = 93;
            Label42.Text = "Removed features can be reused in future" + '\r' + '\n' + "but currently they are not being used";
            // 
            // Label43
            // 
            Label43.AutoSize = true;
            Label43.ForeColor = Color.Red;
            Label43.Location = new Point(692, 256);
            Label43.Name = "Label43";
            Label43.Size = new Size(241, 26);
            Label43.TabIndex = 94;
            Label43.Text = "Changing this value is confirmed to be causing" + '\r' + '\n' + "settings file corruption. You sho" + "uld NOT change it";
            // 
            // Label44
            // 
            Label44.AutoSize = true;
            Label44.Location = new Point(951, 39);
            Label44.Name = "Label44";
            Label44.Size = new Size(242, 26);
            Label44.TabIndex = 98;
            Label44.Text = "Currently not being used by APMS, can be " + '\r' + '\n' + "implemented in future and is currently" + " pretty buggy";
            // 
            // Label45
            // 
            Label45.AutoSize = true;
            Label45.Font = new Font("Microsoft Sans Serif", 14.25f);
            Label45.Location = new Point(950, 15);
            Label45.Name = "Label45";
            Label45.Size = new Size(241, 24);
            Label45.TabIndex = 97;
            Label45.Text = "Experimental Test Features";
            // 
            // Label46
            // 
            Label46.AutoSize = true;
            Label46.Location = new Point(1006, 91);
            Label46.Name = "Label46";
            Label46.Size = new Size(82, 13);
            Label46.TabIndex = 100;
            Label46.Text = "Shell arguments";
            // 
            // Button8
            // 
            Button8.ForeColor = Color.Red;
            Button8.Location = new Point(976, 195);
            Button8.Name = "Button8";
            Button8.Size = new Size(154, 33);
            Button8.TabIndex = 103;
            Button8.Text = "NewIcon.apply(Balanced)";
            Button8.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            Button9.ForeColor = Color.Red;
            Button9.Location = new Point(976, 235);
            Button9.Name = "Button9";
            Button9.Size = new Size(154, 33);
            Button9.TabIndex = 104;
            Button9.Text = "NewIcon.apply(HighPerf)";
            Button9.UseVisualStyleBackColor = true;
            // 
            // Testing
            // 
            Testing.Enabled = true;
            Testing.Interval = 1000;
            // 
            // Button10
            // 
            Button10.Location = new Point(976, 299);
            Button10.Name = "Button10";
            Button10.Size = new Size(154, 40);
            Button10.TabIndex = 105;
            Button10.Text = "Count UPM Collection";
            Button10.UseVisualStyleBackColor = true;
            // 
            // memorizePowerPlanEngine
            // 
            // 
            // Button1
            // 
            Button1.Location = new Point(976, 345);
            Button1.Name = "Button1";
            Button1.Size = new Size(154, 40);
            Button1.TabIndex = 105;
            Button1.Text = "Do Until 7250 Test";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label47
            // 
            Label47.AutoSize = true;
            Label47.Location = new Point(1137, 364);
            Label47.Name = "Label47";
            Label47.Size = new Size(19, 13);
            Label47.TabIndex = 106;
            Label47.Text = "00";
            // 
            // RuntimeBenchmarkOutput
            // 
            RuntimeBenchmarkOutput.AutoSize = true;
            RuntimeBenchmarkOutput.Location = new Point(777, 333);
            RuntimeBenchmarkOutput.Name = "RuntimeBenchmarkOutput";
            RuntimeBenchmarkOutput.Size = new Size(100, 13);
            RuntimeBenchmarkOutput.TabIndex = 107;
            RuntimeBenchmarkOutput.Text = "Runtime Timer: 0ms";
            // 
            // RuntimeBenchmarkEngine
            // 
            RuntimeBenchmarkEngine.Interval = 1;
            // 
            // Button11
            // 
            Button11.Location = new Point(744, 345);
            Button11.Name = "Button11";
            Button11.Size = new Size(75, 23);
            Button11.TabIndex = 108;
            Button11.Text = "force start";
            Button11.UseVisualStyleBackColor = true;
            // 
            // Button12
            // 
            Button12.Location = new Point(835, 345);
            Button12.Name = "Button12";
            Button12.Size = new Size(75, 23);
            Button12.TabIndex = 108;
            Button12.Text = "force stop";
            Button12.UseVisualStyleBackColor = true;
            // 
            // Button13
            // 
            Button13.Location = new Point(954, 119);
            Button13.Name = "Button13";
            Button13.Size = new Size(200, 23);
            Button13.TabIndex = 109;
            Button13.Text = "trigger highPerf warning in 15 secs";
            Button13.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(954, 156);
            Button3.Name = "Button3";
            Button3.Size = new Size(200, 23);
            Button3.TabIndex = 109;
            Button3.Text = "throw notification";
            Button3.UseVisualStyleBackColor = true;
            // 
            // ResetNotificationBuffer
            // 
            ResetNotificationBuffer.Interval = 9000;
            // 
            // Button4
            // 
            Button4.Location = new Point(976, 419);
            Button4.Name = "Button4";
            Button4.Size = new Size(154, 23);
            Button4.TabIndex = 110;
            Button4.Text = "Dispose NotifyIcon Icon";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.Location = new Point(1137, 429);
            Label31.Name = "Label31";
            Label31.Size = new Size(13, 13);
            Label31.TabIndex = 111;
            Label31.Text = "0";
            // 
            // CheckUserBehavior
            // 
            CheckUserBehavior.Enabled = true;
            CheckUserBehavior.Interval = 20000;
            // 
            // Button5
            // 
            Button5.Location = new Point(976, 391);
            Button5.Name = "Button5";
            Button5.Size = new Size(199, 23);
            Button5.TabIndex = 112;
            Button5.Text = "Trigger Check User Behavior";
            Button5.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1195, 490);
            Controls.Add(Button5);
            Controls.Add(Label31);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button13);
            Controls.Add(Button12);
            Controls.Add(Button11);
            Controls.Add(RuntimeBenchmarkOutput);
            Controls.Add(Label47);
            Controls.Add(Button1);
            Controls.Add(Button10);
            Controls.Add(Button9);
            Controls.Add(Button8);
            Controls.Add(Label46);
            Controls.Add(Label44);
            Controls.Add(Label45);
            Controls.Add(Label43);
            Controls.Add(Button2);
            Controls.Add(Label42);
            Controls.Add(Label40);
            Controls.Add(PowerSaveLabel);
            Controls.Add(HighPerfLabel);
            Controls.Add(BalancedLabel);
            Controls.Add(overflowCurseBlocker);
            Controls.Add(Label3);
            Controls.Add(buttonquicksetPowerSave);
            Controls.Add(buttonquicksetPerformance);
            Controls.Add(version);
            Controls.Add(Label38);
            Controls.Add(ActivePlanLabel);
            Controls.Add(CurrentGameLabel);
            Controls.Add(Label12);
            Controls.Add(Label26);
            Controls.Add(buttonquicksetBalanced);
            Controls.Add(Label34);
            Controls.Add(Label35);
            Controls.Add(Label33);
            Controls.Add(GamingModeDoNotAlter);
            Controls.Add(GamingModeBalanced);
            Controls.Add(Label24);
            Controls.Add(GamingModeLowFreq);
            Controls.Add(PowerModeLowFreq);
            Controls.Add(CheckBox1);
            Controls.Add(Panel1);
            Controls.Add(Label27);
            Controls.Add(PictureBox1);
            Controls.Add(TimesHidden);
            Controls.Add(Label18);
            Controls.Add(GroupBox1);
            Controls.Add(GroupBox2);
            Controls.Add(Label30);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserInterface";
            ShowIcon = false;
            Text = "Auto Power Mode Switcher by CryptedBytes";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Load += new EventHandler(Form1_Load);
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            VisibleChanged += new EventHandler(Form1_VisibleChanged);
            SizeChanged += new EventHandler(Form1_SizeChanged);
            Move += new EventHandler(Form1_Move);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Label CurrentPowerPlanLabel;
        internal Timer CheckPowerPlan;
        internal RadioButton PowerModeHighPerf;
        internal RadioButton PowerModeBalanced;
        internal Label Label1;
        internal Label Label2;
        internal RadioButton GamingModeLowFreq;
        internal RadioButton GamingModeDoNotAlter;
        internal Label Label4;
        internal Timer SetPowerPlan;
        internal Timer ProcessDetector;
        internal Label ProcessLabel;
        internal GroupBox GroupBox1;
        internal GroupBox GroupBox2;
        internal Timer FormSizeControl;
        internal Label FormHeightLabel;
        internal Label ActivePlanLabel;
        internal Timer MemoryOptimizer;
        internal NotifyIcon NotifyIcon1;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem ToolStripMenuItem1;
        internal ToolStripMenuItem ToolStripMenuItem2;
        internal Timer BootOptimizerConflictFixer;
        internal Label Label14;
        internal Label ConfilictLabel;
        internal Label Label13;
        internal Label Label15;
        internal Label EngineStatusLabel;
        internal Label Label16;
        internal TextBox TargetProcessBox;
        internal Label Label17;
        internal Timer SettingsEngine;
        internal Label Label18;
        internal Label Label19;
        internal Label EnvironmentTickCount;
        internal Timer StartMinimized;
        internal Timer ContextEngine;
        internal Label TimesHidden;
        internal Label AllowQuit;
        internal Label Label8;
        internal PictureBox PictureBox1;
        internal Timer SetPowerPlanAlternate;
        internal ToolStripMenuItem SettingsToolStripMenuItem;
        internal Label Label3;
        internal Label Label9;
        internal Label AutoPilotStatus;
        internal Label Label11;
        internal ToolStripMenuItem SetPowermodeToBalancedToolStripMenuItem;
        internal ToolStripMenuItem SetToHighPerfToolStripMenuItem;
        internal ToolStripMenuItem SetPowermodeToToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal Label Label20;
        internal Label FreeSpaceLabel;
        internal Timer FreeSpaceChecker;
        internal Timer CPUTracker;
        internal Label CPUUsageLabel;
        internal Label Label21;
        internal Label IOLabel;
        internal Label Label23;
        internal Timer EnvTickCounter;
        internal Label Label22;
        internal Label FormLocationLabel;
        internal Label Label27;
        internal Label Label28;
        internal Label Label29;
        internal ToolStripMenuItem ShowAutoPowerSwitcherToolStripMenuItem;
        internal Label Label30;
        internal Label ArgumentsLabel;
        internal ToolStripMenuItem ToolStripMenuItem3;
        internal Label FormWidthLabel;
        internal Label Label5;
        internal CheckBox CheckBox1;
        internal Panel Panel1;
        internal Label Label7;
        internal Label Label10;
        internal RadioButton PowerModeBattery;
        internal RadioButton PowerModeLowFreq;
        internal Panel Panel2;
        internal Panel Panel3;
        internal RadioButton GamingModeHighPerf;
        internal RadioButton GamingModeBalanced;
        internal Label CurrentGameLabel;
        internal CheckBox AllowPowermodeControl;
        internal Label Label24;
        internal Label Label6;
        internal Label Label12;
        internal Label Label25;
        internal Label Label26;
        internal Label Label32;
        internal Label ConsoleFloodCounter;
        internal Button buttonquicksetBalanced;
        internal Button buttonquicksetPowerSave;
        internal Button buttonquicksetPerformance;
        internal Label Label33;
        internal Label Label34;
        internal ToolStripMenuItem PowerSaveToolStripMenuItem;
        internal Timer EnableFastCheck;
        internal Timer FastCheckDeadline;
        internal Label Label35;
        internal CheckBox CheckBox2;
        internal Label version;
        internal Label overflowCurseBlocker;
        internal CheckBox CheckBox3;
        internal Label Label37;
        internal Label NotifyFunctionCounter;
        internal Timer NotifyFunctionEngine;
        internal Label Label38;
        internal Label MemorizedPowerModeLabel;
        internal Label Label39;
        internal Button Button2;
        internal Timer HighPerformanceWarning;
        internal Label BallonTipClickActionByte;
        internal Label Label41;
        internal Label balancedBugFix;
        internal Label BalancedLabel;
        internal Label HighPerfLabel;
        internal Label PowerSaveLabel;
        internal Label Label40;
        internal Label Label42;
        internal Label Label43;
        internal Label Label44;
        internal Label Label45;
        internal Label Label46;
        internal Button Button8;
        internal Button Button9;
        internal Timer Testing;
        internal Button Button10;
        internal Timer memorizePowerPlanEngine;
        internal Label Label36;
        internal Button Button1;
        internal Label Label47;
        internal Label RuntimeBenchmarkOutput;
        internal Timer RuntimeBenchmarkEngine;
        internal Button Button11;
        internal Button Button12;
        internal Button Button13;
        internal Button Button3;
        internal Timer ResetNotificationBuffer;
        internal Button Button4;
        internal Label Label31;
        internal Timer CheckUserBehavior;
        internal Button Button5;
    }
}