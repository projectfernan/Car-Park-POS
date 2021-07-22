Public Class frmBussDate

    Sub UpdateBussDate()
        With My.Settings
            .BussDate = Format(CDate(dtDate.Value), "MM-dd-yyyy")
            .Save()
            frmMain.txtBussDate.Text = .BussDate
        End With
    End Sub

    Sub viewBdate()
        With My.Settings
            On Error Resume Next
            If .BussDate = vbNullString Then Exit Sub
            dtDate.Value = .BussDate
            frmMain.txtBussDate.Text = .BussDate
        End With
    End Sub

    Private Sub frmBussDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewBdate()
    End Sub

    Private Sub cmdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdT.Click
        UpdateBussDate()
        MsgBox("Bussiness date updated successfully!    ", vbInformation, "Update Bussiness Date")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class