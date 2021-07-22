Public Class frmSenior

    Private Sub frmSenior_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            S_Refnumber = txtDocNo.Text
            S_SeniorName = txtName.Text
            Me.Close()
        End If
    End Sub

    Private Sub frmSenior_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()
    End Sub

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmSenior_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtDocNo.Text = vbNullString
        txtName.Text = vbNullString
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        S_Refnumber = txtDocNo.Text
        S_SeniorName = txtName.Text
        Me.Close()
    End Sub
End Class