Imports ADODB
Public Class frmSummaryReport

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If cboStation.Text = vbNullString Then
            MsgBox("Please connect to database! ", vbExclamation, "Print")
            Exit Sub
        End If

        Dim dtfr As Date = Da1.Value.AddDays(-1)

        Dim dF As String = Format(dtfr, "yyyy-MM-dd 00:00:00")
        Dim dT As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")
        Dim Rpath As String = Application.StartupPath & "\Reports\SummaryRep.rpt"
        Dim rs As New Recordset

        If cboStation.Text = "All" Then
            If conLocal() = False Then Exit Sub

            Try

                rs = conSqlLoc.Execute("Select * From vwesummaryreport Where BussDate >= '" & dF & "' and BussDate <= '" & dT & "' group by Station,BussDate Order by BussDate Asc")
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
        Else
            If conLocal() = False Then Exit Sub

            Try

                rs = conSqlLoc.Execute("Select * From vwesummaryreport Where Station = '" & cboStation.Text & "' and BussDate >= '" & dF & "' and BussDate <= '" & dT & "' Order by BussDate Asc")
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
        End If

      
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmSummaryReport_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPMSmain.tmeSlot.Enabled = True
        frmPMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmSummaryReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frmPMSmain.tmeSlot.Enabled = False
        frmPMSmain.TmrRead.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMach.SelectedIndexChanged
        If cboMach.Text = "Payment Kiosk" Then
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
        ElseIf cboMach.Text = "All" Then
            cboStation.Items.Clear()
            cboStation.Items.Add("All")
        End If
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
End Class