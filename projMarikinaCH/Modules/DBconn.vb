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
            conSqlPOS.Open("Driver={MySQL ODBC 8.0 Unicode Driver}; " _
            & "Server=" & My.Settings.DB_IP1 & ";" _
            & "Port=3306;" _
            & "Option=3;" _
            & "UID=" & My.Settings.DB_User1 & ";" _
            & "PWD=" & My.Settings.DB_Pass1 & ";")
            'conSqlPOS.Execute("SET GLOBAL wait_timeout=50000;")
            Return True
        Catch ex As Exception
            Save_ErrLogs("[conSdb]", ex.Message)
            Return False
        End Try
    End Function

    Public Function conServer() As Boolean
        Try
            If My.Settings.ServerPing = False Then
                If PingMe(frmConnDB.txtIp1.Text) = False Then
                    MainForm.txtDbStat.Text = "Disconnected"
                    MainForm.txtDbStat.ForeColor = Color.Red
                    Return False
                End If
            End If

            If conSqlPOS.State = ConnectionState.Open Then conSqlPOS.Close()
            conSqlPOS = New ADODB.Connection
            conSqlPOS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlPOS.Open("Driver={MySQL ODBC 8.0 Unicode Driver}; " _
            & "Server=" & My.Settings.DB_IP1 & ";" _
            & "Port=3306;" _
            & "Option=3;" _
            & "Database=" & My.Settings.DB_Db1 & ";" _
            & "UID=" & My.Settings.DB_User1 & ";" _
            & "PWD=" & My.Settings.DB_Pass1 & ";")
            conSqlPOS.Execute("SET GLOBAL wait_timeout=50000;")
            conSqlPOS.Execute("SET GLOBAL max_connections=50000;")

            MainForm.txtDbStat.ForeColor = Color.Green
            MainForm.txtDbStat.Text = "Connected"
            Return True
        Catch ex As Exception
            Save_ErrLogs("[conServer]", ex.Message)
            MainForm.txtDbStat.Text = "Disconnected"
            MainForm.txtDbStat.ForeColor = Color.Red
            Return False
        End Try
    End Function

    Public Function conLdb() As Boolean
        Try
            If conSqlLoc.State = ConnectionState.Open Then conSqlLoc.Close()
            conSqlLoc = New ADODB.Connection
            conSqlLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlLoc.Open("Driver={MySQL ODBC 8.0 Unicode Driver}; " _
           & "Server=localhost;" _
           & "Port=3306;" _
           & "Option=3;" _
           & "UID=" & My.Settings.DB_User2 & ";" _
           & "PWD=" & My.Settings.DB_Pass2 & ";")
            Return True
        Catch ex As Exception
            Save_ErrLogs("[conLdb]", ex.Message)
            Return False
        End Try
    End Function

    Public Function conLocal() As Boolean
        Try
            If conSqlLoc.State = ConnectionState.Open Then conSqlLoc.Close()
            conSqlLoc = New ADODB.Connection
            conSqlLoc.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlLoc.Open("Driver={MySQL ODBC 8.0 Unicode Driver}; " _
           & "Server=localhost;" _
           & "Port=3306;" _
           & "Option=3;" _
           & "Database=" & My.Settings.DB_Db2 & ";" _
           & "UID=" & My.Settings.DB_User2 & ";" _
           & "PWD=" & My.Settings.DB_Pass2 & ";")
            conSqlLoc.Execute("SET GLOBAL wait_timeout=50000;")
            conSqlLoc.Execute("SET GLOBAL max_connections=50000;")
            Return True
        Catch ex As Exception
            Save_ErrLogs("[conLocal]", ex.Message)
            Return False
        End Try
    End Function

   

End Module
