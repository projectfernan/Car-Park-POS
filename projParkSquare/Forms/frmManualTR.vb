Imports ADODB
Public Class frmManualTR
    Public HrToFlat As Boolean = False
    Public FlatToHr As Boolean = False
    Public ChargeFlag As Boolean = False
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



            If ChkChargType(cboVtype.Text) = True Then
                TransactManual()
                Me.Hide()
                frmRefNo.ShowDialog()
                Me.Close()
            Else
                TransactManual()
                'Me.Hide()
                Me.Close()
            End If
            
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmManualTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        S_Refnumber = "NO REFERENCE NUMBER"
        S_PayType = "Manual"

        If conLocal() = True Then
            vehicleCharging(cboVtype)
            dtFrm.Value = Now
            dtTo.Value = Now
        End If

    End Sub

    Private Sub frmManualTR_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        S_Refnumber = "NO REFERENCE NUMBER"
        S_PayType = "Manual"
        ReceiptType = vbNullString

        txtPlate.Text = vbNullString
        cboVtype.Text = vbNullString
        txtPlate.Focus()
    End Sub

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

    Sub ChkChargingSwitch(ByVal EntIn As Date, ByVal ExtOut As Date)
        Dim dtToadd As Date = Format(CDate(EntIn), "yyyy-MM-dd HH:mm:ss")

        Dim PetsaIn As Date
        Dim Entdt As Long
        Dim strInFrm As String = Format(CDate(EntIn), "yyyy-MM-dd")
        If frmMain.txtBussDate.Text >= strInFrm Then
            Entdt = Format(CDate(EntIn), "dd")
            PetsaIn = EntIn
        ElseIf frmMain.txtBussDate.Text < strInFrm Then
            Entdt = Format(CDate(frmMain.txtBussDate.Text), "dd")
            PetsaIn = frmMain.txtBussDate.Text & " 23:59:59"
        End If

        Dim Extdt As Long = Format(CDate(ExtOut), "dd")

        Dim entPetsa As Date = Format(EntIn, "yyyy-MM-dd")
        Dim extPetsa As Date = Format(ExtOut, "yyyy-MM-dd")

        Dim DaYdiff As Long = DateDiff(DateInterval.Day, entPetsa, extPetsa)

        Dim lup As Long


        Dim PetsaOut As Date

        PetsaOut = ExtOut

        Dim Newpetsa As Date = EntIn
        For lup = 0 To DaYdiff
            Dim day As Long
            day = day + 1
            ' dtToadd.AddDays(day)

            If Newpetsa > CDate(ExtOut) Then
                Newpetsa = CDate(ExtOut)
            Else
                Newpetsa = Newpetsa
            End If

            If FlatDayCheck(Format(Newpetsa, "dddd"), Newpetsa.ToString) = True Or FlatHolidayCheck(Format(Newpetsa, "MM-dd"), Newpetsa.ToString) = True Then
                'Dim NewPetsat As String = Format(Newpetsa, "yyyy-MM-dd " & Format(My.Settings.FlatCut, "HH:mm:ss"))
                ChargeFlag = True
            End If
            Newpetsa = PetsaIn.AddDays(day)
        Next
    End Sub

    Sub TransactManual()
        RESETinfo()
        frmRefNo.txtDocNo.Text = "No Ref Number"
        ChargeFlag = False
        NoGrace = False

        With frmMain

            .lblTimeIn.Text = Format(CDate(dtFrm.Value.ToString), "yyyy-MM-dd HH:mm:ss")
            .lblTimeOut.Text = Format(CDate(dtTo.Value.ToString), "yyyy-MM-dd HH:mm:ss")


            HexCardID = "MTR00000"

            Dim dtToadd As Date
            Dim PetsaIn As Date

            Dim Entdt As Long
            Dim strInFrm As String = Format(dtFrm.Value, "yyyy-MM-dd")
         
            If frmMain.txtBussDate.Text < strInFrm Then
                Entdt = Format(CDate(frmMain.txtBussDate.Text), "dd")
                PetsaIn = Format(CDate(frmMain.txtBussDate.Text), "yyyy-MM-dd 23:59:59")
            ElseIf frmMain.txtBussDate.Text >= strInFrm Then
                Entdt = Format(dtFrm.Value, "dd")
                PetsaIn = dtFrm.Value
            End If

            Dim Extdt As Long = Format(dtTo.Value, "dd")

            Dim entPetsa As Date = Format(dtFrm.Value, "yyyy-MM-dd")
            Dim extPetsa As Date = Format(dtTo.Value, "yyyy-MM-dd")

            Dim DaYdiff As Long = DateDiff(DateInterval.Day, entPetsa, extPetsa)
            Dim lup As Long

            Dim HrToFlatAmt As Double = 0
            Dim FlatToHrAmt As Double = 0
            Dim FlatDayAmt As Double = 0
            Dim FlatHolidayAmt As Double = 0
            Dim SuccAmt As Double = 0
            Dim FlatAmt As Double = 0


            Dim PetsaOut As Date

            'PetsaIn = dtFrm.Value

            If ReceiptType = "FlatRateOnly" Then
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, dtFrm.Value, dtTo.Value)
                'Dim ovF As Double = overnyt(tmeIn, iout)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(amtDueF)
                .lblOvernigth.Text = "0.00"
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value, dtTo.Value)
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

                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                Exit Sub
            End If

            ChkChargingSwitch(PetsaIn, dtTo.Value)

            If DaYdiff >= 1 And ChargeFlag = True Then

                For lup = 0 To DaYdiff
                    Dim day As Long
                    day = day + 1
                    Dim Newpetsa As Date = PetsaIn.AddDays(day)

                    If Newpetsa > dtTo.Value Then
                        Newpetsa = dtTo.Value
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

                    If Newpetsa > dtTo.Value Then
                        PetsaOut = dtTo.Value
                    Else
                        PetsaOut = Newpetsa
                    End If

                    If lup = DaYdiff Then
                        PetsaOut = dtTo.Value
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

                Dim totalAmtDue As Double = FlatDayAmt + FlatHolidayAmt + SuccAmt
                Dim ov As Double = GETovernyt(dtFrm.Value.ToString, dtTo.Value.ToString, cboVtype.Text)
                Dim totalAmtF As Double = totalAmount(totalAmtDue, ov, 0)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(totalAmtDue)
                .lblOvernigth.Text = ov
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value.ToString, dtTo.Value.ToString)
                .lblTotal.Text = totalAmount(totalAmtDue, ov, 0)
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

                'Me.Close()
                Exit Sub
            End If


            If FlatDayCheck(Format(My.Settings.BussDate, "dddd"), PetsaIn) = True Then
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
                'Dim ovF As Double = overnyt(dtFrm.Value.ToString, dtTo.Value.ToString)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(amtDueF)
                .lblOvernigth.Text = "0.00"
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
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

                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                'Me.Close()
                Exit Sub
            End If

            If FlatHolidayCheck(Format(My.Settings.BussDate, "MM-dd"), PetsaIn) = True Then
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
                'Dim ovF As Double = overnyt(dtFrm.Value.ToString, dtTo.Value.ToString)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(amtDueF)
                .lblOvernigth.Text = "0.00"
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
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

                frmMain.txtTender.Enabled = True
                .txtAmtStat.Text = "TOTAL AMOUNT :"
                'Me.Close()
                Exit Sub
            End If

            If ChargeMode() = True Then
                Dim amtDue As Double = HourLy_RATE(cboVtype.Text, dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
                Dim ov As Double = GETovernyt(dtFrm.Value.ToString, dtTo.Value.ToString.ToString, cboVtype.Text)
                Dim totalAmt As Double = totalAmount(amtDue, ov, 0)
                Dim vatAmt As Double = VAT(totalAmt)

                .lblAmountDue.Text = MakeMoney(amtDue) 'intAmount(getMinMinutes, totalTime)
                .lblOvernigth.Text = MakeMoney(ov)
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
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

                .txtTender.Enabled = True
                'Me.Close()
            Else
                Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
                'Dim ovF As Double = overnyt(dtFrm.Value.ToString, dtTo.Value.ToString)
                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                Dim vatAmtF As Double = VAT(totalAmtF)

                .lblAmountDue.Text = MakeMoney(amtDueF)
                .lblOvernigth.Text = "0.00"
                .lblVtype.Text = cboVtype.Text
                .lblPlate.Text = UCase(txtPlate.Text)
                .lblTotalTime.Text = TotalTime_FUNCTION(dtFrm.Value.ToString, dtTo.Value.ToString.ToString)
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
                .txtTender.Enabled = True
                'Me.Close()
            End If
        End With

    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

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
                    ReceiptType = rs("ChargeType").Value
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

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



        If ChkChargType(cboVtype.Text) = True Then
            TransactManual()
            Me.Hide()
            frmRefNo.ShowDialog()
            Me.Close()
        Else
            TransactManual()
            Me.Close()
        End If

    End Sub

End Class