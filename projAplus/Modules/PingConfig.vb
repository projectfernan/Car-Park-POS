Module PingConfig
    Public Function PingMe(ByVal ipaddress As String) As Boolean
        Try
            If My.Computer.Network.Ping(ipaddress, 1) = False Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
