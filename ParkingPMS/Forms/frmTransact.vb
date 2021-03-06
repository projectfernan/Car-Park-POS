Imports ADODB
Public Class frmTransact
    Public EntryTime As Date
    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 380
    End Sub

    Private Sub frmManualInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtPlate.CharacterCasing = CharacterCasing.Upper
        loc()
        tranDisable()
        If conLocal() = True Then
            vehicleCharging(cboVtype)
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Me.Close()
        End If

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub detect()
        If d8_Card() = True Then
            tranEnable()
            cboVtype.Focus()
            d8_Beep()

            PoleDisOpen()
            clear()
            display()
            PoleDisClose()

            lblMsg2.Visible = True
            lblMsg1.Visible = False
            tmrDetect.Enabled = False
        Else
            lblMsg2.Visible = False
            lblMsg1.Visible = True
        End If
    End Sub

    Function getTimein(ByVal HexID As String) As Boolean
        If frmMain.txtDbStat.Text = "Connected" Then
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from timeinDB where CardCode = '" & HexID & "'", conSqlPOS, 1, 2)
            If rs.EOF = False Then
                tmeIn = rs("TimeIn").Value
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Function ChargeMode() As Boolean
        If frmMain.txtMODE.Text = "FLAT RATE" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        iout = Now
        If d8_Card() = True Then
            If d8_LoadpassOL() = True Then
                If d8_AuthenOL() = True Then
                    HexCardID = vbNullString
                    HexCardID = d8_ReadOL()
                    If getTimein(HexCardID) = True Then
                        With frmMain
                            .InPic.Image = Get_PicIn(HexCardID)
                            .DriverImage.Image = Get_PicDriver(HexCardID)
                            If MsgBox("Vehicle identified?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Transaction") = vbYes Then
                                .lblTimeIn.Text = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")
                                .lblTimeOut.Text = Format(CDate(iout), "yyyy-MM-dd HH:mm:ss")

                                If ChargeMode() = True Then
                                    Dim amtDue As Double = HourLy_RATE(cboVtype.Text, tmeIn, iout)
                                    Dim ov As Double = GETovernyt(tmeIn, iout, cboVtype.Text)
                                    Dim totalAmt As Double = totalAmount(amtDue, ov, 0)
                                    Dim vatAmt As Double = VAT(totalAmt)

                                    .lblAmountDue.Text = Format(Math.Round(amtDue, 2), "0.00") 'intAmount(getMinMinutes, totalTime)
                                    .lblOvernigth.Text = Format(Math.Round(ov, 2), "0.00")
                                    .lblVtype.Text = cboVtype.Text
                                    .lblPlate.Text = UCase(txtPlate.Text)
                                    .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
                                    .lblTotal.Text = totalAmount(amtDue, ov, 0)
                                    totalAmt = totalAmount(amtDue, ov, 0)
                                    .lblVAT.Text = VAT(totalAmt)
                                    .lblSubTotal.Text = subTotal(totalAmt, vatAmt)
                                    .ToolTransact.Enabled = True
                                    .cmdBt.Enabled = False
                                    .cmdLost.Enabled = False
                                    trOpt = True
                                    TrLostOpt = True
                                    Me.Close()
                                Else
                                    Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, tmeIn, iout)
                                    'Dim ovF As Double = overnyt(tmeIn, iout)
                                    Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                                    Dim vatAmtF As Double = VAT(totalAmtF)

                                    .lblAmountDue.Text = Format(Math.Round(amtDueF, 2), "0.00")
                                    .lblOvernigth.Text = "0.00"
                                    .lblVtype.Text = cboVtype.Text
                                    .lblPlate.Text = UCase(txtPlate.Text)
                                    .lblTotalTime.Text = TotalTime_FUNCTION(tmeIn, iout)
                                    .lblTotal.Text = totalAmount(amtDueF, "0.00", 0)
                                    'TotalAmt = totalAmount(amtDueF, 0, 0)
                                    .lblVAT.Text = VAT(totalAmtF)
                                    .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)
                                    .ToolTransact.Enabled = True
                                    .cmdBt.Enabled = False
                                    .cmdLost.Enabled = False
                                    trOpt = True
                                    TrLostOpt = True
                                    Me.Close()
                                End If
                            Else
                                Me.Close()
                            End If
                        End With
                    Else
                        With frmMain
                            If d8_Loadpass() = True Then
                                If d8_Authen() = True Then
                                    If readCard() = False Then
                                        MsgBox("No record found!    ", vbExclamation, "Transaction")
                                        Me.Close()
                                        Exit Sub
                                    End If
                                    .InPic.Image = Get_PicIn(HexCardID)
                                    .DriverImage.Image = Get_PicDriver(HexCardID)

                                    .lblTimeIn.Text = Format(EntryTime, "yyyy-MM-dd HH:mm:ss")
                                    .lblTimeOut.Text = Format(iout, "yyyy-MM-dd HH:mm:ss")

                                    If ChargeMode() = True Then
                                        Dim amtDue As Double = HourLy_RATE(cboVtype.Text, EntryTime, iout)
                                        Dim ov As Double = GETovernyt(EntryTime, iout, cboVtype.Text)
                                        Dim totalAmt As Double = totalAmount(amtDue, ov, 0)
                                        Dim vatAmt As Double = VAT(totalAmt)

                                        .lblAmountDue.Text = Format(Math.Round(amtDue, 2), "0.00")  'intAmount(getMinMinutes, totalTime)
                                        .lblOvernigth.Text = Format(Math.Round(ov, 2), "0.00")
                                        .lblVtype.Text = cboVtype.Text
                                        .lblPlate.Text = UCase(txtPlate.Text)
                                        .lblTotalTime.Text = TotalTime_FUNCTION(EntryTime, iout)
                                        .lblTotal.Text = totalAmount(amtDue, ov, 0)
                                        totalAmt = totalAmount(amtDue, ov, 0)
                                        .lblVAT.Text = VAT(totalAmt)
                                        .lblSubTotal.Text = subTotal(totalAmt, vatAmt)
                                        .ToolTransact.Enabled = True
                                        .cmdBt.Enabled = False
                                        .cmdLost.Enabled = False
                                        trOpt = True
                                        TrLostOpt = True
                                        Me.Close()
                                    Else
                                        Dim amtDueF As Double = Compute_FlateRATE(cboVtype.Text, EntryTime, iout)
                                        'Dim ovF As Double = overnyt(tmeIn, iout)
                                        Dim totalAmtF As Double = totalAmount(amtDueF, "0.00", 0)
                                        Dim vatAmtF As Double = VAT(totalAmtF)

                                        .lblAmountDue.Text = Compute_FlateRATE(cboVtype.Text, EntryTime, iout)
                                        .lblOvernigth.Text = "0.00"
                                        .lblVtype.Text = cboVtype.Text
                                        .lblPlate.Text = UCase(txtPlate.Text)
                                        .lblTotalTime.Text = TotalTime_FUNCTION(EntryTime, iout)
                                        .lblTotal.Text = totalAmount(amtDueF, "0.00", 0)
                                        'TotalAmt = totalAmount(amtDueF, 0, 0)
                                        .lblVAT.Text = VAT(totalAmtF)
                                        .lblSubTotal.Text = subTotal(totalAmtF, vatAmtF)
                                        .ToolTransact.Enabled = True
                                        .cmdBt.Enabled = False
                                        .cmdLost.Enabled = False
                                        trOpt = True
                                        TrLostOpt = True
                                        Me.Close()
                                    End If
                                End If
                            End If
                        End With
                    End If
                End If
            End If
        Else
            MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
        End If
    End Sub

    Private Sub txtPlate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdGo_Click(sender, New System.EventArgs)
        End If
    End Sub

    Public Function readCard() As Boolean
        Try
            tmeIn = Trim(d8_Read()) + ":00"
            EntryTime = vbNullString
            EntryTime = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub tmrDetect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDetect.Tick
        detect()
    End Sub

End Class