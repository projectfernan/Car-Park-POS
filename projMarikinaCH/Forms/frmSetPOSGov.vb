Imports ADODB
Public Class frmSetPOSGov

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSetPOSGov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewSet()
        lstList.Clear()
        header()
        fillL()

        chkDesktop.Checked = My.Settings.DesktopLock
        chkDataPool.Checked = My.Settings.DataPool
        chkPing.Checked = My.Settings.ServerPing

        txtRegulation.Enabled = False
    End Sub

    Sub viewSet()
        With My.Settings
            txtTitle.Text = .TITLE
            txtOperatedBy.Text = .N_OperatedBy
            cboStation.Text = .STATION
            cboChargeState.Text = .MODE
            txtSlot.Value = viewSlot()
        End With
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        lstList.Columns.Add("Regulation List", w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSqlLoc.Execute("select Regulation from tblreceiptreg")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rs("Regulation").Value, lup)
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            Save_ErrLogs("[fillL] frmSetPOSGov", ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveSet()
        saveSlot(txtSlot.Value)

        MainForm.txtTotalSlot.Text = viewSlot().ToString
        MainForm.txtSlot.Text = slot().ToString

        MessageBox.Show("POS successfully set!", "Set POS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Sub saveSet()
        With My.Settings
            .TITLE = txtTitle.Text
            .N_OperatedBy = txtOperatedBy.Text
            .STATION = cboStation.Text
            .SLOT = txtSlot.Text
            .MODE = cboChargeState.Text
            .Save()
        End With
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Select Case cmdAdd.Text
            Case "&Add"
                txtRegulation.Enabled = True
                txtRegulation.Focus()
                cmdAdd.Text = "&Save"
            Case "&Save"
                If MsgBox("Are your sure your entries are correct?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Add Regulation") = vbYes Then
                    AddReg()

                    lstList.Clear()
                    header()
                    fillL()
                End If
        End Select
    End Sub

    Sub AddReg()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("insert into tblreceiptreg(Regulation)Values('" & txtRegulation.Text & "')")
            txtRegulation.Text = vbNullString
            txtRegulation.Enabled = False

            cmdAdd.Text = "&Add"
        Catch ex As Exception
            Save_ErrLogs("[AddReg] frmSetPOSGov", ex.Message)
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkDataPool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDataPool.CheckedChanged
        My.Settings.DataPool = chkDataPool.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkPing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPing.CheckedChanged
        My.Settings.ServerPing = chkPing.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkDesktop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDesktop.CheckedChanged
        My.Settings.DesktopLock = chkDesktop.Checked
        My.Settings.Save()
    End Sub

    Private Sub cboStation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboStation.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboChargeState_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboChargeState.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboChargeState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboChargeState.SelectedIndexChanged

    End Sub
End Class