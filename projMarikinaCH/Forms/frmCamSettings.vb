Public Class frmCamSettings

    Sub save()
        With My.Settings
            .CAM_User = txtUser.Text
            .CAM_Pass = txtPass.Text
            .CAM_IP = txtIp.Text
            .CAM_Port = txtPort.Text

            .CAM_ChannelEnt = ChanEntry.Value
            .CAM_ChannelCap1 = CaptureEnt.Value

            .CAM_ChannelExt = ChanExit.Value
            .CAM_ChannelCap2 = CaptureExit.Value
            .Save()
        End With
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        save()
        camExit()
    End Sub

    Private Sub frmCamSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        camInfo()
    End Sub

    Public Sub camInfo()
        With My.Settings
            txtUser.Text = .CAM_User
            txtPass.Text = .CAM_Pass
            txtIp.Text = .CAM_IP
            txtPort.Text = .CAM_Port

            ChanEntry.Value = .CAM_ChannelEnt
            CaptureEnt.Value = .CAM_ChannelCap1
            ChanExit.Value = .CAM_ChannelExt
            CaptureExit.Value = .CAM_ChannelCap2
        End With
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()
        MsgBox("New Camera settings saved!    ", vbInformation, "Camera Settings")
        Me.Close()
    End Sub
End Class