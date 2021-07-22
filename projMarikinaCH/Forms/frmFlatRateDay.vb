Imports ADODB
Public Class frmFlatRateDay

    Private Sub frmFlatRateDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()
        cboDay.Text = vbNullString

        fill()
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        lstList.Columns.Add("Flat Rate Day", w, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblflatday")
            txtCnt.Text = rs.RecordCount
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rs("FlatRateDay").Value, lup)
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            Save_ErrLogs("[fill] frmFlatRateDay", ex.Message)
        End Try
    End Sub

    Function chkVtype() As Boolean
        Try
            If conLocal() = False Then Return False

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblflatday where FlatRateDay = '" & cboDay.Text & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("[chkVtype] frmFlatRateDay", ex.Message)
            Return False
        End Try
    End Function

    Sub addDay()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblflatday", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("FlatRateDay").Value = cboDay.Text
            rs.Update()
        Catch ex As Exception
            Save_ErrLogs("[addDay] frmFlatRateDay", ex.Message)
        End Try
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If cboDay.Text = vbNullString Then
            MsgBox("Please select day!    ", vbExclamation, "Add")
            Exit Sub
        End If

        If chkVtype() = True Then
            MsgBox("Day already exist!    ", vbExclamation, "Add")
            cboDay.Text = vbNullString
            cboDay.Focus()
            Exit Sub
        End If

        addDay()
        lstList.Clear()
        header()
        fill()

        cboDay.Text = vbNullString
        cboDay.Focus()
    End Sub

    Sub del()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblflatday where FlatRateDay = '" & cboDay.Text & "'")
        Catch ex As Exception
            Save_ErrLogs("[del] frmFlatRateDay", ex.Message)
        End Try
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                cboDay.Text = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If cboDay.Text = vbNullString Then Exit Sub

        If MsgBox("Are you sure you do you want to delete this day?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            If conLocal() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Add")
                frmConnDB.ShowDialog()
                Exit Sub
            End If

            del()
            lstList.Clear()
            header()
            fill()
            cboDay.Text = vbNullString
        End If
    End Sub

    Private Sub cboDay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDay.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdAdd_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub cboDay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDay.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class