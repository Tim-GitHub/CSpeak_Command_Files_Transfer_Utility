Public Class Form1
    Private Sub SelDirPath_Click(sender As System.Object, e As System.EventArgs) Handles SelDirPath.Click
        'Code for selecting server path(s)
        DirPathDialog.Description = "Choose the CLINICFOLDERNAME directory"
        If DirPathDialog.ShowDialog = DialogResult.OK Then
            'When user chooses server path(s) they are copied to the multi-line textbox in the main form and a return for the next path
            'The extra line at the end will be filtered out later in the main code ran for comparing the files
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
        Dim ServerPathList As New List(Of String)
        Dim Paths As Integer
        'Converting multi-line textbox listing command files generated using CSpeak Command Generator to list
        CmdFileList.AddRange(CmdFiles.Text.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
        'Converting multi-line textbox listing server paths to list
        ServerPathList.AddRange(ServerPaths.Text.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
        'Looping through each server path
        For Paths = 0 To ServerPathList.Count - 1
            MsgBox("Scanning path: " & ServerPathList(Paths))
            'Looping through each new command file containing data to be copied to the server
            For i = 0 To CmdFileList.Count - 1
                'Looping through each file in the current server path looking for a match to the current new command filename
                For Each DestinationFile In System.IO.Directory.GetFiles(ServerPathList(Paths))
                    'When a match is found the process continues
                    If System.IO.Path.GetFileName(DestinationFile) = System.IO.Path.GetFileName(CmdFileList(i)) Then
                        MsgBox("Match Found: " & System.IO.Path.GetFileName(CmdFileList(i)))
                    Else
                        'When a match is not found then the next file from the server path(s) are checked
                    End If
                Next
                'Looping through each file on the server is complete
            Next
            'Looping through each command filename is complete
        Next
        'Looping through each server path is complete
    End Sub
End Class
