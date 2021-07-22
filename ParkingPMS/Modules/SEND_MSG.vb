Imports ADODB
Module SEND_MSG
    Public Sub SendMsg(Zone As String, ByVal Msg As String)
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs.Open("select * from tblpmsmsg", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("EntryZone").Value = Zone
            rs("Msg").Value = Msg
            rs.Update()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
End Module
