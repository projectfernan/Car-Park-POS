Imports ADODB
Imports System.Drawing.Printing

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Public Card As String
    Public Vtyp As String
    Public Plate As String
    Public InTime As String

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If verClose = "Quit" Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If trOpt = True And TrLostOpt = True Then
            If e.KeyCode = Keys.Enter Then

            End If
        End If

        If trOpt = True And TrLostOpt = True Then
            If e.KeyCode = Keys.D1 Then
                'frmAddDiscount.ShowDialog()
            End If
        End If

        If trOpt = True And TrLostOpt = True Then
            If e.KeyCode = Keys.D2 Then
                ' Call cmdCancel_Click_1(sender, New System.EventArgs)
            End If
        End If

        If Access = "Login" Then
            If e.Control = True And e.KeyCode = Keys.Enter Then
                If ToolTransact.Enabled = False Then
                    Me.TopMost = False
                    frmLogin.ShowDialog()
                End If
            End If
        Else
            If e.Control = True And e.KeyCode = Keys.Enter Then
                If ToolTransact.Enabled = False Then
                    Me.TopMost = False
                    frmLogin.ShowDialog()
                End If
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F1 Then
                Call cmdBt_Click_1(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F2 Then
                Call cmdGuest_Click(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F3 Then
                Call cmdMonthy_Click(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F5 Then
                frmFindLostCard.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F6 Then
                frmManualTR.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F7 Then
                frmEditPlate.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.Escape Then
                Call cmdLO_Click_1(sender, New System.EventArgs)
            End If
        End If

        If e.Control = True And e.KeyCode = Keys.Insert Then
            If TxtOp.Text = "fernan" Then
                desig = "Admin"
                frmSystem.ShowDialog()
            End If
        End If
    End Sub

    Function orNO() As String
        On Error Resume Next
        Dim rs As New Recordset
        txtTimer.Text = Format(Now, "HH:mm:ss")
        Dim st As String = Replace(txtStation.Text, "Station ", vbNullString) 'Trim(Mid(txtTimer.Text, 2, 1)) + Trim(Mid(txtTimer.Text, 5, 1)) + Trim(Mid(txtTimer.Text, 8, 1))
        Dim tt As String
        rs = New Recordset

        rs = conSqlPOS.Execute("Select * from tblIncomeReport")
        tt = rs.RecordCount + 1
        If tt < 10 Then
            orNO = st + "-" + "00000" + tt
        ElseIf tt >= 10 Then
            orNO = st + "-" + "0000" + tt
        ElseIf tt >= 100 Then
            orNO = st + "-" + "000" + tt
        ElseIf tt >= 1000 Then
            orNO = st + "-" + "00" + tt
        ElseIf tt >= 10000 Then
            orNO = st + "-" + "0" + tt
        Else
            orNO = st + "-" + tt
        End If
    End Function

    Function orNOL() As String
        On Error Resume Next
        Dim rs As New Recordset
        txtTimer.Text = Format(Now, "HH:mm:ss")
        Dim st As String = Replace(txtStation.Text, "Station ", vbNullString) 'Trim(Mid(txtTimer.Text, 2, 1)) + Trim(Mid(txtTimer.Text, 5, 1)) + Trim(Mid(txtTimer.Text, 8, 1))
        Dim tt As String
        rs = New Recordset

        rs = conSqlLoc.Execute("Select * from tblIncomeReport")
        tt = rs.RecordCount + 1
        If tt < 10 Then
            orNOL = st + "-" + "00000" + tt
        ElseIf tt >= 10 Then
            orNOL = st + "-" + "0000" + tt
        ElseIf tt >= 100 Then
            orNOL = st + "-" + "000" + tt
        ElseIf tt >= 1000 Then
            orNOL = st + "-" + "00" + tt
        ElseIf tt >= 10000 Then
            orNOL = st + "-" + "0" + tt
        Else
            orNOL = st + "-" + tt
        End If

    End Function

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.DesktopLock = True Then
            disableExplorer()
        End If

        lblORno.Text = Ticket_OR_No()
        trOpt = False
        TrLostOpt = False
        frmBussDate.viewBdate()

        ViewDriver()
        viewBarrierSettings()

        camInfo()
        camEntrance1()
        camEntrance()
        viewPDcom()
        disable()
        verClose = "Lock"
        viewPOSset()

        'Station
        viwStation()
        'MySQL Connecting
        viewCon()

        'If PingMe(frmConnDB.txtIp1.Text) = True Then
        If conServer() = True Then
            txtDbStat.Text = "Connected"
            txtDbStat.ForeColor = Color.Lime
            frmSetPOS.txtSlot.Text = viewSlot()
            txtTotalSlot.Text = viewSlot()
            txtSlot.Text = slot()
            'tmeSlot.Enabled = True
        Else
            txtDbStat.Text = "Disconnected"
            txtDbStat.ForeColor = Color.Pink
        End If
        'End If

        If conLocal() = True Then
            dbstat2.Text = "Connected"
            dbstat2.ForeColor = Color.Lime

            If frmLogo.chk = False Then
                PicLogo.Image = Logo_Image()
            End If
        Else
            dbstat2.Text = "Disconnected"
            dbstat2.ForeColor = Color.Pink
            Exit Sub
        End If

    End Sub

    Function FlatDayCheck(ByVal DayToday As String) As Boolean
        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblflatday where FlatRateDay = '" & DayToday & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function FlatHolidayCheck(ByVal DayToday As String) As Boolean
        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblholidayflat where HolidayDate = '" & DayToday & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub CheckCutOff()
        Dim addBussDate As Date = My.Settings.BussDate
        Dim NewAddBussDate As Date = addBussDate.AddDays(1)
        Dim NowDate As String = Format(Now, "yyyy-MM-dd") 'NewBussDate.AddDays(1)
        Dim OldBussDate As String = Format(My.Settings.BussDate, "yyyy-MM-dd")

        If NowDate > OldBussDate Then
            If FlatDayCheck(Format(My.Settings.BussDate, "dddd")) = True Or FlatDayCheck(Format(My.Settings.BussDate, "MM-dd")) = True Then
                Dim NowTime As Date = Format(Now, "HH:mm:ss")
                Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")

                If NowTime > Fcut Then
                    My.Settings.BussDate = NowDate
                    My.Settings.Save()
                    txtBussDate.Text = NowDate
                End If
            Else
                Dim NowTime As Date = Format(Now, "HH:mm:ss")
                Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")

                If NowTime > Hcut Then
                    My.Settings.BussDate = NowDate
                    My.Settings.Save()
                    txtBussDate.Text = NowDate
                End If
            End If
        End If
    End Sub

    Function BussdateStr() As String
        Dim NowDate As String = Format(Now, "yyyy-MM-dd")
        Dim OldBussDate As String = Format(My.Settings.BussDate, "yyyy-MM-dd")

        If NowDate = OldBussDate Then
            Return Format(Now, "yyyy-MM-dd HH:mm:ss")
        End If

        If NowDate > OldBussDate Then
            If FlatDayCheck(Format(My.Settings.BussDate, "dddd")) = True Or FlatDayCheck(Format(My.Settings.BussDate, "MM-dd")) = True Then
                Dim NowTime As Date = Format(Now, "HH:mm:ss")
                Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")

                If NowTime <= Fcut Then
                    Return Format(My.Settings.BussDate, "yyyy-MM-dd 23:59:59")
                Else
                    If NowDate > OldBussDate Then
                        Return Format(My.Settings.BussDate, "yyyy-MM-dd 23:59:59")
                    Else
                        Return Format(My.Settings.BussDate, "yyyy-MM-dd HH:mm:ss")
                    End If

                End If
            Else
                Dim NowTime As Date = Format(Now, "HH:mm:ss")
                Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")

                If NowTime <= Hcut Then
                    Return Format(My.Settings.BussDate, "yyyy-MM-dd 23:59:59")
                Else
                    If NowDate > OldBussDate Then
                        Return Format(My.Settings.BussDate, "yyyy-MM-dd 23:59:59")
                    Else
                        Return Format(My.Settings.BussDate, "yyyy-MM-dd HH:mm:ss")
                    End If
                End If
            End If
        End If
    End Function

    Private Sub tmeTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeTime.Tick
        txtTime.Text = Format(Now, "Long Date")
        txtTimer.Text = Format(Now, "HH:mm:ss tt")
        'lblInOut.Text = Format(Now, "General Date")
        txtStatus.Text = Output(frmBarrier.txtStatAdd.Text)

        If My.Settings.BussAuto = False Then
            CheckCutOff()
        End If

        If My.Settings.DesktopLock = True Then
            For Each selProcess As Process In Process.GetProcesses
                If selProcess.ProcessName = "taskmgr" Then
                    selProcess.Kill()
                    Exit For
                End If
            Next
        End If

        txtTender.Focus()
    End Sub

    Private Sub cmdMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSystem.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLogin.ShowDialog()
    End Sub

    Private Sub cmdManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmTransact.ShowDialog()
    End Sub


    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLogin.ShowDialog()
    End Sub

    Private Sub ToolStrip3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F1 Then
            frmLogin.ShowDialog()
        End If
    End Sub

    Private Sub tmeSlot_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeSlot.Tick

    End Sub

    Private Sub frmMain_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Focus()
        Me.KeyPreview = True
    End Sub

    Sub reprint()
        On Error Resume Next
        Dim rs As New Recordset

        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblIncomeReport order by ID desc")
        If rs.EOF = False Then

            P_ORno = rs("ORno").Value
            P_Permit = My.Settings.PERMIT
            P_TIN = My.Settings.TIN
            P_ACCR = My.Settings.ACCR
            P_CardCode = rs("CardCode").Value
            P_EntTime = rs("TimeIn").Value
            P_ExtTime = rs("TimeOut").Value
            P_TotalTime = rs("TotalTime").Value
            P_Vehicle = rs("VehicleType").Value
            P_PlateNo = rs("Plate").Value

            P_HourLy = Format(Math.Round(Val(rs("Total").Value), 2), "0.00")
            P_Overnigth = Format(Math.Round(Val(rs("Overnigth").Value), 2), "0.00")
            P_Lost = Format(Math.Round(Val(rs("LostCard").Value), 2), "0.00")
            P_Total = Format(Math.Round(Val(rs("Total").Value), 2), "0.00")
            P_Vat = Format(Math.Round(Val(rs("VAT").Value), 2), "0.00")
            P_Vatable = Format(Math.Round(Val(rs("SubTotal").Value), 2), "0.00")
            P_Tendered = Format(Math.Round(Val(rs("Tendered").Value), 2), "0.00")
            P_Change = Format(Math.Round(Val(rs("Change").Value), 2), "0.00")

            P_Discount = Format(Math.Round(Val(rs("Discount").Value), 2), "0.00")

            P_Teller = rs("Operator").Value
            P_Station = rs("Station").Value
            P_Machine = My.Settings.MACHINE
            P_Serial = My.Settings.SERIAL
            P_date = Format(Now, "General Date")

            P_Msg = "* REPRINT COPY OF OFFICIAL RECEIPT *"

        End If

    End Sub

    Sub reprintL()
        On Error Resume Next
        Dim rs As New Recordset

        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblIncomeReport order by ID desc")
        If rs.EOF = False Then

            P_ORno = rs("ORno").Value
            P_Permit = My.Settings.PERMIT
            P_TIN = My.Settings.TIN
            P_ACCR = My.Settings.ACCR
            P_CardCode = rs("CardCode").Value
            P_EntTime = rs("TimeIn").Value
            P_ExtTime = rs("TimeOut").Value
            P_TotalTime = rs("TotalTime").Value
            P_Vehicle = rs("VehicleType").Value
            P_PlateNo = rs("Plate").Value

            P_HourLy = Format(Math.Round(Val(rs("Total").Value), 2), "0.00")
            P_Overnigth = Format(Math.Round(Val(rs("Overnigth").Value), 2), "0.00")
            P_Lost = Format(Math.Round(Val(rs("LostCard").Value), 2), "0.00")
            P_Total = Format(Math.Round(Val(rs("Total").Value), 2), "0.00")
            P_Vat = Format(Math.Round(Val(rs("VAT").Value), 2), "0.00")
            P_Vatable = Format(Math.Round(Val(rs("SubTotal").Value), 2), "0.00")
            P_Tendered = Format(Math.Round(Val(rs("Tendered").Value), 2), "0.00")
            P_Change = Format(Math.Round(Val(rs("Change").Value), 2), "0.00")

            P_Discount = Format(Math.Round(Val(rs("Discount").Value), 2), "0.00")

            P_Teller = rs("Operator").Value
            P_Station = rs("Station").Value
            P_Machine = My.Settings.MACHINE
            P_Serial = My.Settings.SERIAL
            P_date = Format(Now, "General Date")

            P_Msg = "* REPRINT COPY OF OFFICIAL RECEIPT *"

        End If

    End Sub

    Private Sub cmdAccept_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtSlot.Text = slot()
        PoleDisOpen()
        clear()
        displayTotal(lblTotal.Text)
        PoleDisClose()
        With frmTender
            .txtTender.Text = vbNullString
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddDiscount.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure do you want to cancel this transaction?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Cancel") = vbYes Then
            PoleDisOpen()
            clear()
            display()
            PoleDisClose()
            kansela()
        End If
    End Sub

    Function getTimein(ByVal HexID As String) As Boolean
        If conServer() = True Then
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

    Public Function readCard() As Boolean
        Try
            tmeIn = Trim(d8_Read()) + ":00"
            EntryTime = vbNullString
            EntryTime = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:00")
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function readCardGrace() As Boolean
        Try
            tmeIn = Trim(d8_Read_Grace) + ":00"
            EntryTime = vbNullString
            EntryTime = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:00")
            Return True
        Catch
            Return False
        End Try
    End Function

    Function ViewPlate(ByVal Code As String) As String
        If conServer() = False Then Return vbNullString

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from timeindb where CardCode = '" & Code & "'")
            If rs.EOF = False Then
                Return rs("Plate").Value
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Return vbNullString
        End Try

    End Function

    Private Sub cmdBt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBt.Click
        TRtype = vbNullString
        TRtype = "Regular"

        txtSlot.Text = slot()

        If txtMODE.Text = vbNullString Then
            MsgBox("Please set POS!    ", vbExclamation, "Transaction")
            frmSetPOS.ShowDialog()
            Exit Sub
        End If
        If d8_conn() = True Then
            d8_Beep()
            lblORno.Text = Ticket_OR_No()
            With frmTransact
                '.cboVtype.Text = vbNullString
                .txtPlate.Text = vbNullString
                If d8_Card() = True Then
                    If d8_LoadpassOL() = True Then
                        If d8_AuthenOL() = True Then
                            HexCardID = vbNullString
                            HexCardID = d8_ReadOL()
                            If getTimein(HexCardID) = False Then
                                If d8_Loadpass() = True Then
                                    If d8_Authen() = True Then
                                        If readCard() = False Then
                                            If readCardGrace() = False Then
                                                MsgBox("No record found!    ", vbExclamation, "Transaction")
                                                Me.Close()
                                                Exit Sub
                                            Else
                                                If MsgBox("This Card Exceeded the Grace Period? ", vbQuestion + vbYesNo, "Transact") = vbYes Then
                                                    frmExeedGrace.ShowDialog()
                                                End If
                                            End If
                                        Else
                                                InPic.Image = Get_PicIn(HexCardID)
                                                DriverImage.Image = Get_PicDriver(HexCardID)
                                                .txtPlate.Text = ViewPlate(HexCardID)
                                                .ShowDialog()
                                        End If
                                    End If
                                End If
                            Else
                                InPic.Image = Get_PicIn(HexCardID)
                                DriverImage.Image = Get_PicDriver(HexCardID)
                                .txtPlate.Text = ViewPlate(HexCardID)
                                .ShowDialog()
                            End If
                        End If
                    End If
                Else
                    MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
                End If
            End With
            Exit Sub
        Else
            MsgBox("No device connected!    ", vbExclamation, "Transaction")
        End If
    End Sub

    Private Sub cmdLost_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLost.Click
        txtSlot.Text = slot()

        lblORno.Text = Ticket_OR_No()
        frmFindLostCard.ShowDialog()
    End Sub

    Private Sub cmdSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSS.Click
        frmEditPlate.ShowDialog()
    End Sub

    Private Sub cmdLO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLO.Click
        If MsgBox("Are you sure do you want to logout?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Logout") = MsgBoxResult.Yes Then
            If My.Settings.LogoutRep = False Then
                If OrFrom(TxtOp.Text, txtStation.Text, My.Settings.BussDate.ToString) <> "-" Then
                    PrntLO(TxtOp.Text, My.Settings.BussDate.ToString)
                End If
            End If
            dellogTime(txtUsername.Text)
            Access = "Logout"
            verClose = "Lock"
            TxtOp.Text = vbNullString
            txtUsername.Text = vbNullString
            kansela()
            disable()
            'cmdLogin.Enabled = True
        End If
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TopMost = True
        If My.Settings.DesktopLock = True Then
            disableExplorer()

        End If
    End Sub

    Private Sub cmdManualTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManualTR.Click
        frmManualTR.ShowDialog()
    End Sub

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        txtSlot.Text = slot()
        PoleDisOpen()
        clear()
        displayTotal(lblTotal.Text)
        PoleDisClose()
        With frmTender
            .txtTender.Text = vbNullString
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdDiscount_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        frmAddDiscount.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If MsgBox("Are you sure do you want to cancel this transaction?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Cancel") = vbYes Then
            PoleDisOpen()
            clear()
            display()
            PoleDisClose()
            kansela()
        End If
    End Sub

    Private Sub txtTender_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTender.EnabledChanged
        txtTender.Focus()
    End Sub

    Private Sub txtTender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTender.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTender.Text = vbNullString Then
                MsgBox("Please enter tender amount! ", vbExclamation, "Tender amount")
                txtTender.Focus()
                Exit Sub
            End If

            If d8_conn() = False Then
                MsgBox("Device is not connected! ", vbExclamation, "Tender amount")
                txtTender.Focus()
                Exit Sub
            End If

            If d8_Card() = False Then
                MsgBox("Please place your card to reader! ", vbExclamation, "Tender amount")
                txtTender.Focus()
                Exit Sub
            End If

            Select Case TRtype
                Case "Regular"
                    If D8_LoadKey(3) = False Then
                        MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If

                    If D8_Authenticate(3) = False Then
                        MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If

                    If D8_ResetCard(12) = False Then
                        MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If

                    If D8_ResetCard(13) = False Then
                        MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If

                    If D8_ResetCard(14) = False Then
                        MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If

                    '---------------------------------------------------------------------------------------

                    If D8_WriteCard(12, lblORno.Text.ToString) = False Then
                        MsgBox("Failed to write Grace Period please try again", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If

                    If D8_WriteDate(13) = False Then
                        MsgBox("Failed to write Grace Period please try again", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If

                    If D8_WriteCard(14, lblPlate.Text.ToString) = False Then
                        MsgBox("Failed to write Grace Period please try again", MsgBoxStyle.Exclamation, "Tender Amount")
                        txtTender.Focus()
                        Exit Sub
                    End If
                Case "Monthly"
                    
                Case "Guest"
                   
            End Select

            Dim tenderAmout As Double = txtTender.Text
            Dim TotalAmount As Double = lblTotal.Text
            Dim ChangeAmout As Double = MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout))

            If Get_tender(lblTotal.Text, txtTender.Text) = True Then

                If Val(tenderAmout) >= 1000 Then
                    printORticket(tenderAmout)
                    Prnt()

                    PoleDisOpen()
                    clear()
                    displayChange1k(MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout)), MakeMoney(tenderAmout))
                    PoleDisClose()

                    If conServer() = True Then
                        save(tenderAmout, ChangeAmout)
                        If My.Settings.DataPool = False Then
                            PushToServer()
                        End If
                        Update_OR()
                        lblORno.Text = Ticket_OR_No()
                        delIn()

                        txtSlot.Text = slot()
                    Else
                        If conLocal() = True Then
                            saveL(tenderAmout, ChangeAmout)
                            Update_OR()
                            lblORno.Text = Ticket_OR_No()

                        Else
                            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                            frmConnDB.ShowDialog()
                            Exit Sub
                        End If
                    End If

                    'kansela()
                    FinishedTR()
                    triger()

                ElseIf Val(tenderAmout) >= 100 Then
                    printORticket(tenderAmout)
                    Prnt()

                    PoleDisOpen()
                    clear()
                    displayChange100(MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout)), MakeMoney(tenderAmout))
                    PoleDisClose()

                    If conServer() = True Then
                        save(tenderAmout, ChangeAmout)
                        If My.Settings.DataPool = False Then
                            PushToServer()
                        End If
                        Update_OR()
                        lblORno.Text = Ticket_OR_No()
                        delIn()
                        txtSlot.Text = slot()
                    Else
                        If conLocal() = True Then
                            saveL(tenderAmout, ChangeAmout)
                            Update_OR()
                            lblORno.Text = Ticket_OR_No()
                        Else
                            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                            frmConnDB.ShowDialog()
                            Exit Sub
                        End If
                    End If

                    'kansela()
                    FinishedTR()
                    triger()

                Else
                    printORticket(tenderAmout)
                    Prnt()

                    PoleDisOpen()
                    clear()
                    displayChange(MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout)), MakeMoney(tenderAmout))
                    PoleDisClose()

                    If conServer() = True Then
                        save(tenderAmout, ChangeAmout)
                        If My.Settings.DataPool = False Then
                            PushToServer()
                        End If
                        Update_OR()
                        lblORno.Text = Ticket_OR_No()
                        delIn()

                        txtSlot.Text = slot()
                    Else
                        If conLocal() = True Then
                            saveL(tenderAmout, ChangeAmout)
                            Update_OR()
                            lblORno.Text = Ticket_OR_No()

                        Else
                            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                            frmConnDB.ShowDialog()
                            Exit Sub
                        End If
                    End If

                    'kansela()
                    FinishedTR()
                    triger()

                End If

                txtAmtStat.Text = "CHANGE :"
                lblTotal.Text = MakeMoney(ChangeAmout)
            Else
                txtTender.Text = vbNullString
                txtTender.Focus()
            End If

        End If
    End Sub

    Sub FinishedTR()
        ToolTransact.Enabled = False
        txtTender.Text = vbNullString
        txtTender.Enabled = False
    End Sub

    Sub save(ByVal Ltender As Double, ByVal Lchange As Double)
        Dim rs As New Recordset

        Try
            rs = New Recordset
            rs.Open("select * from tblIncomeReport where 1=0", conSqlPOS, 1, 2)
            rs.AddNew()
            rs("ORno").Value = lblORno.Text
            rs("CardCode").Value = HexCardID
            rs("Plate").Value = lblPlate.Text
            rs("Operator").Value = TxtOp.Text
            rs("Station").Value = txtStation.Text
            rs("TimeIn").Value = lblTimeIn.Text
            rs("TimeOut").Value = lblTimeOut.Text
            rs("TotalTime").Value = lblTotalTime.Text
            rs("InOutTotal").Value = TotalTimeInt
            rs("Hourly").Value = lblAmountDue.Text
            rs("Overnigth").Value = lblOvernigth.Text
            rs("LostCard").Value = lblLostCard.Text
            rs("Discount").Value = lblDiscount.Text
            rs("Total").Value = lblTotal.Text
            rs("VAT").Value = lblVAT.Text
            rs("SubTotal").Value = lblSubTotal.Text
            rs("Tendered").Value = Ltender
            rs("Change").Value = Lchange
            rs("VehicleType").Value = lblVtype.Text
            rs("Discount").Value = lblDiscount.Text
            rs("PayType").Value = S_PayType
            rs("RefNum").Value = S_Refnumber
            rs("BussDate").Value = BussdateStr()
            rs.Update()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub PushToServer()
        If conServer() = False Then Exit Sub
        If conLocal() = False Then Exit Sub
        Dim rs1 As New Recordset
        Dim rs As New Recordset
        Try

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblincomereport where 1=0")
            Do While rs1.EOF = False
                rs = New Recordset
                rs.Open("select * from tblIncomeReport", conSqlPOS, 1, 2)
                rs.AddNew()
                rs("ORno").Value = rs1("ORno").Value
                rs("CardCode").Value = rs1("CardCode").Value
                rs("Plate").Value = rs1("Plate").Value
                rs("Operator").Value = rs1("Operator").Value
                rs("Station").Value = rs1("Station").Value
                rs("TimeIn").Value = rs1("TimeIn").Value
                rs("TimeOut").Value = rs1("TimeOut").Value
                rs("TotalTime").Value = rs1("TotalTime").Value
                rs("InOutTotal").Value = rs1("InOutTotal").Value
                rs("Hourly").Value = rs1("Hourly").Value
                rs("Overnigth").Value = rs1("Overnigth").Value
                rs("LostCard").Value = rs1("LostCard").Value
                rs("Discount").Value = rs1("Discount").Value
                rs("Total").Value = rs1("Total").Value
                rs("VAT").Value = rs1("VAT").Value
                rs("SubTotal").Value = rs1("SubTotal").Value
                rs("Tendered").Value = rs1("Tendered").Value
                rs("Change").Value = rs1("Change").Value
                rs("VehicleType").Value = rs1("VehicleType").Value
                rs("Discount").Value = rs1("Discount").Value
                rs("PayType").Value = rs1("PayType").Value
                rs("RefNum").Value = rs1("RefNum").Value
                rs("BussDate").Value = rs1("BussDate").Value
                rs.Update()
                DelLocal(rs1("ORno").Value)
                rs1.MoveNext()
            Loop
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub saveL(ByVal Ltender As Double, ByVal Lchange As Double)
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs.Open("select * from tblIncomeReport where 1=0", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("ORno").Value = lblORno.Text
            rs("CardCode").Value = HexCardID
            rs("Plate").Value = lblPlate.Text
            rs("Operator").Value = TxtOp.Text
            rs("Station").Value = txtStation.Text
            rs("TimeIn").Value = lblTimeIn.Text
            rs("TimeOut").Value = lblTimeOut.Text
            rs("TotalTime").Value = lblTotalTime.Text
            rs("InOutTotal").Value = TotalTimeInt
            rs("Hourly").Value = lblAmountDue.Text
            rs("Overnigth").Value = lblOvernigth.Text
            rs("LostCard").Value = lblLostCard.Text
            rs("Discount").Value = lblDiscount.Text
            rs("Total").Value = lblTotal.Text
            rs("VAT").Value = lblVAT.Text
            rs("SubTotal").Value = lblSubTotal.Text
            rs("Tendered").Value = Ltender
            rs("Change").Value = Lchange
            rs("VehicleType").Value = lblVtype.Text
            rs("Discount").Value = lblDiscount.Text
            rs("PayType").Value = S_PayType
            rs("RefNum").Value = S_Refnumber
            rs("BussDate").Value = BussdateStr()
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub updateSlot()
        If conServer() = False Then Exit Sub
        Dim rs As New Recordset
        Try
            rs = New Recordset

            rs.Open("select * from ParkingSlot", conSqlPOS, 1, 2)
            rs("TOTAL").Value = Val(rs("TOTAL").Value) + 1
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update Parking Slot")
        End Try
    End Sub

    Sub delIn()
        If conServer() = False Then Exit Sub

        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from timeindb where CardCode='" & HexCardID & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Public Sub DelLocal(ByVal orNo As String)
        If conLocal() = False Then Exit Sub
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblincomereport where ORno = '" & orNo & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTender.KeyPress
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuest.Click
        TRtype = vbNullString
        TRtype = "Guest"

        txtSlot.Text = slot()

        If txtMODE.Text = vbNullString Then
            MsgBox("Please set POS!    ", vbExclamation, "Transaction")
            frmSetPOS.ShowDialog()
            Exit Sub
        End If
        If d8_conn() = True Then
            lblORno.Text = Ticket_OR_No()

            If d8_Card() = True Then
                If d8_LoadpassOL() = True Then
                    If d8_AuthenOL() = True Then
                        HexCardID = vbNullString
                        HexCardID = d8_ReadOL()
                        If getTimein(HexCardID) = False Then
                            If d8_Loadpass() = True Then
                                If d8_Authen() = True Then
                                    If readCard() = False Then
                                        'MsgBox("No record found!    ", vbExclamation, "Transaction")
                                        'Exit Sub
                                    End If
                                End If
                            End If
                        End If
                        InPic.Image = Get_PicIn(HexCardID)
                        DriverImage.Image = Get_PicDriver(HexCardID)
                        d8_Beep()
                        frmGuest.ShowDialog()

                    End If
                End If
            Else
                MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
            End If

            Exit Sub
        Else
            MsgBox("No device connected!    ", vbExclamation, "Transaction")
        End If

    End Sub

    Private Sub cmdMonthy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMonthy.Click
        TRtype = vbNullString
        TRtype = "Monthly"

        txtSlot.Text = slot()

        If txtMODE.Text = vbNullString Then
            MsgBox("Please set POS!    ", vbExclamation, "Transaction")
            frmSetPOS.ShowDialog()
            Exit Sub
        End If
        If d8_conn() = True Then
            lblORno.Text = Ticket_OR_No()

            If d8_Card() = True Then
                If d8_LoadpassOL() = True Then
                    If d8_AuthenOL() = True Then
                        HexCardID = vbNullString
                        HexCardID = d8_ReadOL()
                        If getTimein(HexCardID) = False Then
                            If d8_Loadpass() = True Then
                                If d8_Authen() = True Then
                                    If readCard() = False Then
                                        'MsgBox("No record found!    ", vbExclamation, "Transaction")
                                        'Exit Sub
                                    End If
                                End If
                            End If
                        End If
                        InPic.Image = Get_PicIn(HexCardID)
                        DriverImage.Image = Get_PicDriver(HexCardID)
                        d8_Beep()
                        frmMonthly.ShowDialog()

                    End If
                End If
            Else
                MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
            End If

            Exit Sub
        Else
            MsgBox("No device connected!    ", vbExclamation, "Transaction")
        End If

     
    End Sub

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTender.TextChanged

    End Sub

End Class
