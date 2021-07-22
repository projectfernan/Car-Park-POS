Imports System.Drawing.Printing
Imports ADODB
Module STATION_LOGOUT
    Public PetsaBuss As Date
    Public ShiftFrm As Date
    Public ShiftTo As Date
    Public WithEvents stLOPrint As PrintDocument '

    Public Sub stPrntLO(ByVal dtFrm As Date, ByVal dtTo As Date)

        ShiftFrm = dtFrm
        ShiftTo = dtTo

        stLOPrint = New PrintDocument
        ' Change the printer to the indicated printer
        stLOPrint.PrinterSettings.PrinterName = PRINTER_NAME

        If stLOPrint.PrinterSettings.IsValid Then
            stLOPrint.DocumentName = "Station Log-Out Report"
            ' Start printing
            Dim pp As New Printing.StandardPrintController
            stLOPrint.PrintController = pp
            stLOPrint.Print()
            stLOPrint.Dispose()
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub stLOPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles stLOPrint.PrintPage

        Dim x As Integer = 2, y As Integer = 4, lineOffset As Integer

        ' Instantiate font objects used in printing.
        Dim printFont As New Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point) 'Substituted to FontA Font

        e.Graphics.PageUnit = GraphicsUnit.Point
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        ' Print the receipt text
        y += (lineOffset * 1.0)
        e.Graphics.DrawString(My.Settings.TITLE, printFont, Brushes.Black, x, y - 9)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        lineOffset = printFont.GetHeight(e.Graphics) - 4

        y += (lineOffset * 2.75)
        e.Graphics.DrawString(My.Settings.ADDR, printFont, Brushes.Black, x, y - 9)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" Contact No.: " & My.Settings.CONTACT, printFont, Brushes.Black, x - 2, y - 9)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" Permit #: ", printFont, Brushes.Black, x - 2, y - 5)
        e.Graphics.DrawString(My.Settings.PERMIT, printFont, Brushes.Black, x + 57, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" TIN : ", printFont, Brushes.Black, x - 2, y - 5)
        e.Graphics.DrawString(My.Settings.TIN, printFont, Brushes.Black, x + 57, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" Accr #: ", printFont, Brushes.Black, x - 2, y - 5)
        e.Graphics.DrawString(My.Settings.ACCR, printFont, Brushes.Black, x + 57, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Machine #:", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(My.Settings.MACHINE, printFont, Brushes.Black, x + 57, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("SN #:", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(My.Settings.SERIAL, printFont, Brushes.Black, x + 57, y - 5)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        y += (lineOffset * 0.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 4)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("STATION'S  LOG-OUT  REPORT", printFont, Brushes.Black, x + 22, y - 5)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 6)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font


        'Dim strOp As String = OperatorName
        Dim strStation As String = MainForm.txtStation.Text

        Dim FromOr As String = sOrFrom(strStation)
        Dim ToOr As String = sOrTo(strStation)

        Dim NetSale As Double = sTotalNet(strStation)
        Dim VatAmt As Double = VAT(NetSale)
        Dim VatSale As Double = Comp_Vat_sale(NetSale, VatAmt)

        'y += (lineOffset * 3.0)
        'e.Graphics.DrawString("Date : ", printFont, Brushes.Black, x, y - 5)
        'e.Graphics.DrawString(Format(Now, "yyyy-MM-dd"), printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Bussines Date: ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(My.Settings.BussDate, "yyyy-MM-dd"), printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Time From : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(ShiftFrm, "yyyy-MM-dd HH:mm:ss"), printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Time To : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(ShiftTo, "yyyy-MM-dd HH:mm:ss"), printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Station : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strStation, printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("From ORno :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(FromOr, printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("To ORno :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(ToOr, printFont, Brushes.Black, x + 65, y - 5)


        y += (lineOffset * 1.6)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 3)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("Cashier Summary", printFont, Brushes.Black, x, y - 5)
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        Dim strBussDate As String = Format(PetsaBuss, "yyyy-MM-dd")
        Dim strFrm As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
        Dim strTo As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
        'Dim strTime2 As String = Format(time2, "yyyy-MM-dd HH:mm:ss")
        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlPOS.Execute("select Operator,Count(Operator)as OpCount,sum(total)as OpTotalAmt from tblincomereport where Station = '" & strStation & "' and TimeOut >= '" & strFrm & "' and  TimeOut <= '" & strTo & "' group by Operator")
        Do While rs.EOF = False
            Dim kahera As String = rs("Operator").Value
            Dim TotalbyKahera As Double = rs("OpTotalAmt").Value
            Dim time1 As Date = SDtinFrm(kahera, strStation)
            Dim time2 As Date = SDtOutTo(kahera, strStation)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Cashier :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(kahera, printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Time From :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(time1, printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Time To :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(time2, printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Cashier Total Sales :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(TotalbyKahera), printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 1.0)
            e.Graphics.DrawString("                     ", printFont, Brushes.Black, x, y - 5)

            rs.MoveNext()
        Loop

        y += (lineOffset * 1.0)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 3)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("Transaction Summary", printFont, Brushes.Black, x, y - 5)
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        Dim TotalTrans As Integer = sTotalTR(strStation)
        Dim VipTotalCnt As Integer = VipOutCount(ShiftFrm, ShiftTo) + VipInOutCount(ShiftFrm, ShiftTo)
        Dim TotalGraceCnt As Integer = 0
        Dim TotalGraceCntM As Integer = 0
        Dim TotalLostCnt As Integer = 0
        Dim TotalTrCount As Integer = 0
        Dim TotalRetail As Integer = 0
        Dim TotalMotor As Integer = 0
        Dim TotalManual As Integer = 0


        Dim rsVeh As New Recordset
        rsVeh = New Recordset

        rsVeh = conSqlPOS.Execute("select VehicleType from tblcharge")

        If rsVeh.EOF = False Then
            Dim VehTyp As String
            Do While rsVeh.EOF = False
                VehTyp = rsVeh("VehicleType").Value
                Dim rs1 As New Recordset
                rs1 = New Recordset

                rs1 = conSqlPOS.Execute("select Count(VehicleType)as VehicleCount from tblincomereport where PayType = 'GracePeriod' and VehicleType = '" & VehTyp & "' and Station = '" & strStation & "' and TimeOut >= '" & strFrm & "' and  TimeOut <= '" & strTo & "'")
                Do While rs1.EOF = False
                    TotalGraceCnt = TotalGraceCnt + Val(rs1("VehicleCount").Value)
                    If Val(rs1("VehicleCount").Value) <> 0 Then
                        y += (lineOffset * 2.0)
                        e.Graphics.DrawString("GP " & VehTyp, printFont, Brushes.Black, x, y - 5)
                        e.Graphics.DrawString(rs1("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
                        e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)
                    End If
                    rs1.MoveNext()
                Loop

                rsVeh.MoveNext()
            Loop
        End If


        y += (lineOffset * 2.0)
        e.Graphics.DrawString("VIP", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(VipTotalCnt, printFont, Brushes.Black, x + 85, y - 5)
        e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)

        Dim rs3 As New Recordset
        rs3 = New Recordset

        rs3 = conSqlPOS.Execute("select VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt from tblincomereport where Station = '" & strStation & "' and PayType <> 'GracePeriod' and PayType <> 'Manual' and LostCard = 0 and TimeOut >= '" & strFrm & "' and  TimeOut <= '" & strTo & "' group by VehicleType")
        Do While rs3.EOF = False
            TotalRetail = TotalRetail + Val(rs3("VehicleCount").Value)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(rs3("VehicleType").Value, printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs3("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(rs3("VehicleTotalAmt").Value), printFont, Brushes.Black, x + 105, y - 5)
            rs3.MoveNext()
        Loop

        Dim rs2 As New Recordset
        rs2 = New Recordset

        rs2 = conSqlPOS.Execute("select Count(LostCard)as LostCount,Sum(total) as LostAmt from tblincomereport where LostCard > 0 and Station = '" & strStation & "' and TimeOut >= '" & strFrm & "' and  TimeOut <= '" & strTo & "'")
        Do While rs2.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("LOST CARD", printFont, Brushes.Black, x, y - 5)
            TotalLostCnt = rs2("LostCount").Value
            e.Graphics.DrawString(rs2("LostCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            If TotalLostCnt = 0 Then
                e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)
            Else
                e.Graphics.DrawString("P " & MakeMoney(rs2("LostAmt").Value), printFont, Brushes.Black, x + 105, y - 5)
            End If
            rs2.MoveNext()
        Loop

        Dim rs4 As New Recordset
        rs4 = New Recordset

        rs4 = conSqlPOS.Execute("select Count(PayType)as ManCount,Sum(total) as ManAmt from tblincomereport where PayType = 'Manual' and Station = '" & strStation & "' and TimeOut >= '" & strFrm & "' and  TimeOut <= '" & strTo & "'")
        Do While rs4.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("MANUAL INPUT", printFont, Brushes.Black, x, y - 5)
            TotalManual = rs4("ManCount").Value
            e.Graphics.DrawString(rs4("ManCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            If TotalManual = 0 Then
                e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)
            Else
                e.Graphics.DrawString("P " & MakeMoney(Val(rs4("ManAmt").Value)), printFont, Brushes.Black, x + 105, y - 5)
            End If
            rs4.MoveNext()
        Loop

        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total Transaction : ", printFont, Brushes.Black, x, y - 5)
        TotalTrCount = TotalGraceCnt + VipTotalCnt + TotalLostCnt + TotalRetail + TotalMotor + TotalGraceCntM + TotalManual
        e.Graphics.DrawString(TotalTrCount, printFont, Brushes.Black, x + 85, y - 5)

        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Total Sales :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(NetSale), printFont, Brushes.Black, x + 105, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total VAT :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(VatAmt), printFont, Brushes.Black, x + 105, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total VAT Sales :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(VatSale), printFont, Brushes.Black, x + 105, y - 5)


        y += (lineOffset * 6.5)
        e.Graphics.DrawString("Signature : _________________________________________________", printFont, Brushes.Black, x, y - 15)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("****** END OF REPORT ******", printFont, Brushes.Black, x - 2, y - 5)


        'BARCODE SAMPLE "---------------------------------------------------------------------------------------------------------------"
        'y += (lineOffset * 2.0)
        'e.Graphics.DrawString("*" & "ABC123" & "*", barcodefont, Brushes.Black, x, y - 20)
        e.HasMorePages = False
    End Sub



    Public Function sOrFrom(ByVal Station As String) As String
        If conServer() = False Then Return "-"
        Try

            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Min(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and TimeOut >= '" & strp1 & "' and  TimeOut <= '" & strp2 & "'")
            If rs.EOF = False Then
                Return rs("MinOr").Value.ToString()
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function sOrTo(ByVal Station As String) As String
        If conServer() = False Then Return "-"
        Try
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Max(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and TimeOut >= '" & strp1 & "' and  TimeOut <= '" & strp2 & "'")
            If rs.EOF = False Then
                Return rs("MinOr").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function sTotalTR(ByVal Station As String) As Integer
        If conServer() = False Then Return 0
        Try
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from tblincomereport where Station = '" & Station & "' and VehicleType <> 'RETAIL' and VehicleType <> 'MOTOR' and TimeOut >= '" & strp1 & "' and  TimeOut <= '" & strp2 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function sTotalNet(ByVal Station As String) As Double
        If conServer() = False Then Return 0
        Try
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select sum(Total) as TotalNet from tblincomereport where Station = '" & Station & "' and TimeOut >= '" & strp1 & "' and  TimeOut <= '" & strp2 & "'")
            If rs.EOF = False Then
                Return rs("TotalNet").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function SDtinFrm(ByVal operatorC As String, ByVal Station As String) As String
        'If conServer() = False Then Return "-"
        Try
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Min(TimeOut) as MinTime from tblincomereport where Station = '" & Station & "' and Operator = '" & operatorC & "' and TimeOut >= '" & strp1 & "' and  TimeOut <= '" & strp2 & "'")
            If rs.EOF = False Then
                Return rs("MinTime").Value.ToString()
            Else
                Return Now
            End If
        Catch ex As Exception
            Return Now
        End Try
    End Function

    Public Function SDtOutTo(ByVal operatorC As String, ByVal Station As String) As String
        'If conServer() = False Then Return "-"
        Try
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Max(TimeOut) as MaxTime from tblincomereport where Station = '" & Station & "' and Operator = '" & operatorC & "' and TimeOut >= '" & strp1 & "' and  TimeOut <= '" & strp2 & "'")
            If rs.EOF = False Then
                Return rs("MaxTime").Value.ToString()
            Else
                Return Now
            End If
        Catch ex As Exception
            Return Now
        End Try
    End Function
End Module
