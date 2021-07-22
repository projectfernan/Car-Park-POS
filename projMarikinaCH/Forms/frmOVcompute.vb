Imports ADODB
Public Class frmOVcompute

    Private Sub frmOVcompute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            vehicleOV(cboVtype)
        End If
        lblTotalAmount.Text = "0.00"
        lbltotalTime.Text = 0
    End Sub

    Public Sub vehicleOV(ByVal cbo As ComboBox)
        Try
            Dim rs As New Recordset
            cbo.Items.Clear()

            rs = New Recordset
            rs = conSqlLoc.Execute("SELECT * from tblovernigth")

            While rs.EOF = False
                cbo.Items.Add(rs("Vtype").Value)
                rs.MoveNext()
            End While
        Catch ex As Exception
            Save_ErrLogs("[vehicleOV] frmOVcompute", ex.Message)
        End Try
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        If cboVtype.Text = vbNullString Then Exit Sub
        lblTotalAmount.Text = GETovernyt(dtFrm.Value, dtTo.Value, cboVtype.Text)
        lbltotalTime.Text = Over_count
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class