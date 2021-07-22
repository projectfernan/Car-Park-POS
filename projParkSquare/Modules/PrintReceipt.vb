Imports System.Drawing.Printing
Module PrintReceipt
    Public P_PayType As String = vbNullString

    Public P_ORno As String
    Public P_Permit As String
    Public P_TIN As String
    Public P_ACCR As String

    Public P_CardCode As String
    Public P_EntTime As String
    Public P_ExtTime As String
    Public P_TotalTime As String
    Public P_Vehicle As String
    Public P_PlateNo As String
    Public P_CouponNo As String

    Public P_HourLy As Double
    Public P_Overnigth As Double
    Public P_Lost As Double
    Public P_Total As Double
    Public P_Vat As Double
    Public P_Vatable As Double
    Public P_Tendered As Double
    Public P_Change As Double
    Public P_DiscountType As String
    Public P_Discount As Double

    Public P_Teller As String
    Public P_Station As String
    Public P_Machine As String
    Public P_Serial As String
    Public P_date As String

    Public P_Msg As String

    Public dvr As String
    ' Constant variable holding the Printer name.
    Public PRINTER_NAME As String = My.Settings.PrinterDriver
    ' Variables/Objects.
    Public WithEvents pdPrint As PrintDocument

    Public Sub Prnt()
        pdPrint = New PrintDocument
        ' Change the printer to the indicated printer
        pdPrint.PrinterSettings.PrinterName = PRINTER_NAME

        If pdPrint.PrinterSettings.IsValid Then
            pdPrint.DocumentName = "Official Receipt"
            ' Start printing
            Dim pp As New Printing.StandardPrintController
            pdPrint.PrintController = pp
            pdPrint.Print()
            pdPrint.Dispose()
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Public Enum CellTextHorizontalAlignment
        LeftAlign = 1
        CentreAlign = 2
        RightAlign = 3
    End Enum

    Public Enum CellTextVerticalAlignment
        TopAlign = 1
        MiddleAlign = 2
        BottomAlign = 3
    End Enum

    Public Function DrawCellString(ByVal s As String, _
                                    ByVal HorizontalAlignment As CellTextHorizontalAlignment, _
                                    ByVal VerticalAlignment As CellTextVerticalAlignment, _
                                    ByVal BoundingRect As Rectangle, _
                                    ByVal DrawRectangle As Boolean, _
                                    ByVal Target As Graphics, _
                                    ByVal PrintFont As Font, _
                                    ByVal FillColour As Brush)


        Dim x As Single, y As Single
        Dim _Textlayout As New System.Drawing.StringFormat

        If DrawRectangle Then
            Target.FillRectangle(FillColour, BoundingRect)
            ' Target.DrawRectangle(_GridPen, BoundingRect)
        End If

        '\\ Set the text alignment
        If HorizontalAlignment = CellTextHorizontalAlignment.LeftAlign Then
            _Textlayout.Alignment = StringAlignment.Near
        ElseIf HorizontalAlignment = CellTextHorizontalAlignment.RightAlign Then
            _Textlayout.Alignment = StringAlignment.Far
        Else
            _Textlayout.Alignment = StringAlignment.Center
        End If

        Dim BoundingRectF As New RectangleF(BoundingRect.X, BoundingRect.Y, BoundingRect.Width, BoundingRect.Height)

        Target.DrawString(s, PrintFont, System.Drawing.Brushes.Black, BoundingRectF, _Textlayout)

    End Function

    Private Sub pdPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles pdPrint.PrintPage

        Dim x As Integer = 2, y As Integer = 4, lineOffset As Integer

        ' Instantiate font objects used in printing.
        ' Dim printFont As New Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point)
        Dim printFont As New Font("Microsoft Sans Serif", 12, FontStyle.Bold, GraphicsUnit.Point) 'Substituted to FontA Font
        Dim printFontOR As New Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point)
        'Dim barcodeFont As New Font("Free 3 of 9 Extended", 20) 'Substituted to Barcode1 Font

        'BARCODE SAMPLE "---------------------------------------------------------------------------------------------------------------"
        'Dim barcodefont As New Font("Free 3 of 9", 40, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font
        'BARCODE SAMPLE "---------------------------------------------------------------------------------------------------------------"

        e.Graphics.PageUnit = GraphicsUnit.Point
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        ' Print the receipt text
        y += (lineOffset * 1.0)
        e.Graphics.DrawString(My.Settings.TITLE, printFont, Brushes.Black, x, y - 9)
        printFont = New Font("Microsoft Sans Serif", 10, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font

        ' Print the receipt text
        y += (lineOffset * 1.0)
        e.Graphics.DrawString(My.Settings.N_OperatedBy, printFont, Brushes.Black, x, y - 5)
        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point) 'Substituted to FontA Font


        lineOffset = printFont.GetHeight(e.Graphics) - 3

        y += (lineOffset * 2.75)
        e.Graphics.DrawString(My.Settings.ADDR, printFont, Brushes.Black, x, y - 11)

        ' y += (lineOffset * 2.0)
        '  e.Graphics.DrawString(" Operated By : " & My.Settings.N_OperatedBy, printFont, Brushes.Black, x - 2, y - 8)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("VAT REG. TIN #: ", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_TIN, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Machine #:", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_Machine, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("SN #:", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_Serial, printFont, Brushes.Black, x + 85, y - 5)

        printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Regular, GraphicsUnit.Point)
        lineOffset = printFont.GetHeight(e.Graphics) - 4

        y += (lineOffset * 0.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 4)
        ' y += (lineOffset * 2.2)
        ' e.Graphics.DrawString("Official Receipt", printFont, Brushes.Black, x, y - 5)
        ' printFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold, GraphicsUnit.Point)
        ' lineOffset = printFont.GetHeight(e.Graphics) - 4
        ' e.Graphics.DrawString("N0." + " " + P_ORno, printFont, Brushes.Black, x + 85, y - 5)
        ' y += (lineOffset * 0.7)
        ' e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 6)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("OR No. :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_ORno, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Card Code :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_CardCode, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Operator :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_Teller, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Terminal :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_Station, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Plate # :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_PlateNo, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Parker Type :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_Vehicle, printFont, Brushes.Black, x + 85, y - 5)
        '  y += (lineOffset * 2.0)
        '  e.Graphics.DrawString("Transaction Date :", printFont, Brushes.Black, x, y - 5)
        ' e.Graphics.DrawString(P_date, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Date/Time In :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_EntTime, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Date/Time Out :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_ExtTime, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Duration :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString(P_TotalTime, printFont, Brushes.Black, x + 85, y - 5)

        If P_CouponNo = "No Ref Number" Or P_CouponNo = "" Then
        Else
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Coupon # :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(P_CouponNo, printFont, Brushes.Black, x + 85, y - 5)
        End If

    
        '  y += (lineOffset * 1.5)
        '  e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 3)
        ' y += (lineOffset * 2.2)
        ' e.Graphics.DrawString("Charges", printFont, Brushes.Black, x, y - 5)
        ' y += (lineOffset * 0.7)
        ' e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

        If P_Lost = "0.00" Then
        Else
            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Parking Fee :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString("P" + " " + MakeMoney(P_HourLy), printFont, Brushes.Black, x + 85, y - 5)
        End If
       
        If P_Lost = "0.00" Then
        Else
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Lost Card :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString("P" + " " + MakeMoney(P_Lost), printFont, Brushes.Black, x + 85, y - 5)
        End If


        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Total :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(P_Total), printFont, Brushes.Black, x + 85, y - 5)
        'y += (lineOffset * 2.0)
        'e.Graphics.DrawString("Discount :", printFont, Brushes.Black, x, y - 5)
        'e.Graphics.DrawString("P" + " " + P_Discount, printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("12% VAT :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(P_Vat), printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Vat Sale :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(P_Vatable), printFont, Brushes.Black, x + 85, y - 5)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString("Cash Tendered :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(P_Tendered), printFont, Brushes.Black, x + 85, y - 5)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Change :", printFont, Brushes.Black, x, y - 5)
        e.Graphics.DrawString("P" + " " + MakeMoney(P_Change), printFont, Brushes.Black, x + 85, y - 5)

        If ReceiptType = "Senior" Then
            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Name of SC/PWD : __________________________________________________________", printFont, Brushes.Black, x, y - 5)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Address : _________________________________________________________________", printFont, Brushes.Black, x, y - 5)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("OSCA ID No./PWD ID No.: ___________________________________________________", printFont, Brushes.Black, x, y - 5)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("TIN : _____________________________________________________________________", printFont, Brushes.Black, x, y - 5)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("SC/PWD Signature : ________________________________________________________", printFont, Brushes.Black, x, y - 5)

        Else
            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Name of Parker : __________________________________________________________", printFont, Brushes.Black, x, y - 5)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Address : _________________________________________________________________", printFont, Brushes.Black, x, y - 5)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("TIN : _____________________________________________________________________", printFont, Brushes.Black, x, y - 5)
        End If

       
        '  DrawCellString("f", CellTextHorizontalAlignment.CentreAlign, CellTextVerticalAlignment.MiddleAlign, 1, False, , AcceptRejectRule)

        y += (lineOffset * 3.0)
        e.Graphics.DrawString(My.Settings.N_PosVendor, printFont, Brushes.Black, x + 13, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString(My.Settings.N_PosVendorAddr, printFontOR, Brushes.Black, x - 3, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("TIN :" & My.Settings.N_PosVendorTin, printFont, Brushes.Black, x + 40, y - 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Accr #: " & P_ACCR & " / " & Format(My.Settings.N_AccrDate, "yyyy-MM-dd"), printFont, Brushes.Black, x + 5, y)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("BIR PTU #: " & P_Permit, printFont, Brushes.Black, x + 25, y)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString("Permit Date Effective : " & Format(My.Settings.N_PermitDateIssued, "yyyy-MM-dd"), printFont, Brushes.Black, x + 23, y)

        y += (lineOffset * 1.5)
        e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString(P_Msg, printFontOR, Brushes.Black, x - 2, y + 5)

        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" ", printFontOR, Brushes.Black, x - 2, y + 10)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" ", printFontOR, Brushes.Black, x - 2, y + 15)
        y += (lineOffset * 2.0)
        e.Graphics.DrawString(" ", printFontOR, Brushes.Black, x - 2, y + 20)

        'BARCODE SAMPLE "---------------------------------------------------------------------------------------------------------------"
        'y += (lineOffset * 2.0)
        'e.Graphics.DrawString("*" & "ABC123" & "*", barcodefont, Brushes.Black, x, y - 20)
        e.HasMorePages = False
    End Sub
End Module
