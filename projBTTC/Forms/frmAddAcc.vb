Imports ADODB
Public Class frmAddAcc

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblUserAcc", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("Username").Value = txtUser.Text
            rs("Password").Value = txtPass.Text
            rs("Password").Value = txtConfirm.Text
            rs("Name").Value = txtname.Text
            rs("Designation").Value = cboDesig.Text
            rs.Update()
            MsgBox("New account saved!    ", MsgBoxStyle.Information, "Save")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Save")
        End Try
    End Sub

    Sub EditL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblUserAcc where username = '" & txtUser.Text & "'", conSqlLoc, 1, 2)
            rs("Password").Value = txtPass.Text
            rs("Password").Value = txtConfirm.Text
            rs("Name").Value = txtname.Text
            rs("Designation").Value = cboDesig.Text
            rs.Update()
            MsgBox("Account updated!    ", MsgBoxStyle.Information, "Update")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Update")
        End Try
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Function fernan() As Boolean
        If Trim(txtUser.Text) = "fernan" Then
            Return True
        Else
            Return False
        End If
    End Function

    Function UserVerL() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblUserAcc where username = '" & Trim(txtUser.Text) & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub clir()
        txtUser.Text = vbNullString
        txtPass.Text = vbNullString
        txtConfirm.Text = vbNullString
        txtName.Text = vbNullString
        cboDesig.Text = vbNullString
    End Sub

    Function Scanblank() As Boolean
        If txtUser.Text = vbNullString Or txtPass.Text = vbNullString Or txtConfirm.Text = vbNullString Or cboDesig.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Scanblank() = True Then
            MsgBox("Please fill up the blanks!    ", vbExclamation, "Save")
            Exit Sub
        End If

        If fernan() = True Then
            MsgBox("Username already exist!    ", vbExclamation, "Save")
            clir()
            txtUser.Focus()
            Exit Sub
        End If

        If lblTitle.Text = "New Account" Then
            If MsgBox("Are you sure your entries are correct?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Save") = MsgBoxResult.Yes Then
                If conLocal() = True Then
                    If UserVerL() = True Then
                        MsgBox("Username already exist!    ", vbExclamation, "Save")
                        clir()
                        txtUser.Focus()
                        Exit Sub
                    End If

                    saveL()
                    Me.Close()
                Else
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                End If
            End If
        Else
            If MsgBox("Are you sure do you want to save changes?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Save") = MsgBoxResult.Yes Then
                
                If UserVerL() = True Then
                    If txtPass.Text = txtConfirm.Text Then
                        EditL()
                    Else
                        MsgBox("Password did not match!    ", MsgBoxStyle.Exclamation, "Update")
                        txtPass.Text = vbNullString
                        txtConfirm.Text = vbNullString
                        txtPass.Focus()
                    End If
                Else
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                End If
                Me.Close()
            End If
        End If

    End Sub
    Sub header()
        Dim w As Integer = frmAcc.lstList.Width / 3
        frmAcc.lstList.Columns.Add("Username", w, HorizontalAlignment.Left)
        frmAcc.lstList.Columns.Add("Name", w, HorizontalAlignment.Left)
        frmAcc.lstList.Columns.Add("Designation", w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblUseracc")
        frmAcc.txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                frmAcc.lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = frmAcc.lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub frmAddAcc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmAcc.lstList.Clear()
        header()
        If conLocal() = True Then
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub cboDesig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDesig.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdSave_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub cboDesig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDesig.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboDesig.Focus()
        End If
    End Sub

    Private Sub frmAddAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class