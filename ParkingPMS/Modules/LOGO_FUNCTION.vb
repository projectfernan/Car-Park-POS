Imports System.IO
Imports System.Diagnostics
Imports ADODB
Module LOGO_FUNCTION
    Public LogoDir As String = Application.StartupPath & "\LogoFolder"
    Public StrPicFile As String
    Public pathFrm As String

    Public Function getpicLogo(ByVal path As String) As String
        Try
            If Not Directory.Exists(LogoDir) Then
                Directory.CreateDirectory(LogoDir)
            End If
            If System.IO.File.Exists(path) Then
                StrPicFile = vbNullString
                StrPicFile = Application.StartupPath & "\LogoFolder\" & "SystemLogo.Jpg"
                If System.IO.File.Exists(StrPicFile) Then
                    System.IO.File.Delete(StrPicFile)
                    System.IO.File.Copy(path, StrPicFile)
                Else
                    System.IO.File.Copy(path, StrPicFile)
                End If
            End If
            Return StrPicFile
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            Return vbNullString
        End Try
    End Function

    Public Sub Delete_Logo()
        If Directory.Exists(Application.StartupPath & "\LogoFolder") = True Then
            Directory.Delete(Application.StartupPath & "\LogoFolder", True)
        End If
    End Sub

    Public Function Logo_Image() As Bitmap
        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblLogo")
            If rs.EOF = False Then
                Dim imgByteArray() As Byte
                Try
                    imgByteArray = CType(rs("Logo").Value, Byte())
                    Dim stream As New System.IO.MemoryStream(imgByteArray)
                    Dim bmp As New Bitmap(stream)
                    stream.Close()
                    Return bmp
                Catch ex As Exception
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
