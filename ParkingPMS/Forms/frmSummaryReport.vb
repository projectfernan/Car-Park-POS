Imports ADODB
Public Class frmSummaryReport

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim dF As String = Format(Da1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim dT As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")
        Dim Rpath As String = Application.StartupPath & "\Reports\SummaryRep.rpt"
        Dim rs As New Recordset

        If conLocal() = False Then Exit Sub

        Try

            rs = conSqlLoc.Execute("Select * From vwesummaryreport Where Timeout Between '" & dF & "' and '" & dT & "' Order by Timeout Asc")
            If rs.EOF = False Then

                Dim RR As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                RR.Load(Rpath)
                RR.SetDataSource(rs)

                Dim a As New frmPrevPrint
                With a
                    .CrystalReportViewer1.ReportSource = RR
                    .ShowDialog()
                End With

            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Summary Report")
        End Try
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmSummaryReport_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPMSmain.tmeSlot.Enabled = True
    End Sub

    Private Sub frmSummaryReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frmPMSmain.tmeSlot.Enabled = False
    End Sub
End Class