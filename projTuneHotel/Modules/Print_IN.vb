Imports System.Drawing.Printing
Imports ADODB
Module Print_IN
    Public WithEvents entPrint As PrintDocument '

    Public Sub PrntEnt(ByVal Opname As String, ByVal OrasdtIn As Date, ByVal OrasdtOut As Date)

        OperatorName = Opname
        'UserPangalan = Usernem
        PetsaDtIn = OrasdtIn
        PetsaDtout = OrasdtOut

        entPrint = New PrintDocument
        ' Change the printer to the indicated printer
        entPrint.PrinterSettings.PrinterName = PRINTER_NAME

        If entPrint.PrinterSettings.IsValid Then
            entPrint.DocumentName = "Cashier Log-In Print"
            ' Start printing
            Dim pp As New Printing.StandardPrintController
            entPrint.PrintController = pp
            entPrint.Print()
            entPrint.Dispose()

        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub entPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles entPrint.PrintPage

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
        e.Graphics.DrawString("OPERATOR'S  LOG-IN PRINT", printFont, Brushes.Black, x + 22, y - 5)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4
        y += (lineOffset * 0.7)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 6)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        Dim time1 As Date = PetsaDtIn
        'Dim time2 As Date = PetsaDtout
        Dim strOp As String = OperatorName
        Dim strStation As String = frmMain.txtStation.Text

        ' y += (lineOffset * 3.0)
        'e.Graphics.DrawString("Date : ", printFont, Brushes.Black, x, y - 5)
        'e.Graphics.DrawString(Format(Now, "yyyy-MM-dd"), printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Time In : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(Format(time1, "yyyy-MM-dd HH:mm:ss"), printFont, Brushes.Black, x + 65, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Operator : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strOp, printFont, Brushes.Black, x + 65, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Station : ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(strStation, printFont, Brushes.Black, x + 65, y - 5)


        e.HasMorePages = False
    End Sub

End Module
