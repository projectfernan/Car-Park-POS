Public Class frmManualTR

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmManualTR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPlate.Text = vbNullString Or cboVtype.Text = vbNullString Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the plate number! ", vbExclamation, "Plate Number")
                txtPlate.Focus()
                Exit Sub
            End If

            TransactManual()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmManualTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            vehicleCharging(cboVtype)
            dtFrm.Value = Now
            dtTo.Value = Now
        End If
    End Sub

    Private Sub frmManualTR_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'txtPlate.Text = vbNullString
        cboVtype.Text = vbNullString
        cboVtype.Focus()
    End Sub

    Function ChargeMode() As Boolean
        If frmMain.txtMODE.Text = "FLAT RATE" Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub TransactManual()
        With frmMain

            .lblTimeIn.Text = Format(CDate(dtFrm.Value.ToString), "yyyy-MM-dd HH:mm:ss")
            .lblTimeOut.Text = Format(CDate(dtTo.Value.ToString), "yyyy-MM-dd HH:mm:ss")

            HexCardID = "MTR00000"
            If ChargeMode() = True And cboVtype.Text <> "MOTOR" Then
                Dim ov As Double = GETovernyt(dtFrm.Value.ToString, dtTo.Value.ToString, cboVtype.Text)
                Dim amtDue As Double = HourLy_RATE(cboVtype.Text, dtFrm.Value.ToString, dtTo.Value.ToString)
                Dim totalAmt As Double = totalAmount(amtDue, ov, 0)
                Dim vatAmt As Double = VAT(totalAmt)

                .lblAmountDue.Text = MakeMoney(amtDue) 'intAmount(getMinMinutes, totalTime)
                .lblOvernigth.Text = MakeMoney(ov)
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value.ToString, dtTo.Value.ToString)
                .lblTotal.Text = totalAmount(amtDue, ov, 0)
                P_TotalAmt = totalAmount(amtDue, ov, 0)
                .lblVAT.Text = VAT(totalAmt)
                .lblSubTotal.Text = subTotal(totalAmt, vatAmt)
                .ToolTransact.Enabled = True
                '.cmdBt.Enabled = False
                '.cmdLost.Enabled = False

                PoleDisOpen()
                clear()
                displayTotal(MakeMoney(P_TotalAmt))
                PoleDisClose()

                trOpt = True
                TrLostOpt = True
                Me.Close()
            Else
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, dtFrm.Value.ToString, dtTo.Value.ToString)
                'Dim ovF As Double = overnyt(tmeIn, iout)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(amtDueF)
                .lblOvernigth.Text = "0.00"
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value.ToString, dtTo.Value.ToString)
                .lblTotal.Text = totalAmount(amtDueF, "0.00", 0)
                P_TotalAmt = totalAmount(amtDueF, 0, 0)
                .lblVAT.Text = VAT(totalAmtF)
                .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)
                .ToolTransact.Enabled = True
                '.cmdBt.Enabled = False
                '.cmdLost.Enabled = False

                PoleDisOpen()
                clear()
                displayTotal(MakeMoney(P_TotalAmt))
                PoleDisClose()

                trOpt = True
                TrLostOpt = True
                Me.Close()
            End If
        End With

    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If txtPlate.Text = vbNullString Or cboVtype.Text = vbNullString Then
            MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
            Exit Sub
        End If

        If Len(txtPlate.Text) < 6 Then
            MsgBox("Please complete the plate number! ", vbExclamation, "Plate Number")
            txtPlate.Focus()
            Exit Sub
        End If

        TransactManual()
    End Sub

End Class