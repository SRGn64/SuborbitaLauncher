Public Class Launcher

    Dim selectedMap As String = "REPLACE"
    Dim preLevelData As Byte()
    Dim postLevelData As Byte()
    Private Sub LaunchGame()

        Dim selectedMapLength As Short = 0 ' Temp value until map is selected
        selectedMapLength = selectedMap.Length + 1 ' And calculate the length of the map name + 1

        If (selectedMap <> "REPLACE") Then ' User picked a map

            Dim savePath As String = "..\..\Saved\SaveGames\0.sav" ' Save file
            Dim saveStream As New IO.FileStream(savePath, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Dim saveBin As New IO.BinaryReader(saveStream) ' Our reader


            Dim preSaveData = saveBin.ReadBytes(1313) ' Grab all the stuff that won't change (Up to 0x521), used to be 0x501 I think

            saveBin.Close() ' Close these so we can start writing to the save
            saveStream.Close()

            If (selectedMap <> "FirstPersonExampleMap") Then

                preLevelData = {&H6, &H0, &H0, &H0, &H4C, &H65, &H76, &H65, &H6C, &H0, &HC,
                &H0, &H0, &H0, &H53, &H74, &H72, &H50, &H72, &H6F, &H70, &H65, &H72, &H74, &H79, &H0,
                &HB, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0} ' This is probably a bad way to do this, but...

                postLevelData = {&H0, &H5, &H0, &H0, &H0, &H4E, &H6F, &H6E, &H65, &H0, &H0, &H0, &H0, &H0} ' More garbage

                My.Computer.FileSystem.WriteAllBytes(savePath, preSaveData, False) ' Write the stuff that won't change
                My.Computer.FileSystem.WriteAllBytes(savePath, preLevelData, True) ' Add the "Level" property stuff
                My.Computer.FileSystem.WriteAllBytes(savePath, BitConverter.GetBytes(selectedMapLength), True) ' Level name length
                My.Computer.FileSystem.WriteAllBytes(savePath, {&H0, &H0}, True) ' Filler
                My.Computer.FileSystem.WriteAllBytes(savePath, System.Text.Encoding.UTF8.GetBytes(selectedMap.ToString), True) ' Map name
                My.Computer.FileSystem.WriteAllBytes(savePath, postLevelData, True) ' Some other stuff needed

            Else
                preLevelData = {&H5, &H0, &H0, &H0, &H4E, &H6F, &H6E, &H65, &H0, &H0, &H0, &H0, &H0} ' Stupid rewrite because the new heli intro breaks things

                My.Computer.FileSystem.WriteAllBytes(savePath, preSaveData, False) ' Write the stuff that won't change
                My.Computer.FileSystem.WriteAllBytes(savePath, preLevelData, True) ' And we're just writing the "None" stuff to stop the heli intro
            End If

            Process.Start(".\Suborbita.exe") ' Start the game...
            Me.Close() ' ...and kill our launcher
        End If
    End Sub

    Private Sub Button_QuickLaunch(sender As Object, e As EventArgs) Handles Button_Level2.Click, Button_Level3.Click, Button_Level4.Click, Button_Level5.Click
        selectedMap = "Level" & sender.ToString.Substring(sender.ToString.Length - 1)
        LaunchGame()
    End Sub

    Private Sub Button_LevelIntro_Click(sender As Object, e As EventArgs) Handles Button_LevelIntro.Click
        selectedMap = "Level0"
        LaunchGame()
    End Sub

    Private Sub Button_Level1_Click(sender As Object, e As EventArgs) Handles Button_Level1.Click
        selectedMap = "FirstPersonExampleMap"
        LaunchGame()
    End Sub
End Class
