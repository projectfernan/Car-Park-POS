Public Class frmAccSetting

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdAccDesig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccDesig.Click
        frmAccDesig.ShowDialog()
    End Sub

    Private Sub cmdSystemAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSystemAcc.Click
        frmAcc.ShowDialog()
    End Sub

    Private Sub frmAccSetting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cmdAccDesig.Enabled = True Then
                Call cmdAccDesig_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            If cmdSystemAcc.Enabled = True Then
                Call cmdSystemAcc_Click(sender, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class