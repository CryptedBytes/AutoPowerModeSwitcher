using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class GameList : Form
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
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            TextBox1 = new TextBox();
            TextBox1.KeyDown += new KeyEventHandler(TextBox1_KeyDown);
            Label1 = new Label();
            Label2 = new Label();
            LinkLabel1 = new LinkLabel();
            LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(25, 54);
            Button1.Name = "Button1";
            Button1.Size = new Size(353, 37);
            Button1.TabIndex = 4;
            Button1.Text = "Add!";
            Button1.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(12, 28);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(384, 20);
            TextBox1.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(121, 12);
            Label1.Name = "Label1";
            Label1.Size = new Size(165, 13);
            Label1.TabIndex = 3;
            Label1.Text = "Type in the game's process name";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Light", 12f);
            Label2.Location = new Point(120, 94);
            Label2.Name = "Label2";
            Label2.Size = new Size(132, 21);
            Label2.TabIndex = 4;
            Label2.Text = "Game added label";
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(310, 0);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(97, 13);
            LinkLabel1.TabIndex = 5;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Database Location";
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(409, 118);
            Controls.Add(LinkLabel1);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(TextBox1);
            Controls.Add(Button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameList";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Add a game to the detection list!";
            Load += new EventHandler(GameList_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button Button1;
        internal TextBox TextBox1;
        internal Label Label1;
        internal Label Label2;
        internal LinkLabel LinkLabel1;
    }
}