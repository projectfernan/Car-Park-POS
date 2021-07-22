Imports ADODB
Public Class frmGuest

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click
        'Dim strStartg As String = Format(CDate(dtDateStart.Value), "yyyy-MM-dd HH:ss")
        'Dim strExpg As String = Format(CDate(dtDateExp.Value), "yyyy-MM-dd HH:mm:ss")

        'Dim dtin As String = Mid(strStartg, 1, 16)
        'Dim dtexp As String = Mid(strExpg, 1, 16)

        Dim strStart As String = Format(CDate(dtDateStart.Value), "yy-MM-dd HH:mm")
        Dim strExp As String = Format(CDate(dtDateExp.Value), "yy-MM-dd 00:00")
        Dim strExp2 As String = Format(CDate(dtDateExp.Value), "MM-dd-yyyy HH:mm")

        If d8_conn() = False Then
            MsgBox("No device connected! ", vbExclamation, "Transaction")
            Exit Sub
        End If

        If d8_Card() = False Then
            MsgBox("Please place your card to reader! ", vbExclamation, "Monthly Transaction")
            Exit Sub
        End If

        If D8_LoadKey(2) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_Authenticate(2) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_ResetCard(8) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_ResetCard(9) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_ResetCard(10) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        '----------------------------- Guest Data -------------------------------

        If D8_WriteCard(8, txtPlate.Text.ToString) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_WriteCard(9, strStart) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_WriteCard(10, strExp) = False Then
            MsgBox("Failed to write data! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        '-------------------------------------------------------------------------------

        If D8_LoadKey(4) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_Authenticate(4) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        Dim strStat As String = "Guest"

        If D8_WriteCard(16, strStat.ToString) = False Then
            MsgBox("Failed to write Grace Period please try again", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        '----------------------------- Capturer Data -------------------------------

        If D8_LoadKey(3) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_Authenticate(3) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_ResetCard(12) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_ResetCard(13) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_ResetCard(14) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_WriteCard(12, frmMain.lblORno.Text.ToString) = False Then
            MsgBox("Failed to write Grace Period please try again", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_WriteCard(13, strExp2) = False Then
            MsgBox("Failed to write Grace Period please try again", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_WriteCard(14, txtPlate.Text.ToString) = False Then
            MsgBox("Failed to write Grace Period please try again", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        '---------------------------------------------------------------------------

        If D8_LoadKey(0) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        If D8_Authenticate(0) = False Then
            MsgBox("The card is not reset properly! ", MsgBoxStyle.Exclamation, "Tender Amount")
            Exit Sub
        End If

        HexCardID = vbNullString
        HexCardID = d8_ReadOL()

        delCard(HexCardID)

        If SaveGuest() = True Then
            viewAmt()
        End If
        d8_Beep()
    End Sub

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmGuest_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdAccept_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmGuest_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        loc()
        dtDateStart.Value = Now
        dtDateExp.Value = Now
        txtPlate.Text = vbNullString
        txtPlate.Focus()
    End Sub

    Function SaveGuest() As Boolean
        If conServer() = False Then
            MsgBox("Please connect to server! ", vbExclamation, "Save")
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblguest", conSqlPOS, 1, 2)
            rs.AddNew()
            rs("CardCode").Value = HexCardID
            rs("Plate").Value = txtPlate.Text
            rs("TimeStart").Value = dtDateStart.Value
            rs("TimeEnd").Value = dtDateExp.Value
            rs.Update()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub delCard(ByVal code As String)
        If conServer() = False Then
            MsgBox("Please connect to server! ", vbExclamation, "Save")
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("delete from tblguest where CardCode = '" & code & "'")

        Catch ex As Exception

        End Try
    End Sub

    Sub viewAmt()

        With frmMain
            Dim AmtDue As Double = Guest_FlateRATE(dtDateStart.Value, dtDateExp.Value)
            Dim VatAmt As Double = VAT(AmtDue)
            If optInHouse.Checked = True Then
                .lblAmountDue.Text = MakeMoney(AmtDue)
                .lblVAT.Text = MakeMoney(VatAmt)
                .lblSubTotal.Text = subTotal(AmtDue, VatAmt)
                .lblTotal.Text = MakeMoney(AmtDue)
                P_TotalAmt = MakeMoney(AmtDue)
            Else
                .lblAmountDue.Text = MakeMoney(0)
                .lblVAT.Text = MakeMoney(0)
                .lblSubTotal.Text = subTotal(0, 0)
                .lblTotal.Text = MakeMoney(0)
                P_TotalAmt = MakeMoney(0)
            End If
            'intAmount(getMinMinutes, totalTime)
            .lblOvernigth.Text = MakeMoney(0)
            .lblVtype.Text = "GUEST"
            .lblPlate.Text = UCase(txtPlate.Text)
            .lblTimeIn.Text = Format(CDate(dtDateStart.Value), "yyyy-MM-dd HH:mm:00")
            .lblTimeOut.Text = Format(CDate(dtDateExp.Value), "yyyy-MM-dd 00:00:00")
            .lblTotalTime.Text = TotalTime_FUNCTION(CDate(.lblTimeIn.Text), CDate(.lblTimeOut.Text))
            .ToolTransact.Enabled = True
            '.cmdBt.Enabled = False
            '.cmdLost.Enabled = False

            PoleDisOpen()
            clear()
            displayTotal(MakeMoney(P_TotalAmt))
            PoleDisClose()

            trOpt = True
            TrLostOpt = True

            frmMain.txtTender.Enabled = True
            .txtAmtStat.Text = "TOTAL AMOUNT :"
            Me.Close()
        End With
    End Sub

    Private Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        optInHouse.Checked = True
    End Sub

    Private Sub optInHouse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles optInHouse.GotFocus
        optInHouse.Checked = True
    End Sub

    Private Sub optVIP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles optVIP.GotFocus
        optVIP.Checked = True
    End Sub
End Class