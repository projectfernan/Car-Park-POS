Imports ADODB
Public Class frmReportDT
    Public rsDt As New Recordset
    Public rsGen As New Recordset
    Sub Head()
        lstList.Columns.Clear()
        lstList.Columns.Add("OR No", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("CardCode", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("Plate", 100, HorizontalAlignment.Left)
        lstList.Columns.Add("TimeIn", 170, HorizontalAlignment.Left)
        lstList.Columns.Add("TimeOut", 170, HorizontalAlignment.Left)
        lstList.Columns.Add("Total", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("VAT", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("SubTotal", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("Vehicle", 130, HorizontalAlignment.Left)
        'lstList.Columns.Add("Other Charges", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("Operator", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("Station", 130, HorizontalAlignment.Left)
    End Sub

    Sub EntSrch()
 
        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
            TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

            rsDt = New Recordset
            rsDt = conSqlPOS.Execute("select * from tblIncomeReport where TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
            If rsDt.EOF = False Then
                For lup = 1 To rsDt.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                    viewlst.SubItems.Add(rsDt("CardCode").Value)
                    viewlst.SubItems.Add(rsDt("Plate").Value)
                    viewlst.SubItems.Add(rsDt("TimeIn").Value)
                    viewlst.SubItems.Add(rsDt("TimeOut").Value)
                    viewlst.SubItems.Add(MakeMoney(rsDt("Total").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("VAT").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("SubTotal").Value))
                    viewlst.SubItems.Add(rsDt("VehicleType").Value)
                    viewlst.SubItems.Add(rsDt("Operator").Value)
                    viewlst.SubItems.Add(rsDt("Station").Value)
                    rsDt.MoveNext()
                Next
                txtcnt.Text = rsDt.RecordCount
            End If
        Catch ex As Exception
            Save_ErrLogs("[EntSrch] frmReportDT", ex.Message)
        End Try
    End Sub

    Sub SrchOp()
        Try
            If conServer() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
                Exit Sub
            End If

            'LstEmpRec.Clear()

            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtFrmOP.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmOp.Text), "HH:mm:ss")
            TmeInTo = Format(CDate(dtToOp.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToOp.Text), "HH:mm:ss")

            rsDt = New Recordset
            rsDt = conSqlPOS.Execute("select * from tblIncomeReport where Operator like '" & cboOp.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
            If rsDt.EOF = False Then
                For lup = 1 To rsDt.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                    viewlst.SubItems.Add(rsDt("CardCode").Value)
                    viewlst.SubItems.Add(rsDt("Plate").Value)
                    viewlst.SubItems.Add(rsDt("TimeIn").Value)
                    viewlst.SubItems.Add(rsDt("TimeOut").Value)
                    viewlst.SubItems.Add(MakeMoney(rsDt("Total").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("VAT").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("SubTotal").Value))
                    viewlst.SubItems.Add(rsDt("VehicleType").Value)
                    viewlst.SubItems.Add(rsDt("Operator").Value)
                    viewlst.SubItems.Add(rsDt("Station").Value)
                    rsDt.MoveNext()
                Next
                txtcnt.Text = rsDt.RecordCount
            End If
        Catch ex As Exception
            Save_ErrLogs("[SrchOps] frmReportDT", ex.Message)
        End Try
    End Sub

    Sub SrchSt()
        Try
            If conServer() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
                Exit Sub
            End If

            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
            TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

            rsDt = New Recordset
            rsDt = conSqlPOS.Execute("select * from tblIncomeReport where Station like '" & cboStation.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
            If rsDt.EOF = False Then
                For lup = 1 To rsDt.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                    viewlst.SubItems.Add(rsDt("CardCode").Value)
                    viewlst.SubItems.Add(rsDt("Plate").Value)
                    viewlst.SubItems.Add(rsDt("TimeIn").Value)
                    viewlst.SubItems.Add(rsDt("TimeOut").Value)
                    viewlst.SubItems.Add(MakeMoney(rsDt("Total").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("VAT").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("SubTotal").Value))
                    viewlst.SubItems.Add(rsDt("VehicleType").Value)
                    viewlst.SubItems.Add(rsDt("Operator").Value)
                    viewlst.SubItems.Add(rsDt("Station").Value)
                    rsDt.MoveNext()
                Next
                txtcnt.Text = rsDt.RecordCount
            End If
        Catch ex As Exception
            Save_ErrLogs("[SrchSts] frmReportDT", ex.Message)
        End Try
    End Sub

    Sub SrchVh()
        Try
            If conServer() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
                Exit Sub
            End If

            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtFrmVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmVh.Text), "HH:mm:ss")
            TmeInTo = Format(CDate(dtToVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToVh.Text), "HH:mm:ss")

            rsDt = New Recordset
            rsDt = conSqlPOS.Execute("select * from tblIncomeReport where VehicleType like '" & cboVehicle.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
            If rsDt.EOF = False Then
                For lup = 1 To rsDt.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                    viewlst.SubItems.Add(rsDt("CardCode").Value)
                    viewlst.SubItems.Add(rsDt("Plate").Value)
                    viewlst.SubItems.Add(rsDt("TimeIn").Value)
                    viewlst.SubItems.Add(rsDt("TimeOut").Value)
                    viewlst.SubItems.Add(MakeMoney(rsDt("Total").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("VAT").Value))
                    viewlst.SubItems.Add(MakeMoney(rsDt("SubTotal").Value))
                    viewlst.SubItems.Add(rsDt("VehicleType").Value)
                    viewlst.SubItems.Add(rsDt("Operator").Value)
                    viewlst.SubItems.Add(rsDt("Station").Value)
                    rsDt.MoveNext()
                Next
                txtcnt.Text = rsDt.RecordCount
            End If
        Catch ex As Exception
            Save_ErrLogs("[SrchVh] frmReportDT", ex.Message)
        End Try
    End Sub

    Sub OperatorsL()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("Select * from tblUserAcc")
            cboOp.Items.Clear()
            While rs.EOF = False
                cboOp.Items.Add(rs("Name").Value)
                rs.MoveNext()
            End While
        Catch ex As Exception
            Save_ErrLogs("[OperatorsL] frmReportDT", ex.Message)
        End Try
    End Sub

    Private Sub frmReportDT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        Head()

        OperatorsL()
        VehicleL()
        ' StationList()
      
    End Sub

    Sub VehicleL()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("Select VehicleType from tblcharge order by VehicleType")
            cboVehicle.Items.Clear()
            While rs.EOF = False
                If Not cboVehicle.Text = rs("VehicleType").Value Then
                    cboVehicle.Text = rs("VehicleType").Value
                    cboVehicle.Items.Add(rs("VehicleType").Value)
                End If
                rs.MoveNext()
            End While
        Catch ex As Exception
            Save_ErrLogs("[VehicleL] frmReportDT", ex.Message)
        End Try
    End Sub

    Sub StationList()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from tblincomereport Order By Station")
        cboStation.Items.Clear()
        While rs.EOF = False
            If Not cboStation.Text = rs("Station").Value Then
                cboStation.Text = rs("Station").Value
                cboStation.Items.Add(rs("Station").Value)
            End If
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        lstList.Clear()

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Head()
        EntSrch()

        Cursor = Cursors.Default
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeFrmOp.ValueChanged

    End Sub

    Private Sub cmdSearchOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchOp.Click
        lstList.Clear()

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Head()
        SrchOp()

        Cursor = Cursors.Default
    End Sub

    Private Sub cmdSearchSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchSt.Click
        lstList.Clear()

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Head()
        SrchSt()

        Cursor = Cursors.Default
    End Sub

    Private Sub cmdSearchVh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchVh.Click
        lstList.Clear()

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Head()
        SrchVh()

        Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If MsgBox("Are you sure do you want to reprint this transaction? ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
                    reprint(viewlst.SubItems(0).Text)
                    PrintReceiptRaw_Now()
                End If
            Next
        End If
    End Sub

    Private Sub cmdPrintOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintOp.Click
        If MsgBox("Are you sure do you want to reprint this transaction? ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
                    reprint(viewlst.SubItems(0).Text)
                    PrintReceiptRaw_Now()
                End If
            Next
        End If
    End Sub

    Private Sub cboOp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOp.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboStation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStation.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboVehicle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVehicle.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdPrintVh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintVh.Click
        If MsgBox("Are you sure do you want to reprint this transaction? ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
                    reprint(viewlst.SubItems(0).Text)
                    PrintReceiptRaw_Now()
                End If
            Next
        End If
    End Sub

    Private Sub cmdPrintSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintSt.Click
        If MsgBox("Are you sure do you want to reprint this transaction? ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
                    reprint(viewlst.SubItems(0).Text)
                    PrintReceiptRaw_Now()
                End If
            Next
        End If
    End Sub


    Sub reprint(ByVal OrNumber As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs = conSqlPOS.Execute("select * from tblincomereport where Orno = '" & OrNumber & "'")
            If rs.EOF = False Then

                P_ORno = rs("ORno").Value
                P_Permit = My.Settings.PERMIT
                P_TIN = My.Settings.TIN
                P_ACCR = My.Settings.ACCR
                P_CardCode = rs("CardCode").Value
                P_EntTime = rs("TimeIn").Value
                P_ExtTime = rs("TimeOut").Value
                P_TotalTime = rs("TotalTime").Value
                P_Vehicle = rs("VehicleType").Value
                P_PlateNo = rs("Plate").Value

                P_HourLy = MakeMoney(rs("Hourly").Value)
                P_Overnigth = MakeMoney(rs("Overnigth").Value)
                P_Lost = MakeMoney(rs("LostCard").Value)
                P_Total = MakeMoney(rs("Total").Value)
                P_Vat = MakeMoney(rs("VAT").Value)
                P_Vatable = MakeMoney(rs("SubTotal").Value)
                P_VatExempt = MakeMoney(rs("VatExempt").Value)
                P_ZeroRated = MakeMoney(rs("ZeroRated").Value)
                P_Tendered = MakeMoney(rs("Tendered").Value)
                P_Change = MakeMoney(rs("Change").Value)

                P_Discount = MakeMoney(rs("Discount").Value)

                P_Teller = rs("Operator").Value
                P_Station = rs("Station").Value
                P_Machine = My.Settings.MACHINE
                P_Serial = My.Settings.SERIAL
                P_date = Format(Now, "General Date")

                P_Msg = "THIS OFFICIAL RECEIPT SHALL BE VALID FOR" & vbNewLine & "          FIVE(5) YEARS FROM THE DATE OF" & vbNewLine & "                         THE PERMIT TO USE"

            End If
        Catch ex As Exception
            Save_ErrLogs("[reprint] frmReportDT", ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class