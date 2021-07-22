Imports ADODB
Public Class frmConnDB
    Public flag As String
    Public flg As Boolean
    Public flg2 As Boolean
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        'If PingMe(txtIp1.Text) = True Then
        If conServer(txtIp1.Text, txtUser1.Text, txtPwd1.Text, cboSdb.Text) = True Then
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
 
        Dim dbshw As New Recordset
        dbshw = New Recordset
        dbshw = conSqlPOS.Execute("show databases")
        cboSdb.Items.Clear()
        Do While dbshw.EOF = False

            cboSdb.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop

    End Sub

    Sub viewDB2()
    
        Dim dbshw As New Recordset
        dbshw = New Recordset
        dbshw = conSqlPOS2.Execute("show databases")
        cboSVRdb2.Items.Clear()
        Do While dbshw.EOF = False

            cboSVRdb2.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop

    End Sub

    Sub viewDBL()
 
        Dim dbshw As New Recordset
        dbshw = New Recordset
        dbshw = conSqlLoc.Execute("show databases")
        cboLdb.Items.Clear()
        Do While dbshw.EOF = False

            cboLdb.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop

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

            .DB_svr2IP = txtIPsvr2.Text
            .DB_svr2UID = txtUIDsvr2.Text
            .DB_svr2PWD = txtPWDsvr2.Text
            .DB_svr2DB = cboSVRdb2.Text

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

    Private Sub frmConnDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.tmeSlot.Enabled = False
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cboSdb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSdb.Click
        'If PingMe(txtIp1.Text) = True Then
        If conSdb(txtIp1.Text, txtUser1.Text, txtPwd1.Text) = True Then
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

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        'Server
        'If PingMe(txtIp1.Text) = True Then
        If conServer(txtIp1.Text, txtUser1.Text, txtPwd1.Text, cboSdb.Text) = True Then
        Else
            If conServer(txtIPsvr2.Text, txtUIDsvr2.Text, txtPWDsvr2.Text, cboSVRdb2.Text) = True Then

            End If
        End If
      
        If conLocal() = True Then
            frmMain.dbstat2.Text = "Connected"
            frmMain.dbstat2.ForeColor = Color.Lime
        Else
            frmMain.dbstat2.Text = "Disconnected"
            frmMain.dbstat2.ForeColor = Color.Red
        End If

        MsgBox("Database connection saved!    ", MsgBoxStyle.Information, "MySQL Connection")
        frmMain.tmeSlot.Enabled = True
        Me.Close()
    End Sub

    Private Sub cboSVRdb2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSVRdb2.Click
        If conSdb2() = True Then
            viewDB2()
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "MySQL Connection")
        End If
    End Sub

    Private Sub cmdtestSvr2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtestSvr2.Click
        If conServer2() = True Then
            MsgBox("Successfully connected!    ", MsgBoxStyle.Information, "Server Connection")
            frmMain.txtDbStat.Text = "Connected"
            frmMain.txtDbStat.ForeColor = Color.Lime
            frmMain.tmeSlot.Enabled = True
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "Server Connection")
            frmMain.txtDbStat.Text = "Disconnected"
            frmMain.txtDbStat.ForeColor = Color.Red
        End If
    End Sub

    Private Sub cboSVRdb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSVRdb2.SelectedIndexChanged

    End Sub
End Class