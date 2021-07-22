Imports System.Threading
Public Class frmStationOut
    Public Delegate Sub PrintStation()

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub commandPrintStationRaw()
        If (InvokeRequired) Then
            Invoke(New PrintStation(AddressOf commandPrintStationRaw))
        Else
            Cursor.Current = Cursors.WaitCursor
            If sOrFrom(frmMain.txtStation.Text) <> "-" Then
                printStationRaw(dt1.Value, dt2.Value)
            Else
                MsgBox("No record found!", vbExclamation, "Print")
            End If
            Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        Dim th As New Thread(New ThreadStart(AddressOf commandPrintStationRaw))
        th.Start()
    End Sub

    Private Sub frmStationOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class