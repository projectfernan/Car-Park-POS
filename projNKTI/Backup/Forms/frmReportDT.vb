Imports ADODB
Public Class frmReportDT
    Public rsDt As New Recordset
    Public rsGen As New Recordset

    Dim bufOp As String
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
        'LstEmpRec.Clear()

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

        If conServer() = False Then
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

        If conServer() = False Then
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

    Sub GenTotal()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlPOS.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
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
        End If
    End Sub

    Sub GenTotalL()
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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
        End If
    End Sub


    Sub GenTotalOp()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmOP.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmOp.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToOp.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToOp.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlPOS.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where Operator like '" & cboOp.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
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
        End If
    End Sub

    Sub GenTotalOpL()
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmOP.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmOp.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToOp.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToOp.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where Operator like '" & cboOp.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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
        End If
    End Sub

    Sub GenTotalst()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlPOS.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where Station like '" & cboStation.Text & "%' and TimeOut >= '" & TmeInFrm & "' and TimeOut <='" & TmeInTo & "'")
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
        End If
    End Sub

    Sub GenTotalstL()
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where Station like '" & cboStation.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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
        End If
    End Sub

    Sub GenTotalVH()
        If PingMe(frmConnDB.txtIp1.Text) = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        Else
            If conServer() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
                Exit Sub
            End If
        End If
        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmVh.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToVh.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlPOS.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where VehicleType like '" & cboVehicle.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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
        End If
    End Sub

    Sub GenTotalVhL()
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If
        'LstEmpRec.Clear()

        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmVh.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToVh.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlLoc.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where VehicleType like '" & cboVehicle.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Sub OperatorsL()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select Name from tblUserAcc where Designation = 'Operator'")
        cboOp.Items.Clear()
        cboOp.Items.Add("fernan")
        While rs.EOF = False
            cboOp.Items.Add(rs("Name").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub Vehicle()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblVehicle")
        cboVehicle.Items.Clear()
        While rs.EOF = False
            cboVehicle.Items.Add(rs("Vehicle").Value)
            rs.MoveNext()
        End While

    End Sub



    Sub txtclear()
        txtTotal.Text = "0.00"
        txtSubTotal.Text = "0.00"
        txtVat.Text = "0.00"

        txtTotalOp.Text = "0.00"
        txtSubTotalOp.Text = "0.00"
        txtVatOp.Text = "0.00"

        txtTotalSt.Text = "0.00"
        txtSubTotalSt.Text = "0.00"
        txtVATst.Text = "0.00"

        txtTotalVh.Text = "0.00"
        txtSubTotalVh.Text = "0.00"
        txtVATVh.Text = "0.00"
    End Sub

    Private Sub frmReportDT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtclear()
        lstList.Clear()
        Head()

        If conServer() = True Then
            OperatorsL()
            Vehicle()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Sub Operators()

        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from tblincomereport order by Operator")
        cboOp.Items.Clear()

        While rs.EOF = False
            If Not bufOp = rs("Operator").Value Then
                cboOp.Items.Add(rs("Operator").Value)
            End If
            bufOp = rs("Operator").Value
            rs.MoveNext()
        End While

    End Sub

    Sub VehicleS()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from tblincomereport order by VehicleType")
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
        txtclear()
        lstList.Clear()
        Head()
        EntSrch()
        GenTotal()
    End Sub

    Private Sub cmdSearchOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchOp.Click
        txtclear()
        lstList.Clear()
        Head()
        SrchOp()
        GenTotalOp()
    End Sub

    Private Sub cmdSearchSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchSt.Click
        txtclear()
        lstList.Clear()
        Head()
        SrchSt()
        GenTotalst()
    End Sub

    Private Sub cmdSearchVh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchVh.Click
        txtclear()
        lstList.Clear()
        Head()
        SrchVh()
        GenTotalVH()
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
        If MsgBox("Are you sure do you want to reprint this transaction? ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
            Dim viewlst As New ListViewItem
            For Each viewlst In lstList.Items
                If viewlst.Selected = True Then
                    reprint(viewlst.SubItems(0).Text)
                    Prnt()
                    saveAudiUpdate(str_SysUser, str_SysPosi, "OR number " & viewlst.SubItems(0).Text & "re-printed")
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
                    saveAudiUpdate(str_SysUser, str_SysPosi, "OR number " & viewlst.SubItems(0).Text & "re-printed")
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
                    saveAudiUpdate(str_SysUser, str_SysPosi, "OR number " & viewlst.SubItems(0).Text & " re-printed")
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
                    saveAudiUpdate(str_SysUser, str_SysPosi, "OR number " & viewlst.SubItems(0).Text & "re-printed")
                End If
            Next
        End If
    End Sub

    Sub reprint(ByVal OrNumber As String)
        If conServer() = False Then Exit Sub

        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs = conSqlPOS.Execute("select * from tblIncomeReport where Orno = '" & OrNumber & "'")
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

                P_HourLy = Format(Math.Round(Val(rs("Total").Value), 2), "0.00")
                P_Overnigth = Format(Math.Round(Val(rs("Overnigth").Value), 2), "0.00")
                P_Lost = Format(Math.Round(Val(rs("LostCard").Value), 2), "0.00")
                P_Total = Format(Math.Round(Val(rs("Total").Value), 2), "0.00")
                P_Vat = Format(Math.Round(Val(rs("VAT").Value), 2), "0.00")
                P_Vatable = Format(Math.Round(Val(rs("SubTotal").Value), 2), "0.00")
                P_Tendered = Format(Math.Round(Val(rs("Tendered").Value), 2), "0.00")
                P_Change = Format(Math.Round(Val(rs("Change").Value), 2), "0.00")

                P_Discount = Format(Math.Round(Val(rs("Discount").Value), 2), "0.00")

                P_Teller = rs("Operator").Value
                P_Station = rs("Station").Value
                P_Machine = My.Settings.MACHINE
                P_Serial = My.Settings.SERIAL
                P_date = Format(Now, "General Date")

                P_Msg = "* REPRINT COPY OF OFFICIAL RECEIPT *"

            End If
        Catch ex As Exception

        End Try
    End Sub

End Class