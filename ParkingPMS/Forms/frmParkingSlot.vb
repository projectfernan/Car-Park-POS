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
            If rs.EOF = False Then
                rs("TOTAL").Value = txtSlot.Value
                rs.Update()
            Else
                rs.AddNew()
                rs("TOTAL").Value = txtSlot.Value
                rs.Update()
            End If
       
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Set POS")
        End Try
    End Sub

    Private Sub cmdT_Click(sender As System.Object, e As System.EventArgs) Handles cmdT.Click
        saveSlot()
        PMSmain.txtTotalSlot.Text = viewSlot()
        MsgBox("Total parking slot successfully set!", vbInformation, "Parking Slot")
        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class