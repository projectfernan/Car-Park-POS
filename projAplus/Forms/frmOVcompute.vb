﻿Imports ADODB
Public Class frmOVcompute

    Private Sub frmOVcompute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            vehicleOV(cboVtype)
        End If
        lblTotalAmount.Text = "0.00"
        lbltotalTime.Text = 0
    End Sub

    Public Sub vehicleOV(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * from tblOvernigth")

        While rs.EOF = False
            cbo.Items.Add(rs("Vtype").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If cboVtype.Text = vbNullString Then Exit Sub
        Dim OvAmount As Double = GETovernyt(dtFrm.Value, dtTo.Value, cboVtype.Text)
        lblTotalAmount.Text = MakeMoney(OvAmount)
        lbltotalTime.Text = Over_count
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub
End Class