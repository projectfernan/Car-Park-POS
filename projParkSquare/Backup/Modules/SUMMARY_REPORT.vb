
Imports System.Drawing.Printing
Imports ADODB

Module SUMMARY_REPORT
   
    Public WithEvents SummPrint As PrintDocument '
    Dim ORfrm As String
    Dim ORto As String
    Public Sub Print(ByVal MSG As String)
        PrintData = PrintData & MSG & vbCrLf
    End Sub

    Public Sub Printf(ByVal MSG As String)
        PrintData = Replace(PrintData, "a", "") & MSG & vbCrLf
    End Sub

    Public Sub _P(ByVal MSG As String)
        'Dim p As New Printer_Config
        'p = Get_Printer_Config()

        'If p.IsOk = False Then
        'MsgBox("Printer is not Set", MsgBoxStyle.Exclamation)
        'Exit Sub
        'End If

        'Dim i As Integer = p.PrintCopy
        'For x As Integer = 1 To i
        Dim PrinterName As String = PRINTER_NAME
        RawPrinterHelper.SendStringToPrinter(PrinterName, MSG)
        'Next
        ' frmSummRep.picLoading.Visible = False
        Cursor.Current = Cursors.Arrow

        PrintData = vbNullString
        MSG = vbNullString
    End Sub

    Public Sub PrntSummLO(ByVal BussDate As Date)

        PetsaBuss = BussDate
        'RawPrinterHelper.SendStringToPrinter(PrinterName, MSG)

        'ShiftFrm = dtFrm
        'ShiftTo = dtTo

        SummPrint = New PrintDocument
        ' Change the printer to the indicated printer
        SummPrint.PrinterSettings.PrinterName = PRINTER_NAME

        If SummPrint.PrinterSettings.IsValid Then
            SummPrint.DocumentName = "Summary Report"
            ' Start printing
            Dim pp As New Printing.StandardPrintController

            SummPrint.PrintController = pp

            ' 
            SummPrint.Print()
            SummPrint.Dispose()
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Sub GetORminMax(ByVal BussPetsa As Date, ByVal St As String, ByVal Op As String)

        Try
            Dim strbussPetsa = Format(BussPetsa, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("call get_cashier_ORfrmTo('" & strbussPetsa & "','" & St & "','" & Op & "')")
            If rs.EOF = False Then
                ORfrm = rs("ORMIN").Value
                ORto = rs("ORMAX").Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub printSummRaw(ByVal BussDate As Date)

        Cursor.Current = Cursors.WaitCursor
        'frmSummRep.picLoading.Visible = True
        PetsaBuss = BussDate
        'Print the receipt text
        Dim output As String = Chr(&H1D) & "V" & Chr(66) & Chr(0)

        Print(My.Settings.TITLE)
        Print(My.Settings.ADDR)
        Print(" Contact No.: " & My.Settings.CONTACT)
        Print(" Permit #: " & My.Settings.PERMIT)
        Print(" TIN : " & My.Settings.TIN)
        Print(" Accr #: " & My.Settings.ACCR)
        Print(" Machine #:" & My.Settings.MACHINE)
        Print(" SN #:" & My.Settings.SERIAL)
        'Print("___________________________________________________________________________")
        Print("----------------------------------------")
        Print("SUMMARY REPORT")
        Print("----------------------------------------")

        'Dim strOp As String = OperatorName
        Dim strStation As String = frmMain.txtStation.Text

        Dim FromOr As String = sumOrFrom(strStation, PetsaBuss)
        Dim ToOr As String = sumOrTo(strStation, PetsaBuss)

        Dim NetSale As Double = sumTotalNet(strStation, PetsaBuss)
        Dim VatAmt As Double = VAT(NetSale)
        Dim VatSale As Double = Comp_Vat_sale(NetSale, VatAmt)

        'y += (lineOffset * 3.0)
        'e.Graphics.DrawString("Date : ", printFont, Brushes.Black, x, y - 5)
        'e.Graphics.DrawString(Format(Now, "yyyy-MM-dd"), printFont, Brushes.Black, x + 65, y - 5)


        Print("Bussines Date: " & Format(PetsaBuss, "yyyy-MM-dd"))
        Print("Station : " & strStation)
        Print("From ORno :" & FromOr)
        Print("To ORno :" & ToOr)

        Print("----------------------------------------")
        Print("Cashier Summary")
        Print("----------------------------------------")

        Dim strBussDate As String = Format(PetsaBuss, "yyyy-MM-dd")

        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlPOS.Execute("select Operator,sum(VehicleTotalAmt)as OpTotalAmt from vwecashiersumm where Station = '" & strStation & "' and BussDate like '" & strBussDate & "%' group by Operator")
        Do While rs.EOF = False
            Dim kahera As String = rs("Operator").Value
            Dim TotalbyKahera As Double = rs("OpTotalAmt").Value

            GetORminMax(PetsaBuss, strStation, kahera)

            Dim time1 As Date = DtinFrm(kahera, strStation, PetsaBuss)
            Dim time2 As Date = DtOutTo(kahera, strStation, PetsaBuss)

            Print("Cashier :" & kahera)
            Print("OR From :" & ORfrm)
            Print("OR To :" & ORto)

            Print("Time From :" & time1)
            Print("Time To :" & time2)
            Print("Cashier Total Sales : P " & MakeMoney(TotalbyKahera))
            Print("                     ")

            rs.MoveNext()
        Loop

        Print("----------------------------------------")
        Print("Transaction Summary")
        Print("----------------------------------------")

        Dim TotalTrans As Integer = sumTotalTR(strStation, PetsaBuss)
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
                '"select VehicleCount from vwegracecount where VehicleType = '" & VehTyp & "' and Station = '" & strStation & "' and Operator = '" & strOp & "' and BussDate = '" & strBussDate & "' limit 1;
                rs1 = conSqlPOS.Execute("select sum(VehicleCount) as VehicleCount from vwegracecount where VehicleType = '" & VehTyp & "' and Station = '" & strStation & "' and BussDate like '" & strBussDate & "%';")
                Do While rs1.EOF = False
                    Try
                        If Val(rs1("VehicleCount").Value) <> 0 Then
                            TotalGraceCnt = TotalGraceCnt + Val(rs1("VehicleCount").Value)
                            Print("GP  " & VehTyp & "  " & rs1("VehicleCount").Value & " P 0.00")
                        End If
                    Catch ex As Exception
                    End Try
                    rs1.MoveNext()
                Loop

                rsVeh.MoveNext()
            Loop
        End If


        Print("VIP " & VipTotalCnt & " P 0.00")

        Dim rs4 As New Recordset
        rs4 = New Recordset

        rs4 = conSqlPOS.Execute("select VehicleType,sum(VehicleCount) as VehicleCount,sum(VehicleTotalAmt) as VehicleTotalAmt from vwevehsumcount where Station = '" & strStation & "' and Paytype <> 'GracePeriod' and Paytype <> 'Manual' and LostCard = 0 and BussDate like '" & strBussDate & "%' group by VehicleType;")
        'select Total,VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt from tblincomereport where Station = '" & strStation & "' and PayType <> 'GracePeriod' and PayType <> 'Manual' and LostCard = 0 and BussDate like '" & strBussDate & "%' group by VehicleType")
        Do While rs4.EOF = False
            TotalRetail = TotalRetail + Val(rs4("VehicleCount").Value)
            Print(rs4("VehicleType").Value & "  " & rs4("VehicleCount").Value & "  P " & MakeMoney(rs4("VehicleTotalAmt").Value))
            rs4.MoveNext()
        Loop

        Dim rs2 As New Recordset
        rs2 = New Recordset

        rs2 = conSqlPOS.Execute("select sum(LostCount) as LostCount,Sum(LostAmt) as LostAmt from vwelostcount where Station = '" & strStation & "' and BussDate like '" & strBussDate & "%'") '"select Count(LostCard)as LostCount,Sum(Total) as LostAmt from tblincomereport where LostCard > 0 and Station = '" & strStation & "' and BussDate like '" & strBussDate & "%'")
        Do While rs2.EOF = False
            Try
                TotalLostCnt = rs2("LostCount").Value

                If TotalLostCnt = 0 Then
                    Print("LOST CARD" & "  " & rs2("LostCount").Value & "  P 0.00")
                Else
                    Print("LOST CARD" & "  " & rs2("LostCount").Value & "  P " & MakeMoney(rs2("LostAmt").Value))
                End If

            Catch ex As Exception

            End Try

            rs2.MoveNext()
        Loop

        Dim rs3 As New Recordset
        rs3 = New Recordset

        rs3 = conSqlPOS.Execute("select sum(ManCount) as ManCount,Sum(ManAmt) as ManAmt from vwemanualsumcount where PayType = 'Manual' and Station = '" & strStation & "' and BussDate like '" & strBussDate & "%'") '"select Count(PayType)as ManCount,Sum(total) as ManAmt from tblincomereport where PayType = 'Manual' and Station = '" & strStation & "' and BussDate like '" & strBussDate & "%'")
        Do While rs3.EOF = False
            Try
                TotalManual = rs3("ManCount").Value

                If TotalManual = 0 Then
                    Print("MANUAL INPUT  " & rs3("ManCount").Value & "  P 0.00")
                Else
                    Print("MANUAL INPUT  " & rs3("ManCount").Value & "  P " & MakeMoney(Val(rs3("ManAmt").Value)))
                End If
            Catch ex As Exception

            End Try
            rs3.MoveNext()
        Loop


        Print("----------------------------------------")


        TotalTrCount = TotalGraceCnt + VipTotalCnt + TotalLostCnt + TotalRetail + TotalGraceCntM + TotalMotor + TotalManual
        Print("Total Transaction : " & TotalTrCount)

        Print("----------------------------------------")


        Print("Total Sales :" & " P" + " " + MakeMoney(NetSale))

        Print("Total VAT :" & " P" + " " + MakeMoney(VatAmt))

        Print("Total VAT Sales :" & " P" + " " + MakeMoney(VatSale))

        Print("Signature : _______________________________")

        Print("****** END OF REPORT ******")

        Print("                     ")
        Print("                     ")

        Print(output)
        _P(PrintData)

    End Sub

    Private Sub PrntSummLO_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles SummPrint.PrintPage

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
        e.Graphics.DrawString("SUMMARY REPORT", printFont, Brushes.Black, x + 22, y - 5)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 6)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font


        'Dim strOp As String = OperatorName
        Dim strStation As String = frmMain.txtStation.Text

        Dim FromOr As String = sumOrFrom(strStation, PetsaBuss)
        Dim ToOr As String = sumOrTo(strStation, PetsaBuss)

        Dim NetSale As Double = sumTotalNet(strStation, PetsaBuss)
        Dim VatAmt As Double = VAT(NetSale)
        Dim VatSale As Double = Comp_Vat_sale(NetSale, VatAmt)

        'y += (lineOffset * 3.0)
        'e.Graphics.DrawString("Date : ", printFont, Brushes.Black, x, y - 5)
        'e.Graphics.DrawString(Format(Now, "yyyy-MM-dd"), printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Bussines Date: ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(PetsaBuss, "yyyy-MM-dd"), printFont, Brushes.Black, x + 65, y - 5)

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

        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlPOS.Execute("select MAX(ORno) as MaxOR,MIN(ORno) as MinOR,Operator,Count(Operator)as OpCount,sum(total)as OpTotalAmt from tblincomereport where Station = '" & strStation & "' and BussDate like '" & strBussDate & "%' group by Operator")
        Do While rs.EOF = False
            Dim kahera As String = rs("Operator").Value
            Dim TotalbyKahera As Double = rs("OpTotalAmt").Value
            Dim ORfrm As String = rs("MinOR").Value
            Dim ORto As String = rs("MaxOR").Value
            Dim time1 As Date = DtinFrm(kahera, strStation, PetsaBuss)
            Dim time2 As Date = DtOutTo(kahera, strStation, PetsaBuss)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Cashier :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(kahera, printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("OR From :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(ORfrm, printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("OR To :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(ORto, printFont, Brushes.Black, x + 105, y - 5)

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

        Dim TotalTrans As Integer = sumTotalTR(strStation, PetsaBuss)
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

                rs1 = conSqlPOS.Execute("select Count(VehicleType)as VehicleCount from tblincomereport where PayType = 'GracePeriod' and VehicleType = '" & VehTyp & "' and Station = '" & strStation & "' and BussDate like '" & strBussDate & "%'")
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

        Dim rs4 As New Recordset
        rs4 = New Recordset

        rs4 = conSqlPOS.Execute("select Total,VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt from tblincomereport where Station = '" & strStation & "' and PayType <> 'GracePeriod' and PayType <> 'Manual' and LostCard = 0 and BussDate like '" & strBussDate & "%' group by VehicleType")
        Do While rs4.EOF = False
            TotalRetail = TotalRetail + Val(rs4("VehicleCount").Value)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(rs4("VehicleType").Value, printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs4("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(rs4("VehicleTotalAmt").Value), printFont, Brushes.Black, x + 105, y - 5)
            rs4.MoveNext()
        Loop

        Dim rs2 As New Recordset
        rs2 = New Recordset

        rs2 = conSqlPOS.Execute("select Count(LostCard)as LostCount,Sum(Total) as LostAmt from tblincomereport where LostCard > 0 and Station = '" & strStation & "' and BussDate like '" & strBussDate & "%'")
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

        Dim rs3 As New Recordset
        rs3 = New Recordset

        rs3 = conSqlPOS.Execute("select Count(PayType)as ManCount,Sum(total) as ManAmt from tblincomereport where PayType = 'Manual' and Station = '" & strStation & "' and BussDate like '" & strBussDate & "%'")
        Do While rs3.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("MANUAL INPUT", printFont, Brushes.Black, x, y - 5)
            TotalManual = rs3("ManCount").Value
            e.Graphics.DrawString(rs3("ManCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            If TotalManual = 0 Then
                e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)
            Else
                e.Graphics.DrawString("P " & MakeMoney(Val(rs3("ManAmt").Value)), printFont, Brushes.Black, x + 105, y - 5)
            End If
            rs3.MoveNext()
        Loop

        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total Transaction : ", printFont, Brushes.Black, x, y - 5)
        TotalTrCount = TotalGraceCnt + VipTotalCnt + TotalLostCnt + TotalRetail + TotalGraceCntM + TotalMotor + TotalManual
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

    Public Function sumOrFrom(ByVal Station As String, ByVal petsa1 As Date) As String
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Min(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and BussDate like '" & dt1 & "%'")
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
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Max(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("MinOr").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function sumTotalTR(ByVal Station As String, ByVal petsa1 As Date) As Integer
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from tblincomereport where Station = '" & Station & "' and VehicleType <> 'RETAIL' and VehicleType <> 'MOTOR' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function sumTotalNet(ByVal Station As String, ByVal petsa1 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select sum(Total) as TotalNet from tblincomereport where Station = '" & Station & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("TotalNet").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Module
