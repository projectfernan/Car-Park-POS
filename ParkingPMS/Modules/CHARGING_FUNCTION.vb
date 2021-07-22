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

    Public P_TotalAmt As Double
    Public OV_LessHr As Long = 0

    Public NoGrace As Boolean = False

    Public TotalTimeInt As Integer

    Public S_Refnumber As String = vbNullString
    Public S_PayType As String = vbNullString

    Public S_SeniorName As String

    Public ReceiptType As String = vbNullString

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
                'Dim lostAmt As Double = Val(MainForm.lblLostCard.Text)
                'If lostAmt > 0 Then
                '    S_PayType = "Regular"
                'Else
                '    S_PayType = "GracePeriod"
                'End If
                'Return "0D, 0H, " & "m, " & tsEc & "s"
            End If

        Catch ex As Exception
            ' S_PayType = "GracePeriod"
            Return "0D, 0H, 0m, 0s"
        End Try
    End Function

    Public Function HourLy_RATE(ByVal Vehicle As String, ByVal tmeIN As Date, ByVal tmeOUT As Date) As String
        Try
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

                        Dim excessHr1 As Long = Excess / 60
                        Dim excessHr As Double = Excess / 60
                        Dim TheString As String
                        TheString = excessHr
                        Dim thelength = Len(TheString)
                        Dim thedecimal = InStr(TheString, ".", CompareMethod.Text)
                        Dim strGetDec As Double

                        If thedecimal = 0 Then
                            strGetDec = 0
                        Else
                            strGetDec = Mid(excessHr.ToString, thedecimal)
                        End If


                        Dim getDiffEx As Double = excessHr - strGetDec


                        If Min1 > 0 And Min1 <= 30 Then
                            Dim totalIntamt As Double = (getDiffEx * IntAmt) + IntAmt
                            Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                            Return MakeMoney(MinAmt_IntAmt)
                        Else
                            Dim totalIntamt As Double = excessHr1 * IntAmt
                            Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                            Return MakeMoney(MinAmt_IntAmt)
                        End If

                    Else
                        Dim MinAmt_IntAmt As Double = MinAmt + IntAmt
                        Return MakeMoney(MinAmt_IntAmt)
                    End If


                    ' Dim Excess As Double = MIN - MinMins
                    ' If Excess > 60 Then

                    'Dim excessHr As Long = Excess / 60
                    ' If Min1 > 0 And Min1 <= 30 Then
                    'Dim totalIntamt As Double = (excessHr * IntAmt) + IntAmt
                    ' Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                    ' Return MakeMoney(MinAmt_IntAmt)
                    ' Else
                    ' Dim totalIntamt As Double = excessHr * IntAmt
                    ' Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                    ' Return MakeMoney(MinAmt_IntAmt)
                    ' End If

                    ' Else
                    ' Dim MinAmt_IntAmt As Double = MinAmt + IntAmt
                    'Return MakeMoney(MinAmt_IntAmt)
                    ' End If
                Else
                    Return "0.00"
                End If
            Else
                Return "0.00"
            End If
        Catch ex As Exception
            Return "0.00"
        End Try
    End Function

    Public Function Compute_FlateRATE(ByVal vtype As String, ByVal Timein As Date, ByVal Timeout As Date) As Double
        If conLocal() = False Then Return "0.00"
        Dim rs As New Recordset
        Try
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
            Return 0
        End Try
    End Function


    Function GETovernyt(ByVal TimeIn As DateTime, ByVal TimeOut As DateTime, ByVal Vehicle As String) As Double

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

            Dim fStartDt As Date = TimeIn.Date.AddDays(-1)
            Dim fStartDtTme As DateTime = fStartDt.Date + FTimeStart.TimeOfDay
            Dim fStartDtTme2 As DateTime = TimeIn.Date + FTimeStart.TimeOfDay

            Dim fEndDtTme As DateTime = TimeIn.Date + FTimeEnd.TimeOfDay
            Dim fEndDtTme2 As DateTime = TimeIn.Date.AddDays(1) + FTimeEnd.TimeOfDay

            If timeInTT = "AM" Then
                If TimeIn > fEndDtTme And TimeOut < fStartDtTme2 Then
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
            Return 0
        End If

    End Function

    Public Function overnyt(ByVal vehicle As String, ByVal strtTime As Date, ByVal EndTime As Date) As String
        Dim rs As New Recordset
        Dim strtme As Date
        Dim endtme As Date
        Dim dbStrTime As Date
        Dim dbEndTime As Date
        Dim cntOV As Integer
        Dim rate As Double

        
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblOvernigth where VType = '" & vehicle & "'")
        If rs.EOF = False Then

            strtme = Format(CDate(strtTime), "HH:mm:ss tt")
            endtme = Format(CDate(EndTime), "HH:mm:ss tt")

            dbStrTime = Format(CDate(rs("TimeStart").Value), "HH:mm:ss tt")
            dbEndTime = Format(CDate(rs("TimeEnd").Value), "HH:mm:ss tt")
            rate = rs("RateCharge").Value

            cntOV = 0
            cntOV = DateDiff(DateInterval.Day, strtTime, EndTime)

            If cntOV > 0 Then
                If dbStrTime > dbEndTime Then
                    If strtme <= dbStrTime And endtme >= dbEndTime Then
                        OVcount = 0
                        OVcount = cntOV + 1
                        Dim ttamt As Double = rate * 1
                        Return Format(Math.Round(ttamt, 2), "#,###.00")
                    Else

                    End If
                Else

                End If
            Else
                If dbStrTime > dbEndTime Then

                Else

                End If
            End If

            If cntOV > 0 Then
                If (Val(dbStrTime) <= Val(endtme) And Val(endtme) >= Val(dbEndTime)) Or (Val(dbStrTime) <= Val(endtme) And Val(endtme) <= Val(dbEndTime)) Then
                    OVcount = 0
                    OVcount = cntOV + 1
                    Dim ttamt As Double = rate * 1
                    Return Format(Math.Round(ttamt, 2), "#,###.00")
                Else
                    OVcount = 0
                    OVcount = cntOV
                    Dim ttamt As Double = rate * cntOV
                    Return Format(Math.Round(ttamt, 2), "#,###.00")
                End If
            Else
                If (Val(dbStrTime) <= Val(endtme) And Val(endtme) >= Val(dbEndTime)) Or (Val(dbStrTime) <= Val(endtme) And Val(endtme) <= Val(dbEndTime)) Then
                    OVcount = 0
                    OVcount = 1
                    Dim ttamt As Double = rate * 1
                    Return Format(Math.Round(ttamt, 2), "#,###.00")
                Else
                    OVcount = 0
                    Return "0.00"
                End If
            End If
        Else
            OVcount = 0
            Return "0.00"
        End If
    End Function

    Public Function VAT(ByVal TotalAmt As Double) As String
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
    End Function

    Public Function subTotal(ByVal totalAmt As Double, ByVal VatAmt As Double) As String
        Dim subTt As Double
        subTt = Val(totalAmt) - Val(VatAmt)
        If subTt = 0 Then Return "0.00"
        subTotal = MakeMoney(subTt)
    End Function

    Public Function totalAmount(ByVal AmtDue As Double, ByVal Overnigth As Double, ByVal lost As Double) As String
        Dim ttamount As Double
        ttamount = AmtDue + Overnigth + lost
        If ttamount = 0 Then Return "0.00"
        totalAmount = MakeMoney(ttamount)
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

    Function MakeMoney(ByVal val As Double) As String
        Dim pera As String
        pera = Replace(FormatCurrency(val, 2), "$", vbNullString)
        Return Replace(pera, "₱", vbNullString)
    End Function
End Module
