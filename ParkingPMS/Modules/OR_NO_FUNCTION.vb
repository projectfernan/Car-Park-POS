Module OR_NO_FUNCTION
    Public Function Ticket_OR_No() As String

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

    End Function

    Public Sub Update_OR()
        Dim i As Long = My.Settings.OR_Number
        Dim s As Long = i + 1
        My.Settings.OR_Number = s
        My.Settings.Save()
    End Sub

    Public Sub Restore_OR()
        With My.Settings
            .OR_Number = 1
            .Save()
        End With
    End Sub

End Module
