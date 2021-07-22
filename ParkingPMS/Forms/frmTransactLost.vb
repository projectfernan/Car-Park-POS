Imports ADODB
Public Class frmTransactLost
    Private Sub frmTransactLost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMain.txtDbStat.Text = "Connected" Then
            vehicleCharging(cboVtype)
        End If
    End Sub

    Function LostCharge(ByVal vehicle As String) As Double
        Dim rs As New Recordset

        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblCharge where VehicleType = '" & vehicle & "'")
        If rs.EOF = False Then
            Dim lostC As Double = rs("LostCard").Value
            Return lostC
        Else
            Return 0
        End If
    End Function

    Function getTimein() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from timeinDB where CardCode = '" & HexCardID & "'", conSqlPOS, 1, 2)
        If rs.EOF = False Then
            tmeIn = rs("TimeIn").Value
            Return True
        Else
            Return False
        End If
    End Function

    Function ChargeMode() As Boolean
        If frmMain.txtMODE.Text = "FLAT RATE" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        iout = Now
        With frmMain
            .lblTimeIn.Text = Format(CDate(LostIn), "yyyy-MM-dd HH:mm:ss")
            .lblTimeOut.Text = Format(CDate(iout), "yyyy-MM-dd HH:mm:ss")

            If ChargeMode() = True Then
                Dim amtDue As Double = HourLy_RATE(cboVtype.Text, LostIn, iout)
                Dim ov As Double = GETovernyt(LostIn, iout, cboVtype.Text)
                Dim LC As Double = LostCharge(cboVtype.Text)
                Dim totalAmt As Double = totalAmount(amtDue, ov, LC)
                Dim vatAmt As Double = VAT(totalAmt)

                .lblAmountDue.Text = HourLy_RATE(cboVtype.Text, LostIn, iout) 'intAmount(getMinMinutes, totalTime)
                .lblOvernigth.Text = Format(Math.Round(ov, 2), "#,###,###.00")
                .lblLostCard.Text = Format(Math.Round(LC, 2), "#,###,###.00")
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(LostIn, iout)
                .lblTotal.Text = totalAmount(amtDue, ov, LC)
                .lblVAT.Text = VAT(totalAmt)
                .lblSubTotal.Text = subTotal(totalAmt, vatAmt)
                .ToolTransact.Enabled = True
                .cmdBt.Enabled = False
                .cmdLost.Enabled = False
                trOpt = True
                TrLostOpt = True
                frmFindLostCard.Close()
                Me.Close()
            Else
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, LostIn, iout)
                Dim LC As Double = LostCharge(cboVtype.Text)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", LC)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = Compute_FlateRATE(cboVtype.Text, LostIn, iout)
                .lblOvernigth.Text = "0.00"
                .lblLostCard.Text = Format(Math.Round(LC, 2), "#,###,###.00")
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(LostIn, iout)
                .lblTotal.Text = totalAmount(amtDueF, "0.00", LC)
                .lblVAT.Text = VAT(totalAmtF)
                .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)
                .ToolTransact.Enabled = True
                .cmdBt.Enabled = False
                .cmdLost.Enabled = False
                trOpt = True
                TrLostOpt = True
                frmFindLostCard.Close()
                Me.Close()
            End If
        End With
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

    Private Sub txtPlate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlate.TextChanged
        UCase(txtPlate.Text)
    End Sub
End Class