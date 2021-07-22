Public Class frmSetTrial
    Dim qt As Boolean = False

    Private Sub frmSetTrial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If qt = True Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmSetTrial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblDtStart.Text = Format(Now, "yyyy-MM-dd")
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        My.Settings.TrialStart = EncryptCode(lblDtStart.Text)
        My.Settings.TrialDays = EncryptCode(txtNoDay.Value.ToString)
        My.Settings.Save()

        MessageBox.Show("The activation trial is successfully!", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("The system will be terminated to make the activation trial in effect!", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        verClose = "Quit"
        qt = True

        Process.GetCurrentProcess.Kill()
        Application.Exit()
    End Sub
End Class