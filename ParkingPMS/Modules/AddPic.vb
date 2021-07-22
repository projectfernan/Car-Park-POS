Imports System.Threading
Imports System.IO
Imports System.IO.File
Imports System.Diagnostics
Imports ADODB
Module AddPic
    Public StrPicFolder As String = Application.StartupPath & "\EmpPic"
    Public StrCapFolder As String = Application.StartupPath & "\EntryCap"
    Public StrCapExtFolder As String = Application.StartupPath & "\ExtCap"
    Public EntPicOutFolder As String = Application.StartupPath & "\EntPicOut"
    Public PicBackUp As String = Application.StartupPath & "\PicUp"
    Public noimage As String
    Public StrPicFile As String
    Public picpath As String
    Public IDNumber As String
    Public idLog As String
    Public idLog2 As String
    Public idLog3 As String
    Public EmpPath As String

    Public CopPic As String
    Public CopPicExt As String

    Public Incap As Bitmap
    Public Function getpic(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(StrPicFolder) Then
                Directory.CreateDirectory(StrPicFolder)
            End If
            If Not Directory.Exists(PicBackUp) Then
                Directory.CreateDirectory(PicBackUp)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\EmpPic\" & (IDNumber) & ".Jpg"
                'If System.IO.File.Exists(StrPicFile) Then
                'Thread.Sleep(0)
                'System.IO.File.Delete(StrPicFile)
                'System.IO.File.Copy(path, StrPicFile)
                ' Else
                'System.IO.File.Copy(path, StrPicFile)
                'End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function
    Public Function CapPic(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(StrCapFolder) Then
                Directory.CreateDirectory(StrCapFolder)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\EntryCap\" & idLog & ".Jpg"
                If System.IO.File.Exists(StrPicFile) Then
                    'System.IO.File.Delete(StrPicFile)
                    'System.IO.File.Copy(path, StrPicFile)
                Else
                    System.IO.File.Copy(path, StrPicFile)
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function
    Public Function CapPicOut(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(StrCapExtFolder) Then
                Directory.CreateDirectory(StrCapExtFolder)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\ExtCap\" & idLog & ".Jpg"
                If System.IO.File.Exists(StrPicFile) Then
                    'System.IO.File.Delete(StrPicFile)
                    'System.IO.File.Copy(path, StrPicFile)
                    'FileCopy(path, StrPicFile)
                Else
                    System.IO.File.Copy(path, StrPicFile)
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function
    Public Sub Delete_Image()
        If Directory.Exists(Application.StartupPath & "\EntCapture") = True Then
            Directory.Delete(Application.StartupPath & "\EntCapture", True)
        End If
    End Sub
    Public Function Get_TmeExt(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select PicPath from tblTimeOut where idlog = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicPath").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmLogs.ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function EntPicOut(ByVal path As String) As Boolean
        Try
            If Not Directory.Exists(EntPicOutFolder) Then
                Directory.CreateDirectory(EntPicOutFolder)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = Application.StartupPath & "\EntPicOut\Ent" & idLog & ".Jpg"
                If System.IO.File.Exists(StrPicFile) Then
                Else
                    System.IO.File.Copy(path, StrPicFile)
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function
    Public Function Get_ImageIn(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select Pic from TimeINdb where cardCode = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Pic").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    Return Image.FromFile(Application.StartupPath & "\noCar.jpeg")
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noCar.jpeg")
            End If
        Catch ex As Exception
            Return Image.FromFile(Application.StartupPath & "\noCar.jpeg")
        End Try
    End Function

    Public Function Get_PicIn(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select Pic from TimeINdb where cardCode = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Pic").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    Return bmp
                    stream.Close()
                Catch ex As Exception
                    Return Image.FromFile(Application.StartupPath & "\noCar.jpg")
                End Try
            Else
                Return Image.FromFile(Application.StartupPath & "\noCar.jpg")
            End If
        Catch ex As Exception
            Return Image.FromFile(Application.StartupPath & "\noCar.jpg")
        End Try
    End Function

    Public Function Get_PicDriver(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select Pic2 from TimeINdb where cardCode = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Pic2").Value, Byte())
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

    Public Function Get_ImageOut(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select PicPath from tblTimeOut where idLog = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicPath").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    ' MessageBox.Show(ex.Message)
                    'frmLogs.EntPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Get_PicEnt(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select PicEnt from tblLogsRec where Idlog = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicEnt").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmLogs.EntPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Get_PicExt(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("select PicExt from tblLogsRec where idlog = '" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicExt").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    'frmLogs.ExtPic.Image = Image.FromFile(Application.StartupPath & "\noimage.jpeg")
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Get_ImageDB(ByRef Acnumber As String) As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("SELECT PicPath FROM tbltimeIn WHERE IdLog='" & Acnumber & "'")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("PicPath").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                    Return Nothing
                End Try
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
