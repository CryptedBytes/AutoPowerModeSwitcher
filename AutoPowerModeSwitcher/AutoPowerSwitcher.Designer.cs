using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AutoPowerSwitcher : Form
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
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            HourTextbox = new TextBox();
            HourTextbox.TextChanged += new EventHandler(HourTextbox_TextChanged);
            MinuteTextbox = new TextBox();
            MinuteTextbox.TextChanged += new EventHandler(MinuteTextbox_TextChanged);
            SecondTextbox = new TextBox();
            SecondTextbox.TextChanged += new EventHandler(SecondTextbox_TextChanged);
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            CalculateValues = new Timer(components);
            CalculateValues.Tick += new EventHandler(CalculateValues_Tick);
            ValueInSecondsLabel = new Label();
            ErrorLabel = new Label();
            RadioButton1 = new RadioButton();
            Label6 = new Label();
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            RadioButton2 = new RadioButton();
            Label7 = new Label();
            Label8 = new Label();
            userLabel = new Label();
            userLabel.Click += new EventHandler(Label9_Click);
            UIEngine = new Timer(components);
            UIEngine.Tick += new EventHandler(UIEngine_Tick);
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(9, 147);
            Button1.Name = "Button1";
            Button1.Size = new Size(176, 28);
            Button1.TabIndex = 0;
            Button1.Text = "Schedule";
            Button1.UseVisualStyleBackColor = true;
            // 
            // HourTextbox
            // 
            HourTextbox.Location = new Point(12, 46);
            HourTextbox.Name = "HourTextbox";
            HourTextbox.Size = new Size(50, 20);
            HourTextbox.TabIndex = 1;
            HourTextbox.Text = "0";
            // 
            // MinuteTextbox
            // 
            MinuteTextbox.Location = new Point(86, 46);
            MinuteTextbox.Name = "MinuteTextbox";
            MinuteTextbox.Size = new Size(50, 20);
            MinuteTextbox.TabIndex = 2;
            MinuteTextbox.Text = "0";
            // 
            // SecondTextbox
            // 
            SecondTextbox.Location = new Point(161, 46);
            SecondTextbox.Name = "SecondTextbox";
            SecondTextbox.Size = new Size(50, 20);
            SecondTextbox.TabIndex = 3;
            SecondTextbox.Text = "0";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial Black", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(68, 44);
            Label1.Name = "Label1";
            Label1.Size = new Size(15, 22);
            Label1.TabIndex = 4;
            Label1.Text = ":";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial Black", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(140, 43);
            Label2.Name = "Label2";
            Label2.Size = new Size(15, 22);
            Label2.TabIndex = 5;
            Label2.Text = ":";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Light", 11.75f);
            Label3.Location = new Point(12, 22);
            Label3.Name = "Label3";
            Label3.Size = new Size(50, 21);
            Label3.TabIndex = 6;
            Label3.Text = "Hours";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Light", 9.75f);
            Label4.Location = new Point(84, 25);
            Label4.Name = "Label4";
            Label4.Size = new Size(52, 17);
            Label4.TabIndex = 7;
            Label4.Text = "Minutes";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Light", 9.75f);
            Label5.Location = new Point(158, 26);
            Label5.Name = "Label5";
            Label5.Size = new Size(53, 17);
            Label5.TabIndex = 8;
            Label5.Text = "Seconds";
            // 
            // CalculateValues
            // 
            CalculateValues.Enabled = true;
            CalculateValues.Interval = 10;
            // 
            // ValueInSecondsLabel
            // 
            ValueInSecondsLabel.AutoSize = true;
            ValueInSecondsLabel.Location = new Point(310, 5);
            ValueInSecondsLabel.Name = "ValueInSecondsLabel";
            ValueInSecondsLabel.Size = new Size(13, 13);
            ValueInSecondsLabel.TabIndex = 9;
            ValueInSecondsLabel.Text = "0";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(69, 178);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(201, 13);
            ErrorLabel.TabIndex = 10;
            ErrorLabel.Text = "An error occured while calculating";
            ErrorLabel.Visible = false;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Checked = true;
            RadioButton1.Location = new Point(16, 100);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(73, 17);
            RadioButton1.TabIndex = 11;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Shutdown";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 10.25f, FontStyle.Bold);
            Label6.ForeColor = Color.ForestGreen;
            Label6.Location = new Point(125, 178);
            Label6.Name = "Label6";
            Label6.Size = new Size(88, 17);
            Label6.TabIndex = 12;
            Label6.Text = "Scheduled!";
            Label6.Visible = false;
            // 
            // Button2
            // 
            Button2.Enabled = false;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Location = new Point(191, 147);
            Button2.Name = "Button2";
            Button2.Size = new Size(176, 28);
            Button2.TabIndex = 13;
            Button2.Text = "CANCEL";
            Button2.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(95, 100);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(71, 17);
            RadioButton2.TabIndex = 14;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Hibernate";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Light", 9.75f);
            Label7.Location = new Point(13, 5);
            Label7.Name = "Label7";
            Label7.Size = new Size(158, 17);
            Label7.TabIndex = 15;
            Label7.Text = "When should I take action?";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI Light", 9.75f);
            Label8.Location = new Point(9, 80);
            Label8.Name = "Label8";
            Label8.Size = new Size(108, 17);
            Label8.TabIndex = 16;
            Label8.Text = "What should I do?";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI Light", 9.75f);
            userLabel.Location = new Point(1, 127);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(78, 17);
            userLabel.TabIndex = 17;
            userLabel.Text = "convertables";
            // 
            // UIEngine
            // 
            UIEngine.Enabled = true;
            UIEngine.Interval = 1;
            // 
            // AutoPowerSwitcher
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(381, 206);
            Controls.Add(userLabel);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(RadioButton2);
            Controls.Add(Button2);
            Controls.Add(Label6);
            Controls.Add(RadioButton1);
            Controls.Add(ErrorLabel);
            Controls.Add(ValueInSecondsLabel);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(SecondTextbox);
            Controls.Add(MinuteTextbox);
            Controls.Add(HourTextbox);
            Controls.Add(Button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AutoPowerSwitcher";
            ShowIcon = false;
            Text = "AutoPowerSwitcher";
            Click += new EventHandler(AutoPowerSwitcher_Click);
            Load += new EventHandler(AutoPowerSwitcher_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button Button1;
        internal TextBox HourTextbox;
        internal TextBox MinuteTextbox;
        internal TextBox SecondTextbox;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Timer CalculateValues;
        internal Label ValueInSecondsLabel;
        internal Label ErrorLabel;
        internal RadioButton RadioButton1;
        internal Label Label6;
        internal Button Button2;
        internal RadioButton RadioButton2;
        internal Label Label7;
        internal Label Label8;
        internal Label userLabel;
        internal Timer UIEngine;
    }
}