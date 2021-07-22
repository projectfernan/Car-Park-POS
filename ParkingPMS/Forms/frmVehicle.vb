Imports ADODB
Public Class frmVehicle
    Public vid As String
    Function ids() As String
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblVehicle")
        If rs.EOF = False Then
            ids = Val(rs.RecordCount) + 1
        Else
            ids = 0
        End If
    End Function
    Function id() As String
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblVehicle")
        If rs.EOF = False Then
            id = Val(rs.RecordCount) + 1
        Else
            id = 0
        End If
    End Function

    Function chkVtypeS() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblVehicle where Vehicle = '" & txtVtype.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Function chkVtype() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblVehicle where Vehicle = '" & txtVtype.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub addS()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblVehicle", conSqlPOS, 1, 2)
        rs.AddNew()
        rs("Id").Value = id()
        rs("Vehicle").Value = UCase(txtVtype.Text)
        rs.Update()
    End Sub

    Sub add()
        If conLocal() = False Then Exit Sub
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblVehicle", conSqlLoc, 1, 2)
        rs.AddNew()
        rs("Vehicle").Value = UCase(txtVtype.Text)
        rs.Update()
    End Sub

    Sub delS()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("delete from tblVehicle where vehicle = '" & txtVtype.Text & "'")
    End Sub

    Sub del()
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("delete from tblVehicle where vehicle = '" & txtVtype.Text & "'")
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                vid = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Sub slctRecS()
        If frmMain.dbstat2.Text = "Connected" Then
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from tblVehicle where Vehicle = '" & vid & "'")
            If rs.EOF = False Then
                txtVtype.Text = rs("Vehicle").Value
            End If
        Else
            MsgBox("Please connect to localhost!    ", vbExclamation)
            frmConnDB.ShowDialog()
        End If
    End Sub

    Sub slctRec()
        If conLocal() = True Then
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblVehicle where Vehicle = '" & vid & "'")
            If rs.EOF = False Then
                txtVtype.Text = rs("Vehicle").Value
            End If
        Else
            MsgBox("Please connect to localhost!    ", vbExclamation)
            frmConnDB.ShowDialog()
        End If
    End Sub

    Sub header()
        lstList.Columns.Add("Vehicle Type", 300, HorizontalAlignment.Left)
    End Sub

    Sub fillS()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblVehicle")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Vehicle").Value, lup)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblVehicle")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Vehicle").Value, lup)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Try
            If txtVtype.Text = vbNullString Then
                MsgBox("Please type vehicle type!    ", vbExclamation, "Add")
                Exit Sub
            End If

            If chkVtype() = True Then
                MsgBox("Vehicle already exist!    ", vbExclamation, "Add")
                txtVtype.Text = vbNullString
                txtVtype.Focus()
                Exit Sub
            End If
            add()
            lstList.Clear()
            header()
            fill()
            txtVtype.Text = vbNullString
            txtVtype.Focus()
        Catch
            MsgBox("Please connect to database!    ", vbExclamation, "Add")
            frmConnDB.ShowDialog()
        End Try

    End Sub

    Private Sub frmVehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
            Try
                lstList.Clear()
                header()
                fill()
            Catch
                MsgBox("Please connect to database!    ", vbExclamation, "Add")
                frmConnDB.ShowDialog()
            End Try

        cmdDel.Enabled = False
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        slctRec()
        cmdDel.Enabled = True
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Try
            If MsgBox("Are you sure you do you want to delete this record?    ", vbQuestion + vbYesNo + vbDefaultButton2, "Delete") = vbYes Then
                del()
                lstList.Clear()
                header()
                fill()
                txtVtype.Text = vbNullString
            End If
        Catch
            MsgBox("Please connect to database!    ", vbExclamation, "Add")
            frmConnDB.ShowDialog()
        End Try

    End Sub

    Private Sub txtVtype_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cmdAdd_Click(sender, New System.EventArgs)
        End If
    End Sub

End Class