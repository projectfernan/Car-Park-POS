Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WG3000_COMM.Core
Imports ADODB

Public Class frmSetController
    Dim frm As New FormMove

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim snNo As Integer = txtSN.Text
        If wgMjController.GetControllerType(snNo) = 0 Then

        Else
            controler = New wgMjController
            controler.NetIPConfigure(txtSN.Text, txtMack.Text, txtIP.Text, txtSubnet.Text, txtGateway.Text, txtPort.Text, txtPcIp.Text)

reconfig:
            Dim controlConfigure As New wgMjControllerConfigure

            controlConfigure.DoorControlSet(1, 0)
            'controlConfigure.DoorControlSet(2, 0)

            controlConfigure.DoorDelaySet(1, txtTriggerDelay.Value)
            'controlConfigure.DoorDelaySet(2, txtTriggerDelay.Value)

            Save()

            Dim Upcon As Integer = controler.UpdateConfigureIP(controlConfigure)

            MsgBox("Controller successfully saved and configured! ", vbInformation, "Save")

            Me.Close()
        End If
    End Sub

    Sub Save()
        Try
            With My.Settings
                .ctrl_SN = txtSN.Text
                .ctrl_Ip = txtIP.Text
                .ctrl_Port = txtPort.Text
                .ctrl_Mac = txtMack.Text
                .ctrl_Subnet = txtSubnet.Text
                .ctrl_Gateway = txtGateway.Text
                .ctrl_PcIp = txtPcIp.Text

                .ctrl_TriggerDelay = txtTriggerDelay.Value
                .Save()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Private Sub frmSetController_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        With My.Settings
            txtSN.Text = .ctrl_SN
            txtIP.Text = .ctrl_Ip
            txtPort.Text = .ctrl_Port
            txtMack.Text = .ctrl_Mac
            txtSubnet.Text = .ctrl_Subnet
            txtGateway.Text = .ctrl_Gateway
            txtPcIp.Text = .ctrl_PcIp
            txtTriggerDelay.Value = .ctrl_TriggerDelay
        End With
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        frmFindControler.ShowDialog()
    End Sub

    Private Sub HeaderPanel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseDown
        frm = Form_Mouse_Down(Me, True)
    End Sub

    Private Sub HeaderPanel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseMove
        Set_Move_Drag(Me)
    End Sub

    Private Sub HeaderPanel_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseUp
        frm = Form_Mouse_Down(Me, False)
    End Sub

    Private Sub btnTrigger_Click(sender As System.Object, e As System.EventArgs) Handles btnTrigger.Click
        Save()

        Dim SENo As Integer

        If txtSN.Text IsNot "" Then
            SENo = CInt(txtSN.Text)
        Else
            SENo = 0
        End If

        If OpenBarrierEnt() = False Then

        End If
        OpenBarrierExt()

    End Sub
End Class