Public Class frmGenCateg

    Private Sub frmGenCateg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If frmMain.txtDbStat.Text = "Connected" Then
                Report = "Server"
                frmReportDT.ShowDialog()
            Else
                MsgBox("Failed to connect to server!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            If frmMain.dbstat2.Text = "Connected" Then
                Report = "Local"
                frmReportDT.ShowDialog()
            Else
                MsgBox("Failed to connect to localhost!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End If
    End Sub

    Private Sub frmGenCateg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdGenServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenServer.Click
        If frmMain.txtDbStat.Text = "Connected" Then
            Report = "Server"
            frmReportDT.ShowDialog()
        Else
            MsgBox("Failed to connect to server!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub cmdGenLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenLocal.Click
        If frmMain.dbstat2.Text = "Connected" Then
            Report = "Local"
            frmReportDT.ShowDialog()
        Else
            MsgBox("Failed to connect to localhost!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class