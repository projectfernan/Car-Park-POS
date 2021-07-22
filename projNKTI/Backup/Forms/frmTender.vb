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

    Sub print()
        With frmMain
            P_ORno = .lblORno.Text
            P_Permit = My.Settings.PERMIT
            P_TIN = My.Settings.TIN
            P_ACCR = My.Settings.ACCR
            P_CardCode = HexCardID
            P_EntTime = .lblTimeIn.Text
            P_ExtTime = .lblTimeOut.Text
            P_TotalTime = .lblTotalTime.Text
            P_Vehicle = .lblVtype.Text
            P_PlateNo = .lblPlate.Text

            P_HourLy = .lblAmountDue.Text
            P_Overnigth = .lblOvernigth.Text
            P_Lost = .lblLostCard.Text
            P_Total = .lblTotal.Text
            P_Vat = .lblVAT.Text
            P_Vatable = .lblSubTotal.Text
            P_Tendered = MakeMoney(Val(txtTender.Text))
            P_Change = MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text))

            P_Discount = .lblDiscount.Text

            P_Teller = .TxtOp.Text
            P_Station = .txtStation.Text
            P_Machine = My.Settings.MACHINE
            P_Serial = My.Settings.SERIAL
            P_date = Format(Now, "General Date")

            P_Msg = "* THIS SERVES AS AN OFFICIAL RECEIPT *"
        End With
    End Sub

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
                    If frmMain.lblVtype.Text = "CAR" And frmMain.lblTotal.Text = "0.00" Then
                    Else
                        print()
                        Prnt()
                    End If
                 
                    PoleDisOpen()
                    clear()
                    displayChange1k(MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text)), MakeMoney(Val(txtTender.Text)))
                    PoleDisClose()
                    .ShowDialog()
                    Me.Hide()
                    Me.Close()
                ElseIf Val(txtTender.Text) >= 100 Then
                    If frmMain.lblVtype.Text = "CAR" And frmMain.lblTotal.Text = "0.00" Then
                    Else
                        print()
                        Prnt()
                    End If

                    PoleDisOpen()
                    clear()
                    displayChange100(MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text)), MakeMoney(Val(txtTender.Text)))
                    PoleDisClose()
                    .ShowDialog()
                    Me.Hide()
                    Me.Close()
                Else
                    If frmMain.lblVtype.Text = "CAR" And frmMain.lblTotal.Text = "0.00" Then
                    Else
                        print()
                        Prnt()
                    End If

                    PoleDisOpen()
                    clear()
                    displayChange(MakeMoney(Change(frmMain.lblTotal.Text, txtTender.Text)), MakeMoney(Val(txtTender.Text)))
                    PoleDisClose()
                    .ShowDialog()
                    Me.Hide()
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

        If e.KeyCode = Keys.Escape Then
            Me.Close()
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

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTender.TextChanged

    End Sub
End Class