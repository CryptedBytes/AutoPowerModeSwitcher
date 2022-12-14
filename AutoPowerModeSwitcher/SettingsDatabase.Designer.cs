using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class SettingsDatabase : Form
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
            Engine = new Timer(components);
            Engine.Tick += new EventHandler(Engine_Tick);
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            CheckBox1 = new CheckBox();
            CheckBox1.CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(26, 64);
            Label1.Name = "Label1";
            Label1.Size = new Size(87, 15);
            Label1.TabIndex = 0;
            Label1.Text = "GETTING DATA";
            // 
            // Engine
            // 
            Engine.Enabled = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.Location = new Point(26, 79);
            Label2.Name = "Label2";
            Label2.Size = new Size(87, 15);
            Label2.TabIndex = 1;
            Label2.Text = "GETTING DATA";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(26, 139);
            Label3.Name = "Label3";
            Label3.Size = new Size(87, 15);
            Label3.TabIndex = 2;
            Label3.Text = "GETTING DATA";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.Location = new Point(26, 94);
            Label4.Name = "Label4";
            Label4.Size = new Size(87, 15);
            Label4.TabIndex = 2;
            Label4.Text = "GETTING DATA";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.Location = new Point(26, 109);
            Label5.Name = "Label5";
            Label5.Size = new Size(87, 15);
            Label5.TabIndex = 3;
            Label5.Text = "GETTING DATA";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(26, 124);
            Label6.Name = "Label6";
            Label6.Size = new Size(87, 15);
            Label6.TabIndex = 4;
            Label6.Text = "GETTING DATA";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(26, 154);
            Label7.Name = "Label7";
            Label7.Size = new Size(87, 15);
            Label7.TabIndex = 5;
            Label7.Text = "GETTING DATA";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(26, 169);
            Label8.Name = "Label8";
            Label8.Size = new Size(87, 15);
            Label8.TabIndex = 6;
            Label8.Text = "GETTING DATA";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Arial", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.Red;
            Label9.Location = new Point(26, 47);
            Label9.Name = "Label9";
            Label9.Size = new Size(254, 15);
            Label9.TabIndex = 7;
            Label9.Text = "DatabaseName                                Value           ";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Arial", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label10.ForeColor = Color.Black;
            Label10.Location = new Point(4, 9);
            Label10.Name = "Label10";
            Label10.Size = new Size(218, 19);
            Label10.TabIndex = 8;
            Label10.Text = "Settings Database Manager";
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = CheckState.Checked;
            CheckBox1.Location = new Point(8, 246);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(68, 17);
            CheckBox1.TabIndex = 9;
            CheckBox1.Text = "TopMost";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // SettingsDatabase
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(CheckBox1);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsDatabase";
            ShowIcon = false;
            Text = "Settings Database Manager";
            Load += new EventHandler(Form2_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Timer Engine;
        internal Label Label2;
        internal Label Label3;
        internal Label Label4;
        internal Label Label5;
        internal Label Label6;
        internal Label Label7;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal CheckBox CheckBox1;
    }
}