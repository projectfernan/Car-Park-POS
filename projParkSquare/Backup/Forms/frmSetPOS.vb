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
            .MODE = cboMode.Text
            .N_AccrDate = dtAccr.Value
            .N_OperatedBy = txtOperated.Text
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

    Sub saveSlot()
        Try
            If conServer() = False Then Exit Sub

            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from parkingslot", conSqlPOS, 1, 2)
            If rs.EOF = False Then
                rs("TOTAL").Value = txtSlot.Text
                rs.Update()
            Else
                rs.AddNew()
                rs("TOTAL").Value = txtSlot.Text
                rs.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Set POS")
        End Try
    End Sub

    Private Sub cboStation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStation.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        saveSlot()
        frmMain.txtTotalSlot.Text = viewSlot()
        frmMain.txtSlot.Text = slot()
        MsgBox("POS successfully set!    ", MsgBoxStyle.Information, "Set POS")
        viewPOSset()
        Me.Close()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cboMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMode.KeyDown
        If e.KeyCode = Keys.Enter Then
            save()
            saveSlot()
            MsgBox("POS successfully set!    ", MsgBoxStyle.Information, "Set POS")
            viewPOSset()
            Me.Close()
        End If
    End Sub

    Private Sub cboMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMode.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtSlot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSlot.KeyPress
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
End Class