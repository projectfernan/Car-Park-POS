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
        If e.Control = True And e.KeyCode = Keys.Enter Then
            If ToolTransact.Enabled = False Then
                Me.TopMost = False
                frmLogin.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F1 Then
                '  Call cmdBt_Click_1(sender, New System.EventArgs)
                frmManualTR.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F2 Then
                Call cmdLost_Click_1(sender, New System.EventArgs)
                'If txtDbStat.Text = "Connected" Then
                'If MsgBox("Reprint last transaction?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Reprint") = vbYes Then
                'reprint()
                'Prnt()
                'End If
                'Else
                'If dbstat2.Text = "Connected" Then
                'If MsgBox("Reprint last transaction?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Reprint") = vbYes Then
                'reprintL()
                'Prnt()
                'End If
                'End If
                'End If
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F3 Then
                frmManualLost.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F5 Then
                frmEditPlate.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F6 Then
                frmManualBar.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F7 Then

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
        camEntrance()
        viewPDcom()
        disable()
        verClose = "Lock"
        viewPOSset()

        'Station
        viwStation()
        'MySQL Connecting
        viewCon()

        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = True Then
                frmSetPOS.txtSlot.Text = viewSlot()
                txtTotalSlot.Text = viewSlot()
                txtSlot.Text = slot()
            Else
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = True Then
                    frmSetPOS.txtSlot.Text = viewSlot()
                    txtTotalSlot.Text = viewSlot()
                    txtSlot.Text = slot()
                End If
            End If
        End With

        If conLocal() = True Then
            dbstat2.Text = "Connected"
            dbstat2.ForeColor = Color.Lime

            If frmLogo.chk = False Then
                PicLogo.Image = Logo_Image()
            End If
        Else
            dbstat2.Text = "Disconnected"
            dbstat2.ForeColor = Color.Red
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
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    Return False
                End If
            End If
        End With

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from timeinDB where CardCode = '" & HexID & "' and Validate = 0;", conSqlPOS, 1, 2)
            If rs.EOF = False Then
                tmeIn = rs("TimeIn").Value
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

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

    Function ViewPlate(ByVal Code As String) As String
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    Return vbNullString
                End If
            End If
        End With

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
        txtSlot.Text = slot()
        If Not txtStatus.Text = My.Settings.LoopCode Then
            MsgBox("Transaction cannot be proceed, No vehicle detected!", vbExclamation, "Transaction")
            Exit Sub
        End If

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
                                            MsgBox("No record found!    ", vbExclamation, "Transaction")
                                            Me.Close()
                                            Exit Sub
                                        End If
                                    End If
                                End If
                            End If
                            InPic.Image = Get_PicDriver(HexCardID)
                            DriverImage.Image = Get_PicIn(HexCardID)
                            .txtPlate.Text = ViewPlate(HexCardID)
                            .ShowDialog()

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
        If Not txtStatus.Text = My.Settings.LoopCode Then
            MsgBox("Transaction cannot be proceed, No vehicle detected!", vbExclamation, "Lost Card Transaction")
            Exit Sub
        End If

        lblORno.Text = Ticket_OR_No()
        frmFindLostCard.ShowDialog()
    End Sub


    Private Sub cmdSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEditPlate.ShowDialog()
    End Sub

    Private Sub cmdLO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLO.Click
        If MsgBox("Are you sure do you want to logout?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Logout") = MsgBoxResult.Yes Then
            'PrntExt(TxtOp.Text, dtlogin(txtUsername.Text), Format(Now, "yyyy-MM-dd HH:mm:59"))
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

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManualLost.Click
        frmManualLost.ShowDialog()
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

    Function ValidateEntTicket() As Boolean
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    Return False
                End If
            End If
        End With

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("update timeindb set Validate = 1 where CardCode = '" & HexCardID & "'")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub txtTender_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTender.EnabledChanged
        txtTender.Focus()
    End Sub

    Sub delIn()
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    delIn()
                End If
            End If
        End With


        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from timeindb where CardCode='" & HexCardID & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub


    Private Sub txtTender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTender.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTender.Text = vbNullString Then
                MsgBox("Plese enter tender amount!    ", vbExclamation, "Tender amount")
                txtTender.Focus()
                Exit Sub
            End If

            Dim tenderAmout As Double = txtTender.Text
            Dim TotalAmount As Double = lblTotal.Text
            Dim ChangeAmout As Double = MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout))

            With frmConnDB

                If Get_tender(lblTotal.Text, txtTender.Text) = True Then

                    If Val(tenderAmout) >= 1000 Then
                   
                        PoleDisOpen()
                        clear()
                        displayChange1k(MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout)), MakeMoney(tenderAmout))
                        PoleDisClose()

                    ElseIf Val(tenderAmout) >= 100 Then

                        PoleDisOpen()
                        clear()
                        displayChange100(MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout)), MakeMoney(tenderAmout))
                        PoleDisClose()

                    Else
                  
                        PoleDisOpen()
                        clear()
                        displayChange(MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout)), MakeMoney(tenderAmout))
                        PoleDisClose()

                    End If

                    printORticket(tenderAmout)
                    Prnt()

                    If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = True Then
                        saveToServer(tenderAmout, ChangeAmout)
                        'ExtValidation(HexCardID)
                        If My.Settings.DataPool = False Then
                            PushToServer()
                        End If
                        Update_OR()
                        lblORno.Text = Ticket_OR_No()

                        If lblLostCard.Text <> "0.00" Then
                            delIn()
                        End If

                        txtSlot.Text = slot()
                        ValidateEntTicket()
                    Else
                        If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = True Then
                            saveToServer(tenderAmout, ChangeAmout)
                            'ExtValidation(HexCardID)
                            If My.Settings.DataPool = False Then
                                PushToServer()
                            End If
                            Update_OR()
                            lblORno.Text = Ticket_OR_No()

                            If lblLostCard.Text <> "0.00" Then
                                delIn()
                            End If

                            txtSlot.Text = slot()
                            ValidateEntTicket()
                        Else
                            If conLocal() = True Then
                                saveL(tenderAmout, ChangeAmout)
                                'ExtValidation(HexCardID)
                                Update_OR()
                                lblORno.Text = Ticket_OR_No()
                                ValidateEntTicket()
                            Else
                                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                                frmConnDB.ShowDialog()
                                Exit Sub
                            End If
                        End If
                    End If
                    'kansela()
                    FinishedTR()
                    triger()

                    txtAmtStat.Text = "CHANGE :"
                    lblTotal.Text = MakeMoney(ChangeAmout)

                Else
                    txtTender.Text = vbNullString
                    txtTender.Focus()
                End If
            End With
        End If

    End Sub

    Sub FinishedTR()
        ToolTransact.Enabled = False
        txtTender.Text = vbNullString
        txtTender.Enabled = False
        txtBarcode.Enabled = True
    End Sub

    Sub saveToServer(ByVal Ltender As Double, ByVal Lchange As Double)
        Dim rs As New Recordset

        Dim ViolateFlag As Integer

        If lblOvernigth.Text = "0.00" Then
            ViolateFlag = 0
        Else
            ViolateFlag = 1
        End If

        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("insert into incomereport(TRno,CardCode,Plate,Operator,PC,TimeIn,TimeOut,TotalTime,InOutTotal,Regular,Overnight,LostCard,DiscountAmount,Total,VAT,NonVat,VatExempt,Tender,`Change`,Type,Payment,DiscountReference,DiscParkerName,`Status`,BusnessDate)VALUES('" _
                    & lblORno.Text & _
              "','" & HexCardID & _
              "','" & lblPlate.Text & _
              "','" & TxtOp.Text & _
              "','" & txtStation.Text & _
              "','" & lblTimeIn.Text & _
              "','" & lblTimeOut.Text & _
              "','" & lblTotalTime.Text & _
              "','" & TotalTimeInt & _
              "','" & Val(lblAmountDue.Text) & _
              "','" & Val(lblOvernigth.Text) & _
              "','" & Val(lblLostCard.Text) & _
              "','" & Val(lblDiscount.Text) & _
              "','" & Val(lblTotal.Text) & _
              "','" & Val(lblVAT.Text) & _
              "','" & Val(lblSubTotal.Text) & _
              "','" & Val(txtVatExempt.Text) & _
              "','" & Ltender & _
              "','" & Lchange & _
              "','" & lblVtype.Text & _
              "','" & S_PayType & _
              "','" & S_Refnumber & _
              "','" & S_SeniorName & _
              "','" & ViolateFlag & _
              "','" & BussdateStr() & "')")
        Catch ex As Exception
            If conLocal() = True Then
                saveL(Ltender, Lchange)
            End If
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub save(ByVal Ltender As Double, ByVal Lchange As Double)
        Dim rs As New Recordset

        Try
            rs = New Recordset
            rs.Open("select * from incomereport where 1=0", conSqlPOS, 1, 2)
            rs.AddNew()
            rs("TRno").Value = lblORno.Text
            rs("CardCode").Value = HexCardID
            rs("Plate").Value = lblPlate.Text
            rs("Operator").Value = TxtOp.Text
            rs("PC").Value = txtStation.Text
            rs("TimeIn").Value = lblTimeIn.Text
            rs("TimeOut").Value = lblTimeOut.Text
            rs("TotalTime").Value = lblTotalTime.Text
            rs("InOutTotal").Value = TotalTimeInt
            rs("Regular").Value = lblAmountDue.Text
            rs("Overnigth").Value = lblOvernigth.Text
            rs("LostCard").Value = lblLostCard.Text
            rs("DiscountAmount").Value = lblDiscount.Text
            rs("Total").Value = lblTotal.Text
            rs("VAT").Value = lblVAT.Text
            rs("NonVat").Value = lblSubTotal.Text
            rs("Tender").Value = Ltender
            rs("Change").Value = Lchange
            rs("Type").Value = lblVtype.Text
            rs("Payment").Value = S_PayType
            rs("DiscountReference").Value = S_Refnumber
            rs("DiscParkerName").Value = S_SeniorName
            rs("BusnessDate").Value = BussdateStr()
            rs.Update()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub PushToServer()
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    Exit Sub
                End If
            End If
        End With

        If conLocal() = False Then Exit Sub
        Dim rs1 As New Recordset
        Dim rs As New Recordset
        Try

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblincomereport")
            Do While rs1.EOF = False
                rs = New Recordset
                rs.Open("select * from incomereport where 1=0", conSqlPOS, 1, 2)
                rs.AddNew()
                rs("TRno").Value = rs1("ORno").Value
                rs("CardCode").Value = rs1("CardCode").Value
                rs("Plate").Value = rs1("Plate").Value
                rs("Operator").Value = rs1("Operator").Value
                rs("PC").Value = rs1("Station").Value
                rs("TimeIn").Value = rs1("TimeIn").Value
                rs("TimeOut").Value = rs1("TimeOut").Value
                rs("TotalTime").Value = rs1("TotalTime").Value
                rs("InOutTotal").Value = rs1("InOutTotal").Value
                rs("Regular").Value = rs1("Hourly").Value
                rs("Overnight").Value = rs1("Overnigth").Value
                rs("LostCard").Value = rs1("LostCard").Value
                rs("DiscountAmount").Value = rs1("Discount").Value
                rs("Total").Value = rs1("Total").Value
                rs("VAT").Value = rs1("VAT").Value
                rs("NonVat").Value = rs1("SubTotal").Value
                rs("VatExempt").Value = rs1("VatExempt").Value
                rs("Tender").Value = rs1("Tendered").Value
                rs("Change").Value = rs1("Change").Value
                rs("Type").Value = rs1("VehicleType").Value
                rs("Payment").Value = rs1("PayType").Value
                rs("DiscountReference").Value = rs1("RefNum").Value
                rs("DiscParkerName").Value = rs1("DiscParkerName").Value
                rs("Status").Value = rs1("Status").Value
                rs("BusnessDate").Value = rs1("BussDate").Value
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
        Dim ViolateFlag As Integer

        If lblOvernigth.Text = "0.00" Then
            ViolateFlag = 0
        Else
            ViolateFlag = 1
        End If

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
            rs("VatExempt").Value = txtVatExempt.Text
            rs("Tendered").Value = Ltender
            rs("Change").Value = Lchange
            rs("VehicleType").Value = lblVtype.Text
            rs("Discount").Value = lblDiscount.Text
            rs("PayType").Value = S_PayType
            rs("RefNum").Value = S_Refnumber
            rs("DiscParkerName").Value = S_SeniorName
            rs("Status").Value = ViolateFlag
            rs("BussDate").Value = BussdateStr()
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub ExtValidation(ByVal cCode As String)
        'If conServer() = False Then Exit Sub

        'Try
        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlPOS.Execute("select * from timeindb where CardCode = '" & cCode & "'")
        If rs.EOF = False Then
            Dim strOrasOut As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            Dim rs2 As New Recordset
            rs2 = New Recordset
            rs2 = conSqlPOS.Execute("insert into tblexitpass(CardCode,Vehicle,Plate,TimeIn,Timeout,Operator,PC,Status,Mode)VALUES('" & _
                                    rs("CardCode").Value & _
                                    "','" & lblVtype.Text & _
                                    "','" & lblPlate.Text & _
                                    "','" & rs("TimeIn").Value & _
                                    "','" & strOrasOut & _
                                    "','" & TxtOp.Text & _
                                    "','" & txtStation.Text & _
                                    "',1,'Online')")
        End If
        'Catch ex As Exception

        'End Try
    End Sub

    Public Sub DelLocal(ByVal orNo As String)
        If conLocal() = False Then Exit Sub
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from incomereport where TRno = '" & orNo & "'")
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

    Private Sub TmrRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrRead.Tick
        txtBarcode.Focus()
    End Sub

    Function chkTimeIN(ByVal bcode As String) As Boolean
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    Return False
                End If
            End If
        End With

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("select CardCode from timeindb where CardCode = '" & bcode & "' and Validate = 1 limit 1;")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getLastTRtime(ByVal brcode As String) As Date
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    Return Now
                End If
            End If
        End With

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select TimeOut from incomereport where CardCode = '" & brcode & "' order by TimeOut limit 1;")
            If rs.EOF = False Then
                Return rs("TimeOut").Value
            Else
                Return Now
            End If
        Catch ex As Exception
            Return Now
        End Try

    End Function

    Function getExeeDinfo(ByVal brcode As String) As Boolean
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    Return False
                End If
            End If
        End With

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Plate,Type from incomereport where CardCode = '" & brcode & "' order by TimeOut limit 1;")
            If rs.EOF = False Then
                lblPlate.Text = rs("Plate").Value
                lblVtype.Text = rs("Type").Value
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    Sub viewAmt(ByVal plate As String, ByVal vtyp As String)
        Dim OVamt As Double = GETovernyt(EntryTime, Now, vtyp)
        Dim intAmt As Double = Get_IntervalAmt(vtyp, EntryTime, Now) + OVamt
        Dim vatAmt As Double = VAT(intAmt)

        lblAmountDue.Text = MakeMoney(intAmt)  'intAmount(getMinMinutes, totalTime)
        lblOvernigth.Text = MakeMoney(OVamt)
        lblVtype.Text = "EXCEED"
        lblPlate.Text = UCase(plate)
        lblTimeIn.Text = Format(CDate(EntryTime), "yyyy-MM-dd HH:mm:00")
        lblTimeOut.Text = Format(Now, "yyyy-MM-dd HH:mm:59")
        lblTotalTime.Text = TotalTime_FUNCTION(CDate(EntryTime), Now)
        lblTotal.Text = MakeMoney(intAmt)
        P_TotalAmt = MakeMoney(intAmt)
        lblVAT.Text = VAT(intAmt)
        lblSubTotal.Text = subTotal(intAmt, vatAmt)
        txtVatExempt.Text = "0.00"
        ToolTransact.Enabled = True

        PoleDisOpen()
        clear()
        displayTotal(MakeMoney(P_TotalAmt))
        PoleDisClose()

        trOpt = True
        TrLostOpt = True


        txtTender.Enabled = True
        txtAmtStat.Text = "TOTAL AMOUNT :"
        txtBarcode.Text = vbNullString
        txtBarcode.Enabled = False


    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If verClose = "Lock" Then
            txtBarcode.Text = vbNullString
        Else
            If e.KeyCode = Keys.Enter Then
                Try
                    txtVatExempt.Text = "0.00"
                    HexCardID = vbNullString
                    HexCardID = txtBarcode.Text

                    If txtBarcode.Text = vbNullString Then Exit Sub

                    If chkTimeIN(txtBarcode.Text) = True Then
                        Try
                            Dim yr As String = Trim(Mid(HexCardID, 1, 4))
                            Dim mm As String = Trim(Mid(HexCardID, 5, 2))
                            Dim arw As String = Trim(Mid(HexCardID, 7, 2))

                            Dim H As String = Trim(Mid(HexCardID, 9, 2))
                            Dim Mn As String = Trim(Mid(HexCardID, 11, 2))

                            tmeIn = yr & "-" & mm & "-" & arw & " " & H & ":" & Mn & ":00"

                            EntryTime = vbNullString
                            EntryTime = Format(getLastTRtime(txtBarcode.Text), "yyyy-MM-dd HH:mm:ss")

                        Catch ex As Exception
                            txtBarcode.Text = vbNullString
                            Exit Sub
                        End Try
                        If MsgBox("Exeed grace period?", vbQuestion + vbYesNo, "Transact") = vbYes Then
                            S_PayType = "Regular"
                            S_Refnumber = "No Ref Number"
                            S_SeniorName = "Not Senior"

                            If getExeeDinfo(txtBarcode.Text) = True Then
                                viewAmt(lblPlate.Text, lblVtype.Text)
                            End If
                            '  frmExeedGrace.ShowDialog()
                            Exit Sub
                        Else
                            txtBarcode.Text = vbNullString
                            Exit Sub
                        End If
                    End If

                    If getTimein(HexCardID) = False Then

                        Try
                            '  Dim yr As String = Trim(Mid(HexCardID, 1, 4))
                            '  Dim mm As String = Trim(Mid(HexCardID, 5, 2))
                            '  Dim arw As String = Trim(Mid(HexCardID, 7, 2))

                            ' Dim H As String = Trim(Mid(HexCardID, 9, 2))
                            ' Dim Mn As String = Trim(Mid(HexCardID, 11, 2))

                            ' tmeIn = yr & "-" & mm & "-" & arw & " " & H & ":" & Mn & ":00"

                            ' EntryTime = vbNullString
                            ' EntryTime = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")

                            MsgBox("No record found! ", vbExclamation, "Barcode")
                            txtBarcode.Text = vbNullString
                            Exit Sub
                        Catch ex As Exception
                            txtBarcode.Text = vbNullString
                            Exit Sub
                        End Try
                    End If


                    InPic.Image = Get_PicDriver(HexCardID)
                    DriverImage.Image = Get_PicIn(HexCardID)

                    With frmTransact
                        .txtPlate.Text = ViewPlate(HexCardID)
                        .ShowDialog()
                    End With

                Catch ex As Exception
                    txtBarcode.Text = vbNullString
                End Try

                txtBarcode.Text = vbNullString
            End If
        End If

    End Sub

    Private Sub cmdLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManualBar.Click
        frmManualBar.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditPlate.Click
        frmEditPlate.ShowDialog()
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTender.TextChanged

    End Sub
End Class
