Imports ADODB
Public Class frmReportDT
    Public rsDt As New Recordset
    Public rsGen As New Recordset
    Sub Head()
        Dim w As Integer = lstList.Width / 7
        lstList.Columns.Clear()
        lstList.Columns.Add("OR No", w, HorizontalAlignment.Left)
        lstList.Columns.Add("TimeIn", w, HorizontalAlignment.Left)
        lstList.Columns.Add("TimeOut", w, HorizontalAlignment.Left)
        lstList.Columns.Add("TotalTime", w, HorizontalAlignment.Left)
        lstList.Columns.Add("VehicleType", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Plate No", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Document No", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Amt Due", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Overnight", w, HorizontalAlignment.Left)
        lstList.Columns.Add("LostCard", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Total", w, HorizontalAlignment.Left)
        lstList.Columns.Add("VAT", w, HorizontalAlignment.Left)
        lstList.Columns.Add("VatSale", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Tendered", w, HorizontalAlignment.Left)
    End Sub

    Sub HeadDis()
        Dim w As Integer = lstList.Width / 12
        lstList.Columns.Clear()
        lstList.Columns.Add("OR No", w, HorizontalAlignment.Left)
        lstList.Columns.Add("TimeIn", w, HorizontalAlignment.Left)
        lstList.Columns.Add("TimeOut", w, HorizontalAlignment.Left)
        lstList.Columns.Add("TotalTime", w, HorizontalAlignment.Left)
        lstList.Columns.Add("VehicleType", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Plate No", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Document No", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Amt Due", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Overnight", w, HorizontalAlignment.Left)
        lstList.Columns.Add("LostCard", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Total", w, HorizontalAlignment.Left)
        lstList.Columns.Add("VAT", w, HorizontalAlignment.Left)
        lstList.Columns.Add("VatSale", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Tendered", w, HorizontalAlignment.Left)
    End Sub

    Sub EntSrchL()

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlLoc.Execute("select * from incomereport where TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "' order by " & cboDtOrderBy.Text & " " & cboDtsort.Text & "")
        If rsDt.EOF = False Then
            Me.Cursor = Cursors.WaitCursor

            ProgBar.Maximum = rsDt.RecordCount
            txtcnt.Text = rsDt.RecordCount

            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(rsDt("TotalTime").Value)
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("DiscountReference").Value)
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Regular").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Overnight").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("LostCard").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Total").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Vat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("NonVat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Tender").Value)))
                rsDt.MoveNext()

                ProgBar.Value = lup
            Next
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Sub SrchOpL()
        If conLocal() = False Then
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
        rsDt = conSqlLoc.Execute("select * from incomereport where Operator = '" & cboOp.Text & "' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "' order by " & cboOpOrder.Text & " " & cboOpSort.Text & "")
        If rsDt.EOF = False Then
            Me.Cursor = Cursors.WaitCursor

            ProgBar.Maximum = rsDt.RecordCount
            txtcnt.Text = rsDt.RecordCount

            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(rsDt("TotalTime").Value)
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("DiscountReference").Value)
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Regular").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Overnight").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("LostCard").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Total").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Vat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("NonVat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Tender").Value)))
                rsDt.MoveNext()
                ProgBar.Value = lup
            Next

            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Sub SrchStL()
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlLoc.Execute("select * from incomeReport where PC = '" & cboStation.Text & "' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "' order by " & cboStOrder.Text & " " & cboSort.Text & "")
        If rsDt.EOF = False Then
            Me.Cursor = Cursors.WaitCursor

            ProgBar.Maximum = rsDt.RecordCount
            txtcnt.Text = rsDt.RecordCount

            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(rsDt("TotalTime").Value)
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("DiscountReference").Value)
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Regular").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Overnight").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("LostCard").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Total").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Vat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("NonVat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Tender").Value)))
                rsDt.MoveNext()
                ProgBar.Value = lup
            Next
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Sub SrchVhL()
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmVh.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToVh.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlLoc.Execute("select * from incomereport where Type = '" & cboVehicle.Text & "' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "' order by " & cboVhOrder.Text & " " & cboVhsort.Text & " ")
        If rsDt.EOF = False Then
            Me.Cursor = Cursors.WaitCursor

            ProgBar.Maximum = rsDt.RecordCount
            txtcnt.Text = rsDt.RecordCount

            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(rsDt("TotalTime").Value)
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("DiscountReference").Value)
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Regular").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Overnight").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("LostCard").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Total").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Vat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("NonVat").Value)))
                viewlst.SubItems.Add(MakeMoney(Val(rsDt("Tender").Value)))
                rsDt.MoveNext()
                ProgBar.Value = lup
            Next
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Sub GenTotalL()

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(NonVat) as St,sum(VatExempt) as VatExemp from incomereport where TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsGen.EOF = False Then
            On Error Resume Next
            If Val(rsGen("tt").Value) >= 1000 Then
                txtTotal.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0,000.00")
            Else
                txtTotal.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0.00")
            End If

            If Val(rsGen("St").Value) >= 1000 Then
                txtSubTotal.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0,000.00")
            Else
                txtSubTotal.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0.00")
            End If

            If Val(rsGen("vt").Value) >= 1000 Then
                txtVat.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0,000.00")
            Else
                txtVat.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0.00")
            End If

            txtVatExempt.Text = MakeMoney(rsGen("VatExemp").Value)
        End If
    End Sub

    Sub GenTotalOpL()

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmOP.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmOp.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToOp.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToOp.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(NonVat) as St,sum(VatExempt) as VatExemp from incomeReport where Operator like '" & cboOp.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsGen.EOF = False Then
            On Error Resume Next
            If Val(rsGen("tt").Value) >= 1000 Then
                txtTotalOp.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0,000.00")
            Else
                txtTotalOp.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0.00")
            End If

            If Val(rsGen("St").Value) >= 1000 Then
                txtSubTotalOp.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0,000.00")
            Else
                txtSubTotalOp.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0.00")
            End If

            If Val(rsGen("vt").Value) >= 1000 Then
                txtVatOp.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0,000.00")
            Else
                txtVatOp.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0.00")
            End If

            txtVatExempt2.Text = MakeMoney(rsGen("VatExemp").Value)
        End If
    End Sub

    Sub GenTotalstL()

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(NonVat) as St,sum(VatExempt) as VatExemp from incomereport where PC like '" & cboStation.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsGen.EOF = False Then
            On Error Resume Next
            If Val(rsGen("tt").Value) >= 1000 Then
                txtTotalSt.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0,000.00")
            Else
                txtTotalSt.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0.00")
            End If

            If Val(rsGen("St").Value) >= 1000 Then
                txtSubTotalSt.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0,000.00")
            Else
                txtSubTotalSt.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0.00")
            End If

            If Val(rsGen("vt").Value) >= 1000 Then
                txtVATst.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0,000.00")
            Else
                txtVATst.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0.00")
            End If

            txtVatExempt3.Text = MakeMoney(rsGen("VatExemp").Value)
        End If
    End Sub

    Sub GenTotalVhL()

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmVh.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToVh.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(NonVat) as St,Sum(VatExempt) as VatExemp from incomereport where Type like '" & cboVehicle.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsGen.EOF = False Then
            On Error Resume Next
            If Val(rsGen("tt").Value) >= 1000 Then
                txtTotalVh.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0,000.00")
            Else
                txtTotalVh.Text = Format(Math.Round(Val(rsGen("tt").Value), 2), "0.00")
            End If

            If Val(rsGen("St").Value) >= 1000 Then
                txtSubTotalVh.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0,000.00")
            Else
                txtSubTotalVh.Text = Format(Math.Round(Val(rsGen("St").Value), 2), "0.00")
            End If

            If Val(rsGen("vt").Value) >= 1000 Then
                txtVATVh.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0,000.00")
            Else
                txtVATVh.Text = Format(Math.Round(Val(rsGen("vt").Value), 2), "0.00")
            End If

            txtVatExempt4.Text = MakeMoney(rsGen("VatExemp").Value)
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Sub OperatorsL()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tbluseracc where Designation = 'Operator' order by Name")
        cboOp.Items.Clear()
      
        While rs.EOF = False
            If Not cboOp.Text = rs("Name").Value Then
                cboOp.Text = rs("Name").Value
                cboOp.Items.Add(rs("Name").Value)
            End If
            rs.MoveNext()
        End While

    End Sub

    Sub VehicleL()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblcharge order by VehicleType")
        cboVehicle.Items.Clear()
        While rs.EOF = False
            If Not cboVehicle.Text = rs("VehicleType").Value Then
                cboVehicle.Text = rs("VehicleType").Value
                cboVehicle.Items.Add(rs("VehicleType").Value)
            End If
            rs.MoveNext()
        End While

    End Sub

    Sub StationList()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblincomereport Order By Station")
        cboStation.Items.Clear()
        While rs.EOF = False
            If Not cboStation.Text = rs("Station").Value Then
                cboStation.Text = rs("Station").Value
                cboStation.Items.Add(rs("Station").Value)
            End If
            rs.MoveNext()
        End While
    End Sub

    Sub txtclear()
        txtTotal.Text = "0.00"
        txtSubTotal.Text = "0.00"
        txtVat.Text = "0.00"
        txtVatExempt.Text = "0.00"

        txtTotalOp.Text = "0.00"
        txtSubTotalOp.Text = "0.00"
        txtVatOp.Text = "0.00"
        txtVatExempt2.Text = "0.00"

        txtTotalSt.Text = "0.00"
        txtSubTotalSt.Text = "0.00"
        txtVATst.Text = "0.00"
        txtVatExempt3.Text = "0.00"

        txtTotalVh.Text = "0.00"
        txtSubTotalVh.Text = "0.00"
        txtVATVh.Text = "0.00"
        txtVatExempt4.Text = "0.00"
    End Sub

    Private Sub frmReportDT_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmPMSmain.tmeSlot.Enabled = True
        frmPMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmReportDT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmPMSmain.tmeSlot.Enabled = False
        frmPMSmain.TmrRead.Enabled = False
        txtclear()
        lstList.Clear()
        HeadDis()

        ProgBar.Value = 0

        If conLocal() Then
            OperatorsL()
            VehicleL()
            ' StationList()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If

    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtclear()
        lstList.Clear()
        Head()
        GenTotalL()
        EntSrchL()

    End Sub

    Private Sub cmdSearchOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchOp.Click
        txtclear()
        lstList.Clear()
        Head()
        GenTotalOpL()
        SrchOpL()
    End Sub

    Private Sub cmdSearchSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchSt.Click
        txtclear()
        lstList.Clear()
        Head()
        GenTotalstL()
        SrchStL()
    End Sub

    Private Sub cmdSearchVh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchVh.Click
        txtclear()
        lstList.Clear()
        Head()
        GenTotalVhL()
        SrchVhL()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        txtclear()
    End Sub

    Sub ByDTPrint()
        Dim ReportPath As String = Application.StartupPath & "\Reports\CrByDate.rpt"

        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsDt)
        frmPrevPrint.CrystalReportViewer1.ReportSource = Report
        frmPrevPrint.ShowDialog()
        'Else
        ' MsgBox("No Record Found", MsgBoxStyle.Exclamation)
        'End If
    End Sub

    Sub ByOpPrint()
        Dim ReportPath As String = Application.StartupPath & "\Reports\CrByOp.rpt"

        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsDt)
        frmPrevPrint.CrystalReportViewer1.ReportSource = Report
        frmPrevPrint.ShowDialog()
        'Else
        ' MsgBox("No Record Found", MsgBoxStyle.Exclamation)
        'End If
    End Sub

    Sub ByStPrint()
        Dim ReportPath As String = Application.StartupPath & "\Reports\CrBySt.rpt"

        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsDt)
        frmPrevPrint.CrystalReportViewer1.ReportSource = Report
        frmPrevPrint.ShowDialog()
        'Else
        ' MsgBox("No Record Found", MsgBoxStyle.Exclamation)
        'End If
    End Sub

    Sub ByVhPrint()
        Dim ReportPath As String = Application.StartupPath & "\Reports\CrByVh.rpt"

        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Report.Load(ReportPath)
        Report.SetDataSource(rsDt)
        frmPrevPrint.CrystalReportViewer1.ReportSource = Report
        frmPrevPrint.ShowDialog()
        'Else
        ' MsgBox("No Record Found", MsgBoxStyle.Exclamation)
        'End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        ByDTPrint()
    End Sub

    Private Sub cmdPrintOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintOp.Click
        ByOpPrint()
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
        ByVhPrint()
    End Sub

    Private Sub cmdPrintSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintSt.Click
        ByStPrint()
    End Sub

    Private Sub cboDtOrderBy_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboDtOrderBy.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboDtsort_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboDtsort.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboOpOrder_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboOpOrder.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboOpSort_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboOpSort.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboStOrder_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboStOrder.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboSort_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboSort.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboVhOrder_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboVhOrder.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboVhsort_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboVhsort.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboDtOrderBy_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDtOrderBy.SelectedIndexChanged

    End Sub

    Private Sub cboMach_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMach.SelectedIndexChanged
        If cboMach.Text = "RPT" Then
            cboStation.Items.Clear()
            Dim lup1 As Integer = 0
            Dim lup2 As Integer = 10

            For lup1 = 1 To lup2
                cboStation.Items.Add("RPT-" & lup1.ToString)
            Next
        ElseIf cboMach.Text = "POS" Then
            cboStation.Items.Clear()
            Dim lup1 As Integer = 0
            Dim lup2 As Integer = 10

            For lup1 = 1 To lup2
                cboStation.Items.Add("Station " & lup1.ToString)
            Next
        End If
    End Sub
End Class