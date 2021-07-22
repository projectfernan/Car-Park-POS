Public Class ErrLogs

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboFindType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboFindType.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FindLogs()
    End Sub

    Sub FindLogs()
        Dim DateFrm As String = Format(dtFrm.Value, "yyyy'/'MM'/'dd HH:mm")
        Dim DateTo As String = Format(dtTo.Value, "yyyy'/'MM'/'dd HH:mm")

        Dim QueryWOdate As String = "select TimeStamp,Thread,Error from tblErrLogs where " & cboCateg.Text & " like '%" & txtKeyCode.Text & "%' order by TimeStamp desc"
        Dim QueryWdate As String = "select TimeStamp,Thread,Error from tblErrLogs where " & cboCateg.Text & " like '%" & txtKeyCode.Text & "%' and " & _
                                   "TimeStamp BETWEEN #" & DateFrm & "# AND #" & DateTo & "# order by TimeStamp desc"

        Select Case cboFindType.Text
            Case "Category Only"
                If LoadDgvData(dgErrRec, QueryWOdate, True) = False Then
                    MessageBox.Show("Failed to find logs!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Case "Date Range"
                If LoadDgvData(dgErrRec, QueryWdate, True) = False Then
                    MessageBox.Show("Failed to find logs!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
        End Select
    End Sub
End Class