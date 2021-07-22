Imports ADODB
Public Class frmAddDiscount
    Dim DiscountPer As Double
    Dim VatExemptStat As Boolean

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

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = MainForm.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmAddDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()
        If conLocal() = True Then
            Discount(cboVtype)
        End If
    End Sub

    Function VATExempt() As Boolean
        Try
            If conLocal() = False Then Return False

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select VatExempt from tblDiscount where DiscountName = '" & cboVtype.Text & "'")
            If rs.EOF = False Then
                Return Convert.ToBoolean(Convert.ToInt32(rs("VatExempt").Value))
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("[VATExempt] Apply Discount", ex.Message)
            Return False
        End Try
    End Function

    Function Percent() As Double
        Try
            If conLocal() = False Then Return 0

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblDiscount where DiscountName = '" & cboVtype.Text & "'")
            If rs.EOF = False Then
                Percent = rs("Percentage").Value
            Else
                Percent = 0
            End If
        Catch ex As Exception
            Save_ErrLogs("[Percent] Apply Discount", ex.Message)
            Return 0
        End Try
    End Function

    Sub TotalDiscountWV(ByVal total As Double, ByVal discount As Double)
        Dim discnt As Double = 0
        Dim lesDis As Double = 0
        Dim vat As Double = 0
        Dim subTotal As Double = 0

        With MainForm
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

        With MainForm
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

        With MainForm
            discnt = total * discount
            lesDis = total - discnt

            .lblDiscount.Text = MakeMoney(discnt)
            .lblVAT.Text = "0.00"
            .lblSubTotal.Text = "0.00"
            .lblTotal.Text = MakeMoney(lesDis)
        End With
    End Sub

    Sub MinDiscountNV(ByVal minTotal As Double, ByVal discount As Double, ByVal total As Double)
        Dim discnt As Double
        Dim lesDis As Double

        With MainForm
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
        P_DiscountType = cboVtype.Text

        ApplyDiscount()
    End Sub

    Sub ApplyDiscount()
        Try
            If conLocal() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
                Exit Sub
            Else

                If Get_DiscountInfo(cboVtype.Text) = False Then
                    Exit Sub
                End If

                With MainForm
                    Dim ToDiscAmt As Double = .lblTotal.Text
                    Dim VatPer As Double = GetVat() + 1
                    Dim vatExemptAmt As Double
                    Dim DiscountAmt As Double
                    Dim VatSale As Double
                    Dim VatAmt As Double
                    Dim LessTotalDiscAmt As Double

                    Select Case VatExemptStat
                        Case True
                            vatExemptAmt = ToDiscAmt / VatPer
                            vatExemptAmt = Math.Round(vatExemptAmt, 2)
                            DiscountAmt = vatExemptAmt * DiscountPer
                            DiscountAmt = Math.Round(DiscountAmt, 2)
                            LessTotalDiscAmt = vatExemptAmt - DiscountAmt

                            .lblDiscount.Text = MakeMoney(DiscountAmt)
                            .lblTotal.Text = MakeMoney(LessTotalDiscAmt)
                            .lblVatExempt.Text = MakeMoney(vatExemptAmt)
                            .lblVAT.Text = MakeMoney(0)
                            .lblSubTotal.Text = MakeMoney(0)
                        Case False
                            DiscountAmt = ToDiscAmt * DiscountPer
                            DiscountAmt = Math.Round(DiscountAmt, 2)
                            LessTotalDiscAmt = ToDiscAmt - DiscountAmt
                            LessTotalDiscAmt = Math.Round(LessTotalDiscAmt)
                            VatSale = LessTotalDiscAmt / VatPer
                            VatAmt = LessTotalDiscAmt - VatSale

                            .lblDiscount.Text = MakeMoney(DiscountAmt)
                            .lblTotal.Text = MakeMoney(LessTotalDiscAmt)
                            .lblSubTotal.Text = MakeMoney(VatSale)
                            .lblVAT.Text = MakeMoney(VatAmt)
                    End Select

                    Me.Close()
                End With
            End If
        Catch ex As Exception
            Save_ErrLogs("ApplyDiscount", ex.Message)
        End Try
    End Sub

    Function Get_DiscountInfo(ByVal DiscName As String) As Boolean
        Try
            If conLocal() = False Then
                Return False
            End If

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select Percentage,VatExempt from tblDiscount where DiscountName = '" & cboVtype.Text & "'")
            If rs.EOF = False Then
                DiscountPer = rs("Percentage").Value
                P_DiscPer = DiscountPer
                VatExemptStat = Convert.ToBoolean(Convert.ToInt32(rs("VatExempt").Value))
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("Get_DiscountInfo", ex.Message)
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Function GetVat() As Double
        Try
            If conLocal() = False Then
                Return False
            End If

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select Vat from tblvat")
            If rs.EOF = False Then
                Return rs("Vat").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Save_ErrLogs("[GetVat] Apply Discount", ex.Message)
            Return 0
        End Try
    End Function

    Private Sub frmAddDiscount_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cboVtype.Text = vbNullString
        txtRef.Text = vbNullString
        cboVtype.Focus()
    End Sub
End Class