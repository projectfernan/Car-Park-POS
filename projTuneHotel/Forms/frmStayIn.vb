Imports ADODB
Public Class frmStayIn

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        Dim w2 As Integer = lstList.Width / 3
        Dim w3 As Integer = w - w2
        lstList.Columns.Add("Plate No", w2, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", w3, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from timeindb")

        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Plate").Value, lup)
                viewlst.SubItems.Add(rs("Timein").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub frmStayIn_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        lstList.Clear()
        header()
        fillL()
    End Sub

    Private Sub cmdCashOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashOut.Click
        If conServer() = True Then
            PrntStayIn(frmMain.TxtOp.Text, My.Settings.BussDate, nem)
        End If
    End Sub
End Class