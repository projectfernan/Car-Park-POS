Imports System.Threading

Public Class frmSummRep
    Public Delegate Sub PrintSumm()

    Private Sub frmSummRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtFrm.Value = MainForm.txtBussDate.Text
    End Sub

    Sub CommandPrint()

        If (InvokeRequired) Then
            Invoke(New PrintSumm(AddressOf CommandPrint))
        Else
            'Cursor.Current = Cursors.WaitCursor
            printSummRaw(dtFrm.Value)

            'Cursor.Current = Cursors.Arrow
        End If

    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If My.Settings.KickCashDrawer = True Then
            OpenCashdrawer(My.Settings.PrinterDriver)
        End If

        Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Dim th As New Thread(New ThreadStart(AddressOf CommandPrint))
        th.Start()

        Cursor = Cursors.Default
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class