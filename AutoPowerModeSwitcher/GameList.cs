using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AutoPowerModeSwitcher
{

    public partial class GameList
    {
        private System.IO.StreamWriter w;
        private System.IO.StreamReader r;

        public GameList()
        {
            InitializeComponent();
        }
        private void FuncAddGame()
        {
            if (My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items.Contains(TextBox1.Text)) // if game is already on the list, show a warning.
            {
                Interaction.MsgBox("This process is already on the tracking list! No need to add it again.", MsgBoxStyle.Exclamation, "Duplicate item!");
            }
            else // if game is yet to be added
            {
                My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items.Add(TextBox1.Text);
                Label2.Text = "Added game '" + TextBox1.Text + "'!";
                Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User added a game to the list.");
                // save list to local database
                WriteDB();

            }


        }
        private void WriteDB()
        {
            int i;
            My.MyProject.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory, UserGenerated Database.");
            My.MyProject.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated");
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory, DriverGenerated Database.");
            w = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes");
            var loopTo = My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items.Count - 1;
            for (i = 0; i <= loopTo; i++)
                w.WriteLine(My.MyProject.Forms.UserPreferencesModule.GameDetectionCollection.Items[i]);
            w.Close();
            My.MyProject.Forms.UserPreferencesModule.DetectionEngine.Stop();
            System.Threading.Thread.Sleep(200);
            My.MyProject.Forms.UserPreferencesModule.DetectionEngine.Start();
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved listbox items to UserGenerated Database and closed StreamWriter's thread.");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text)) // if textbox is empty return an error
            {
                Interaction.MsgBox("You can't leave it empty!");
            }

            else if (TextBox1.Text.Contains(".exe")) // if textbox contains .exe
            {

                TextBox1.Text = TextBox1.Text.Replace(".exe", "");
                FuncAddGame();
            }




            else // normal conditions
            {

                FuncAddGame();

            }


        }

        private void GameList_Load(object sender, EventArgs e)
        {
            Label2.Text = "";
            Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "GameList is intialized.");
            TextBox1.Focus();
        }


        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1.PerformClick();
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interaction.MsgBox(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes");
        }
    }
}