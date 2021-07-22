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
                Call cmdLost_Click_1(sender, New System.EventArgs)
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.F5 Then
                frmManualLost.ShowDialog()
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
            txtDbStat.ForeColor = Color.Red
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

            P_Msg = "THIS OFFICIAL RECEIPT SHALL BE VALID FOR" & vbNewLine & "                 5 YEARS FROM THE DATE OF" & vbNewLine & "                         THE PERMIT TO USE"

           
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

            P_Msg = "THIS OFFICIAL RECEIPT SHALL BE VALID FOR" & vbNewLine & "          FIVE(5) YEARS FROM THE DATE OF" & vbNewLine & "                         THE PERMIT TO USE"

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
            'CheckOR:
            '           If checkORexist(Ticket_OR_No()) = True Then
            'Update_OR()
            'GoTo CheckOR
            'End If

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
                                    If readCard() = False Then
                                        If getTimein(HexCardID) = True Then
                                            delIn()
                                        End If
                                        MsgBox("No record found!    ", vbExclamation, "Transaction")
                                        Exit Sub
                                    Else
                                        If getTimein(HexCardID) = True Then
                                        End If    '  If chkCardIncome(HexCardID, tmeIn) = True Then
                                        InPic.Image = Get_PicIn(HexCardID)
                                        DriverImage.Image = Get_PicDriver(HexCardID)
                                        .txtPlate.Text = ViewPlate(HexCardID)
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

    Private Sub cmdRR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRR.Click
        If conServer() = True Then
            txtSlot.Text = slot()
            If MsgBox("Reprint last transaction?    ", vbQuestion + vbYesNo, "Reprint") = vbYes Then
                reprint()
                Prnt()
            End If
        End If
    End Sub

    Private Sub cmdSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSS.Click
        frmEditPlate.ShowDialog()
    End Sub

    Private Sub cmdLO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLO.Click
        If MsgBox("Are you sure do you want to logout?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Logout") = MsgBoxResult.Yes Then
            PrntExt(TxtOp.Text, dtlogin(txtUsername.Text), Format(Now, "yyyy-MM-dd HH:mm:59"))
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
                MsgBox("Plese enter tender amount!    ", vbExclamation, "Tendered amount")
                txtTender.Focus()
                Exit Sub
            End If

            If d8_Card() = False Then
                MsgBox("Please place your card to reader! ", vbExclamation, "Tendered amount")
                txtTender.Text = vbNullString
                Exit Sub
            End If

            Dim tenderAmout As Double = txtTender.Text
            Dim TotalAmount As Double = lblTotal.Text
            Dim ChangeAmout As Double = MakeMoney(Get_ChangeAmt(TotalAmount, tenderAmout))

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
                If S_PayType = "GracePeriod" And My.Settings.GPprint = True Then
                Else
                    'Prnt()
                    PrintReceiptRaw_Now()
                End If

                If conServer() = True Then
                    Update_OR()
                    lblORno.Text = Ticket_OR_No()

                    d8_AuthenWr()
                    d8_LoadpassWr()
                    D8_Write()

                    delIn()
                    delIn()


                    txtSlot.Text = slot()
                    d8_AuthenWr()
                    d8_LoadpassWr()
                    D8_Write()

                    saveToServer(tenderAmout, ChangeAmout)
                    If My.Settings.DataPool = False Then
                        PushToServer()
                    End If

                    txtAmtStat.Text = "CHANGE :"
                    lblTotal.Text = MakeMoney(ChangeAmout)

                    'kansela()
                    FinishedTR()
                    triger()
                Else
                    If conLocal() = True Then
                        Update_OR()
                        lblORno.Text = Ticket_OR_No()
                        d8_AuthenWr()
                        d8_LoadpassWr()
                        D8_Write()
                        d8_AuthenWr()
                        d8_LoadpassWr()
                        D8_Write()

                        saveL(tenderAmout, ChangeAmout)

                        txtAmtStat.Text = "CHANGE :"
                        lblTotal.Text = MakeMoney(ChangeAmout)

                        'kansela()
                        FinishedTR()
                        triger()
                    Else
                        MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                        frmConnDB.ShowDialog()
                        Exit Sub
                    End If
                End If

                If d8_Card() = False Then
                    MsgBox("Please place your card to reader! ", vbExclamation, "Tendered amount")
                    txtTender.Text = vbNullString
                    Exit Sub
                End If

                d8_AuthenWr()
                d8_LoadpassWr()
                D8_Write()
                txtSlot.Text = slot()
                d8_AuthenWr()
                d8_LoadpassWr()
                D8_Write()

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

    Sub saveToServer(ByVal Ltender As Double, ByVal Lchange As Double)
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,InOutTotal,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,Tendered,`Change`,VehicleType,PayType,RefNum,BussDate)VALUES('" _
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
              "','" & Ltender & _
              "','" & Lchange & _
              "','" & lblVtype.Text & _
              "','" & S_PayType & _
              "','" & S_Refnumber & _
              "','" & BussdateStr() & "')")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
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

            Me.Cursor = Cursors.WaitCursor
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
                rs = conSqlPOS.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,InOutTotal,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,Tendered,`Change`,VehicleType,PayType,RefNum,BussDate)VALUES('" _
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
               "','" & tendered & _
               "','" & changes & _
               "','" & rs1("VehicleType").Value & _
               "','" & rs1("PayType").Value & _
               "','" & rs1("RefNum").Value & _
               "','" & LocBussDate & "')")

                PushdelIn(rs1("CardCode").Value)
                DelLocal(rs1("ORno").Value)

                rs1.MoveNext()
            Loop

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub saveL(ByVal Ltender As Double, ByVal Lchange As Double)
        Dim rs As New Recordset
        ' Try
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
        'Catch ex As Exception
        ' MsgBox(ex.Message, vbCritical)
        'End Try
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

    Sub delIn()
        If conServer() = False Then
            MsgBox("Can't delete card data to server due of conection problem! ", vbCritical, "Delete")
        End If

        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from timeindb where CardCode='" & HexCardID & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

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

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click

        PushToServer()

    End Sub
End Class
