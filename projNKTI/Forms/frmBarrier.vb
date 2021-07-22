Public Class frmBarrier

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Sub save()
        With My.Settings
            .PortAdd = txtPortAdd.Text
            .StatAdd = txtStatAdd.Text
            .Port = txtPort.Value
            .Delay = txtDelay.Value

            .LoopCode = txtLoop.Value
            .Save()
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        saveAudiUpdate(str_SysUser, str_SysPosi, "Update barrier settings")

        MsgBox("Barrier settings saved!    ", MsgBoxStyle.Information, "Barrier Settings")
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        If txtPortAdd.Text = vbNullString Then
            MsgBox("Please enter port address!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtPortAdd.Focus()
            Exit Sub
        End If

        If txtPort.Value = vbNullString Then
            MsgBox("Please enter port!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtPort.Focus()
            Exit Sub
        End If

        If txtDelay.Value = vbNullString Then
            MsgBox("Please enter delay!    ", MsgBoxStyle.Exclamation, "Trigger settings")
            txtDelay.Focus()
            Exit Sub
        End If
        trigerOff()
        triger()
        saveAudiUpdate(str_SysUser, str_SysPosi, "Test barrier trigger")

    End Sub

    Private Sub frmBarrier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdPin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPin.Click
        If cmdPin.Text = "  Scan Pin" Then
            cmdPin.Text = "  Stop"
            tmrInp.Enabled = True
            Exit Sub
        End If

        If cmdPin.Text = "  Stop" Then
            cmdPin.Text = "  Scan Pin"
            tmrInp.Enabled = False
            Exit Sub
        End If

        saveAudiUpdate(str_SysUser, str_SysPosi, "Scan pin in barrier settings")

    End Sub

    Private Sub tmrInp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInp.Tick
        txtOutput.Text = Output(txtStatAdd.Text)
    End Sub
End Class