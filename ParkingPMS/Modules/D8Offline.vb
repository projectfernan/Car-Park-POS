
Module D8Offline
    Public rd As COMRD800Lib.RD800
    Public st As Integer
    Public st2 As Integer
    Public snr As String
    Public readData As String


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

    Public Function readCard() As Boolean
        Try
            Try
                tmeIn = Format(CDate(d8_Read()), "yyyy-MM-dd HH:mm")
                EntryTime = DateTime.Parse(tmeIn)
            Catch ex As Exception
                tmeIn = Mid(d8_Read(), 7, 4) & "-" & Mid(d8_Read(), 1, 2) & "-" & Mid(d8_Read(), 4, 2) & " " & Mid(d8_Read(), 12)
                EntryTime = DateTime.Parse(tmeIn)
            End Try
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module
