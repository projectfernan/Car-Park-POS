Module D8Write

    Public Function d8_LoadpassWr() As Boolean
        Try
            rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF" 'this is load key function
            st = rd.dc_load_key(0, CShort(3))
            If st < 0 Then
                Return False
            Else
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

    Public Function d8_AuthenWr() As Boolean
        Try
            st = rd.dc_authentication(0, CShort(3)) 'this is to authentication
            If st < 0 Then
                Return False
            Else
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

    Public Function D8_Write() As Boolean
        Try
            Dim ss As String = StringToHex("                ")
            rd.dc_restore(CShort(12))
            rd.put_bstrSBuffer_asc = ss
            st = rd.dc_write(CShort(12)) 'this is how to write
            If st < 0 Then
                Return False
            Else
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

End Module
