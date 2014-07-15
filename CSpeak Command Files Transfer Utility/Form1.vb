Public Class Form1
    Private Sub SelDirPath_Click(sender As System.Object, e As System.EventArgs) Handles SelDirPath.Click
        DirPathDialog.Description = "Choose the directory containing your episodes."
        If DirPathDialog.ShowDialog = DialogResult.OK Then
            ServerPaths.AppendText(DirPathDialog.SelectedPath & vbNewLine)
        End If
    End Sub

    Private Sub SelCmdFiles_Click(sender As System.Object, e As System.EventArgs) Handles SelCmdFiles.Click
        'Code for selecting path(s) to new command files to be uploaded to the server
        If CmdFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            'When user chooses a file or multiple files they are added to an array
            Dim SelectedCmdFiles As Array
            SelectedCmdFiles = CmdFileDialog.FileNames
            For i = 0 To SelectedCmdFiles.GetUpperBound(0)
                'Add the file paths to the multi-ine textbox in the main form and a return for the next path
                'The extra line at the end will be filtered out later in the main code ran for comparing the files
                CmdFiles.AppendText(SelectedCmdFiles(i) & vbNewLine)
            Next
            'Completed adding all selected file(s) to the multi-line textbox in the main form
        End If
    End Sub

    Private Sub AppNewCmd_Click(sender As System.Object, e As System.EventArgs) Handles AppNewCmd.Click
        'Main code for detecting matched files and copying data
        'Defining variables
        Dim CmdFileList As New List(Of String)
        Dim i As Integer
        'Converting multi-line textbox listing command files generated using CSpeak Command Generator
        CmdFileList.AddRange(CmdFiles.Text.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
        'Looping through each new command file containing data to be copied to the server(s)
        For i = 0 To CmdFileList.Count - 1
            'Looping through each file in the server path(s) looking for a match to the new command filename
            For Each DestinationFile In System.IO.Directory.GetFiles(ServerPaths.Text)
                'When a match is found the process continues
                If System.IO.Path.GetFileName(DestinationFile) = System.IO.Path.GetFileName(CmdFileList(i)) Then
                    MsgBox(System.IO.Path.GetFileName(DestinationFile) & System.IO.Path.GetFileName(CmdFileList(i)) & " Matches!")
                Else
                    'When a match is not found then the next file from the server path(s) are checked
                End If
            Next
            'Looping through each file on the server is complete
        Next
        'Looping through each command filename is complete
    End Sub
End Class
