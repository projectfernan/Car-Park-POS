Imports ADODB
Imports System.Threading
Public Class frmCashierLogout
    Public Delegate Sub PrintCashierOut()
    Private Sub frmCashierLogout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtFrm.Value = frmMain.txtBussDate.Text

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

    Sub CommandPrintCashierOut()
        If (InvokeRequired) Then
            Invoke(New PrintCashierOut(AddressOf CommandPrintCashierOut))
        Else

            Cursor.Current = Cursors.WaitCursor
            If OrFrom(cboCashier.Text, frmMain.txtStation.Text, dtFrm.Value.ToString) <> "-" Then
                printCAshierRaw(cboCashier.Text, dtFrm.Value.ToString)
            Else
                MsgBox("No record found!", vbExclamation, "Print")
            End If
            Cursor.Current = Cursors.Arrow

        End If
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        ''
        Dim th As New Thread(New ThreadStart(AddressOf CommandPrintCashierOut))
        th.Start()

    End Sub

    Private Sub cboCashier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCashier.SelectedIndexChanged

    End Sub
End Class