Imports ADODB
Public Class frmManualTR
    Public HrToFlat As Boolean = False
    Public FlatToHr As Boolean = False
    Public ChargeFlag As Boolean = False

    Private Sub frmManualTR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdCompute_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmManualTR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            vehicleCharging(cboVtype)
            dtFrm.Value = Now
            dtTo.Value = Now
        End If
    End Sub

    Private Sub frmManualTR_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        S_Refnumber = "No Ref Number"
        S_PayType = "Manual"
        S_CouponName = ""
        S_SeniorName = ""
        ReceiptType = ""

        txtPlate.Text = vbNullString
        cboVtype.Text = vbNullString
        txtPlate.Focus()
    End Sub

    Function ChargeMode() As Boolean
        If MainForm.txtMODE.Text = "FLAT RATE" Then
            Return False
        Else
            Return True
        End If
    End Function

    Function FlatDayCheck(ByVal DayToday As String, ByVal dtstr As Date) As Boolean
        Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")
        Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")
        Dim OutCut As Date = Format(dtstr, "HH:mm:ss")

        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblflatday where FlatRateDay = '" & DayToday & "'")
            If rs.EOF = False Then
                If OutCut >= Hcut Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function FlatHolidayCheck(ByVal DayToday As String, ByVal dtstr As Date) As Boolean
        Dim Fcut As Date = Format(My.Settings.FlatCut, "HH:mm:ss")
        Dim Hcut As Date = Format(My.Settings.HourlyCut, "HH:mm:ss")
        Dim OutCut As Date = Format(dtstr, "HH:mm:ss")

        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblholidayflat where HolidayDate = '" & DayToday & "'")
            If rs.EOF = False Then
                If OutCut >= Hcut Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub ChkChargingSwitch(ByVal EntIn As Date, ByVal ExtOut As Date)
        Dim dtToadd As Date = Format(CDate(EntIn), "yyyy-MM-dd HH:mm:ss")

        Dim PetsaIn As Date
        Dim Entdt As Long
        Dim strInFrm As String = Format(CDate(EntIn), "yyyy-MM-dd")
        If MainForm.txtBussDate.Text >= strInFrm Then
            Entdt = Format(CDate(EntIn), "dd")
            PetsaIn = EntIn
        ElseIf MainForm.txtBussDate.Text < strInFrm Then
            Entdt = Format(CDate(MainForm.txtBussDate.Text), "dd")
            PetsaIn = MainForm.txtBussDate.Text & " 23:59:59"
        End If

        Dim Extdt As Long = Format(CDate(ExtOut), "dd")

        Dim entPetsa As Date = Format(EntIn, "yyyy-MM-dd")
        Dim extPetsa As Date = Format(ExtOut, "yyyy-MM-dd")

        Dim DaYdiff As Long = DateDiff(DateInterval.Day, entPetsa, extPetsa)

        Dim lup As Long


        Dim PetsaOut As Date

        PetsaOut = ExtOut

        Dim Newpetsa As Date = EntIn
        For lup = 0 To DaYdiff
            Dim day As Long
            day = day + 1
            ' dtToadd.AddDays(day)

            If Newpetsa > CDate(ExtOut) Then
                Newpetsa = CDate(ExtOut)
            Else
                Newpetsa = Newpetsa
            End If

            If FlatDayCheck(Format(Newpetsa, "dddd"), Newpetsa.ToString) = True Or FlatHolidayCheck(Format(Newpetsa, "MM-dd"), Newpetsa.ToString) = True Then
                'Dim NewPetsat As String = Format(Newpetsa, "yyyy-MM-dd " & Format(My.Settings.FlatCut, "HH:mm:ss"))
                ChargeFlag = True
            End If
            Newpetsa = PetsaIn.AddDays(day)
        Next
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Function ChkChargType(ByVal Ky As String) As Boolean
        If conLocal() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblcharge where VehicleType = '" & Ky & "'")
            If rs.EOF = False Then
                If rs("ChargeType").Value = "Coupon" Then
                    Return True
                Else
                    ReceiptType = rs("ChargeType").Value
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click

        If txtPlate.Text = vbNullString Or cboVtype.Text = vbNullString Then
            MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
            Exit Sub
        End If

        If Len(txtPlate.Text) < 6 Then
            MsgBox("Please complete the plate number! ", vbExclamation, "Plate Number")
            txtPlate.Focus()
            Exit Sub
        End If

        Dim strTimein As String = Format(dtFrm.Value, "yyyy-MM-dd HH:mm")
        Dim strTimeout As String = Format(dtTo.Value, "yyyy-MM-dd HH:mm")

        If ChkChargType(cboVtype.Text) = True Then
            Transact(cboVtype.Text, txtPlate.Text, False, False, strTimein, strTimeout)
            Me.Hide()
            Dim f As New frmRefNo
            f.ShowDialog()
            Me.Close()
        ElseIf ReceiptType = "Senior" Then
            Transact(cboVtype.Text, txtPlate.Text, False, False, strTimein, strTimeout)
            Me.Hide()
            Dim f As New frmSenior
            f.ShowDialog()
            Me.Close()
        Else
            Transact(cboVtype.Text, txtPlate.Text, False, False, strTimein, strTimeout)
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class