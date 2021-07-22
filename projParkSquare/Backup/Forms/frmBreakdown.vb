Imports ADODB
Public Class frmBreakdown

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmBreakdown_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'lstList.Clear()
        header()
        txtTotalCash.Text = "0.00"
    End Sub

    Sub header()
        'Dim w As Integer = lstList.Width / 3
        'Dim NemW As Integer = w + w
        'lstList.Columns.Add("Denomination", w, HorizontalAlignment.Left)
        'lstList.Columns.Add("Qty", w, HorizontalAlignment.Left)
        'lstList.Columns.Add("Total", w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblbreakdown where Operator = '" & frmMain.TxtOp.Text & "' and BussDate like '" & frmMain.txtBussDate.Text & "%' order by Denomination Desc")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                ' lstList.Refresh()
                Dim viewlst As New ListViewItem
                'viewlst = lstList.Items.Add(rs("Denomination").Value, lup)
                viewlst.SubItems.Add(rs("Qty").Value)
                viewlst.SubItems.Add(MakeMoney(Val(rs("TotalAmt").Value)))
                rs.MoveNext()
            Next
        End If
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
            Return 0
        End Try
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddMoney.ShowDialog()
    End Sub

    Sub saveCashOut()
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("Select * from tblcashout", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("CashOut").Value = txtTotalCash.Text
            rs("CashOutBy").Value = cboCashier.Text
            rs("BussDate").Value = frmMain.txtBussDate.Text
            rs.Update()
        Catch ex As Exception

        End Try

    End Sub

    Sub ClearBreakdown()
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblbreakdown")
        Catch ex As Exception

        End Try
    End Sub

    Sub AddDeno(ByVal Qty As Integer, ByVal Deno As Double)
        If conLocal() = False Then Exit Sub

        Try
            Dim Amt As Double = Qty * Deno

            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblbreakdown where 1=0", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("Denomination").Value = MakeMoney(Deno)
            rs("Qty").Value = Qty
            rs("TotalAmt").Value = Amt
            rs("Operator").Value = cboCashier.Text
            rs("BussDate").Value = My.Settings.BussDate
            rs.Update()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCashOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashOut.Click
        If cboCashier.Text = vbNullString Then
            MsgBox("Please select cashier! ", vbExclamation, "Cash Out Breakdown")
            Exit Sub
        End If

        AddDeno(txtQty1k.Value, txt1k.Text)
        AddDeno(txtQty500.Value, txt500.Text)
        AddDeno(txtQty200.Value, txt200.Text)
        AddDeno(txtQty100.Value, txt100.Text)
        AddDeno(txtQty50.Value, txt50.Text)
        AddDeno(txtQty20.Value, txt20.Text)

        saveCashOut()
        If conLocal() = True Then
            PrntCashOut(cboCashier.Text, My.Settings.BussDate, nem)
        End If
        ClearBreakdown()
        With frmCashOut
            .lstList.Clear()
            .header()
            .fillL()
            .txtTotalCash.Text = MakeMoney(TotalCashOut(My.Settings.BussDate))
        End With
        Me.Close()
    End Sub

    Sub total()
        Dim tt As Double = Val(txt1kAmt.Text) + Val(txt500Amt.Text) + Val(txt200Amt.Text) + Val(txt100Amt.Text) + Val(txt50Amt.Text) + Val(txt20Amt.Text)
        txtTotalCash.Text = MakeMoney(tt)
    End Sub

    Private Sub txtQty1k_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty1k.GotFocus
        txt1kAmt.Text = CInt(txtQty1k.Value) * Val(txt1k.Text)
        total()
    End Sub

    Private Sub txtQty_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty1k.ValueChanged
        txt1kAmt.Text = CInt(txtQty1k.Value) * Val(txt1k.Text)
        total()
    End Sub

    Private Sub txtQty500_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty500.GotFocus
        txt500Amt.Text = CInt(txtQty500.Value) * Val(txt500.Text)
        total()
    End Sub

    Private Sub txtQty500_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty500.ValueChanged
        txt500Amt.Text = CInt(txtQty500.Value) * Val(txt500.Text)
        total()
    End Sub

    Private Sub txtQty200_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty200.GotFocus
        txt200Amt.Text = CInt(txtQty200.Value) * Val(txt200.Text)
        total()
    End Sub

    Private Sub txtQty200_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty200.ValueChanged
        txt200Amt.Text = CInt(txtQty200.Value) * Val(txt200.Text)
        total()
    End Sub

    Private Sub txtQty100_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty100.GotFocus
        txt100Amt.Text = CInt(txtQty100.Value) * Val(txt100.Text)
        total()
    End Sub

    Private Sub txtQty100_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty100.ValueChanged
        txt100Amt.Text = CInt(txtQty100.Value) * Val(txt100.Text)
        total()
    End Sub

    Private Sub txtQty50_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty50.GotFocus
        txt50Amt.Text = CInt(txtQty50.Value) * Val(txt50.Text)
        total()
    End Sub

    Private Sub txtQty50_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty50.ValueChanged
        txt50Amt.Text = CInt(txtQty50.Value) * Val(txt50.Text)
        total()
    End Sub

    Private Sub txtQty20_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQty20.GotFocus
        txt20Amt.Text = CInt(txtQty20.Value) * Val(txt20.Text)
        total()
    End Sub

    Private Sub txtQty20_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty20.ValueChanged
        txt20Amt.Text = CInt(txtQty20.Value) * Val(txt20.Text)
        total()
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

    Function TotalCash(ByVal bussdt As Date, ByVal op As String) As Double
        If conLocal() = False Then Return 0
        Try
            Dim Petsa As String = Format(bussdt, "yyyy-MM-dd")

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select sum(TotalAmt) as TotalCash from tblbreakdown where Operator = '" & op & "' and BussDate like '" & Petsa & "%'")

            If rs.EOF = False Then
                Return rs("TotalCash").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub frmBreakdown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            CashierList(cboCashier)
        End If
    End Sub
End Class