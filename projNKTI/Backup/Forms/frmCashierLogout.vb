﻿Imports ADODB
Public Class frmCashierLogout

    Private Sub frmCashierLogout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            CashierList(cboCashier)
        End If

    End Sub

    Public Sub CashierList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * from tbluseracc where Designation = 'Operator'")

        While rs.EOF = False
            cbo.Items.Add(rs("Name").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If OrFrom(cboCashier.Text, frmMain.txtStation.Text, dtFrm.Value.ToString, dtTo.Value.ToString) <> "-" Then
            PrntLO(cboCashier.Text, dtFrm.Value.ToString, dtTo.Value.ToString)
            saveAudiUpdate(str_SysUser, str_SysPosi, "Operator logout report generated")
        Else
            MsgBox("No record found!", vbExclamation, "Print")
        End If
    End Sub
End Class