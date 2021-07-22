Public Class frmChargeCateg

    Private Sub cmdHourly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHourly.Click
        frmCharging.ShowDialog()
    End Sub

    Private Sub cmdOvernigth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOvernigth.Click
        frmOvernigth.ShowDialog()
    End Sub

    Private Sub btnDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiscount.Click
        frmDiscount.ShowDialog()
    End Sub

    Private Sub btnVat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVat.Click
        frmVAtSettings.ShowDialog()
    End Sub

    Private Sub frmChargeCateg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Call cmdHourly_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F2 Then
            Call cmdOvernigth_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.F3 Then
            If btnVat.Enabled = True Then
                Call btnVat_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F4 Then
            Call btnDiscount_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmChargeCateg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.POS_VER = "GOVERNMENT BASED" Then
            btnVat.Enabled = False
        End If
    End Sub
End Class