Public Class frmOR

    Private Sub frmOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOR.Value = My.Settings.OR_Number
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdT.Click
        With My.Settings
            .OR_Number = txtOR.Value
            .Save()
            frmMain.lblORno.Text = Ticket_OR_No()
            MsgBox("OR number successfull set!", vbInformation, "OR Settings")
            Me.Close()
        End With
    End Sub
End Class