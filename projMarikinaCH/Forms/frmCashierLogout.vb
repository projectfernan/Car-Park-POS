Imports ADODB
Imports System.Threading
Public Class frmCashierLogout
    Public Delegate Sub PrintCashierOut()
    Private Sub frmCashierLogout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtFrm.Value = MainForm.txtBussDate.Text
        chkLOprint.Checked = My.Settings.LOPrint

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

    Sub CommandPrintCashierOut()
        If (InvokeRequired) Then
            Invoke(New PrintCashierOut(AddressOf CommandPrintCashierOut))
        Else
            'Cursor.Current = Cursors.WaitCursor
            printCAshierRaw(cboCashier.Text, dtFrm.Value)
            'Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If My.Settings.KickCashDrawer = True Then
            OpenCashdrawer(My.Settings.PrinterDriver)
        End If

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Dim th As New Thread(New ThreadStart(AddressOf CommandPrintCashierOut))
        th.Start()

        Cursor = Cursors.Default
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkLOprint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLOprint.CheckedChanged
        My.Settings.LOPrint = chkLOprint.Checked
        My.Settings.Save()
    End Sub
End Class