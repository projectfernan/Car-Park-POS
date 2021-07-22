Public Class frmCashDrawer

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdT.Click
        OpenCashdrawer(My.Settings.PrinterDriver)
    End Sub

    Private Sub frmCashDrawer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkKickCD.Checked = My.Settings.KickCashDrawer
    End Sub

    Private Sub chkKickCD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKickCD.CheckedChanged
        My.Settings.KickCashDrawer = chkKickCD.Checked
        My.Settings.Save()
    End Sub
End Class