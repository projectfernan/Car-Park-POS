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