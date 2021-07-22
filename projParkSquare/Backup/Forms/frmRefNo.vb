Imports ADODB
Public Class frmRefNo

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub frmRefNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub frmRefNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()
    End Sub

    Private Sub frmRefNo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtDocNo.Text = vbNullString
    End Sub

    Function chkRefNum(ByVal refnum As String) As Boolean
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

    End Function

    Private Sub cmdAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccept.Click

        S_Refnumber = txtDocNo.Text

        If chkRefNum(S_Refnumber) = True Then Exit Sub

        Me.Close()
    End Sub

    Private Sub txtDocNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            S_Refnumber = txtDocNo.Text

            '  If chkRefNum(S_Refnumber) = True Then Exit Sub

            Me.Close()
        End If
    End Sub

    Private Sub txtDocNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDocNo.TextChanged

    End Sub
End Class