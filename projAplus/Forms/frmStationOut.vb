Public Class frmStationOut

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If sOrFrom(frmMain.txtStation.Text) <> "-" Then
            stPrntLO(dt1.Value, dt2.Value)
        Else
            MsgBox("No record found!", vbExclamation, "Print")
        End If
    End Sub

    Private Sub frmStationOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class