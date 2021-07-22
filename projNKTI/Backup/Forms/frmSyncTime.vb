Imports ADODB
Imports System.Runtime.InteropServices

Public Class frmSyncTime
    Sub getservertime()
        Dim rs As New Recordset
        rs = conSqlPOS.Execute("select current_time,current_date")
        If rs.EOF = False Then
            txtServerDt.Text = rs("current_time").Value
        End If
    End Sub
    Sub getLocaltime()
        Dim rs As New Recordset
        rs = conSqlLoc.Execute("select current_time,current_date")
        If rs.EOF = False Then
            txtLocalDt.Text = rs("current_time").Value
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PingMe(frmConnDB.txtIp1.Text) = True Then
            If conServer() = True Then
                getservertime()
            Else
                MsgBox("Please connect to server!    ", MsgBoxStyle.Exclamation, "Server")
                frmConnDB.ShowDialog()
            End If
        Else
            MsgBox("Please connect to server!    ", MsgBoxStyle.Exclamation, "Server")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
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
            saveAudiUpdate(str_SysUser, str_SysPosi, "Update System date/time synch")

            MsgBox("Successfully synchronized!    ", MsgBoxStyle.Information, "Synchronization")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Synchronization")
        End Try
    End Sub

    Private Sub frmSyncTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class