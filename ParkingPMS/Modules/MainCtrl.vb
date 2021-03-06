Imports ADODB
Module MainCtrl
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
        With frmMain
            .cmdBt.Enabled = False
            .cmdRR.Enabled = False
            .cmdSS.Enabled = False
            .cmdLO.Enabled = False
            .ToolTransact.Enabled = False
            .cmdLost.Enabled = False
            '.GpDetails.Enabled = False
            '.gpTran.Enabled = False
        End With
    End Sub

    Public Sub enable()
        With frmMain
            .cmdBt.Enabled = True
            .cmdRR.Enabled = True
            .cmdSS.Enabled = True
            .cmdLO.Enabled = True
            .cmdLost.Enabled = True
            '.GpDetails.Enabled = True
            '.gpTran.Enabled = True
        End With
    End Sub

    Public Sub login()
        'frmMain.cmdLogin.Enabled = False
        frmMain.cmdLO.Enabled = True
    End Sub

    Public Sub logout()
        frmMain.cmdLO.Enabled = False
        'frmMain.cmdLogin.Enabled = True
    End Sub

    Sub viewPOSset()
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
            frmSetPOS.cboMode.Text = .MODE
            frmMain.txtMODE.Text = .MODE
        End With
    End Sub

    Function viewSlot() As String

        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from parkingslot")
        If rs.EOF = False Then
            viewSlot = rs("TOTAL").Value
        Else
            viewSlot = "0"
        End If
    End Function

    Sub tranDisable()
        With frmTransact
            .cboVtype.Enabled = False
            .txtPlate.Enabled = False
            .cmdGo.Enabled = False
        End With
    End Sub

    Sub tranEnable()
        With frmTransact
            .cboVtype.Enabled = True
            .txtPlate.Enabled = True
            .cmdGo.Enabled = True
        End With
    End Sub

    Sub viwStation()
        With My.Settings
            If .STATION = vbNullString Then
                Exit Sub
            End If
            frmMain.txtStation.Text = .STATION
        End With
    End Sub

    Sub viwLostcard()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from LostCardDB")
            If rs.EOF = False Then
                frmLostCard.txtAmount.Value = rs("Amount").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub viwLostcardL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from LostCardDB")
            If rs.EOF = False Then
                frmLostCard.txtAmount.Value = rs("Amount").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub kansela()
        With frmMain
            .lblPlate.Text = "-"
            .lblVtype.Text = "-"
            .lblTimeIn.Text = "-"
            .lblTimeOut.Text = "-"

            .lblTotalTime.Text = "0 Hr and 0 Mins"
            .lblAmountDue.Text = "0.00"
            .lblOvernigth.Text = "0.00"
            .lblLostCard.Text = "0.00"
            .lblSubTotal.Text = "0.00"
            .lblDiscount.Text = "0.00"
            .lblVAT.Text = "0.00"
            .lblTotal.Text = "0.00"
            .cmdBt.Enabled = True
            .cmdLost.Enabled = True
            trOpt = False
            TrLostOpt = False
            '.InPic.Image = Image.FromFile(Application.StartupPath & "\noCar.jpg")
            .ToolTransact.Enabled = False
            .cmdDiscount.Enabled = True
            HexCardID = vbNullString
            tmeIn = vbNullString

        End With
    End Sub
End Module
