Public Class frmRefNo

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmRefNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      
    End Sub

    Private Sub frmRefNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()
    End Sub

    Private Sub frmRefNo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtDocNo.Text = vbNullString
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        S_Refnumber = txtDocNo.Text
        Me.Close()
    End Sub

    Private Sub txtDocNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            S_Refnumber = txtDocNo.Text
            Me.Close()
        End If
    End Sub

End Class