Public Class frmChargingLED

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub frmChargingLED_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboCom1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCom1.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboCom2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCom2.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboCom3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCom3.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdH_Click(sender As System.Object, e As System.EventArgs) Handles cmdH.Click
        If PingMe(txtHourlyIP.Text) = False Then
            MsgBox("Failed to connect!", vbExclamation, "Send")
            Exit Sub
        End If

        If LEDcon(txtHourlyIP.Text, cboCom1.SelectedIndex) = True Then
            If LEDMsg(txtHourlyAmt.Text, cboCom1.SelectedIndex) = True Then
                SendLEDmsg(cboCom1.SelectedIndex)
            Else
                MsgBox("Failed to write the message!", vbExclamation, "Send")
            End If
        Else
            MsgBox("Failed to connect!", vbExclamation, "Send")
        End If
    End Sub
End Class