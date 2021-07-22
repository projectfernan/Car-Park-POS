Module HEX_to_String
    '---------------hexa to string-------------------------------------------------------------------------------------------------------------------------

    Function HexToString(ByVal strHex As String) As String
        Dim strMakeText As String, lngCharCount As Long
        strMakeText = Space$(Len(strHex) \ 2)
        For lngCharCount = 1 To Len(strHex) \ 2
            Mid$(strMakeText, lngCharCount, 1) = Chr(Val("&H" & Mid$(strHex, (lngCharCount * 2) - 1, 2)))
        Next lngCharCount
        HexToString = strMakeText
    End Function

    Function StringToHex(ByVal alpha As String) As String
        Dim str As String = vbNullString
        Dim Val As String = vbNullString
        Dim i As Long
        For i = 1 To alpha.Length
            str = Mid(alpha, i, 1)
            Dim xx As String
            xx = Hex(Asc(str))
            Val = Val + xx
        Next i

        If Val.Length > 32 Then
            Return vbNullString
        End If

        Val = Val + New String("0", 32 - Val.Length)

        Return Val
    End Function
    '-----------------------------------------------------------------------------------------------------------------------------------------------------------

    Function StringToHexGdt(ByVal alpha As String) As String
        Dim str As String = vbNullString
        Dim Val As String = vbNullString
        Dim i As Long
        For i = 1 To Len(alpha)
            str = Mid(alpha, i, 1)
            Dim xx As String
            xx = Hex(Asc(str))
            Val = Val + xx
        Next i
        StringToHexGdt = Val
    End Function

End Module

