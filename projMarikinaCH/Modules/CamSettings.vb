Imports System.IO
Module CamSettings
    Public Sub CAM_CLOSE()
        With MainForm
            .CamEntry.StopRealPlay()
            .CamEntry.Logout()
            .CamEntry.ClearOCX()

        End With
    End Sub
   
    
    Public Sub camExit()
        'CAM_CLOSE()
        Dim val As Long
        Try
            With My.Settings
                If PingMe(.CAM_IP) = False Then
                    errMsg = "Camera Exit Disconnected."
                    Exit Sub
                End If

                val = MainForm.CamEntry.Login(.CAM_IP, .CAM_Port, .CAM_User, .CAM_Pass)
                If val < 0 Then
                    errMsg = "Camera Exit Error."
                Else
                    MainForm.CamEntry.StartRealPlay(.CAM_ChannelExt, 0, 0)
                    errMsg = vbNullString
                End If
            End With

        Catch ex As Exception
            Save_ErrLogs("[camExit] CamSettings", ex.Message)
            errMsg = ex.Message
        End Try
    End Sub

    Public Sub extCapture()
        Try
            Dim orgCAp As String
            MainForm.CamEntry.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, Application.StartupPath & "\ExtCapture")
            orgCAp = Dir(Application.StartupPath & "\ExtCapture\JPEGCapture\*.jpeg")
            CopPic = (Application.StartupPath & "\ExtCapture\JPEGCapture\" & orgCAp & "")
            errMsg = vbNullString
        Catch ex As Exception
            Save_ErrLogs("[extCapture] CamSettings", ex.Message)
            errMsg = ex.Message
        End Try
        'Dim pathEnt As String

        'CapPic(CopPic)
    End Sub

    Public Sub Delete_ENt_Image()
        Try
            If Directory.Exists(Application.StartupPath & "\EntCapture") = True Then
                Directory.Delete(Application.StartupPath & "\EntCapture", True)
            End If
        Catch ex As Exception
            Save_ErrLogs("[Delete_ENt_Image] CamSettings", ex.Message)
        End Try
    End Sub

    Public Function Get_ImageName() As String
        Try
            Dim Name As String = Dir$(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
            If Name = "" Then
                Return Nothing
            Else
                Return Application.StartupPath & "\EntCapture\JPEGCapture\" & Name
            End If
        Catch ex As Exception
            Save_ErrLogs("[Get_ImageName] CamSettings", ex.Message)
        End Try
    End Function

    Public Function StreamImage() As ADODB.Stream
        Try
            Dim sTrem As New ADODB.Stream
            sTrem.Type = ADODB.StreamTypeEnum.adTypeBinary
            sTrem.Open()
            If Get_ImageName() = Nothing Then
                Return Nothing
            End If
            sTrem.LoadFromFile(Get_ImageName)
            Return sTrem
        Catch ex As Exception
            Save_ErrLogs("[StreamImage] CamSettings", ex.Message)
        End Try
    End Function


End Module
