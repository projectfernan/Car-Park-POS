Module System_Logs
    Public Sub Save_ErrLogs(ByVal threadName As String, ByVal ErrLog As String)
        Try
            Dim tmeNow As String = Format(Now, "yyyy'/'MM'/'dd HH:mm:ss")
            Dim query As String = "INSERT INTO tblErrLogs([Thread],[Error],[TimeStamp])VALUES('" & _
                                   threadName & "','" & _
                                   RemoveReservedSymbols(ErrLog) & "',#" & _
                                   tmeNow & "#)"

            If rsFlogsCUD(query) = False Then
                errMsg = "Failed to save Error Logs."
            End If
        Catch ex As Exception
            errMsg = ex.Message
        End Try
    End Sub

    Public Function RemoveReservedSymbols(ByVal txt As String) As String
        Dim cleanText As String

        cleanText = Replace(txt, ".", vbNullString)
        cleanText = Replace(cleanText, "/", vbNullString)
        cleanText = Replace(cleanText, "*", vbNullString)
        cleanText = Replace(cleanText, ";", vbNullString)
        'cleanText = Replace(cleanText, ":", vbNullString)
        cleanText = Replace(cleanText, "!", vbNullString)
        cleanText = Replace(cleanText, "#", vbNullString)
        cleanText = Replace(cleanText, "&", vbNullString)
        'cleanText = Replace(cleanText, "-", vbNullString)
        cleanText = Replace(cleanText, "?", vbNullString)
        cleanText = Replace(cleanText, "'", vbNullString)
        cleanText = Replace(cleanText, "$", vbNullString)
        cleanText = Replace(cleanText, "%", vbNullString)

        Return cleanText
    End Function
End Module
