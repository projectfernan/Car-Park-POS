Imports ADODB
Public Class frmAddCharging

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub
    Function getId() As String
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblCharge")
        getId = rs.RecordCount + 1
    End Function
    Function getId2() As String
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblCharge")
        getId2 = rs.RecordCount + 1
    End Function

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblcharge", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("VehicleType").Value = cboVtype.Text
            rs("GracePeriod").Value = txtGPeriod.Value
            rs("MinMinutes").Value = txtMinMinutes.Value
            rs("MinAmount").Value = txtAmount.Value
            rs("IntAmount").Value = txtintAmount.Value
            rs("FlatRate").Value = txtFlatRate.Value
            rs("LostCard").Value = txtLostCard.Value
            rs("KeyCode").Value = cboKey.Text
            rs("ChargeType").Value = cboChargeType.Text
            rs.Update()

            MsgBox("New Charging rule saved!    ", MsgBoxStyle.Information, "Save")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Save")
        End Try
    End Sub

    Sub editL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblcharge where VehicleType = '" & addChargeId & "'", conSqlLoc, 1, 2)
            rs("GracePeriod").Value = txtGPeriod.Value
            rs("MinMinutes").Value = txtMinMinutes.Value
            rs("MinAmount").Value = txtAmount.Value
            rs("IntAmount").Value = txtIntAmount.Value
            rs("FlatRate").Value = txtFlatRate.Value
            rs("LostCard").Value = txtLostCard.Value
            rs("KeyCode").Value = cboKey.Text
            rs("ChargeType").Value = cboChargeType.Text
            rs.Update()

            MsgBox("Charging rule updated!    ", MsgBoxStyle.Information, "Update")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Update")
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If lblTitle.Text = "New Charging Rule" Then
            If MsgBox("Are you sure your entries are correct?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Save") = MsgBoxResult.Yes Then
                If conLocal() = True Then
                    saveL()
                Else
                    MsgBox("Please connect to local database! ", vbExclamation, "Save")
                    frmConnDB.ShowDialog()
                End If
            End If
        Else
            If MsgBox("Are you sure do you want to save changes?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Save") = MsgBoxResult.Yes Then
                If conLocal() = True Then
                    editL()
                End If
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddCharging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conLocal() = True Then
            vtypL(cboVtype)
        End If
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboKey.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboChargeType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboChargeType.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

End Class