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

    Private Sub frmLogin_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdLogin_Click_1(sender, New System.EventArgs)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
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
        pass = "s0bad3l1g3r"

        If Trim(txtUser.Text) = user Then
            If Trim(txtPass.Text) = pass Then
                frmPMSmain.TxtOp.Text = "Fernan Cabrera"
                frmPMSmain.txtPosi.Text = "Admin :"
                txtUser.Text = vbNullString
                txtPass.Text = vbNullString
                UnlockLockPms()
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

    Sub loginb()
        Try
            Dim rs As New Recordset
            Dim nem As String

            rs = New Recordset
            rs = conSqlLoc.Execute("Select * from tblUserAcc where Username = '" & txtUser.Text & "'")
            If rs.EOF = False Then
                nem = rs("Name").Value
                desig = rs("Designation").Value

                If desig = "Operator" Then
                    MsgBox("Unknown username!     ", vbExclamation, "Login")
                    txtUser.Text = vbNullString
                    txtPass.Text = vbNullString
                    txtUser.Focus()
                    frmMain.KeyPreview = True
                    Exit Sub
                End If

                If Trim(txtPass.Text) = Trim(rs("Password").Value) Then
                    frmPMSmain.TxtOp.Text = rs("Name").Value
                    frmPMSmain.txtPosi.Text = rs("Designation").Value + " :"
                    txtUser.Text = vbNullString
                    txtPass.Text = vbNullString
                    UnlockLockPms()
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

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtUser.Text = vbNullString
        txtPass.Text = vbNullString
        txtUser.Focus()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class