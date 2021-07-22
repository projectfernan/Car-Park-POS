Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module ER302_Function
    Dim buf1(200) As Byte
    Dim b1 As Byte
    Dim pSnr As String
    Dim key As String = "FFFFFFFFFFFF"

    Public Function ER302_Conn(ByVal com As Integer) As Boolean
        Try
            'ClosePort
            rf_ClosePort()

            'OpenPort
            Dim i As Integer
            i = rf_init_com(com, 19200)
            If (i <> 0) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
            Return False
        End Try
    End Function

    Public Function ER302_Request() As Boolean
        Try
            Dim i As Integer
            Dim j As Short
            Dim rM As Byte = &H26S '&H26S Can't Read Halted Card &H52S Can Read Halted Card

            i = rf_request(0, rM, j)
            If (i <> 0) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
            Return False
        End Try
    End Function

    Public Function ER302_AntiColl() As String
        Try
            Dim i As Integer
            i = rf_anticoll(0, 4, buf1(0), b1)
            If (i <> 0) Then
                Return ""
            End If

            pSnr = ""
            For i = 0 To b1 - 1
                pSnr = pSnr & VB.Right("00" & Hex(buf1(i)), 2)
            Next i
            Return pSnr
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
            Return ""
        End Try
    End Function

    Public Function ER302_CardSelect() As Boolean
        Try
            Dim i As Integer
            i = rf_select(0, buf1(0), 4, b1)
            If (i <> 0) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
            Return False
        End Try
    End Function

    Public Function ER302_WriteCard(ByVal data As String, ByVal index As Integer) As Boolean
        Try
            Dim i As Integer
            Dim b1, b3 As Byte
            Dim buf1(200) As Byte
            Dim buf2(200) As Byte
            b1 = &H60S
            Dim hexData As String = data

            For i = 0 To 5
                buf1(i) = Val("&H" & Mid(key, i * 2 + 1, 2))
            Next i

            If (Len(hexData) <> 32) Then
                Return False
            End If

            For i = 0 To 15
                buf2(i) = Val("&H" & Mid(hexData, i * 2 + 1, 2))
            Next i
            'Authentication
            b3 = CByte(index)
            i = rf_M1_authentication2(0, b1, b3, buf1(0))
            If (i <> 0) Then
                Return False
            End If
            'Write card
            i = rf_M1_write(0, b3, buf2(0))
            If (i <> 0) Then
                Return False
            End If

            Return True
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
            Return False
        End Try
    End Function

    Public Function ER302_ReadCard(ByVal index As Integer) As String
        Try
            Dim i As Integer
            Dim b1, b2, b3 As Byte
            Dim buf1(200) As Byte
            Dim buf2(200) As Byte
            b1 = &H60S

            For i = 0 To 5
                buf1(i) = Val("&H" & Mid(key, i * 2 + 1, 2))
            Next i

            'Authentication
            b3 = CByte(index)
            i = rf_M1_authentication2(0, b1, b3, buf1(0))
            If (i <> 0) Then
                Return ""
            End If
            'Read card
            i = rf_M1_read(0, b3, buf2(0), b2)
            If (i <> 0) Then
                Return ""
            End If

            Dim retData As String = ""
            For i = 0 To b2 - 1
                retData = retData & VB.Right("00" & Hex(buf2(i)), 2)
            Next i

            Dim TextData As String = HexToString(retData)

            Return TextData
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
            Return ""
        End Try
    End Function

    Function ER302_Beep()
        Try
            rf_beep(0, 20)
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
        End Try
    End Function

    Function ER302_Halt()
        Try
            rf_halt(0)
        Catch ex As Exception
            errMsg = "ER302: " & ex.Message
            Save_ErrLogs("[ER302]", errMsg)
        End Try
    End Function
End Module
