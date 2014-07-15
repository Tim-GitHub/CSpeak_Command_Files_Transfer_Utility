<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SelDirPath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelCmdFiles = New System.Windows.Forms.Button()
        Me.AppNewCmd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DirPathDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.ServerPaths = New System.Windows.Forms.TextBox()
        Me.CmdFiles = New System.Windows.Forms.TextBox()
        Me.CmdFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'SelDirPath
        '
        Me.SelDirPath.Location = New System.Drawing.Point(12, 20)
        Me.SelDirPath.Name = "SelDirPath"
        Me.SelDirPath.Size = New System.Drawing.Size(143, 23)
        Me.SelDirPath.TabIndex = 0
        Me.SelDirPath.Text = "Select Directory Paths"
        Me.SelDirPath.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Directories where files will be copied to:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(438, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New command files containing data to be added to the identical files in th direct" & _
    "ories above:"
        '
        'SelCmdFiles
        '
        Me.SelCmdFiles.Location = New System.Drawing.Point(12, 218)
        Me.SelCmdFiles.Name = "SelCmdFiles"
        Me.SelCmdFiles.Size = New System.Drawing.Size(143, 23)
        Me.SelCmdFiles.TabIndex = 3
        Me.SelCmdFiles.Text = "Select Command Files"
        Me.SelCmdFiles.UseVisualStyleBackColor = True
        '
        'AppNewCmd
        '
        Me.AppNewCmd.Location = New System.Drawing.Point(262, 410)
        Me.AppNewCmd.Name = "AppNewCmd"
        Me.AppNewCmd.Size = New System.Drawing.Size(166, 23)
        Me.AppNewCmd.TabIndex = 6
        Me.AppNewCmd.Text = "Append New Commands"
        Me.AppNewCmd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Transfer Log:"
        '
        'ServerPaths
        '
        Me.ServerPaths.Location = New System.Drawing.Point(15, 67)
        Me.ServerPaths.Multiline = True
        Me.ServerPaths.Name = "ServerPaths"
        Me.ServerPaths.Size = New System.Drawing.Size(667, 145)
        Me.ServerPaths.TabIndex = 9
        Me.ServerPaths.Text = "C:\CLINICFOLDERNAME1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C:\CLINICFOLDERNAME2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CmdFiles
        '
        Me.CmdFiles.BackColor = System.Drawing.SystemColors.Window
        Me.CmdFiles.Location = New System.Drawing.Point(13, 269)
        Me.CmdFiles.Multiline = True
        Me.CmdFiles.Name = "CmdFiles"
        Me.CmdFiles.ReadOnly = True
        Me.CmdFiles.Size = New System.Drawing.Size(667, 133)
        Me.CmdFiles.TabIndex = 10
        Me.CmdFiles.Text = "C:\CCC-fndef-asthma-TFE.ccc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C:\CCC-fndef-DM-2.ccc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CmdFileDialog
        '
        Me.CmdFileDialog.FileName = "OpenFileDialog1"
        Me.CmdFileDialog.Multiselect = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 589)
        Me.Controls.Add(Me.CmdFiles)
        Me.Controls.Add(Me.ServerPaths)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AppNewCmd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SelCmdFiles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelDirPath)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelDirPath As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelCmdFiles As System.Windows.Forms.Button
    Friend WithEvents AppNewCmd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DirPathDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ServerPaths As System.Windows.Forms.TextBox
    Friend WithEvents CmdFiles As System.Windows.Forms.TextBox
    Friend WithEvents CmdFileDialog As System.Windows.Forms.OpenFileDialog

End Class
