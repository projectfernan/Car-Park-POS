Imports ADODB
Public Class frmSummaryReport

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If cboStation.Text = vbNullString Then
            MsgBox("Please connect to database! ", vbExclamation, "Print")
            Exit Sub
        End If

        Dim dF As String = Format(Da1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim dT As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")
        Dim Rpath As String = Application.StartupPath & "\Reports\SummaryRep.rpt"
        Dim rs As New Recordset

        If conLocal() = False Then Exit Sub

        Try

            rs = conSqlLoc.Execute("Select * from vwesummaryreport Where Station = '" & cboStation.Text & "' and BussDate >= '" & dF & "' and BussDate <= '" & dT & "' Order by BussDate Asc")
            If rs.EOF = False Then

                Dim RR As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                RR.Load(Rpath)
                RR.SetDataSource(rs)
                With My.Settings
                    RR.SetParameterValue("Company", .COMPANY)
                    RR.SetParameterValue("CompAddress", .CompAddr)
                    RR.SetParameterValue("Permit", "Permit #: " & .PERMIT)
                    RR.SetParameterValue("Tin", "TIN " & .TIN)
                End With
                crtViewer.ReportSource = RR
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Summary Report")
        End Try
    End Sub

    Private Sub frmSummaryReport_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PMSmain.tmeSlot.Enabled = True
        PMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmSummaryReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PMSmain.tmeSlot.Enabled = False
        PMSmain.TmrRead.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class