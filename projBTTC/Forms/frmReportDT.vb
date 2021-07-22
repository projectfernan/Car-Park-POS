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

            Dim lup As Short
            Dim TmeInTo As String
            Dim TmeInFrm As String

            TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
            TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

            rsDt = New Recordset
            rsDt = conSqlPOS.Execute("select * from tblIncomeReport where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmOP.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmOp.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToOp.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToOp.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlPOS.Execute("select * from tblIncomeReport where Operator like '" & cboOp.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlPOS.Execute("select * from tblIncomeReport where Station like '" & cboStation.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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

        Dim lup As Short
        Dim TmeInTo As String
        Dim TmeInFrm As String

        TmeInFrm = Format(CDate(dtFrmVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmVh.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToVh.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToVh.Text), "HH:mm:ss")

        rsDt = New Recordset
        rsDt = conSqlPOS.Execute("select * from tblIncomeReport where VehicleType like '" & cboVehicle.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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

        TmeInFrm = Format(CDate(dtDateFrm.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeFrm.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtDateTo.Text), "yyyy-MM-dd") + " " + Format(CDate(dtTmeTo.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlPOS.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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

        TmeInFrm = Format(CDate(dtFrmOP.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmOp.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToOp.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToOp.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlPOS.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where Operator like '" & cboOp.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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

        TmeInFrm = Format(CDate(dtFrmSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeFrmSt.Text), "HH:mm:ss")
        TmeInTo = Format(CDate(dtToSt.Text), "yyyy-MM-dd") + " " + Format(CDate(tmeToSt.Text), "HH:mm:ss")

        rsGen = New Recordset
        rsGen = conSqlPOS.Execute("select sum(Total) as tt,sum(VAT) as vt,sum(SubTotal) as St from tblIncomeReport where Station like '" & cboStation.Text & "%' and TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
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
        If Report = "Server" Then
            If frmMain.txtDbStat.Text = "Connected" Then
                Operators()
                Vehicle()
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End If

        If Report = "Local" Then
            If frmMain.dbstat2.Text = "Connected" Then
                OperatorsL()
                VehicleL()
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End If

    End Sub



    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click

        If Report = "Server" Then
            txtclear()
            lstList.Clear()
            Head()
            EntSrch()
            GenTotal()
        End If

        If Report = "Local" Then
            txtclear()
            lstList.Clear()
            Head()
            EntSrchL()
            GenTotalL()
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeFrmOp.ValueChanged

    End Sub

    Private Sub cmdSearchOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchOp.Click
        If Report = "Server" Then
            txtclear()
            lstList.Clear()
            Head()
            SrchOp()
            GenTotalOp()
        End If

        If Report = "Local" Then
            txtclear()
            lstList.Clear()
            Head()
            SrchOpL()
            GenTotalOpL()
        End If
    End Sub

    Private Sub cmdSearchSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchSt.Click
        If Report = "Server" Then
            txtclear()
            lstList.Clear()
            Head()
            SrchSt()
            GenTotalst()
        End If

        If Report = "Local" Then
            txtclear()
            lstList.Clear()
            Head()
            SrchStL()
            GenTotalstL()
        End If
    End Sub

    Private Sub cmdSearchVh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchVh.Click
        If Report = "Server" Then
            txtclear()
            lstList.Clear()
            Head()
            SrchVh()
            GenTotalVH()
        End If

        If Report = "Local" Then
            txtclear()
            lstList.Clear()
            Head()
            SrchVhL()
            GenTotalVhL()
        End If
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
End Class