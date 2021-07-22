Imports ADODB

Module TimeIn_Data
    Public Structure TimeIn_Logs
        Public Plate As String
        Public LogTime As String
        Public CarImg As Bitmap
        Public DriverImg As Bitmap
        Public LogStat As Boolean
    End Structure

    Public Function TimeInInfo(ByVal Code As String) As TimeIn_Logs
        Dim til As New TimeIn_Logs

        Try
            If conServer() = False Then
                til.Plate = ""
                til.LogTime = Format(Now, "yyyy-MM-dd HH:mm")
                til.CarImg = Image.FromFile(Application.StartupPath & "\noCar.jpg")
                til.DriverImg = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                til.LogStat = False
                Return til
            End If

            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select Plate,Timein,PIC,PIC2 from timeindb where CardCode = '" & Code & "'")
            If rs.EOF = False Then
                til.Plate = rs("Plate").Value
                til.LogTime = Format(CDate(rs("Timein").Value), "yyyy-MM-dd HH:mm")

                Try
                    Dim imgByteArray() As Byte
                    imgByteArray = CType(rs("PIC").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    til.CarImg = bmp
                    stream.Close()
                Catch ex As Exception
                    til.CarImg = Image.FromFile(Application.StartupPath & "\noCar.jpg")
                End Try

                Try
                    Dim imgByteArray() As Byte
                    imgByteArray = CType(rs("PIC2").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    til.DriverImg = bmp
                    stream.Close()
                Catch ex As Exception
                    til.DriverImg = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                End Try

                til.LogStat = True

                Return til
            Else
                til.Plate = ""
                til.LogTime = Format(Now, "yyyy-MM-dd HH:mm")
                til.CarImg = Image.FromFile(Application.StartupPath & "\noCar.jpg")
                til.DriverImg = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                til.LogStat = False
                Return til
            End If
        Catch ex As Exception
            til.Plate = ""
            til.LogTime = Format(Now, "yyyy-MM-dd HH:mm")
            til.CarImg = Image.FromFile(Application.StartupPath & "\noCar.jpg")
            til.DriverImg = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
            til.LogStat = False
            Return til
        End Try
    End Function
End Module
