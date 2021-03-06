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

    Public Function D8_LoadKey(ByVal Sector As Short) As Boolean

        RD.put_bstrSBuffer_asc = "FFFFFFFFFFFF"
        st = RD.dc_load_key(0, Sector)
        If st < 0 Then
            errMsg = "Card Password Error"
            Return False
        Else
            errMsg = vbNullString
            Return True
        End If

    End Function

    Public Function D8_Authenticate(ByVal Sector As Short) As Boolean
        st = RD.dc_authentication(0, Sector)
        If st < 0 Then
            errMsg = "Card Authentication Error"
            Return False
        Else
            errMsg = vbNullString
            Return True
        End If
    End Function

    Public Function D8_ResetCard(ByVal Address As Short) As Boolean

        RD.dc_restore(CShort(Address))
        Dim ss As String = New String("0", 32)
        RD.put_bstrSBuffer_asc = ss
        st = RD.dc_write(CShort(Address))

        If st < 0 Then
            errMsg = "Card Reset Error"
            Return False
        Else
            errMsg = vbNullString
            Return True
        End If

    End Function

    Public Function D8_WriteDate(ByVal address As Short) As Boolean 'write Date Time ========================

        RD.dc_restore(CShort(address))
        Dim T As String = Format(Now, "MM-dd-yyyy HH:mm")
        RD.put_bstrSBuffer_asc = StringToHex(T)
        st = RD.dc_write(CShort(address))

        If st < 0 Then
            errMsg = "Card Write Date Error"
            Return False
        Else
            errMsg = vbNullString
            Return True
        End If

    End Function

    Public Function D8_WriteCard(ByVal address As Short, ByVal Plate As String) As Boolean 'write Date Time ========================
        RD.dc_restore(CShort(address))
        Plate = Replace(Plate, "MANUAL-", vbNullString)
        If Plate = Nothing Then Return True
        If Plate.Length > 15 Then Plate = Mid$(Plate, 1, 12)

        RD.put_bstrSBuffer_asc = StringToHex(Plate)
        st = RD.dc_write(CShort(address))
        If st < 0 Then
            Return False
        Else
            Return True
        End If

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
