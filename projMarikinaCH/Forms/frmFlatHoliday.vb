Imports ADODB
Public Class frmFlatHoliday

    Private Sub frmFlatHoliday_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lstList.Clear()
        header()
        fill()
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtHoliday.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdAdd_Click(sender, New System.EventArgs)
        End If
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        lstList.Columns.Add("Holiday Flat Rate", w, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblholidayflat")
            txtCnt.Text = rs.RecordCount
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rs("HolidayDate").Value, lup)
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            Save_ErrLogs("[fill] frmFlatHoliday", ex.Message)
        End Try
    End Sub

    Function chkVtype() As Boolean
        Try
            Dim hd As String = Format(dtHoliday.Value, "MM-dd").ToString
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblholidayflat where HolidayDate = '" & hd & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Save_ErrLogs("[chkVtype] frmFlatHoliday", ex.Message)
        End Try
    End Function

    Sub addDay()
        Try
            If conLocal() = False Then Exit Sub

            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblholidayflat", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("HolidayDate").Value = Format(dtHoliday.Value, "MM-dd").ToString
            rs.Update()
        Catch ex As Exception
            Save_ErrLogs("[addDay] frmFlatHoliday", ex.Message)
        End Try
    End Sub

    Sub del()
        Try
            If conLocal() = False Then Exit Sub

            Dim hd As String = Format(dtHoliday.Value, "MM-dd").ToString
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblholidayflat where HolidayDate = '" & hd & "'")
        Catch ex As Exception
            Save_ErrLogs("[del] frmFlatHoliday", ex.Message)
        End Try
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                dtHoliday.Value = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If conLocal() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Add")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        If chkVtype() = True Then
            MsgBox("Holiday date already exist!    ", vbExclamation, "Add")
            dtHoliday.Focus()
            Exit Sub
        End If

        addDay()
        lstList.Clear()
        header()
        fill()

        dtHoliday.Focus()
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure you do you want to delete this holiday date?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
            If conLocal() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Add")
                frmConnDB.ShowDialog()
                Exit Sub
            End If

            del()
            lstList.Clear()
            header()
            fill()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class