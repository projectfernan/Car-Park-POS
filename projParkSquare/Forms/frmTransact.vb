Imports ADODB
Public Class frmTransact
    Public HrToFlat As Boolean = False
    Public FlatToHr As Boolean = False
    Public ChargeFlag As Boolean = False

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmTransact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Sub header()
        Dim w As Integer = lstList.Width / 2
        Dim w2 As Integer = w / 2
        lstList.Columns.Add("Key", w2, HorizontalAlignment.Left)
        lstList.Columns.Add("Charging", w2 + w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblcharge order By KeyCode")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("KeyCode").Value, lup)
                viewlst.SubItems.Add(rs("VehicleType").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function Get_Vtype(ByVal K As String) As String
        If conLocal() = False Then Return vbNullString

        Try
            Dim rs As New Recordset

            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblcharge where KeyCode = '" & K & "'")
            If rs.EOF = False Then
                Return rs("VehicleType").Value
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Return vbNullString
        End Try
    End Function

    Private Sub frmManualInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        S_Refnumber = "No Ref Number"
        S_PayType = "Regular"

        Me.txtPlate.CharacterCasing = CharacterCasing.Upper
        loc()

        lstList.Clear()
        header()

        If conLocal() = True Then
            lstList.Clear()
            header()
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Me.Close()
        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub detect()
        If d8_Card() = True Then
            tranEnable()
            'cboVtype.Focus()
            d8_Beep()

            PoleDisOpen()
            clear()
            display()
            PoleDisClose()

            lblMsg2.Visible = True
            lblMsg1.Visible = False
            tmrDetect.Enabled = False
        Else
            lblMsg2.Visible = False
            lblMsg1.Visible = True
        End If
    End Sub

    Function getTimein(ByVal HexID As String) As Boolean
        If conServer() = False Then Return False

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from timeinDB where CardCode = '" & HexID & "'", conSqlPOS, 1, 2)
        If rs.EOF = False Then
            tmeIn = Format(CDate(rs("TimeIn").Value), "yyyy-MM-dd HH:mm:00")
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

        ' Dim DaYdiff As Long = DateDiff(DateInterval.Day, EntIn, ExtOut) 'Extdt - Entdt
        Dim lup As Long

        Dim PetsaOut As Date

        PetsaOut = ExtOut

        For lup = 0 To DaYdiff
            Dim day As Long
            day = day + 1
            Dim Newpetsa As Date = PetsaIn.AddDays(day)

            If Newpetsa > CDate(ExtOut) Then
                Newpetsa = CDate(ExtOut)
            Else
                Newpetsa = Newpetsa
            End If

            If FlatDayCheck(Format(Newpetsa, "dddd"), Newpetsa.ToString) = True Or FlatHolidayCheck(Format(Newpetsa, "MM-dd"), Newpetsa.ToString) = True Then
                Dim NewPetsat As String = Format(Newpetsa, "yyyy-MM-dd " & Format(My.Settings.FlatCut, "HH:mm:ss"))
                Newpetsa = NewPetsat
                ChargeFlag = True
            End If
        Next
    End Sub

    Sub Transact(ByVal VehicleTyp As String)
        RESETinfo()
        frmRefNo.txtDocNo.Text = "No Ref Number"
        ChargeFlag = False
        NoGrace = False

        frmMain.txtSlot.Text = slot()

        iout = Format(Now, "yyyy-MM-dd HH:mm:00")
        If d8_Card() = True Then
            If getTimein(HexCardID) = True Then
                With frmMain

                    .lblTimeIn.Text = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")
                    .lblTimeOut.Text = Format(CDate(iout), "yyyy-MM-dd HH:mm:ss")

                    Dim dtToadd As Date = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")

                    Dim PetsaIn As Date

                    Dim Entdt As Long
                    Dim strInFrm As String = Format(CDate(tmeIn), "yyyy-MM-dd")

                    If frmMain.txtBussDate.Text < strInFrm Then
                        Entdt = Format(CDate(frmMain.txtBussDate.Text), "dd")
                        PetsaIn = Format(CDate(frmMain.txtBussDate.Text), "yyyy-MM-dd 23:59:59")
                    ElseIf frmMain.txtBussDate.Text >= strInFrm Then
                        Entdt = Format(CDate(tmeIn), "dd")
                        PetsaIn = CDate(tmeIn)
                    End If

                    Dim Extdt As Long = Format(CDate(iout), "dd")

                    Dim entPetsa As Date = Format(CDate(tmeIn), "yyyy-MM-dd")
                    Dim extPetsa As Date = Format(CDate(iout), "yyyy-MM-dd")

                    Dim DaYdiff As Long = DateDiff(DateInterval.Day, entPetsa, extPetsa)
                    Dim lup As Long

                    Dim HrToFlatAmt As Double = 0
                    Dim FlatToHrAmt As Double = 0
                    Dim FlatDayAmt As Double = 0
                    Dim FlatHolidayAmt As Double = 0
                    Dim SuccAmt As Double = 0
                    Dim FlatAmt As Double = 0

                    Dim PetsaOut As Date

                    PetsaOut = iout

                    ChkChargingSwitch(PetsaIn, iout)

                    If ReceiptType = "FlatRateOnly" Then
                        Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, tmeIn, iout)
                        'Dim ovF As Double = overnyt(tmeIn, iout)
                        Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                        Dim vatAmtF As Double = VAT(totalAmtF)

                        .lblAmountDue.Text = MakeMoney(amtDueF)
                        .lblOvernigth.Text = "0.00"
                        .lblVtype.Text = VehicleTyp
                        .lblPlate.Text = UCase(txtPlate.Text)
                        .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
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

                    If DaYdiff >= 1 And ChargeFlag = True Then

                        For lup = 0 To DaYdiff
                            Dim day As Long
                            day = day + 1
                            Dim Newpetsa As Date = PetsaIn.AddDays(day)

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

                                FlatDayAmt = FlatDayAmt + Compute_FlateRATE(VehicleTyp, PetsaIn.ToString, fcutOut)

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

                                SuccAmt = SuccAmt + HourLy_RATE(VehicleTyp, PetsaIn.ToString, hcutOut)

                                PetsaIn = hcutOut

                                Continue For
                            End If

                        Next

                        Dim totalAmtDue As Double = FlatDayAmt + FlatHolidayAmt + SuccAmt
                        Dim ov As Double = GETovernyt(tmeIn, iout, VehicleTyp)
                        Dim totalAmtF As Double = totalAmount(totalAmtDue, ov, 0)
                        Dim vatAmtF As Double = VAT(totalAmtF)

                        .lblAmountDue.Text = MakeMoney(totalAmtDue)
                        .lblOvernigth.Text = ov
                        .lblVtype.Text = VehicleTyp
                        .lblPlate.Text = UCase(txtPlate.Text)
                        .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
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

                    If FlatDayCheck(Format(CDate(My.Settings.BussDate), "dddd"), PetsaIn) = True Then
                        Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, tmeIn, iout)
                        'Dim ovF As Double = overnyt(tmeIn, iout)
                        Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                        Dim vatAmtF As Double = VAT(totalAmtF)

                        .lblAmountDue.Text = MakeMoney(amtDueF)
                        .lblOvernigth.Text = "0.00"
                        .lblVtype.Text = VehicleTyp
                        .lblPlate.Text = UCase(txtPlate.Text)
                        .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
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

                    If FlatHolidayCheck(Format(CDate(My.Settings.BussDate), "MM-dd"), PetsaIn) = True Then
                        Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, tmeIn, iout)
                        'Dim ovF As Double = overnyt(tmeIn, iout)
                        Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                        Dim vatAmtF As Double = VAT(totalAmtF)

                        .lblAmountDue.Text = MakeMoney(amtDueF)
                        .lblOvernigth.Text = "0.00"
                        .lblVtype.Text = VehicleTyp
                        .lblPlate.Text = UCase(txtPlate.Text)
                        .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
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

                        Dim amtDue As Double = HourLy_RATE(VehicleTyp, tmeIn, iout)
                        Dim ov As Double = GETovernyt(tmeIn, iout, VehicleTyp)
                        Dim totalAmt As Double = totalAmount(amtDue, ov, 0)
                        Dim vatAmt As Double = VAT(totalAmt)

                        .lblAmountDue.Text = MakeMoney(amtDue) 'intAmount(getMinMinutes, totalTime)
                        .lblOvernigth.Text = MakeMoney(ov)
                        .lblVtype.Text = VehicleTyp
                        .lblPlate.Text = UCase(txtPlate.Text)
                        .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
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
                        frmMain.txtTender.Enabled = True

                        trOpt = True
                        TrLostOpt = True

                        frmMain.txtTender.Enabled = True
                        .txtAmtStat.Text = "TOTAL AMOUNT :"

                        'Me.Close()
                    Else
                        Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, tmeIn, iout)
                        'Dim ovF As Double = overnyt(tmeIn, iout)
                        Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                        Dim vatAmtF As Double = VAT(totalAmtF)

                        .lblAmountDue.Text = MakeMoney(amtDueF)
                        .lblOvernigth.Text = "0.00"
                        .lblVtype.Text = VehicleTyp
                        .lblPlate.Text = UCase(txtPlate.Text)
                        .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
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
                    End If
                End With
            Else
                With frmMain
                    If d8_Loadpass() = True Then
                        If d8_Authen() = True Then
                            If readCard() = False Then
                                MsgBox("No record found!    ", vbExclamation, "Transaction")
                                Me.Close()
                                Exit Sub
                            End If

                            .lblTimeIn.Text = Format(EntryTime, "yyyy-MM-dd HH:mm:ss")
                            .lblTimeOut.Text = Format(iout, "yyyy-MM-dd HH:mm:ss")

                            Dim dtToadd As Date = Format(CDate(EntryTime), "yyyy-MM-dd HH:mm:ss")

                            Dim Entdt As Long = Format(CDate(EntryTime), "dd")
                            Dim Extdt As Long = Format(CDate(iout), "dd")

                            Dim DaYdiff As Long = Extdt - Entdt
                            Dim lup As Long

                            Dim HrToFlatAmt As Double = 0
                            Dim FlatToHrAmt As Double = 0
                            Dim FlatDayAmt As Double = 0
                            Dim FlatHolidayAmt As Double = 0
                            Dim SuccAmt As Double = 0
                            Dim FlatAmt As Double = 0

                            Dim PetsaIn As Date
                            Dim PetsaOut As Date

                            PetsaIn = EntryTime

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

                                        Dim Hcutext As Date = fcutOut
                                        If Hcutext > OutCut Then
                                            fcutOut = OutCut
                                        End If

                                        FlatDayAmt = FlatDayAmt + Compute_FlateRATE(VehicleTyp, PetsaIn.ToString, fcutOut)

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

                                        SuccAmt = SuccAmt + HourLy_RATE(VehicleTyp, PetsaIn.ToString, hcutOut)

                                        PetsaIn = hcutOut

                                        Continue For
                                    End If

                                Next

                                Dim totalAmtDue As Double = FlatDayAmt + FlatHolidayAmt + SuccAmt
                                Dim ov As Double = GETovernyt(tmeIn, iout, VehicleTyp)
                                Dim totalAmtF As Double = totalAmount(totalAmtDue, ov, 0)
                                Dim vatAmtF As Double = VAT(totalAmtF)

                                .lblAmountDue.Text = MakeMoney(totalAmtDue)
                                .lblOvernigth.Text = ov
                                .lblVtype.Text = VehicleTyp
                                .lblPlate.Text = UCase(txtPlate.Text)
                                .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
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

                            If FlatDayCheck(Format(CDate(iout), "dddd"), PetsaIn) = True Then
                                Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, EntryTime, iout)
                                'Dim ovF As Double = overnyt(tmeIn, iout)
                                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                                Dim vatAmtF As Double = VAT(totalAmtF)

                                .lblAmountDue.Text = MakeMoney(amtDueF)
                                .lblOvernigth.Text = "0.00"
                                .lblVtype.Text = VehicleTyp
                                .lblPlate.Text = UCase(txtPlate.Text)
                                .lblTotalTime.Text = TotalTime_FUNCTION(EntryTime, iout)
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

                            If FlatHolidayCheck(Format(CDate(iout), "MM-dd"), PetsaIn) = True Then
                                Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, EntryTime, iout)
                                'Dim ovF As Double = overnyt(tmeIn, iout)
                                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                                Dim vatAmtF As Double = VAT(totalAmtF)

                                .lblAmountDue.Text = MakeMoney(amtDueF)
                                .lblOvernigth.Text = "0.00"
                                .lblVtype.Text = VehicleTyp
                                .lblPlate.Text = UCase(txtPlate.Text)
                                .lblTotalTime.Text = TotalTime_FUNCTION(EntryTime, iout)
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
                                Dim ov As Double = GETovernyt(EntryTime, iout, VehicleTyp)
                                Dim amtDue As Double = HourLy_RATE(VehicleTyp, EntryTime, iout)
                                Dim totalAmt As Double = totalAmount(amtDue, ov, 0)
                                Dim vatAmt As Double = VAT(totalAmt)

                                .lblAmountDue.Text = MakeMoney(amtDue)  'intAmount(getMinMinutes, totalTime)
                                .lblOvernigth.Text = MakeMoney(ov)
                                .lblVtype.Text = VehicleTyp
                                .lblPlate.Text = UCase(txtPlate.Text)
                                .lblTotalTime.Text = TotalTime_FUNCTION(EntryTime, iout)
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

                                frmMain.txtTender.Enabled = True
                                .txtAmtStat.Text = "TOTAL AMOUNT :"
                                'Me.Close()
                            Else
                                Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, EntryTime, iout)
                                'Dim ovF As Double = overnyt(tmeIn, iout)
                                Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                                Dim vatAmtF As Double = VAT(totalAmtF)

                                .lblAmountDue.Text = MakeMoney(amtDueF)
                                .lblOvernigth.Text = "0.00"
                                .lblVtype.Text = VehicleTyp
                                .lblPlate.Text = UCase(txtPlate.Text)
                                .lblTotalTime.Text = TotalTime_FUNCTION(EntryTime, iout)
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
                            End If
                        End If
                    End If
                End With
            End If
        Else
            MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
        End If
    End Sub

    Function ChkChargType(ByVal Ky As String) As Boolean
        If conLocal() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblcharge where KeyCode = '" & Ky & "'")
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

    Private Sub txtPlate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlate.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim vtp As String = Get_Vtype("F1")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                If ChkChargType("F1") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F2 Then
            Dim vtp As String = Get_Vtype("F2")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                If ChkChargType("F2") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            Dim vtp As String = Get_Vtype("F3")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F3") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Dim vtp As String = Get_Vtype("F4")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F4") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            Dim vtp As String = Get_Vtype("F5")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F5") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            Dim vtp As String = Get_Vtype("F6")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F6") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            Dim vtp As String = Get_Vtype("F7")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F7") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            Dim vtp As String = Get_Vtype("F8")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F8") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            Dim vtp As String = Get_Vtype("F9")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F9") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            Dim vtp As String = Get_Vtype("F10")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F10") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            Dim vtp As String = Get_Vtype("F11")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F11") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            Dim vtp As String = Get_Vtype("F12")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F12") = True Then
                    Transact(vtp)
                    frmRefNo.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp)
                End If
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Function readCard() As Boolean
        Try
            tmeIn = Trim(d8_Read()) + ":00"
            EntryTime = vbNullString
            EntryTime = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub tmrDetect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetect.Tick
        detect()
    End Sub

    Private Sub txtPlate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlate.TextChanged

    End Sub

    Private Sub frmTransact_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        S_Refnumber = "No Ref Number"
        S_PayType = "Regular"
    End Sub
End Class