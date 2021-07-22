Imports ADODB
Public Class frmConnDB
    Public flag As String
    Public flg As Boolean
    Public flg2 As Boolean
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        'If PingMe(txtIp1.Text) = True Then
        If conServer() = True Then
            MsgBox("Successfully connected!    ", MsgBoxStyle.Information, "Server Connection")
            frmMain.txtDbStat.Text = "Connected"
            frmMain.txtDbStat.ForeColor = Color.Lime
            frmMain.tmeSlot.Enabled = True
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Server Connection")
            frmMain.txtDbStat.Text = "Disconnected"
            frmMain.txtDbStat.ForeColor = Color.Red
        End If
        'Else
        'MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Server Connection")
        'frmMain.txtDbStat.Text = "Disconnected"
        'frmMain.txtDbStat.ForeColor = Color.Red
        'End If
    End Sub
    Sub viewDB()
        If flg = True Then
            Exit Sub
        End If
        Dim dbshw As New Recordset
        dbshw = New Recordset
        dbshw = conSqlPOS.Execute("show databases")
        Do While dbshw.EOF = False
            cboSdb.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop
        flg = True
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


    Private Sub cmdTest2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest2.Click
        'If PingMe(txtIp2.Text) = True Then
        If conLocal() = True Then
            frmMain.dbstat2.Text = "Connected"
            frmMain.dbstat2.ForeColor = Color.Lime
            MsgBox("Successfully connected!    ", MsgBoxStyle.Information, "Localhost Connection")
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Localhost Connection")
            frmMain.dbstat2.Text = "Disconnected"
            frmMain.dbstat2.ForeColor = Color.Red
        End If

    End Sub

    Sub save()
        With My.Settings
            .DB_IP1 = txtIp1.Text
            .DB_User1 = txtUser1.Text
            .DB_Pass1 = txtPwd1.Text
            .DB_Db1 = cboSdb.Text

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
    Sub saveSDB()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblServerDB", conndb, 1, 2)
        rs.AddNew()
        rs("IP").Value = txtIp1.Text
        rs("UID").Value = txtUser1.Text
        rs("PWD").Value = txtPwd1.Text
        rs("Db").Value = cboSdb.Text
        rs.Update()
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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        'Server
        'If PingMe(txtIp1.Text) = True Then
        If conServer() = True Then
            frmMain.txtDbStat.Text = "Connected"
            frmMain.txtDbStat.ForeColor = Color.Lime
            frmMain.tmeSlot.Enabled = True
        Else
            frmMain.txtDbStat.Text = "Disconnected"
            frmMain.txtDbStat.ForeColor = Color.Red
        End If
        'Else
        'frmMain.txtDbStat.Text = "Disconnected"
        'frmMain.txtDbStat.ForeColor = Color.Red
        'End If
        'Localhost
        If conLocal() = True Then
            frmMain.dbstat2.Text = "Connected"
            frmMain.dbstat2.ForeColor = Color.Lime
        Else
            frmMain.dbstat2.Text = "Disconnected"
            frmMain.dbstat2.ForeColor = Color.Red
        End If

        saveAudiUpdate(str_SysUser, str_SysPosi, "Update database settings")

        MsgBox("Database connection saved!    ", MsgBoxStyle.Information, "MySQL Connection")
        frmMain.tmeSlot.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmConnDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.tmeSlot.Enabled = False
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cboSdb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSdb.Click
        'If PingMe(txtIp1.Text) = True Then
        If conSdb() = True Then
            viewDB()
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "MySQL Connection")
        End If
        'Else
        'MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "MySQL Connection")
        'End If
    End Sub

    Private Sub cboLdb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLdb.Click
        If conLdb() = True Then
            viewDBL()
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "MySQL Connection")
        End If
    End Sub

    Private Sub cboSdb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSdb.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class