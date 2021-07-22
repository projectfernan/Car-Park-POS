Imports ADODB
Public Class frmAddDiscount

    Private Sub frmAddDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cboVtype.Text = vbNullString Or txtRef.Text = vbNullString Then
                Exit Sub
            End If

            Call cmdGo_Click(sender, New System.EventArgs)


            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmAddDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
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
            Percent = rs("Percentage").Value
        Else
            Percent = 0
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
            .lblDiscount.Text = MakeMoney(discnt)
            .lblVAT.Text = MakeMoney(vat)
            .lblSubTotal.Text = MakeMoney(subTotal)
            .lblTotal.Text = MakeMoney(lesDis)
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
            vat = (lesDis / 1.12) * 0.12
            subTotal = lesDis - vat
            .lblDiscount.Text = MakeMoney(discnt)
            .lblVAT.Text = MakeMoney(vat)
            .lblSubTotal.Text = MakeMoney(subTotal)
            .lblTotal.Text = MakeMoney(lesDis)
        End With
    End Sub

    Sub TotalDiscountNV(ByVal total As Double, ByVal discount As Double)
        Dim discnt As Double
        Dim lesDis As Double
        Dim vatExempt As Double
        Dim totalVatExempt As Double
        With frmMain

            vatExempt = total / 1.12
            totalVatExempt = total - vatExempt
            discnt = vatExempt * discount
            lesDis = vatExempt - discnt

            .txtVatExempt.Text = MakeMoney(totalVatExempt)
            .lblDiscount.Text = MakeMoney(discnt)
            .lblVAT.Text = "0.00"
            .lblSubTotal.Text = "0.00"
            .lblTotal.Text = MakeMoney(lesDis)
        End With
    End Sub

    Sub MinDiscountNV(ByVal minTotal As Double, ByVal discount As Double, ByVal total As Double)
        Dim discnt As Double
        Dim lesDis As Double

        With frmMain
            discnt = minTotal * discount
            lesDis = total - discnt

            .lblDiscount.Text = MakeMoney(discnt)
            .lblVAT.Text = "0.00"
            .lblSubTotal.Text = "0.00"
            .lblTotal.Text = MakeMoney(lesDis)
        End With
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        If cboVtype.Text = vbNullString Or txtRef.Text = vbNullString Then
            Exit Sub
        End If

        S_Refnumber = txtRef.Text

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

    Private Sub frmAddDiscount_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cboVtype.Text = vbNullString
        txtRef.Text = vbNullString
        cboVtype.Focus()
    End Sub
End Class