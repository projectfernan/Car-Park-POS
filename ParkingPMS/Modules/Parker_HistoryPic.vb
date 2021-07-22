Imports ADODB
Module Parker_HistoryPic
    Public Function Get_PkHistory1(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select Incapture from tblparkerhistory where Id = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Incapture").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    Return bmp
                    stream.Close()
                Catch ex As Exception
                    Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End If
        Catch ex As Exception
            Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Function

    Public Function Get_PkHistory2(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select Outcapture from tblparkerhistory where Id = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Outcapture").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    Return bmp
                    stream.Close()
                Catch ex As Exception
                    Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            End If
        Catch ex As Exception
            Return Image.FromFile(Application.StartupPath & "\noimage.jpeg")
        End Try
    End Function
End Module
