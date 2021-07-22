Imports ADODB
Imports System.Drawing.Printing
Imports System.Threading

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Public Delegate Sub PrintCashierOut()
    Dim xLOcashier As String = vbNullString

    Public Card As String
    Public Vtyp As String
    Public Plate As String
    Public InTime As String

    Dim ret_ent As New TimeIn_Logs

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If verClose = "Quit" Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'If trOpt = True And TrLostOpt = True Then
        '    If e.KeyCode = Keys.Enter Then

        '    End If
        'End If

        'If trOpt = True And TrLostOpt = True Then
        '    If e.KeyCode = Keys.D1 Then
        '        'frmAddDiscount.ShowDialog()
        '    End If
        'End If

        'If trOpt = True And TrLostOpt = True Then
        '    If e.KeyCode = Keys.D2 Then
        '        ' Call cmdCancel_Click_1(sender, New System.EventArgs)
        '    End If
        'End If

        If Access = "Login" Then
            If e.Control = True And e.KeyCode = Keys.Enter Then
                Me.TopMost = False
                Dim lg As New frmLogin
                lg.ShowDialog()
            End If
        Else
            If e.Control = True And e.KeyCode = Keys.Enter Then
                Me.TopMost = False
                Dim lg As New frmLogin
                lg.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then
        Else
            If btnEntryVeh.Visible = True Then
                If e.Control = True And e.KeyCode = Keys.E Then
                    Call btnEntryVeh_Click(sender, New System.EventArgs)
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
                Call cmdRR_Click_1(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F3 Then
                Call cmdLost_Click_1(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F4 Then
                Call ToolStripButton1_Click_1(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F5 Then
                Call cmdEditPlate_Click(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F6 Then
                If TxtOp.Text = "fernan" Then
                    Call cmdManualTR_Click(sender, New System.EventArgs)
                End If
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
                Dim sys As New frmSystem
                sys.ShowDialog()
            End If
        End If

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.I Then
            If TxtOp.Text = "fernan" Then
                desig = "Admin"
                Dim f As New InternalSet
                f.ShowDialog()
            End If
        End If

        If e.Control = True And e.Alt = True And e.KeyCode = Keys.M Then
            If TxtOp.Text = "fernan" Then
                desig = "Admin"
                Dim f As New frmManualTR
                f.ShowDialog()
            End If
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If ConnFLogs() = False Then
            MessageBox.Show("System Error! Please contact your software vendor!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Process.GetCurrentProcess.Kill()
            Application.Exit()
        End If

        If My.Settings.Operation = "SINGLE" Then
            btnEntryVeh.Visible = False
        Else
            btnEntryVeh.Visible = True
        End If

        If My.Settings.POS_VER = "GOVERNMENT BASED" Then
            HideBIRTags()
        End If

        lblORno.Text = Ticket_OR_No()
        trOpt = False
        TrLostOpt = False
        frmBussDate.viewBdate()

        PRINTER_NAME = My.Settings.PrinterDriver

        'RealPlayCamera
        camExit()

        disable()
        verClose = "Lock"
        viewPOSset()

        'Station
        viwStation()

        'If PingMe(frmConnDB.txtIp1.Text) = True Then
        If conServer() = True Then
            txtDbStat.Text = "Connected"
            txtDbStat.ForeColor = Color.Green
            txtTotalSlot.Text = viewSlot().ToString
            txtSlot.Text = slot().ToString
            'tmeSlot.Enabled = True
        Else
            txtDbStat.Text = "Disconnected"
            txtDbStat.ForeColor = Color.Red
        End If
        'End If

        If conLocal() = True Then
            dbstat2.Text = "Connected"
            dbstat2.ForeColor = Color.Green

            If frmLogo.chk = False Then
                'PicLogo.Image = Logo_Image()
            End If
        Else
            dbstat2.Text = "Disconnected"
            dbstat2.ForeColor = Color.Red
        End If

        PD_Offline()

        SysActivation()

        If My.Settings.DesktopLock = True Then
            disabledTaskMan()
            disableExplorer()
        End If
    End Sub

    Sub HideBIRTags()
        labelVatSale.Visible = False
        labelVat.Visible = False
        labelVatEx.Visible = False
        labelZeroRate.Visible = False

        lblSubTotal.Visible = False
        lblVAT.Visible = False
        lblVatExempt.Visible = False
        lblZeroRated.Visible = False
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
            Save_ErrLogs("[FlatDayCheck] MainForm", ex.Message)
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
            Save_ErrLogs("[FlatHolidayCheck] MainForm", ex.Message)
            Return False
        End Try
    End Function

    Sub CheckCutOff()

        Dim addBussDate As Date = My.Settings.BussDate
        Dim NewAddBussDate As Date = addBussDate.AddDays(1)
        Dim NowDate As String = Format(Now, "yyyy-MM-dd") 'NewBussDate.AddDays(1)
        Dim OldBussDate As String = Format(My.Settings.BussDate, "yyyy-MM-dd")

        If NowDate > OldBussDate Then

            Dim NowTime As Date = Format(Now, "HH:mm:ss")
            Dim Fcut As Date = Format(My.Settings.SaleCutt, "HH:mm:ss")

            If NowTime > Fcut Then
                My.Settings.BussDate = NowDate
                My.Settings.Save()
                txtBussDate.Text = NowDate
            End If

        End If
    End Sub

    Function BussdateStr() As String
        Try
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
            Else
                Return Format(Now, "yyyy-MM-dd")
            End If
        Catch ex As Exception
            Return Format(Now, "yyyy-MM-dd")
        End Try
    End Function

    Private Sub tmeTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeTime.Tick
        txtTime.Text = Format(Now, "Long Date")
        txtTimer.Text = Format(Now, "HH:mm:ss tt")
        'lblInOut.Text = Format(Now, "General Date")
        txtStatus.Text = Output(frmBarrier.txtStatAdd.Text)

        If My.Settings.BussAuto = False Then
            CheckCutOff()
        End If

        If errMsg <> vbNullString Then
            txtSysMsg.Text = errMsg
        Else
            txtSysMsg.Text = "---"
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

    Private Sub frmMain_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        'Me.Focus()
        'Me.KeyPreview = True
    End Sub

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddDiscount.ShowDialog()
    End Sub

    Function getTimein(ByVal HexID As String) As Boolean
        Try
            If conServer() = True Then
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSqlPOS.Execute("select TimeIn from timeindb where CardCode = '" & HexID & "'limit 1;")
                If rs.EOF = False Then
                    tmeIn = rs("TimeIn").Value
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("[getTimein] MainForm", ex.Message)
        End Try
    End Function

    Function ViewPlate(ByVal Code As String) As String
        If conServer() = False Then Return vbNullString

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select Plate from timeindb where CardCode = '" & Code & "' limit 1;")
            If rs.EOF = False Then
                Return rs("Plate").Value
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Save_ErrLogs("[ViewPlate] MainForm", ex.Message)
            Return vbNullString
        End Try

    End Function

    Function checkORexist(ByVal transNo As String) As Boolean

        If conServer() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("select ORno from vweorfromto where ORno = '" & transNo & "' limit 1;")

            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Save_ErrLogs("[checkORexist] MainForm", ex.Message)
            Return False
        End Try
    End Function

    Function chkCardIncome(ByVal Cod As String, ByVal OrasIn As Date) As Boolean

        If conServer() = False Then Return False

        Try
            Dim strIn As String = Format(OrasIn, "yyyy-MM-dd HH:mm:ss")
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("SELECT CardCode,Timein FROM tblincomereport where CardCode = '" & Cod & "' and TimeIn = '" & strIn & "' limit 1;")
            If rs.EOF = False Then
                delInClear(Cod)
                ' MsgBox("Income eof is false")
                Return False
            Else
                ' MsgBox("income EOF is true")
                Return True
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message & " chkCardIncome")
            Return False
        End Try

    End Function

    Public Function CardIsIn(ByVal card As String) As Boolean
        If conServer() = False Then Return False
        Try
            Dim rs As New Recordset
            rs = conSqlPOS.Execute("SELECT CardCode,Timein FROM timeindb WHERE CardCode='" & card & "' limit 1;")
            If rs.EOF = False Then
                Dim FF As Boolean = chkCardIncome(card, rs("Timein").Value)

                'MsgBox("TIMEINDB EOF = false")
                Return FF
            Else
                'MsgBox("TIMEINDB EOF = true")
                Return False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message & " [CardIsIn]")
            Return False
        End Try

    End Function


    Private Sub cmdBt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBt.Click
        Try
            txtSlot.Text = slot().ToString

            If txtMODE.Text = vbNullString Then
                MsgBox("Please set POS!    ", vbExclamation, "Transaction")
                frmSetPOS.ShowDialog()
                Exit Sub
            End If

            If d8_conn() = True Then
                d8_Beep()

                lblORno.Text = Ticket_OR_No()
                With frmTransact
                    .txtPlate.Text = vbNullString
                    If d8_Card() = True Then
                        If d8_LoadpassOL() = True Then
                            If d8_AuthenOL() = True Then
                                HexCardID = vbNullString
                                HexCardID = d8_ReadOL()

                                If d8_Loadpass() = True Then
                                    If d8_Authen() = True Then
                                        ret_ent = TimeInInfo(HexCardID)
                                        If readCard() = False Then
                                            If My.Settings.CardDataBckup = False Then
                                                MsgBox("No record found!    ", vbExclamation, "Transaction")
                                                Exit Sub
                                            End If

                                            If ret_ent.LogStat = False Then
                                                MsgBox("No record found!    ", vbExclamation, "Transaction")
                                                Exit Sub
                                            End If

                                            EntryTime = ret_ent.LogTime
                                            InPic.Image = ret_ent.CarImg
                                            DriverImage.Image = ret_ent.DriverImg
                                            .txtPlate.Text = ret_ent.Plate
                                            .ShowDialog()
                                        Else
                                            'If getTimein(HexCardID) = True Then
                                            'End If    '  If chkCardIncome(HexCardID, tmeIn) = True Then
                                            InPic.Image = ret_ent.CarImg 'Get_PicIn(HexCardID)
                                            DriverImage.Image = ret_ent.DriverImg 'Get_PicDriver(HexCardID)
                                            .txtPlate.Text = ret_ent.Plate 'ViewPlate(HexCardID)
                                            .ShowDialog()
                                            'Else
                                            'MsgBox("No record found!    ", vbExclamation, "Transaction")
                                            'Exit Sub
                                            'End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Else
                        MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
                    End If
                End With
                Exit Sub
            Else
                If ReadER302() = True Then
                    Exit Sub
                End If

                MsgBox("No device connected!    ", vbExclamation, "Transaction")
            End If
        Catch ex As Exception
            Save_ErrLogs("[cmdBt_Click_1] MainForm", ex.Message)
        End Try
    End Sub

    Function ReadER302() As Boolean
        'Connect to port
reDo:   If ER302_Conn(My.Settings.Er302Com) = False Then Return False

        'Create request
        If ER302_Request() = False Then
            MsgBox("Please place your card to reader!", vbExclamation, "Register Entry Vehicle")
            'CardStat = "NoCard"
            Return True
        End If

        'Anticoll
        Dim snr As String = ER302_AntiColl()
        If snr = "" Then Return False

        'Card Select
proc:   If ER302_CardSelect() = False Then Return False

        ret_ent = TimeInInfo(snr)

        'Return Card DateTime
        Dim dT As String = ER302_ReadCard(12)
        If dT = "" Then
            If My.Settings.CardDataBckup = False Then
                ER302_Beep()

                MsgBox("No record found!    ", vbExclamation, "Transaction")
                Return True
            End If

            EntryTime = ret_ent.LogTime
            InPic.Image = ret_ent.CarImg
            DriverImage.Image = ret_ent.DriverImg
        Else
            If IsDate(dT) = False Then
                ER302_Beep()

                MsgBox("No record found!    ", vbExclamation, "Transaction")
                Return True
            End If

            EntryTime = dT
            InPic.Image = ret_ent.CarImg
            DriverImage.Image = ret_ent.DriverImg
        End If

        ER302_Beep()

        With frmTransact
            .txtPlate.Text = ret_ent.Plate 'ViewPlate(HexCardID)
            .ShowDialog()
        End With

        Return True
    End Function

    Private Sub cmdLost_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLost.Click
        txtSlot.Text = slot()
        'If Not txtStatus.Text = My.Settings.LoopCode Then
        '    MsgBox("Transaction cannot be proceed, No vehicle detected!", vbExclamation, "Lost Card Transaction")
        '    Exit Sub
        'End If

        'lblORno.Text = Ticket_OR_No()
        frmFindLostCard.ShowDialog()
    End Sub

    Private Sub cmdRR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRR.Click
        If MsgBox("Reprint last transaction?    ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
            PrintReceiptRaw_Now()
        End If
    End Sub

    Private Sub cmdLO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLO.Click
        If MsgBox("Are you sure do you want to logout?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Logout") = MsgBoxResult.Yes Then
            'PrntExt(TxtOp.Text, dtlogin(txtUsername.Text), Format(Now, "yyyy-MM-dd HH:mm:59"))

            If My.Settings.KickCashDrawer = True Then
                OpenCashdrawer(My.Settings.PrinterDriver)
            End If

            If My.Settings.LOPrint = True Then
                xLOcashier = TxtOp.Text

                Dim th As New Thread(New ThreadStart(AddressOf CommandPrintCashierOut))
                th.Start()
            End If

            dellogTime(txtUsername.Text)
            Access = "Logout"
            verClose = "Lock"
            txtPosi.Text = "System :"
            TxtOp.Text = "Locked"
            txtUsername.Text = vbNullString
            kansela()
            disable()

            PD_Offline()
        End If
    End Sub

    Sub CommandPrintCashierOut()
        If (InvokeRequired) Then
            Invoke(New PrintCashierOut(AddressOf CommandPrintCashierOut))
        Else
            'Cursor.Current = Cursors.WaitCursor
            Dim dtBuss As Date = CDate(txtBussDate.Text)

            printCAshierRaw(xLOcashier, dtBuss)
            'Cursor.Current = Cursors.Arrow
        End If
    End Sub

    'Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    '    Me.TopMost = True
    '    If My.Settings.DesktopLock = True Then
    '        disableExplorer()

    '    End If
    'End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManualLost.Click
        Dim f As New frmManualLost
        f.ShowDialog()
    End Sub

    Private Sub cmdManualTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdManualTR.Click
        Dim f As New frmManualTR
        f.ShowDialog()
    End Sub

    Private Sub cmdDiscount_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        Dim f As New frmAddDiscount
        f.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        If MsgBox("Are you sure do you want to cancel this transaction?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Cancel") = vbYes Then
            PD_Welcome()
            kansela()
        End If
    End Sub

    Private Sub txtTender_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTender.EnabledChanged
        txtTender.Focus()
    End Sub

    Private Sub txtTender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTender.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtTender.Text = vbNullString Then
                MsgBox("Plese enter tender amount!    ", vbExclamation, "Tendered amount")
                txtTender.Focus()
                Exit Sub
            End If

            If d8_Card() = False Then
                If ER302_Conn(My.Settings.Er302Com) = True Then
                    If ER302_Request() = False Then
                        MsgBox("Please place the card to reader!     ", vbExclamation, "Transaction")
                        txtTender.Text = vbNullString
                        txtTender.Focus()
                        Exit Sub
                    Else
                        HexCardID = ER302_AntiColl()
                    End If
                End If
            End If

            Dim tenderAmout As Double = CDbl(txtTender.Text)
            Dim TotalAmount As Double = CDbl(lblTotal.Text)
            Dim ChangeAmout As Double = MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout))

            If Get_tender(lblTotal.Text, txtTender.Text) = False Then
                txtTender.Text = vbNullString
                txtTender.Focus()
            Else
                If conServer() = False Then
                    If conLocal() = False Then
                        MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                        frmConnDB.ShowDialog()
                        Exit Sub
                    Else
reloc:                  If saveL(tenderAmout, ChangeAmout) = False Then
                            If MessageBox.Show("Failed to save to local! Please try again!", "Local", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Retry Then
                                GoTo reloc
                            End If
                            txtTender.Text = vbNullString
                            txtTender.Focus()
                            Exit Sub
                        End If
                    End If
                Else
resave:             If saveToServer(tenderAmout, ChangeAmout) = False Then
                        If conLocal() = True Then
                            If saveL(tenderAmout, ChangeAmout) = False Then
                                If MessageBox.Show("Failed to save to server! Please try again!", "Server", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Retry Then
                                    GoTo resave
                                End If
                                txtTender.Text = vbNullString
                                txtTender.Focus()
                            End If
                        End If
                    Else
                        If My.Settings.DataPool = False Then
                            If conServer() = True Then
                                If conLocal() = True Then
                                    If bgwServerPush.IsBusy = False Then
                                        bgwServerPush.RunWorkerAsync()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

                PD_Display_Change(MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout)), MakeMoney(tenderAmout))

                OpenCashdrawer(My.Settings.PrinterDriver)

                printORticket(tenderAmout)
                If S_PayType = "GracePeriod" And My.Settings.GPprint = True Then
                Else
                    'Prnt()
                    PrintReceiptRaw_Now()
                End If

                Update_OR()
                lblORno.Text = Ticket_OR_No()
                txtSlot.Text = slot().ToString

                txtAmtStat.Text = "CHANGE :"
                lblTotal.Text = MakeMoney(ChangeAmout)

                'kansela()
                FinishedTR()
re:             If OpenBarrierExt() = False Then
                    MessageBox.Show("Failed to open the barrier!", "Open Barrier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If MessageBox.Show("Retry to open barrier?", "Open Barrier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                        If OpenBarrierExt() = False Then GoTo re
                    End If
                End If

                If d8_Card() = False Then
                    ER302ResetCard()
                Else
                    D8_Data_Reset()
                End If
            End If
        End If
    End Sub

    Sub D8_Data_Reset()

        If D8_LoadKey(3) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        If D8_Authenticate(3) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        If D8_ResetCard(12) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        If D8_ResetCard(13) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        If D8_ResetCard(14) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        If D8_WriteCard(12, lblVtype.Text) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        If D8_WriteDate(13) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        If D8_WriteCard(14, lblPlate.Text) = False Then
            MsgBox("Failed to reset card data!")
            Exit Sub
        End If

        d8_Beep()
        d8_halt()

    End Sub

    Function ER302ResetCard() As Boolean
        'Connect to port
reDo:   If ER302_Conn(My.Settings.Er302Com) = False Then Return False

        'Create request
        If ER302_Request() = False Then
            MsgBox("Please place your card to reader!", vbExclamation, "Reset Data")
            Return True
        End If

        'Anticoll
        Dim snr As String = ER302_AntiColl()
        If snr = "" Then Return False

        If delIn(snr) = False Then

        End If

        'Card Select
        If ER302_CardSelect() = False Then Return False

        'write Date Time ========================
        Dim T As String = Format(Now, "yyyy-MM-dd HH:mm")
        Dim dtHex As String = StringToHex(T)
        If ER302_WriteCard(dtHex, 13) = False Then
            MsgBox("Failed to reset card data!", vbExclamation, "Reset Data")
            If MessageBox.Show("Retry to reset card?", "Reset Data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo reDo
            End If

            Return False
        End If

        'Write Vehicle =========================
        Dim lup As Integer
        Dim St As String = lblVtype.Text
        Dim stLen As Integer = Len(St)

        If Len(St) <> 16 Then
            For lup = stLen To 16
                St = St & " "
                lup = Len(St)
            Next
        End If

        Dim StHex As String = StringToHex(St)
        If ER302_WriteCard(StHex, 12) = False Then
            MsgBox("Failed to reset card data!", vbExclamation, "Reset Data")
            If MessageBox.Show("Retry to reset card?", "Reset Data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo reDo
            End If

            Return False
        End If

        'Write Plate Number=====================
        Dim i As Integer
        Dim Plate As String = lblPlate.Text
        Dim pLen As Integer = Len(Plate)

        If Len(Plate) <> 16 Then
            For i = pLen To 16
                Plate = Plate & " "
                i = Len(Plate)
            Next
        End If

        Dim PlateHex As String = StringToHex(Plate)
        If ER302_WriteCard(PlateHex, 14) = False Then
            MsgBox("Failed to reset card data!", vbExclamation, "Reset Data")
            If MessageBox.Show("Retry to reset card?", "Reset Data", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo reDo
            End If

            Return False
        End If

        ER302_Halt()
        ER302_Beep()
        Return True
    End Function

    Sub FinishedTR()
        'ToolTransact.Enabled = False
        cmdDiscount.Enabled = False
        cmdCancel.Enabled = False

        txtTender.Text = vbNullString
        txtTender.Enabled = False
    End Sub

    Function saveToServer(ByVal Ltender As Double, ByVal Lchange As Double) As Boolean
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,InOutTotal,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,VatExempt,ZeroRated,Tendered,`Change`,VehicleType,PayType,CouponName,SeniorName,RefNum,BussDate)VALUES('" _
                    & lblORno.Text & _
              "','" & HexCardID & _
              "','" & lblPlate.Text & _
              "','" & TxtOp.Text & _
              "','" & txtStation.Text & _
              "','" & lblTimeIn.Text & _
              "','" & lblTimeOut.Text & _
              "','" & lblTotalTime.Text & _
              "','" & TotalTimeInt & _
              "','" & CDbl(lblAmountDue.Text) & _
              "','" & CDbl(lblOvernigth.Text) & _
              "','" & CDbl(lblLostCard.Text) & _
              "','" & CDbl(lblDiscount.Text) & _
              "','" & CDbl(lblTotal.Text) & _
              "','" & CDbl(lblVAT.Text) & _
              "','" & CDbl(lblSubTotal.Text) & _
              "','" & CDbl(lblVatExempt.Text) & _
              "','" & CDbl(lblZeroRated.Text) & _
              "','" & Ltender & _
              "','" & Lchange & _
              "','" & lblVtype.Text & _
              "','" & S_PayType & _
              "','" & S_CouponName & _
              "','" & S_SeniorName & _
              "','" & S_Refnumber & _
              "','" & BussdateStr() & "')")

            Return True
        Catch ex As Exception
            Save_ErrLogs("[saveToServer] MainForm", ex.Message)
            'MsgBox(ex.Message, vbCritical)
            Return False
        End Try
    End Function

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
            rs("PayType").Value = S_PayType
            rs("RefNum").Value = S_Refnumber
            rs("BussDate").Value = BussdateStr()
            rs.Update()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub PushToServer()
        
        Dim rs1 As New Recordset
        Dim rs As New Recordset

        Try
            'Me.Cursor = Cursors.WaitCursor
            rs1 = New Recordset

            rs1 = conSqlLoc.Execute("select * from tblincomereport")
            Do While rs1.EOF = False
                Dim INoutTotal As Long = rs1("InOutTotal").Value
                Dim tendered As Double = rs1("Tendered").Value
                Dim changes As Double = rs1("Change").Value
                Dim LocTimeIn As String = Format(CDate(rs1("TimeIn").Value), "yyyy-MM-dd HH:mm:ss")
                Dim LocTimeOut As String = Format(CDate(rs1("TimeIn").Value), "yyyy-MM-dd HH:mm:ss")
                Dim LocBussDate As String = Format(CDate(rs1("BussDate").Value), "yyyy-MM-dd HH:mm:ss")

                rs = New Recordset
                rs = conSqlPOS.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,InOutTotal,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,VatExempt,ZeroRated,Tendered,`Change`,VehicleType,PayType,CouponName,SeniorName,RefNum,BussDate)VALUES('" _
                     & rs1("ORno").Value & _
               "','" & rs1("CardCode").Value & _
               "','" & rs1("Plate").Value & _
               "','" & rs1("Operator").Value & _
               "','" & rs1("Station").Value & _
               "','" & LocTimeIn & _
               "','" & LocTimeOut & _
               "','" & rs1("TotalTime").Value & _
               "','" & INoutTotal & _
               "','" & CDbl(rs1("Hourly").Value) & _
               "','" & CDbl(rs1("Overnigth").Value) & _
               "','" & CDbl(rs1("LostCard").Value) & _
               "','" & CDbl(rs1("Discount").Value) & _
               "','" & CDbl(rs1("Total").Value) & _
               "','" & CDbl(rs1("VAT").Value) & _
               "','" & CDbl(rs1("SubTotal").Value) & _
               "','" & CDbl(rs1("VatExempt").Value) & _
               "','" & CDbl(rs1("ZeroRated").Value) & _
               "','" & tendered & _
               "','" & changes & _
               "','" & rs1("VehicleType").Value & _
               "','" & rs1("PayType").Value & _
               "','" & rs1("CouponName").Value & _
               "','" & rs1("SeniorName").Value & _
               "','" & rs1("RefNum").Value & _
               "','" & LocBussDate & "')")

                PushdelIn(rs1("CardCode").Value)
                DelLocal(rs1("ORno").Value)

                rs1.MoveNext()
            Loop

            'Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            'Me.Cursor = Cursors.Arrow
            Save_ErrLogs("[PushToServer] MainForm", ex.Message)
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Function saveL(ByVal Ltender As Double, ByVal Lchange As Double) As Boolean
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,InOutTotal,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,VatExempt,ZeroRated,Tendered,`Change`,VehicleType,PayType,CouponName,SeniorName,RefNum,BussDate)VALUES('" _
                         & lblORno.Text & _
                   "','" & HexCardID & _
                   "','" & lblPlate.Text & _
                   "','" & TxtOp.Text & _
                   "','" & txtStation.Text & _
                   "','" & lblTimeIn.Text & _
                   "','" & lblTimeOut.Text & _
                   "','" & lblTotalTime.Text & _
                   "','" & TotalTimeInt & _
                   "','" & CDbl(lblAmountDue.Text) & _
                   "','" & CDbl(lblOvernigth.Text) & _
                   "','" & CDbl(lblLostCard.Text) & _
                   "','" & CDbl(lblDiscount.Text) & _
                   "','" & CDbl(lblTotal.Text) & _
                   "','" & CDbl(lblVAT.Text) & _
                   "','" & CDbl(lblSubTotal.Text) & _
                   "','" & CDbl(lblVatExempt.Text) & _
                   "','" & CDbl(lblZeroRated.Text) & _
                   "','" & Ltender & _
                   "','" & Lchange & _
                   "','" & lblVtype.Text & _
                   "','" & S_PayType & _
                   "','" & S_CouponName & _
                   "','" & S_SeniorName & _
                   "','" & S_Refnumber & _
                   "','" & BussdateStr() & "')")
            Return True
        Catch ex As Exception
            Save_ErrLogs("[saveL] MainForm", ex.Message)
            Return False
        End Try
    End Function

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

    Sub PushdelIn(ByVal ccode As String)

        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from timeindb where CardCode='" & ccode & "'")
        Catch ex As Exception
            PushdelIn(ccode)
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Function delIn(ByVal Code As String) As Boolean
        If conServer() = False Then
            errMsg = "TimeIn Log: Can't delete card data to server due of conection problem."
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from timeindb where CardCode='" & Code & "'")
            errMsg = vbNullString
            Return True
        Catch ex As Exception
            errMsg = "TimeIn Log: " & ex.Message
            Save_ErrLogs("[delIn] MainForm", ex.Message)
            Return False
        End Try
    End Function

    Sub delInClear(ByVal hexcode As String)
        If conServer() = False Then
            MsgBox("Can't delete card data to server due of conection problem! ", vbCritical, "Delete")
        End If

        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from timeindb where CardCode='" & hexcode & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Public Sub DelLocal(ByVal orNo As String)
        'If conLocal() = False Then Exit Sub
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

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PushToServer()
    End Sub

    Private Sub cmdEditPlate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditPlate.Click
        frmEditPlate.ShowDialog()
    End Sub

    Private Sub btnEntryVeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntryVeh.Click
        Dim f As New frmEntryVeh
        f.ShowDialog()
    End Sub

    Private Sub TmrRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrRead.Tick
        If bgwCtrler.IsBusy = False Then
            bgwCtrler.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgwCtrler_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCtrler.DoWork
        With My.Settings
            TmrRead.Enabled = False
            updateControllerStatus(.ctrl_SN, .ctrl_PcIp, .ctrl_Port)
        End With
    End Sub

    Private Sub bgwCtrler_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCtrler.RunWorkerCompleted
        TmrRead.Enabled = True
    End Sub

    Private Sub bgwServerPush_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwServerPush.DoWork
        PushToServer()
    End Sub

    Private Sub txtTender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTender.TextChanged

    End Sub
End Class
