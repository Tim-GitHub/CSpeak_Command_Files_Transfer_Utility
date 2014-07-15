Public Class Form1
    Private Sub SelDirPath_Click(sender As System.Object, e As System.EventArgs) Handles SelDirPath.Click
        DirPathDialog.Description = "Choose the directory containing your episodes."
        If DirPathDialog.ShowDialog = DialogResult.OK Then
            ServerPaths.AppendText(DirPathDialog.SelectedPath & vbNewLine)
        End If
    End Sub

    Private Sub SelCmdFiles_Click(sender As System.Object, e As System.EventArgs) Handles SelCmdFiles.Click
        If CmdFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim SelectedCmdFiles As Array
            SelectedCmdFiles = CmdFileDialog.FileNames
            For index = 0 To SelectedCmdFiles.GetUpperBound(0)
                CmdFiles.AppendText(SelectedCmdFiles(index))
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim List2 As New List(Of String)
        Dim index As Integer
        List2.AddRange(CmdFiles.Text.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
        For index = 0 To List2.Count - 1
            For Each DestinationFile In System.IO.Directory.GetFiles(ServerPaths.Text)
                If System.IO.Path.GetFileName(DestinationFile) = System.IO.Path.GetFileName(List2(index)) Then
                    MsgBox(System.IO.Path.GetFileName(DestinationFile) & System.IO.Path.GetFileName(List2(index)) & " Matches!")
                Else
                End If
            Next
        Next
    End Sub
End Class
