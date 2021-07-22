Imports ADODB
Public Class frmManualLost

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Function LostCharge(ByVal vehicle As String) As Double
        If conLocal() = False Then Return 0

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

    Sub ManualLost()
        With frmMain

            .lblTimeIn.Text = Format(CDate(Now), "yyyy-MM-dd HH:mm:ss")
            .lblTimeOut.Text = Format(CDate(Now), "yyyy-MM-dd HH:mm:ss")

            Dim LC As Double = LostCharge(cboVtype.Text)
            Dim vatAmt As Double = VAT(LC)
            HexCardID = "MLC00000"
            .lblAmountDue.Text = "0.00"
            .lblOvernigth.Text = "0.00"
            .lblVtype.Text = cboVtype.Text
            .lblPlate.Text = UCase(txtPlate.Text)
            .lblTotalTime.Text = TotalTime_FUNCTION(Now, Now)
            .lblTotal.Text = MakeMoney(LC)
            .lblLostCard.Text = MakeMoney(LC)
            P_TotalAmt = VAT(LC)
            .lblVAT.Text = VAT(LC)
            .lblSubTotal.Text = subTotal(LC, vatAmt)
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
        End With
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        ManualLost()
    End Sub

    Private Sub frmManualLost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            ManualLost()
        End If
    End Sub

    Private Sub frmManualLost_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If conLocal() = True Then
            vehicleCharging(cboVtype)
        End If
    End Sub

    Private Sub frmManualLost_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtPlate.Text = vbNullString
        cboVtype.Text = vbNullString
        cboVtype.Focus()
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

End Class