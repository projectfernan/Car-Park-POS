Public Class frmTender
    Function Change(ByVal total As String, ByVal tender As String) As String
        Dim ch As String
        ch = tender - total
        Change = Format(Math.Round(Val(ch), 2), "0.00")
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
                .lblChange.Text = Change(frmMain.lblTotal.Text, txtTender.Text)
                .lblTender.Text = Format(Math.Round(Val(txtTender.Text), 2), "0.00")
                '.txtTotal.Text = Format(Math.Round(TotalAmt, 2), "0.00")
                If Val(txtTender.Text) >= 1000 Then
                    PoleDisOpen()
                    clear()
                    displayChange1k(Change(frmMain.lblTotal.Text, txtTender.Text), Format(Math.Round(Val(txtTender.Text), 2), "0.00"))
                    PoleDisClose()
                    .ShowDialog()
                    Me.Close()
                Else
                    PoleDisOpen()
                    clear()
                    displayChange(Change(frmMain.lblTotal.Text, txtTender.Text), Format(Math.Round(Val(txtTender.Text), 2), "0.00"))
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
            If txtTender.Text = vbNullString Then
                MsgBox("Plese enter tender amount!    ", vbExclamation, "Tender amount")
                Exit Sub
            End If
            If tender(frmMain.lblTotal.Text) = True Then
                With frmTenderChange
                    .lblChange.Text = Change(frmMain.lblTotal.Text, txtTender.Text)
                    .lblTender.Text = Format(Math.Round(Val(txtTender.Text), 2), "0.00")
                    .txtTotal.Text = Format(Math.Round(Val(frmMain.lblTotal.Text), 2), "0.00")
                    If Val(txtTender.Text) >= 1000 Then
                        PoleDisOpen()
                        clear()
                        displayChange1k(Change(frmMain.lblTotal.Text, txtTender.Text), Format(Math.Round(Val(txtTender.Text), 2), "0.00"))
                        PoleDisClose()
                        .ShowDialog()
                        Me.Close()
                    Else
                        PoleDisOpen()
                        clear()
                        displayChange(Change(frmMain.lblTotal.Text, txtTender.Text), Format(Math.Round(Val(txtTender.Text), 2), "0.00"))
                        PoleDisClose()
                        .ShowDialog()
                        Me.Close()
                    End If
                End With
            Else
                txtTender.Text = vbNullString
                txtTender.Focus()
            End If
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

    End Sub

    Private Sub frmTender_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtTender.Text = vbNullString
        txtTender.Focus()
    End Sub
End Class