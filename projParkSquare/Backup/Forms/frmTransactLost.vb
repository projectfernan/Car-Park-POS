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
        If conLocal() = True Then
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

    Function FlatDayCheck(ByVal DayToday As String, ByVal dtstr As Date) As Boolean
        Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")
        Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")
        Dim OutCut As Date = Format(dtstr, "HH:mm:ss")

        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblflatday where FlatRateDay = '" & DayToday & "'")
            If rs.EOF = False Then
                If OutCut >= Hcut Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function FlatHolidayCheck(ByVal DayToday As String, ByVal dtstr As Date) As Boolean
        Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")
        Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")
        Dim OutCut As Date = Format(dtstr, "HH:mm:ss")

        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblholidayflat where HolidayDate = '" & DayToday & "'")
            If rs.EOF = False Then
                If OutCut >= Hcut Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function ChkChargType(ByVal Ky As String) As Boolean
        If conLocal() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblcharge where VehicleType = '" & Ky & "'")
            If rs.EOF = False Then
                If rs("ChargeType").Value = "Coupon" Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub TransactLost()
        RESETinfo()
        NoGrace = False

        iout = Format(Now, "yyyy-MM-dd HH:mm:00")
        With frmMain
            .lblTimeIn.Text = Format(CDate(LostIn), "yyyy-MM-dd HH:mm:ss")
            .lblTimeOut.Text = Format(CDate(iout), "yyyy-MM-dd HH:mm:ss")

            Dim dtToadd As Date = Format(CDate(LostIn), "yyyy-MM-dd 06:01:00")

            Dim Entdt As Long = Format(CDate(LostIn), "dd")
            Dim Extdt As Long = Format(CDate(iout), "dd")

            Dim DaYdiff As Long = Extdt - Entdt
            Dim lup As Long

            Dim LostAmt As Double = LostCharge(cboVtype.Text)
            Dim HrToFlatAmt As Double = 0
            Dim FlatToHrAmt As Double = 0
            Dim FlatDayAmt As Double = 0
            Dim FlatHolidayAmt As Double = 0
            Dim SuccAmt As Double = 0
            Dim FlatAmt As Double = 0

            Dim PetsaIn As Date
            Dim PetsaOut As Date

            PetsaIn = LostIn

            If DaYdiff >= 1 Then

                For lup = 0 To DaYdiff
                    Dim day As Long
                    day = day + 1
                    Dim Newpetsa As Date = dtToadd.AddDays(day)

                    If Newpetsa > CDate(iout) Then
                        Newpetsa = CDate(iout)
                    Else
                        Newpetsa = Newpetsa
                    End If

                    If FlatDayCheck(Format(Newpetsa, "dddd"), Newpetsa.ToString) = True Or FlatHolidayCheck(Format(Newpetsa, "MM-dd"), Newpetsa.ToString) = True Then
                        Dim NewPetsat As String = Format(Newpetsa, "yyyy-MM-dd " & Format(My.Settings.FlatCut, "HH:mm:ss"))
                        Newpetsa = NewPetsat
                    Else
                        Dim NewPetsat As String = Format(Newpetsa, "yyyy-MM-dd " & Format(My.Settings.HourlyCut, "HH:mm:ss"))
                        Newpetsa = NewPetsat
                    End If

                    If Newpetsa > CDate(iout) Then
                        PetsaOut = CDate(iout)
                    Else
                        PetsaOut = Newpetsa
                    End If

                    If lup = DaYdiff Then
                        PetsaOut = CDate(iout)
                    End If


                    If FlatDayCheck(Format(PetsaIn, "dddd"), PetsaIn.ToString) = True Or FlatHolidayCheck(Format(PetsaIn, "MM-dd"), PetsaIn.ToString) = True Then
                        Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")
                        Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")

                        Dim OutCut As Date = Format(CDate(PetsaOut.ToString), "yyyy-MM-dd HH:mm:ss")

                        Dim fcutOut As String = Format(CDate(PetsaOut.ToString), "yyyy-MM-dd") & " " & Format(Fcut, "HH:mm:ss")

                        If lup = DaYdiff Then
                            fcutOut = OutCut
                        End If

                        FlatDayAmt = FlatDayAmt + Compute_FlateRATE(cboVtype.Text, PetsaIn.ToString, fcutOut)

                        PetsaIn = fcutOut

                        Continue For
                    Else
                        Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")
                        Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")

                        Dim OutCut As Date = Format(CDate(PetsaOut.ToString), "yyyy-MM-dd HH:mm:ss")

                        Dim hcutOut As String = Format(CDate(PetsaOut.ToString), "yyyy-MM-dd") & " " & Format(Hcut, "HH:mm:ss")

                        Dim Hcutext As Date = hcutOut
                        If Hcutext > OutCut Then
                            hcutOut = OutCut
                        End If

                        If lup = DaYdiff Then
                            hcutOut = OutCut
                        End If

                        SuccAmt = SuccAmt + HourLy_RATE(cboVtype.Text, PetsaIn.ToString, hcutOut)

                        PetsaIn = hcutOut

                        Continue For
                    End If

                Next

                Dim totalAmtDue As Double = FlatDayAmt + FlatHolidayAmt + SuccAmt + LostAmt
                Dim ov As Double = GETovernyt(LostIn, iout, cboVtype.Text)

                Dim totalAmtF As Double = totalAmount(totalAmtDue, ov, LostAmt)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(totalAmtDue)
                .lblOvernigth.Text = ov
                .lblLostCard.Text = MakeMoney(LostAmt)
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(LostIn, iout)
                .lblTotal.Text = totalAmount(totalAmtDue, ov, LostAmt)
                P_TotalAmt = totalAmount(totalAmtF, 0, 0)
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

                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                frmFindLostCard.Close()
                'Me.Close()
                Exit Sub
            End If

            If FlatDayCheck(Format(CDate(iout), "dddd"), PetsaIn) = True Then
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, LostIn, iout)
                'Dim ovF As Double = overnyt(lostin, iout)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", LostAmt)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(amtDueF)
                .lblOvernigth.Text = "0.00"
                .lblLostCard.Text = MakeMoney(LostAmt)
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(LostIn, iout)
                .lblTotal.Text = totalAmount(amtDueF, "0.00", LostAmt)
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

                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                frmFindLostCard.Close()
                'Me.Close()
                Exit Sub
            End If

            If FlatHolidayCheck(Format(CDate(iout), "MM-dd"), PetsaIn) = True Then
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, LostIn, iout)
                'Dim ovF As Double = overnyt(lostin, iout)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", LostAmt)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(amtDueF)
                .lblOvernigth.Text = "0.00"
                .lblLostCard.Text = MakeMoney(LostAmt)
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(LostIn, iout)
                .lblTotal.Text = totalAmount(amtDueF, "0.00", LostAmt)
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

                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                frmFindLostCard.Close()
                'Me.Close()
                Exit Sub
            End If

            If ChargeMode() = True Then
                Dim ov As Double = GETovernyt(LostIn, iout, cboVtype.Text)
                Dim amtDue As Double = HourLy_RATE(cboVtype.Text, LostIn, iout)

                Dim totalAmt As Double = totalAmount(amtDue, ov, LostAmt)
                Dim vatAmt As Double = VAT(totalAmt)

                .lblAmountDue.Text = HourLy_RATE(cboVtype.Text, LostIn, iout) 'intAmount(getMinMinutes, totalTime)
                .lblOvernigth.Text = MakeMoney(ov)
                .lblLostCard.Text = MakeMoney(LostAmt)
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(LostIn, iout)
                .lblTotal.Text = totalAmount(amtDue, ov, LostAmt)
                P_TotalAmt = totalAmount(amtDue, 0, 0)
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
                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                frmFindLostCard.Close()
                'Me.Close()
            Else
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, LostIn, iout)

                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", LostAmt)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = Compute_FlateRATE(cboVtype.Text, LostIn, iout)
                .lblOvernigth.Text = "0.00"
                .lblLostCard.Text = MakeMoney(LostAmt)
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(LostIn, iout)
                .lblTotal.Text = totalAmount(amtDueF, "0.00", LostAmt)
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

                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                frmFindLostCard.Close()
                'Me.Close()
            End If
        End With
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

        TransactLost()

        If ChkChargType(cboVtype.Text) = True Then
            Me.Hide()
            frmRefNo.ShowDialog()
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

    Private Sub txtPlate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlate.TextChanged
        UCase(txtPlate.Text)
    End Sub

    Private Sub frmTransactLost_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        S_Refnumber = "No Ref Number"
        S_PayType = "Regular"
        cboVtype.Focus()
    End Sub

    Private Sub cboVtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVtype.SelectedIndexChanged

    End Sub
End Class