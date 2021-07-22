Imports ADODB
Public Class frmLstayRep

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click
        Dim dF As String = Format(Da1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim dT As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")
        Dim Rpath As String = Application.StartupPath & "\Reports\crLenStay.rpt"
        Dim rs As New Recordset

        If conLocal() = False Then Exit Sub

        Try
            rs = conSqlLoc.Execute("Select * From vwelenstay where TimeOut between '" & dF & "' and '" & dT & "'")
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
                MsgBox("No Record Found", MsgBoxStyle.Information, "Pickload Report")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Pickload Report")
        End Try
    End Sub

    Private Sub frmLstayRep_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmPMSmain.tmeSlot.Enabled = True
        frmPMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmLstayRep_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        frmPMSmain.tmeSlot.Enabled = False
        frmPMSmain.TmrRead.Enabled = False
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class