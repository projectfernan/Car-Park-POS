Imports System.IO
Public Class frmRestore

    Sub browseMysql()
        OpenPath.Filter = "MYSQL file (*.sql)|*.sql"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString
        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile1.Text = OpenPath.FileName
        End If
    End Sub

    Sub browseMysqlexe()
        OpenPath.Filter = "mysql (*.exe)|*.exe"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString
        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtExeFile.Text = OpenPath.FileName
        End If
    End Sub

    Sub browse2()
        SavePath.Filter = "MYSQL file (*.sql)|*.sql"
        SavePath.InitialDirectory = "C:\"
        SavePath.FileName = vbNullString
        If SavePath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtpath.Text = SavePath.FileName
        End If
    End Sub

    Sub browse()
        Dim FBD As New FolderBrowserDialog
        FBD.Description = "Working Directory"
        FBD.ShowNewFolderButton = True      'OR FALSE
        FBD.SelectedPath = "C:\"
        FBD.ShowDialog()
        txtpath.Text = FBD.SelectedPath     'Use this path to Process the folder...or files
        FBD = Nothing
    End Sub

    Private Sub cmdBackup_Click(sender As System.Object, e As System.EventArgs) Handles cmdBackup.Click
        Try
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = txtpath.Text
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql.exe -u " & frmConnDB.txtUser2.Text & " -p " & frmConnDB.txtPass2.Text & " " & frmConnDB.cboLdb.Text & " < " & txtFile1.Text)
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            Process.Start(txtExeFile.Text, " -u " & frmConnDB.txtUser2.Text & " -p " & frmConnDB.txtPass2.Text & " --" & frmConnDB.cboLdb.Text & " > -r " & txtFile1.Text & "")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Restore")
        End Try
    End Sub

    Private Sub cmdBrowseDump_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowseDump.Click
        browseMysql()
    End Sub

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        browse()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        browseMysqlexe()
    End Sub

    Private Sub frmRestore_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        With My.Settings
            .WorkingDIR = txtpath.Text
            .MySQL = txtExeFile.Text
            .Save()
        End With
    End Sub

    Private Sub frmRestore_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        txtExeFile.Text = My.Settings.MySQL
        txtFile1.Text = vbNullString
        txtpath.Text = My.Settings.WorkingDIR
    End Sub

End Class