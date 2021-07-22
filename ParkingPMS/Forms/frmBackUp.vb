Public Class frmBackUp

    Private Sub frmBackUp_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        With My.Settings
            .MySQLdump = txtFile1.Text
            .Save()
        End With
    End Sub

    Private Sub frmBackUp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub browse()
        Dim FBD As New FolderBrowserDialog
        FBD.Description = "Backup Path"
        FBD.ShowNewFolderButton = True      'OR FALSE
        FBD.SelectedPath = "C:\"
        FBD.ShowDialog()
        txtpath.Text = FBD.SelectedPath      'Use this path to Process the folder...or files
        FBD = Nothing
    End Sub

    Sub browseMysql()
        OpenPath.Filter = "mysqldump (*.exe)|*.exe"
        OpenPath.InitialDirectory = "C:\"
        OpenPath.FileName = vbNullString
        If OpenPath.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile1.Text = OpenPath.FileName
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

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        browse2()
    End Sub

    Private Sub cmdBackup_Click(sender As System.Object, e As System.EventArgs) Handles cmdBackup.Click
        Try
            Process.Start(txtFile1.Text, " -u " & frmConnDB.txtUser2.Text & " -p " & frmConnDB.txtPass2.Text & " " & frmConnDB.cboLdb.Text & " -r " & txtpath.Text & "")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Backup")
        End Try
    End Sub

    Private Sub cmdBrowseDump_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowseDump.Click
        browseMysql()
    End Sub

    Private Sub frmBackUp_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        txtFile1.Text = My.Settings.MySQLdump
        txtpath.Text = vbNullString
    End Sub
End Class