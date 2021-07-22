Imports ADODB
Public Class frmFindLostCard
    Public vid As String
    Public Plate As String
    Public TimeIn As String
    Public Vehicle As String

    Sub DisableDt()
        dtpIn.Enabled = False
        dtpOut.Enabled = False
        dtptmeIn.Enabled = False
        dtptmeOut.Enabled = False
    End Sub

    Sub EnableDt()
        dtpIn.Enabled = True
        dtpOut.Enabled = True
        dtptmeIn.Enabled = True
        dtptmeOut.Enabled = True
    End Sub

    Sub DisablePlate()
        txtPlate.Text = vbNullString
        txtPlate.Enabled = False
    End Sub

    Sub EnablePlate()
        txtPlate.Enabled = True
        txtPlate.Focus()
    End Sub

    Sub header()
        lstList.Columns.Add("Card Code", 140, HorizontalAlignment.Left)
        lstList.Columns.Add("Plate", 140, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("Entry Zone", 150, HorizontalAlignment.Left)
    End Sub

    Private Sub frmFindLostCard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmFindLostCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()
        cmdVerified.Enabled = False
        DisableDt()
        DisablePlate()
    End Sub

    Sub findPlate(ByVal plateNo As String)
        Dim rs As New Recordset

        rs = New Recordset
        rs = conSqlPOS.Execute("SELECT * FROM TimeinDB WHERE Plate like '" & plateNo & "%' Order by Timein ASC") '"select * from timeindb where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rs.EOF = False Then
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

    Sub find()
        Dim TmeInTo As String
        Dim TmeInFrm As String
        Dim rs As New Recordset

        TmeInFrm = Format(CDate(dtpIn.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeIn.Value), "HH:mm:00")
        TmeInTo = Format(CDate(dtpOut.Value), "yyyy-MM-dd") + " " + Format(CDate(dtptmeOut.Value), "HH:mm:00")

        rs = New Recordset
        rs = conSqlPOS.Execute("SELECT * FROM TimeinDB WHERE TimeIn >= '" & TmeInFrm & "' AND Timein <= '" & TmeInTo & "' Order by Timein ASC") '"select * from timeindb where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
        If rs.EOF = False Then
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

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Select Case cboCateg.Text
            Case "By Date"
                With frmConnDB
                    If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                        If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                            MsgBox("Please connect to server!    ", vbExclamation, "Server")
                            frmConnDB.ShowDialog()
                            Exit Sub
                        End If
                    End If
                End With

                lstList.Clear()
                header()
                find()
              
            Case "By Plate"
                With frmConnDB
                    If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                        If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                            MsgBox("Please connect to server!    ", vbExclamation, "Server")
                            frmConnDB.ShowDialog()
                            Exit Sub
                        End If
                    End If
                End With

                lstList.Clear()
                header()
                findPlate(txtPlate.Text)
        End Select
    
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                HexCardID = viewlst.SubItems(0).Text
                LostIn = viewlst.SubItems(2).Text
            End If
        Next
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        With frmConnDB
            If conServer(.txtIp1.Text, .txtUser1.Text, .txtPwd1.Text, .cboSdb.Text) = False Then
                If conServer(.txtIPsvr2.Text, .txtUIDsvr2.Text, .txtPWDsvr2.Text, .cboSVRdb2.Text) = False Then
                    MsgBox("Please connect to server!    ", vbExclamation, "Server")
                    frmConnDB.ShowDialog()
                    Exit Sub
                End If
            End If
        End With

            With frmMain
                .InPic.Image = Get_PicIn(HexCardID)
                .DriverImage.Image = Get_PicDriver(HexCardID)
            End With

        cmdVerified.Enabled = True
    End Sub

    Private Sub cmdVerified_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerified.Click
        PoleDisOpen()
        clear()
        display()
        PoleDisClose()
        With frmTransactLost
            .cboVtype.Text = vbNullString
            .txtPlate.Text = vbNullString
            .ShowDialog()
        End With
    End Sub

    Private Sub cboCateg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCateg.SelectedIndexChanged
        Select Case cboCateg.Text
            Case "By Date"
                EnableDt()
                DisablePlate()
            Case "By Plate"
                EnablePlate()
                DisableDt()
        End Select
    End Sub

    Private Sub txtPlate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlate.KeyPress
        If Asc(e.KeyChar) >= 32 And Asc(e.KeyChar) <= 47 And Asc(e.KeyChar) <> 45 Then
            e.KeyChar = vbNullString
        End If

        If Asc(e.KeyChar) >= 58 And Asc(e.KeyChar) <= 64 Then
            e.KeyChar = vbNullString
        End If

        If Asc(e.KeyChar) >= 91 And Asc(e.KeyChar) <= 96 Then
            e.KeyChar = vbNullString
        End If

        If Asc(e.KeyChar) >= 123 And Asc(e.KeyChar) <= 127 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class