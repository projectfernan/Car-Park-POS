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
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End With

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlPOS.Execute("select * from IncomeReport where TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("NonVat").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("PC").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
        End If
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
        rsDt = conSqlLoc.Execute("select * from tblIncomeReport where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("SubTotal").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("VehicleType").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("Station").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
        End If
    End Sub

    Sub SrchOp()

        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End With

        'LstEmpRec.Clear()

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmOP.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmOp.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToOp.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToOp.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlPOS.Execute("select * from IncomeReport where Operator like '" & cboOp.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("NonVat").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("PC").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
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
        rsDt = conSqlLoc.Execute("select * from tblIncomeReport where Operator like '" & cboOp.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("SubTotal").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("VehicleType").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("Station").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
        End If
    End Sub

    Sub SrchSt()
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End With

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlPOS.Execute("select * from IncomeReport where PC like '" & cboStation.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("NonVat").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("PC").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
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
        rsDt = conSqlLoc.Execute("select * from tblIncomeReport where Station like '" & cboStation.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("SubTotal").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("VehicleType").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("Station").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
        End If
    End Sub

    Sub SrchVh()

        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End With

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmVh.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToVh.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlPOS.Execute("select * from IncomeReport where Type like '" & cboVehicle.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("TRno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("NonVat").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("Type").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("PC").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
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
        rsDt = conSqlLoc.Execute("select * from tblIncomeReport where VehicleType like '" & cboVehicle.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rsDt.EOF = False Then
            For lup = 1 To rsDt.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rsDt("ORno").Value, lup)
                viewlst.SubItems.Add(rsDt("CardCode").Value)
                viewlst.SubItems.Add(rsDt("Plate").Value)
                viewlst.SubItems.Add(rsDt("TimeIn").Value)
                viewlst.SubItems.Add(rsDt("TimeOut").Value)
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("Total").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("VAT").Value), 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(Val(rsDt("SubTotal").Value), 2), "0.00"))
                viewlst.SubItems.Add(rsDt("VehicleType").Value)
                viewlst.SubItems.Add(rsDt("Operator").Value)
                viewlst.SubItems.Add(rsDt("Station").Value)
                rsDt.MoveNext()
            Next
            txtcnt.Text = rsDt.RecordCount
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Sub Operators()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from tblUserAcc")
        cboOp.Items.Clear()
        While rs.EOF = False
            cboOp.Items.Add(rs("Name").Value)
            rs.MoveNext()
        End While

    End Sub

    Sub OperatorsL()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblUserAcc")
        cboOp.Items.Clear()
        While rs.EOF = False
            cboOp.Items.Add(rs("Name").Value)
            rs.MoveNext()
        End While

    End Sub

    Sub Vehicle()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from tblVehicle")
        cboVehicle.Items.Clear()
        While rs.EOF = False
            cboVehicle.Items.Add(rs("Vehicle").Value)
            rs.MoveNext()
        End While

    End Sub

    Sub VehicleL()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblVehicle")
        cboVehicle.Items.Clear()
        While rs.EOF = False
            cboVehicle.Items.Add(rs("Vehicle").Value)
            rs.MoveNext()
        End While

    End Sub

    Private Sub frmReportDT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lstList.Clear()
        Head()
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End With

        Operators()
        VehicleS()
    End Sub


    Sub VehicleS()
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
        Head()
        EntSrch()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeFrmOp.ValueChanged

    End Sub

    Private Sub cmdSearchOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchOp.Click
        lstList.Clear()
        Head()
        SrchOp()
    End Sub

    Private Sub cmdSearchSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchSt.Click
        lstList.Clear()
        Head()
        SrchSt()
    End Sub

    Private Sub cmdSearchVh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchVh.Click
        lstList.Clear()
        Head()
        SrchVh()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
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
        If MsgBox("Are you sure do you want to reprint this transaction? ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
                    reprint(viewlst.SubItems(0).Text)
                    Prnt()
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
                    Prnt()
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
                    Prnt()
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
                    Prnt()
                End If
            Next
        End If
    End Sub


    Sub reprint(ByVal OrNumber As String)
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End With

        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs = conSqlPOS.Execute("select * from IncomeReport where TRno = '" & OrNumber & "'")
            If rs.EOF = False Then

                P_ORno = rs("TRno").Value
                P_Permit = My.Settings.PERMIT
                P_TIN = My.Settings.TIN
                P_ACCR = My.Settings.ACCR
                P_CardCode = rs("CardCode").Value
                P_EntTime = rs("TimeIn").Value
                P_ExtTime = rs("TimeOut").Value
                P_TotalTime = rs("TotalTime").Value
                P_Vehicle = rs("Type").Value
                P_PlateNo = rs("Plate").Value

                P_HourLy = Format(Math.Round(Val(rs("Regular").Value), 2), "0.00")
                P_Overnigth = Format(Math.Round(Val(rs("Overnight").Value), 2), "0.00")
                P_Lost = Format(Math.Round(Val(rs("LostCard").Value), 2), "0.00")
                P_Total = Format(Math.Round(Val(rs("Total").Value), 2), "0.00")
                P_Vat = Format(Math.Round(Val(rs("VAT").Value), 2), "0.00")
                P_Vatable = Format(Math.Round(Val(rs("NonVat").Value), 2), "0.00")
                P_VatExemp = Format(Math.Round(Val(rs("VatExempt").Value), 2), "0.00")
                P_Tendered = Format(Math.Round(Val(rs("Tender").Value), 2), "0.00")
                P_Change = Format(Math.Round(Val(rs("Change").Value), 2), "0.00")

                P_Discount = Format(Math.Round(Val(rs("DiscountAmount").Value), 2), "0.00")

                P_Teller = rs("Operator").Value
                P_Station = rs("PC").Value
                P_Machine = My.Settings.MACHINE
                P_Serial = My.Settings.SERIAL
                P_date = Format(Now, "yyyy-MM-dd")

                P_Msg = "THIS OFFICIAL RECEIPT SHALL BE VALID FOR" & vbNewLine & "          FIVE(5) YEARS FROM THE DATE OF" & vbNewLine & "                         THE PERMIT TO USE"

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class