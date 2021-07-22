Imports ADODB
Public Class frmOvernigth
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
        dtStart.Enabled = False
        dtEnd.Enabled = False
    End Sub

    Sub enableData()
        cboVtype.Enabled = True
        txtAmount.Enabled = True
        dtStart.Enabled = True
        dtEnd.Enabled = True
    End Sub

    Sub clean()
        cboVtype.Text = vbNullString
        txtAmount.Value = 0.0
        dtStart.Value = Now
        dtEnd.Value = Now
    End Sub

    Sub header()
        lstList.Columns.Add("Vehicle Type", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("Amount", 130, HorizontalAlignment.Left)
        lstList.Columns.Add("Time Start", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("Time End", 200, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from tblOvernigth")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Vtype").Value, lup)
                viewlst.SubItems.Add(Format(Math.Round(rs("RateCharge").Value, 2), ".00"))
                viewlst.SubItems.Add(Format(CDate(rs("TimeStart").Value), "HH:mm:ss"))
                viewlst.SubItems.Add(Format(CDate(rs("TimeEnd").Value), "HH:mm:ss"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub fillL()
        'On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblOvernigth")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Vtype").Value, lup)
                viewlst.SubItems.Add(Format(Math.Round(rs("RateCharge").Value, 2), ".00"))
                viewlst.SubItems.Add(Format(CDate(rs("TimeStart").Value), "HH:mm:ss"))
                viewlst.SubItems.Add(Format(CDate(rs("TimeEnd").Value), "HH:mm:ss"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub frmOvernigth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clean()
        disableCMD()
        disableData()
        If conLocal() = True Then

            vtypL(cboVtype)
            lstList.Clear()
            header()
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Overnigth Rate")
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
            rs = conSqlPOS.Execute("select * from tblOvernigth where Vtype = '" & vid & "'")
            If rs.EOF = False Then
                cboVtype.Text = rs("VType").Value
                txtAmount.Value = rs("RateCharge").Value
                dtStart.Value = rs("TimeStart").Value
                dtEnd.Value = rs("TimeEnd").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Overnigth Rate")
        End Try

    End Sub

    Sub slctRecL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblOvernigth where Vtype = '" & vid & "'")
            If rs.EOF = False Then
                cboVtype.Text = rs("VType").Value
                txtAmount.Value = rs("RateCharge").Value
                dtStart.Value = rs("TimeStart").Value
                dtEnd.Value = rs("TimeEnd").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Overnigth Rate")
        End Try
    End Sub

    Function VerType() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlPOS.Execute("Select * from tblOvernigth where VType = '" & cboVtype.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Function VerTypeL() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tblOvernigth where VType = '" & cboVtype.Text & "'")
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
            rs.Open("select * from tblOvernigth", conSqlPOS, 1, 2)
            rs.AddNew()
            rs("VType").Value = cboVtype.Text
            rs("TimeStart").Value = dtStart.Value
            rs("TimeEnd").Value = dtEnd.Value
            rs("RateCharge").Value = txtAmount.Value
            rs.Update()
            MsgBox("New Overnigth rate added!    ", vbInformation, "Save")
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
            rs.Open("select * from tblOvernigth", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("VType").Value = cboVtype.Text
            rs("TimeStart").Value = dtStart.Value
            rs("TimeEnd").Value = dtEnd.Value
            rs("RateCharge").Value = txtAmount.Value
            rs.Update()
            MsgBox("New Overnigth rate added!    ", vbInformation, "Save")
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
            rs.Open("select * from tblOvernigth where VType = '" & cboVtype.Text & "'", conSqlPOS, 1, 2)
            rs("TimeStart").Value = dtStart.Value
            rs("TimeEnd").Value = dtEnd.Value
            rs("RateCharge").Value = txtAmount.Value
            rs.Update()
            MsgBox("Overnigth rate successfully updated!    ", vbInformation, "Update")
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
            rs.Open("select * from tblOvernigth where VType = '" & cboVtype.Text & "'", conSqlLoc, 1, 2)
            rs("TimeStart").Value = dtStart.Value
            rs("TimeEnd").Value = dtEnd.Value
            rs("RateCharge").Value = txtAmount.Value
            rs.Update()
            MsgBox("Overnigth rate successfully updated!    ", vbInformation, "Update")
            clean()
            disableData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        If conLocal() = True Then

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
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged

        slct()
        If conLocal() = True Then
            slctRecL()
            cmdEdit.Enabled = True
            cmdDel.Enabled = True
            disableData()
            cmdAdd.Text = "&Add"
            cmdEdit.Text = "&Edit"
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdDel.Enabled = False
        If conLocal() = True Then

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
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Sub del()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from tblOvernigth where Vtype = '" & cboVtype.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Sub delL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblOvernigth where Vtype = '" & cboVtype.Text & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
            If conLocal() = True Then
                delL()
                lstList.Clear()
                header()
                fillL()
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        disableCMD()
        disableData()
        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        frmOVcompute.ShowDialog()
    End Sub

    Private Sub cboVtype_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboVtype.SelectedIndexChanged

    End Sub
End Class