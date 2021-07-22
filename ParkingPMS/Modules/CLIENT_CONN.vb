Imports ADODB
Module CLIENT_CONN
    Public C_ip As String
    Public C_uid As String
    Public C_pwd As String
    Public C_port As String
    Public C_db As String

    Public conSqlClient As New Connection
    Public conDbSlct As New Connection

    Public Function conClient(ByVal ip As String, ByVal uid As String, ByVal pwd As String, ByVal port As String, ByVal db As String) As Boolean
        Try
            conSqlClient = New ADODB.Connection
            conSqlClient.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conSqlClient.Open("Driver={mySQL ODBC 5.1 Driver}; " _
           & "Server=" & ip & ";" _
            & "Port=" & uid & ";" _
            & "Option=3;" _
             & "Database=" & db & ";" _
            & "UID=" & uid & ";" _
            & "PWD=" & pwd & ";")
            Return True
        Catch
            Return False
        End Try
    End Function

    Sub ViewClientAcc(ByVal st As String)
        Dim rs As New Recordset

        rs = conSqlLoc.Execute("select * from tblPOS where Station = '" & st & "'")
        If rs.EOF = False Then
            C_ip = rs("IPadd").Value
            C_uid = rs("Username").Value
            C_pwd = rs("Password").Value
            C_port = rs("Port").Value
            C_db = rs("Database").Value
        End If
    End Sub

    Public Function POSdbSlct() As Boolean
        Try
            conDbSlct = New ADODB.Connection
            conDbSlct.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            conDbSlct.Open("Driver={mySQL ODBC 5.1 Driver}; " _
            & "Server=" & frmAddPOS.txtIp1.Text & ";" _
            & "Port=" & frmAddPOS.txtSPort.Value & ";" _
            & "Option=3;" _
            & "UID=" & frmAddPOS.txtUser.Text & ";" _
            & "PWD=" & frmAddPOS.txtPwd.Text & ";")
            Return True
        Catch
            Return False
        End Try
    End Function
End Module
