Imports ADODB
Public Class frmBreakdown

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmBreakdown_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtTotalCash.Text = "0.00"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            rs("CashOutBy").Value = frmMain.TxtOp.Text
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

    Private Sub cmdCashOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        saveCashOut()
        If conLocal() = True Then
            PrntCashOut(frmMain.TxtOp.Text, My.Settings.BussDate, nem)
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

    Private Sub txtQty1k_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty1k.KeyPress
        If Len(txtQty1k.Text) = 0 And Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
        If Len(txtQty1k.Text) = 0 And Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtQty1k_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty1k.TextChanged
        txt1kAmt.Text = CInt(txtQty1k.Text) * Val(txt1k.Text)
        txt1kAmt.Text = MakeMoney(Val(txt1kAmt.Text))
        total()
    End Sub

    Private Sub txtQty500_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty500.KeyPress
        If Len(txtQty500.Text) = 0 And Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
        If Len(txtQty500.Text) = 0 And Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtQty500_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty500.TextChanged
        txt500Amt.Text = CInt(txtQty500.Text) * Val(txt500.Text)
        txt500Amt.Text = MakeMoney(Val(txt500Amt.Text))
        total()
    End Sub

    Private Sub txtQty200_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty200.KeyPress
        If Len(txtQty200.Text) = 0 And Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
        If Len(txtQty200.Text) = 0 And Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtQty200_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty200.TextChanged
        txt200Amt.Text = CInt(txtQty200.Text) * Val(txt200.Text)
        txt200Amt.Text = MakeMoney(Val(txt200Amt.Text))
        total()
    End Sub

    Private Sub txtQty100_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty100.KeyPress
        If Len(txtQty100.Text) = 0 And Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
        If Len(txtQty100.Text) = 0 And Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtQty100_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty100.TextChanged
        txt100Amt.Text = CInt(txtQty100.Text) * Val(txt100.Text)
        txt100Amt.Text = MakeMoney(Val(txt100Amt.Text))
        total()
    End Sub

    Private Sub txtQty50_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty50.KeyPress
        If Len(txtQty50.Text) = 0 And Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
        If Len(txtQty50.Text) = 0 And Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtQty50_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty50.TextChanged
        txt50Amt.Text = CInt(txtQty50.Text) * Val(txt50.Text)
        txt50Amt.Text = MakeMoney(Val(txt50Amt.Text))
        total()
    End Sub

    Private Sub txtQty20_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty20.KeyPress
        If Len(txtQty20.Text) = 0 And Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
        If Len(txtQty20.Text) = 0 And Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 13 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtQty20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty20.TextChanged
        txt20Amt.Text = CInt(txtQty20.Text) * Val(txt20.Text)
        txt20Amt.Text = MakeMoney(Val(txt20Amt.Text))
        total()
    End Sub

    Sub total()
        Dim tt As Double = Val(txt1kAmt.Text) + Val(txt500Amt.Text) + Val(txt200Amt.Text) + Val(txt100Amt.Text) + Val(txt50Amt.Text) + Val(txt20Amt.Text)
        txtTotalCash.Text = MakeMoney(tt)
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

    Private Sub cmdCashOut_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashOut.Click
        If cboCashier.Text = vbNullString Then
            MsgBox("Please select cashier! ", vbExclamation, "Cash Out Breakdown")
            Exit Sub
        End If

        AddDeno(txtQty1k.Text, txt1k.Text)
        AddDeno(txtQty500.Text, txt500.Text)
        AddDeno(txtQty200.Text, txt200.Text)
        AddDeno(txtQty100.Text, txt100.Text)
        AddDeno(txtQty50.Text, txt50.Text)
        AddDeno(txtQty20.Text, txt20.Text)

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

    Private Sub frmBreakdown_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            CashierList(cboCashier)
        End If
    End Sub
End Class