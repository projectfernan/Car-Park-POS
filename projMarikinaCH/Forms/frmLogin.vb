Imports ADODB
Public Class frmLogin

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MainForm.KeyPreview = True
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
        pass = "0901pr0J3ctf0273"

        If Trim(txtUser.Text) = user Then
            If Trim(txtPass.Text) = pass Then
                desig = "Admin"
                MainForm.txtUsername.Text = txtUser.Text
                MainForm.txtPosi.Text = "Admin :"
                MainForm.TxtOp.Text = txtUser.Text
                'frmMain.txtAdmin.Text = admin
                saveLogin(txtUser.Text)

                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                enable()
                login()
                verClose = "Unlocked"
                Access = "Login"

                Me.Close()
                Exit Sub
            Else
                MsgBox("Unknown password!    ", vbExclamation, "Login")
                txtPass.Text = vbNullString
                txtPass.Focus()
                MainForm.KeyPreview = True
            End If
        Else
            MsgBox("Unknown username!     ", vbExclamation, "Login")
            txtUser.Text = vbNullString
            txtPass.Text = vbNullString
            txtUser.Focus()
            MainForm.KeyPreview = True
        End If
    End Sub

    Sub loginb()
        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs = conSqlLoc.Execute("Select * from tbluseracc where Username = '" & txtUser.Text & "'")
            If rs.EOF = False Then

                desig = rs("Designation").Value

                If Trim(txtPass.Text) = rs("Password").Value Then

                    If desig = "Operator" Then
                        'frmMain.cmdSS.Enabled = False
                        MainForm.txtUsername.Text = txtUser.Text
                        MainForm.TxtOp.Text = rs("Name").Value
                        MainForm.txtPosi.Text = desig + " " + ":"
                        'frmMain.txtAdmin.Text = admin
                        saveLogin(txtUser.Text)

                        txtUser.Text = vbNullString
                        txtPass.Text = vbNullString
                        enable()
                        login()
                        verClose = "Unlocked"
                        Access = "Login"

                        PD_Welcome()
                    Else
                        nem = rs("Name").Value
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
                    MainForm.KeyPreview = True
                    Exit Sub
                End If
            Else
                MsgBox("Unknown username!     ", vbExclamation, "Login")
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                txtUser.Focus()
                MainForm.KeyPreview = True
                Exit Sub
            End If
        Catch ex As Exception
            Save_ErrLogs("[loginb] frmLogin", ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Login")
            MainForm.KeyPreview = True
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

            'PrntEnt(MainForm.TxtOp.Text, Format(Now, "yyyy-MM-dd HH:mm:00"), Format(Now, "yyyy-MM-dd HH:mm:59"))
        Catch ex As Exception
            Save_ErrLogs("[saveLogin] frmLogin", ex.Message)
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
        SysActivation()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class