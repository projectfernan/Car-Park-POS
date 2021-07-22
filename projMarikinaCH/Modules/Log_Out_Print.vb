Imports System.Drawing.Printing
Imports ADODB
Module Log_Out_Print
    ' Constant variable holding the Printer name.
    ' Variables/Objects.
    Public WithEvents LOPrint As PrintDocument '
    Public OperatorName As String
    Public UserPangalan As String
    Public BussPetsa As Date
    Public PetsaDtIn As Date
    Public PetsaDtout As Date

    Public Sub PrntLO(ByVal Opname As String, ByVal BussDt As Date)

        OperatorName = Opname
        'UserPangalan = Usernem
        BussPetsa = BussDt
        'PetsaDtout = OrasdtOut

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

            Cursor.Current = Cursors.Arrow
        Else
            MessageBox.Show("Printer is not available.", "Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Public Function Comp_Vat_sale(ByVal totalAmt As Double, ByVal Vat As Double) As Double
        Return totalAmt - Vat
    End Function

    Private Sub LOPrint_Print(ByVal sender As System.Object, ByVal e As PrintPageEventArgs) Handles LOPrint.PrintPage
        Try
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

            Dim strOp As String = OperatorName
            Dim strStation As String = MainForm.txtStation.Text

            Dim time1 As Date = DtinFrm(strOp, strStation, BussPetsa)
            Dim time2 As Date = DtOutTo(strOp, strStation, BussPetsa)

            Dim FromOr As String = OrFrom(strOp, strStation, BussPetsa)
            Dim ToOr As String = OrTo(strOp, strStation, BussPetsa)

            Dim VipTotalCnt As Integer = VipOutCount(time1, time2) + VipInOutCount(time1, time2)
            Dim TotalTrans As Integer = TotalTR(strOp, strStation, BussPetsa)
            Dim TotalGraceCnt As Integer = 0
            Dim TotalGraceCntM As Integer = 0
            Dim TotalLostCnt As Integer = 0
            Dim TotalTrCount As Integer = 0
            Dim TotalRetail As Integer = 0
            Dim TotalMotor As Integer = 0

            Dim TotalManual As Integer = 0

            Dim NetSale As Double = TotalNet(strOp, strStation, BussPetsa)
            Dim VatAmt As Double = VAT(NetSale)
            Dim VatSale As Double = Comp_Vat_sale(NetSale, VatAmt)
            Dim TotalPartialCash As Double = PartialCashOut(BussPetsa, strOp)
            Dim TotalCash As Double = DiffSaleCashOut(NetSale, TotalPartialCash)

            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Time From : ", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(Format(time1, "yyyy-MM-dd HH:mm:00"), printFont, Brushes.Black, x + 65, y - 5)
            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Time To : ", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(Format(time2, "yyyy-MM-dd HH:mm:59"), printFont, Brushes.Black, x + 65, y - 5)

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

            Dim strBussDate As String = Format(BussPetsa, "yyyy-MM-dd")

            Dim rsVeh As New Recordset
            rsVeh = New Recordset

            rsVeh = conSqlPOS.Execute("select VehicleType from tblcharge")

            If rsVeh.EOF = False Then
                Dim VehTyp As String
                Do While rsVeh.EOF = False
                    VehTyp = rsVeh("VehicleType").Value
                    Dim rs1 As New Recordset
                    rs1 = New Recordset

                    rs1 = conSqlPOS.Execute("select VehicleCount from vwegracecount where VehicleType = '" & VehTyp & "' and Station = '" & strStation & "' and Operator = '" & strOp & "' and BussDate = '" & strBussDate & "' limit 1;")
                    If rs1.EOF = False Then
                        TotalGraceCnt = TotalGraceCnt + Val(rs1("VehicleCount").Value)
                        If Val(rs1("VehicleCount").Value) <> 0 Then
                            y += (lineOffset * 2.0)
                            e.Graphics.DrawString("GP " & VehTyp, printFont, Brushes.Black, x, y - 5)
                            e.Graphics.DrawString(rs1("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
                            e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)
                        End If
                    End If

                    rsVeh.MoveNext()
                Loop
            End If

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("VIP", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString(VipTotalCnt, printFont, Brushes.Black, x + 85, y - 5)
            e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)

            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("select VehicleCount,VehicleType,VehicleTotalAmt from vwevehsumcount where Station = '" & strStation & "' and Paytype <> 'GracePeriod' and Paytype <> 'Manual' and Operator = '" & strOp & "' and LostCard = 0 and BussDate like '" & strBussDate & "%';")
            Do While rs.EOF = False
                y += (lineOffset * 2.0)
                TotalRetail = TotalRetail + Val(rs("VehicleCount").Value)
                e.Graphics.DrawString(rs("VehicleType").Value, printFont, Brushes.Black, x, y - 5)
                e.Graphics.DrawString(rs("VehicleCount").Value, printFont, Brushes.Black, x + 85, y - 5)
                e.Graphics.DrawString("P " & MakeMoney(rs("VehicleTotalAmt").Value), printFont, Brushes.Black, x + 105, y - 5)
                rs.MoveNext()
            Loop

            Dim rs2 As New Recordset
            rs2 = New Recordset

            rs2 = conSqlPOS.Execute("select LostCount,LostAmt from vwelostcount where Station = '" & strStation & "' and Operator = '" & strOp & "' and BussDate like '" & strBussDate & "%'")
            Do While rs2.EOF = False
                y += (lineOffset * 2.0)
                e.Graphics.DrawString("LOST CARD", printFont, Brushes.Black, x, y - 5)
                TotalLostCnt = rs2("LostCount").Value
                e.Graphics.DrawString(rs2("LostCount").Value, printFont, Brushes.Black, x + 85, y - 5)
                If TotalLostCnt = 0 Then
                    e.Graphics.DrawString("P 0.00", printFont, Brushes.Black, x + 105, y - 5)
                Else
                    e.Graphics.DrawString("P " & MakeMoney(Val(rs2("LostAmt").Value)), printFont, Brushes.Black, x + 105, y - 5)
                End If
                rs2.MoveNext()
            Loop

            Dim rs3 As New Recordset
            rs3 = New Recordset

            rs3 = conSqlPOS.Execute("select ManCount,ManAmt from vwemanualsumcount where PayType = 'Manual' and Station = '" & strStation & "' and Operator = '" & strOp & "' and BussDate like '" & strBussDate & "%'")
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
            TotalTrCount = TotalTrans + VipTotalCnt
            e.Graphics.DrawString(TotalTrCount, printFont, Brushes.Black, x + 85, y - 5)

            y += (lineOffset * 0.9)
            e.Graphics.DrawString("___________________________________________________________________________", printFont, Brushes.Black, x, y - 5)

            y += (lineOffset * 3.0)
            e.Graphics.DrawString("Total Sales :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString("P" + " " + MakeMoney(NetSale), printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Partial Cash Out :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString("P" + " " + MakeMoney(TotalPartialCash), printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 2.0)
            e.Graphics.DrawString("Total Cash :", printFont, Brushes.Black, x, y - 5)
            e.Graphics.DrawString("P" + " " + MakeMoney(TotalCash), printFont, Brushes.Black, x + 105, y - 5)

            y += (lineOffset * 3.0)
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
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Print")
        End Try
    End Sub

    Public Function DiffSaleCashOut(ByVal Sale As Double, ByVal CashOut As Double) As Double
        Return Sale - CashOut
    End Function

    Public Function PartialCashOut(ByVal bussdt As Date, ByVal Op As String) As Double
        If conLocal() = False Then Return 0
        Try
            Dim Petsa As String = Format(bussdt, "yyyy-MM-dd")

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("CALL get_CashOut('" & Op & "','" & Petsa & "')")

            If rs.EOF = False Then
                If IsDBNull(rs("TotalCash").Value) Then
                    Return 0
                Else
                    Return rs("TotalCash").Value
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function VipOutCount(ByVal dtFrm As Date, ByVal dtTo As Date) As Integer
        If conServer() = False Then Return 0

        Dim petsa1 As String = Format(dtFrm, "yyyy-MM-dd HH:mm:00")
        Dim petsa2 As String = Format(dtTo, "yyyy-MM-dd HH:mm:59")

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("select count(CardCode) as VipCount from tbltimeout where TimeOut between '" & petsa1 & "' and '" & petsa2 & "'")
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
        If conServer() = False Then Return 0

        Dim petsa1 As String = Format(dtFrm, "yyyy-MM-dd HH:mm:00")
        Dim petsa2 As String = Format(dtTo, "yyyy-MM-dd HH:mm:59")

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("select count(CardCode) as VipCount from tbllogsrec where TimeOut between '" & petsa1 & "' and '" & petsa2 & "'")
            If rs.EOF = False Then
                Return CInt(rs("VipCount").Value)
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function

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

    Public Function OrFrom(ByVal operatorC As String, ByVal Station As String, ByVal petsa1 As Date) As String
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Min(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and Operator = '" & operatorC & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("MinOr").Value.ToString()
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function OrTo(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date) As String
        If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Max(ORno) as MinOr from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("MinOr").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Public Function DtinFrm(ByVal operatorC As String, ByVal Station As String, ByVal petsa1 As Date) As String
        ' If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Min(TimeOut) as MinTime from tblincomereport where Station = '" & Station & "' and Operator = '" & operatorC & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("MinTime").Value.ToString()
            Else
                Return Now
            End If
        Catch ex As Exception
            Return Now
        End Try
    End Function

    Public Function DtOutTo(ByVal operatorC As String, ByVal Station As String, ByVal petsa1 As Date) As String
        'If conServer() = False Then Return "-"
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Max(TimeOut) as MaxTime from tblincomereport where Station = '" & Station & "' and Operator = '" & operatorC & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("MaxTime").Value.ToString()
            Else
                Return Now
            End If
        Catch ex As Exception
            Return Now
        End Try
    End Function

    Public Function TotalTR(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date) As Integer
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Count(ID)as TotalTrans from tblincomereport where Station = '" & Station & "' and Operator = '" & op & "' and BussDate like '" & dt1 & "%'")
            If rs.EOF = False Then
                Return rs("TotalTrans").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function TotalNet(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("CALL get_TotalNet('" & Station & "','" & op & "','" & dt1 & "')")
            If rs.EOF = False Then
                If IsDBNull(rs("TotalNet").Value) Then
                    Return 0
                Else
                    Return rs("TotalNet").Value
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function TotalVatSale(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("CALL get_TotalVatable('" & Station & "','" & op & "','" & dt1 & "')")
            If rs.EOF = False Then
                If IsDBNull(rs("TotalVatSale").Value) Then
                    Return 0
                Else
                    Return rs("TotalVatSale").Value
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function TotalVatExempt(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("CALL get_TotalVatExempt('" & Station & "','" & op & "','" & dt1 & "')")
            If rs.EOF = False Then
                If IsDBNull(rs("TotalVatExempt").Value) Then
                    Return 0
                Else
                    Return rs("TotalVatExempt").Value
                End If
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function TotalVat(ByVal op As String, ByVal Station As String, ByVal petsa1 As Date) As Double
        If conServer() = False Then Return 0
        Try
            Dim dt1 As String = Format(petsa1, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("CALL get_TotalVat('" & Station & "','" & op & "','" & dt1 & "')")
            If rs.EOF = False Then
                If IsDBNull(rs("TotalVat").Value) Then
                    Return 0
                Else
                    Return rs("TotalVat").Value
                End If
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
        Dim pera As String
        pera = Replace(FormatCurrency(val, 2), "$", vbNullString)
        Return Replace(pera, "₱", vbNullString)
    End Function



End Module
