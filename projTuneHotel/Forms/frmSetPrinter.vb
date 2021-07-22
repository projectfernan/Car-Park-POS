Public Class frmSetPrinter

    Private Sub frmSetPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateInstalledPrintersCombo(cboDriver)
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
        Prnt()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cboDriver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDriver.SelectedIndexChanged

    End Sub
End Class