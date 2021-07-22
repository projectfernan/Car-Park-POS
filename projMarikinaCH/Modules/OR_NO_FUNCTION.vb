Imports ADODB
Module OR_NO_FUNCTION
    Public Function Ticket_OR_No() As String
        Try
            Dim Ticket As String = My.Settings.OR_Number
            Dim x As Integer = 1

            If Ticket.Length > 10 Then

                For x = 1 To 100
                    Dim ss As String = "Station " & x
                    If ss = My.Settings.STATION Then
                        Exit For
                    End If
                Next
                Return x.ToString & "-" & Ticket
            Else

                If Ticket = 0 Then Ticket = 1

                Dim i As Integer = 8 - Ticket.Length
                Dim Nticket As String = New String("0", i)

                For x = 1 To 100
                    Dim ss As String = "Station " & x
                    If ss = My.Settings.STATION Then
                        Exit For
                    End If
                Next

                Return x.ToString & "-" & Nticket & Ticket
            End If
        Catch ex As Exception
            Save_ErrLogs("[Ticket_OR_No]", ex.Message)
            Return vbNullString
        End Try
    End Function

    Public Sub Update_OR()
        Try
            Dim i As Long = My.Settings.OR_Number
            Dim s As Long = i + 1
            My.Settings.OR_Number = s
            My.Settings.Save()
        Catch ex As Exception
            Save_ErrLogs("[Update_OR]", ex.Message)
        End Try
       
        'Dim i As Long = CInt(getOr())
        'Dim s As Long = i + 1

        'setOr(s)
    End Sub

    'Public Function getOr() As String
    '    Try
    '        If conLocal() = False Then Return 1

    '        Dim rs As New recordset
    '        rs = conSqlLoc.Execute("select ORseries from tblsetpos")
    '        If rs.EOF = False Then
    '            Return rs("ORseries").Value
    '        Else
    '            Return 1
    '        End If
    '    Catch ex As Exception
    '        Return 1
    '    End Try
    'End Function

    'Public Function setOr(ByVal orno As Long) As String
    '    Try
    '        If conLocal() = False Then Return 1

    '        Dim rs As New Recordset
    '        rs.Open("select ORseries from tblsetpos", conSqlLoc, 1, 2)
    '        rs("ORseries").Value = orno
    '        rs.Update()

    '    Catch ex As Exception
    '        Return 1
    '    End Try
    'End Function

    Public Sub Restore_OR()
        With My.Settings
            .OR_Number = 1
            .Save()
        End With
    End Sub

End Module
