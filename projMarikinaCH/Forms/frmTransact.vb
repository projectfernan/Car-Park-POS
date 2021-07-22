Imports ADODB
Public Class frmTransact
    

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = MainForm.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmTransact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        iout = Format(Now, "yyyy-MM-dd HH:mm:00")

        If e.KeyCode = Keys.F1 Then
            Dim vtp As String = Get_Vtype("F1")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                txtPlate.Focus()
                Exit Sub
            End If

            If vtp <> vbNullString Then
                If ChkChargType("F1") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F2 Then
            Dim vtp As String = Get_Vtype("F2")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                If ChkChargType("F2") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            Dim vtp As String = Get_Vtype("F3")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F3") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Dim vtp As String = Get_Vtype("F4")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F4") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F5 Then
            Dim vtp As String = Get_Vtype("F5")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F5") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            Dim vtp As String = Get_Vtype("F6")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F6") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            Dim vtp As String = Get_Vtype("F7")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F7") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            Dim vtp As String = Get_Vtype("F8")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F8") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            Dim vtp As String = Get_Vtype("F9")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F9") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            Dim vtp As String = Get_Vtype("F10")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F10") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            Dim vtp As String = Get_Vtype("F11")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F11") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            Dim vtp As String = Get_Vtype("F12")
            If txtPlate.Text = vbNullString Or Len(txtPlate.Text) < 6 Then
                MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
                Exit Sub
            End If

            If vtp <> vbNullString Then
                'Transact(vtp)
                If ChkChargType("F12") = True Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    S_CouponName = vtp
                    Dim fr As New frmRefNo
                    fr.ShowDialog()
                    Me.Close()
                ElseIf ReceiptType = "Senior" Then
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                    Dim sn As New frmSenior
                    sn.ShowDialog()
                    Me.Close()
                Else
                    Transact(vtp, txtPlate.Text, True, False, EntryTime, iout)
                End If
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width / 2
        Dim w2 As Integer = w / 2
        lstList.Columns.Add("Key", w2, HorizontalAlignment.Left)
        lstList.Columns.Add("Charging", w2 + w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblcharge order By KeyCode")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rs("KeyCode").Value, lup)
                    viewlst.SubItems.Add(rs("VehicleType").Value)
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            Save_ErrLogs("[fillL] frmTransact", ex.Message)
        End Try
    End Sub

    Function Get_Vtype(ByVal K As String) As String
        If conLocal() = False Then Return vbNullString

        Try
            Dim rs As New Recordset

            rs = New Recordset

            rs = conSqlLoc.Execute("select VehicleType from tblcharge where KeyCode = '" & K & "'")
            If rs.EOF = False Then
                Return rs("VehicleType").Value
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Save_ErrLogs("[Get_Vtype] frmTransact", ex.Message)
            Return vbNullString
        End Try
    End Function

    Private Sub frmManualInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        S_Refnumber = "No Ref Number"
        S_PayType = "Regular"

        Me.txtPlate.CharacterCasing = CharacterCasing.Upper
        loc()

        lstList.Clear()
        header()

        If conLocal() = True Then
            lstList.Clear()
            header()
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Function getTimein(ByVal HexID As String) As Boolean
        If conServer() = False Then Return False

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from timeinDB where CardCode = '" & HexID & "'", conSqlPOS, 1, 2)
        If rs.EOF = False Then
            tmeIn = Format(CDate(rs("TimeIn").Value), "yyyy-MM-dd HH:mm:00")
            Return True
        Else
            Return False
        End If

    End Function

    Public Function readCard() As Boolean
        Try
            tmeIn = Trim(d8_Read()) + ":00"
            tmeIn = Mid(d8_Read(), 7, 4) & "-" & Mid(d8_Read(), 1, 2) & "-" & Mid(d8_Read(), 4, 2) & " " & Mid(d8_Read(), 12)
            EntryTime = DateTime.Parse(tmeIn)
            Return True
        Catch ex As Exception
            Save_ErrLogs("[readCard] frmTransact", ex.Message)
            Return False
        End Try
    End Function

    Private Sub frmTransact_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        S_Refnumber = "No Ref Number"
        S_PayType = "Regular"
        S_SeniorName = ""
        S_CouponName = ""
    End Sub

    Private Sub lstList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstList.Click
        txtPlate.Focus()
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

End Class