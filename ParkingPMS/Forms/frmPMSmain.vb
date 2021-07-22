Imports ADODB
Imports System.Threading
Public Class frmPMSmain
    Public id As String
    Public Dstat As Boolean
    Public EntID As String
    Public entIPad As String


    Public Delegate Sub GetTotalSales()
    Public Delegate Sub GetTotalTrans()
    Public Delegate Sub GetSlotAvail()

    Sub GetSLots()

        If (InvokeRequired) Then
            Invoke(New GetSlotAvail(AddressOf GetSLots))
        Else
            tmeSlot.Enabled = False
            If conLocal() = False Then
                txtSlot.Text = txtTotalSlot.Text
            End If

            Try
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSqlLoc.Execute("select count(CardCode) as CNt from timeindb limit 1;")
                If rs.EOF = False Then
                    txtSlot.Text = Val(txtTotalSlot.Text) - Val(rs("CNt").Value)
                Else
                    txtSlot.Text = txtTotalSlot.Text
                End If
                tmeSlot.Enabled = True
            Catch ex As Exception
                txtSlot.Text = txtTotalSlot.Text
            End Try
        End If

    End Sub

    Private Sub frmPMSmain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If verClose = "Quit" Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmPMSmain_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtOp.Text = "Lock" Then
                frmLogin.ShowDialog()
            End If
        End If

    End Sub

    Private Sub frmPMSmain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
      
        LockPms()
        viewSocketSet()
        txtPosi.Text = "System"
        TxtOp.Text = "Lock"

        viewCon()
        If conLocal() = True Then
            txtDbStat.Text = "Connected"
            txtDbStat.ForeColor = Color.Lime
            frmParkingSlot.txtSlot.Value = viewSlot()
            txtTotalSlot.Text = viewSlot()
            tmeSlot.Enabled = True

            lstList.Clear()
            PosHeader()
            fill()

            EntfillwStat()

            SC_Listen()

            If frmLogo.chk = False Then
                PicLogo.Image = Logo_Image()
            End If
        Else
            txtDbStat.Text = "Disconnected"
            txtDbStat.ForeColor = Color.Red
            Exit Sub
        End If
    End Sub

    Sub PosHeader()
        lstList.Columns.Add("Station", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Location", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("Ip Address", 300, HorizontalAlignment.Left)
        lstList.Columns.Add("Port", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Username", 150, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        'On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblPOS")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Station").Value, Image1.Images.Count - 1)
                viewlst.SubItems.Add(rs("Location").Value)
                viewlst.SubItems.Add(rs("IpAdd").Value)
                viewlst.SubItems.Add(rs("Port").Value)
                viewlst.SubItems.Add(rs("Username").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub EntHeader()
        Dim w As Integer = lstList2.Width / 3
        lstList2.Columns.Add("Zone", w, HorizontalAlignment.Left)
        lstList2.Columns.Add("Zone IP", w, HorizontalAlignment.Left)
        lstList2.Columns.Add("Status", w, HorizontalAlignment.Left)
    End Sub

    Sub Entfill(Stat As String)
        'On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tbldispensers")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList2.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList2.Items.Add(rs("Zone").Value, Image2.Images.Count - 1)
                viewlst.SubItems.Add(rs("IP").Value)
                viewlst.SubItems.Add(Stat)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub connTrue()
        Dim ls As ListViewItem
        For Each ls In lstList.Items
            If ls.Selected = True Then
                ls.SubItems.Item(5).Text = "Connected"
                ls.BackColor = Color.LightBlue
            End If
        Next
    End Sub

    Sub connFalse()
        Dim ls As ListViewItem
        For Each ls In lstList.Items
            If ls.Selected = True Then
                ls.SubItems.Item(5).Text = "Disconnected"
                ls.BackColor = Color.White
            End If
        Next
    End Sub

    Sub POSable()
        cmdEditPOS.Enabled = True
        cmdDelPOS.Enabled = True
        cmdUpdateSettingsPOS.Enabled = True
        cmdTestPos.Enabled = True
    End Sub

    Sub POSdisable()
        cmdEditPOS.Enabled = False
        cmdDelPOS.Enabled = False
        cmdUpdateSettingsPOS.Enabled = False
        cmdTestPos.Enabled = False
    End Sub

    Private Sub tmeTime_Tick(sender As System.Object, e As System.EventArgs) Handles tmeTime.Tick
        txtTime.Text = Format(Now, "Long Date")
        txtTimer.Text = Format(Now, "HH:mm:ss tt")

        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVatSettings.ShowDialog()
    End Sub

    Private Sub cmdCharging_Click_1(sender As System.Object, e As System.EventArgs)
        frmLostCard.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click_1(sender As System.Object, e As System.EventArgs)
        frmReportDT.ShowDialog()
    End Sub

    Function slot() As String
        If conLocal() = False Then Return "0"
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from timeindb")
            If rs.EOF = False Then
                Return Val(txtTotalSlot.Text) - rs.RecordCount
            Else
                Return txtTotalSlot.Text
            End If
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Function totalTR() As Integer
        If conLocal() = False Then Return 0

        Try
            Dim dt As String = Format(Now, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblincomereport where TimeOut like '" & dt & "%'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function totalNet() As Double
        If conLocal() = False Then Return 0

        Try
            Dim dt As String = Format(Now, "yyyy-MM-dd")
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select sum(Total) as tt from tblincomereport where TimeOut like '" & dt & "%'")
            If rs.EOF = False Then
                Return rs("tt").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub tmeSlot_Tick(sender As System.Object, e As System.EventArgs) Handles tmeSlot.Tick
        'txtSlot.Text = slot()
        'txtTransaction.Text = totalTR()
        'txtTotalNet.Text = MakeMoney(totalNet())

        Dim th As New Thread(New ThreadStart(Sub() GetSLots()))
        th.Start()
    End Sub

    Private Sub txtTotalSlot_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtSlot_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub edit(ByVal st As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblPOS where Station = '" & st & "'")
        If rs.EOF = False Then
            With frmAddPOS
                .cboStation.Text = rs("Station").Value
                .txtArea.Text = rs("Location").Value
                .txtIp1.Text = rs("IpAdd").Value
                .txtUser.Text = rs("Username").Value
                .txtPwd.Text = rs("Password").Value
                .txtSPort.Text = rs("Port").Value
                .cboSdb.Text = rs("Database").Value
            End With
        End If
    End Sub

    Sub del(ByVal st As String)
        Dim rs As New Recordset
        If MsgBox("Are you sure do you want to delete this POS client?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblPOS where Station = '" & st & "'")
            MsgBox("POS successfully deleted!    ", vbInformation, "Delete")
            lstList.Clear()
            PosHeader()
            fill()
        End If
    End Sub

    Sub delEnt(ByVal st As String)
        Dim rs As New Recordset
        If MsgBox("Are you sure do you want to delete this Entry Zone?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tbldispensers where Zone = '" & st & "'")
            MsgBox("Entry Zone successfully deleted!    ", vbInformation, "Delete")
            lstList.Clear()
            PosHeader()
            fill()
        End If
    End Sub

    Private Sub cmdDelPOS_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub cmdTestPos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
                ViewClientAcc(id)
                If PingMe(C_ip) = True Then
                    If conClient(C_ip, C_uid, C_pwd, C_port, C_db) = True Then
                        viewlst.SubItems.Item(5).Text = "Connected"
                        viewlst.BackColor = Color.LightBlue
                        MsgBox("Successfully connected!    ", vbInformation, "POS Client")
                        'Exit For
                    Else
                        viewlst.SubItems.Item(5).Text = "Disconnected"
                        viewlst.BackColor = Color.Pink
                        MsgBox("Failed to connect!    ", vbExclamation, "POS Client")
                        'Exit For
                    End If
                Else
                    viewlst.SubItems.Item(5).Text = "Disconnected"
                    viewlst.BackColor = Color.Pink
                    MsgBox("Failed to connect!    ", vbExclamation, "POS Client")
                    'Exit For
                End If
            End If
        Next
    End Sub

    Function viewVolume() As Integer
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlClient.Execute("select * from tblincomereport")
            If rs.EOF = False Then
                Return rs.RecordCount
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub SocketSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SocketSettingsToolStripMenuItem.Click
        frmSocket.ShowDialog()
    End Sub

    Private Sub Wns_Local_ConnectionRequest(sender As Object, e As AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent) Handles Wns_Local.ConnectionRequest
        If Wns_Local.CtlState <> MSWinsockLib.StateConstants.sckConnected Then
            Wns_Local.Close()
        End If

        Wns_Local.Accept(e.requestID)
    End Sub

    Private Sub Wns_Local_SendComplete(sender As Object, e As System.EventArgs) Handles Wns_Local.SendComplete
        Wns_Local.Close()
    End Sub

    Private Sub cmdAddD_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddD.Click
        With frmAddDispenser
            .txtTitle.Text = "Add Dispenser"
            .cboZone.Enabled = True
            .cboZone.Text = vbNullString
            .txtZoneHost.Text = vbNullString
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdeditD_Click(sender As System.Object, e As System.EventArgs) Handles cmdeditD.Click
        If EntID = vbNullString Then Exit Sub

        With frmAddDispenser
            .txtTitle.Text = "Update Dispenser"
            .cboZone.Enabled = False
            .cboZone.Text = EntID
            .txtZoneHost.Text = entIPad
            .ShowDialog()
        End With
    End Sub

    Private Sub SystemLogoToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles SystemLogoToolStripMenuItem.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub DatabaseSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatabaseSettingsToolStripMenuItem.Click
        frmConnDB.ShowDialog()
    End Sub

    Private Sub cmdDbSettings_Click(sender As System.Object, e As System.EventArgs) Handles cmdDbSettings.Click
        frmParkingSlot.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs)
        frmAcc.ShowDialog()
    End Sub

    Private Sub cmdVehicle_Click(sender As System.Object, e As System.EventArgs) Handles cmdVehicle.Click
        frmVehicle.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        frmCharging.ShowDialog()
    End Sub

    Private Sub cmdOvernigth_Click(sender As System.Object, e As System.EventArgs) Handles cmdOvernigth.Click
        frmOvernigth.ShowDialog()
    End Sub

    Private Sub cmdVatSettings_Click(sender As System.Object, e As System.EventArgs) Handles cmdVatSettings.Click
        frmVatSettings.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmReportDT.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmSummaryReport.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If MsgBox("Are you sure do you want to logout?", vbQuestion + vbYesNo + vbDefaultButton2, "Logout") = vbYes Then
            LockPms()
            txtPosi.Text = "System"
            TxtOp.Text = "Lock"
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System Terminate") = vbYes Then
            verClose = "Quit"
            RestartExplorer()
            Application.Exit()
        End If
    End Sub

    Private Sub cmdAddPOS_Click(sender As System.Object, e As System.EventArgs) Handles cmdAddPOS.Click
        With frmAddPOS
            .lblTitle.Text = "New POS"
            .cboStation.Enabled = True
            .txtIp1.Text = vbNullString
            .txtPwd.Text = vbNullString
            .txtUser.Text = vbNullString
            .txtArea.Text = vbNullString
            .cboStation.Text = vbNullString
            .cboSdb.Text = vbNullString
            .cboStation.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdEditPOS_Click(sender As System.Object, e As System.EventArgs) Handles cmdEditPOS.Click
        frmAddPOS.lblTitle.Text = "Update POS"
        frmAddPOS.cboStation.Enabled = False
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
                edit(id)
                frmAddPOS.ShowDialog()
            End If
        Next
    End Sub

    Private Sub cmdDelPOS_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelPOS.Click
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Delete")
            Exit Sub
        End If

        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
                del(id)
            End If
        Next
    End Sub

    Private Sub cmdUpdateSettingsPOS_Click(sender As System.Object, e As System.EventArgs) Handles cmdUpdateSettingsPOS.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
                ViewClientAcc(id)
                If PingMe(C_ip) = True Then
                    If conClient(C_ip, C_uid, C_pwd, C_port, C_db) = True Then
                        frmUpdateSettigns.ShowDialog()
                    Else
                        MsgBox("Failed to connect!    ", vbExclamation, "POS Client")
                    End If
                Else
                    MsgBox("Failed to connect!    ", vbExclamation, "POS Client")
                End If
            End If
        Next
    End Sub

    Private Sub cmdDownload_Click(sender As System.Object, e As System.EventArgs) Handles cmdDownload.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
                frmDownload.txtStation.Text = viewlst.SubItems(0).Text
                ViewClientAcc(id)
                If PingMe(C_ip) = True Then
                    If conClient(C_ip, C_uid, C_pwd, C_port, C_db) = True Then
                        frmDownload.txtTRec.Text = viewVolume()
                        frmDownload.txtTrec2.Text = viewVolume()
                        frmDownload.ShowDialog()
                    Else
                        MsgBox("Failed to connect!    ", vbExclamation, "POS Client")
                    End If
                Else
                    MsgBox("Failed to connect!    ", vbExclamation, "POS Client")
                End If
            End If
        Next
    End Sub

    Private Sub Wns_Local_ConnectEvent(sender As System.Object, e As System.EventArgs) Handles Wns_Local.ConnectEvent

    End Sub

    Private Sub Wns_Local_DataArrival(sender As Object, e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles Wns_Local.DataArrival
        Dim data As String = ""
        Wns_Local.GetData(data)
        If OtherSignal(data) = False Then
            MsgBox(data, vbInformation, "Response")
            Exit Sub
        End If

        If Dstat = CheckZoneStat(data) Then Exit Sub
        lstList2.Clear()
        EntHeader()
        ' EntfillwStat(data)

    End Sub

    Sub EntfillwStat()
        'On Error Resume Next
        lstList2.Clear()
        EntHeader()

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tbldispensers")
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList2.Refresh()
                Dim viewlst As New ListViewItem
                If PingMe(rs("IP").Value) = True Then
                        viewlst = lstList2.Items.Add(rs("Zone").Value, Image2.Images.Count - 1)
                        viewlst.SubItems.Add(rs("IP").Value)
                        viewlst.SubItems.Add("Active")
                        Dstat = False
                Else
                    viewlst = lstList2.Items.Add(rs("Zone").Value, Image2.Images.Count - 1)
                    viewlst.SubItems.Add(rs("IP").Value)
                    viewlst.SubItems.Add("Stop")
                    Dstat = True
                End If
                rs.MoveNext()
            Next

        End If

    End Sub

    Sub updateFillDis(Zone As String, Stat As String)
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tbldispensers where Zone = '" & Zone & "'", conSqlLoc, 1, 2)
            If rs.EOF = False Then
                rs("Status").Value = Stat
                rs.Update()
                delDisMsg(Zone)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub FillDispstat()
        If conLocal() = False Then Exit Sub

        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tbldispensers")
        If rs.EOF = False Then
            lstList2.Clear()
            EntHeader()
            For lup = 1 To rs.RecordCount
                lstList2.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList2.Items.Add(rs("Zone").Value, Image2.Images.Count - 1)
                viewlst.SubItems.Add(rs("IP").Value)
                viewlst.SubItems.Add(rs("Status").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub delDisMsg(Zone As String)
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("delete from tbldispensermsg where EntryZone = '" & Zone & "'")
        Catch ex As Exception

        End Try
    End Sub

    Sub delDisCMD(Zone As String)
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("Delete from tbldispensercmd where EntryZone = '" & Zone & "'")
        Catch ex As Exception

        End Try
    End Sub

    Sub EntfillwStat2()
        If conLocal() = False Then Exit Sub

        Dim rs1 As New Recordset
        rs1 = New Recordset
        rs1 = conSqlLoc.Execute("select * from tbldispensermsg")
        If rs1.EOF = False Then
            Dim Zone As String = rs1("EntryZone").Value
            Dim Stat As String = rs1("Msg").Value

            updateFillDis(Zone, Stat)

            FillDispstat()
        End If

    End Sub

    Sub ReplyCommand()
        If conLocal() = False Then Exit Sub

        Dim rs1 As New Recordset
        rs1 = New Recordset
        rs1 = conSqlLoc.Execute("select * from tbldispensercmd")
        If rs1.EOF = False Then
            Dim Zone As String = rs1("EntryZone").Value
            Dim Stat As String = rs1("Msg").Value

            frmDcommand.txtStat.Text = Stat

            delDisCMD(Zone)

        End If
    End Sub

    Sub findZoneInDB(data As String)
        If conLocal() = False Then Exit Sub
        Dim rs As New Recordset

        rs = conSqlLoc.Execute("select * from tbldispensers")
        Do While rs.EOF = False
            If CheckZoneSignal(data, rs("Zone").Value) = True Then
                If CheckZoneStat(data) = True Then
                    lstList2.Clear()
                    EntHeader()
                    Entfill("Stop")
                    Exit Sub
                Else
                    lstList2.Clear()
                    EntHeader()
                    Entfill("Active")
                    Exit Sub
                End If
            End If
            rs.MoveNext()
        Loop
    End Sub

    Function CheckZoneSignal(str As String, strF As String) As Boolean
        Dim strL As Integer = Len(str)
        Dim strtest As String = Replace(str, strF, vbNullString)
        Dim strtestL As Integer = Len(strtest)

        If strL > strtestL Then
            Return True
        Else
            Return False
        End If
    End Function

    Function CheckZoneStat(str As String) As Boolean
        Dim strL As Integer = Len(str)
        Dim strtest As String = Replace(str, "Stop", vbNullString)
        Dim strtestL As Integer = Len(strtest)

        If strL > strtestL Then
            Return True
        Else
            Return False
        End If
    End Function


    Function OtherSignal(str As String) As Boolean
        Dim strL As Integer = Len(str)
        Dim strtest As String = Replace(str, "Entry Zone", vbNullString)
        Dim strtestL As Integer = Len(strtest)

        If strL > strtestL Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdCommandD_Click(sender As System.Object, e As System.EventArgs) Handles cmdCommandD.Click
        If EntID = vbNullString Then Exit Sub
        With frmDcommand
            .txtDispenser.Text = EntID
            .ShowDialog()
        End With
    End Sub

    Private Sub cmdDelD_Click(sender As System.Object, e As System.EventArgs) Handles cmdDelD.Click
        If EntID = vbNullString Then Exit Sub
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Delete")
            Exit Sub
        End If

        delEnt(EntID)
        EntfillwStat()
    End Sub

    Private Sub PickLodByTimeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PickLodByTimeToolStripMenuItem.Click
        frmPickLoadTME.ShowDialog()
    End Sub

    Private Sub PickLoadByDateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PickLoadByDateToolStripMenuItem.Click
        frmPickloadDT.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmBackUp.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem4.Click
        frmRestore.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        frmDiscount.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Try
            Shell(Application.StartupPath & "\VIP\Access Control System.exe", AppWinStyle.NormalFocus)
        Catch
        End Try
    End Sub

    Private Sub ChargingRulesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChargingRulesToolStripMenuItem.Click
        frmChargingLED.ShowDialog()
    End Sub

    Private Sub TmrRead_Tick(sender As System.Object, e As System.EventArgs) Handles TmrRead.Tick
        EntfillwStat2()
        ReplyCommand()
    End Sub

    Private Sub lstList2_Click(sender As Object, e As System.EventArgs) Handles lstList2.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList2.Items
            If viewlst.Selected = True Then
                EntID = viewlst.SubItems(0).Text
                entIPad = viewlst.SubItems(1).Text
            End If
        Next
    End Sub

    Private Sub lstList2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstList2.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList2.Items
            If viewlst.Selected = True Then
                EntID = viewlst.SubItems(0).Text
                entIPad = viewlst.SubItems(1).Text
            End If
        Next
    End Sub

    Private Sub ByDateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ByDateToolStripMenuItem.Click
        frmSummaryRate.ShowDialog()
    End Sub

    Private Sub ByOperatorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ByOperatorToolStripMenuItem.Click
        frmOpSummaryRate.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        frmAccDesig.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem6.Click
        frmAcc.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        frmTransTme.ShowDialog()
    End Sub

    Private Sub PickLoadByDateInListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PickLoadByDateInListToolStripMenuItem.Click
        frmTransDt.ShowDialog()
    End Sub

    Private Sub LenthOfStayReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LenthOfStayReportToolStripMenuItem.Click
        frmLengthStay.ShowDialog()
    End Sub

    Private Sub LengthOfStayReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LengthOfStayReportToolStripMenuItem.Click
        frmLstayRep.ShowDialog()
    End Sub

    Private Sub AccountabilityReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountabilityReportToolStripMenuItem.Click
        frmAccReport.ShowDialog()
    End Sub

    Private Sub cmdVehicleInLogs_Click(sender As System.Object, e As System.EventArgs) Handles cmdVehicleInLogs.Click
        frmVehicleInlogs.ShowDialog()
    End Sub

    Private Sub UpdateDoubleORToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateDoubleORToolStripMenuItem.Click
        frmUpdateDoubleOR.ShowDialog()
    End Sub

    Private Sub tmrData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrData.Tick

    End Sub

    Sub GetSales()
        If (InvokeRequired) Then
            Invoke(New GetTotalSales(AddressOf GetSales))
        Else
            tmeSales.Enabled = False
            If conLocal() = False Then
                txtTotalNet.Text = "0.00"
                Exit Sub
            End If

            Try
                Dim dt As String = Format(Now, "yyyy-MM-dd")
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSqlLoc.Execute("select sum(Total) as tt from tblincomereport where TimeOut like '" & dt & "%' limit 1;")
                If rs.EOF = False Then
                    txtTotalNet.Text = MakeMoney(Val(rs("tt").Value)).ToString
                Else
                    txtTotalNet.Text = "0.00"
                End If

                tmeSales.Enabled = True
            Catch ex As Exception
                txtTotalNet.Text = "0.00"
            End Try
        End If

    End Sub

    Private Sub tmeSales_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmeSales.Tick
        Dim th As New Thread(New ThreadStart(Sub() GetSales()))
        th.Start()
    End Sub

    Sub GetTransCnt()
        If (InvokeRequired) Then
            Invoke(New GetTotalTrans(AddressOf GetTransCnt))
        Else
            tmecnt.Enabled = False
            If conLocal() = False Then
                txtTransaction.Text = "0"
            End If

            Try
                Dim dt As String = Format(Now, "yyyy-MM-dd")
                Dim rs As New Recordset
                rs = New Recordset
                rs = conSqlLoc.Execute("select Count(ORno) as ORcnt from tblincomereport where TimeOut like '" & dt & "%'")
                If rs.EOF = False Then
                    txtTransaction.Text = CInt(rs("ORcnt").Value).ToString
                Else
                    txtTransaction.Text = "0"
                End If

                tmecnt.Enabled = True
            Catch ex As Exception
                txtTransaction.Text = "0"
            End Try
        End If
    End Sub

    Private Sub tmecnt_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmecnt.Tick
        Dim th As New Thread(New ThreadStart(Sub() GetTransCnt()))
        th.Start()
    End Sub
End Class