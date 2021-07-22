Imports ADODB
Module POS_Version_Function
    Function getSetVer() As String
        Try
            If conLocal() = False Then
                Return ""
            End If

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select PosVer from tblsetpos")
            If rs.EOF = False Then
                Return rs("PosVer").Value
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
End Module
