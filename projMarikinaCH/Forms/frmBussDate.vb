Public Class frmBussDate

    Sub UpdateBussDate()
        With My.Settings
            .BussDate = dtBdate.Value
            .HourlyCut = dtHcut.Value
            .FlatCut = dtFcut.Value
            .SaleCutt = dtSaleCutt.Value
            .Save()
            MainForm.txtBussDate.Text = Format(.BussDate, "yyyy-MM-dd")
        End With
    End Sub

    Sub viewBdate()
        With My.Settings
            On Error Resume Next
            dtBdate.Value = .BussDate
            dtHcut.Value = .HourlyCut
            dtFcut.Value = .FlatCut
            dtSaleCutt.Value = .SaleCutt
            MainForm.txtBussDate.Text = Format(.BussDate, "yyyy-MM-dd")
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

    Private Sub chkBussAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBussAuto.CheckedChanged
        My.Settings.BussAuto = chkBussAuto.Checked
        My.Settings.Save()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class