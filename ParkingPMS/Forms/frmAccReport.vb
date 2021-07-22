Imports System.Threading
Imports Excel = Microsoft.Office.Interop.Excel
Imports ADODB
Public Class frmAccReport
    Public PetsaBuss As Date
    Public ShiftFrm As Date
    Public ShiftTo As Date
    Public LVtypeCnt As Long
    Public LVtypeCnt2 As Long
    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Public Function sumOrFrom(ByVal Station As String, ByVal petsa1 As Date) As String
        If conLocal() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select Min(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("MinOr").Value.ToString()
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function sumOrTo(ByVal Station As String, ByVal petsa1 As Date) As String
        If conLocal() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select Max(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("MinOr").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function sumTotalTR(ByVal petsa1 As Date, ByVal petsa2 As Date) As Integer
        If conLocal() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblincomereport where VehicleType <> 'RETAIL' and VehicleType <> 'MOTOR' and BussDate between '" & dt1 & "' and '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function sumTotalNet(ByVal Petsa1 As Date, ByVal Petsa2 As Date) As Double
        If conLocal() = False Then Return 0
        Try
            Dim dt1 As String = Format(Petsa1, "yyyy-MM-dd")
            Dim dt2 As String = Format(Petsa2, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select sum(Total) as TotalNet from tblincomereport where BussDate between '" & dt1 & "' and '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs("TotalNet").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Comp_Vat_sale(ByVal totalAmt As Double, ByVal Vat As Double) As Double
        Return totalAmt - Vat
    End Function

    Public Function VipOutCount(ByVal dtFrm As Date, ByVal dtTo As Date) As Integer
        If conLocal() = False Then Return 0

        Dim petsa1 As String = Format(dtFrm, "yyyy-MM-dd HH:mm:00")
        Dim petsa2 As String = Format(dtTo, "yyyy-MM-dd HH:mm:59")

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select count(CardCode) as VipCount from tbltimeout where TimeOut between '" & petsa1 & "' and '" & petsa2 & "'")
            If rs.EOF = False Then
                Return rs("VipCount").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function VipInOutCount(ByVal dtFrm As Date, ByVal dtTo As Date) As Integer
        If conLocal() = False Then Return 0

        Dim petsa1 As String = Format(dtFrm, "yyyy-MM-dd HH:mm:00")
        Dim petsa2 As String = Format(dtTo, "yyyy-MM-dd HH:mm:59")

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select count(CardCode) as VipCount from tbllogsrec where TimeOut between '" & petsa1 & "' and '" & petsa2 & "'")
            If rs.EOF = False Then
                Return CInt(rs("VipCount").Value)
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Function GetSlot() As Long
        If conLocal() = False Then Return 0

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from parkingslot")
            If rs.EOF = False Then
                Return rs("TOTAL").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub cmdGene_Click(sender As System.Object, e As System.EventArgs) Handles cmdGene.Click
        'On Error GoTo Err_Handler

        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range
        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True
        ' Add a new workbook.
        wbXl = appXL.Workbooks.Add
        shXL = wbXl.ActiveSheet
        'Title
        shXL.Range("A1", "XFD1").Merge()
        shXL.Range("A1").Value = "AYALA PROPERTY MANAGEMENT CORPORATION"
        With shXL.Range("A1")
            .Font.Bold = True
            .Font.FontStyle = "Bell MT"
            .Font.Size = 20
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        shXL.Range("A2", "XFD2").Merge()
        shXL.Range("A2").Value = "ACCOUNTABILITY SUMMARY" ' 
        With shXL.Range("A1")
            .Font.Bold = True
            .Font.FontStyle = "Bell MT"
            .Font.Size = 14
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim strfrm As String = Format(Da1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim strTo As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")

        shXL.Range("A4", "XFD4").Merge()
        shXL.Range("A4").Value = "Date From : " & strfrm
        With shXL.Range("A4")
            .Font.Bold = True
            .Font.FontStyle = "Bell MT"
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        shXL.Range("A5", "XFD5").Merge()
        shXL.Range("A5").Value = "Date To : " & strTo
        With shXL.Range("A5")
            .Font.Bold = True
            .Font.FontStyle = "Bell MT"
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        With shXL.Range("B7:XFD7")
            .Font.Bold = True
            .Font.Size = 11
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        With shXL.Range("A7:A1048576")
            .Font.Bold = True
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        'shXL.Cells(3, 1).Value = " "


        Dim NetSale As Double = sumTotalNet(Da1.Value, Da2.Value)
        Dim VatAmt As Double = VAT(NetSale)
        Dim VatSale As Double = Comp_Vat_sale(NetSale, VatAmt)

        Dim strIndt As String = Format(Da1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim strOutdt As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")

        Dim NoOfdays As Long = DateDiff(DateInterval.Day, Da1.Value, Da2.Value)
        If NoOfdays = 0 Then NoOfdays = 1
        Dim TotalNoSlots As Long = GetSlot()

        Dim TotalTrans As Integer = sumTotalTR(Da1.Value, Da2.Value)
        Dim VipTotalCnt As Integer = VipOutCount(Da1.Value, Da2.Value) + VipInOutCount(Da1.Value, Da2.Value)
        Dim TotalGraceCnt As Integer = 0
        Dim TotalGraceCntM As Integer = 0
        Dim TotalLostCnt As Integer = 0
        Dim TotalTrCount As Integer = 0
        Dim TotalRetail As Integer = 0
        Dim TotalMotor As Integer = 0


        With shXL.Range("B9:XFD9")
            .NumberFormat = "#,###,###.00"
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        shXL.Cells(7, 1).Value = "TransactionType"
        shXL.Cells(8, 1).Value = "Volume"
        shXL.Cells(9, 1).Value = "Total Amount"

        Dim rs1 As New Recordset
        rs1 = New Recordset

        rs1 = conSqlLoc.Execute("select Count(VehicleType)as VehicleCount from tblincomereport where PayType = 'GracePeriod' and VehicleType = 'RETAIL' and BussDate between '" & strIndt & "' and '" & strOutdt & "'")

        Do While rs1.EOF = False
            shXL.Cells(7, 2).Value = "GP RETAIL"
            shXL.Cells(8, 2).Value = rs1("VehicleCount").Value
            shXL.Cells(9, 2).Value = "0"
            TotalGraceCnt = rs1("VehicleCount").Value
            rs1.MoveNext()
        Loop

        Dim rs6 As New Recordset
        rs6 = New Recordset

        rs6 = conSqlLoc.Execute("select Count(VehicleType)as VehicleCount from tblincomereport where PayType = 'GracePeriod' and VehicleType = 'MOTOR' and BussDate between '" & strIndt & "' and '" & strOutdt & "'")
        Do While rs6.EOF = False
            shXL.Cells(7, 3).Value = "GP MOTOR"
            shXL.Cells(8, 3).Value = rs6("VehicleCount").Value
            shXL.Cells(9, 3).Value = "0"
            TotalGraceCnt = rs6("VehicleCount").Value
            rs6.MoveNext()
        Loop

        shXL.Cells(7, 4).Value = "VIP"
        shXL.Cells(8, 4).Value = VipTotalCnt
        shXL.Cells(9, 4).Value = "0"

        Dim rs4 As New Recordset
        rs4 = New Recordset

        rs4 = conSqlLoc.Execute("select Total,VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt from tblincomereport where VehicleType = 'RETAIL' and Total > 0 and LostCard = 0 and BussDate between '" & strIndt & "' and '" & strOutdt & "' group by VehicleType")
        Do While rs4.EOF = False
            shXL.Cells(7, 5).Value = rs4("VehicleType").Value
            shXL.Cells(8, 5).Value = rs4("VehicleCount").Value
            shXL.Cells(9, 5).Value = rs4("VehicleTotalAmt").Value
            TotalRetail = rs4("VehicleCount").Value

            rs4.MoveNext()
        Loop

        Dim rs7 As New Recordset
        rs7 = New Recordset

        rs7 = conSqlLoc.Execute("select Total,VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt from tblincomereport where VehicleType = 'MOTOR' and Total > 0 and LostCard = 0 and BussDate between '" & strIndt & "' and '" & strOutdt & "' group by VehicleType")
        Do While rs7.EOF = False
            shXL.Cells(7, 6).Value = rs7("VehicleType").Value
            shXL.Cells(8, 6).Value = rs7("VehicleCount").Value
            shXL.Cells(9, 6).Value = rs7("VehicleTotalAmt").Value
            TotalMotor = rs7("VehicleCount").Value

            rs7.MoveNext()
        Loop

        Dim rs2 As New Recordset
        rs2 = New Recordset

        rs2 = conSqlLoc.Execute("select Count(LostCard)as LostCount,Sum(Total) as LostAmt,TimeOut from tblincomereport where LostCard > 0 and BussDate between '" & strIndt & "' and '" & strOutdt & "'")
        Do While rs2.EOF = False
            shXL.Cells(7, 7).Value = "LOST CARD"
            shXL.Cells(8, 7).Value = rs2("LostCount").Value
            TotalLostCnt = rs2("LostCount").Value
            shXL.Cells(9, 7).Value = TotalLostCnt

            If TotalLostCnt = 0 Then
                shXL.Cells(9, 7).Value = "0"
            Else
                shXL.Cells(9, 7).Value = rs2("LostAmt").Value
            End If

            rs2.MoveNext()
        Loop

        Dim rs3 As New Recordset
        rs3 = New Recordset

        rs3 = conSqlLoc.Execute("select VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt from tblincomereport where VehicleType <> 'RETAIL' and VehicleType <> 'MOTOR' and LostCard = 0 and BussDate between '" & strIndt & "' and '" & strOutdt & "' group by VehicleType")
        Do While rs3.EOF = False

            Dim lup As Long = 8

            shXL.Cells(7, lup).Value = rs3("VehicleType").Value
            shXL.Cells(8, lup).Value = rs3("VehicleCount").Value
            shXL.Cells(9, lup).Value = rs3("VehicleTotalAmt").Value

            lup = lup + 1

            LVtypeCnt = lup

            rs3.MoveNext()
        Loop

        Dim totalCell As Long = LVtypeCnt + 1
        TotalTrCount = TotalGraceCnt + VipTotalCnt + TotalTrans + TotalLostCnt + TotalRetail + TotalGraceCntM + TotalMotor

        shXL.Cells(7, totalCell).Value = "OVERALL TOTAL"
        shXL.Cells(8, totalCell).Value = TotalTrCount
        shXL.Cells(9, totalCell).Value = NetSale

        Dim AddCell As Long = totalCell + 1

        shXL.Cells(7, AddCell).Value = "NO. OF DAYS"
        shXL.Cells(8, AddCell).Value = NoOfdays
        shXL.Cells(9, AddCell).Value = 0


        Dim AddCell2 As Long = AddCell + 1
        Dim aveTurnSlot As Long = (TotalTrCount / TotalNoSlots) / NoOfdays
        shXL.Cells(7, AddCell2).Value = "AVERAGE TURN OVER SLOTS"
        shXL.Cells(8, AddCell2).Value = aveTurnSlot
        shXL.Cells(9, AddCell2).Value = 0

        Dim AddCell3 As Long = AddCell2 + 1
        Dim DailyRevSlot As Long = (NetSale / TotalNoSlots) / NoOfdays
        shXL.Cells(7, AddCell3).Value = "AVERAGE DAILY REVENUE SLOTS"
        shXL.Cells(8, AddCell3).Value = 0
        shXL.Cells(9, AddCell3).Value = DailyRevSlot

        shXL.Range("E12", "XFD12").Merge()
        shXL.Range("E12").Value = "CASHIER SUMMARY"
        With shXL.Range("E12")
            .Font.Bold = True
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        shXL.Cells(13, 3).Value = " "

        With shXL.Range("E14:XFD14")
            .Font.Bold = True
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        shXL.Cells(14, 5).Value = "ON DUTY"
        shXL.Cells(14, 6).Value = "VOLUME"
        shXL.Cells(14, 7).Value = "TOTAL REVENUE"


        With shXL.Range("G15:G1048576")
            .NumberFormat = "#,###,###.00"
            .Font.Size = 12
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlLoc.Execute("select Count(ORno) as TrVolume,MAX(ORno) as MaxOR,MIN(ORno) as MinOR,Operator,Count(Operator)as OpCount,sum(total)as OpTotalAmt from tblincomereport where BussDate between '" & strIndt & "' and '" & strOutdt & "' group by Operator")

        Dim lupD As Long = 15
        Do While rs.EOF = False
            Dim kahera As String = rs("Operator").Value
            Dim TotalbyKahera As Double = rs("OpTotalAmt").Value
            Dim ORfrm As String = rs("MinOR").Value
            Dim ORto As String = rs("MaxOR").Value
            Dim OpTRcnt As Long = rs("TrVolume").Value

            shXL.Cells(lupD, 5).Value = kahera
            shXL.Cells(lupD, 6).Value = OpTRcnt
            shXL.Cells(lupD, 7).Value = TotalbyKahera

            lupD = lupD + 1

            LVtypeCnt2 = lupD

            ' Sleep(100)
            ' System.Threading.Thread.CurrentThread.Sleep(5000)
            Threading.Thread.Sleep(100)

            rs.MoveNext()
        Loop

        Dim Lastcell As Long = LVtypeCnt2 + 1

        shXL.Cells(Lastcell, 1).Value = "Total Volume"
        shXL.Cells(Lastcell, 6).Value = TotalTrCount

        Dim lastcell2 As Long = Lastcell + 1
        shXL.Cells(lastcell2, 1).Value = "Overall Total Revenue"
        shXL.Cells(lastcell2, 7).Value = NetSale

        raXL = shXL.Range("A4", "XFD5")
        raXL.EntireColumn.AutoFit()
        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.
        appXL.Visible = True
        appXL.UserControl = True
        ' Release object references.
        raXL = Nothing
        shXL = Nothing
        wbXl = Nothing
        'appXL.Quit()
        appXL = Nothing
        Exit Sub
        'Err_Handler:
        '        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)
    End Sub
End Class