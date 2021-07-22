Public Class frmSettings
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBarrier.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSetPrinter.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmConnDB.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmBarrier.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmSetPrinter.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmPoleDisplay.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmCamSettings.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmSyncTime.ShowDialog()
    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles cmOR.ItemClicked

    End Sub

    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmSetPOS.ShowDialog()
        End If

        If e.KeyCode = Keys.F2 Then
            frmConnDB.ShowDialog()
        End If

        If e.KeyCode = Keys.F3 Then
            frmSyncTime.ShowDialog()
        End If

        If e.KeyCode = Keys.F5 Then
            frmBarrier.ShowDialog()
        End If

        If e.KeyCode = Keys.F6 Then
            frmCamSettings.ShowDialog()
        End If

        If e.KeyCode = Keys.F7 Then
            frmSetPrinter.ShowDialog()
        End If

        If e.KeyCode = Keys.F8 Then
            frmPoleDisplay.ShowDialog()
        End If

        If e.KeyCode = Keys.F9 Then
            frmD8Test.ShowDialog()
        End If

        If e.KeyCode = Keys.F10 Then
            frmOR.ShowDialog()
        End If
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmSetPOS.ShowDialog()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        frmD8Test.ShowDialog()
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdBussDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBussDate.Click
        frmBussDate.ShowDialog()
    End Sub

    Private Sub cmdOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOR.Click
        frmOR.ShowDialog()
    End Sub
End Class