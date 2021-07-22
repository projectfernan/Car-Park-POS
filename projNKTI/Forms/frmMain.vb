﻿Imports ADODB
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

        If e.Control = True And e.KeyCode = Keys.Insert Then
            If TxtOp.Text = "fernan" Then
                frmSystem.ShowDialog()
            End If
        End If

        If trOpt = True And TrLostOpt = True Then
            If e.KeyCode = Keys.Enter Then
                PoleDisOpen()
                clear()
                displayTotal(lblTotal.Text)
                PoleDisClose()
                frmTender.ShowDialog()
            End If
        End If

        If trOpt = True And TrLostOpt = True Then
            If e.KeyCode = Keys.D1 Then
                frmDiscountCateg.ShowDialog()
            End If
        End If

        If trOpt = True And TrLostOpt = True Then
            If e.KeyCode = Keys.D2 Then
                Call cmdCancel_Click_1(sender, New System.EventArgs)
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
                If desig = "Operator" Then
                    Exit Sub
                End If
                ' frmSystem.ShowDialog()
            End If
        End If

        If verClose = "Lock" Then

        Else
            If e.KeyCode = Keys.Escape Then
                Call cmdLO_Click_1(sender, New System.EventArgs)
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

        If txtDbStat.Text = "Connected" Then
            txtTimer.Text = Format(Now, "Long Time")
        Else
            If dbstat2.Text = "Connected" Then
                txtTimer.Text = Format(Now, "Long Time")
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End If

    End Sub

    Private Sub tmeTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeTime.Tick
        txtTime.Text = Format(Now, "Long Date")
        txtTimer.Text = Format(Now, "HH:mm:ss tt")
        'lblInOut.Text = Format(Now, "General Date")
        txtStatus.Text = Output(frmBarrier.txtStatAdd.Text)

        If My.Settings.DesktopLock = True Then
            For Each selProcess As Process In Process.GetProcesses
                If selProcess.ProcessName = "taskmgr" Then
                    selProcess.Kill()
                    Exit For
                End If
            Next
        End If
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
        Me.Focus()
        Me.KeyPreview = True
    End Sub

    Sub reprint()
        On Error Resume Next
        Dim rs As New Recordset

        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblIncomeReport where Station = '" & txtStation.Text & "' order by ID desc")
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


    Private Sub cmdAccept_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
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

    Private Sub cmdDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiscount.Click
        frmDiscountCateg.ShowDialog()
    End Sub

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
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
            EntryTime = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")
            Return True
        Catch
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
            lblORno.Text = Ticket_OR_No()
            With frmTransact
                .cboVtype.Text = vbNullString
                '.txtPlate.Text = vbNullString
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
                            InPic.Image = Get_PicIn(HexCardID)
                            DriverImage.Image = Get_PicDriver(HexCardID)
                            If MsgBox("Vehicle identified?    ", vbQuestion + vbYesNo, "Transaction") = vbYes Then
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
        frmSystem.ShowDialog()
    End Sub

    Private Sub cmdLO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLO.Click
        If MsgBox("Are you sure do you want to logout?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Logout") = MsgBoxResult.Yes Then
            Dim dt As Date = dtlogin(txtUsername.Text)
            If OrFrom(TxtOp.Text, txtStation.Text, dt, Now) <> "-" Then
                PrntLO(TxtOp.Text, dtlogin(txtUsername.Text), Format(Now, "yyyy-MM-dd HH:mm:59"))
                dellogTime(txtUsername.Text)
            End If

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
End Class
