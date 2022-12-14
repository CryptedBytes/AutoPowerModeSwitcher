using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AutoPowerModeSwitcher
{
    public partial class AutoPowerSwitcher
    {
        public AutoPowerSwitcher()
        {
            InitializeComponent();
        }
        private void renderUserLabel()
        {

            if (userLabel.Text.Contains("0 hours"))
            {
                userLabel.Text = userLabel.Text.Replace("0 hours,", "");
            }

            if (userLabel.Text.Contains("0 minutes"))
            {
                userLabel.Text = userLabel.Text.Replace("0 minutes ", "");
            }


            if (userLabel.Text.Contains("0 seconds"))
            {
                userLabel.Text = userLabel.Text.Replace("and 0 seconds, ", "");
            }

            if (HourTextbox.Text == "1")
            {
                userLabel.Text = userLabel.Text.Replace("1 hours", "A hour");
            }

            if (MinuteTextbox.Text == "1")
            {
                userLabel.Text = userLabel.Text.Replace("1 minutes", "a minute");
            }

            if (SecondTextbox.Text == "1")
            {
                userLabel.Text = userLabel.Text.Replace("1 seconds", "a second");
            }

        }

        private void SecondTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SecondTextbox.Text))
            {
                SecondTextbox.Text = "0";
                Button1.Focus();
                SecondTextbox.Focus();
            }
            else
            {
                CalculateValues.Start();
            }


        }

        private void CalculateValues_Tick(object sender, EventArgs e)
        {
            try
            {
                ValueInSecondsLabel.Text = (Conversions.ToDouble(SecondTextbox.Text) + Conversions.ToDouble(MinuteTextbox.Text) * 60d + Conversions.ToDouble(HourTextbox.Text) * 3600d).ToString();
                if (ValueInSecondsLabel.Text.Contains("E"))
                {
                    ErrorLabel.Visible = true;
                    Button1.Enabled = false;
                }

                // HourTextbox.Text = 0
                // MinuteTextbox.Text = 0
                // SecondTextbox.Text = 0
                else
                {
                    ErrorLabel.Visible = !true;
                    Button1.Enabled = !false;
                }
                CalculateValues.Stop();
            }
            catch (Exception ex)
            {

                HourTextbox.Text = "0";
                MinuteTextbox.Text = "0";
                SecondTextbox.Text = "0";
                Interaction.MsgBox("Only numbers are allowed!!", MsgBoxStyle.Critical, "An error occured.");
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Calculating shutdown timer in seconds");
            CalculateValues.Start();

            System.Threading.Thread.Sleep(170);
            // MsgBox("shutdown -s -t " & ValueInSecondsLabel.Text)
            if (Conversions.ToDouble(ValueInSecondsLabel.Text) == 0d)
            {
                Interaction.MsgBox("You cannot schedule a shutdown equal or lower than a zero value!");
            }
            else
            {
                string a = ValueInSecondsLabel.Text;
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Interaction.Shell("shutdown -s -t " + ValueInSecondsLabel.Text);
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM IS SCHEDULED TO SHUTDOWN IN '" + ValueInSecondsLabel.Text + "' SECONDS.");
                Button2.Enabled = true;

                Label6.Visible = true;

            }


        }

        private void MinuteTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MinuteTextbox.Text))
            {
                MinuteTextbox.Text = "0";
                Button1.Focus();
                MinuteTextbox.Focus();
            }
            else
            {
                CalculateValues.Start();
            }

        }

        private void HourTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(HourTextbox.Text))
            {
                HourTextbox.Text = 0.ToString();
                Button1.Focus();
                HourTextbox.Focus();
            }
            else
            {

                CalculateValues.Start();

            }


        }

        private void AutoPowerSwitcher_Click(object sender, EventArgs e)
        {
            CalculateValues.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Interaction.Shell("shutdown -a");
            System.Threading.Thread.Sleep(200);
            Interaction.Shell("shutdown -a");
            Label6.Visible = false;
            Button2.Enabled = false;
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");

            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "WARNING: SYSTEM SHUTDOWN HAS BEEN CANCELLED");


        }

        private void AutoPowerSwitcher_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "AutoPowerSwitcher is intialized.");
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void UIEngine_Tick(object sender, EventArgs e)
        {
            if (Conversions.ToDouble(HourTextbox.Text) == 0d & Conversions.ToDouble(MinuteTextbox.Text) == 0d & Conversions.ToDouble(SecondTextbox.Text) == 0d)
            {
                userLabel.Visible = false;
            }

            else
            {
                userLabel.Visible = true;

                if (RadioButton1.Checked == true)
                {
                    userLabel.Text = "After " + HourTextbox.Text + " hours, " + MinuteTextbox.Text + " minutes and " + SecondTextbox.Text + " seconds, I will shutdown your PC!";
                    renderUserLabel();
                }

                else
                {
                    userLabel.Text = "After " + HourTextbox.Text + " hours, " + MinuteTextbox.Text + " minutes and " + SecondTextbox.Text + " seconds, I will hibernate your PC!";
                    renderUserLabel();
                }
            }
        }
    }
}