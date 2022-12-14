using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserPreferencesModule : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPreferencesModule));
            DetectionEngine = new Timer(components);
            DetectionEngine.Tick += new EventHandler(Engine_Tick);
            UIEngine = new Timer(components);
            UIEngine.Tick += new EventHandler(UIEngine_Tick);
            UninstallPanel = new Panel();
            ProcessingAnimator = new Timer(components);
            ProcessingAnimator.Tick += new EventHandler(ProcessingAnimator_Tick);
            CheckboxDisabler = new Timer(components);
            CheckboxDisabler.Tick += new EventHandler(ConsoleEngine_Tick);
            TabPage7 = new TabPage();
            Panel10 = new Panel();
            Button17 = new Button();
            Button17.Click += new EventHandler(Button17_Click);
            Label57 = new Label();
            Label65 = new Label();
            Panel7 = new Panel();
            Button15 = new Button();
            Button15.Click += new EventHandler(Button15_Click_1);
            Label59 = new Label();
            Label60 = new Label();
            HideGameDetectionPanel = new Panel();
            HideGameDetectionPanel.VisibleChanged += new EventHandler(HideGameDetectionPanel_VisibleChanged);
            LinkLabel6 = new LinkLabel();
            LinkLabel6.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel6_LinkClicked);
            Button11 = new Button();
            Button11.Click += new EventHandler(Button11_Click);
            Label52 = new Label();
            Label40 = new Label();
            Label35 = new Label();
            Label30 = new Label();
            CheckingSpeedPanel = new Panel();
            Label36 = new Label();
            TextBox1 = new TextBox();
            TextBox1.TextChanged += new EventHandler(TextBox1_TextChanged_2);
            Label39 = new Label();
            Button13 = new Button();
            Button13.Click += new EventHandler(Button13_Click);
            Button6 = new Button();
            Button6.Click += new EventHandler(Button6_Click);
            Button16 = new Button();
            Button16.Click += new EventHandler(Button16_Click);
            Button9 = new Button();
            Button9.Click += new EventHandler(Button9_Click);
            Button8 = new Button();
            Button8.Click += new EventHandler(Button8_Click);
            Button5 = new Button();
            Button5.Click += new EventHandler(Button5_Click);
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click_1);
            GameDetectionCollection = new ListBox();
            TabPage5 = new TabPage();
            TabPage5.Enter += new EventHandler(TabPage5_Enter);
            Label46 = new Label();
            UninstallCancelButton = new Button();
            UninstallCancelButton.Click += new EventHandler(UninstallCancelButton_Click);
            Label43 = new Label();
            Label11 = new Label();
            Label44 = new Label();
            Panel5 = new Panel();
            Label37 = new Label();
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            CheckBox10 = new CheckBox();
            CheckBox9 = new CheckBox();
            CheckBox8 = new CheckBox();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            TabPage4 = new TabPage();
            Panel9 = new Panel();
            Panel8 = new Panel();
            Label55 = new Label();
            Panel3 = new Panel();
            Panel3.VisibleChanged += new EventHandler(Panel3_VisibleChanged);
            Label45 = new Label();
            CheckBox6 = new CheckBox();
            Label34 = new Label();
            LinkLabel5 = new LinkLabel();
            LinkLabel5.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel5_LinkClicked);
            Label23 = new Label();
            Label22 = new Label();
            PrioritizeTargetProcessCheckBox = new CheckBox();
            PrioritizeTargetProcessCheckBox.CheckedChanged += new EventHandler(PrioritizeTargetProcessCheckBox_CheckedChanged);
            Label33 = new Label();
            Label18 = new Label();
            Label14 = new Label();
            Label13 = new Label();
            RestartAfterSessionCheckBox = new CheckBox();
            RestartAfterSessionCheckBox.CheckedChanged += new EventHandler(RestartAfterSessionCheckBox_CheckedChanged);
            KillProcessesCheckBox = new CheckBox();
            KillProcessesCheckBox.CheckedChanged += new EventHandler(CheckBox10_CheckedChanged);
            GameBoosterEnabled = new CheckBox();
            GameBoosterEnabled.CheckedChanged += new EventHandler(GameBoosterEnabled_CheckedChanged);
            TabPage3 = new TabPage();
            TabPage3.Click += new EventHandler(TabPage3_Click);
            Label54 = new Label();
            UserTrackingHighSpeedCheckbox = new CheckBox();
            UserTrackingHighSpeedCheckbox.CheckedChanged += new EventHandler(UserTrackingHighSpeedCheckbox_CheckedChanged);
            memory4 = new Label();
            memory2 = new Label();
            OverrideWarningLabel = new Label();
            Label53 = new Label();
            Label51 = new Label();
            UIEngineLabel = new Label();
            Button7 = new Button();
            Button7.Click += new EventHandler(Button7_Click);
            Label38 = new Label();
            NoImpactCheckbox = new CheckBox();
            NoImpactCheckbox.CheckedChanged += new EventHandler(DelayStartup_CheckedChanged);
            Label29 = new Label();
            Label28 = new Label();
            Label27 = new Label();
            Label26 = new Label();
            Label25 = new Label();
            Label24 = new Label();
            UserTrackingCheckbox = new CheckBox();
            UserTrackingCheckbox.CheckedChanged += new EventHandler(CheckBox6_CheckedChanged);
            Label21 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label17 = new Label();
            EnableBootManagerCheck = new CheckBox();
            EnableBootManagerCheck.CheckedChanged += new EventHandler(EnableBootManagerCheck_CheckedChanged);
            EnableExperimentalFeatuesCheckBox = new CheckBox();
            EnableExperimentalFeatuesCheckBox.CheckedChanged += new EventHandler(CheckBox7_CheckedChanged);
            LinkLabel3 = new LinkLabel();
            LinkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel3_LinkClicked);
            Label5 = new Label();
            StartMinimized = new CheckBox();
            StartMinimized.CheckedChanged += new EventHandler(StartMinimized_CheckedChanged);
            TopMostCheckbox = new CheckBox();
            TopMostCheckbox.CheckedChanged += new EventHandler(TopMostCheckbox_CheckedChanged);
            StartonBoot = new CheckBox();
           
            TabPage1 = new TabPage();
            HideLegacySettingsPanel1 = new Panel();
            Label64 = new Label();
            Label58 = new Label();
            Button14 = new Button();
            Button14.Click += new EventHandler(Button14_Click);
            Label63 = new Label();
            Label62 = new Label();
            Label61 = new Label();
            Label50 = new Label();
            isAlreadyRunningLabel = new Label();
            Label49 = new Label();
            memory = new Label();
            Label48 = new Label();
            Label47 = new Label();
            SimulateProcessRunningCheckbox = new CheckBox();
            SimulateProcessRunningCheckbox.CheckedChanged += new EventHandler(CheckBox13_CheckedChanged);
            Label9 = new Label();
            Label16 = new Label();
            Panel1 = new Panel();
            Panel2 = new Panel();
            memory3 = new Label();
            IntervalWarning = new Label();
            Label4 = new Label();
            Interval2 = new RadioButton();
            Interval2.CheckedChanged += new EventHandler(Invertal2_CheckedChanged);
            Interval1 = new RadioButton();
            Label8 = new Label();
            LinkLabel2 = new LinkLabel();
            LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            EngineMode1 = new RadioButton();
            LinkLabel1 = new LinkLabel();
            LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            EngineMode2 = new RadioButton();
            EngineMode2.CheckedChanged += new EventHandler(EngineMode2_CheckedChanged);
            Label7 = new Label();
            Label6 = new Label();
            Panel4 = new Panel();
            ShowWarn = new Label();
            Label20 = new Label();
            LowFreqGUID = new TextBox();
            LowFreqGUID.TextChanged += new EventHandler(TextBox1_TextChanged);
            LowFreqGUID.Click += new EventHandler(LowFreqGUID_Click);
            LinkLabel4 = new LinkLabel();
            LinkLabel4.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel4_LinkClicked);
            Label12 = new Label();
            WarnLabel = new Label();
            TabPage2 = new TabPage();
            PrivacyStatementPanel = new Panel();
            PrivacyStatementPanel.VisibleChanged += new EventHandler(PrivacyStatementPanel_VisibleChanged);
            Label31 = new Label();
            Label32 = new Label();
            Panel6 = new Panel();
            Button12 = new Button();
            Button12.Click += new EventHandler(Button12_Click);
            Button10 = new Button();
            Button10.Click += new EventHandler(Button10_Click);
            Label42 = new Label();
            Label41 = new Label();
            Label15 = new Label();
            Label10 = new Label();
            Label3 = new Label();
            GroupBox1 = new GroupBox();
            Label56 = new Label();
            Label2 = new Label();
            Userdetect = new RadioButton();
            Userdetect.CheckedChanged += new EventHandler(Userdetect_CheckedChanged);
            UserNOdetect = new RadioButton();
            GroupBox2 = new GroupBox();
            Label19 = new Label();
            CheckBox12 = new CheckBox();
            CheckBox11 = new CheckBox();
            Label1 = new Label();
            CheckBox2 = new CheckBox();
            CheckBox5 = new CheckBox();
            CheckBox1 = new CheckBox();
            CheckBox3 = new CheckBox();
            TabControl1 = new TabControl();
            TabControl1.TabStopChanged += new EventHandler(TabControl1_TabStopChanged);
            TabControl1.TabIndexChanged += new EventHandler(TabControl1_TabIndexChanged);
            TabControl1.SelectedIndexChanged += new EventHandler(TabControl1_SelectedIndexChanged);
            TabPage7.SuspendLayout();
            Panel10.SuspendLayout();
            Panel7.SuspendLayout();
            HideGameDetectionPanel.SuspendLayout();
            CheckingSpeedPanel.SuspendLayout();
            TabPage5.SuspendLayout();
            Panel5.SuspendLayout();
            TabPage4.SuspendLayout();
            Panel3.SuspendLayout();
            TabPage3.SuspendLayout();
            TabPage1.SuspendLayout();
            HideLegacySettingsPanel1.SuspendLayout();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel4.SuspendLayout();
            TabPage2.SuspendLayout();
            PrivacyStatementPanel.SuspendLayout();
            Panel6.SuspendLayout();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            TabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // DetectionEngine
            // 
            DetectionEngine.Interval = 10000;
            // 
            // UIEngine
            // 
            UIEngine.Enabled = true;
            UIEngine.Interval = 2200;
            // 
            // UninstallPanel
            // 
            UninstallPanel.Location = new Point(24, 421);
            UninstallPanel.Name = "UninstallPanel";
            UninstallPanel.Size = new Size(691, 25);
            UninstallPanel.TabIndex = 62;
            UninstallPanel.Visible = false;
            // 
            // ProcessingAnimator
            // 
            ProcessingAnimator.Interval = 220;
            // 
            // CheckboxDisabler
            // 
            CheckboxDisabler.Enabled = true;
            CheckboxDisabler.Interval = 1;
            // 
            // TabPage7
            // 
            TabPage7.Controls.Add(Panel10);
            TabPage7.Controls.Add(Panel7);
            TabPage7.Controls.Add(HideGameDetectionPanel);
            TabPage7.Controls.Add(CheckingSpeedPanel);
            TabPage7.Controls.Add(Label39);
            TabPage7.Controls.Add(Button13);
            TabPage7.Controls.Add(Button6);
            TabPage7.Controls.Add(Button16);
            TabPage7.Controls.Add(Button9);
            TabPage7.Controls.Add(Button8);
            TabPage7.Controls.Add(Button5);
            TabPage7.Controls.Add(Button4);
            TabPage7.Controls.Add(GameDetectionCollection);
            TabPage7.Location = new Point(4, 22);
            TabPage7.Name = "TabPage7";
            TabPage7.Padding = new Padding(3);
            TabPage7.Size = new Size(691, 384);
            TabPage7.TabIndex = 6;
            TabPage7.Text = "Game Detection";
            TabPage7.UseVisualStyleBackColor = true;
            // 
            // Panel10
            // 
            Panel10.Controls.Add(Button17);
            Panel10.Controls.Add(Label57);
            Panel10.Controls.Add(Label65);
            Panel10.Location = new Point(623, 313);
            Panel10.Name = "Panel10";
            Panel10.Size = new Size(689, 382);
            Panel10.TabIndex = 64;
            Panel10.Visible = false;
            // 
            // Button17
            // 
            Button17.FlatStyle = FlatStyle.Flat;
            Button17.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button17.Location = new Point(76, 316);
            Button17.Name = "Button17";
            Button17.Size = new Size(535, 42);
            Button17.TabIndex = 57;
            Button17.Text = "Enable GameDetectionUtility";
            Button17.UseVisualStyleBackColor = true;
            // 
            // Label57
            // 
            Label57.AutoSize = true;
            Label57.Font = new Font("Segoe UI Light", 10.25f);
            Label57.Location = new Point(219, 294);
            Label57.Name = "Label57";
            Label57.Size = new Size(248, 19);
            Label57.TabIndex = 56;
            Label57.Text = "To enable it again, click the button below.";
            // 
            // Label65
            // 
            Label65.AutoSize = true;
            Label65.Font = new Font("Segoe UI Light", 24.25f);
            Label65.Location = new Point(105, 155);
            Label65.Name = "Label65";
            Label65.Size = new Size(484, 45);
            Label65.TabIndex = 56;
            Label65.Text = "Game Detection Utility is disabled";
            // 
            // Panel7
            // 
            Panel7.Controls.Add(Button15);
            Panel7.Controls.Add(Label59);
            Panel7.Controls.Add(Label60);
            Panel7.Location = new Point(645, 37);
            Panel7.Name = "Panel7";
            Panel7.Size = new Size(689, 382);
            Panel7.TabIndex = 63;
            Panel7.Visible = false;
            // 
            // Button15
            // 
            Button15.FlatStyle = FlatStyle.Flat;
            Button15.Font = new Font("Segoe UI Light", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button15.Location = new Point(173, 215);
            Button15.Name = "Button15";
            Button15.Size = new Size(320, 56);
            Button15.TabIndex = 57;
            Button15.Text = "Enable PowerMode controls back!";
            Button15.UseVisualStyleBackColor = true;
            // 
            // Label59
            // 
            Label59.AutoSize = true;
            Label59.Font = new Font("Segoe UI Light", 12.25f);
            Label59.Location = new Point(169, 141);
            Label59.Name = "Label59";
            Label59.Size = new Size(351, 23);
            Label59.TabIndex = 56;
            Label59.Text = "As you have disabled the PowerMode Controls";
            // 
            // Label60
            // 
            Label60.AutoSize = true;
            Label60.Font = new Font("Segoe UI Light", 20.25f);
            Label60.Location = new Point(52, 164);
            Label60.Name = "Label60";
            Label60.Size = new Size(593, 37);
            Label60.TabIndex = 56;
            Label60.Text = "Game Detection Utility cannot work at the moment.";
            // 
            // HideGameDetectionPanel
            // 
            HideGameDetectionPanel.Controls.Add(LinkLabel6);
            HideGameDetectionPanel.Controls.Add(Button11);
            HideGameDetectionPanel.Controls.Add(Label52);
            HideGameDetectionPanel.Controls.Add(Label40);
            HideGameDetectionPanel.Controls.Add(Label35);
            HideGameDetectionPanel.Controls.Add(Label30);
            HideGameDetectionPanel.Location = new Point(679, 15);
            HideGameDetectionPanel.Name = "HideGameDetectionPanel";
            HideGameDetectionPanel.Size = new Size(689, 382);
            HideGameDetectionPanel.TabIndex = 62;
            // 
            // LinkLabel6
            // 
            LinkLabel6.AutoSize = true;
            LinkLabel6.Location = new Point(585, 9);
            LinkLabel6.Name = "LinkLabel6";
            LinkLabel6.Size = new Size(81, 13);
            LinkLabel6.TabIndex = 58;
            LinkLabel6.TabStop = true;
            LinkLabel6.Text = "Force Recheck";
            // 
            // Button11
            // 
            Button11.FlatStyle = FlatStyle.Flat;
            Button11.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button11.Location = new Point(61, 316);
            Button11.Name = "Button11";
            Button11.Size = new Size(535, 42);
            Button11.TabIndex = 57;
            Button11.Text = "Let me review my AutoPilot preferences";
            Button11.UseVisualStyleBackColor = true;
            // 
            // Label52
            // 
            Label52.AutoSize = true;
            Label52.Font = new Font("Segoe UI Light", 10.25f);
            Label52.Location = new Point(144, 298);
            Label52.Name = "Label52";
            Label52.Size = new Size(380, 19);
            Label52.TabIndex = 56;
            Label52.Text = "Click the button below to enable AutoPilot and unlock this utility";
            // 
            // Label40
            // 
            Label40.AutoSize = true;
            Label40.Font = new Font("Segoe UI Light", 11.25f);
            Label40.Location = new Point(215, 141);
            Label40.Name = "Label40";
            Label40.Size = new Size(224, 20);
            Label40.TabIndex = 56;
            Label40.Text = "we have just disabled it out for you";
            // 
            // Label35
            // 
            Label35.AutoSize = true;
            Label35.Font = new Font("Segoe UI Light", 12.25f);
            Label35.Location = new Point(167, 118);
            Label35.Name = "Label35";
            Label35.Size = new Size(326, 23);
            Label35.TabIndex = 56;
            Label35.Text = "this utility cannot work without the AutoPilot";
            // 
            // Label30
            // 
            Label30.AutoSize = true;
            Label30.Font = new Font("Segoe UI Light", 20.25f);
            Label30.Location = new Point(130, 161);
            Label30.Name = "Label30";
            Label30.Size = new Size(394, 37);
            Label30.TabIndex = 56;
            Label30.Text = "Game Detection Utility is disabled";
            // 
            // CheckingSpeedPanel
            // 
            CheckingSpeedPanel.Controls.Add(Label36);
            CheckingSpeedPanel.Controls.Add(TextBox1);
            CheckingSpeedPanel.Location = new Point(31, 313);
            CheckingSpeedPanel.Name = "CheckingSpeedPanel";
            CheckingSpeedPanel.Size = new Size(161, 50);
            CheckingSpeedPanel.TabIndex = 61;
            // 
            // Label36
            // 
            Label36.AutoSize = true;
            Label36.Location = new Point(28, 2);
            Label36.Name = "Label36";
            Label36.Size = new Size(108, 13);
            Label36.TabIndex = 56;
            Label36.Text = "Checking Speed (ms)";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(46, 18);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(63, 20);
            TextBox1.TabIndex = 55;
            TextBox1.Text = "10000";
            // 
            // Label39
            // 
            Label39.AutoSize = true;
            Label39.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label39.Location = new Point(13, 8);
            Label39.Name = "Label39";
            Label39.Size = new Size(193, 25);
            Label39.TabIndex = 55;
            Label39.Text = "Game Detection Utility";
            // 
            // Button13
            // 
            Button13.FlatStyle = FlatStyle.Flat;
            Button13.ForeColor = Color.Black;
            Button13.Location = new Point(31, 120);
            Button13.Name = "Button13";
            Button13.Size = new Size(164, 30);
            Button13.TabIndex = 5;
            Button13.Text = "Remove all items from the list";
            Button13.UseVisualStyleBackColor = true;
            // 
            // Button6
            // 
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.ForeColor = Color.Black;
            Button6.Location = new Point(31, 156);
            Button6.Name = "Button6";
            Button6.Size = new Size(164, 30);
            Button6.TabIndex = 5;
            Button6.Text = "Restore default list items";
            Button6.UseVisualStyleBackColor = true;
            // 
            // Button16
            // 
            Button16.FlatStyle = FlatStyle.Flat;
            Button16.Font = new Font("Microsoft Sans Serif", 8.25f);
            Button16.Location = new Point(31, 192);
            Button16.Name = "Button16";
            Button16.Size = new Size(164, 30);
            Button16.TabIndex = 1;
            Button16.Text = "Reload";
            Button16.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            Button9.FlatStyle = FlatStyle.Flat;
            Button9.Font = new Font("Microsoft Sans Serif", 8.25f);
            Button9.Location = new Point(31, 266);
            Button9.Name = "Button9";
            Button9.Size = new Size(164, 30);
            Button9.TabIndex = 1;
            Button9.Text = "Get help";
            Button9.UseVisualStyleBackColor = true;
            // 
            // Button8
            // 
            Button8.FlatStyle = FlatStyle.Flat;
            Button8.Font = new Font("Microsoft Sans Serif", 8.25f);
            Button8.Location = new Point(31, 230);
            Button8.Name = "Button8";
            Button8.Size = new Size(164, 30);
            Button8.TabIndex = 1;
            Button8.Text = "Disable game detection";
            Button8.UseVisualStyleBackColor = true;
            // 
            // Button5
            // 
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.Font = new Font("Microsoft Sans Serif", 8.25f);
            Button5.Location = new Point(31, 84);
            Button5.Name = "Button5";
            Button5.Size = new Size(164, 30);
            Button5.TabIndex = 1;
            Button5.Text = "Remove selected from the list";
            Button5.UseVisualStyleBackColor = true;
            // 
            // Button4
            // 
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Font = new Font("Microsoft Sans Serif", 8.25f);
            Button4.Location = new Point(31, 48);
            Button4.Name = "Button4";
            Button4.Size = new Size(164, 30);
            Button4.TabIndex = 1;
            Button4.Text = "Add a process to the list";
            Button4.UseVisualStyleBackColor = true;
            // 
            // GameDetectionCollection
            // 
            GameDetectionCollection.FormattingEnabled = true;
            GameDetectionCollection.Location = new Point(212, 48);
            GameDetectionCollection.Name = "GameDetectionCollection";
            GameDetectionCollection.Size = new Size(179, 251);
            GameDetectionCollection.TabIndex = 0;
            // 
            // TabPage5
            // 
            TabPage5.Controls.Add(Label46);
            TabPage5.Controls.Add(UninstallCancelButton);
            TabPage5.Controls.Add(Label43);
            TabPage5.Controls.Add(Label11);
            TabPage5.Controls.Add(Label44);
            TabPage5.Controls.Add(Panel5);
            TabPage5.Controls.Add(CheckBox10);
            TabPage5.Controls.Add(CheckBox9);
            TabPage5.Controls.Add(CheckBox8);
            TabPage5.Controls.Add(Button2);
            TabPage5.Location = new Point(4, 22);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(691, 384);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "Reset This Application";
            TabPage5.UseVisualStyleBackColor = true;
            // 
            // Label46
            // 
            Label46.AutoSize = true;
            Label46.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label46.ForeColor = Color.Red;
            Label46.Location = new Point(244, 138);
            Label46.Name = "Label46";
            Label46.Size = new Size(159, 31);
            Label46.TabIndex = 63;
            Label46.Text = "Processing";
            Label46.Visible = false;
            // 
            // UninstallCancelButton
            // 
            UninstallCancelButton.Location = new Point(594, 3);
            UninstallCancelButton.Name = "UninstallCancelButton";
            UninstallCancelButton.Size = new Size(91, 33);
            UninstallCancelButton.TabIndex = 62;
            UninstallCancelButton.Text = "CANCEL";
            UninstallCancelButton.UseVisualStyleBackColor = true;
            UninstallCancelButton.Visible = false;
            // 
            // Label43
            // 
            Label43.AutoSize = true;
            Label43.Font = new Font("Segoe UI Light", 10.25f);
            Label43.Location = new Point(32, 49);
            Label43.Name = "Label43";
            Label43.Size = new Size(391, 19);
            Label43.TabIndex = 56;
            Label43.Text = "Uninstall or reset AutoPowerModeSwitcher's selected components";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(317, 304);
            Label11.Name = "Label11";
            Label11.Size = new Size(13, 13);
            Label11.TabIndex = 61;
            Label11.Text = "0";
            Label11.Visible = false;
            // 
            // Label44
            // 
            Label44.AutoSize = true;
            Label44.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label44.Location = new Point(31, 24);
            Label44.Name = "Label44";
            Label44.Size = new Size(263, 25);
            Label44.TabIndex = 55;
            Label44.Text = "Reset AutoPowerModeSwitcher";
            // 
            // Panel5
            // 
            Panel5.Controls.Add(Label37);
            Panel5.Controls.Add(Button3);
            Panel5.Location = new Point(239, 200);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(446, 100);
            Panel5.TabIndex = 60;
            // 
            // Label37
            // 
            Label37.AutoSize = true;
            Label37.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
            Label37.ForeColor = Color.Red;
            Label37.Location = new Point(2, 24);
            Label37.Name = "Label37";
            Label37.Size = new Size(190, 15);
            Label37.TabIndex = 62;
            Label37.Text = "Admin privileges are needed";
            Label37.Visible = false;
            // 
            // Button3
            // 
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Location = new Point(3, 42);
            Button3.Name = "Button3";
            Button3.Size = new Size(189, 54);
            Button3.TabIndex = 61;
            Button3.Text = "Reset AutoPowerModeSwitcher";
            Button3.UseVisualStyleBackColor = true;
            // 
            // CheckBox10
            // 
            CheckBox10.AutoSize = true;
            CheckBox10.Location = new Point(429, 340);
            CheckBox10.Name = "CheckBox10";
            CheckBox10.Size = new Size(106, 17);
            CheckBox10.TabIndex = 59;
            CheckBox10.Text = "Reset all settings";
            CheckBox10.UseVisualStyleBackColor = true;
            // 
            // CheckBox9
            // 
            CheckBox9.AutoSize = true;
            CheckBox9.Location = new Point(429, 357);
            CheckBox9.Name = "CheckBox9";
            CheckBox9.Size = new Size(252, 17);
            CheckBox9.TabIndex = 58;
            CheckBox9.Text = "Uninstall APMS from system deleting all app files";
            CheckBox9.UseVisualStyleBackColor = true;
            // 
            // CheckBox8
            // 
            CheckBox8.AutoSize = true;
            CheckBox8.Location = new Point(429, 320);
            CheckBox8.Name = "CheckBox8";
            CheckBox8.Size = new Size(140, 17);
            CheckBox8.TabIndex = 57;
            CheckBox8.Text = "Remove all registry keys";
            CheckBox8.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Location = new Point(249, 320);
            Button2.Name = "Button2";
            Button2.Size = new Size(174, 54);
            Button2.TabIndex = 56;
            Button2.Text = "Execute Selected Commands";
            Button2.UseVisualStyleBackColor = true;
            // 
            // TabPage4
            // 
            TabPage4.Controls.Add(Panel9);
            TabPage4.Controls.Add(Panel8);
            TabPage4.Controls.Add(Label55);
            TabPage4.Controls.Add(Panel3);
            TabPage4.Controls.Add(PrioritizeTargetProcessCheckBox);
            TabPage4.Controls.Add(Label33);
            TabPage4.Controls.Add(Label18);
            TabPage4.Controls.Add(Label14);
            TabPage4.Controls.Add(Label13);
            TabPage4.Controls.Add(RestartAfterSessionCheckBox);
            TabPage4.Controls.Add(KillProcessesCheckBox);
            TabPage4.Controls.Add(GameBoosterEnabled);
            TabPage4.Location = new Point(4, 22);
            TabPage4.Name = "TabPage4";
            TabPage4.Padding = new Padding(3);
            TabPage4.Size = new Size(691, 384);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "TaskManager Settings";
            TabPage4.UseVisualStyleBackColor = true;
            // 
            // Panel9
            // 
            Panel9.Location = new Point(56, 194);
            Panel9.Name = "Panel9";
            Panel9.Size = new Size(218, 23);
            Panel9.TabIndex = 60;
            // 
            // Panel8
            // 
            Panel8.Location = new Point(38, 224);
            Panel8.Name = "Panel8";
            Panel8.Size = new Size(647, 104);
            Panel8.TabIndex = 59;
            // 
            // Label55
            // 
            Label55.AutoSize = true;
            Label55.Font = new Font("Microsoft Sans Serif", 8.75f);
            Label55.ForeColor = Color.Red;
            Label55.Location = new Point(165, 288);
            Label55.Name = "Label55";
            Label55.Size = new Size(362, 15);
            Label55.TabIndex = 58;
            Label55.Text = "Note: OneDrive is no longer killed due to issues restoring it's state";
            // 
            // Panel3
            // 
            Panel3.Controls.Add(Label45);
            Panel3.Controls.Add(CheckBox6);
            Panel3.Controls.Add(Label34);
            Panel3.Controls.Add(LinkLabel5);
            Panel3.Controls.Add(Label23);
            Panel3.Controls.Add(Label22);
            Panel3.Location = new Point(680, 37);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(668, 199);
            Panel3.TabIndex = 55;
            // 
            // Label45
            // 
            Label45.AutoSize = true;
            Label45.Location = new Point(208, 9);
            Label45.Name = "Label45";
            Label45.Size = new Size(224, 26);
            Label45.TabIndex = 6;
            Label45.Text = "this warning is removed." + '\r' + '\n' + "remove visible changed codes to bring it back";
            // 
            // CheckBox6
            // 
            CheckBox6.AutoSize = true;
            CheckBox6.Location = new Point(425, 178);
            CheckBox6.Name = "CheckBox6";
            CheckBox6.Size = new Size(182, 17);
            CheckBox6.TabIndex = 5;
            CheckBox6.Text = "And don't ever show this warning";
            CheckBox6.UseVisualStyleBackColor = true;
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.Location = new Point(109, 159);
            Label34.Name = "Label34";
            Label34.Size = new Size(473, 13);
            Label34.TabIndex = 4;
            Label34.Text = "However you may use it before release if you accept your CPU to be burnt by a sim" + "ple memory leak";
            // 
            // LinkLabel5
            // 
            LinkLabel5.AutoSize = true;
            LinkLabel5.Font = new Font("Microsoft Sans Serif", 10.25f);
            LinkLabel5.Location = new Point(236, 174);
            LinkLabel5.Name = "LinkLabel5";
            LinkLabel5.Size = new Size(169, 17);
            LinkLabel5.TabIndex = 3;
            LinkLabel5.TabStop = true;
            LinkLabel5.Text = "I accept the risk, continue";
            // 
            // Label23
            // 
            Label23.AutoSize = true;
            Label23.Font = new Font("Segoe UI Light", 14.25f);
            Label23.ForeColor = Color.Black;
            Label23.Location = new Point(3, 86);
            Label23.Name = "Label23";
            Label23.Size = new Size(636, 25);
            Label23.TabIndex = 1;
            Label23.Text = "This feature may get removed on the next build or may get improved instead.";
            // 
            // Label22
            // 
            Label22.AutoSize = true;
            Label22.Font = new Font("Segoe UI Light", 20.25f);
            Label22.ForeColor = Color.Red;
            Label22.Location = new Point(66, 46);
            Label22.Name = "Label22";
            Label22.Size = new Size(516, 37);
            Label22.TabIndex = 0;
            Label22.Text = "This feature is currently disabled in this build ";
            // 
            // PrioritizeTargetProcessCheckBox
            // 
            PrioritizeTargetProcessCheckBox.AutoSize = true;
            PrioritizeTargetProcessCheckBox.Font = new Font("Segoe UI Light", 11f);
            PrioritizeTargetProcessCheckBox.Location = new Point(56, 194);
            PrioritizeTargetProcessCheckBox.Name = "PrioritizeTargetProcessCheckBox";
            PrioritizeTargetProcessCheckBox.Size = new Size(218, 24);
            PrioritizeTargetProcessCheckBox.TabIndex = 57;
            PrioritizeTargetProcessCheckBox.Text = "TRY to prioritize target process";
            PrioritizeTargetProcessCheckBox.UseVisualStyleBackColor = true;
            // 
            // Label33
            // 
            Label33.AutoSize = true;
            Label33.Font = new Font("Microsoft Sans Serif", 8.75f);
            Label33.ForeColor = Color.Red;
            Label33.Location = new Point(53, 254);
            Label33.Name = "Label33";
            Label33.Size = new Size(590, 15);
            Label33.TabIndex = 56;
            Label33.Text = "Rainmeter, Dropbox, iCloud Sync, KeyScrambler, Lightshot, TeamViewer and a few mo" + "re apps will be killed";
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Segoe UI Light", 10.25f);
            Label18.Location = new Point(35, 48);
            Label18.Name = "Label18";
            Label18.Size = new Size(623, 19);
            Label18.TabIndex = 54;
            Label18.Text = "Enable TaskManager to let us kill some processes to gain more RAM and CPU for you" + "r gaming purposes.";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label14.ForeColor = Color.Red;
            Label14.Location = new Point(53, 241);
            Label14.Name = "Label14";
            Label14.Size = new Size(477, 13);
            Label14.TabIndex = 51;
            Label14.Text = "THIS MODULE IS EXPERIMENTAL AND CURRENTLY IN ACTIVE DEVELOPMENT";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label13.Location = new Point(34, 23);
            Label13.Name = "Label13";
            Label13.Size = new Size(182, 25);
            Label13.TabIndex = 50;
            Label13.Text = "TaskManager Settings";
            // 
            // RestartAfterSessionCheckBox
            // 
            RestartAfterSessionCheckBox.AutoSize = true;
            RestartAfterSessionCheckBox.Font = new Font("Segoe UI Light", 11f);
            RestartAfterSessionCheckBox.Location = new Point(56, 164);
            RestartAfterSessionCheckBox.Name = "RestartAfterSessionCheckBox";
            RestartAfterSessionCheckBox.Size = new Size(327, 24);
            RestartAfterSessionCheckBox.TabIndex = 11;
            RestartAfterSessionCheckBox.Text = "Restart killed processes after game session ends";
            RestartAfterSessionCheckBox.UseVisualStyleBackColor = true;
            // 
            // KillProcessesCheckBox
            // 
            KillProcessesCheckBox.AutoSize = true;
            KillProcessesCheckBox.Font = new Font("Segoe UI Light", 11f);
            KillProcessesCheckBox.Location = new Point(56, 131);
            KillProcessesCheckBox.Name = "KillProcessesCheckBox";
            KillProcessesCheckBox.Size = new Size(160, 24);
            KillProcessesCheckBox.TabIndex = 10;
            KillProcessesCheckBox.Text = "Kill useless processes";
            KillProcessesCheckBox.UseVisualStyleBackColor = true;
            // 
            // GameBoosterEnabled
            // 
            GameBoosterEnabled.AutoSize = true;
            GameBoosterEnabled.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameBoosterEnabled.Location = new Point(35, 101);
            GameBoosterEnabled.Name = "GameBoosterEnabled";
            GameBoosterEnabled.Size = new Size(259, 29);
            GameBoosterEnabled.TabIndex = 0;
            GameBoosterEnabled.Text = "Enable TaskManager Module";
            GameBoosterEnabled.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(Label54);
            TabPage3.Controls.Add(UserTrackingHighSpeedCheckbox);
            TabPage3.Controls.Add(memory4);
            TabPage3.Controls.Add(memory2);
            TabPage3.Controls.Add(OverrideWarningLabel);
            TabPage3.Controls.Add(Label53);
            TabPage3.Controls.Add(Label51);
            TabPage3.Controls.Add(UIEngineLabel);
            TabPage3.Controls.Add(Button7);
            TabPage3.Controls.Add(Label38);
            TabPage3.Controls.Add(NoImpactCheckbox);
            TabPage3.Controls.Add(Label29);
            TabPage3.Controls.Add(Label28);
            TabPage3.Controls.Add(Label27);
            TabPage3.Controls.Add(Label26);
            TabPage3.Controls.Add(Label25);
            TabPage3.Controls.Add(Label24);
            TabPage3.Controls.Add(UserTrackingCheckbox);
            TabPage3.Controls.Add(Label21);
            TabPage3.Controls.Add(Button1);
            TabPage3.Controls.Add(Label17);
            TabPage3.Controls.Add(EnableBootManagerCheck);
            TabPage3.Controls.Add(EnableExperimentalFeatuesCheckBox);
            TabPage3.Controls.Add(LinkLabel3);
            TabPage3.Controls.Add(Label5);
            TabPage3.Controls.Add(StartMinimized);
            TabPage3.Controls.Add(TopMostCheckbox);
            TabPage3.Controls.Add(StartonBoot);
            TabPage3.Location = new Point(4, 22);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(691, 384);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Application Settings";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // Label54
            // 
            Label54.AutoSize = true;
            Label54.Location = new Point(550, 96);
            Label54.Name = "Label54";
            Label54.Size = new Size(45, 13);
            Label54.TabIndex = 75;
            Label54.Text = "tracking";
            Label54.Visible = false;
            // 
            // UserTrackingHighSpeedCheckbox
            // 
            UserTrackingHighSpeedCheckbox.AutoSize = true;
            UserTrackingHighSpeedCheckbox.Location = new Point(548, 235);
            UserTrackingHighSpeedCheckbox.Name = "UserTrackingHighSpeedCheckbox";
            UserTrackingHighSpeedCheckbox.Size = new Size(108, 17);
            UserTrackingHighSpeedCheckbox.TabIndex = 74;
            UserTrackingHighSpeedCheckbox.Text = "Precise checking";
            UserTrackingHighSpeedCheckbox.UseVisualStyleBackColor = true;
            // 
            // memory4
            // 
            memory4.AutoSize = true;
            memory4.Location = new Point(575, 109);
            memory4.Name = "memory4";
            memory4.Size = new Size(49, 13);
            memory4.TabIndex = 73;
            memory4.Text = "memory4";
            memory4.Visible = false;
            // 
            // memory2
            // 
            memory2.AutoSize = true;
            memory2.Location = new Point(610, 95);
            memory2.Name = "memory2";
            memory2.Size = new Size(49, 13);
            memory2.TabIndex = 71;
            memory2.Text = "memory2";
            memory2.Visible = false;
            // 
            // OverrideWarningLabel
            // 
            OverrideWarningLabel.AutoSize = true;
            OverrideWarningLabel.Font = new Font("Segoe UI Light", 10.25f);
            OverrideWarningLabel.ForeColor = Color.Red;
            OverrideWarningLabel.Location = new Point(178, 4);
            OverrideWarningLabel.Name = "OverrideWarningLabel";
            OverrideWarningLabel.Size = new Size(290, 19);
            OverrideWarningLabel.TabIndex = 70;
            OverrideWarningLabel.Text = "Some settings are managed by global overrides";
            OverrideWarningLabel.Visible = false;
            // 
            // Label53
            // 
            Label53.AutoSize = true;
            Label53.Location = new Point(550, 78);
            Label53.Name = "Label53";
            Label53.Size = new Size(90, 13);
            Label53.TabIndex = 69;
            Label53.Text = "NotificationUUID:";
            Label53.Visible = false;
            // 
            // Label51
            // 
            Label51.AutoSize = true;
            Label51.Font = new Font("Microsoft Sans Serif", 8.75f, FontStyle.Bold);
            Label51.ForeColor = Color.Green;
            Label51.Location = new Point(520, 55);
            Label51.Name = "Label51";
            Label51.Size = new Size(50, 15);
            Label51.TabIndex = 68;
            Label51.Text = "Saved!";
            Label51.Visible = false;
            // 
            // UIEngineLabel
            // 
            UIEngineLabel.AutoSize = true;
            UIEngineLabel.Location = new Point(646, 78);
            UIEngineLabel.Name = "UIEngineLabel";
            UIEngineLabel.Size = new Size(13, 13);
            UIEngineLabel.TabIndex = 67;
            UIEngineLabel.Text = "0";
            UIEngineLabel.Visible = false;
            // 
            // Button7
            // 
            Button7.FlatStyle = FlatStyle.Flat;
            Button7.Location = new Point(576, 52);
            Button7.Name = "Button7";
            Button7.Size = new Size(83, 23);
            Button7.TabIndex = 66;
            Button7.Text = "Save";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Label38
            // 
            Label38.AutoSize = true;
            Label38.Location = new Point(53, 292);
            Label38.Name = "Label38";
            Label38.Size = new Size(432, 13);
            Label38.TabIndex = 65;
            Label38.Text = "Minimize resource usage and CPU utilization by slowing down application runtime e" + "lements";
            // 
            // NoImpactCheckbox
            // 
            NoImpactCheckbox.AutoSize = true;
            NoImpactCheckbox.Font = new Font("Segoe UI Light", 10f);
            NoImpactCheckbox.Location = new Point(35, 269);
            NoImpactCheckbox.Name = "NoImpactCheckbox";
            NoImpactCheckbox.Size = new Size(288, 23);
            NoImpactCheckbox.TabIndex = 64;
            NoImpactCheckbox.Text = "Minimize performance impact when gaming";
            NoImpactCheckbox.UseVisualStyleBackColor = true;
            // 
            // Label29
            // 
            Label29.AutoSize = true;
            Label29.Location = new Point(53, 329);
            Label29.Name = "Label29";
            Label29.Size = new Size(556, 13);
            Label29.TabIndex = 63;
            Label29.Text = "View and use Experimental Features. Not recommended and in-active-development. Bu" + "t includes some exciting stuff!";
            // 
            // Label28
            // 
            Label28.AutoSize = true;
            Label28.Location = new Point(56, 252);
            Label28.Name = "Label28";
            Label28.Size = new Size(611, 13);
            Label28.TabIndex = 62;
            Label28.Text = "This can help application to act according to available resources on your PC, how" + "ever  it MAY cause performance loss over time";
            // 
            // Label27
            // 
            Label27.AutoSize = true;
            Label27.Location = new Point(56, 215);
            Label27.Name = "Label27";
            Label27.Size = new Size(488, 13);
            Label27.TabIndex = 61;
            Label27.Text = "Let AutoPowerModeSwitcher and BootManager to optimize your boot-time by starting " + "services delayed";
            // 
            // Label26
            // 
            Label26.AutoSize = true;
            Label26.Location = new Point(51, 173);
            Label26.Name = "Label26";
            Label26.Size = new Size(389, 13);
            Label26.TabIndex = 60;
            Label26.Text = "Start application minimized so you won't get distracted when the application star" + "ts";
            // 
            // Label25
            // 
            Label25.AutoSize = true;
            Label25.Location = new Point(51, 134);
            Label25.Name = "Label25";
            Label25.Size = new Size(571, 13);
            Label25.TabIndex = 59;
            Label25.Text = "This will make application to stay on top of every layer - except ExclusiveTopMos" + "t ones (eg. Task Manager, UWP apps)";
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Location = new Point(51, 96);
            Label24.Name = "Label24";
            Label24.Size = new Size(132, 13);
            Label24.TabIndex = 58;
            Label24.Text = "Reading info text from disk";
            // 
            // UserTrackingCheckbox
            // 
            UserTrackingCheckbox.AutoSize = true;
            UserTrackingCheckbox.Font = new Font("Segoe UI Light", 10f);
            UserTrackingCheckbox.Location = new Point(35, 231);
            UserTrackingCheckbox.Name = "UserTrackingCheckbox";
            UserTrackingCheckbox.Size = new Size(507, 23);
            UserTrackingCheckbox.TabIndex = 57;
            UserTrackingCheckbox.Text = "Track data such as CPU usage, free space of primary disk and system running time";
            UserTrackingCheckbox.UseVisualStyleBackColor = true;
            // 
            // Label21
            // 
            Label21.AutoSize = true;
            Label21.Font = new Font("Microsoft Sans Serif", 8.75f, FontStyle.Bold);
            Label21.ForeColor = Color.Red;
            Label21.Location = new Point(476, 27);
            Label21.Name = "Label21";
            Label21.Size = new Size(65, 15);
            Label21.TabIndex = 56;
            Label21.Text = "Restored";
            Label21.Visible = false;
            // 
            // Button1
            // 
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(546, 23);
            Button1.Name = "Button1";
            Button1.Size = new Size(139, 23);
            Button1.TabIndex = 55;
            Button1.Text = "Restore to default values";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Font = new Font("Segoe UI Light", 10.25f);
            Label17.Location = new Point(35, 48);
            Label17.Name = "Label17";
            Label17.Size = new Size(284, 19);
            Label17.TabIndex = 53;
            Label17.Text = "Customize application settings to get most of it";
            // 
            // EnableBootManagerCheck
            // 
            EnableBootManagerCheck.AutoSize = true;
            EnableBootManagerCheck.Font = new Font("Segoe UI Light", 10f);
            EnableBootManagerCheck.Location = new Point(35, 195);
            EnableBootManagerCheck.Name = "EnableBootManagerCheck";
            EnableBootManagerCheck.Size = new Size(388, 23);
            EnableBootManagerCheck.TabIndex = 53;
            EnableBootManagerCheck.Text = "Enable and use integrated BootManager on Windows Startup";
            EnableBootManagerCheck.UseVisualStyleBackColor = true;
            // 
            // EnableExperimentalFeatuesCheckBox
            // 
            EnableExperimentalFeatuesCheckBox.AccessibleName = "";
            EnableExperimentalFeatuesCheckBox.AutoSize = true;
            EnableExperimentalFeatuesCheckBox.Font = new Font("Segoe UI Light", 10f);
            EnableExperimentalFeatuesCheckBox.Location = new Point(35, 308);
            EnableExperimentalFeatuesCheckBox.Name = "EnableExperimentalFeatuesCheckBox";
            EnableExperimentalFeatuesCheckBox.Size = new Size(354, 23);
            EnableExperimentalFeatuesCheckBox.TabIndex = 52;
            EnableExperimentalFeatuesCheckBox.Text = "Enable Experimental Features and Verbose Informations";
            EnableExperimentalFeatuesCheckBox.UseVisualStyleBackColor = true;
            // 
            // LinkLabel3
            // 
            LinkLabel3.AutoSize = true;
            LinkLabel3.Location = new Point(64, 349);
            LinkLabel3.Name = "LinkLabel3";
            LinkLabel3.Size = new Size(200, 13);
            LinkLabel3.TabIndex = 51;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "Show Test Controls (Debugger Interface)";
            LinkLabel3.Visible = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(34, 23);
            Label5.Name = "Label5";
            Label5.Size = new Size(170, 25);
            Label5.TabIndex = 49;
            Label5.Text = "Application Settings";
            // 
            // StartMinimized
            // 
            StartMinimized.AutoSize = true;
            StartMinimized.Font = new Font("Segoe UI Light", 10f);
            StartMinimized.Location = new Point(35, 153);
            StartMinimized.Name = "StartMinimized";
            StartMinimized.Size = new Size(189, 23);
            StartMinimized.TabIndex = 48;
            StartMinimized.Text = "Start application minimized";
            StartMinimized.UseVisualStyleBackColor = true;
            // 
            // TopMostCheckbox
            // 
            TopMostCheckbox.AutoSize = true;
            TopMostCheckbox.Font = new Font("Segoe UI Light", 10f);
            TopMostCheckbox.Location = new Point(35, 114);
            TopMostCheckbox.Name = "TopMostCheckbox";
            TopMostCheckbox.Size = new Size(356, 23);
            TopMostCheckbox.TabIndex = 47;
            TopMostCheckbox.Text = "Keep this application always on top of other applications";
            TopMostCheckbox.UseVisualStyleBackColor = true;
            // 
            // StartonBoot
            // 
            StartonBoot.AutoCheck = false;
            StartonBoot.AutoSize = true;
            StartonBoot.Checked = true;
            StartonBoot.CheckState = CheckState.Checked;
            StartonBoot.Font = new Font("Segoe UI Light", 10f);
            StartonBoot.Location = new Point(35, 74);
            StartonBoot.Name = "StartonBoot";
            StartonBoot.Size = new Size(208, 23);
            StartonBoot.TabIndex = 46;
            StartonBoot.Text = "Start application with Windows";
            StartonBoot.UseVisualStyleBackColor = true;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(HideLegacySettingsPanel1);
            TabPage1.Controls.Add(Label50);
            TabPage1.Controls.Add(isAlreadyRunningLabel);
            TabPage1.Controls.Add(Label49);
            TabPage1.Controls.Add(memory);
            TabPage1.Controls.Add(Label48);
            TabPage1.Controls.Add(Label47);
            TabPage1.Controls.Add(SimulateProcessRunningCheckbox);
            TabPage1.Controls.Add(Label9);
            TabPage1.Controls.Add(Label16);
            TabPage1.Controls.Add(Panel1);
            TabPage1.Controls.Add(Panel4);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(691, 384);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "CryptedEngine Tweaking";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // HideLegacySettingsPanel1
            // 
            HideLegacySettingsPanel1.Controls.Add(Label64);
            HideLegacySettingsPanel1.Controls.Add(Label58);
            HideLegacySettingsPanel1.Controls.Add(Button14);
            HideLegacySettingsPanel1.Controls.Add(Label63);
            HideLegacySettingsPanel1.Controls.Add(Label62);
            HideLegacySettingsPanel1.Controls.Add(Label61);
            HideLegacySettingsPanel1.Location = new Point(4, 9);
            HideLegacySettingsPanel1.Name = "HideLegacySettingsPanel1";
            HideLegacySettingsPanel1.Size = new Size(684, 378);
            HideLegacySettingsPanel1.TabIndex = 67;
            // 
            // Label64
            // 
            Label64.AutoSize = true;
            Label64.Font = new Font("Segoe UI Light", 12.25f);
            Label64.Location = new Point(91, 234);
            Label64.Name = "Label64";
            Label64.Size = new Size(546, 23);
            Label64.TabIndex = 62;
            Label64.Text = "If you encounter any problems, just enter safemode and reset application.";
            // 
            // Label58
            // 
            Label58.AutoSize = true;
            Label58.Font = new Font("Segoe UI Light", 12.25f);
            Label58.Location = new Point(33, 211);
            Label58.Name = "Label58";
            Label58.Size = new Size(642, 23);
            Label58.TabIndex = 61;
            Label58.Text = "However, some stuff may still work but are untested and will probably create prob" + "lems.";
            // 
            // Button14
            // 
            Button14.FlatStyle = FlatStyle.Flat;
            Button14.ForeColor = Color.Red;
            Button14.Location = new Point(140, 304);
            Button14.Name = "Button14";
            Button14.Size = new Size(398, 43);
            Button14.TabIndex = 60;
            Button14.Text = "I understand the risks, continue.";
            Button14.UseVisualStyleBackColor = true;
            // 
            // Label63
            // 
            Label63.AutoSize = true;
            Label63.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label63.ForeColor = Color.Red;
            Label63.Location = new Point(99, 119);
            Label63.Name = "Label63";
            Label63.Size = new Size(521, 31);
            Label63.TabIndex = 59;
            Label63.Text = "This menu has been officially removed.";
            // 
            // Label62
            // 
            Label62.AutoSize = true;
            Label62.Font = new Font("Segoe UI Light", 15.25f);
            Label62.Location = new Point(100, 181);
            Label62.Name = "Label62";
            Label62.Size = new Size(502, 30);
            Label62.TabIndex = 0;
            Label62.Text = "CryptedEngine has updated and is no longer tweakable";
            // 
            // Label61
            // 
            Label61.AutoSize = true;
            Label61.Font = new Font("Segoe UI Light", 15.25f);
            Label61.Location = new Point(66, 150);
            Label61.Name = "Label61";
            Label61.Size = new Size(561, 30);
            Label61.TabIndex = 0;
            Label61.Text = "This tab page used to control the deprecated CryptedEngine. " + '\r' + '\n';
            // 
            // Label50
            // 
            Label50.AutoSize = true;
            Label50.Location = new Point(483, 365);
            Label50.Name = "Label50";
            Label50.Size = new Size(141, 13);
            Label50.TabIndex = 66;
            Label50.Text = "Process Name: notepad.exe";
            Label50.Visible = false;
            // 
            // isAlreadyRunningLabel
            // 
            isAlreadyRunningLabel.AutoSize = true;
            isAlreadyRunningLabel.Location = new Point(550, 271);
            isAlreadyRunningLabel.Name = "isAlreadyRunningLabel";
            isAlreadyRunningLabel.Size = new Size(43, 13);
            isAlreadyRunningLabel.TabIndex = 65;
            isAlreadyRunningLabel.Text = "getdata";
            isAlreadyRunningLabel.Visible = false;
            // 
            // Label49
            // 
            Label49.AutoSize = true;
            Label49.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label49.ForeColor = Color.Red;
            Label49.Location = new Point(466, 349);
            Label49.Name = "Label49";
            Label49.Size = new Size(188, 15);
            Label49.TabIndex = 64;
            Label49.Text = "SIMULATION IN PROGRESS";
            Label49.Visible = false;
            // 
            // memory
            // 
            memory.AutoSize = true;
            memory.Location = new Point(483, 271);
            memory.Name = "memory";
            memory.Size = new Size(42, 13);
            memory.TabIndex = 63;
            memory.Text = "lastitem";
            memory.Visible = false;
            // 
            // Label48
            // 
            Label48.AutoSize = true;
            Label48.Location = new Point(458, 313);
            Label48.Name = "Label48";
            Label48.Size = new Size(191, 13);
            Label48.TabIndex = 61;
            Label48.Text = "PRETEND as target process is running";
            // 
            // Label47
            // 
            Label47.AutoSize = true;
            Label47.Font = new Font("Segoe UI Light", 15f);
            Label47.Location = new Point(464, 284);
            Label47.Name = "Label47";
            Label47.Size = new Size(197, 28);
            Label47.TabIndex = 61;
            Label47.Text = "Debug CryptedEngine";
            // 
            // SimulateProcessRunningCheckbox
            // 
            SimulateProcessRunningCheckbox.AutoSize = true;
            SimulateProcessRunningCheckbox.Location = new Point(528, 332);
            SimulateProcessRunningCheckbox.Name = "SimulateProcessRunningCheckbox";
            SimulateProcessRunningCheckbox.Size = new Size(65, 17);
            SimulateProcessRunningCheckbox.TabIndex = 62;
            SimulateProcessRunningCheckbox.Text = "Enabled";
            SimulateProcessRunningCheckbox.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.Location = new Point(34, 23);
            Label9.Name = "Label9";
            Label9.Size = new Size(193, 25);
            Label9.TabIndex = 50;
            Label9.Text = "CryptedEngine Tweaks";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Font = new Font("Segoe UI Light", 10.25f);
            Label16.Location = new Point(35, 48);
            Label16.Name = "Label16";
            Label16.Size = new Size(363, 19);
            Label16.TabIndex = 53;
            Label16.Text = "Change the way how the CryptedEngine processes your data";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(Panel2);
            Panel1.Controls.Add(Label8);
            Panel1.Controls.Add(LinkLabel2);
            Panel1.Controls.Add(EngineMode1);
            Panel1.Controls.Add(LinkLabel1);
            Panel1.Controls.Add(EngineMode2);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(Label6);
            Panel1.Location = new Point(4, 67);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(687, 193);
            Panel1.TabIndex = 51;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(memory3);
            Panel2.Controls.Add(IntervalWarning);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(Interval2);
            Panel2.Controls.Add(Interval1);
            Panel2.Location = new Point(369, 12);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(299, 89);
            Panel2.TabIndex = 52;
            // 
            // memory3
            // 
            memory3.AutoSize = true;
            memory3.Location = new Point(251, 0);
            memory3.Name = "memory3";
            memory3.Size = new Size(13, 13);
            memory3.TabIndex = 52;
            memory3.Text = "0";
            // 
            // IntervalWarning
            // 
            IntervalWarning.AutoSize = true;
            IntervalWarning.Location = new Point(59, 64);
            IntervalWarning.Name = "IntervalWarning";
            IntervalWarning.Size = new Size(175, 13);
            IntervalWarning.TabIndex = 51;
            IntervalWarning.Text = "Frequent checks are recommended" + '\r' + '\n';
            IntervalWarning.Visible = false;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Light", 15f);
            Label4.Location = new Point(57, 7);
            Label4.Name = "Label4";
            Label4.Size = new Size(201, 28);
            Label4.TabIndex = 12;
            Label4.Text = "Engine Check Intervals";
            // 
            // Interval2
            // 
            Interval2.AutoSize = true;
            Interval2.Font = new Font("Segoe UI Light", 10f);
            Interval2.Location = new Point(165, 38);
            Interval2.Name = "Interval2";
            Interval2.Size = new Size(106, 23);
            Interval2.TabIndex = 13;
            Interval2.Text = "Less Frequent";
            Interval2.UseVisualStyleBackColor = true;
            // 
            // Interval1
            // 
            Interval1.AutoSize = true;
            Interval1.Checked = true;
            Interval1.Font = new Font("Segoe UI Light", 10f);
            Interval1.Location = new Point(15, 38);
            Interval1.Name = "Interval1";
            Interval1.Size = new Size(79, 23);
            Interval1.TabIndex = 11;
            Interval1.TabStop = true;
            Interval1.Text = "Frequent";
            Interval1.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI Light", 15f);
            Label8.Location = new Point(102, 12);
            Label8.Name = "Label8";
            Label8.Size = new Size(168, 28);
            Label8.TabIndex = 14;
            Label8.Text = "Core Engine Mode";
            // 
            // LinkLabel2
            // 
            LinkLabel2.AutoSize = true;
            LinkLabel2.Location = new Point(229, 162);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(74, 13);
            LinkLabel2.TabIndex = 21;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "How it works?";
            // 
            // EngineMode1
            // 
            EngineMode1.AutoSize = true;
            EngineMode1.Font = new Font("Segoe UI Light", 10f);
            EngineMode1.Location = new Point(23, 43);
            EngineMode1.Name = "EngineMode1";
            EngineMode1.Size = new Size(151, 23);
            EngineMode1.TabIndex = 15;
            EngineMode1.Text = "Performance focused";
            EngineMode1.UseVisualStyleBackColor = true;
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(19, 161);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(74, 13);
            LinkLabel1.TabIndex = 20;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "How it works?";
            // 
            // EngineMode2
            // 
            EngineMode2.AutoSize = true;
            EngineMode2.Checked = true;
            EngineMode2.Font = new Font("Segoe UI Light", 10f);
            EngineMode2.Location = new Point(233, 43);
            EngineMode2.Name = "EngineMode2";
            EngineMode2.Size = new Size(89, 23);
            EngineMode2.TabIndex = 14;
            EngineMode2.TabStop = true;
            EngineMode2.Text = "Optimized";
            EngineMode2.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(229, 69);
            Label7.Name = "Label7";
            Label7.Size = new Size(215, 78);
            Label7.TabIndex = 19;
            Label7.Text = "More bugs" + '\r' + '\n' + "Less responsive UI" + '\r' + '\n' + "Slower detection" + '\r' + '\n' + "May save battery" + '\r' + '\n' + "Less likely to" + " cause CPU overheat over time" + '\r' + '\n' + "Runs fluently on every machine";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(20, 69);
            Label6.Name = "Label6";
            Label6.Size = new Size(175, 91);
            Label6.TabIndex = 18;
            Label6.Text = "Less bugs" + '\r' + '\n' + "More responsive UI" + '\r' + '\n' + "Faster detection" + '\r' + '\n' + "May consume more battery" + '\r' + '\n' + "May ca" + "use CPU overheat over time" + '\r' + '\n' + "May cause performance overhead" + '\r' + '\n' + "on old machines" + '\r' + '\n';
            // 
            // Panel4
            // 
            Panel4.Controls.Add(ShowWarn);
            Panel4.Controls.Add(Label20);
            Panel4.Controls.Add(LowFreqGUID);
            Panel4.Controls.Add(LinkLabel4);
            Panel4.Controls.Add(Label12);
            Panel4.Controls.Add(WarnLabel);
            Panel4.Location = new Point(54, 266);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(353, 112);
            Panel4.TabIndex = 61;
            // 
            // ShowWarn
            // 
            ShowWarn.AutoSize = true;
            ShowWarn.Location = new Point(242, 19);
            ShowWarn.Name = "ShowWarn";
            ShowWarn.Size = new Size(13, 13);
            ShowWarn.TabIndex = 60;
            ShowWarn.Text = "1";
            ShowWarn.Visible = false;
            // 
            // Label20
            // 
            Label20.AutoSize = true;
            Label20.Font = new Font("Segoe UI Light", 15f);
            Label20.Location = new Point(33, 19);
            Label20.Name = "Label20";
            Label20.Size = new Size(215, 28);
            Label20.TabIndex = 52;
            Label20.Text = "Manually Override GUID";
            // 
            // LowFreqGUID
            // 
            LowFreqGUID.Location = new Point(23, 63);
            LowFreqGUID.Name = "LowFreqGUID";
            LowFreqGUID.Size = new Size(225, 20);
            LowFreqGUID.TabIndex = 56;
            LowFreqGUID.Text = "ca366f9a-4ace-4337-b948-5b196e337c7d";
            // 
            // LinkLabel4
            // 
            LinkLabel4.AutoSize = true;
            LinkLabel4.Location = new Point(250, 66);
            LinkLabel4.Name = "LinkLabel4";
            LinkLabel4.Size = new Size(73, 13);
            LinkLabel4.TabIndex = 59;
            LinkLabel4.TabStop = true;
            LinkLabel4.Text = "RESET GUID";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(5, 47);
            Label12.Name = "Label12";
            Label12.Size = new Size(276, 13);
            Label12.TabIndex = 57;
            Label12.Text = "If required please enter your \"LowFreq Mode\" GUID here";
            // 
            // WarnLabel
            // 
            WarnLabel.AutoSize = true;
            WarnLabel.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarnLabel.ForeColor = Color.Red;
            WarnLabel.Location = new Point(76, 86);
            WarnLabel.Name = "WarnLabel";
            WarnLabel.Size = new Size(135, 15);
            WarnLabel.TabIndex = 58;
            WarnLabel.Text = "Invalid GUID (UUID)";
            WarnLabel.Visible = false;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(PrivacyStatementPanel);
            TabPage2.Controls.Add(Panel6);
            TabPage2.Controls.Add(Label42);
            TabPage2.Controls.Add(Label41);
            TabPage2.Controls.Add(Label15);
            TabPage2.Controls.Add(Label10);
            TabPage2.Controls.Add(Label3);
            TabPage2.Controls.Add(GroupBox1);
            TabPage2.Controls.Add(GroupBox2);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(691, 384);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "AutoPilot Mode";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // PrivacyStatementPanel
            // 
            PrivacyStatementPanel.Controls.Add(Label31);
            PrivacyStatementPanel.Controls.Add(Label32);
            PrivacyStatementPanel.Location = new Point(622, 132);
            PrivacyStatementPanel.Name = "PrivacyStatementPanel";
            PrivacyStatementPanel.Size = new Size(676, 207);
            PrivacyStatementPanel.TabIndex = 58;
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.Location = new Point(0, 26);
            Label31.Name = "Label31";
            Label31.Size = new Size(669, 52);
            Label31.TabIndex = 55;
            Label31.Text = resources.GetString("Label31.Text");
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.Location = new Point(238, 15);
            Label32.Name = "Label32";
            Label32.Size = new Size(209, 13);
            Label32.TabIndex = 56;
            Label32.Text = "PRIVACY STATEMENT of AutoPilot Mode";
            // 
            // Panel6
            // 
            Panel6.Controls.Add(Button12);
            Panel6.Controls.Add(Button10);
            Panel6.Location = new Point(7, 189);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(408, 182);
            Panel6.TabIndex = 59;
            // 
            // Button12
            // 
            Button12.FlatStyle = FlatStyle.Flat;
            Button12.Location = new Point(197, 12);
            Button12.Name = "Button12";
            Button12.Size = new Size(180, 41);
            Button12.TabIndex = 0;
            Button12.Text = "Show us how to optimize your PC";
            Button12.UseVisualStyleBackColor = true;
            // 
            // Button10
            // 
            Button10.FlatStyle = FlatStyle.Flat;
            Button10.Location = new Point(11, 12);
            Button10.Name = "Button10";
            Button10.Size = new Size(180, 41);
            Button10.TabIndex = 0;
            Button10.Text = "Choose what should we detect";
            Button10.UseVisualStyleBackColor = true;
            // 
            // Label42
            // 
            Label42.AutoSize = true;
            Label42.Location = new Point(109, 359);
            Label42.Name = "Label42";
            Label42.Size = new Size(81, 13);
            Label42.TabIndex = 58;
            Label42.Text = "TimesChecked:";
            // 
            // Label41
            // 
            Label41.AutoSize = true;
            Label41.Location = new Point(192, 359);
            Label41.Name = "Label41";
            Label41.Size = new Size(13, 13);
            Label41.TabIndex = 57;
            Label41.Text = "0";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Font = new Font("Segoe UI Light", 10.25f);
            Label15.Location = new Point(35, 48);
            Label15.Name = "Label15";
            Label15.Size = new Size(526, 19);
            Label15.TabIndex = 52;
            Label15.Text = "Keep this enabled and forget about APMS as it will take over everything for your " + "confort";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Segoe UI Light", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.Location = new Point(34, 23);
            Label10.Name = "Label10";
            Label10.Size = new Size(139, 25);
            Label10.TabIndex = 51;
            Label10.Text = "AutoPilot Mode";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(15, 174);
            Label3.Name = "Label3";
            Label3.Size = new Size(400, 16);
            Label3.TabIndex = 8;
            Label3.Text = "Tweak AutoPilot's engine by choosing which games to auto-detect";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label56);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Userdetect);
            GroupBox1.Controls.Add(UserNOdetect);
            GroupBox1.Location = new Point(18, 87);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(366, 84);
            GroupBox1.TabIndex = 6;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "MASTER SWITCH";
            // 
            // Label56
            // 
            Label56.AutoSize = true;
            Label56.Location = new Point(285, 15);
            Label56.Name = "Label56";
            Label56.Size = new Size(13, 13);
            Label56.TabIndex = 3;
            Label56.Text = "0";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(6, 16);
            Label2.Name = "Label2";
            Label2.Size = new Size(231, 13);
            Label2.TabIndex = 2;
            Label2.Text = "Should we set everything automatically for you?";
            // 
            // Userdetect
            // 
            Userdetect.AutoSize = true;
            Userdetect.Location = new Point(11, 32);
            Userdetect.Name = "Userdetect";
            Userdetect.Size = new Size(346, 17);
            Userdetect.TabIndex = 1;
            Userdetect.TabStop = true;
            Userdetect.Text = "Yes please, turn on AutoPilot and detect my games (Recommended)";
            Userdetect.UseVisualStyleBackColor = true;
            // 
            // UserNOdetect
            // 
            UserNOdetect.AutoSize = true;
            UserNOdetect.Location = new Point(11, 55);
            UserNOdetect.Name = "UserNOdetect";
            UserNOdetect.Size = new Size(311, 17);
            UserNOdetect.TabIndex = 0;
            UserNOdetect.TabStop = true;
            UserNOdetect.Text = "Nope, DO NOT enable AutoPilot. I'll check everything myself";
            UserNOdetect.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Label19);
            GroupBox2.Controls.Add(CheckBox12);
            GroupBox2.Controls.Add(CheckBox11);
            GroupBox2.Controls.Add(Label1);
            GroupBox2.Controls.Add(CheckBox2);
            GroupBox2.Controls.Add(CheckBox5);
            GroupBox2.Controls.Add(CheckBox1);
            GroupBox2.Controls.Add(CheckBox3);
            GroupBox2.Location = new Point(18, 189);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(354, 150);
            GroupBox2.TabIndex = 7;
            GroupBox2.TabStop = false;
            GroupBox2.Visible = false;
            // 
            // Label19
            // 
            Label19.AutoSize = true;
            Label19.Location = new Point(59, 136);
            Label19.Name = "Label19";
            Label19.Size = new Size(214, 13);
            Label19.TabIndex = 6;
            Label19.Text = "NOTE: These settings are not saved on exit";
            // 
            // CheckBox12
            // 
            CheckBox12.AutoSize = true;
            CheckBox12.Checked = true;
            CheckBox12.CheckState = CheckState.Checked;
            CheckBox12.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox12.Location = new Point(162, 116);
            CheckBox12.Name = "CheckBox12";
            CheckBox12.Size = new Size(191, 25);
            CheckBox12.TabIndex = 7;
            CheckBox12.Text = "Grand Theft Auto IV: CE";
            CheckBox12.UseVisualStyleBackColor = true;
            // 
            // CheckBox11
            // 
            CheckBox11.AutoSize = true;
            CheckBox11.Checked = true;
            CheckBox11.CheckState = CheckState.Checked;
            CheckBox11.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox11.Location = new Point(12, 114);
            CheckBox11.Name = "CheckBox11";
            CheckBox11.Size = new Size(111, 25);
            CheckBox11.TabIndex = 6;
            CheckBox11.Text = "Battlefield 4";
            CheckBox11.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(6, 11);
            Label1.Name = "Label1";
            Label1.Size = new Size(335, 52);
            Label1.TabIndex = 5;
            Label1.Text = resources.GetString("Label1.Text");
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Checked = true;
            CheckBox2.CheckState = CheckState.Checked;
            CheckBox2.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox2.Location = new Point(162, 63);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(162, 25);
            CheckBox2.TabIndex = 1;
            CheckBox2.Text = "Grand Theft Auto V";
            CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox5
            // 
            CheckBox5.AutoSize = true;
            CheckBox5.Checked = true;
            CheckBox5.CheckState = CheckState.Checked;
            CheckBox5.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox5.Location = new Point(162, 88);
            CheckBox5.Name = "CheckBox5";
            CheckBox5.Size = new Size(91, 25);
            CheckBox5.TabIndex = 4;
            CheckBox5.Text = "Far Cry 3";
            CheckBox5.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = CheckState.Checked;
            CheckBox1.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox1.Location = new Point(12, 63);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(88, 25);
            CheckBox1.TabIndex = 0;
            CheckBox1.Text = "Fallout 4";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBox3
            // 
            CheckBox3.AutoSize = true;
            CheckBox3.Checked = true;
            CheckBox3.CheckState = CheckState.Checked;
            CheckBox3.Font = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBox3.Location = new Point(12, 87);
            CheckBox3.Name = "CheckBox3";
            CheckBox3.Size = new Size(111, 25);
            CheckBox3.TabIndex = 2;
            CheckBox3.Text = "Battlefield 3";
            CheckBox3.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage7);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Controls.Add(TabPage4);
            TabControl1.Controls.Add(TabPage5);
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Location = new Point(4, 5);
            TabControl1.Multiline = true;
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(699, 410);
            TabControl1.TabIndex = 9;
            // 
            // UserPreferencesModule
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 426);
            Controls.Add(UninstallPanel);
            Controls.Add(TabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserPreferencesModule";
            Opacity = 0.02d;
            Text = "AutoPowerModeSwitcher Settings";
            TabPage7.ResumeLayout(false);
            TabPage7.PerformLayout();
            Panel10.ResumeLayout(false);
            Panel10.PerformLayout();
            Panel7.ResumeLayout(false);
            Panel7.PerformLayout();
            HideGameDetectionPanel.ResumeLayout(false);
            HideGameDetectionPanel.PerformLayout();
            CheckingSpeedPanel.ResumeLayout(false);
            CheckingSpeedPanel.PerformLayout();
            TabPage5.ResumeLayout(false);
            TabPage5.PerformLayout();
            Panel5.ResumeLayout(false);
            Panel5.PerformLayout();
            TabPage4.ResumeLayout(false);
            TabPage4.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            HideLegacySettingsPanel1.ResumeLayout(false);
            HideLegacySettingsPanel1.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            PrivacyStatementPanel.ResumeLayout(false);
            PrivacyStatementPanel.PerformLayout();
            Panel6.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            TabControl1.ResumeLayout(false);
            Load += new EventHandler(GameChooser_Load);
            FormClosing += new FormClosingEventHandler(UserPreferencesModule_FormClosing);
            VisibleChanged += new EventHandler(UserPreferencesModule_VisibleChanged);
            ResumeLayout(false);

        }
        internal Timer DetectionEngine;
        internal Timer UIEngine;
        internal Panel UninstallPanel;
        internal Timer ProcessingAnimator;
        internal Timer CheckboxDisabler;
        internal TabPage TabPage7;
        internal TabPage TabPage5;
        internal Label Label46;
        internal Button UninstallCancelButton;
        internal Label Label43;
        internal Label Label11;
        internal Label Label44;
        internal Panel Panel5;
        internal Label Label37;
        internal Button Button3;
        internal CheckBox CheckBox10;
        internal CheckBox CheckBox9;
        internal CheckBox CheckBox8;
        internal Button Button2;
        internal TabPage TabPage4;
        internal Panel Panel9;
        internal Panel Panel8;
        internal Label Label55;
        internal Panel Panel3;
        internal Label Label45;
        internal CheckBox CheckBox6;
        internal Label Label34;
        internal LinkLabel LinkLabel5;
        internal Label Label23;
        internal Label Label22;
        internal CheckBox PrioritizeTargetProcessCheckBox;
        internal Label Label33;
        internal Label Label18;
        internal Label Label14;
        internal Label Label13;
        internal CheckBox RestartAfterSessionCheckBox;
        internal CheckBox KillProcessesCheckBox;
        internal CheckBox GameBoosterEnabled;
        internal TabPage TabPage3;
        internal Label Label54;
        internal CheckBox UserTrackingHighSpeedCheckbox;
        internal Label memory4;
        internal Label memory2;
        internal Label OverrideWarningLabel;
        internal Label Label53;
        internal Label Label51;
        internal Label UIEngineLabel;
        internal Button Button7;
        internal Label Label38;
        internal CheckBox NoImpactCheckbox;
        internal Label Label29;
        internal Label Label28;
        internal Label Label27;
        internal Label Label26;
        internal Label Label25;
        internal Label Label24;
        internal CheckBox UserTrackingCheckbox;
        internal Label Label21;
        internal Button Button1;
        internal Label Label17;
        internal CheckBox EnableBootManagerCheck;
        internal CheckBox EnableExperimentalFeatuesCheckBox;
        internal LinkLabel LinkLabel3;
        internal Label Label5;
        internal CheckBox StartMinimized;
        internal CheckBox TopMostCheckbox;
        internal CheckBox StartonBoot;
        internal TabPage TabPage1;
        internal Panel HideLegacySettingsPanel1;
        internal Label Label63;
        internal Label Label62;
        internal Label Label61;
        internal Label Label50;
        internal Label isAlreadyRunningLabel;
        internal Label Label49;
        internal Label memory;
        internal Label Label48;
        internal Label Label47;
        internal CheckBox SimulateProcessRunningCheckbox;
        internal Label Label9;
        internal Label Label16;
        internal Panel Panel1;
        internal Panel Panel2;
        internal Label memory3;
        internal Label IntervalWarning;
        internal Label Label4;
        internal RadioButton Interval2;
        internal RadioButton Interval1;
        internal Label Label8;
        internal LinkLabel LinkLabel2;
        internal RadioButton EngineMode1;
        internal LinkLabel LinkLabel1;
        internal RadioButton EngineMode2;
        internal Label Label7;
        internal Label Label6;
        internal Panel Panel4;
        internal Label ShowWarn;
        internal Label Label20;
        internal TextBox LowFreqGUID;
        internal LinkLabel LinkLabel4;
        internal Label Label12;
        internal Label WarnLabel;
        internal TabPage TabPage2;
        internal Panel PrivacyStatementPanel;
        internal Label Label32;
        internal Label Label31;
        internal Label Label42;
        internal Label Label41;
        internal Label Label15;
        internal Label Label10;
        internal Label Label3;
        internal GroupBox GroupBox1;
        internal Label Label56;
        internal Label Label2;
        internal RadioButton Userdetect;
        internal RadioButton UserNOdetect;
        internal GroupBox GroupBox2;
        internal Label Label19;
        internal CheckBox CheckBox12;
        internal CheckBox CheckBox11;
        internal Label Label1;
        internal CheckBox CheckBox2;
        internal CheckBox CheckBox5;
        internal CheckBox CheckBox1;
        internal CheckBox CheckBox3;
        internal TabControl TabControl1;
        internal ListBox GameDetectionCollection;
        internal Button Button5;
        internal Button Button4;
        internal Button Button6;
        internal Label Label39;
        internal Panel CheckingSpeedPanel;
        internal Label Label36;
        internal TextBox TextBox1;
        internal Button Button9;
        internal Button Button8;
        internal Panel Panel6;
        internal Button Button10;
        internal Panel HideGameDetectionPanel;
        internal Button Button11;
        internal Label Label35;
        internal Label Label30;
        internal Button Button12;
        internal Button Button13;
        internal Button Button14;
        internal Label Label52;
        internal Label Label40;
        internal Button Button16;
        internal LinkLabel LinkLabel6;
        internal Panel Panel7;
        internal Label Label59;
        internal Label Label60;
        internal Button Button15;
        internal Panel Panel10;
        internal Button Button17;
        internal Label Label57;
        internal Label Label65;
        internal Label Label64;
        internal Label Label58;
    }
}