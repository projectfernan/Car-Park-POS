Imports ADODB
Module MainCtrl
    Public errMsg As String = vbNullString

    Public signal As String
    Public item As String
    Public iCode As String
    Public Bcode As String
    Public iName As String
    Public iPrice As Double
    Public addChargeId As String
    Public verClose As String
    Public acces As String
    Public trOpt As Boolean
    Public TrLostOpt As Boolean
    Public Report As String

    Public Sub disable()

        With MainForm
            .btnEntryVeh.Enabled = False
            .cmdBt.Enabled = False
            .cmdRR.Enabled = False
            .cmdEditPlate.Enabled = False
            .cmdLO.Enabled = False
            '.ToolTransact.Enabled = False
            .cmdDiscount.Enabled = False
            .cmdCancel.Enabled = False

            .cmdLost.Enabled = False
            .cmdManualLost.Enabled = False
            .cmdManualTR.Enabled = False
            .txtTender.Enabled = False
            '.GpDetails.Enabled = False
            '.gpTran.Enabled = False

        End With
    End Sub

    Public Sub enable()
        With MainForm
            .btnEntryVeh.Enabled = True
            .cmdBt.Enabled = True
            .cmdRR.Enabled = True
            .cmdEditPlate.Enabled = True
            .cmdLO.Enabled = True
            .cmdLost.Enabled = True
            .cmdManualLost.Enabled = True
            .cmdManualTR.Enabled = True
            '.GpDetails.Enabled = True
            '.gpTran.Enabled = True
        End With
    End Sub

    Public Sub login()
        'frmMain.cmdLogin.Enabled = False
        MainForm.cmdLO.Enabled = True
    End Sub

    Public Sub logout()
        MainForm.cmdLO.Enabled = False
        'frmMain.cmdLogin.Enabled = True
    End Sub

    Public Sub viewPOSset()
        On Error Resume Next
        With My.Settings
            frmSetPOS.txtTitle.Text = .TITLE
            frmSetPOS.txtAdd.Text = .ADDR
            frmSetPOS.txtContact.Text = .CONTACT
            frmSetPOS.txtTin.Text = .TIN
            frmSetPOS.txtPermit.Text = .PERMIT
            frmSetPOS.txtSerial.Text = .SERIAL
            frmSetPOS.txtMachine.Text = .MACHINE
            frmSetPOS.txtAccr.Text = .ACCR
            frmSetPOS.cboStation.Text = .STATION
            frmSetPOS.cboChargeState.Text = .MODE
            'frmSetPOS.cboMode.Text = .Operation

            frmSetPOS.txtOperatedBy.Text = .N_OperatedBy
            frmSetPOS.txtPOSVendor.Text = .N_PosVendor
            frmSetPOS.txtVendorAddr.Text = .N_PosVendorAddr
            frmSetPOS.txtVendorTin.Text = .N_PosVendorTin
            frmSetPOS.dtAccr.Value = .N_AccrDate
            frmSetPOS.dtPermit.Value = .N_PermitDateIssued

            MainForm.txtMODE.Text = .Operation & " - " & .MODE
            If My.Settings.Operation = "SINGLE" Then
                MainForm.btnEntryVeh.Visible = False
            Else
                MainForm.btnEntryVeh.Visible = True
            End If
            MainForm.txtStation.Text = .STATION
            MainForm.lblORno.Text = Ticket_OR_No()
        End With
    End Sub

    Public Function viewSlot() As Integer
        If conServer() = False Then Return 0

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from parkingslot")
            If rs.EOF = False Then
                viewSlot = CInt(rs("TOTAL").Value)
            Else
                viewSlot = 0
            End If
        Catch ex As Exception
            Save_ErrLogs("[viewSlot]", ex.Message)
            Return 0
        End Try
    End Function

    Public Sub tranDisable()
        With frmTransact
            '.cboVtype.Enabled = False
            .txtPlate.Enabled = False
            .cmdGo.Enabled = False
        End With
    End Sub

    Public Sub tranEnable()
        With frmTransact
            '.cboVtype.Enabled = True
            .txtPlate.Enabled = True
            .cmdGo.Enabled = True
        End With
    End Sub

    Public Sub viwStation()
        With My.Settings
            If .STATION = vbNullString Then
                Exit Sub
            End If
            MainForm.txtStation.Text = .STATION
        End With
    End Sub

    Public Sub RESETinfo()
        With MainForm
            .lblPlate.Text = "-"
            .lblVtype.Text = "-"
            .lblTimeIn.Text = "-"
            .lblTimeOut.Text = "-"

            .lblTotalTime.Text = "0 Hr and 0 Mins"
            .lblAmountDue.Text = MakeMoney(0)
            .lblOvernigth.Text = MakeMoney(0)
            .lblLostCard.Text = MakeMoney(0)
            .lblSubTotal.Text = MakeMoney(0)
            .lblDiscount.Text = MakeMoney(0)
            .lblVAT.Text = MakeMoney(0)
            .lblTotal.Text = MakeMoney(0)
            .lblVatExempt.Text = MakeMoney(0)
            .lblZeroRated.Text = MakeMoney(0)

            P_Discount = 0
            P_DiscountType = vbNullString
            P_DiscPer = 0
        End With
    End Sub

    Public Sub kansela()
        With MainForm
            .lblPlate.Text = "-"
            .lblVtype.Text = "-"
            .lblTimeIn.Text = "-"
            .lblTimeOut.Text = "-"

            .lblTotalTime.Text = "0 Hr and 0 Mins"
            .lblAmountDue.Text = MakeMoney(0)
            .lblOvernigth.Text = MakeMoney(0)
            .lblLostCard.Text = MakeMoney(0)
            .lblSubTotal.Text = MakeMoney(0)
            .lblDiscount.Text = MakeMoney(0)
            .lblVAT.Text = MakeMoney(0)
            .lblTotal.Text = MakeMoney(0)
            .lblVatExempt.Text = MakeMoney(0)
            .lblZeroRated.Text = MakeMoney(0)
            .cmdBt.Enabled = True
            .cmdLost.Enabled = True

            trOpt = False
            TrLostOpt = False
            '.InPic.Image = Image.FromFile(Application.StartupPath & "\noCar.jpg")
            '.ToolTransact.Enabled = False
            .cmdDiscount.Enabled = False
            .cmdCancel.Enabled = False

            HexCardID = vbNullString
            tmeIn = vbNullString

            .txtTender.Enabled = False
            .txtTender.Text = vbNullString

            P_Discount = 0
            P_DiscountType = vbNullString
            P_DiscPer = 0
        End With
    End Sub

    Public Function slot() As Integer
        Try
            Dim totalSlot As Integer = viewSlot()
            If conServer() = False Then Return 0

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("CALL get_TakenSlot")
            If rs.EOF = False Then
                Dim SlotLeft As Integer = totalSlot - CInt(rs("TakenSlot").Value)
                Return SlotLeft
            Else
                Return totalSlot
            End If
        Catch ex As Exception
            Save_ErrLogs("[slot]", ex.Message)
            Return 0
        End Try
    End Function

    Public Sub saveSlot(ByVal Slot As Integer)
        Try
            If conServer() = False Then Exit Sub

            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from parkingslot", conSqlPOS, 1, 2)
            If rs.EOF = False Then
                rs("TOTAL").Value = Slot
                rs.Update()
            Else
                rs.AddNew()
                rs("TOTAL").Value = Slot
                rs.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Set POS")
        End Try
    End Sub
End Module
