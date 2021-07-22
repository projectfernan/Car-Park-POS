Imports ADODB
Imports System.Runtime.InteropServices

Public Class frmSyncTime
    Sub getservertime()
        Try
            If conServer() = False Then Exit Sub

            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select current_time,current_date")
            If rs.EOF = False Then
                txtServerDt.Text = rs("current_time").Value
            End If

        Catch ex As Exception
            Save_ErrLogs("[getservertime]", ex.Message)
        End Try
    End Sub

    Sub getLocaltime()
        If conLocal() = False Then Exit Sub
        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select current_time,current_date")
            If rs.EOF = False Then
                txtLocalDt.Text = rs("current_time").Value
            End If
        Catch ex As Exception
            Save_ErrLogs("[getLocaltime]", ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If conServer() = True Then
            getservertime()
        Else
            MsgBox("Please connect to server!    ", MsgBoxStyle.Exclamation, "Server")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If conLocal() = True Then
            getLocaltime()
        Else
            MsgBox("Please connect to localhost!    ", MsgBoxStyle.Exclamation, "Localhost")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        Try
            SetDeviceTime(txtServerDt.Text)
            txtLocalDt.Text = Format(Now, "general date")
            MsgBox("Successfully synchronized!    ", MsgBoxStyle.Information, "Synchronization")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Synchronization")
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class