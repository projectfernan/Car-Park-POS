Imports ADODB
Module CHARGING_FUNCTION
    Public iout As Date
    Public LostIn As Date
    'Data Strings for IN and Out
    Public EntryTime As Date

    Public dteIn As String
    Public dteOut As String
    Public tmeIn As String
    Public tmeOut As String
    Public OVcount As Integer

    Public Over_count As Long = 0
    Public Count_Days As Long = 0

    'Public P_TotalAmt As Double
    Public OV_LessHr As Long = 0

    Public OVtotalDue As Double = 0

    Public NoGrace As Boolean = False

    Public TotalTimeInt As Integer

    Public S_CouponName As String = vbNullString
    Public S_SeniorName As String = vbNullString
    Public S_Refnumber As String = vbNullString
    Public S_PayType As String = vbNullString

    Public ReceiptType As String = vbNullString


    Dim OVcharge As Double = 0
    Dim OVStartTme As DateTime
    Dim OVEndTme As DateTime
    Dim HRtotalDue As Double = 0
    Dim OVtotalMin As Long = 0
    Dim OVtotalHr As Long = 0
    Dim OVtoReg As Boolean = False

    Public origInOutMins As Long = 0

    Public HrToFlat As Boolean = False
    Public FlatToHr As Boolean = False
    Public ChargeFlag As Boolean = False

    Public Function TotalTime_FUNCTION(ByVal tmeIN As Date, ByVal tmeOUT As Date) As String
        Try
            Dim MIN As Long = DateDiff("n", tmeIN, tmeOUT)
            Dim hh As Integer = DateDiff("h", tmeIN, tmeOUT)
            Dim dd As Integer = DateDiff(DateInterval.Day, tmeIN, tmeOUT)
            Dim ss As Integer = DateDiff(DateInterval.Second, tmeIN, tmeOUT)

            If MIN > 0 Then
                If MIN >= 60 And MIN < 1440 Then
                    Dim tHH As Long = hh
                    Dim tExcessMin As Long = CLng(MIN Mod 60)
                    Dim tsEc As Long = CLng(ss Mod 60)

                    If tExcessMin >= 1 Then
                        TotalTimeInt = hh + 1
                    Else
                        TotalTimeInt = hh
                    End If

                    Return "0D, " & tHH & "H, " & tExcessMin & "m, " & tsEc & "s"
                ElseIf MIN >= 1440 Then
                    Dim tDD As Long = dd
                    Dim tExcessMin As Long = CLng(MIN Mod 60)
                    Dim tExcessHr As Long = CLng(hh Mod 24)
                    Dim tsEc As Long = CLng(ss Mod 60)

                    If tExcessMin >= 1 Then
                        TotalTimeInt = hh + 1
                    Else
                        TotalTimeInt = hh
                    End If
                    Return tDD & "D, " & tExcessHr & "H, " & tExcessMin & "m, " & tsEc & "s"
                Else
                    Dim tsEc As Long = CLng(ss Mod 60)
                    TotalTimeInt = 1
                    Return "0D, " & "0H, " & MIN & "m, " & tsEc & "s"
                End If
            Else
                Dim tsEc As Long = CLng(ss Mod 60)
                Dim lostAmt As Double = Val(MainForm.lblLostCard.Text)
                If lostAmt > 0 Then
                    S_PayType = "Regular"
                Else
                    S_PayType = "GracePeriod"
                End If
                Return "0D, 0H, " & "m, " & tsEc & "s"
            End If

        Catch ex As Exception
            Save_ErrLogs("[TotalTime_FUNCTION]", ex.Message)
            Return "0D, 0H, 0m, 0s"
        End Try
    End Function

    Public Function HourLy_RATE(ByVal Vehicle As String, ByVal tmeIN As Date, ByVal tmeOUT As Date) As String
        Try
            If conLocal() = False Then Return MakeMoney(0)

            If My.Settings.OvSucceeding = True Then
                'Return HourlyRate2(Vehicle, tmeIN, tmeOUT)
                Dim grace As Long = 0
                Dim MinMins As Long = 0
                Dim MinAmt As Double = 0
                Dim IntAmt As Double = 0

                Dim rs As New Recordset
                rs = conSqlLoc.Execute("select * from tblCharge where VehicleType = '" & Vehicle & "'")
                If rs.EOF = False Then
                    Dim MIN As Long = 0
                    grace = rs("GracePeriod").Value
                    MinMins = rs("MinMinutes").Value
                    MinAmt = rs("MinAmount").Value
                    IntAmt = rs("IntAmount").Value

                    Dim origMin As Long = DateDiff(DateInterval.Minute, tmeIN, tmeOUT)

                    Dim lessOVmin As Long = 60 * OVtotalHr

                    Dim OrigMineXs As Long = CLng(origMin Mod 60)

                    If OrigMineXs > 0 Then
                        'lessOVmin = lessOVmin + 60
                    End If

                    'lessOVmin = origMin - OVtotalMin
                    'MIN = lessOVmin

                    MIN = origMin - lessOVmin

                    Dim Min1 As Long = CLng(MIN Mod 60)
                    'If OVtotalMin > 0 Then
                    '    If OvhrGap > origMin Then
                    '        If MIN > 60 Then
                    '            MIN = MIN - Min1
                    '            Min1 = 0
                    '        End If
                    '    End If
                    'End If

                    If OVtoReg = True Then
                        Dim OrigMinIOExs As Long = CLng(MIN Mod 60)

                        If MIN > 60 Then
                            MIN = MIN - Min1
                        ElseIf MIN < 0 Then
                            Return 0
                        Else
                            OrigMinIOExs = 0
                            MIN = 60
                        End If

                        Dim SuccRegHr As Long = MIN / 60
                        If OrigMinIOExs > 0 Then
                            If MIN > 0 Then
                                Dim SuccRegAmt As Double = (IntAmt * SuccRegHr) + IntAmt
                                Return SuccRegAmt
                            End If
                        Else
                            Dim SuccRegAmt As Double = IntAmt * SuccRegHr
                            Return SuccRegAmt
                        End If
                    End If

                    If NoGrace = True Then
                        grace = 0
                    End If

                    If MIN <= grace Then '
                        If origMin < 0 Then
                        Else
                            If ReceiptType = "Senior" Then
                            Else
                                If lessOVmin = 0 Then
                                    S_PayType = "GracePeriod"
                                End If
                                Return MakeMoney(0)
                            End If
                        End If
                    End If

                    If MIN <= grace Then '
                        If MIN < 0 Then
                        Else
                        End If
                        Dim graceTotal As Double = 0 'OVtotalDue
                        Return MakeMoney(graceTotal)
                    ElseIf MIN <= MinMins Then
                        Dim MinTotal As Double = MinAmt ' + OVtotalDue
                        Return MakeMoney(MinTotal)
                    ElseIf MIN > MinMins Then
                        Dim Excess As Double = MIN - MinMins
                        If Excess > 60 Then
                            Dim exMinMod As Long = CLng(Excess Mod 60)

                            If exMinMod > 0 Then
                                Excess = Excess - exMinMod
                                Dim excessHr1 As Long = Excess / 60
                                Dim totalIntamt As Double = (excessHr1 * IntAmt) + IntAmt
                                Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                                Return MinAmt_IntAmt
                            Else
                                Dim excessHr1 As Long = Excess / 60
                                Dim totalIntamt As Double = (excessHr1 * IntAmt)
                                Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                                Return MinAmt_IntAmt
                            End If
                        Else
                            Dim MinAmt_IntAmt As Double = MinAmt + IntAmt '+ OVtotalDue
                            Return MakeMoney(MinAmt_IntAmt)
                        End If
                    Else
                        Return MakeMoney(0)
                    End If
                Else
                    Return MakeMoney(0)
                End If
            Else
                Dim rs As New Recordset
                rs = conSqlLoc.Execute("select * from tblCharge where VehicleType = '" & Vehicle & "'")
                If rs.EOF = False Then
                    Dim MIN As Long
                    Dim grace As Long = rs("GracePeriod").Value
                    Dim MinMins As Long = rs("MinMinutes").Value
                    Dim MinAmt As Double = rs("MinAmount").Value
                    Dim IntAmt As Double = rs("IntAmount").Value
                    Dim fMIN As Long = DateDiff(DateInterval.Minute, tmeIN, tmeOUT)
                    Dim OV_Mins As Long = OV_LessHr * 60
                    Dim OVDiff As Long = fMIN - OV_Mins

                    MIN = fMIN

                    Dim Min1 As Long = CLng(MIN Mod 60)

                    If NoGrace = True Then
                        grace = 0
                    End If

                    Dim Rtmin As Long = DateDiff(DateInterval.Minute, tmeIN, tmeOUT)

                    If Rtmin <= grace Then '
                        If Rtmin < 0 Then
                        Else
                            If ReceiptType = "Senior" Then
                            Else
                                S_PayType = "GracePeriod"
                            End If
                        End If
                    End If

                    If MIN <= grace Then '
                        If MIN < 0 Then
                        Else

                        End If
                        Return "0.00"
                    ElseIf MIN <= MinMins Then
                        Return MakeMoney(MinAmt)
                    ElseIf MIN > MinMins Then
                        Dim Excess As Double = MIN - MinMins
                        If Excess > 60 Then
                            Dim exMinMod As Long = CLng(Excess Mod 60)

                            If exMinMod > 0 Then
                                Excess = Excess - exMinMod
                                Dim excessHr1 As Long = Excess / 60
                                Dim totalIntamt As Double = (excessHr1 * IntAmt) + IntAmt
                                Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                                Return MinAmt_IntAmt
                            Else
                                Dim excessHr1 As Long = Excess / 60
                                Dim totalIntamt As Double = (excessHr1 * IntAmt)
                                Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                                Return MinAmt_IntAmt
                            End If
                        Else
                            Dim MinAmt_IntAmt As Double = MinAmt + IntAmt '+ OVtotalDue
                            Return MakeMoney(MinAmt_IntAmt)
                        End If
                    Else
                        Return "0.00"
                    End If
                Else
                    Return "0.00"
                End If
            End If
        Catch ex As Exception
            Save_ErrLogs("[HourLy_RATE]", ex.Message)
            Return "0.00"
        End Try
    End Function

    Public Function Compute_FlateRATE(ByVal vtype As String, ByVal Timein As Date, ByVal Timeout As Date) As Double
        Try
            If conLocal() = False Then Return 0

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("SELECT * FROM tblCharge WHERE VehicleType= '" & vtype & "'")
            If rs.EOF = False Then
                Dim grace As Long = rs("GracePeriod").Value
                Dim F As Double = rs("FlatRate").Value
                Dim TDmin As Long = DateDiff(DateInterval.Minute, Timein, Timeout)
                Dim TD As Long = DateDiff(DateInterval.Hour, Timein, Timeout)

                Dim TDminMOD As Long = CLng(TDmin Mod 60)

                Dim Rtmin As Long = DateDiff(DateInterval.Minute, Timein, Timeout)

                If TDmin <= grace Then
                    If Rtmin <= grace Then '
                        If Rtmin < 0 Then
                        Else
                            If ReceiptType = "Senior" Then
                            Else
                                S_PayType = "GracePeriod"

                            End If
                        End If
                    End If
                    Return 0
                ElseIf TDmin > 1440 Then
                    If TDminMOD > 0 Then
                        Dim Dy As Double = TD / 24
                        Dim Dy2 As Integer = Mid(Dy.ToString, 1, 1)
                        Dim DyCnt As Integer = Dy2 + 1
                        Dim ttt As Double = F * DyCnt
                        Return ttt
                    Else
                        Dim D As Integer = TD / 24
                        Dim tt As Double = F * D
                        Return tt
                    End If
                Else
                    Return F
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            Save_ErrLogs("[Compute_FlateRATE]", ex.Message)
            Return 0
        End Try
    End Function

    Public Function getSuccOvernight(ByVal TimeIn As DateTime, ByVal TimeOut As DateTime, ByVal Vehicle As String) As Double
        Try
            If conLocal() = False Then
                Save_ErrLogs("[getSuccOvernight]", "conLocal false")

                Return 0
            End If

            Dim HrInfo As New Charging_Hourly
            HrInfo = Get_Charging_Hourly(Vehicle)

            Dim OvCutGap As Long = HrInfo.MinMins + 60

            If My.Settings.OvSucceeding = True Then
                Dim OAtotalDue As Double = 0
                OVtoReg = False
                OVtotalHr = 0

                Dim rsOV As New Recordset
                rsOV = conSqlLoc.Execute("select * from tblovernigth where VType = '" & Vehicle & "'")
                If rsOV.EOF = False Then
                    OVcharge = CDbl(rsOV("RateCharge").Value)
                    OVStartTme = CDate(rsOV("TimeStart").Value)
                    OVEndTme = CDate(rsOV("TimeEnd").Value)
                Else
                    'Save_ErrLogs("[getSuccOvernight]", "VType not found in tblovernigth")
                    Return 0
                End If

                Dim StartTime As Date = Format(OVStartTme, "HH:mm:ss")
                Dim EndTime As Date = Format(OVEndTme, "HH:mm:ss")
                Dim Amount As Double = OVcharge

                Dim FTimeIn As Date
                Dim FTimeOut As Date
                Dim FTimeStart As Date
                Dim FTimeEnd As Date

                FTimeIn = Format(TimeIn, "HH:mm tt")
                FTimeOut = Format(TimeOut, "HH:mm tt")
                FTimeStart = Format(StartTime, "HH:mm tt")
                FTimeEnd = Format(EndTime, "HH:mm tt")

                Dim timeInTT As String = Format(TimeIn, "tt")
                Dim dtFinFout As Long = DateDiff(DateInterval.Day, TimeIn, TimeOut)
                Dim dtFinFoutMin As Long = DateDiff(DateInterval.Day, TimeIn, TimeOut)
                Dim OrigInOut As Long = DateDiff(DateInterval.Minute, TimeIn, TimeOut)

                Dim fStartDt As Date = TimeIn.Date.AddDays(-1)
                Dim fStartDtTme As DateTime = fStartDt.Date + FTimeStart.TimeOfDay
                Dim fStartDtTme2 As DateTime = TimeIn.Date + FTimeStart.TimeOfDay

                Dim fEndDtTme As DateTime = TimeIn.Date + FTimeEnd.TimeOfDay
                Dim fEndDtTme2 As DateTime = TimeIn.Date.AddDays(1) + FTimeEnd.TimeOfDay

                If OrigInOut = 0 Then Return 0

                If timeInTT = "AM" Or timeInTT = "am" Then
                    If TimeIn > fEndDtTme And TimeOut < fStartDtTme2 Then
                        OVtotalMin = 0
                        OVtotalHr = 0
                        'Save_ErrLogs("[getSuccOvernight]", "Return 0 in if statement :" & TimeIn.ToString & ">" & fEndDtTme.ToString & "And" & TimeOut.ToString & "<" & fStartDtTme2.ToString)
                        Return 0
                    ElseIf TimeIn <= fEndDtTme And TimeOut > fStartDtTme2 Then
                        Dim tmeDiff As Long = DateDiff(DateInterval.Minute, fStartDtTme2, fEndDtTme2)
                        Dim OvHr As Long = tmeDiff / 60

                        OVtotalMin = tmeDiff
                        OVtotalDue = OVcharge * OvHr
                        OVtotalHr = OvHr
                        Return OVtotalDue
                    ElseIf TimeIn <= fEndDtTme And TimeOut < fStartDtTme2 Then
                        Dim tmeDiff As Long = 0
                        If TimeOut >= fEndDtTme Then
                            OVtoReg = True
                            tmeDiff = DateDiff(DateInterval.Minute, TimeIn, fEndDtTme)
                        ElseIf TimeOut < fEndDtTme Then
                            tmeDiff = DateDiff(DateInterval.Minute, TimeIn, TimeOut)
                        End If

                        If tmeDiff <= 60 Then
                            OVtotalMin = tmeDiff

                            'If origInOutMins > OvCutGap Then
                            '    OVtotalHr = 2
                            'Else
                            '    OVtotalHr = 1
                            'End If

                            OVtotalHr = 1
                            OVtotalDue = OVcharge * OVtotalHr

                            Return OVtotalDue
                        Else
                            Dim ovExMin As Long = CInt(tmeDiff Mod 60)
                            If ovExMin > 0 Then
                                Dim OvMin60 As Long = tmeDiff - ovExMin
                                Dim OvHr As Long = OvMin60 / 60

                                'Dim origIOexs As Long = CLng(origInOutMins Mod 60)

                                'If origIOexs > 0 Then
                                '    OvHr = OvHr + 1
                                'End If

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 2
                                'Else
                                '    OvHr = OvHr + 1
                                'End If

                                OvHr = OvHr + 1

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            Else
                                Dim OvHr As Long = tmeDiff / 60

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 1
                                'End If

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            End If
                        End If
                        'If dtFinFout <= 0 Then
                        '    'Over_count = 1
                        '    'Return Amount * Over_count
                        'End If
                    ElseIf TimeIn >= fEndDtTme And TimeOut >= fStartDtTme2 Then
                        Dim tmeDiff As Long = DateDiff(DateInterval.Minute, fStartDtTme2, TimeOut)
                        If tmeDiff <= 60 Then
                            OVtotalMin = tmeDiff

                            'If origInOutMins > OvCutGap Then
                            '    OVtotalHr = 2
                            'Else
                            '    OVtotalHr = 1
                            'End If
                            OVtotalHr = 1

                            OVtotalDue = OVcharge * OVtotalHr

                            Return OVtotalDue
                        Else
                            Dim ovExMin As Long = CInt(tmeDiff Mod 60)
                            If ovExMin > 0 Then
                                Dim OvMin60 As Long = tmeDiff - ovExMin
                                Dim OvHr As Long = OvMin60 / 60

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 2
                                'Else
                                '    OvHr = OvHr + 1
                                'End If
                                OvHr = OvHr + 1

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            Else
                                Dim OvHr As Long = tmeDiff / 60

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 1
                                'End If

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            End If
                        End If
                        'If dtFinFout <= 0 Then
                        '    'Over_count = 1
                        '    'Return Amount * Over_count
                        'End If
                    Else
                        If TimeIn <= fEndDtTme Then
                            'Over_count = 1
                            Dim tmeDiff As Long = DateDiff(DateInterval.Minute, TimeIn, fEndDtTme)
                            If tmeDiff <= 60 Then
                                OVtotalMin = tmeDiff

                                'If origInOutMins > OvCutGap Then
                                '    OVtotalHr = 2
                                'Else
                                '    OVtotalHr = 1
                                'End If

                                OVtotalHr = 1

                                OVtotalDue = OVcharge * OVtotalHr

                                Return OVtotalDue
                            Else
                                Dim ovExMin As Long = CInt(tmeDiff Mod 60)
                                If ovExMin > 0 Then
                                    Dim OvMin60 As Long = tmeDiff - ovExMin
                                    Dim OvHr As Long = OvMin60 / 60

                                    'If origInOutMins > OvCutGap Then
                                    '    OvHr = OvHr + 2
                                    'Else
                                    '    OvHr = OvHr + 1
                                    'End If

                                    OvHr = OvHr + 1

                                    OVtotalMin = tmeDiff
                                    OVtotalDue = OVcharge * OvHr
                                    OVtotalHr = OvHr
                                    Return OVtotalDue
                                Else
                                    Dim OvHr As Long = tmeDiff / 60

                                    'If origInOutMins > OvCutGap Then
                                    '    OvHr = OvHr + 1
                                    'End If

                                    OVtotalMin = tmeDiff
                                    OVtotalDue = OVcharge * OvHr
                                    OVtotalHr = OvHr
                                    Return OVtotalDue
                                End If
                            End If
                        End If
                        'If dtFinFout > 0 Then

                        'End If
                    End If
                Else
                    Save_ErrLogs("[getSuccOvernight]", "Get else in timeInTT :" & timeInTT)
                    If TimeIn < fStartDtTme2 And TimeOut < fStartDtTme2 Then
                        OVtotalMin = 0
                        OVtotalHr = 0
                        'Save_ErrLogs("[getSuccOvernight]", "Return 0 in if statement :" & TimeIn.ToString & "<" & fStartDtTme2.ToString & "And" & TimeOut.ToString & "<" & fStartDtTme2.ToString)
                        Return 0
                    ElseIf TimeIn <= fStartDtTme2 And TimeOut >= fStartDtTme2 Then
                        Dim tmeDiff As Long = DateDiff(DateInterval.Minute, fStartDtTme2, TimeOut)
                        If tmeDiff <= 60 Then
                            OVtotalMin = tmeDiff

                            'If origInOutMins > OvCutGap Then
                            '    OVtotalHr = 2
                            'Else
                            '    OVtotalHr = 1
                            'End If
                            OVtotalHr = 1

                            OVtotalDue = OVcharge * OVtotalHr

                            Return OVtotalDue
                        Else
                            Dim ovExMin As Long = CInt(tmeDiff Mod 60)
                            If ovExMin > 0 Then
                                Dim OvMin60 As Long = tmeDiff - ovExMin
                                Dim OvHr As Long = OvMin60 / 60

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 2
                                'Else
                                '    OvHr = OvHr + 1
                                'End If

                                OvHr = OvHr + 1

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            Else
                                Dim OvHr As Long = tmeDiff / 60

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 1
                                'End If

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            End If
                        End If
                    ElseIf TimeIn >= fStartDtTme2 And TimeOut < fEndDtTme2 Then
                        If TimeOut > fEndDtTme2 Then
                            OVtoReg = True
                        End If

                        Dim tmeDiff As Long = DateDiff(DateInterval.Minute, TimeIn, TimeOut)
                        If tmeDiff <= 60 Then
                            OVtotalMin = tmeDiff

                            'If origInOutMins > OvCutGap Then
                            '    OVtotalHr = 2
                            'Else
                            '    OVtotalHr = 1
                            'End If
                            OVtotalHr = 1

                            OVtotalDue = OVcharge * OVtotalHr

                            Return OVtotalDue
                        Else
                            Dim ovExMin As Long = CInt(tmeDiff Mod 60)
                            If ovExMin > 0 Then
                                Dim OvMin60 As Long = tmeDiff - ovExMin
                                Dim OvHr As Long = OvMin60 / 60

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 2
                                'Else
                                '    OvHr = OvHr + 1
                                'End If

                                OvHr = OvHr + 1

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            Else
                                Dim OvHr As Long = tmeDiff / 60

                                'If origInOutMins > OvCutGap Then
                                '    OvHr = OvHr + 1
                                'End If

                                OVtotalMin = tmeDiff
                                OVtotalDue = OVcharge * OvHr
                                OVtotalHr = OvHr
                                Return OVtotalDue
                            End If
                        End If
                    ElseIf TimeIn >= fStartDtTme2 And TimeOut >= fEndDtTme2 Then
                        If TimeIn >= fStartDtTme2 Then
                            'Over_count = 1
                            Dim tmeDiff As Long = DateDiff(DateInterval.Minute, TimeIn, fEndDtTme2)
                            If tmeDiff <= 60 Then
                                OVtotalMin = tmeDiff

                                'If origInOutMins > OvCutGap Then
                                '    OVtotalHr = 2
                                'Else
                                '    OVtotalHr = 1
                                'End If
                                OVtotalHr = 1

                                OVtotalDue = OVcharge * OVtotalHr

                                Return OVtotalDue
                            Else
                                Dim ovExMin As Long = CInt(tmeDiff Mod 60)
                                If ovExMin > 0 Then
                                    Dim OvMin60 As Long = tmeDiff - ovExMin
                                    Dim OvHr As Long = OvMin60 / 60

                                    'If origInOutMins > OvCutGap Then
                                    '    OvHr = OvHr + 2
                                    'Else
                                    '    OvHr = OvHr + 1
                                    'End If

                                    OvHr = OvHr + 1

                                    OVtotalMin = tmeDiff
                                    OVtotalDue = OVcharge * OvHr
                                    OVtotalHr = OvHr
                                    Return OVtotalDue
                                Else
                                    Dim OvHr As Long = tmeDiff / 60

                                    'If origInOutMins > OvCutGap Then
                                    '    OvHr = OvHr + 1
                                    'End If

                                    OVtotalMin = tmeDiff
                                    OVtotalDue = OVcharge * OvHr
                                    OVtotalHr = OvHr
                                    Return OVtotalDue
                                End If
                            End If
                        End If
                        'Over_count = Over_count + dtFinFout
                        'Return Amount * Over_count
                    End If
                End If
            End If
        Catch ex As Exception
            Save_ErrLogs("[getSuccOvernight]", ex.Message)
            Return 0
        End Try
    End Function

    Function GETovernyt(ByVal TimeIn As DateTime, ByVal TimeOut As DateTime, ByVal Vehicle As String) As Double
        Try
            If conLocal() = False Then
                Save_ErrLogs("[getSuccOvernight]", "conLocal false")
                Return 0
            End If

            If My.Settings.OvSucceeding = True Then
                Return getSuccOvernight(TimeIn, TimeOut, Vehicle)
            Else
            Over_count = 0
            Count_Days = 0
            GETovernyt = 0
            OV_LessHr = 0

            Dim rs As New Recordset

            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblOvernigth where VType = '" & Vehicle & "'")
            If rs.EOF = False Then

                Dim StartTime As Date = Format(CDate(rs("TimeStart").Value), "HH:mm:ss")
                Dim EndTime As Date = Format(CDate(rs("TimeEnd").Value), "HH:mm:ss")
                Dim Amount As Double = rs("RateCharge").Value

                Dim FTimeIn As Date
                Dim FTimeOut As Date
                Dim FTimeStart As Date
                Dim FTimeEnd As Date

                FTimeIn = Format(TimeIn, "HH:mm tt")
                FTimeOut = Format(TimeOut, "HH:mm tt")
                FTimeStart = Format(StartTime, "HH:mm tt")
                FTimeEnd = Format(EndTime, "HH:mm tt")

                Dim timeInTT As String = Format(TimeIn, "tt")
                Dim dtFinFout As Long = DateDiff(DateInterval.Day, TimeIn, TimeOut)
                Dim dtFinFoutMin As Long = DateDiff(DateInterval.Day, TimeIn, TimeOut)

                Dim fStartDt As Date = TimeIn.Date.AddDays(-1)
                Dim fStartDtTme As DateTime = fStartDt.Date + FTimeStart.TimeOfDay
                Dim fStartDtTme2 As DateTime = TimeIn.Date + FTimeStart.TimeOfDay

                Dim fEndDtTme As DateTime = TimeIn.Date + FTimeEnd.TimeOfDay
                Dim fEndDtTme2 As DateTime = TimeIn.Date.AddDays(1) + FTimeEnd.TimeOfDay


                    If timeInTT = "AM" Or timeInTT = "am" Then
                        If TimeIn > fEndDtTme And TimeOut < fStartDtTme2 Then

                            'Save_ErrLogs("[GETovernyt]", "If Statement: " & TimeIn & ">" & fEndDtTme & "And" & TimeOut & "<" & fStartDtTme2)
                            Over_count = 0
                            Return 0
                        ElseIf TimeIn <= fEndDtTme And TimeOut < fStartDtTme2 Then
                            If dtFinFout <= 0 Then
                                Over_count = 1
                                Return Amount * Over_count
                            End If
                        Else
                            If TimeIn <= fEndDtTme Then
                                Over_count = 1
                            End If
                            If dtFinFout > 0 Then
                                Over_count = Over_count + dtFinFout
                                Return Amount * Over_count
                            End If
                        End If
                    Else

                        If TimeIn < fStartDtTme2 And TimeOut < fStartDtTme2 Then
                            'Save_ErrLogs("[GETovernyt]", "If Statement: " & TimeIn & "<" & fStartDtTme2 & "And" & TimeOut & "<" & fStartDtTme2)
                            Over_count = 0
                            Return 0
                        ElseIf TimeIn < fStartDtTme2 And TimeOut > fStartDtTme2 Then
                            Over_count = 1
                            Over_count = Over_count + dtFinFout
                            Return Amount * Over_count
                        ElseIf TimeIn >= fStartDtTme2 And TimeOut < fEndDtTme2 Then
                            Over_count = 1
                            Return Amount * Over_count
                        ElseIf TimeIn >= fStartDtTme2 And TimeOut > fEndDtTme2 Then
                            If TimeIn >= fStartDtTme2 Then
                                Over_count = 1
                            End If
                            Over_count = Over_count + dtFinFout
                            Return Amount * Over_count
                        End If
                    End If

                Else
                    'Save_ErrLogs("[GETovernyt]", "Vtype not found in tblovernight")
                    Return 0
                End If

            End If
        Catch ex As Exception
            Save_ErrLogs("[GETovernyt]", ex.Message)
            Return 0
        End Try
    End Function

   

    Public Function VAT(ByVal TotalAmt As Double) As String
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblvat")
            If rs.EOF = False Then
                Dim vt As Double
                Dim vatP As Double = rs("VAT").Value
                Dim vat1 As Double = vatP + 1
                vt = TotalAmt / vat1 * vatP
                If vt = 0 Then Return "0.00"
                Return MakeMoney(vt)
            Else
                Return "0.00"
            End If
        Catch ex As Exception
            Save_ErrLogs("[VAT] CHARGING_FUNCTION", ex.Message)
        End Try
    End Function

    Public Function subTotal(ByVal totalAmt As Double, ByVal VatAmt As Double) As String
        Dim subTt As Double
        subTt = Val(totalAmt) - Val(VatAmt)
        If subTt = 0 Then Return "0.00"
        subTotal = MakeMoney(subTt)
    End Function

    Public Function totalAmount(ByVal AmtDue As Double, ByVal Overnigth As Double, ByVal lost As Double) As Double
        Dim ttamount As Double
        ttamount = AmtDue + Overnigth + lost
        Return ttamount
    End Function

    Public Function Get_IntervalAmt(ByVal VEH As String, ByVal Timein As Date, ByVal Timeout As Date) As Double

        If conLocal() = False Then Return 0

        Try

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("SELECT IntAmount From tblcharge where VehicleType = '" & VEH & "'")
            If rs.EOF = False Then

                Dim H As Long = DateDiff(DateInterval.Hour, Timein, Timeout)
                Dim M As Long = CLng(DateDiff(DateInterval.Minute, Timein, Timeout) Mod 60)
                Dim AMT As Double = rs("Intamount").Value
                Select Case H

                    Case 0
                        Return rs("IntAmount").Value
                    Case Is <> 0 And M <> 0

                        Return ((AMT * H) + AMT)
                    Case Else
                        Return 0
                End Select

            Else
                Return 0
            End If



        Catch ex As Exception
            'ErrMSG = ex.Message.ToString
        End Try
    End Function

    Public Function LostCharge(ByVal vehicle As String) As Double
        Try
            If conLocal() = False Then
                Return 0
            End If

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select LostCard from tblCharge where VehicleType = '" & vehicle & "'")
            If rs.EOF = False Then
                Dim lostC As Double = rs("LostCard").Value
                Return lostC
            Else
                Return 0
            End If
        Catch ex As Exception
            Save_ErrLogs("[LostCharge] CHARGING FUNCTION", ex.Message)
            Return 0
        End Try

    End Function

    Public Function ChargeMode() As Boolean
        If MainForm.txtMODE.Text = "FLAT RATE" Then
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
            Save_ErrLogs("[FlatDayCheck] CHARGING FUNCTION", ex.Message)
            Return False
        End Try
    End Function

    Public Function FlatHolidayCheck(ByVal DayToday As String, ByVal dtstr As Date) As Boolean
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
            Save_ErrLogs("[FlatHolidayCheck] CHARGING FUNCTION", ex.Message)
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

            rs = conSqlLoc.Execute("select ChargeType from tblcharge where KeyCode = '" & Ky & "'")
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
            Save_ErrLogs("[ChkChargType] CHARGING FUNCTION", ex.Message)
            Return False
        End Try
    End Function

    Function getLastDate(ByVal yr As Integer, ByVal mm As Integer) As Integer
        Return System.DateTime.DaysInMonth(yr, mm)
    End Function

    Public Sub Transact(ByVal VehicleTyp As String, ByVal PlateNo As String, ByVal wCard As Boolean, ByVal LostC As Boolean, ByVal TimeIn As DateTime, ByVal Timeout As DateTime)
        Try
            RESETinfo()
            frmRefNo.txtDocNo.Text = "No Ref Number"
            ChargeFlag = False
            NoGrace = False

            With MainForm
                If wCard = True Then
                    If d8_Card() = False Then
                        If ER302_Conn(My.Settings.Er302Com) = True Then
                            If ER302_Request() = True Then
                            Else
                                MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
                                Exit Sub
                            End If
                        End If
                    End If
                End If

                origInOutMins = DateDiff(DateInterval.Minute, TimeIn, Timeout)

                .lblTimeIn.Text = Format(TimeIn, "yyyy-MM-dd HH:mm:ss")
                .lblTimeOut.Text = Format(Timeout, "yyyy-MM-dd HH:mm:ss")

                Dim dtToadd As Date = Format(CDate(TimeIn), "yyyy-MM-dd HH:mm:ss")

                Dim Entdt As Long = Format(CDate(TimeIn), "dd")
                Dim Extdt As Long = Format(CDate(Timeout), "dd")

                Dim DaYdiff As Long = Extdt - Entdt
                If DaYdiff < 0 Then
                    Dim yr As Integer = Format(CDate(TimeIn), "yyyy")
                    Dim mm As Integer = Format(CDate(TimeIn), "MM")
                    Dim lastDtMM As Long = getLastDate(yr, mm)

                    Dim ttExtEntDt As Long = lastDtMM + Extdt
                    DaYdiff = ttExtEntDt - Entdt
                End If

                Dim lup As Long

                Dim LostAmt As Double = 0
                If LostC = True Then
                    LostAmt = LostCharge(VehicleTyp)
                End If

                Dim HrToFlatAmt As Double = 0
                Dim FlatToHrAmt As Double = 0
                Dim FlatDayAmt As Double = 0
                Dim FlatHolidayAmt As Double = 0
                Dim SuccAmt As Double = 0
                Dim FlatAmt As Double = 0
                Dim SucOvAmt As Double = 0

                Dim PetsaIn As Date
                Dim PetsaOut As Date

                PetsaIn = TimeIn

                If DaYdiff >= 1 Then
                    For lup = 0 To DaYdiff
                        Dim day As Long
                        day = day + 1
                        Dim Newpetsa As Date = dtToadd.AddDays(day)

                        If Newpetsa > CDate(Timeout) Then
                            Newpetsa = CDate(Timeout)
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

                        If Newpetsa > CDate(Timeout) Then
                            PetsaOut = CDate(Timeout)
                        Else
                            PetsaOut = Newpetsa
                        End If

                        If lup = DaYdiff Then
                            PetsaOut = CDate(Timeout)
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

                            If My.Settings.OvSucceeding = True Then
                                SucOvAmt = SucOvAmt + GETovernyt(PetsaIn.ToString, hcutOut, VehicleTyp)
                            End If

                            SuccAmt = SuccAmt + HourLy_RATE(VehicleTyp, PetsaIn.ToString, hcutOut)

                            PetsaIn = hcutOut

                            Continue For
                        End If

                    Next

                    Dim totalAmtDue As Double = FlatDayAmt + FlatHolidayAmt + SuccAmt
                    Dim ov As Double = 0

                    If My.Settings.OvSucceeding = False Then
                        ov = GETovernyt(TimeIn, Timeout, VehicleTyp)
                    Else
                        ov = SucOvAmt
                    End If

                    Dim totalAmtF As Double = totalAmount(totalAmtDue, ov, LostAmt)
                    Dim vatAmtF As Double = VAT(totalAmtF)

                    .lblAmountDue.Text = MakeMoney(totalAmtDue)
                    .lblOvernigth.Text = MakeMoney(ov)
                    .lblLostCard.Text = MakeMoney(LostAmt)
                    .lblVtype.Text = VehicleTyp
                    .lblPlate.Text = UCase(PlateNo)
                    .lblTotalTime.Text = TotalTime_FUNCTION(TimeIn, Timeout)
                    .lblTotal.Text = MakeMoney(totalAmtF)
                    .lblVAT.Text = VAT(totalAmtF)
                    .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)

                    .cmdDiscount.Enabled = True
                    .cmdCancel.Enabled = True
                    '.cmdBt.Enabled = False
                    '.cmdLost.Enabled = False

                    'PoleDisOpen()
                    'clear()
                    'displayTotal(MakeMoney(P_TotalAmt))
                    'PoleDisClose()
                    PD_Display_Total(MakeMoney(totalAmtF))

                    trOpt = True
                    TrLostOpt = True

                    MainForm.txtTender.Enabled = True
                    .txtAmtStat.Text = "TOTAL AMOUNT :"

                    'Me.Close()
                    Exit Sub
                End If

                If FlatDayCheck(Format(CDate(Timeout), "dddd"), PetsaIn) = True Then
                    Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, TimeIn, Timeout)
                    'Dim ovF As Double = overnyt(tmeIn, iout)
                    Dim totalAmtF As Double = totalAmount(amtDueF, 0, LostAmt)
                    Dim vatAmtF As Double = VAT(totalAmtF)

                    .lblAmountDue.Text = MakeMoney(amtDueF)
                    .lblOvernigth.Text = MakeMoney(0)
                    .lblLostCard.Text = MakeMoney(LostAmt)
                    .lblVtype.Text = VehicleTyp
                    .lblPlate.Text = UCase(PlateNo)
                    .lblTotalTime.Text = TotalTime_FUNCTION(TimeIn, Timeout)
                    .lblTotal.Text = MakeMoney(totalAmtF)
                    .lblVAT.Text = VAT(totalAmtF)
                    .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)

                    .cmdDiscount.Enabled = True
                    .cmdCancel.Enabled = True
                    '.cmdBt.Enabled = False
                    '.cmdLost.Enabled = False

                    'PoleDisOpen()
                    'clear()
                    'displayTotal(MakeMoney(P_TotalAmt))
                    'PoleDisClose()
                    PD_Display_Total(MakeMoney(totalAmtF))

                    trOpt = True
                    TrLostOpt = True

                    MainForm.txtTender.Enabled = True
                    .txtAmtStat.Text = "TOTAL AMOUNT :"
                    'Me.Close()
                    Exit Sub
                End If

                If FlatHolidayCheck(Format(CDate(Timeout), "MM-dd"), PetsaIn) = True Then
                    Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, TimeIn, Timeout)
                    'Dim ovF As Double = overnyt(tmeIn, iout)
                    Dim totalAmtF As Double = totalAmount(amtDueF, 0, LostAmt)
                    Dim vatAmtF As Double = VAT(totalAmtF)

                    .lblAmountDue.Text = MakeMoney(amtDueF)
                    .lblOvernigth.Text = MakeMoney(0)
                    .lblLostCard.Text = MakeMoney(LostAmt)
                    .lblVtype.Text = VehicleTyp
                    .lblPlate.Text = UCase(PlateNo)
                    .lblTotalTime.Text = TotalTime_FUNCTION(TimeIn, Timeout)
                    .lblTotal.Text = MakeMoney(totalAmtF)
                    .lblVAT.Text = VAT(totalAmtF)
                    .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)

                    .cmdDiscount.Enabled = True
                    .cmdCancel.Enabled = True
                    '.cmdBt.Enabled = False
                    '.cmdLost.Enabled = False

                    'PoleDisOpen()
                    'clear()
                    'displayTotal(MakeMoney(P_TotalAmt))
                    'PoleDisClose()
                    PD_Display_Total(MakeMoney(totalAmtF))

                    trOpt = True
                    TrLostOpt = True

                    MainForm.txtTender.Enabled = True
                    .txtAmtStat.Text = "TOTAL AMOUNT :"
                    'Me.Close()
                    Exit Sub
                End If

                If ChargeMode() = True Then
                    Dim ov As Double = GETovernyt(TimeIn, Timeout, VehicleTyp)
                    Dim amtDue As Double = HourLy_RATE(VehicleTyp, TimeIn, Timeout)
                    Dim totalAmt As Double = totalAmount(amtDue, ov, LostAmt)
                    Dim vatAmt As Double = VAT(totalAmt)

                    .lblAmountDue.Text = MakeMoney(amtDue)  'intAmount(getMinMinutes, totalTime)
                    .lblOvernigth.Text = MakeMoney(ov)
                    .lblLostCard.Text = MakeMoney(LostAmt)
                    .lblVtype.Text = VehicleTyp
                    .lblPlate.Text = UCase(PlateNo)
                    .lblTotalTime.Text = TotalTime_FUNCTION(TimeIn, Timeout)
                    .lblTotal.Text = MakeMoney(totalAmt)
                    .lblVAT.Text = VAT(totalAmt)
                    .lblSubTotal.Text = subTotal(totalAmt, vatAmt)

                    .cmdDiscount.Enabled = True
                    .cmdCancel.Enabled = True
                    '.cmdBt.Enabled = False
                    '.cmdLost.Enabled = False

                    'PoleDisOpen()
                    'clear()
                    'displayTotal(MakeMoney(P_TotalAmt))
                    'PoleDisClose()

                    PD_Display_Total(MakeMoney(totalAmt))

                    trOpt = True
                    TrLostOpt = True

                    MainForm.txtTender.Enabled = True
                    .txtAmtStat.Text = "TOTAL AMOUNT :"
                    'Me.Close()
                Else
                    Dim amtDueF As Double = Compute_FlateRATE(VehicleTyp, TimeIn, Timeout)
                    'Dim ovF As Double = overnyt(tmeIn, iout)
                    Dim totalAmtF As Double = totalAmount(amtDueF, 0, LostAmt)
                    Dim vatAmtF As Double = VAT(totalAmtF)

                    .lblAmountDue.Text = MakeMoney(amtDueF)
                    .lblOvernigth.Text = MakeMoney(0)
                    .lblLostCard.Text = MakeMoney(LostAmt)
                    .lblVtype.Text = VehicleTyp
                    .lblPlate.Text = UCase(PlateNo)
                    .lblTotalTime.Text = TotalTime_FUNCTION(TimeIn, Timeout)
                    .lblTotal.Text = MakeMoney(totalAmtF)
                    .lblVAT.Text = VAT(totalAmtF)
                    .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)

                    .cmdDiscount.Enabled = True
                    .cmdCancel.Enabled = True
                    '.cmdBt.Enabled = False
                    '.cmdLost.Enabled = False

                    'PoleDisOpen()
                    'clear()
                    'displayTotal(MakeMoney(P_TotalAmt))
                    'PoleDisClose()
                    PD_Display_Total(MakeMoney(totalAmtF))

                    trOpt = True
                    TrLostOpt = True

                    .txtTender.Enabled = True
                    .txtAmtStat.Text = "TOTAL AMOUNT :"
                    'Me.Close()
                End If
            End With
        Catch ex As Exception
            Save_ErrLogs("[Transact] frmTransact", ex.Message)
        End Try
    End Sub
End Module
