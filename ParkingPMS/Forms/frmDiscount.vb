Imports ADODB
Public Class frmDiscount
    Public vid As String
    Public dis As String
    Public Vat As String
    Sub header()
        Dim w As Integer = lstList.Width / 2
        lstList.Columns.Add("Discount Name", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Percentage", w, HorizontalAlignment.Left)
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Sub disabl()
        txtDName.Enabled = False
        txtPercent.Enabled = False
        chkVat.Enabled = False
    End Sub

    Sub enabl()
        txtDName.Enabled = True
        txtPercent.Enabled = True
        chkVat.Enabled = True
    End Sub

    Sub clean()
        txtDName.Text = vbNullString
        txtPercent.Value = "0.00"
    End Sub

    Private Sub frmDiscount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub frmDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If conLocal() = True Then
            lstList.Clear()
            header()
            fillL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Hourly Rate")
            frmConnDB.ShowDialog()
        End If
        disabl()
        cmdDel.Enabled = False
        cmdEdit.Enabled = False
    End Sub

    Function VerDnameL() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs = conSqlLoc.Execute("Select * from tbldiscount where DiscountName = '" & txtDName.Text & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tbldiscount")
        txtcnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("DiscountName").Value, lup)
                viewlst.SubItems.Add(rs("Percentage").Value)
                viewlst.SubItems.Add(rs("VatExempt").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblDiscount", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("DiscountName").Value = txtDName.Text
            rs("Percentage").Value = txtPercent.Value
            rs("VatExempt").Value = Convert.ToInt32(chkVat.Checked)
            rs.Update()
            MsgBox("New record added!    ", vbInformation, "Save")
            clean()
            disabl()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        If conLocal() = True Then
            If cmdAdd.Text = "&Add" Then
                clean()
                enabl()
                txtDName.Focus()
                cmdAdd.Text = "&Save"
            Else
                If txtDName.Text = vbNullString Then
                    MsgBox("Please enter discount name!    ", vbExclamation, "Save")
                    txtDName.Focus()
                    Exit Sub
                End If
                If VerDnameL() = True Then
                    MsgBox("Discount name already exist!    ", vbExclamation, "Save")
                    txtDName.Text = vbNullString
                    Exit Sub
                End If
                saveL()
                lstList.Clear()
                header()
                fillL()
                cmdAdd.Text = "&Add"
            End If
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Discount")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub EditL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblDiscount where DiscountName = '" & txtDName.Text & "'", conSqlLoc, 1, 2)
            rs("Percentage").Value = txtPercent.Value
            rs("VatExempt").Value = Convert.ToInt32(chkVat.Checked)
            rs.Update()
            MsgBox("Record updated!    ", vbInformation, "Update")
            clean()
            disabl()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update")
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        cmdDel.Enabled = False
        If conLocal() = True Then

            If cmdEdit.Text = "&Edit" Then
                enabl()
                txtDName.Enabled = False
                txtPercent.Focus()
                cmdEdit.Text = "&Update"
            Else
                EditL()
                lstList.Clear()
                header()
                fillL()
                cmdEdit.Text = "&Edit"
                cmdEdit.Enabled = False
            End If

        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Discount")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Sub delL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblDiscount where DiscountName = '" & txtDName.Text & "'")
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
                MsgBox("Please connect to database!    ", vbExclamation, "Discount")
                frmConnDB.ShowDialog()
            End If
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

    Sub slctRecL()
        Try
            If conLocal() = False Then
                Exit Sub
            End If

            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblDiscount where DiscountName = '" & vid & "'")
            If rs.EOF = False Then
                txtDName.Text = rs("Discountname").Value
                txtPercent.Value = rs("Percentage").Value
                chkVat.Checked = Convert.ToBoolean(Convert.ToInt32(rs("VatExempt").Value))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Hourly Rate")
        End Try
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        slctRecL()
        cmdEdit.Enabled = True
        cmdDel.Enabled = True
        disabl()
        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        disabl()
        cmdDel.Enabled = False
        cmdEdit.Enabled = False
        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class















