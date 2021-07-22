Module D8Online
    Public HexCardID As String
    Public timeIN As String
    Public Function d8_LoadpassOL() As Boolean
        rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF" 'this is load key function
        st = rd.dc_load_key(0, CShort(0))
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function d8_AuthenOL() As Boolean
        st = rd.dc_authentication(0, CShort(0)) 'this is to authentication
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function d8_ReadOL() As String
        st = rd.dc_read(CShort(0)) 'this is how to read
        If st < 0 Then
            Return vbNullString
        Else
            System.Threading.Thread.Sleep(200)
            Return Trim(Mid(rd.get_bstrRBuffer_asc, 1, 8))
        End If
    End Function
End Module
