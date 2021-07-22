Imports ADODB
Public Class frmAddDiscount

    Private Sub frmAddDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMain.txtDbStat.Text = "Connected" Then
            Discount(cboVtype)
        Else
            Discount(cboVtype)
        End If
    End Sub

    Function VerDiscount() As Boolean
        Dim rs As New Recordset
        rs = conSqlLoc.Execute("select * from tblDiscount where DiscountName = '" & cboVtype.Text & "'")
        If rs.EOF = False Then
            If rs("DiscountOption").Value = "Total Discount" Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Function VerVAT() As Boolean
        Dim rs As New Recordset
        rs = conSqlLoc.Execute("select * from tblDiscount where DiscountName = '" & cboVtype.Text & "'")
        If rs.EOF = False Then
            If rs("VatOption").Value = "Disabled VAT" Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Function Percent() As Double
        Dim rs As New Recordset
        rs = conSqlLoc.Execute("select * from tblDiscount where DiscountName = '" & cboVtype.Text & "'")
        If rs.EOF = False Then
            Percent = Format(Math.Round(Val(rs("Percentage").Value), 1), "0.00")
        Else
            Percent = "0.00"
        End If
    End Function

    Sub TotalDiscountWV(ByVal total As Double, ByVal discount As Double)
        Dim discnt As Double = 0
        Dim lesDis As Double = 0
        Dim vat As Double = 0
        Dim subTotal As Double = 0

        With frmMain
            discnt = total * discount
            lesDis = total - discnt
            vat = lesDis / 1.12 * 0.12
            subTotal = lesDis - vat
            .lblDiscount.Text = Format(Math.Round(Val(discnt), 1), "#,###,###.00")
            .lblVAT.Text = Format(Math.Round(Val(vat), 1), "#,###,###.00")
            .lblSubTotal.Text = Format(Math.Round(Val(subTotal), 1), "#,###,###.00")
            .lblTotal.Text = Format(Math.Round(Val(lesDis), 1), "#,###,###.00")
        End With
    End Sub

    Sub MinDiscountWV(ByVal minTotal As Double, ByVal discount As Double, ByVal total As Double)
        Dim discnt As Double
        Dim lesDis As Double
        Dim vat As Double
        Dim subTotal As Double

        With frmMain
            discnt = minTotal * discount
            lesDis = total - discnt
            vat = lesDis / 1.12 * 0.12
            subTotal = lesDis - vat
            .lblDiscount.Text = Format(Math.Round(discnt, 1), "#,###,###.00")
            .lblVAT.Text = Format(Math.Round(vat, 1), "#,###,###.00")
            .lblSubTotal.Text = Format(Math.Round(subTotal, 1), "#,###,###.00")
            .lblTotal.Text = Format(Math.Round(lesDis, 1), "#,###,###.00")
        End With
    End Sub

    Sub TotalDiscountNV(ByVal total As Double, ByVal discount As Double)
        Dim discnt As Double
        Dim lesDis As Double

        With frmMain
            discnt = total * discount
            lesDis = total - discnt

            .lblDiscount.Text = Format(Math.Round(discnt, 1), "#,###,###.00")
            .lblVAT.Text = "#,###,###.00"
            .lblSubTotal.Text = "#,###,###.00"
            .lblTotal.Text = Format(Math.Round(lesDis, 1), "#,###,###.00")
        End With
    End Sub

    Sub MinDiscountNV(ByVal minTotal As Double, ByVal discount As Double, ByVal total As Double)
        Dim discnt As Double
        Dim lesDis As Double

        With frmMain
            discnt = minTotal * discount
            lesDis = total - discnt

            .lblDiscount.Text = Format(Math.Round(discnt, 1), "#,###,###.00")
            .lblVAT.Text = "0.00"
            .lblSubTotal.Text = "0.00"
            .lblTotal.Text = Format(Math.Round(lesDis, 1), "#,###,###.00")
        End With
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        With frmMain
            If conLocal() = True Then
                If VerDiscount() = True Then
                    If VerVAT() = True Then
                        TotalDiscountNV(.lblTotal.Text, Percent)
                        .cmdDiscount.Enabled = False
                        Me.Close()
                        Exit Sub
                    Else
                        TotalDiscountWV(.lblTotal.Text, Percent)
                        .cmdDiscount.Enabled = False
                        Me.Close()
                        Exit Sub
                    End If
                Else
                    If VerVAT() = True Then
                        MinDiscountNV(.lblAmountDue.Text, Percent, .lblTotal.Text)
                        .cmdDiscount.Enabled = False
                        Me.Close()
                        Exit Sub
                    Else
                        MinDiscountWV(.lblAmountDue.Text, Percent, .lblTotal.Text)
                        .cmdDiscount.Enabled = False
                        Me.Close()
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End With
    End Sub

    Private Sub cboVtype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboVtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            With frmMain
                If conLocal() = True Then
                    If VerDiscount() = True Then
                        If VerVAT() = True Then
                            TotalDiscountNV(.lblTotal.Text, Percent)
                            .cmdDiscount.Enabled = False
                            Me.Close()
                            Exit Sub
                        Else
                            TotalDiscountWV(.lblTotal.Text, Percent)
                            .cmdDiscount.Enabled = False
                            Me.Close()
                            Exit Sub
                        End If
                    Else
                        If VerVAT() = True Then
                            MinDiscountNV(.lblAmountDue.Text, Percent, .lblTotal.Text)
                            .cmdDiscount.Enabled = False
                            Me.Close()
                            Exit Sub
                        Else
                            MinDiscountWV(.lblAmountDue.Text, Percent, .lblTotal.Text)
                            .cmdDiscount.Enabled = False
                            Me.Close()
                            Exit Sub
                        End If
                    End If
                Else
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                End If
            End With
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cboVtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVtype.SelectedIndexChanged

    End Sub
End Class