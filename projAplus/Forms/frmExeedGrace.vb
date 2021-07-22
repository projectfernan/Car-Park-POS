Imports ADODB
Public Class frmExeedGrace
    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmExeedGrace_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdAccept_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        If txtPlate.Text = vbNullString Or cboVtype.Text = vbNullString Then
            MsgBox("Please complete the fields! ", vbExclamation, "Accept")
            txtPlate.Focus()
            Exit Sub
        End If
        viewAmt()
    End Sub

    Private Sub frmExeedGrace_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        loc()

        If conLocal() = True Then
            vehicleCharging(cboVtype)
        End If

        txtPlate.Text = vbNullString
        cboVtype.Text = vbNullString
        txtPlate.Focus()
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub



    Sub viewAmt()
        Dim Ov As Double = GETovernyt(CDate(EntryTime), Now, cboVtype.Text)
        Dim intAmt As Double = Get_IntervalAmt(cboVtype.Text, EntryTime, Now) + Ov
        Dim vatAmt As Double = VAT(intAmt)
        With frmMain
            .lblAmountDue.Text = MakeMoney(intAmt)  'intAmount(getMinMinutes, totalTime)
            .lblOvernigth.Text = Ov
            .lblVtype.Text = "EXCEED"
            .lblPlate.Text = UCase(txtPlate.Text)
            .lblTimeIn.Text = Format(CDate(EntryTime), "yyyy-MM-dd HH:mm:00")
            .lblTimeOut.Text = Format(Now, "yyyy-MM-dd HH:mm:59")
            .lblTotalTime.Text = TotalTime_FUNCTION(CDate(EntryTime), Now)
            .lblTotal.Text = MakeMoney(intAmt)
            P_TotalAmt = MakeMoney(intAmt)
            .lblVAT.Text = VAT(intAmt)
            .lblSubTotal.Text = subTotal(intAmt, vatAmt)
            .ToolTransact.Enabled = True

            PoleDisOpen()
            clear()
            displayTotal(MakeMoney(P_TotalAmt))
            PoleDisClose()

            trOpt = True
            TrLostOpt = True


            frmMain.txtTender.Enabled = True
            .txtAmtStat.Text = "TOTAL AMOUNT :"
            .txtBarcode.Text = vbNullString
            .txtBarcode.Enabled = False
            Me.Close()
        End With
    End Sub


End Class