Imports ADODB
Public Class frmPickLoadTME


    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click
        Dim dF As String = Format(CDate(Da1.Value), "yyyy-MM-dd HH:mm:ss")
        Dim dT As String = Format(CDate(Da2.Value), "yyyy-MM-dd HH:mm:ss")
        Dim Rpath As String = Application.StartupPath & "\Reports\PickLoadGraphTme.rpt"
        Dim rs As New Recordset

        If conLocal() = False Then Exit Sub

        Try

            rs = conSqlLoc.Execute("Select * From vweplgraph Where Timeout Between '" & dF & "' and '" & dT & "' Order by Timeout")
            If rs.EOF = False Then

                Dim RR As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                RR.Load(Rpath)
                RR.SetDataSource(rs)

                With My.Settings
                    RR.SetParameterValue("Company", .COMPANY)
                End With

                crtViewer.ReportSource = RR
            Else
                MsgBox("No Record Found", MsgBoxStyle.Information, "Pickload Report")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Pickload Report")
        End Try
    End Sub

    Private Sub frmPickLoadTME_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PMSmain.tmeSlot.Enabled = True
        PMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmPickLoadTME_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        PMSmain.tmeSlot.Enabled = False
        PMSmain.TmrRead.Enabled = False
    End Sub

    Private Sub frmPickLoadTME_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class