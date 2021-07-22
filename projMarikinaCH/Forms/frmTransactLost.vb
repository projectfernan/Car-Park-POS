Imports ADODB
Public Class frmTransactLost
    Public HrToFlat As Boolean = False
    Public FlatToHr As Boolean = False

    Private Sub frmTransactLost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmTransactLost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()
        If conLocal() = True Then
            vehicleCharging(cboVtype)
        End If
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        frmRefNo.txtDocNo.Text = "No Ref Number"
        If txtPlate.Text = vbNullString Or cboVtype.Text = vbNullString Then
            MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
            Exit Sub
        End If

        If Len(txtPlate.Text) < 6 Then
            MsgBox("Please complete the plate number! ", vbExclamation, "Plate Number")
            txtPlate.Focus()
            Exit Sub
        End If

        Dim strTimeout As String = Format(Now, "yyyy-MM-dd HH:mm")

        Transact(cboVtype.Text, txtPlate.Text, False, True, LostIn, strTimeout)

        If ChkChargType(cboVtype.Text) = True Then
            Me.Hide()
            Dim f As New frmRefNo
            f.ShowDialog()
            Me.Close()
        ElseIf ReceiptType = "Senior" Then
            Me.Hide()
            Dim f As New frmSenior
            f.ShowDialog()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtPlate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdGo_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub txtPlate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                txtPlate.Focus()
            Case 33 To 47
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

    Private Sub txtPlate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlate.TextChanged
        UCase(txtPlate.Text)
    End Sub

    Private Sub frmTransactLost_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        S_Refnumber = "No Ref Number"
        S_PayType = "Regular"
        cboVtype.Focus()
    End Sub

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = MainForm.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

End Class