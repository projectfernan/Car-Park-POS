Imports ADODB
Public Class frmReportDT
    Public rsDt As New Recordset
    Public rsGen As New Recordset

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

    Private Sub frmReportDT_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        PMSmain.tmeSlot.Enabled = True
        PMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmReportDT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PMSmain.tmeSlot.Enabled = False
        PMSmain.TmrRead.Enabled = False
  
        If conLocal() Then
            OperatorsL()
            ' StationList()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If

    End Sub

    Sub ByDTPrint()
        Dim ReportPath As String = Application.StartupPath & "\Reports\CrByDate.rpt"

        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim dF As String = Format(dtDateFrm.Value, "yyyy-MM-dd HH:mm")
        Dim dT As String = Format(dtDateTo.Value, "yyyy-MM-dd HH:mm")

        Dim rs As New Recordset
        Dim query As String = "Select ORno,Plate,VehicleType,TimeIn,TimeOut,TotalTime,Hourly,Overnigth,LostCard,Discount," _
                                & "Total,SubTotal,VatExempt,ZeroRated,Vat from tblincomereport where TimeOut between '" _
                                & dF & "' and '" & dT & "' order by " & cboDtOrderBy.Text & " " & cboDtsort.Text
        rs = conSqlLoc.Execute(query)

        If rs.EOF = False Then
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs)
            With My.Settings
                Report.SetParameterValue("Company", .COMPANY)
                Report.SetParameterValue("CompAddress", .CompAddr)
                Report.SetParameterValue("Permit", "Permit #: " & .PERMIT)
                Report.SetParameterValue("Tin", "TIN " & .TIN)
            End With
            crViewer.ReportSource = Report
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information, "Detailed Sales Report")
        End If
    End Sub

    Sub ByOpPrint()
        Dim ReportPath As String = Application.StartupPath & "\Reports\CrByOpe.rpt"

        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim dF As String = Format(dtFrmOP.Value, "yyyy-MM-dd HH:mm")
        Dim dT As String = Format(dtToOp.Value, "yyyy-MM-dd HH:mm")

        Dim rs As New Recordset
        Dim query As String = "Select ORno,Plate,VehicleType,TimeIn,TimeOut,TotalTime,Hourly,Overnigth,LostCard,Discount," _
                                & "Total,SubTotal,VatExempt,ZeroRated,Vat,Operator from tblincomereport where Operator = '" _
                                & cboOp.Text & "' and TimeOut between '" & dF & "' and '" & dT _
                                & "' order by " & cboOpOrder.Text & " " & cboOpSort.Text
        rs = conSqlLoc.Execute(query)

        If rs.EOF = False Then
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs)
            With My.Settings
                Report.SetParameterValue("Company", .COMPANY)
                Report.SetParameterValue("CompAddress", .CompAddr)
                Report.SetParameterValue("Permit", "Permit #: " & .PERMIT)
                Report.SetParameterValue("Tin", "TIN " & .TIN)
            End With
            crViewer.ReportSource = Report
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information, "Detailed Sales Report")
        End If
    End Sub

    Sub ByStPrint()
        Dim ReportPath As String = Application.StartupPath & "\Reports\CrByStation.rpt"

        If Not IO.File.Exists(ReportPath) Then
            MsgBox("Cannot load Report file!    ", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim dF As String = Format(dtFrmSt.Value, "yyyy-MM-dd HH:mm")
        Dim dT As String = Format(dtToSt.Value, "yyyy-MM-dd HH:mm")

        Dim rs As New Recordset
        Dim query As String = "Select ORno,Plate,VehicleType,TimeIn,TimeOut,TotalTime,Hourly,Overnigth,LostCard,Discount," _
                                & "Total,SubTotal,VatExempt,ZeroRated,Vat,Station from tblincomereport where Station = '" & _
                                cboStation.Text & "' and TimeOut between '" & dF & "' and '" & dT & _
                                "' order by " & cboStOrder.Text & " " & cboStSort.Text
        rs = conSqlLoc.Execute(query)

        If rs.EOF = False Then
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Report.Load(ReportPath)
            Report.SetDataSource(rs)
            With My.Settings
                Report.SetParameterValue("Company", .COMPANY)
                Report.SetParameterValue("CompAddress", .CompAddr)
                Report.SetParameterValue("Permit", "Permit #: " & .PERMIT)
                Report.SetParameterValue("Tin", "TIN " & .TIN)
            End With
            crViewer.ReportSource = Report
        Else
            MsgBox("No Record Found", MsgBoxStyle.Information, "Detailed Sales Report")
        End If
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

    Private Sub cboVehicle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdPrintSt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintSt.Click
        ByStPrint()
    End Sub

    Private Sub cboDtOrderBy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDtOrderBy.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboDtsort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDtsort.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboOpOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOpOrder.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboOpSort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboOpSort.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboStOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStOrder.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboSort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStSort.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboVhOrder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboVhsort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class