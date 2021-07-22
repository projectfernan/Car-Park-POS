Imports ADODB
Public Class frmCharging
    Public id As String

    Sub header()
        lstList.Columns.Add("Vehicle Type", 300, HorizontalAlignment.Left)
        lstList.Columns.Add("Grace Period", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Minimum Mins.", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Min. Amount", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Int. Amount", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("FlatRate", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("LostCard", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("ChargeType", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Key", 150, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblCharge")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                 viewlst = lstList.Items.Add(rs("VehicleType").Value, lup)
                viewlst.SubItems.Add(rs("GracePeriod").Value)
                viewlst.SubItems.Add(rs("MinMinutes").Value)
                viewlst.SubItems.Add(Format(Math.Round(rs("MinAmount").Value, 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("IntAmount").Value, 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("FlatRate").Value, 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("LostCard").Value, 2), "0.00"))
                viewlst.SubItems.Add(rs("ChargeType").Value)
                viewlst.SubItems.Add(rs("KeyCode").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub FindL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblCharge where " & cboCateg.Text & " like '%" & txtKeyword.Text & "%'")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("VehicleType").Value, lup)
                viewlst.SubItems.Add(rs("GracePeriod").Value)
                viewlst.SubItems.Add(rs("MinMinutes").Value)
                viewlst.SubItems.Add(Format(Math.Round(rs("MinAmount").Value, 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("IntAmount").Value, 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("FlatRate").Value, 2), "0.00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("LostCard").Value, 2), "0.00"))
                viewlst.SubItems.Add(rs("ChargeType").Value)
                viewlst.SubItems.Add(rs("KeyCode").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub edt(ByRef id As String)
        On Error Resume Next
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblCharge where VehicleType = '" & id & "'")
        If rs.EOF = False Then
            With frmAddCharging
                addChargeId = rs("VehicleType").Value()
                .cboVtype.Text = rs("VehicleType").Value()
                .txtGPeriod.Text = rs("GracePeriod").Value
                .txtMinMinutes.Text = rs("MinMinutes").Value
                .txtAmount.Text = rs("MinAmount").Value
                .txtIntAmount.Text = rs("IntAmount").Value
                .txtFlatRate.Text = rs("FlatRate").Value
                .txtLostCard.Text = rs("LostCard").Value
                .cboChargeType.Text = rs("ChargeType").Value
                .cboKey.Text = rs("KeyCode").Value
            End With
        End If
    End Sub

    Sub del()
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from tblCharge where VehicleType = '" & id & "'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete")
        End Try
    End Sub

    Sub del2()
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblCharge where VehicleType = '" & id & "'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete")
        End Try
    End Sub

    Sub clr()
        With frmAddCharging
            .cboVtype.Text = vbNullString
            .txtGPeriod.Value = 0
            .txtMinMinutes.Value = 0
            .txtAmount.Value = 0.0
            .txtIntAmount.Value = 0.0
            .txtFlatRate.Value = 0.0
            .txtLostCard.Value = 0.0
        End With
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Private Sub frmCharging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()
        If conLocal() = True Then
            fillL()
        Else
            MsgBox("Please connect to local database! ", vbExclamation, "Charging Rules")
            frmConnDB.ShowDialog()
        End If
        cmdDel.Enabled = False
        cmdEdit.Enabled = False
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmAddCharging.lblTitle.Text = "New Charging Rule"
        frmAddCharging.cboVtype.Focus()
        clr()
        frmAddCharging.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        lstList.Clear()
        header()
        If conLocal() = True Then
            fillL()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        frmAddCharging.lblTitle.Text = "Update Charging Rule"
        edt(id)
        frmAddCharging.cboVtype.Focus()
        frmAddCharging.ShowDialog()
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        cmdDel.Enabled = True
        cmdEdit.Enabled = True
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this account?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Delete") = MsgBoxResult.Yes Then
            If conLocal() = True Then
                del2()
                lstList.Clear()
                header()
                fillL()
            End If
        End If
    End Sub

    Private Sub ToolStripComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboCateg.Focus()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        lstList.Clear()
        header()
        If conLocal() = True Then
            FindL()
        End If
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            lstList.Clear()
            header()
            If conLocal() = True Then
                FindL()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmCompute.ShowDialog()
    End Sub
End Class