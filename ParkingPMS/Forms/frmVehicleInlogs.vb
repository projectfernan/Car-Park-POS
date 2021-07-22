Imports ADODB
Public Class frmVehicleInlogs
    Sub header()
        lstList.Columns.Add("CardCode", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("PlateNo", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("Entry Zone", 200, HorizontalAlignment.Left)
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub find()
        Dim TmeInTo As String
        Dim TmeInFrm As String
        Dim rs As New Recordset

        TmeInFrm = Format(CDate(dtpIn.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeIn.Value), "HH:mm:ss tt")
        TmeInTo = Format(CDate(dtpOut.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeOut.Value), "HH:mm:ss tt")

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * FROM TimeinDB WHERE TimeIn >= '" & TmeInFrm & "' AND Timein <= '" & TmeInTo & "' Order by Timein ASC") '"select * from timeindb where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rs.EOF = False Then
            txtcnt.Text = rs.RecordCount
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("CardCode").Value, lup)
                viewlst.SubItems.Add(rs("Plate").Value)
                viewlst.SubItems.Add(rs("TimeIn").Value)
                viewlst.SubItems.Add(rs("PC").Value)
                rs.MoveNext()
            Next
        End If


    End Sub

    Private Sub frmVehicleInlogs_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        lstList.Clear()
        header()
    End Sub

    Private Sub cmdFind_Click(sender As System.Object, e As System.EventArgs) Handles cmdFind.Click
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        lstList.Clear()
        header()
        find()
    End Sub

    Sub delIn(cod As String)
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from timeindb where CardCode='" & cod & "'")
            MsgBox("Vehicle log is successfully deleted! ", vbInformation, "Delete")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Private Sub lstList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                CarImage.Image = Get_PicIn(viewlst.SubItems(0).Text)
            End If
        Next
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this Vehicle Logs? ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    delIn(viewlst.SubItems(0).Text)
                    lstList.Clear()
                    header()
                    find()
                    CarImage.Image = Image.FromFile(Application.StartupPath & "\noCar.jpg")
                End If
            End If
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class