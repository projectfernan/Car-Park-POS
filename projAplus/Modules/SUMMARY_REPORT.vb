Imports System.Drawing.Printing
Imports ADODB
Module SUMMARY_REPORT
    Public WithEvents SummPrint As PrintDocument '

    Public Sub PrntSummLO(ByVal BussDate As Date)

        PetsaBuss = BussDate
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
            SummPrint.Print()
            SummPrint.Dispose()
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
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
        Dim VatExempt As Double = summTotalVatExemp(strStation, PetsaBuss)

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

        rs = conSqlPOS.Execute("select MAX(TRno) as MaxOR,MIN(TRno) as MinOR,Operator,Count(Operator)as OpCount,sum(total)as OpTotalAmt from incomereport where PC = '" & strStation & "' and BusnessDate like '" & strBussDate & "%' group by Operator")
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

        Dim VipTotalCnt As Integer = VipOutCount(ShiftFrm, ShiftTo) + VipInOutCount(ShiftFrm, ShiftTo)
        Dim TotalTrans As Integer = sumTotalTR(strStation, PetsaBuss) + VipTotalCnt
        Dim TotalGraceCnt As Integer = 0
        Dim TotalGraceCntM As Integer = 0
        Dim TotalLostCnt As Integer = 0
        Dim TotalTrCount As Integer = 0
        Dim TotalRetail As Integer = 0
        Dim TotalMotor As Integer = 0

        Dim rsVeh As New Recordset
        rsVeh = New Recordset

        rsVeh = conSqlPOS.Execute("select VehicleType from tblcharge")

        If rsVeh.EOF = False Then
            Dim VehTyp As String
            Do While rsVeh.EOF = False
                VehTyp = rsVeh("VehicleType").Value
                Dim rs1 As New Recordset
                rs1 = New Recordset
                rs1 = conSqlPOS.Execute("select Count(Type)as VehicleCount from incomereport where Payment = 'GracePeriod' and Type = '" & VehTyp & "' and PC = '" & strStation & "' and BusnessDate like '" & strBussDate & "%'")
                Do While rs1.EOF = False
                    TotalGraceCnt = rs1("VehicleCount").Value
                    If TotalGraceCnt <> 0 Then
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

        rs3 = conSqlPOS.Execute("select Type,Count(Type)as VehicleCount,sum(total)as VehicleTotalAmt from incomereport where PC = '" & strStation & "' and Payment <> 'GracePeriod' and LostCard = 0 and BusnessDate like '" & strBussDate & "%' group by Type")
        Do While rs3.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(rs3("Type").Value, printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs3("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(rs3("VehicleTotalAmt").Value), printFont, Brushes.Black, x + 105, y - 5)
            rs3.MoveNext()
        Loop

        Dim rs2 As New Recordset
        rs2 = New Recordset

        rs2 = conSqlPOS.Execute("select Count(LostCard)as LostCount,Sum(Total) as LostAmt from incomereport where LostCard > 0 and PC = '" & strStation & "' and BusnessDate like '" & strBussDate & "%'")
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

        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total Transaction : ", printFont, Brushes.Black, x, y - 5)
        ' TotalTrCount = TotalGraceCnt + VipTotalCnt + TotalTrans + TotalLostCnt + TotalRetail + TotalGraceCntM + TotalMotor
        e.Graphics.DrawString(TotalTrans, printFont, Brushes.Black, x + 85, y - 5)

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

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total VAT Exempt :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(VatExempt), printFont, Brushes.Black, x + 105, y - 5)

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
        'If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Min(TRno) as MinOr from incomereport where PC = '" & Station & "' and BusnessDate like '" & dt1 & "%'")
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
        'If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Max(TRno) as MinOr from incomereport where PC = '" & Station & "' and BusnessDate like '" & dt1 & "%'")
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
        ' If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from incomereport where PC = '" & Station & "' and BusnessDate like '" & dt1 & "%'")
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
        'If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim strp1 As String = Format(ShiftFrm, "yyyy-MM-dd HH:mm:00")
            Dim strp2 As String = Format(ShiftTo, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select sum(Total) as TotalNet from incomereport where PC = '" & Station & "' and BusnessDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("TotalNet").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function summTotalVatExemp(ByVal Station As String, ByVal petsa1 As Date) As Double
        'If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select sum(VatExempt) as TotalVatExempt from incomereport where PC = '" & Station & "' and BusnessDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("TotalVatExempt").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Module
