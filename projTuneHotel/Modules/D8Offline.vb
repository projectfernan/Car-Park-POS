
Module D8Offline
    ' Public rd As COMRD800Lib.RD800
    Public st As Integer
    Public st2 As Integer
    Public snr As String
    Public readData As String
    Public RD As COMRD800Lib.IRD800 = New COMRD800Lib.RD800


    Public Function d8_conn() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub d8_Beep()
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then

        Else
            rd.dc_beep(10)
        End If
    End Sub

    Public Function d8_Card() As Boolean
        rd = New COMRD800Lib.RD800
        st = rd.dc_init(100, 115200)
        If st < 0 Then
            Return False
        Else
            st = rd.dc_card(0, snr)
            If st = 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Function d8_Loadpass() As Boolean
        rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF" 'this is load key function
        st = rd.dc_load_key(0, CShort(3))
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function d8_Authen() As Boolean
        st = rd.dc_authentication(0, CShort(3)) 'this is to authentication
        If st < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function d8_Read() As String
        st = rd.dc_read(CShort(12)) 'this is how to read
        If st < 0 Then
            d8_Read = "0"
        Else
            System.Threading.Thread.Sleep(200)
            d8_Read = rd.get_bstrRBuffer
        End If
    End Function

    Function d8_Read_Grace() As String
        st = RD.dc_read(CShort(13)) 'this is how to read
        If st < 0 Then
            Return "0"
        Else
            System.Threading.Thread.Sleep(200)
            Return RD.get_bstrRBuffer
        End If
    End Function

    Public Function D8_LoadKey(ByVal Sector As Short) As Boolean

        Dim pas As String = "FFFFFFFFFFFF"
        rd.put_bstrSBuffer_asc = pas.ToString
        st = RD.dc_load_key(0, Sector)
        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function D8_Authenticate(ByVal Sector As Short) As Boolean

        st = RD.dc_authentication(0, Sector)

        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function


    Public Function D8_ResetCard(ByVal Address As Short) As Boolean

        rd.dc_restore(CShort(Address))
        Dim ss As String = New String("0", 32)
        RD.put_bstrSBuffer_asc = ss
        st = RD.dc_write(CShort(Address))

        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function D8_WriteDate(ByVal address As Short) As Boolean 'write Date Time ========================

        RD.dc_restore(CShort(address))
        Dim T As String = Format(Now, "MM-dd-yyyy HH:mm")
        RD.put_bstrSBuffer_asc = StringToHex(T)
        st = RD.dc_write(CShort(address))

        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function D8_WriteDateG(ByVal address As Short) As Boolean 'write Date Time ========================

        RD.dc_restore(CShort(address))
        Dim T As String = Format(frmGuest.dtDateStart.Value, "MM-dd-yyyy")
        RD.put_bstrSBuffer_asc = StringToHexGdt(T)
        st = RD.dc_write(CShort(address))

        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function


    Public Function D8_WriteDateG2(ByVal address As Short) As Boolean 'write Date Time ========================

        RD.dc_restore(CShort(address))
        Dim T As String = Format(frmGuest.dtDateExp.Value, "MM-dd-yyyy HH:mm")
        RD.put_bstrSBuffer_asc = StringToHexGdt(T)
        st = RD.dc_write(CShort(address))

        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function D8_WriteCard(ByVal address As Short, ByVal Plate As String) As Boolean 'write Data ========================
        rd.dc_restore(CShort(address))
        rd.put_bstrSBuffer_asc = StringToHex(Plate.ToString)
        st = rd.dc_write(CShort(address))
        If st < 0 Then
            Return False
        Else
            Return True
        End If

    End Function

End Module
