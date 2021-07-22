Imports ADODB
Public Class frmFlatRate
    Public vid As String
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub disableCMD()
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
    End Sub

    Sub enableCMD()
        cmdEdit.Enabled = True
        cmdDel.Enabled = True
    End Sub

    Sub disableData()
        cboVtype.Enabled = False
        txtAmount.Enabled = False
    End Sub

    Sub enableData()
        cboVtype.Enabled = True
        txtAmount.Enabled = True
    End Sub

    Sub clean()
        cboVtype.Text = vbNullString
        txtAmount.Value = 0.0
    End Sub

    Sub header()
        lstList.Columns.Add("Vehicle Type", 225, HorizontalAlignment.Left)
        lstList.Columns.Add("Flat Rate", 225, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblFlatRate")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Vtype").Value, lup)
                viewlst.SubItems.Add(Format(Math.Round(rs("FlatRate").Value, 2), ".00"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblFlatRate")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Vtype").Value, lup)
                viewlst.SubItems.Add(Format(Math.Round(rs("FlatRate").Value, 2), ".00"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub frmFlatRate_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub frmFlatRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        disableCMD()
        disableData()
        If frmMain.dbstat2.Text = "Connected" Then
            vtypL(cboVtype)
            lstList.Clear()
            header()
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Hourly Rate")
            frmConnDB.ShowDialog()
        End If
    End Sub


    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                vid = viewlst.SubItems(0).Text
            End If
        Next
    End Sub

    Sub slctRec()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from tblFlatRate where Vtype = '" & vid & "'")
            If rs.EOF = False Then
                cboVtype.Text = rs("VType").Value
                txtAmount.Value = rs("FlatRate").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Flat Rate")
        End Try

    End Sub

    Sub slctRecL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblFlatRate where Vtype = '" & vid & "'")
            If rs.EOF = False Then
                cboVtype.Text = rs("VType").Value
                txtAmount.Value = rs("FlatRate").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Flat Rate")
        End Try
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        If frmMain.dbstat2.Text = "Connected" Then
            slctRecL()
            cmdEdit.Enabled = True
            cmdDel.Enabled = True
            disableData()
            cmdAdd.Text = "&Add"
            cmdEdit.Text = "&Edit"
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Hourly Rate")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Function VerType() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from tblFlatRate where VType = '" & cboVtype.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Function VerTypeL() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblFlatRate where VType = '" & cboVtype.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub save()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblFlatRate", conSqlPOS, 1, 2)
            rs.AddNew()
            rs("VType").Value = cboVtype.Text
            rs("FlatRate").Value = txtAmount.Value
            rs.Update()
            MsgBox("New flat rate added!    ", vbInformation, "Save")
            clean()
            disableData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblFlatRate", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("VType").Value = cboVtype.Text
            rs("FlatRate").Value = txtAmount.Value
            rs.Update()
            MsgBox("New flat rate added!    ", vbInformation, "Save")
            clean()
            disableData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub edit()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblFlatRate where VType = '" & cboVtype.Text & "'", conSqlPOS, 1, 2)
            rs("FlatRate").Value = txtAmount.Value
            rs.Update()
            MsgBox("Flat rate successfully updated!    ", vbInformation, "Update")
            clean()
            disableData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try
    End Sub

    Sub editL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblFlatRate where VType = '" & cboVtype.Text & "'", conSqlLoc, 1, 2)
            rs("FlatRate").Value = txtAmount.Value
            rs.Update()
            MsgBox("Flat rate successfully updated!    ", vbInformation, "Update")
            clean()
            disableData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        If frmMain.dbstat2.Text = "Connected" Then

            If cmdAdd.Text = "&Add" Then
                clean()
                enableData()
                cboVtype.Focus()
                cmdAdd.Text = "&Save"
            Else
                If cboVtype.Text = vbNullString Then
                    MsgBox("Please select vehicle type!    ", vbExclamation, "Save")
                    cboVtype.Focus()
                    Exit Sub
                End If
                If VerTypeL() = True Then
                    MsgBox("Vehicle type already exist!    ", vbExclamation, "Save")
                    cboVtype.Text = vbNullString
                    Exit Sub
                End If
                saveL()
                lstList.Clear()
                header()
                fillL()
                cmdAdd.Text = "&Add"
            End If

        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Hourly Rate")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdDel.Enabled = False
        If frmMain.dbstat2.Text = "Connected" Then
            If cmdEdit.Text = "&Edit" Then
                enableData()
                cboVtype.Enabled = False
                txtAmount.Focus()
                cmdEdit.Text = "&Update"
            Else
                editL()
                lstList.Clear()
                header()
                fillL()
                cmdEdit.Text = "&Edit"
            End If
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Hourly Rate")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        disableCMD()
        disableData()
        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub del()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from tblFlatRate where Vtype = '" & cboVtype.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Sub delL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblFlatRate where Vtype = '" & cboVtype.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
            If frmMain.dbstat2.Text = "Connected" Then
                delL()
                lstList.Clear()
                header()
                fillL()
            End If
        End If
    End Sub
End Class