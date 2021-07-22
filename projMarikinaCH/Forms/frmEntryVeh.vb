Imports ADODB
Public Class frmEntryVeh
    Dim CardStat As String = ""

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Function Delete_Card(ByVal Card As String) As Boolean
        If conServer() = False Then Return False
        Try
            conSqlPOS.Execute("DELETE FROM TimeinDB Where CardCode= '" & Card & "'")
            Return True
        Catch ex As Exception
            'Save_Logs(ex.Message.ToString)
            Return False
        End Try
    End Function

    Public Function Save_ToDatabase(ByVal CardCode As String, ByVal VEH As String, ByVal DateT As String, ByVal Station As String, ByVal Plate As String) As Boolean

        If Delete_Card(CardCode) = False Then Return False

        If conServer() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs.Open("SELECT * FROM TimeinDB WHERE 0=1", conSqlPOS, 1, 2)
            rs.AddNew()
            rs("CardCode").Value = CardCode
            rs("Timein").Value = DateT
            rs("Vehicle").Value = VEH
            rs("PC").Value = Station
            rs("Lane").Value = "ENTRY POS"
            If Plate = vbNullString Then
                rs("Plate").Value = "-"
            Else
                rs("Plate").Value = Plate
            End If

            If Get_ImageName() = Nothing Then
            Else
                rs("PIC").Value = StreamImage.Read
            End If

            rs.Update()

            Delete_ENt_Image()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function CheckEntryVEh(ByVal Ccode As String) As Boolean
        Dim rs As New Recordset
        Try
            rs = conSqlPOS.Execute("select CardCode from timeindb where CardCode = '" & Ccode & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("[LOG] CheckEntryVEh", ex.Message)
            Return False
        End Try
    End Function

    Private Sub LOG()
        Try
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please input the plate number! ", vbExclamation, "Register Entry Vehicle")
                txtPlate.Focus()
                Exit Sub
            End If

            Dim st As Integer = 0
            Dim IsCamera As Boolean
            Dim Plate As String = vbNullString
            rd = New COMRD800Lib.RD800
            st = rd.dc_init(100, 115200)

            If st < 0 Then
                st = rd.dc_init(200, 115200)

                If st < 0 Then
                    If ER302Reader() = False Then
                        MsgBox("Device is Not Connected", vbExclamation, "Register Entry Vehicle")
                        Exit Sub
                    Else
                        Select Case CardStat
                            Case "Proc"
                                GoTo openBar
                            Case "InUsed"
                                GoTo inused
                            Case "NoCard"
                                Exit Sub
                        End Select
                    End If
                End If

            Else
                If d8_Card() = False Then
                    MsgBox("Please place your card to reader!", vbExclamation, "Register Entry Vehicle")
                    Exit Sub
                End If
                rd.dc_beep(10)
            End If

rewrite:    pnNotice.Visible = True

            Application.DoEvents()

            Dim Code As String = String.Empty
            st = rd.dc_card(0, Code)

            If st <> 0 Then
                Exit Sub
            Else
                'On Error Resume Next
                If d8_LoadpassOL() = True Then
                    If d8_AuthenOL() = True Then
                        HexCardID = d8_ReadOL()
                    End If
                End If
            End If

            rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF"
            st = rd.dc_load_key(0, 0)
            If st < 0 Then
                MsgBox("Card Error", MsgBoxStyle.Exclamation)
                pnNotice.Visible = False
                Exit Sub
            End If

            'Generate CardCode
            st = rd.dc_authentication(0, 3)
            If st < 0 Then
                MsgBox("Error Card", vbExclamation, "Register Entry Vehicle")
                pnNotice.Visible = False
                Exit Sub
            End If

            If readCard() = True Then
                If My.Settings.EntryLogDb = True Then
                    If CheckEntryVEh(HexCardID) = True Then
                        GoTo inused
                    Else
                        GoTo proc
                    End If
                End If
inused:         MessageBox.Show("Card is already used in entry transaction! Please give the card to the parker.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                pnNotice.Visible = False
                txtPlate.Text = vbNullString
                txtPlate.Focus()
                Exit Sub
            End If

            'write Date Time ========================
proc:       rd.dc_restore(CShort(12))
            Dim T As String = Format(Now, "yyyy-MM-dd HH:mm")
            rd.put_bstrSBuffer_asc = StringToHex(T)
            st = rd.dc_write(CShort(12))
            If st < 0 Then
                MsgBox("Error in writing date to card", vbExclamation, "Register Entry Vehicle")
                pnNotice.Visible = False
                Exit Sub
            Else
            End If

            'Write Station =========================
            rd.dc_restore(CShort(13))
            rd.put_bstrSBuffer_asc = StringToHex(MainForm.txtStation.Text)
            st = rd.dc_write(CShort(13))
            If st < 0 Then
                MsgBox("Error in writing station to card", vbExclamation, "Register Entry Vehicle")
                pnNotice.Visible = False
                Exit Sub
            End If

            If txtPlate.Text = vbNullString Then
                Plate = vbNullString
            Else
                'Write Plate Number=====================
                Plate = txtPlate.Text
                rd.dc_restore(CShort(14))
                rd.put_bstrSBuffer_asc = StringToHex(txtPlate.Text & "       ")
                st = rd.dc_write(CShort(14))

                If st < 0 Then
                    MsgBox("Error card!", vbExclamation, "Register Entry Vehicle")
                    pnNotice.Visible = False
                    Exit Sub
                End If

            End If

            'save To Database ==============>
            EntVehCapture()
            If Save_ToDatabase(HexCardID, "CAR", T, MainForm.txtStation.Text, Plate) = False Then
                errMsg = "Vehicle entry failed to save to server."
            End If

            If d8_Card() = False Then
                MessageBox.Show("Failed to write card!", "Register Entry Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                pnNotice.Visible = False
                If MessageBox.Show("Try to re-write card?", "Register Entry Vehicle", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo rewrite
                End If
            End If

            rd.put_bstrSBuffer_asc = "FFFFFFFFFFFF"
            st = rd.dc_load_key(0, 0)
            If st < 0 Then
                MsgBox("Card Error", MsgBoxStyle.Exclamation)
                pnNotice.Visible = False
                Exit Sub
            End If

            'Generate CardCode
            st = rd.dc_authentication(0, 3)
            If st < 0 Then
                MsgBox("Error Card", vbExclamation, "Register Entry Vehicle")
                pnNotice.Visible = False
                Exit Sub
            End If

            If readCard() = False Then
                MessageBox.Show("Failed to write card!", "Register Entry Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                pnNotice.Visible = False
                If MessageBox.Show("Try to re-write card?", "Register Entry Vehicle", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    GoTo rewrite
                Else
                    pnNotice.Visible = False
                    txtPlate.Text = vbNullString
                    txtPlate.Focus()
                    Exit Sub
                End If
            End If

            rd.dc_halt()
            rd.dc_exit()

openBar:    MainForm.txtSlot.Text = slot().ToString

            pnNotice.Visible = False

            MessageBox.Show("The card is successfully registered to the entry vehicle!" & vbCrLf & _
                            "Give the card to the parker.", "Register Entry Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If MessageBox.Show("Open barrier?", "Open Barrier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> Windows.Forms.DialogResult.Yes Then
                Me.Close()
                Exit Sub
            End If

re:         If OpenBarrierEnt() = False Then
                MessageBox.Show("Failed to open the barrier!", "Open Barrier", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If MessageBox.Show("Retry to open barrier?", "Open Barrier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                    If OpenBarrierEnt() = False Then GoTo re
                End If
            End If
            Me.Close()

        Catch ex As Exception
            Save_ErrLogs("[LOG] frmEntryVeh", ex.Message)
        End Try
    End Sub

    Function ER302Reader() As Boolean
        'Connect to port
reDo:   If ER302_Conn(My.Settings.Er302Com) = False Then Return False

        'Create request
        If ER302_Request() = False Then
            MsgBox("Please place your card to reader!", vbExclamation, "Register Entry Vehicle")
            CardStat = "NoCard"
            Return True
        End If

        'Anticoll
        Dim snr As String = ER302_AntiColl()
        If snr = "" Then Return False

        'Card Select
        If ER302_CardSelect() = False Then Return False

        If My.Settings.EntryLogDb = True Then
            If CheckEntryVEh(snr) = True Then
                Dim dT As String = ER302_ReadCard(12)
                If IsDate(dT) Then
                    CardStat = "InUsed"
                    Return True
                Else
                    CardStat = "Proc"
                    GoTo proc
                End If
            Else
                CardStat = "Proc"
                GoTo proc
            End If
        End If

proc:   'write Date Time ========================
        Dim T As String = Format(Now, "yyyy-MM-dd HH:mm")
        Dim dtHex As String = StringToHex(T)
        If ER302_WriteCard(dtHex, 12) = False Then
            MsgBox("Error in writing date to card", vbExclamation, "Register Entry Vehicle")
            If MessageBox.Show("Retry to rewrite card?", "Open Barrier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo reDo
            End If

            pnNotice.Visible = False
            Return False
        End If

        'Write Station =========================
        Dim lup As Integer
        Dim St As String = MainForm.txtStation.Text
        Dim stLen As Integer = Len(St)

        If Len(St) <> 16 Then
            For lup = stLen To 16
                St = St & " "
                lup = Len(St)
            Next
        End If

        Dim StHex As String = StringToHex(St)
        If ER302_WriteCard(StHex, 13) = False Then
            MsgBox("Error in writing station to card", vbExclamation, "Register Entry Vehicle")
            If MessageBox.Show("Retry to rewrite card?", "Open Barrier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo reDo
            End If

            pnNotice.Visible = False
            Return False
        End If

        'Write Plate Number=====================
        Dim i As Integer
        Dim Plate As String = txtPlate.Text
        Dim pLen As Integer = Len(Plate)

        If Len(Plate) <> 16 Then
            For i = pLen To 16
                Plate = Plate & " "
                i = Len(Plate)
            Next
        End If

        Dim PlateHex As String = StringToHex(Plate)
        If ER302_WriteCard(PlateHex, 14) = False Then
            MsgBox("Error in writing plate number to card", vbExclamation, "Register Entry Vehicle")
            If MessageBox.Show("Retry to rewrite card?", "Open Barrier", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Retry Then
                GoTo reDo
            End If

            pnNotice.Visible = False
            Return False
        End If

        'save To Database ==============>
        EntVehCapture()
        If Save_ToDatabase(snr, "CAR", T, MainForm.txtStation.Text, txtPlate.Text) = False Then
            errMsg = "Vehicle entry failed to save to server."
        End If

        ER302_Halt()
        ER302_Beep()
        Return True
    End Function

    Private Sub txtPlate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlate.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()

        If e.KeyCode = Keys.Enter Then
            LOG()
        End If
    End Sub

    Private Sub frmEntryVeh_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        EntryCam.StopRealPlay()
        EntryCam.Logout()
        EntryCam.ClearOCX()
    End Sub

    Private Sub frmEntryVeh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'camInfo()
        camEntrance()
    End Sub

    Sub camEntrance()
        'CAM_CLOSE()
        Dim val As Long
        Try
            With My.Settings
                If PingMe(.CAM_IP) = False Then
                    errMsg = "Camera Entry Disconnected."
                    Exit Sub
                End If

                'Me.EntryCam.StopRealPlay()
                'Me.EntryCam.Logout()
                val = Me.EntryCam.Login(.CAM_IP, .CAM_Port, .CAM_User, .CAM_Pass)
                If val < 0 Then
                    errMsg = "Camera Entry Error."
                Else
                    Me.EntryCam.StartRealPlay(.CAM_ChannelEnt, 0, 0)
                    errMsg = vbNullString
                End If
            End With
        Catch ex As Exception
            Save_ErrLogs("[camEntrance] frmEntryVeh", ex.Message)
            errMsg = ex.Message
        End Try
    End Sub

    Sub EntVehCapture()
        Try
            Dim orgCAp As String
            Me.EntryCam.JPEGCapturePicture(My.Settings.CAM_ChannelCap1, 0, 0, Application.StartupPath & "\EntCapture")
            orgCAp = Dir(Application.StartupPath & "\EntCapture\JPEGCapture\*.jpeg")
            CopPic = (Application.StartupPath & "\EntCapture\JPEGCapture\" & orgCAp & "")
            errMsg = vbNullString
        Catch ex As Exception
            Save_ErrLogs("[EntVehCapture] frmEntryVeh", ex.Message)
            errMsg = ex.Message
        End Try
    End Sub

    Private Sub txtPlate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                txtPlate.Focus()
            Case 33 To 47
                e.KeyChar = vbNullString
            Case 91 To 96
                e.KeyChar = vbNullString
            Case 58 To 64
                e.KeyChar = vbNullString
            Case 123 To 126
                e.KeyChar = vbNullString
            Case 8, 9, 27, 32  'backspace, tab, esc, space
        End Select
    End Sub

    Private Sub txtPlate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlate.TextChanged

    End Sub
End Class