Public Class frmDiscountCateg

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub WaveOvernigth(ByVal OvAmount As Double, ByVal totalAmt As Double)
        Dim newTotal As Double = totalAmt - OvAmount
        frmMain.lblTotal.Text = MakeMoney(newTotal)
        frmMain.lblOvernigth.Text = "0.00"
    End Sub

    Private Sub frmDiscountCateg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If optDiscount.Checked = True Then
                frmAddDiscount.ShowDialog()
                Me.Close()
            End If

            If optOVvalid.Checked = True Then
                WaveOvernigth(frmMain.lblOvernigth.Text, frmMain.lblTotal.Text)
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmDiscountCateg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmDiscountCateg_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        optDiscount.Checked = True
    End Sub
End Class