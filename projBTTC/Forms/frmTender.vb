Public Class frmTender
    Function Change(ByVal total As Double, ByVal tender As Double) As Double
        Dim ch As Double
        ch = tender - total
        Change = MakeMoney(ch)
    End Function

    Function tender(ByVal total As String) As Boolean
        If Val(txtTender.Text) < Val(total) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        If txtTender.Text = vbNullString Then
            MsgBox("Plese enter tender amount!    ", vbExclamation, "Tender amount")
            Exit Sub
        End If
        If tender(frmMain.lblTotal.Text) = True Then
            With frmTenderChange
                .lblChange.Text = MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text))
                .lblTender.Text = MakeMoney(Val(txtTender.Text))
                .txtTotal.Text = MakeMoney(frmMain.lblTotal.Text)
                If Val(txtTender.Text) >= 1000 Then
                    PoleDisOpen()
                    clear()
                    displayChange1k(MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text)), MakeMoney(Val(txtTender.Text)))
                    PoleDisClose()
                    .ShowDialog()
                    Me.Close()
                ElseIf Val(txtTender.Text) >= 100 Then
                    PoleDisOpen()
                    clear()
                    displayChange100(MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text)), MakeMoney(Val(txtTender.Text)))
                    PoleDisClose()
                    .ShowDialog()
                    Me.Close()
                Else
                    PoleDisOpen()
                    clear()
                    displayChange(MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text)), MakeMoney(Val(txtTender.Text)))
                    PoleDisClose()
                    .ShowDialog()
                    Me.Close()
                End If
            End With
        Else
            txtTender.Text = vbNullString
            txtTender.Focus()
        End If
    End Sub

    Private Sub txtTender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTender.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdGo_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub txtTender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTender.KeyPress
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub frmTender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.txtSlot.Text = slot()
    End Sub

    Private Sub frmTender_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtTender.Text = vbNullString
        txtTender.Focus()
    End Sub
End Class