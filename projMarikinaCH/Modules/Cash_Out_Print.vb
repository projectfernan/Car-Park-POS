Imports System.Drawing.Printing
Imports ADODB
Module Cash_Out_Print
    Public Logmin As String
    Public WithEvents CashOutPrint As PrintDocument '

    Public Sub PrntCashOut(ByVal Opname As String, ByVal OrasdtIn As Date, ByVal LogAdmin As String)
        OperatorName = Opname
        PetsaDtIn = OrasdtIn
        Logmin = LogAdmin

        CashOutPrint = New PrintDocument
        ' Change the printer to the indicated printer
        CashOutPrint.PrinterSettings.PrinterName = PRINTER_NAME

        If CashOutPrint.PrinterSettings.IsValid Then
            CashOutPrint.DocumentName = "Cash Out Print"
            ' Start printing
            Dim pp As New Printing.StandardPrintController
            CashOutPrint.PrintController = pp
            CashOutPrint.Print()
            CashOutPrint.Dispose()
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PrntCashOut_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles CashOutPrint.PrintPage

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

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        y += (lineOffset * 0.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 4)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("PARTIAL CASH OUT PRINT", printFont, Brushes.Black, x + 22, y - 5)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 6)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        Dim time1 As Date = PetsaDtIn
        Dim strOp As String = OperatorName
        Dim strStation As String = MainForm.txtStation.Text

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Bussiness Date : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(time1, "yyyy-MM-dd"), printFont, Brushes.Black, x + 75, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Operator : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strOp, printFont, Brushes.Black, x + 75, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Cash Out By : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Logmin, printFont, Brushes.Black, x + 75, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Station : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strStation, printFont, Brushes.Black, x + 75, y - 5)

        y += (lineOffset * 1.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 3)
        y += (lineOffset * 2.2)
        e.Graphics.DrawString("Cash Out Breakdown", printFont, Brushes.Black, x, y - 5)
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        Dim strBussDate As String = Format(BussPetsa, "yyyy-MM-dd")

        Dim TotalCashAmt As Double = TotalCash()
        Dim rs1 As New Recordset
        rs1 = New Recordset

        rs1 = conSqlLoc.Execute("select Denomination,Qty,TotalAmt from tblbreakdown order by Denomination desc")
      
        Do While rs1.EOF = False
            y += (lineOffset * 2.0)
            e.Graphics.DrawString(rs1("Denomination").Value, printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(rs1("Qty").Value, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString("P " & MakeMoney(rs1("TotalAmt").Value), printFont, Brushes.Black, x + 105, y - 5)
            rs1.MoveNext()
        Loop

        y += (lineOffset * 0.9)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Total Cash :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(TotalCashAmt), printFont, Brushes.Black, x + 105, y - 5)

        y += (lineOffset * 6.5)
        e.Graphics.DrawString("Signature : _________________________________________________", printFont, Brushes.Black, x, y - 15)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("****** END OF REPORT ******", printFont, Brushes.Black, x - 2, y - 5)


        e.HasMorePages = False
    End Sub

    
End Module
