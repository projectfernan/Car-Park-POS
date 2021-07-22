Imports ADODB
Public Class frmFlatHoliday

    Private Sub frmFlatHoliday_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lstList.Clear()
        header()

        If conLocal() = False Then Exit Sub
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
        On Error Resume Next
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
    End Sub

    Function chkVtype() As Boolean
        Dim hd As String = Format(dtHoliday.Value, "MM-dd").ToString
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblholidayflat where HolidayDate = '" & hd & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub addDay()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblholidayflat", conSqlLoc, 1, 2)
        rs.AddNew()
        rs("HolidayDate").Value = Format(dtHoliday.Value, "MM-dd").ToString
        rs.Update()
    End Sub

    Sub del()
        Dim hd As String = Format(dtHoliday.Value, "MM-dd").ToString
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("delete from tblholidayflat where HolidayDate = '" & hd & "'")
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

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub
End Class