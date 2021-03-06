Imports ADODB
Public Class frmSetPOS

    Private Sub frmSetPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewPOSset()
        txtSlot.Text = viewSlot()
    End Sub

    Sub save()
        With My.Settings
            .TITLE = txtTitle.Text
            .ADDR = txtAdd.Text
            .CONTACT = txtContact.Text
            .TIN = txtTin.Text
            .PERMIT = txtPermit.Text
            .SERIAL = txtSerial.Text
            .MACHINE = txtMachine.Text
            .ACCR = txtAccr.Text
            .STATION = cboStation.Text
            .SLOT = txtSlot.Text
            .MODE = cboMode.Text
            .Save()
        End With
    End Sub
    Sub delSlot()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("delete from parkingslot", conSqlPOS, 1, 2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Set POS")
        End Try
    End Sub

    Sub saveSlot()
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from parkingslot", conSqlPOS, 1, 2)
            rs("TOTAL").Value = txtSlot.Text
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Set POS")
        End Try
    End Sub

    Private Sub cboStation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStation.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        saveSlot()
        MsgBox("POS successfully set!    ", MsgBoxStyle.Information, "Set POS")
        viewPOSset()
        Me.Close()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cboMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMode.KeyDown
        If e.KeyCode = Keys.Enter Then
            save()
            saveSlot()
            MsgBox("POS successfully set!    ", MsgBoxStyle.Information, "Set POS")
            viewPOSset()
            Me.Close()
        End If
    End Sub

    Private Sub cboMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboMode.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtSlot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSlot.KeyPress
        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
        If Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = vbNullString
        End If
    End Sub

End Class