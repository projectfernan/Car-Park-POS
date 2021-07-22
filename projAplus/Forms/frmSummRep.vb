Public Class frmSummRep

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmSummRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtFrm.Value = frmMain.txtBussDate.Text
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If sumOrFrom(frmMain.txtStation.Text, dtFrm.Value) <> "-" Then
            PrntSummLO(dtFrm.Value)
        Else
            MsgBox("No record found!", vbExclamation, "Print")
        End If
    End Sub
End Class