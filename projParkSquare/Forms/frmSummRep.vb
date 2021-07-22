Imports System.Threading

Public Class frmSummRep
    Public Delegate Sub PrintSumm()

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmSummRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtFrm.Value = frmMain.txtBussDate.Text
        chkRAWprint.Checked = My.Settings.SumRawPrint
        picLoading.Visible = False
    End Sub

    Sub CommandPrint()

        If (InvokeRequired) Then
            Invoke(New PrintSumm(AddressOf CommandPrint))
        Else
            Cursor.Current = Cursors.WaitCursor
            If sumOrFrom(frmMain.txtStation.Text, dtFrm.Value) <> "-" Then
                If chkRAWprint.Checked = False Then
                    PrntSummLO(dtFrm.Value)
                ElseIf chkRAWprint.Checked = True Then
                    printSummRaw(dtFrm.Value)
                End If
            Else
                MsgBox("No record found!", vbExclamation, "Print")
            End If
            Cursor.Current = Cursors.Arrow
        End If

    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click

        Dim th As New Thread(New ThreadStart(AddressOf CommandPrint))
        th.Start()
       
    End Sub
End Class