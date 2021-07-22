Imports ADODB
Module CHARGING_FUNCTION
    Public iout As Date
    Public LostIn As Date
    'Data Strings for IN and Out
    Public dteIn As String
    Public dteOut As String
    Public tmeIn As Date
    Public tmeOut As Date
    Public OVcount As Integer

    Public Over_count As Long = 0
    Public Count_Days As Long = 0

    Public TotalAmt As Double

    Public Function TotalTime_FUNCTION(ByVal tmeIN As Date, ByVal tmeOUT As Date) As String
        Try
            Dim MIN As Long = DateDiff("n", tmeIN, tmeOUT)
            Dim hh As Integer = DateDiff("h", tmeIN, tmeOUT)


            If MIN > 0 Then
                If MIN >= 60 Then
                    Dim tHH As Long = hh
                    Dim tExcessMin As Long = CLng(MIN Mod 60)
                    Return tHH & " Hr and " & tExcessMin & " Mins"
                Else
                    Return "0 Hr and " & MIN & " Mins"
                End If
            Else
                Return "0 Hr and 0 Mins"
            End If

        Catch ex As Exception
            Return "0 Hr and 0 Mins"
        End Try
    End Function

    Public Function HourLy_RATE(ByVal Vehicle As String, ByVal tmeIN As Date, ByVal tmeOUT As Date) As String
        Try
            Dim rs As New Recordset

            rs = conSqlLoc.Execute("select * from tblCharge where VehicleType = '" & Vehicle & "'")
            If rs.EOF = False Then

                Dim grace As Long = rs("GracePeriod").Value
                Dim MinMins As Long = rs("MinMinutes").Value
                Dim MinAmt As Double = rs("MinAmount").Value
                Dim IntAmt As Double = rs("IntAmount").Value
                Dim MIN As Long = DateDiff(DateInterval.Minute, tmeIN, tmeOUT)

                Dim Min1 As Long = CLng(MIN Mod 60)

                If MIN <= grace Then
                    Return "0.00"
                ElseIf MIN <= MinMins Then
                    Return MakeMoney(MinAmt)
                ElseIf MIN > MinMins Then
                    Dim Excess As Double = MIN - MinMins
                    If Excess > 60 Then

                        Dim excessHr As Long = Excess / 60
                        If Min1 > 0 And Min1 <= 30 Then
                            Dim totalIntamt As Double = (excessHr * IntAmt) + IntAmt
                            Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                            Return MakeMoney(MinAmt_IntAmt)
                        Else
                            Dim totalIntamt As Double = excessHr * IntAmt
                            Dim MinAmt_IntAmt As Double = MinAmt + totalIntamt
                            Return MakeMoney(MinAmt_IntAmt)
                        End If

                    Else
                        Dim MinAmt_IntAmt As Double = MinAmt + IntAmt
                        Return MakeMoney(MinAmt_IntAmt)
                    End If
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

    Public Function Compute_FlateRATE(ByVal vtype As String, ByVal Timein As Date, ByVal Timeout As Date) As String
        If conLocal() = False Then Return "0.00"
        Dim rs As New Recordset
        Try
            rs = conSqlLoc.Execute("SELECT * FROM tblCharge WHERE VehicleType= '" & vtype & "'")
            If rs.EOF = False Then
                Dim F As Double = rs("FlatRate").Value
                Dim TD As Long = DateDiff(DateInterval.Hour, Timein, Timeout)

                If TD > 24 Then
                    Dim D As Integer = TD / 24
                    Dim tt As Double = F * D
                    Return Format(Math.Round(tt, 2), "#,###.00")
                Else
                    Return Format(Math.Round(F, 2), "#,###.00")
                End If
            Else
                Return "0.00"
            End If
        Catch ex As Exception
            Return "0.00"
        End Try
    End Function

    Function GETovernyt(ByVal TimeIn As Date, ByVal TimeOut As Date, ByVal Vehicle As String) As Double

        Dim ax As Date = TimeIn.Date
        Dim bx As Date = TimeOut.Date
        Over_count = 0
        Count_Days = 0
        GETovernyt = 0

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

            Dim TimeInterv As Date = "00:00:00"

            Dim dtTimeIn As Date = Format(TimeIn, "yyyy-MM-dd")
            Dim dtTimeOut As Date = Format(TimeOut, "yyyy-MM-dd")

            FTimeIn = Format(TimeIn, "HH:mm tt")
            FTimeOut = Format(TimeOut, "HH:mm tt")
            FTimeStart = Format(StartTime, "HH:mm tt")
            FTimeEnd = Format(EndTime, "HH:mm tt")

            Dim DtDiffInOut As Long = DateDiff(DateInterval.Hour, FTimeStart, FTimeOut)
            Dim dtDiffStartEnd As Long = DateDiff(DateInterval.Hour, FTimeStart, FTimeEnd)
            Dim dtHRdiff As Long = DateDiff(DateInterval.Hour, FTimeIn, FTimeEnd)

            If dtTimeIn < dtTimeOut Then
                If FTimeIn <= FTimeStart And FTimeOut <= FTimeEnd Or FTimeIn >= FTimeStart And FTimeOut >= FTimeEnd Or FTimeIn >= FTimeStart And FTimeOut <= FTimeEnd Then
                    Count_Days = DateDiff(DateInterval.Day, TimeIn, TimeOut)
                    Over_count = Count_Days
                    If Count_Days = 0 Then
                        If DtDiffInOut >= dtDiffStartEnd Then
                            Over_count = Count_Days + 1
                        End If
                    Else
                        If DtDiffInOut <= dtDiffStartEnd Then
                            If DtDiffInOut >= dtDiffStartEnd Then
                                Over_count = Count_Days + 1
                            End If
                        Else
                            If DtDiffInOut >= dtDiffStartEnd Then
                                Over_count = Count_Days + 1
                            End If
                        End If
                    End If
                End If
                Return Amount * Over_count
            Else
                Count_Days = DateDiff(DateInterval.Day, TimeIn, TimeOut)
                If DtDiffInOut <= dtDiffStartEnd Then
                    If DtDiffInOut >= dtDiffStartEnd Then
                        Over_count = Count_Days + 1
                    End If
                Else
                    If FTimeStart > FTimeEnd Then
                        If FTimeOut > FTimeStart Then
                            If DtDiffInOut >= dtDiffStartEnd Then
                                Over_count = Count_Days + 1
                            End If
                        End If
                    Else
                        If FTimeIn <= FTimeEnd Then
                            If dtHRdiff >= dtDiffStartEnd Then
                                Over_count = Count_Days + 1
                            End If
                        End If
                    End If
                End If
                Return Amount * Over_count
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
            Return Format(Math.Round(vt, 2), "#,###.00")
        Else
            Return "0.00"
        End If
    End Function

    Public Function subTotal(ByVal totalAmt As Double, ByVal VatAmt As Double) As String
        Dim subTt As String
        subTt = Val(totalAmt) - Val(VatAmt)
        If subTt = 0 Then Return "0.00"
        subTotal = Format(Math.Round(Val(subTt), 2), "#,###.00")
    End Function

    Public Function totalAmount(ByVal AmtDue As Double, ByVal Overnigth As Double, ByVal lost As Double) As String
        Dim ttamount As Double
        ttamount = AmtDue + Overnigth + lost
        If ttamount = 0 Then Return "0.00"
        totalAmount = Format(Math.Round(ttamount, 2), "#,###.00")
    End Function

    Function MakeMoney(ByVal val As Double) As String
        MakeMoney = Replace(FormatCurrency(val, 2), "$", vbNullString)
    End Function
End Module
