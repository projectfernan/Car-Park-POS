Public Class frmSetPrinter

    Private Sub frmSetPrinter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        saveDriver()
    End Sub

    Private Sub frmSetPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboDriver.Items.Clear()
        PopulateInstalledPrintersCombo(cboDriver)
        chkGPprint.Checked = My.Settings.GPprint

        ViewDriver()
    End Sub

    Public Sub ViewDriver()
        With My.Settings
            cboDriver.Text = .PrinterDriver
        End With
    End Sub

    Private Sub cboDriver_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDriver.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub saveDriver()
        With My.Settings
            .PrinterDriver = cboDriver.Text
            .Save()
            PRINTER_NAME = .PrinterDriver
        End With

    End Sub

    Private Sub cmdTest1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest1.Click
        If cboDriver.Text = vbNullString Then
            MsgBox("Please select printer driver!    ", MsgBoxStyle.Exclamation, "Printer Test")
            Exit Sub
        End If
        saveDriver()
        ' Prnt()
        PrintReceiptRaw_Now()
    End Sub

    Private Sub cboDriver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDriver.SelectedIndexChanged

    End Sub

    Private Sub chkGPprint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGPprint.CheckedChanged
        My.Settings.GPprint = chkGPprint.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class