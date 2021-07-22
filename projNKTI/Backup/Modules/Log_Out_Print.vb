Imports System.Drawing.Printing
Imports ADODB
Module Log_Out_Print
    ' Constant variable holding the Printer name.
    ' Variables/Objects.
    Public WithEvents LOPrint As PrintDocument '
    Public OperatorName As String
    Public UserPangalan As String
    Public PetsaDtIn As Date
    Public PetsaDtout As Date

    Public Sub PrntLO(ByVal Opname As String, ByVal OrasdtIn As Date, ByVal OrasdtOut As Date)

        OperatorName = Opname
        'UserPangalan = Usernem
        PetsaDtIn = OrasdtIn
        PetsaDtout = OrasdtOut

        LOPrint = New PrintDocument
        ' Change the printer to the indicated printer
        LOPrint.PrinterSettings.PrinterName = PRINTER_NAME

        If LOPrint.PrinterSettings.IsValid Then
            LOPrint.DocumentName = "Cashier Log-Out Report"
            ' Start printing
            Dim pp As New Printing.StandardPrintController
            LOPrint.PrintController = pp
            LOPrint.Print()
            LOPrint.Dispose()
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub LOPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles LOPrint.PrintPage

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
        e.Graphics.DrawString("OPERATOR'S  LOG-OUT  REPORT", printFont, Brushes.Black, x + 22, y - 5)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 6)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        Dim time1 As Date = PetsaDtIn
        Dim time2 As Date = PetsaDtout
        Dim strOp As String = OperatorName
        Dim strStation As String = frmMain.txtStation.Text

        Dim FromOr As String = OrFrom(strOp, strStation, time1, time2)
        Dim ToOr As String = OrTo(strOp, strStation, time1, time2)

        Dim TotalTrans As Integer = TotalTR(strOp, strStation, time1, time2)
        Dim NetSale As Double = TotalNet(strOp, strStation, time1, time2)
        Dim Vat As Double = TotalVat(strOp, strStation, time1, time2)
        Dim VatSale As Double = Comp_Vat_sale(NetSale, Vat) 'TotalVatSale(strOp, strStation, time1, time2)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Time In : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(time1, "yyyy-MM-dd HH:mm:ss"), printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Time Out : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(time2, "yyyy-MM-dd HH:mm:ss"), printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Operator : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strOp, printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Station : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strStation, printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("From ORno :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(FromOr, printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("To ORno :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(ToOr, printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 1.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 3)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("Transaction Summary", printFont, Brushes.Black, x, y - 5)
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        Dim strTime1 As String = Format(time1, "yyyy-MM-dd HH:mm:ss")
        Dim strTime2 As String = Format(time2, "yyyy-MM-dd HH:mm:ss")

        Dim rs1 As New Recordset
        rs1 = New Recordset

        rs1 = conSqlPOS.Execute("select VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt,Total from tblincomereport where Station = '" & strStation & "' and Operator = '" & strOp & "' and TimeOut >= '" & strTime1 & "' and  TimeOut <= '" & strTime2 & "' and VehicleType = 'CAR' and Total = 0 group by VehicleType,Total")
        Do While rs1.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("DROP OFF", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs1("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString(MakeMoney(rs1("Total").Value), printFont, Brushes.Black, x + 105, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(rs1("VehicleTotalAmt").Value), printFont, Brushes.Black, x + 150, y - 5)
            rs1.MoveNext()
        Loop

        Dim rs2 As New Recordset
        rs2 = New Recordset

        rs2 = conSqlPOS.Execute("select VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt,Total from tblincomereport where Station = '" & strStation & "' and Operator = '" & strOp & "' and TimeOut >= '" & strTime1 & "' and  TimeOut <= '" & strTime2 & "' and VehicleType = 'CAR' and Total > 0 group by VehicleType,Total")
        Do While rs2.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(rs2("VehicleType").Value, printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs2("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString(MakeMoney(rs2("Total").Value), printFont, Brushes.Black, x + 105, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(rs2("VehicleTotalAmt").Value), printFont, Brushes.Black, x + 150, y - 5)
            rs2.MoveNext()
        Loop

        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlPOS.Execute("select VehicleType,Count(VehicleType)as VehicleCount,sum(total)as VehicleTotalAmt,Total from tblincomereport where Station = '" & strStation & "' and Operator = '" & strOp & "' and TimeOut >= '" & strTime1 & "' and  TimeOut <= '" & strTime2 & "' and VehicleType <> 'CAR' group by VehicleType,Total")
        Do While rs.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(rs("VehicleType").Value, printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString(MakeMoney(rs("Total").Value), printFont, Brushes.Black, x + 105, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(rs("VehicleTotalAmt").Value), printFont, Brushes.Black, x + 150, y - 5)
            rs.MoveNext()
        Loop
        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total Transaction : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(TotalTrans, printFont, Brushes.Black, x + 85, y - 5)

        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Total Net Sales :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(NetSale), printFont, Brushes.Black, x + 105, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total VAT :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(Vat), printFont, Brushes.Black, x + 105, y - 5)

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

    Public Function dtlogin(ByVal username As String) As Date
        If conLocal() = False Then Return Nothing

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tbllogtime where Username = '" & username & "'")
            If rs.EOF = False Then
                Return rs("LoginTime").Value
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function OrFrom(ByVal operatorC As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As String
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:00")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:59")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Min(ORno) as MinOr from tblincomereport where TimeOut >= '" & dt1 & "' and  TimeOut <= '" & dt2 & "' and Station = '" & Station & "' and Operator = '" & operatorC & "'")
            If rs.EOF = False Then
                'MsgBox(rs("MinOr").Value.ToString)
                Return rs("MinOr").Value.ToString

            Else

                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function OrTo(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As String
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Max(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeOut >= '" & dt1 & "' and  TimeOut <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs("MinOr").Value.ToString
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function TotalTR(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As Integer
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeOut >= '" & dt1 & "' and  TimeOut <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function TotalNet(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select sum(Total) as TotalNet from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeOut >= '" & dt1 & "' and  TimeOut <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs("TotalNet").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function TotalVat(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select sum(Vat) as TotalVat from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeOut >= '" & dt1 & "' and  TimeOut <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs("TotalVat").Value
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

    Public Function TotalVatSale(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date, ByVal petsa2 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd HH:mm:ss")
            Dim dt2 As String = Format(petsa2, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select sum(SubTotal) as TotalVatSale from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and TimeOut >= '" & dt1 & "' and  TimeOut <= '" & dt2 & "'")
            If rs.EOF = False Then
                Return rs("TotalVatSale").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub dellogTime(ByVal username As String)
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("delete from tbllogtime where Username = '" & username & "'")

        Catch ex As Exception

        End Try
    End Sub

    Function MakeMoney(ByVal val As Double) As String
        MakeMoney = Replace(FormatCurrency(val, 2), "$", vbNullString)
    End Function

End Module
