Module TimeComputation
   
    '-----------------------
    'Divided data string 
    Public YRin As String
    Public MMin As String
    Public DDin As String

    Public YRout As String
    Public MMout As String
    Public DDout As String

    Public HHin As String
    Public MinIn As String
    Public SSin As String

    Public HHout As String
    Public MinOut As String
    Public SSout As String
    '-----------------------
    'For time Category
    Public HH As String
    Public DD As String
    Public MM As String
    Public YR As String
    '-----------------------
    'For Rate computation
    Public gThr As Integer
    Public min As String
    Public Mins As String
    '-----------------------
    Public HHmin As String

    Public Sub dtData(ByVal dtIn As String, ByVal dtOut As String)
        tmeIn = Format(CDate(dtIn), "HH:mm:ss tt")
        tmeOut = Format(CDate(dtOut), "HH:mm:ss tt")

        dteIn = Format(CDate(dtIn), "yyyy-MM-dd")
        dteOut = Format(CDate(dtOut), "yyyy-MM-dd")

        YRin = Mid(dteIn, 1, 4)
        MMin = Mid(dteIn, 6, 2)
        DDin = Mid(dteIn, 9, 2)

        YRout = Mid(dteOut, 1, 4)
        MMout = Mid(dteOut, 6, 2)
        DDout = Mid(dteOut, 9, 2)

        HHin = Mid(tmeIn, 1, 2)
        MinIn = Mid(tmeIn, 4, 2)
        SSin = Mid(tmeIn, 8, 2)

        HHout = Mid(tmeOut, 1, 2)
        MinOut = Mid(tmeOut, 4, 2)
        SSout = Mid(tmeOut, 8, 2)

    End Sub

    Public Function yrVer() As Boolean
        If YRin < YRout Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function mmVer() As Boolean
        If MMin < MMout Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ddVer() As Boolean
        If DDin < DDout Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function HHVer() As Boolean
        If HHin < HHout Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function MinVer() As Boolean
        If MinIn < MinOut Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub Yrmn()
        Dim total As String
        Dim gtt As String
        'Dim ttotal As String

        total = Val(YRout) - Val(YRin)
        gtt = Val(total) * 12
        If MMin < MMout Then
            Dim tt As String
            tt = Val(MMout) - Val(MMin)
            gtt = Val(gtt) + Val(tt)
        ElseIf MMin > MMout Then
            Dim tt As String
            tt = Val(MMin) - Val(MMout)
            gtt = Val(gtt) - Val(tt)
        End If

        Dim md As String
        md = Val(gtt) * 30
        If DDin < DDout Then
            Dim tt As String
            tt = Val(DDout) - Val(DDin)
            md = Val(md) + Val(tt)
        ElseIf DDin > DDout Then
            Dim tt As String
            tt = Val(DDin) - Val(DDout)
            md = Val(md) - Val(tt)
        End If

        Dim totalHr As String
        totalHr = Val(md) * 24
        If HHin < HHout Then
            Dim tt As String
            tt = Val(HHout) - Val(HHin)
            totalHr = Val(totalHr) + Val(tt)
        ElseIf HHin > HHout Then
            Dim tt As String
            tt = Val(HHin) - Val(HHout)
            totalHr = Val(totalHr) - Val(tt)
        End If

        YR = Val(totalHr) * 60
        If MinIn < MinOut Then
            Dim dif As String
            dif = Val(MinOut) - Val(MinIn)
            YR = Val(YR) + Val(dif)
        ElseIf MinIn > MinOut Then
            Dim dif As String
            dif = Val(MinIn) - Val(MinOut)
            YR = Val(YR) - Val(dif)
        End If
    End Sub
    Sub MMmn()
        Dim total As String
        Dim gtt As String

        total = Val(MMout) - Val(MMin)
        gtt = Val(total) * 30

        If DDin < DDout Then
            Dim ddf As String
            ddf = Val(DDout) - Val(DDin)
            gtt = Val(gtt) + Val(ddf)
        ElseIf DDin > DDout Then
            Dim ddf2 As String
            ddf2 = Val(DDin) - Val(DDout)
            gtt = Val(gtt) - Val(ddf2)
        End If

        Dim totalHr As String
        totalHr = Val(gtt) * 24
        If HHin < HHout Then
            Dim tt As String
            tt = Val(HHout) - Val(HHin)
            totalHr = Val(totalHr) + Val(tt)
        ElseIf HHin > HHout Then
            Dim tt As String
            tt = Val(HHin) - Val(HHout)
            totalHr = Val(totalHr) - Val(tt)
        End If

        MM = Val(totalHr) * 60
        If MinIn < MinOut Then
            Dim dif As String
            dif = Val(MinOut) - Val(MinIn)
            MM = Val(MM) + Val(dif)
        ElseIf MinIn > MinOut Then
            Dim dif As String
            dif = Val(MinIn) - Val(MinOut)
            MM = Val(MM) - Val(dif)
        End If
    End Sub
    Sub DDmn()
        Dim total As String
        Dim Htotal As String
        'Dim Gtotal As String
        If DDin < DDout Then
            total = Val(DDout) - Val(DDin)
            Htotal = Val(total) * 24

            If HHin < HHout Then
                Dim dif As String
                dif = Val(HHout) - Val(HHin)
                Htotal = Val(Htotal) + Val(dif)
            ElseIf HHin > HHout Then
                Dim dif As String
                dif = Val(HHin) - Val(HHout)
                Htotal = Val(Htotal) - Val(dif)
            End If
            DD = Val(Htotal) * 60

            If MinIn < MinOut Then
                Dim dif As String
                dif = Val(MinOut) - Val(MinIn)
                DD = Val(DD) + Val(dif)
            ElseIf MinIn > MinOut Then
                Dim dif As String
                dif = Val(MinIn) - Val(MinOut)
                DD = Val(DD) - Val(dif)
            End If
        End If
    End Sub
    Sub tmeMin()
        Dim total As String

        If tmeIn < tmeOut Then
            total = Val(tmeOut) - Val(tmeIn)
            HHmin = total
        End If

    End Sub
    Sub HHmn()
        Dim total As String
        If HHin < HHout Then
            total = Val(HHout) - Val(HHin)
            HH = Val(total) * 60
            If MinIn < MinOut Then
                Dim dif As String
                dif = Val(MinOut) - Val(MinIn)
                HH = Val(HH) + Val(dif)
            ElseIf MinIn > MinOut Then
                Dim dif As String
                dif = Val(MinIn) - Val(MinOut)
                HH = Val(HH) - Val(dif)
            End If
        End If
    End Sub

    Function Minute() As String
        If HHin = HHout And MinIn < MinOut Then
            Minute = Val(MinOut) - Val(MinIn)
        Else
            Minute = 0
        End If
    End Function

    Function timeHH() As String
        Dim totalMin As String
        Dim gThr As Integer
        Dim min As String

        totalMin = Val(HHmin) * 60
        gThr = Val(totalMin) / 60
        min = gThr Mod 24
        timeHH = totalMin

    End Function

    Function totalTime() As String
        If yrVer() = True Then  'For Year
            Yrmn()              'YY - MM - DD - HH - MIN
            totalTime = Val(YR) / 60
            Exit Function
        Else
            If mmVer() = True Then 'For Month
                MMmn()             'MM - DD - HH - MIN
                totalTime = Val(MM) / 60
                Exit Function
            Else
                If ddVer() = True Then 'For Day
                    DDmn()             'DD - HH - MIN
                    totalTime = Val(DD) / 60
                    Exit Function
                Else
                    If HHVer() = True Then 'For Hourly
                        HHmn()             'HH - MIN
                        totalTime = Val(HH) / 60
                        Exit Function
                    Else
                        If MinVer() = True Then 'For Minute
                            totalTime = Val(Minute) / 60 'MIN - MIN
                            Exit Function
                        Else
                            totalTime = 0
                        End If
                    End If
                End If
            End If
        End If
    End Function

End Module
