Imports ADODB
Module DBconn
    Public conSqlLoc As New ADODB.Connection
    Public conSqlPOS As New ADODB.Connection
    Public conndb As New Connection
    Public recset As New ADODB.Recordset

    Public admin As String
    Public Access As String
    Public Function conSdb() As Boolean
        Try
            If conSqlPOS.State = ConnectionState.Open Then conSqlPOS.Close()
            conSqlPOS = New ADODB.Connection
            conSqlPOS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlPOS.Open("Driver={mySQL ODBC 5.1 Driver}; " _
            & "Server=" & frmConnDB.txtIp1.Text & ";" _
            & "Port=" & frmConnDB.txtSPort.Value & ";" _
            & "Option=3;" _
            & "UID=" & frmConnDB.txtUser1.Text & ";" _
            & "PWD=" & frmConnDB.txtPwd1.Text & ";")
            conSqlPOS.Execute("SET GLOBAL wait_timeout=50000;")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function conServer() As Boolean
        Try
            If My.Settings.ServerPing = False Then
                If PingMe(frmConnDB.txtIp1.Text) = False Then
                    frmMain.txtDbStat.Text = "Disconnected"
                    frmMain.txtDbStat.ForeColor = Color.Pink
                    Return False
                End If
            End If

            If conSqlPOS.State = ConnectionState.Open Then conSqlPOS.Close()
            conSqlPOS = New ADODB.Connection
            conSqlPOS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlPOS.Open("Driver={mySQL ODBC 5.1 Driver}; " _
            & "Server=" & frmConnDB.txtIp1.Text & ";" _
            & "Port=" & frmConnDB.txtSPort.Value & ";" _
            & "Option=3;" _
            & "Database=" & frmConnDB.cboSdb.Text & ";" _
            & "UID=" & frmConnDB.txtUser1.Text & ";" _
            & "PWD=" & frmConnDB.txtPwd1.Text & ";")
            conSqlPOS.Execute("SET GLOBAL wait_timeout=50000;")

            frmMain.txtDbStat.ForeColor = Color.Lime
            frmMain.txtDbStat.Text = "Connected"
            Return True
        Catch
            frmMain.txtDbStat.Text = "Disconnected"
            frmMain.txtDbStat.ForeColor = Color.Red
            Return False
        End Try
    End Function

    Public Function conLdb() As Boolean
        Try
            If conSqlLoc.State = ConnectionState.Open Then conSqlLoc.Close()
            conSqlLoc = New ADODB.Connection
            conSqlLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlLoc.Open("Driver={mySQL ODBC 5.1 Driver}; " _
           & "Server=localhost;" _
           & "Port=3306;" _
           & "Option=3;" _
           & "UID=" & frmConnDB.txtUser2.Text & ";" _
           & "PWD=" & frmConnDB.txtPass2.Text & ";")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function conLocal() As Boolean
        Try
            If frmConnDB.cboLdb.Text = vbNullString Or frmConnDB.txtUser2.Text = vbNullString Then
                Return False
                Exit Function
            End If
            If conSqlLoc.State = ConnectionState.Open Then conSqlLoc.Close()
            conSqlLoc = New ADODB.Connection
            conSqlLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlLoc.Open("Driver={mySQL ODBC 5.1 Driver}; " _
           & "Server=localhost;" _
           & "Port=3306;" _
           & "Option=3;" _
           & "Database=" & frmConnDB.cboLdb.Text & ";" _
           & "UID=" & frmConnDB.txtUser2.Text & ";" _
           & "PWD=" & frmConnDB.txtPass2.Text & ";")
            conSqlLoc.Execute("SET GLOBAL wait_timeout=50000;")
            Return True
        Catch
            Return False
        End Try
    End Function
    Public Sub viewCon()
        With My.Settings
            frmConnDB.txtIp1.Text = .DB_IP1
            frmConnDB.txtUser1.Text = .DB_User1
            frmConnDB.txtPwd1.Text = .DB_Pass1
            'frmConnDB.txtSPort.Text = .DB_LPort
            frmConnDB.cboSdb.Text = .DB_Db1

            frmConnDB.txtUser2.Text = .DB_User2
            frmConnDB.txtPass2.Text = .DB_Pass2
            'frmConnDB.txtLPort.Text = .DB_LPort
            frmConnDB.cboLdb.Text = .DB_Db2
        End With
    End Sub

    Public Function ConDB() As Boolean
        Try
            conndb = New ADODB.Connection
            conndb.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conndb.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Dbase.mdb")
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function
    'Public Function scanNull()
    '  'If frmConnDB.txtIp2.Text = vbNullString Or frmConnDB.txtDb2.Text = vbNullString Or frmConnDB.txtUser2.Text = vbNullString Or frmConnDB.txtPass2.Text = vbNullString Then
    'Return True
    ' Else
    ' Return False
    '     ' End If
    'End Function

End Module
