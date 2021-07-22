Public Class frmSocket

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub saveSocket()
        With My.Settings
            .S_Listener = txtlistener.Value
            .S_ServerHost = txtServerHost.Text
            .S_ServerPort = txtServerPort.Value
        End With
    End Sub

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        saveSocket()
        MsgBox("Socket settings successfully saved! ", vbInformation, "Save")
        Me.Close()
    End Sub
End Class