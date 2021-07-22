Imports ADODB
Module DBconn
    Public conSqlLoc As New ADODB.Connection
    Public conSqlPOS As New ADODB.Connection
    Public conndb As New Connection
    Public recset As New ADODB.Recordset

    Public admin As String
    Public Access As String

    Public Function conLdb() As Boolean
        Try
            If conSqlLoc.State = ConnectionState.Open Then conSqlLoc.Close()
            conSqlLoc = New ADODB.Connection
            conSqlLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlLoc.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
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
            With My.Settings
                conSqlLoc.Open("Driver={mySQL ODBC 8.0 Unicode Driver}; " _
               & "Server=" & .DB_IP2 & ";" _
               & "Port=3306;" _
               & "Option=3;" _
               & "Database=" & .DB_Db2 & ";" _
               & "UID=" & .DB_User2 & ";" _
               & "PWD=" & .DB_Pass2 & ";")
            End With
            conSqlLoc.Execute("SET GLOBAL wait_timeout=50000;")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Sub viewCon()
        With My.Settings
            frmConnDB.txtIpLoc.Text = .DB_IP2
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
