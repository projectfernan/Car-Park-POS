Public Class frmAccSettings

    Private Sub cmdAccDesig_Click(sender As System.Object, e As System.EventArgs) Handles cmdAccDesig.Click
        frmAccDesig.ShowDialog()
    End Sub

    Private Sub cmdSystemAcc_Click(sender As System.Object, e As System.EventArgs) Handles cmdSystemAcc.Click
        frmAcc.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmAccSettings_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cmdAccDesig.Enabled = True Then
                frmAccDesig.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            If cmdSystemAcc.Enabled = True Then
                frmAcc.ShowDialog()
            End If
        End If
    End Sub

End Class