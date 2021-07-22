Imports ADODB
Public Class frmParkingSlot

    Sub saveSlot()
        If conLocal() = False Then
            MsgBox("Please connect to database!", vbExclamation, "Set")
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from parkingslot", conSqlLoc, 1, 2)
            rs("TOTAL").Value = txtSlot.Value
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Set POS")
        End Try
    End Sub

    Private Sub cmdT_Click(sender As System.Object, e As System.EventArgs) Handles cmdT.Click
        saveSlot()
        frmPMSmain.txtTotalSlot.Text = viewSlot()
        MsgBox("Total parking slot successfully set!", vbInformation, "Parking Slot")
        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub
End Class