Imports ADODB
Public Class AddMoney

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        AddDeno()
        With frmBreakdown
            .txtTotalCash.Text = MakeMoney(TotalCash(My.Settings.BussDate))
        End With
        Me.Close()
    End Sub

    Function TotalCash(ByVal bussdt As Date) As Double
        If conLocal() = False Then Return 0
        Try
            Dim Petsa As String = Format(bussdt, "yyyy-MM-dd")

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select sum(TotalAmt) as TotalCash from tblbreakdown where Operator = '" & frmMain.TxtOp.Text & "' and BussDate like '" & Petsa & "%'")

            If rs.EOF = False Then
                Return rs("TotalCash").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Sub AddDeno()
        If conLocal() = False Then Exit Sub

        Try
            Dim Amt As Double = txtDeno.Value * txtQty.Value

            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblbreakdown where 1=0", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("Denomination").Value = txtDeno.Value
            rs("Qty").Value = txtQty.Value
            rs("TotalAmt").Value = Amt
            rs("Operator").Value = frmMain.TxtOp.Text
            rs("BussDate").Value = My.Settings.BussDate
            rs.Update()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub AddMoney_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtDeno.Value = 0
        txtQty.Value = 0

    End Sub
End Class