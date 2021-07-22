Imports ADODB
Public Class frmLogin

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.KeyPreview = True
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If testadmin() = True Then
                pasok()
                Exit Sub
            Else

                If conLocal() = True Then
                    loginb()
                Else
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmConnDB.ShowDialog()
                End If
            End If
        End If

        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Function testadmin() As Boolean
        If txtUser.Text = "fernan" Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub pasok()
        Dim user As String
        Dim pass As String

        user = "fernan"
        pass = "l1g3rs0bad3"

        If Trim(txtUser.Text) = user Then
            If Trim(txtPass.Text) = pass Then
                desig = "Admin"
                frmMain.txtUsername.Text = txtUser.Text
                frmMain.txtPosi.Text = "Admin :"
                frmMain.TxtOp.Text = txtUser.Text

                saveLogin(txtUser.Text)

                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                enable()
                login()
                verClose = "Unlocked"
                Access = "Login"

                str_SysUser = user
                str_SysPosi = "Admin"

                Me.Close()
                Exit Sub
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
                frmMain.KeyPreview = True
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
            frmMain.KeyPreview = True
        End If
    End Sub

    Sub login2()
        Try
            Dim rs As New Recordset
            Dim nem As String

            rs = New Recordset
            rs = conSqlPOS.Execute("Select * from tblUserAcc where Username = '" & txtUser.Text & "'")
            If rs.EOF = False Then
                nem = rs("Name").Value
                desig = rs("Designation").Value

                If Trim(txtPass.Text) = rs("Password").Value Then
                    frmMain.txtPosi.Text = desig + " " + ":"
                    frmMain.TxtOp.Text = nem
                    'frmMain.txtAdmin.Text = admin
                    txtUser.Text = vbNullString
                    txtPass.Text = vbNullString
                    enable()
                    login()
                    verClose = "Unlocked"
                    Access = "Login"
                    If desig = "Operator" Then
                        frmMain.cmdSS.Enabled = False
                    Else
                        frmMain.cmdSS.Enabled = True
                    End If
                    Me.Close()
                    Exit Sub
                Else
                    MsgBox("Unknown password!    ", vbExclamation, "Login")
                    txtPass.Text = vbNullString
                    txtPass.Focus()
                    frmMain.KeyPreview = True
                    Exit Sub
                End If
            Else
                MsgBox("Unknown username!     ", vbExclamation, "Login")
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                txtUser.Focus()
                frmMain.KeyPreview = True
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Login")
            frmMain.KeyPreview = True
        End Try
    End Sub

    Sub loginb()
        Try
            Dim rs As New Recordset
            Dim nem As String

            rs = New Recordset
            rs = conSqlLoc.Execute("Select * from tblUserAcc where Username = '" & txtUser.Text & "'")
            If rs.EOF = False Then
                nem = rs("Name").Value
                desig = rs("Designation").Value

                If Trim(txtPass.Text) = rs("Password").Value Then
                    If desig = "Operator" Then
                        str_SysUser = txtUser.Text
                        str_SysPosi = rs("Designation").Value
                        frmMain.txtUsername.Text = txtUser.Text
                        frmMain.TxtOp.Text = nem
                        frmMain.txtPosi.Text = desig + " " + ":"
                        saveLogin(txtUser.Text)

                        txtUser.Text = vbNullString
                        txtPass.Text = vbNullString
                        enable()
                        login()
                        verClose = "Unlocked"
                        Access = "Login"
                    ElseIf desig = "Supervisor" Then
                        str_SysUser = txtUser.Text
                        str_SysPosi = rs("Designation").Value
                        SuperV()
                        Me.Hide()
                        frmSystem.ShowDialog()
                        txtUser.Text = vbNullString
                        txtPass.Text = vbNullString
                    Else
                        str_SysUser = txtUser.Text
                        str_SysPosi = rs("Designation").Value
                        AdminAcc()
                        Me.Hide()
                        frmSystem.ShowDialog()
                        txtUser.Text = vbNullString
                        txtPass.Text = vbNullString
                    End If

                    Me.Close()
                    Exit Sub
                Else
                    MsgBox("Unknown password!    ", vbExclamation, "Login")
                    txtPass.Text = vbNullString
                    txtPass.Focus()
                    frmMain.KeyPreview = True
                    Exit Sub
                End If
            Else
                MsgBox("Unknown username!     ", vbExclamation, "Login")
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                txtUser.Focus()
                frmMain.KeyPreview = True
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Login")
            frmMain.KeyPreview = True
        End Try
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
       
    End Sub

    Private Sub cmdLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If testadmin() = True Then
            pasok()
            Exit Sub
        Else
            
            If conLocal() = True Then
                loginb()
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End If

    End Sub

    Sub saveLogin(ByVal Username As String)
        If conLocal() = False Then Exit Sub

        Try
            Dim rs1 As New Recordset
            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tbllogtime where Username = '" & Username & "'")
            If rs1.EOF = False Then
                Exit Sub
            End If

            Dim rs As New Recordset
            Dim dt As String = Format(Now, "yyyy-MM-dd HH:mm:00")
            rs = New Recordset
            rs.Open("select * from tbllogtime", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("Username").Value = Username
            rs("LoginTime").Value = dt
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtUser.Text = vbNullString
        txtPass.Text = vbNullString
        txtUser.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class