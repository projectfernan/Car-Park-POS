Imports ADODB
Public Class frmCashOut

    Private Sub frmCashOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()
        fillL()

        txtTotalCash.Text = MakeMoney(TotalCashOut(MainForm.txtBussDate.Text))
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width / 3
        Dim NemW As Integer = w + w
        lstList.Columns.Add("Operator", NemW, HorizontalAlignment.Left)
        lstList.Columns.Add("Cash Out", w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblcashout where BussDate like '" & MainForm.txtBussDate.Text & "%'")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rs("CashOutBy").Value, lup)
                    viewlst.SubItems.Add(MakeMoney(Val(rs("CashOut").Value)))
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            Save_ErrLogs("[fillL] frmCashOut", ex.Message)
        End Try
    End Sub

    Function TotalCashOut(ByVal bussdt As Date) As Double
        If conLocal() = False Then Return 0
        Try
            Dim Petsa As String = Format(bussdt, "yyyy-MM-dd")

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select sum(Cashout) as TotalCash from tblcashout where BussDate like '" & Petsa & "%'")

            If rs.EOF = False Then
                Return rs("TotalCash").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Save_ErrLogs("[TotalCashOut] frmCashOut", ex.Message)
            Return 0
        End Try
    End Function

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        'If frmMain.TxtOp.Text = "Locked" Then
        'MsgBox("The transaction cannot be proceed, because there is operator has been logged in.", vbExclamation, "Cash Out")
        'Exit Sub
        'End If
        Dim f As New frmBreakdown
        f.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class