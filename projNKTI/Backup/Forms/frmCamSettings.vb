Public Class frmCamSettings

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        saveAudiUpdate(str_SysUser, str_SysPosi, "Update Camera settings")

        MsgBox("New Camera settings saved!    ", vbInformation, "Camera Settings")
        Me.Close()
    End Sub
    Sub save()
        With My.Settings
            .CAM_User = txtUser.Text
            .CAM_Pass = txtpass.Text
            .CAM_IP = txtIp.Text
            .CAM_Port = txtPort.Text

            .CAM_ChannelEnt = ChanEntry.Value
            .CAM_ChannelCap1 = CaptureEnt.Value
            .Save()
        End With
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        camEntrance()
        saveAudiUpdate(str_SysUser, str_SysPosi, "Test camera connection")

    End Sub

    Private Sub frmCamSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        camInfo()
    End Sub
End Class