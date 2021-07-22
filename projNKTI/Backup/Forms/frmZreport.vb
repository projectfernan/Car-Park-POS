Imports System.Drawing.Printing
Imports ADODB
Public Class frmZreport
    Public SourcePath As String

    Dim IsFirst As Boolean
    Dim DN As Date
    Dim pc As String
    Dim r_count As String
    Dim BIR_ID As String
    Dim IsLogin As Boolean
    Dim MaxR As String
    Dim MinR As String

    'Private ComP_Ref As Company_Ref
    Dim HF As New Font("Seoge UI", 12, FontStyle.Bold, GraphicsUnit.Point)
    Dim RLG As New Font("Seoge UI", 8, FontStyle.Regular, GraphicsUnit.Point)
    Dim BLD As New Font("Seoge UI", 8, FontStyle.Bold, GraphicsUnit.Point)
    Dim PRV As New PrintPreviewDialog
    Public PaperSize As Integer = 15

    Dim X, Y, U, J, wx As Integer

    Private Sub frmZreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pc = frmMain.txtStation.Text
    End Sub

    Function GetMinOR(ByVal dt As Date, ByVal St As String, ByVal Field As String) As String

        If conServer() = False Then Return "-"

        Try

            Dim SQL As String = vbNullString
            Dim a As String = Format(dt.Date, "yyyy-MM-dd")

            SQL = "SELECT MIN(" & Field & ") AS T FROM tblincomereport WHERE Station='" & pc & "' and TimeOut LIKE '" & a & "%'"

            Dim rs As New ADODB.Recordset
            rs = New ADODB.Recordset
            rs = conSqlPOS.Execute(SQL)
            If rs.EOF = False Then
                r_count = rs.RecordCount.ToString
                Return rs("T").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Function GetMaxOR(ByVal dt As Date, ByVal St As String, ByVal Field As String) As String
        If conServer() = False Then Return "-"

        Try
            Dim SQL As String = vbNullString
            Dim a As String = Format(dt.Date, "yyyy-MM-dd")

            SQL = "SELECT MAX(" & Field & ") AS T FROM tblincomereport WHERE Station='" & pc & "' and TimeOut LIKE '" & a & "%'"

            Dim rs As New Recordset
            rs = conSqlPOS.Execute(SQL)
            If rs.EOF = False Then
                r_count = rs.RecordCount.ToString
                Return rs("T").Value
            Else
                Return "-"
            End If
        Catch ex As Exception
            Return "-"
        End Try
    End Function

    Private Sub Get_MinandMaxOR(ByVal DN As Date)
        If conServer() = False Then Exit Sub
        Try
            Dim station As String = frmMain.txtStation.Text
            Dim strdt As String = Format(DN, "yyyy-MM-dd")

            Dim rs As New Recordset
            rs = conSqlPOS.Execute("Call Get_OR('%" & strdt & "','" & station & "')")
            If rs.EOF = False Then
                MaxR = rs("ORMAX").Value.ToString
                MinR = rs("ORMIN").Value.ToString
            Else
                MaxR = "-"
                MinR = "-"
            End If

        Catch ex As Exception
            MaxR = "-"
            MinR = "-"
        End Try
    End Sub



    Public Function CenterME(ByVal text As String, ByVal F As Font, ByVal e As Graphics) As Integer
        Dim i As New SizeF
        Dim margin As Integer = 0

        i = e.MeasureString(text, F)
        margin = PaperSize - (i.Width / 2)

        If margin < 0 Then
            margin = 0
        End If
        Return margin
    End Function

    Private Function GET_TRcnt(ByVal d1 As Date) As String
        
        If conServer() = False Then Return 0

        Try
            Dim SQL As String = vbNullString
            Dim a As String = Format(d1.Date, "yyyy-MM-dd")

            SQL = "SELECT * FROM tblincomereport WHERE Station='" & pc & "' and TimeOut LIKE '" & a & "%'"

            Dim rs As New Recordset
            rs = conSqlPOS.Execute(SQL)
            If rs.EOF = False Then
                Return rs.RecordCount.ToString
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function GET_GTNEW(ByVal d1 As Date, ByVal T_field As String) As Double
        
        If conServer() = False Then Return 0

        Try
            Dim SQL As String = vbNullString
            Dim a As String = Format(d1.Date, "yyyy-MM-dd")

            SQL = "SELECT SUM(" & T_field & ") AS T FROM tblincomereport WHERE Station='" & pc & "' and TimeOut LIKE '" & a & "%'"

            Dim rs As New Recordset
            rs = conSqlPOS.Execute(SQL)
            If rs.EOF = False Then
                r_count = rs.RecordCount.ToString
                Return rs("T").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function GT_OLD(ByVal D1 As Date, ByVal T_Field As String) As Double
        If conServer() = False Then Return 0

        Try

            Dim SQL As String = vbNullString
            Dim a As String = Format(D1.Date, "yyyy-MM-dd")

            SQL = "SELECT SUM(" & T_Field & ") AS T FROM tblincomereport WHERE Station='" & pc & "' and TimeOut < '" & a & "'"

            Dim rs As New Recordset
            rs = conSqlPOS.Execute(SQL)
            If rs.EOF = False Then
                Return rs("T").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function Get_Vat(ByVal Amount As Double) As Double
        If conLocal() = False Then Return 0

        Try
            Dim Vat As Double = 0
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("SELECT Vat FROM tblvat")
            If rs.EOF = False Then
                Vat = rs("Vat").Value
                Dim Vat1 As Double = Vat + 1
                Dim CompVat1 As Double = CDbl(Amount) / CDbl(Vat1)
                Dim ptVat As Double = Vat1 - 1
                Dim TotalVat As Double = CompVat1 * Vat
                Dim Computed As Double = CDbl(Amount) - CDbl(TotalVat)
                Return Computed
            Else
                Return 0
            End If

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Get_SubTotal(ByVal Amount As Double, ByVal Vat As Double) As Double
        Return Amount - Vat
    End Function

    Private Sub PDO_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PDO.PrintPage
        e.Graphics.PageUnit = GraphicsUnit.Point
        Dim PS As Integer = (e.PageSettings.PaperSize.Width / 2)
        Dim LN As String = New String("-", PS)

        With e.Graphics

            If IsFirst = False Then

                Dim Title As String = My.Settings.TITLE
                Dim title2 As String = My.Settings.TITLE
                Dim Address As String = My.Settings.ADDR
                Dim Tel As String = My.Settings.CONTACT
                Dim Permit As String = My.Settings.PERMIT
                Dim TIN As String = My.Settings.TIN

                X = 0
                Y = 0
                U = 50
                J = 110
                wx = 0


                '.DrawString(Title, HF, Brushes.Black, 77, Y)
                'Y = Y + 10
                .DrawString(title2, HF, Brushes.Black, 1, Y)
                Y = Y + 13

                .DrawString(Address, RLG, Brushes.Black, 1, Y)
                Y = Y + 10

                .DrawString(LN, RLG, Brushes.Black, 0, Y)
                Y = Y + 15

                .DrawString("Permit # :", RLG, Brushes.Black, 1, Y)
                .DrawString(Permit, RLG, Brushes.Black, 100, Y)
                Y = Y + 11
                .DrawString("TIN # :", RLG, Brushes.Black, 1, Y)
                .DrawString(TIN, RLG, Brushes.Black, 100, Y)
                Y = Y + 11

                Dim strp As String = vbNullString
                strp = My.Settings.ACCR
                .DrawString("Accr # : ", RLG, Brushes.Black, 1, Y)
                .DrawString(strp, RLG, Brushes.Black, 100, Y)
                Y = Y + 11

                strp = My.Settings.MACHINE
                .DrawString("MIN # : ", RLG, Brushes.Black, 1, Y)
                .DrawString(strp, RLG, Brushes.Black, 100, Y)
                Y = Y + 11

                strp = My.Settings.SERIAL
                .DrawString("SN # : ", RLG, Brushes.Black, 1, Y)
                .DrawString(strp, RLG, Brushes.Black, 100, Y)
                Y = Y + 11

                .DrawString("Tel # :", RLG, Brushes.Black, 1, Y)
                .DrawString(Tel, RLG, Brushes.Black, 100, Y)
                Y = Y + 15

                .DrawString(LN, RLG, Brushes.Black, 0, Y)
                Y = Y + 12

                Dim Opby As String = "Z-READING REPORT"

                wx = CenterME(Opby, New Font("Arial", 10, FontStyle.Regular), e.Graphics)
                .DrawString(Opby, New Font("Arial", 10, FontStyle.Regular), Brushes.Black, 1, Y)
                Y = Y + 12

                .DrawString(LN, RLG, Brushes.Black, 0, Y)
                Y = Y + 15
            Else
                X = 0
                Y = 0
            End If

            '------------------------------------
            'If Server_Connect() = False Then
            'MsgBox("Server Error", MsgBoxStyle.Exclamation)
            'Exit Sub
            'End If
            'DatabaseReconnectionLost()
            '------------------------------------

            Dim rs As New Recordset
            Dim Scon As String = vbNullString
            Dim Ops As String = vbNullString
            Dim a As String = Format(dtAll.Value.Date, "yyyy-MM-dd")
            DN = dtAll.Value.Date

            .DrawString("Report Date : ", RLG, Brushes.Black, 1, Y)
            .DrawString(DN.ToShortDateString, RLG, Brushes.Black, 110, Y)
            Y = Y + 12

            .DrawString("Station : ", RLG, Brushes.Black, 1, Y)
            .DrawString(frmMain.txtStation.Text, RLG, Brushes.Black, 110, Y)
            Y = Y + 12

            .DrawString("Operator : ", RLG, Brushes.Black, 1, Y)
            .DrawString(frmMain.TxtOp.Text, RLG, Brushes.Black, 110, Y)
            Y = Y + 12

            Dim TNS As String = vbNullString
            MinR = vbNullString
            MinR = GetMinOR(dtAll.Value, pc, "ORno")
            MaxR = vbNullString
            MaxR = GetMaxOR(dtAll.Value, pc, "ORno")
            Dim cnt As Integer = GET_TRcnt(a)
            Dim NetSale As Double = GET_GTNEW(a, "Total")
            Dim NetVat As Double = Get_Vat(NetSale)
            Dim NewNetVatSale As Double = Get_SubTotal(NetSale, NetVat)
            Dim OldSale As Double = GT_OLD(a, "Total")
            Dim NewSale As Double = NetSale + OldSale
            Dim NewVat As Double = Get_Vat(NewSale)
            Dim NewVatSale As Double = Get_SubTotal(NewSale, NewVat)

            .DrawString("OR From : ", RLG, Brushes.Black, 1, Y)
            .DrawString(MinR, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            .DrawString("OR To : ", RLG, Brushes.Black, 1, Y)
            .DrawString(MaxR, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            .DrawString("Total Transaction : ", RLG, Brushes.Black, 1, Y)
            .DrawString(cnt, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            TNS = "Php " & MakeMoney(NetSale)
            .DrawString("Total NET-Sales : ", RLG, Brushes.Black, 1, Y)
            .DrawString(TNS, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            TNS = "Php " & MakeMoney(NewNetVatSale)
            .DrawString("Total 12% VAT-Sales : ", RLG, Brushes.Black, 1, Y)
            .DrawString(TNS, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            TNS = "Php " & MakeMoney(NetVat)
            .DrawString("Total Gross Sales : ", RLG, Brushes.Black, 1, Y)
            .DrawString(TNS, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            .DrawString(LN, RLG, Brushes.Black, 0, Y)
            Y = Y + 15

            TNS = "Php " & MakeMoney(OldSale)
            .DrawString("Old Accumulated Sales : ", RLG, Brushes.Black, 1, Y)
            .DrawString(TNS, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            TNS = "Php " & MakeMoney(NewSale)
            .DrawString("New Accumulated Sales : ", RLG, Brushes.Black, 1, Y)
            .DrawString(TNS, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            TNS = "Php " & MakeMoney(NewVatSale)
            .DrawString("Grand Total 12% VAT Sales : ", RLG, Brushes.Black, 1, Y)
            .DrawString(TNS, RLG, Brushes.Black, J, Y)
            Y = Y + 15

            TNS = "Php " & MakeMoney(NewVat)
            .DrawString("Total Gross : ", RLG, Brushes.Black, 1, Y)
            .DrawString(TNS, RLG, Brushes.Black, J, Y)
            Y = Y + 20

            .DrawString("------------------------ End of Report -------------------------", RLG, Brushes.Black, 20, Y)
            Y = Y + 11

        End With


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdZreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZreport.Click
        PDO = New PrintDocument
        PDO.PrinterSettings.PrinterName = My.Settings.PrinterDriver
        If PDO.PrinterSettings.IsValid Then
            Dim pp As New Printing.StandardPrintController
            PDO.PrintController = pp
            'ComP_Ref = Get_Comp()
            'Get_MinandMaxOR(dtAll.Value)
            PRV.Document = PDO
            PRV.ShowIcon = False
            PRV.PrintPreviewControl.Zoom = 1
            PDO.Print()
            'Save_Logs("Print Summary Report: Print By: " & Admin_Name)
            saveAudiUpdate(str_SysUser, str_SysPosi, "Z reading printed")
            PRV.ShowDialog()
        Else
            MsgBox("Printer Not Detected", vbExclamation)
        End If
    End Sub
End Class