Imports ADODB
Public Class frmOpSummaryRate

    Private Sub frmOpSummaryRate_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PMSmain.tmeSlot.Enabled = True
        PMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmOpSummaryRate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PMSmain.tmeSlot.Enabled = False
        PMSmain.TmrRead.Enabled = False

        If conLocal() = True Then
            OperatorsL()
        End If

    End Sub

    Sub OperatorsL()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblincomereport order by Operator")
        cboOp.Items.Clear()

        While rs.EOF = False
            If Not cboOp.Text = rs("Operator").Value Then
                cboOp.Text = rs("Operator").Value
                cboOp.Items.Add(rs("Operator").Value)
            End If
            rs.MoveNext()
        End While

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cboOp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboOp.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub DelSumrate()
        If conLocal() = False Then Exit Sub
        Dim rs As New Recordset
        rs = New Recordset
        Try
            rs = conSqlLoc.Execute("delete from tblsummrate")
        Catch

        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim dF As String = Format(Da1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim dT As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")
        Dim Rpath As String = Application.StartupPath & "\Reports\CRopSummaryRate.rpt"
        Dim rs As New Recordset
        Dim rs2 As New Recordset
        Dim rs3 As New Recordset

        If conLocal() = False Then Exit Sub
        DelSumrate()

        Try
            rs = conSqlLoc.Execute("select VehicleType,count(Total)as RateCount,Total,sum(Total) as TotalAmount,TimeOut,Operator from tblincomereport where Operator = '" & cboOp.Text & "' and TimeOut between '" & dF & "' and '" & dT & "' group by Total")
            If rs.EOF = False Then

                Do While rs.EOF = False
                    rs2 = New Recordset
                    rs2.Open("select * from tblsummrate where 1=0", conSqlLoc, 1, 2)
                    rs2.AddNew()
                    rs2("VehicleType").Value = rs("VehicleType").Value
                    rs2("RateCount").Value = rs("RateCount").Value
                    rs2("Rate").Value = rs("Total").Value
                    rs2("TotalAmount").Value = rs("TotalAmount").Value
                    rs2("Operator").Value = rs("Operator").Value
                    rs2("TimeOut").Value = rs("TimeOut").Value
                    rs2.Update()
                    rs.MoveNext()
                Loop

                rs3 = New Recordset
                rs3 = conSqlLoc.Execute("select * from tblsummrate")
                If rs3.EOF = False Then
                    Dim RR As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    RR.Load(Rpath)
                    RR.SetDataSource(rs3)

                    Dim a As New frmPrevPrint
                    With a
                        .CrystalReportViewer1.ReportSource = RR
                        .ShowDialog()
                    End With
                End If
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Summary Report")
        End Try
    End Sub
End Class