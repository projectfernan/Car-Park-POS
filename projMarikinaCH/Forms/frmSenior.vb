Public Class frmSenior

    Private Sub frmSenior_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDocNo.Text = vbNullString Or txtName.Text = vbNullString Then
                MessageBox.Show("Please complete all details required!", "Senior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Dim txt As Control

                For Each txt In Panel1.Controls
                    If TypeOf txt Is TextBox Then

                        If txt.Text = "" Then
                            If txtDocNo.Text = "" And txtName.Text = "" Then
                                txtDocNo.Focus()
                                Exit For
                            End If

                            txt.Focus()

                            Exit For
                        End If
                    End If
                Next txt

                Exit Sub
            End If

            S_Refnumber = txtDocNo.Text
            S_SeniorName = txtName.Text
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            S_Refnumber = ""
            S_SeniorName = ""
            PD_Welcome()
            kansela()
            Me.Close()
        End If
    End Sub

    Private Sub frmSenior_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()
    End Sub

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = MainForm.CamEntry.Width + 17
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

    Private Sub txtDocNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                txtDocNo.Focus()
            Case 33 To 44
                e.KeyChar = vbNullString
            Case 46 To 47
                e.KeyChar = vbNullString
            Case 91 To 96
                e.KeyChar = vbNullString
            Case 58 To 64
                e.KeyChar = vbNullString
            Case 123 To 126
                e.KeyChar = vbNullString
            Case 8, 9, 27, 32  'backspace, tab, esc, space
        End Select
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                txtName.Focus()
            Case 33 To 43
                e.KeyChar = vbNullString
            Case 45
                e.KeyChar = vbNullString
            Case 47
                e.KeyChar = vbNullString
            Case 91 To 96
                e.KeyChar = vbNullString
            Case 58 To 64
                e.KeyChar = vbNullString
            Case 123 To 126
                e.KeyChar = vbNullString
            Case 8, 9, 27, 32  'backspace, tab, esc, space
        End Select
    End Sub
End Class