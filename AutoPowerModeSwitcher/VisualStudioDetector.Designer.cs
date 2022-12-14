using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class VisualStudioDetector : Form
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
            Label2 = new Label();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Engine = new Timer(components);
            Engine.Tick += new EventHandler(Engine_Tick);
            Label3 = new Label();
            HideThisFormEngine = new Timer(components);
            HideThisFormEngine.Tick += new EventHandler(HideThisFormEngine_Tick);
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(36, 6);
            Label1.Name = "Label1";
            Label1.Size = new Size(224, 13);
            Label1.TabIndex = 0;
            Label1.Text = "Looks like you are currently developing APMS";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(25, 19);
            Label2.Name = "Label2";
            Label2.Size = new Size(250, 13);
            Label2.TabIndex = 1;
            Label2.Text = "Would you like to shut it down to prevent confilicts?";
            // 
            // Button1
            // 
            Button1.Location = new Point(142, 38);
            Button1.Name = "Button1";
            Button1.Size = new Size(158, 23);
            Button1.TabIndex = 2;
            Button1.Text = "Shut down current instance";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(12, 38);
            Button2.Name = "Button2";
            Button2.Size = new Size(124, 23);
            Button2.TabIndex = 3;
            Button2.Text = "No, keep running";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Engine
            // 
            Engine.Interval = 4000;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(281, 6);
            Label3.Name = "Label3";
            Label3.Size = new Size(13, 13);
            Label3.TabIndex = 4;
            Label3.Text = "0";
            Label3.Visible = false;
            // 
            // HideThisFormEngine
            // 
            HideThisFormEngine.Enabled = true;
            HideThisFormEngine.Interval = 1;
            // 
            // VisualStudioDetector
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 67);
            Controls.Add(Label3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VisualStudioDetector";
            ShowIcon = false;
            Text = "VisualStudioDetector";
            Load += new EventHandler(VisualStudioDetector_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Label Label2;
        internal Button Button1;
        internal Button Button2;
        internal Timer Engine;
        internal Label Label3;
        internal Timer HideThisFormEngine;
    }
}