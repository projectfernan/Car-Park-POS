Imports ADODB
Public Class frmCompute

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        OV_LessHr = 0

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Select Case cboCtype.Text
            Case "Flat Rate"
                lbltotalTime.Text = TotalTime_FUNCTION(dtFrm.Text, dtTo.Text)
                lblTotalAmount.Text = Compute_FlateRATE(cboVtype.Text, dtFrm.Text, dtTo.Text)
            Case "Hourly"
                lbltotalTime.Text = TotalTime_FUNCTION(dtFrm.Text, dtTo.Text)
                lblTotalAmount.Text = HourLy_RATE(cboVtype.Text, dtFrm.Text, dtTo.Text)
        End Select
    End Sub

    Private Sub frmCompute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbltotalTime.Text = "0 Hrs and 0 Mins"
        lblTotalAmount.Text = "0.00"
        cboVtype.Text = vbNullString
        cboCtype.Text = vbNullString

        If conLocal() = True Then
            vehicleCharging(cboVtype)
        End If
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cboCtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

End Class