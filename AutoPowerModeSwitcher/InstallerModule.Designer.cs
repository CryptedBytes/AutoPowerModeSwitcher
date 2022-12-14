using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutoPowerModeSwitcher
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class InstallerModule : Form
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
            Installer = new Timer(components);
            Installer.Tick += new EventHandler(Installer_Tick);
            Label2 = new Label();
            Label1 = new Label();
            Label3 = new Label();
            ButtonCancel = new Button();
            ButtonCancel.Click += new EventHandler(ButtonCancel_Click);
            ButtonInstall = new Button();
            ButtonInstall.Click += new EventHandler(ButtonInstall_Click);
            Label4 = new Label();
            StatusLabel = new Label();
            StatusDetail = new Label();
            StatusDetail.TextChanged += new EventHandler(StatusDetail_TextChanged);
            CheckBox1 = new CheckBox();
            InstallDialog = new Panel();
            Label5 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            InstallationCompleteDialog = new Panel();
            Button1 = new Button();
            Button1.Click += new EventHandler(Button1_Click);
            Label8 = new Label();
            Label9 = new Label();
            ErrorDialog = new Panel();
            Button4 = new Button();
            Button4.Click += new EventHandler(Button4_Click);
            Button3 = new Button();
            Button3.Click += new EventHandler(Button3_Click);
            Button2 = new Button();
            Button2.Click += new EventHandler(Button2_Click);
            Label11 = new Label();
            Label10 = new Label();
            Label12 = new Label();
            Panel1 = new Panel();
            LinkLabel3 = new LinkLabel();
            LinkLabel3.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel3_LinkClicked);
            LinkLabel2 = new LinkLabel();
            LinkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel2_LinkClicked);
            LinkLabel1 = new LinkLabel();
            LinkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
            Label14 = new Label();
            Label13 = new Label();
            InstallDialog.SuspendLayout();
            InstallationCompleteDialog.SuspendLayout();
            ErrorDialog.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Installer
            // 
            Installer.Interval = 1000;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Light", 9f, FontStyle.Regular, GraphicsUnit.Point, 162);
            Label2.Location = new Point(195, 64);
            Label2.Name = "Label2";
            Label2.Size = new Size(104, 15);
            Label2.TabIndex = 1;
            Label2.Text = "It will be installed to";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Light", 13.25f);
            Label1.Location = new Point(143, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(187, 25);
            Label1.TabIndex = 0;
            Label1.Text = "You are about to install";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Light", 15.25f);
            Label3.Location = new Point(53, 34);
            Label3.Name = "Label3";
            Label3.Size = new Size(385, 30);
            Label3.TabIndex = 2;
            Label3.Text = "AutoPowerModeSwitcher by CryptedBytes";
            // 
            // ButtonCancel
            // 
            ButtonCancel.DialogResult = DialogResult.Cancel;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Segoe UI Light", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
            ButtonCancel.Location = new Point(13, 123);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(90, 27);
            ButtonCancel.TabIndex = 3;
            ButtonCancel.Text = "CANCEL";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonInstall
            // 
            ButtonInstall.DialogResult = DialogResult.Cancel;
            ButtonInstall.FlatStyle = FlatStyle.Flat;
            ButtonInstall.Font = new Font("Segoe UI Light", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
            ButtonInstall.Location = new Point(400, 123);
            ButtonInstall.Name = "ButtonInstall";
            ButtonInstall.Size = new Size(90, 27);
            ButtonInstall.TabIndex = 4;
            ButtonInstall.Text = "INSTALL";
            ButtonInstall.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe UI Light", 9f, FontStyle.Regular, GraphicsUnit.Point, 162);
            Label4.Location = new Point(92, 99);
            Label4.Name = "Label4";
            Label4.Size = new Size(324, 15);
            Label4.TabIndex = 5;
            Label4.Text = "Click install to continue. No network connection needed to install";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI Light", 15.25f);
            StatusLabel.ForeColor = Color.Red;
            StatusLabel.Location = new Point(193, 119);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(103, 30);
            StatusLabel.TabIndex = 6;
            StatusLabel.Text = "Installing...";
            StatusLabel.Visible = false;
            // 
            // StatusDetail
            // 
            StatusDetail.AutoSize = true;
            StatusDetail.Font = new Font("Segoe UI Light", 9f, FontStyle.Regular, GraphicsUnit.Point, 162);
            StatusDetail.Location = new Point(180, 153);
            StatusDetail.Name = "StatusDetail";
            StatusDetail.Size = new Size(56, 15);
            StatusDetail.TabIndex = 7;
            StatusDetail.Text = "%Status%";
            StatusDetail.Visible = false;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = CheckState.Checked;
            CheckBox1.Location = new Point(400, 153);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(103, 17);
            CheckBox1.TabIndex = 8;
            CheckBox1.Text = "Create shortcuts";
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // InstallDialog
            // 
            InstallDialog.Controls.Add(Label5);
            InstallDialog.Controls.Add(Label7);
            InstallDialog.Controls.Add(Label6);
            InstallDialog.Location = new Point(41, 156);
            InstallDialog.Name = "InstallDialog";
            InstallDialog.Size = new Size(477, 107);
            InstallDialog.TabIndex = 9;
            InstallDialog.Visible = false;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Segoe UI Light", 15.25f);
            Label5.Location = new Point(45, 34);
            Label5.Name = "Label5";
            Label5.Size = new Size(385, 30);
            Label5.TabIndex = 12;
            Label5.Text = "AutoPowerModeSwitcher by CryptedBytes";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Segoe UI Light", 13.25f);
            Label7.Location = new Point(164, 9);
            Label7.Name = "Label7";
            Label7.Size = new Size(119, 25);
            Label7.TabIndex = 10;
            Label7.Text = "Now installing";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Segoe UI Light", 11f);
            Label6.Location = new Point(90, 74);
            Label6.Name = "Label6";
            Label6.Size = new Size(298, 20);
            Label6.TabIndex = 11;
            Label6.Text = "Hold on! It will be ready for you any time soon!";
            // 
            // InstallationCompleteDialog
            // 
            InstallationCompleteDialog.Controls.Add(Button1);
            InstallationCompleteDialog.Controls.Add(Label8);
            InstallationCompleteDialog.Controls.Add(Label9);
            InstallationCompleteDialog.Location = new Point(58, 166);
            InstallationCompleteDialog.Name = "InstallationCompleteDialog";
            InstallationCompleteDialog.Size = new Size(477, 107);
            InstallationCompleteDialog.TabIndex = 13;
            InstallationCompleteDialog.Visible = false;
            // 
            // Button1
            // 
            Button1.DialogResult = DialogResult.Cancel;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Segoe UI Light", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 162);
            Button1.Location = new Point(132, 64);
            Button1.Name = "Button1";
            Button1.Size = new Size(205, 40);
            Button1.TabIndex = 14;
            Button1.Text = "Click here to get started";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Segoe UI Light", 15.25f);
            Label8.Location = new Point(43, 34);
            Label8.Name = "Label8";
            Label8.Size = new Size(385, 30);
            Label8.TabIndex = 15;
            Label8.Text = "AutoPowerModeSwitcher by CryptedBytes";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Segoe UI Light", 13.25f);
            Label9.Location = new Point(146, 9);
            Label9.Name = "Label9";
            Label9.Size = new Size(168, 25);
            Label9.TabIndex = 14;
            Label9.Text = "Successfully installed";
            // 
            // ErrorDialog
            // 
            ErrorDialog.Controls.Add(Button4);
            ErrorDialog.Controls.Add(Button3);
            ErrorDialog.Controls.Add(Button2);
            ErrorDialog.Controls.Add(Label11);
            ErrorDialog.Controls.Add(Label10);
            ErrorDialog.Location = new Point(38, 171);
            ErrorDialog.Name = "ErrorDialog";
            ErrorDialog.Size = new Size(474, 105);
            ErrorDialog.TabIndex = 16;
            ErrorDialog.Visible = false;
            // 
            // Button4
            // 
            Button4.Location = new Point(346, 62);
            Button4.Name = "Button4";
            Button4.Size = new Size(112, 23);
            Button4.TabIndex = 4;
            Button4.Text = "Copy error details";
            Button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            Button3.Location = new Point(216, 62);
            Button3.Name = "Button3";
            Button3.Size = new Size(117, 23);
            Button3.TabIndex = 3;
            Button3.Text = "Show error details";
            Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            Button2.Location = new Point(116, 62);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 2;
            Button2.Text = "Exit";
            Button2.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(131, 34);
            Label11.Name = "Label11";
            Label11.Size = new Size(202, 13);
            Label11.TabIndex = 1;
            Label11.Text = "Please exit application now and retry later";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(120, 16);
            Label10.Name = "Label10";
            Label10.Size = new Size(213, 13);
            Label10.TabIndex = 0;
            Label10.Text = "An error occured during installation process.";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Font = new Font("Segoe UI Light", 9f, FontStyle.Regular, GraphicsUnit.Point, 162);
            Label12.Location = new Point(38, 82);
            Label12.Name = "Label12";
            Label12.Size = new Size(94, 15);
            Label12.TabIndex = 17;
            Label12.Text = "Installation Path:  ";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(LinkLabel3);
            Panel1.Controls.Add(LinkLabel2);
            Panel1.Controls.Add(LinkLabel1);
            Panel1.Controls.Add(Label14);
            Panel1.Controls.Add(Label13);
            Panel1.Location = new Point(496, 7);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(484, 153);
            Panel1.TabIndex = 18;
            // 
            // LinkLabel3
            // 
            LinkLabel3.AutoSize = true;
            LinkLabel3.Location = new Point(338, 95);
            LinkLabel3.Name = "LinkLabel3";
            LinkLabel3.Size = new Size(74, 13);
            LinkLabel3.TabIndex = 4;
            LinkLabel3.TabStop = true;
            LinkLabel3.Text = "Relaunch app";
            // 
            // LinkLabel2
            // 
            LinkLabel2.AutoSize = true;
            LinkLabel2.Location = new Point(120, 95);
            LinkLabel2.Name = "LinkLabel2";
            LinkLabel2.Size = new Size(189, 13);
            LinkLabel2.TabIndex = 3;
            LinkLabel2.TabStop = true;
            LinkLabel2.Text = "I understand the risk, continue anyway";
            // 
            // LinkLabel1
            // 
            LinkLabel1.AutoSize = true;
            LinkLabel1.Location = new Point(46, 95);
            LinkLabel1.Name = "LinkLabel1";
            LinkLabel1.Size = new Size(45, 13);
            LinkLabel1.TabIndex = 2;
            LinkLabel1.TabStop = true;
            LinkLabel1.Text = "Exit app";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(157, 53);
            Label14.Name = "Label14";
            Label14.Size = new Size(98, 13);
            Label14.TabIndex = 1;
            Label14.Text = "Things you can do:";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(43, 22);
            Label13.Name = "Label13";
            Label13.Size = new Size(401, 13);
            Label13.TabIndex = 0;
            Label13.Text = "This installer is no longer supported and may cause serious problems on your syst" + "em";
            // 
            // InstallerModule
            // 
            AcceptButton = ButtonInstall;
            AutoScaleDimensions = new SizeF(6f, 13f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonCancel;
            ClientSize = new Size(502, 173);
            ControlBox = false;
            Controls.Add(Panel1);
            Controls.Add(ErrorDialog);
            Controls.Add(InstallationCompleteDialog);
            Controls.Add(InstallDialog);
            Controls.Add(CheckBox1);
            Controls.Add(StatusDetail);
            Controls.Add(StatusLabel);
            Controls.Add(Label4);
            Controls.Add(ButtonInstall);
            Controls.Add(ButtonCancel);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(Label12);
            Name = "InstallerModule";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Install AutoPowerModeSwicher";
            InstallDialog.ResumeLayout(false);
            InstallDialog.PerformLayout();
            InstallationCompleteDialog.ResumeLayout(false);
            InstallationCompleteDialog.PerformLayout();
            ErrorDialog.ResumeLayout(false);
            ErrorDialog.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(InstallerModule_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Timer Installer;
        internal Label Label2;
        internal Label Label1;
        internal Label Label3;
        internal Button ButtonCancel;
        internal Button ButtonInstall;
        internal Label Label4;
        internal Label StatusLabel;
        internal Label StatusDetail;
        internal CheckBox CheckBox1;
        internal Panel InstallDialog;
        internal Label Label5;
        internal Label Label7;
        internal Label Label6;
        internal Panel InstallationCompleteDialog;
        internal Button Button1;
        internal Label Label8;
        internal Label Label9;
        internal Panel ErrorDialog;
        internal Button Button2;
        internal Label Label11;
        internal Label Label10;
        internal Label Label12;
        internal Button Button3;
        internal Button Button4;
        internal Panel Panel1;
        internal LinkLabel LinkLabel3;
        internal LinkLabel LinkLabel2;
        internal LinkLabel LinkLabel1;
        internal Label Label14;
        internal Label Label13;
    }
}