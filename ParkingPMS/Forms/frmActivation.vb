Public Class frmActivation
    Dim q As Boolean = False

    Private Sub frmActivation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If q = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txtActiCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtActiCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case txtActiCode.Text
                Case FullActi
                    Dim enc As String = EncryptCode(txtActiCode.Text)

                    MessageBox.Show("The system is fully activated!", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MessageBox.Show("The system will be terminated to make the activation in effect!", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    My.Settings.ActiCode = enc
                    My.Settings.Save()

                    verClose = "Quit"
                    q = True
                    Application.Exit()
                Case TrialActi
                    Dim enc As String = EncryptCode(txtActiCode.Text)
                    My.Settings.ActiCode = enc
                    My.Settings.Save()

                    q = True
                    Me.Hide()
                    Me.Close()
                    frmSetTrial.ShowDialog()
            End Select
        End If

        If e.KeyCode = Keys.Escape Then
            MessageBox.Show("The system will be terminated!", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            verClose = "Quit"
            q = True
            Application.Exit()
        End If
    End Sub
End Class