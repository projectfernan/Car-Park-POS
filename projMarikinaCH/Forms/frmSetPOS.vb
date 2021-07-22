Imports ADODB
Public Class frmSetPOS

    Private Sub frmSetPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewPOSset()
        txtSlot.Text = viewSlot()

        chkDesktop.Checked = My.Settings.DesktopLock
        chkDataPool.Checked = My.Settings.DataPool
        chkPing.Checked = My.Settings.ServerPing
    End Sub

    Sub save()
        With My.Settings
            .TITLE = txtTitle.Text
            .ADDR = txtAdd.Text
            .CONTACT = txtContact.Text
            .TIN = txtTin.Text
            .PERMIT = txtPermit.Text
            .SERIAL = txtSerial.Text
            .MACHINE = txtMachine.Text
            .ACCR = txtAccr.Text
            .STATION = cboStation.Text
            .SLOT = txtSlot.Text
            .MODE = cboChargeState.Text
            '.Operation = cboMode.Text

            .N_AccrDate = dtAccr.Value
            .N_OperatedBy = txtOperatedBy.Text
            .N_PermitDateIssued = dtPermit.Value
            .N_PosVendor = txtPOSVendor.Text
            .N_PosVendorAddr = txtVendorAddr.Text
            .N_PosVendorTin = txtVendorTin.Text
            .Save()
        End With
    End Sub

    Sub delSlot()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("delete from parkingslot", conSqlPOS, 1, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Set POS")
        End Try
    End Sub

    Private Sub cboStation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStation.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cboMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboChargeState.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtSlot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub chkDesktop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesktop.CheckedChanged
        My.Settings.DesktopLock = chkDesktop.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDesktop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDesktop.Click
        MsgBox("To take the effect of this setting, Please restart the application!", vbInformation, "Lock Desktop")
    End Sub

    Private Sub chkDataPool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDataPool.CheckedChanged
        My.Settings.DataPool = chkDataPool.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkPing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPing.CheckedChanged
        My.Settings.ServerPing = chkPing.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()
        saveSlot(txtSlot.Value)

        MainForm.txtTotalSlot.Text = viewSlot().ToString
        MainForm.txtSlot.Text = slot().ToString

        MsgBox("POS successfully set!    ", MsgBoxStyle.Information, "Set POS")
        viewPOSset()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboStation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStation.SelectedIndexChanged

    End Sub

    Private Sub cboChargeState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChargeState.SelectedIndexChanged

    End Sub
End Class