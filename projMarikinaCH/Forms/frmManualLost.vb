Imports ADODB
Public Class frmManualLost

    Function LostCharge(ByVal vehicle As String) As Double
        If conLocal() = False Then Return 0

        Dim rs As New Recordset

        rs = New Recordset
        rs = conSqlLoc.Execute("select LostCard from tblCharge where VehicleType = '" & vehicle & "'")
        If rs.EOF = False Then
            Dim lostC As Double = rs("LostCard").Value
            Return lostC
        Else
            Return 0
        End If
    End Function

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        If txtPlate.Text = vbNullString Or cboVtype.Text = vbNullString Then
            MsgBox("Please complete the transaction details! ", vbExclamation, "Transact")
            Exit Sub
        End If

        If Len(txtPlate.Text) >= 6 Then
        Else
            MsgBox("Please complete the plate number! ", vbExclamation, "Plate Number")
            txtPlate.Focus()
            Exit Sub
        End If

        'ManualLost()
        Transact(cboVtype.Text, txtPlate.Text, False, True, Now, Now)

        If ChkChargType(cboVtype.Text) = True Then
            Me.Hide()
            Dim f As New frmRefNo
            f.ShowDialog()
            Me.Close()
        ElseIf ReceiptType = "Senior" Then
            Me.Hide()
            Dim f As New frmSenior
            f.ShowDialog()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmManualLost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdGo_Click(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
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

    Private Sub frmManualLost_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If conLocal() = True Then
            vehicleCharging(cboVtype)
        End If
    End Sub

    Private Sub frmManualLost_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        S_Refnumber = "No Ref Number"
        S_PayType = "Regular"

        txtPlate.Text = vbNullString
        cboVtype.Text = vbNullString
        cboVtype.Focus()
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
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