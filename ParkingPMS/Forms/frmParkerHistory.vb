Imports ADODB
Public Class frmParkerHistory

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Sub header()
        lstList.Columns.Add("ID", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("CardCode", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("PlateNo", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("Time Out", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("Exit Lane", 200, HorizontalAlignment.Left)
    End Sub

    Sub find()
        Progbar.Value = 0

        Dim TmeInTo As String
        Dim TmeInFrm As String
        Dim rs As New Recordset

        TmeInFrm = Format(CDate(dtpIn.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeIn.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtpOut.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeOut.Value), "HH:mm:ss tt")

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * FROM tblparkerhistory WHERE " & cboCateg.Text & " like '" & txtPlate.Text & "%' and TimeOut >= '" & TmeInFrm & "' AND TimeOut <= '" & TmeInTo & "' Order by TimeOut ASC") '"select * from timeindb where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rs.EOF = False Then
            cmdDel.Enabled = True
            txtcnt.Text = rs.RecordCount
            Progbar.Maximum = rs.RecordCount
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Id").Value, lup)
                viewlst.SubItems.Add(rs("CardCode").Value)
                viewlst.SubItems.Add(rs("Plate").Value)
                viewlst.SubItems.Add(rs("TimeIn").Value)
                viewlst.SubItems.Add(rs("TimeOut").Value)
                viewlst.SubItems.Add(rs("ExitLane").Value)

                Progbar.Value = lup

                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub cmdFind_Click(sender As System.Object, e As System.EventArgs) Handles cmdFind.Click
        Progbar.Value = 0
        lstList.Clear()
        header()
        find()

    End Sub

    Private Sub cboCateg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub frmParkerHistory_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Progbar.Value = 0
        lstList.Clear()
        header()
        cmdDel.Enabled = False
    End Sub

    Private Sub lstList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                CarImage.Image = Get_PkHistory1(viewlst.SubItems(0).Text)
                CarImage2.Image = Get_PkHistory2(viewlst.SubItems(0).Text)
            End If
        Next
    End Sub

    Sub delHistory()
        If conLocal() = False Then
            Exit Sub
        End If

        Try
            Progbar.Value = 0

            Dim TmeInTo As String
            Dim TmeInFrm As String
            Dim rs As New Recordset

            TmeInFrm = Format(CDate(dtpIn.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeIn.Value), "HH:mm:ss tt")
            TmeInTo = Format(CDate(dtpOut.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeOut.Value), "HH:mm:ss tt")

            rs = New Recordset
            rs = conSqlLoc.Execute("delete FROM tblparkerhistory WHERE " & cboCateg.Text & " like '" & txtPlate.Text & "%' or TimeOut >= '" & TmeInFrm & "' AND TimeOut <= '" & TmeInTo & "' Order by TimeOut ASC") '"select * from timeindb where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        If MsgBox("Are you sure do you want to delete this logs? ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete Parker History") = vbYes Then
            delHistory()
            lstList.Clear()
            header()
            cmdDel.Enabled = False
        End If
    End Sub
End Class