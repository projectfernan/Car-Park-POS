Imports ADODB
Public Class frmSettings

    'Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
    '    frmD8Test.ShowDialog()
    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSetPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetPOS.Click
        Dim Ver As String = My.Settings.POS_VER
        Select Case Ver
            Case "BIR BASED"
                Dim f As New frmSetPOS
                f.ShowDialog()
            Case "GOVERNMENT BASED"
                Dim f As New frmSetPOSGov
                f.ShowDialog()
        End Select
    End Sub

    Private Sub btnDbSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDbSettings.Click
        Dim f As New frmConnDB
        f.ShowDialog()
    End Sub

    Private Sub btnDtSync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDtSync.Click
        Dim f As New frmSyncTime
        f.ShowDialog()
    End Sub

    Private Sub btnController_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnController.Click
        frmSetController.ShowDialog()
    End Sub

    Private Sub btnCamera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCamera.Click
        Dim f As New frmCamSettings
        f.ShowDialog()
    End Sub

    Private Sub btnPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrinter.Click
        Dim f As New frmSetPrinter
        f.ShowDialog()
    End Sub

    Private Sub btnPoleDisp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoleDisp.Click
        Dim f As New frmPoleDisplay
        f.ShowDialog()
    End Sub

    Private Sub cmdOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New InternalSet
        f.ShowDialog()
    End Sub

    Private Sub frmSettings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call btnSetPOS_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F2 Then
            Call btnDbSettings_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F3 Then
            Call btnDtSync_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F4 Then
            Call btnController_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F5 Then
            Call btnCamera_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F6 Then
            Call btnPrinter_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F7 Then
            Call btnPoleDisp_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F8 Then
            Call btnCashDrawer_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F9 Then
            Call btnER302_Click(sender, New System.EventArgs)
        End If

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.E Then
            Dim f As New ErrLogs
            f.ShowDialog()
        End If
    End Sub

    Private Sub btnCashDrawer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashDrawer.Click
        Dim f As New frmCashDrawer
        f.ShowDialog()
    End Sub

    Private Sub btnER302_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnER302.Click
        Dim f As New frmER302
        f.ShowDialog()
    End Sub
End Class