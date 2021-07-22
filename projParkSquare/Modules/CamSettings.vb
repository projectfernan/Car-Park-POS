Module CamSettings
    Public Sub CAM_CLOSE()
        With frmMain
            .CamEntry.StopRealPlay()
            .CamEntry.Logout()
            .CamEntry.ClearOCX()
           
        End With
    End Sub
    Public Sub camInfo()
        With My.Settings
            frmCamSettings.txtUser.Text = .CAM_User
            frmCamSettings.txtpass.Text = .CAM_Pass
            frmCamSettings.txtIp.Text = .CAM_IP
            frmCamSettings.txtPort.Text = .CAM_Port

            frmCamSettings.ChanEntry.Value = .CAM_ChannelEnt
            frmCamSettings.CaptureEnt.Value = .CAM_ChannelCap1
        End With
    End Sub
    Public Sub camEntrance()
        'CAM_CLOSE()
        Dim val As Long
        Try
            With frmMain
                val = .CamEntry.Login(frmCamSettings.txtIp.Text, frmCamSettings.txtPort.Text, frmCamSettings.txtUser.Text, frmCamSettings.txtPass.Text)
                .CamEntry.StartRealPlay(frmCamSettings.ChanEntry.Text, 0, 0)
                If val < 0 Then

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
   
    Public Sub inCapture()
        'Dim pathEnt As String
        Dim orgCAp As String
        frmMain.CamEntry.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, Application.StartupPath & "\EntCapture")
        orgCAp = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
        CopPic = (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")
        'CapPic(CopPic)
    End Sub
    
End Module
