Imports ADODB
Public Class frmRefNo

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = MainForm.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmRefNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDocNo.Text = vbNullString Then
                MessageBox.Show("Please complete all details required!", "Senior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDocNo.Focus()
                Exit Sub
            End If


            S_Refnumber = txtDocNo.Text
            '  If chkRefNum(S_Refnumber) = True Then Exit Sub
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            S_Refnumber = ""
            PD_Welcome()
            kansela()
            Me.Close()
        End If
    End Sub

    Private Sub frmRefNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()
    End Sub

    Private Sub frmRefNo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtDocNo.Text = vbNullString
    End Sub

    Function chkRefNum(ByVal refnum As String) As Boolean
        Try
            If conServer() = False Then
                MsgBox("Failed to connect to server!", vbExclamation, "Reference number")
                Return False
            End If

            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("select RefNum from tblincomereport where Refnum = '" & refnum & "';")
            If rs.EOF = False Then
                MsgBox("Document number is already used! ", vbExclamation, "Reference number")
                txtDocNo.Text = vbNullString
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("[chkRefNum] frmRefNo", ex.Message)
        End Try
    End Function

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click

        S_Refnumber = txtDocNo.Text

        If chkRefNum(S_Refnumber) = True Then Exit Sub

        Me.Close()
    End Sub

    Private Sub txtDocNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        


    End Sub

    Private Sub txtDocNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                txtDocNo.Focus()
            Case 33 To 44
                e.KeyChar = vbNullString
            Case 46 To 47
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