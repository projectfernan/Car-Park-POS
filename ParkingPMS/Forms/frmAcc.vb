Imports ADODB
Public Class frmAcc
    Public id As String
    Private Sub frmAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()

        If conLocal() = True Then
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If

        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width / 3
        lstList.Columns.Add("Username", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Name", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Designation", w, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblUseracc")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblUseracc")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub Findfill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblUseracc where " & cboCateg.Text & " like '" & txtinput.Text & "'")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmAddAcc.lblTitle.Text = "New Account"
        clr()
        frmAddAcc.txtUser.Focus()
        frmAddAcc.txtUser.ReadOnly = False
        frmAddAcc.txtUser.Focus()
        frmAddAcc.ShowDialog()
    End Sub

    Sub clr()
        With frmAddAcc
            .txtUser.Text = vbNullString
            .txtPass.Text = vbNullString
            .txtConfirm.Text = vbNullString
            .txtname.Text = vbNullString
            .cboDesig.Text = vbNullString
        End With
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Sub edt(ByRef id As String)
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblUserAcc where username = '" & id & "'")
        If rs.EOF = False Then
            With frmAddAcc
                .txtUser.Text = rs("Username").Value
                .txtPass.Text = rs("Password").Value
                .txtConfirm.Text = rs("Password").Value
                .txtname.Text = rs("Name").Value
                .cboDesig.Text = rs("Designation").Value
            End With
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        With frmAddAcc
            .lblTitle.Text = "Update Account"
            edt(id)
            .txtUser.Focus()
            .txtUser.ReadOnly = True
            .ShowDialog()
        End With
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        cmdEdit.Enabled = True
        cmdDel.Enabled = True
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                id = viewlst.SubItems(0).Text
            End If
        Next
    End Sub
    Sub del()
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from tblUserAcc where Username = '" & id & "'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete")
        End Try
    End Sub

    Sub del2()
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblUserAcc where Username = '" & id & "'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Delete")
        End Try
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If conLocal() = False Then Exit Sub

        If MsgBox("Are you sure do you want to delete this account?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Delete") = MsgBoxResult.Yes Then

            del2()
            lstList.Clear()
            header()
            fillL()
        End If

    End Sub

    Private Sub cboCateg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub txtinput_TextChanged(sender As Object, e As System.EventArgs) Handles txtinput.TextChanged
        If conLocal() = True Then
            lstList.Clear()
            header()
            Findfill()
        End If
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        lstList.Clear()
        header()

        If conLocal() = True Then
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If

        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub
End Class