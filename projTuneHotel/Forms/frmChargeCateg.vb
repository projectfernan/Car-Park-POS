﻿Public Class frmChargeCateg

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdHourly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHourly.Click
        frmCharging.ShowDialog()
    End Sub

    Private Sub cmdFlat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMontlyRate.ShowDialog()
    End Sub

    Private Sub cmdOvernigth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOvernigth.Click
        frmOvernigth.ShowDialog()
    End Sub

    Private Sub frmChargeCateg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmCharging.ShowDialog()
        End If

        If e.KeyCode = Keys.F2 Then
            frmOvernigth.ShowDialog()
        End If

        If e.KeyCode = Keys.F3 Then
            frmVAtSettings.ShowDialog()
        End If

        If e.KeyCode = Keys.F5 Then
            frmMontlyRate.ShowDialog()
        End If

    End Sub

    Private Sub frmChargeCateg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        frmVAtSettings.ShowDialog()
    End Sub

    Private Sub cmdInhouseRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInhouseRate.Click
        frmGuestRate.ShowDialog()
    End Sub
End Class