Imports ADODB
Public Class frmConnDB
    Public flag As String
    Public flg As Boolean
    Public flg2 As Boolean
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
   
    Sub viewDBL()
        If flg2 = True Then
            Exit Sub
        End If
        Dim dbshw As New Recordset
        dbshw = New Recordset
        dbshw = conSqlLoc.Execute("show databases")
        Do While dbshw.EOF = False
            cboLdb.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop
        flg2 = True
    End Sub


    Private Sub cmdTest2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Sub save()
        With My.Settings
            .DB_IP2 = txtIpLoc.Text
            .DB_User2 = txtUser2.Text
            .DB_Pass2 = txtPass2.Text
            .DB_Db2 = cboLdb.Text
            .Save()
        End With
    End Sub

    Sub DeLSdb()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conndb.Execute("delete from tblServerDB")
    End Sub

    Sub DelLdb()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conndb.Execute("delete from tblLocalDB")
    End Sub
    Sub saveLDB()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblLocalDB", conndb, 1, 2)
        rs.AddNew()
        rs("UID").Value = txtUser2.Text
        rs("PWD").Value = txtPass2.Text
        rs("Db").Value = cboLdb.Text
        rs.Update()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cboLdb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLdb.Click
        If conLdb() = True Then
            viewDBL()
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "MySQL Connection")
        End If
    End Sub

    Private Sub btnTestConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConn.Click
        save()
        If conLocal() = True Then
            PMSmain.txtDbStat.Text = "Connected"
            PMSmain.txtDbStat.ForeColor = Color.Lime
            MsgBox("Successfully connected!    ", MsgBoxStyle.Information, "Localhost Connection")
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Localhost Connection")
            PMSmain.txtDbStat.Text = "Disconnected"
            PMSmain.txtDbStat.ForeColor = Color.LightCoral
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()
        'Server
        If PingMe(txtIpLoc.Text) = True Then
            If conLocal() = True Then
                PMSmain.txtDbStat.Text = "Connected"
                PMSmain.txtDbStat.ForeColor = Color.Lime
                PMSmain.tmeSlot.Enabled = True
            Else
                PMSmain.txtDbStat.Text = "Disconnected"
                PMSmain.txtDbStat.ForeColor = Color.LightCoral
            End If
        Else
            PMSmain.txtDbStat.Text = "Disconnected"
            PMSmain.txtDbStat.ForeColor = Color.LightCoral
        End If

        MsgBox("Database connection saved!    ", MsgBoxStyle.Information, "MySQL Connection")
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class