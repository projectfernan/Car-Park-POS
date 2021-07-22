Public Class frmBussDate

    Sub UpdateBussDate()
        With My.Settings
            .BussDate = dtBdate.Value
            .HourlyCut = dtHcut.Value
            .FlatCut = dtFcut.Value
            .Save()
            frmMain.txtBussDate.Text = Format(.BussDate, "yyyy-MM-dd")
        End With
    End Sub

    Sub viewBdate()
        With My.Settings
            On Error Resume Next
            dtBdate.Value = .BussDate
            dtHcut.Value = .HourlyCut
            dtFcut.Value = .FlatCut
            frmMain.txtBussDate.Text = Format(.BussDate, "yyyy-MM-dd")
        End With
    End Sub

    Private Sub frmBussDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewBdate()
        chkBussAuto.Checked = My.Settings.BussAuto
    End Sub

    Private Sub cmdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdT.Click
        UpdateBussDate()
        MsgBox("Bussiness date updated successfully!    ", vbInformation, "Update Bussiness Date")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub chkBussAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBussAuto.CheckedChanged
        My.Settings.BussAuto = chkBussAuto.Checked
        My.Settings.Save()
    End Sub
End Class