Imports ADODB
Public Class frmHourly
    Public vid As String

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmHourly_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        cmdADd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub frmHourly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMain.dbstat2.Text = "Connected" Then
            vtypL(cboVtype)
            lstList.Clear()
            header()
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Hourly Rate")
            frmConnDB.ShowDialog()
        End If
        disable()
        cmdDel.Enabled = False
        cmdEdit.Enabled = False
    End Sub

    Private Sub cboVtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboVtype.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Sub header()
        lstList.Columns.Add("Vehicle Type", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("Grace Period", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("Minimum Minutes", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Minimum Amount", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Interval Amount", 150, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from HourlyDb")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Type").Value, lup)
                viewlst.SubItems.Add(rs("GracePeriod").Value)
                viewlst.SubItems.Add(rs("FirstMin").Value)
                viewlst.SubItems.Add(Format(Math.Round(rs("FirstAmount").Value, 2), ".00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("IntAmount").Value, 2), ".00"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from HourlyDb")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Type").Value, lup)
                viewlst.SubItems.Add(rs("GracePeriod").Value)
                viewlst.SubItems.Add(rs("FirstMin").Value)
                viewlst.SubItems.Add(Format(Math.Round(rs("FirstAmount").Value, 2), ".00"))
                viewlst.SubItems.Add(Format(Math.Round(rs("IntAmount").Value, 2), ".00"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub disable()
        cboVtype.Enabled = False
        txtGPeriod.Enabled = False
        txtMinMinutes.Enabled = False
        txtAmount.Enabled = False
        txtIterval.Enabled = False
    End Sub

    Sub enable()
        cboVtype.Enabled = True
        txtGPeriod.Enabled = True
        txtMinMinutes.Enabled = True
        txtAmount.Enabled = True
        txtIterval.Enabled = True
    End Sub

    Sub clean()
        cboVtype.Text = vbNullString
        txtGPeriod.Value = 0
        txtMinMinutes.Value = 0
        txtAmount.Value = 0.0
        txtIterval.Value = 0.0
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
            rs = conSqlPOS.Execute("select * from HourlyDb where type = '" & vid & "'")
            If rs.EOF = False Then
                cboVtype.Text = rs("Type").Value
                txtGPeriod.Value = rs("GracePeriod").Value
                txtMinMinutes.Value = rs("FirstMin").Value
                txtAmount.Value = rs("FirstAmount").Value
                txtIterval.Value = rs("IntAmount").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Hourly Rate")
        End Try

    End Sub

    Sub slctRecL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from HourlyDb where Type = '" & vid & "'")
            If rs.EOF = False Then
                cboVtype.Text = rs("Type").Value
                txtGPeriod.Value = rs("GracePeriod").Value
                txtMinMinutes.Value = rs("FirstMin").Value
                txtAmount.Value = rs("FirstAmount").Value
                txtIterval.Value = rs("IntAmount").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Hourly Rate")
        End Try
    End Sub

    Function VerType() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from Hourlydb where Type = '" & cboVtype.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Function VerTypeL() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from Hourlydb where Type = '" & cboVtype.Text & "'")
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
            rs.Open("select * from HourlyDB", conSqlPOS, 1, 2)
            rs.AddNew()
            rs("Type").Value = cboVtype.Text
            rs("GracePeriod").Value = txtGPeriod.Value
            rs("FirstMin").Value = txtMinMinutes.Value
            rs("FirstAmount").Value = txtAmount.Value
            rs("IntAmount").Value = txtIterval.Value
            rs.Update()
            MsgBox("New hourly rate added!    ", vbInformation, "Save")
            clean()
            disable()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from HourlyDB", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("Type").Value = cboVtype.Text
            rs("GracePeriod").Value = txtGPeriod.Value
            rs("FirstMin").Value = txtMinMinutes.Value
            rs("FirstAmount").Value = txtAmount.Value
            rs("IntAmount").Value = txtIterval.Value
            rs.Update()
            MsgBox("New hourly rate added!    ", vbInformation, "Save")
            clean()
            disable()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub edit()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from HourlyDB where Type = '" & cboVtype.Text & "'", conSqlPOS, 1, 2)
            rs("GracePeriod").Value = txtGPeriod.Value
            rs("FirstMin").Value = txtMinMinutes.Value
            rs("FirstAmount").Value = txtAmount.Value
            rs("IntAmount").Value = txtIterval.Value
            rs.Update()
            MsgBox("Hourly rate successfully updated!    ", vbInformation, "Update")
            clean()
            disable()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try
    End Sub

    Sub editL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from HourlyDB where Type = '" & cboVtype.Text & "'", conSqlLoc, 1, 2)
            rs("GracePeriod").Value = txtGPeriod.Value
            rs("FirstMin").Value = txtMinMinutes.Value
            rs("FirstAmount").Value = txtAmount.Value
            rs("IntAmount").Value = txtIterval.Value
            rs.Update()
            MsgBox("Hourly rate successfully updated!    ", vbInformation, "Update")
            clean()
            disable()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try
    End Sub

    Private Sub cmdADd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADd.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        If frmMain.dbstat2.Text = "Connected" Then

            If cmdADd.Text = "&Add" Then
                clean()
                enable()
                cboVtype.Focus()
                cmdADd.Text = "&Save"
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
                cmdADd.Text = "&Add"
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
                enable()
                cboVtype.Enabled = False
                txtGPeriod.Focus()
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

    Sub del()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from HourlyDb where type = '" & cboVtype.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Sub delL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from HourlyDb where type = '" & cboVtype.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        If frmMain.dbstat2.Text = "Connected" Then
            slctRecL()
            cmdEdit.Enabled = True
            cmdDel.Enabled = True
            disable()
            cmdADd.Text = "&Add"
            cmdEdit.Text = "&Edit"
        End If
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
            If frmMain.dbstat2.Text = "Connected" Then
                delL()
                lstList.Clear()
                header()
                fillL()
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Delete")
                frmConnDB.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        disable()
        cmdDel.Enabled = False
        cmdEdit.Enabled = False
        cmdADd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub cboVtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVtype.SelectedIndexChanged

    End Sub
End Class