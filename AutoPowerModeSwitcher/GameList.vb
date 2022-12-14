
Public Class GameList
   Dim w As IO.StreamWriter
    Dim r As IO.StreamReader
    Private sub FuncAddGame
        If UserPreferencesModule.GameDetectionCollection.Items.Contains(TextBox1.text) Then 'if game is already on the list, show a warning.
            MsgBox("This process is already on the tracking list! No need to add it again.", MsgBoxStyle.Exclamation, "Duplicate item!")
        Else 'if game is yet to be added
                UserPreferencesModule.GameDetectionCollection.Items.Add(TextBox1.text) 
       Label2.Text = "Added game '" & TextBox1.Text & "'!"
           Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "User added a game to the list.")
        'save list to local database
            Call WriteDB

        End If
        

    End sub
    Private sub WriteDB 
     Dim i As Integer
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated")
             Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory, UserGenerated Database.")
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\DriverGenerated")
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Created Directory, DriverGenerated Database.")
        w = New IO.StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes")
        For i = 0 To UserPreferencesModule.GameDetectionCollection.Items.Count - 1
            w.WriteLine(UserPreferencesModule.GameDetectionCollection.Items.Item(i))
        Next
        w.Close()
        UserPreferencesModule.detectionengine.Stop
        Threading.Thread.Sleep(200)
        UserPreferencesModule.detectionengine.start
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "Saved listbox items to UserGenerated Database and closed StreamWriter's thread.")
    end sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then 'if textbox is empty return an error
            MsgBox("You can't leave it empty!")

            Elseif TextBox1.Text.Contains(".exe") then 'if textbox contains .exe
    
         TextBox1.Text = TextBox1.Text.Replace(".exe" , "")
           Call  FuncAddGame


           

        else ' normal conditions

            Call FuncAddGame

        End If
       
       
    End Sub

    Private Sub GameList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Label2.Text = ""
        Debug.WriteLine(DateTime.Now.ToString("HH.mm.ss") + ": " + "GameList is intialized.")
       TextBox1.Focus
    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
         If e.KeyCode = Keys.Enter Then
        Button1.PerformClick
    End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
           MsgBox(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\CryptedBytes\AutoPowerModeSwitcher\Database\UserGenerated\GameDetectionIdentifier.cryptedbytes")
    End Sub
End Class