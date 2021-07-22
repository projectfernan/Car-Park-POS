Imports ADODB
Public Class frmFindLostCard
    Public vid As String
    Public Plate As String
    Public TimeIn As String
    Public Vehicle As String

    Sub DisableDt()
        dtpIn.Enabled = False
        dtpOut.Enabled = False
    End Sub

    Sub EnableDt()
        dtpIn.Enabled = True
        dtpOut.Enabled = True
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
        Dim w As Integer = lstList.Width / 3
        Dim wd4 As Integer = w / 4
        Dim wz As Integer = w - wd4
        Dim wt As Integer = w + wd4

        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", wt, HorizontalAlignment.Left)
        lstList.Columns.Add("Plate", w, HorizontalAlignment.Left)
        lstList.Columns.Add("Entry Zone", wz, HorizontalAlignment.Left)
    End Sub

    Private Sub frmFindLostCard_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmFindLostCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loc()

        lstList.Clear()
        header()
        cmdVerified.Enabled = False
        DisableDt()
        DisablePlate()
    End Sub

    Sub findPlate(ByVal plateNo As String)
        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs = conSqlPOS.Execute("SELECT CardCode,Plate,TimeIn,PC FROM Timeindb WHERE Plate like '" & plateNo & "%' Order by Timein DESC") '"select * from timeindb where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rs("CardCode").Value, lup)
                    viewlst.SubItems.Add(Format(CDate(rs("TimeIn").Value), "yyyy-MM-dd HH:mm"))
                    viewlst.SubItems.Add(rs("Plate").Value)
                    viewlst.SubItems.Add(rs("PC").Value)
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            Save_ErrLogs("[findPlate] frmFindLostCard", ex.Message)
        End Try
    End Sub

    Sub find()
        Try
            Dim TmeInTo As String
            Dim TmeInFrm As String
            Dim rs As New Recordset

            TmeInFrm = Format(CDate(dtpIn.Value), "yyyy-MM-dd HH:mm")
            TmeInTo = Format(CDate(dtpOut.Value), "yyyy-MM-dd HH:mm")

            rs = New Recordset
            rs = conSqlPOS.Execute("SELECT CardCode,Plate,TimeIn,PC FROM timeindb WHERE TimeIn >= '" & TmeInFrm & "' AND Timein <= '" & TmeInTo & "' Order by Timein DESC") '"select * from timeindb where TimeIn >= '" & TmeInFrm & "' and TimeIn <='" & TmeInTo & "'")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(rs("CardCode").Value, lup)
                    viewlst.SubItems.Add(Format(CDate(rs("TimeIn").Value), "yyyy-MM-dd HH:mm"))
                    viewlst.SubItems.Add(rs("Plate").Value)
                    viewlst.SubItems.Add(rs("PC").Value)
                    rs.MoveNext()
                Next
            End If
        Catch ex As Exception
            Save_ErrLogs("[find] frmFindLostCard", ex.Message)
        End Try      
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Select Case cboCateg.Text
            Case "By Date"
                If conServer() = True Then
                    lstList.Clear()
                    header()
                    find()
                Else
                    MsgBox("Please connect to server!    ", vbExclamation, "Server")
                    frmConnDB.ShowDialog()
                End If
            Case "By Plate"
                If conServer() = True Then
                    lstList.Clear()
                    header()
                    findPlate(txtPlate.Text)
                Else
                    MsgBox("Please connect to server!    ", vbExclamation, "Server")
                    frmConnDB.ShowDialog()
                End If
        End Select
    End Sub

    Sub slct()
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                HexCardID = viewlst.SubItems(0).Text
                LostIn = viewlst.SubItems(1).Text
                frmTransactLost.txtPlate.Text = viewlst.SubItems(2).Text
            End If
        Next
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        slct()
        If conServer() = True Then
            With MainForm
                .InPic.Image = Get_PicIn(HexCardID)
                .DriverImage.Image = Get_PicDriver(HexCardID)
            End With
        End If
        cmdVerified.Enabled = True
    End Sub

    Private Sub cmdVerified_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerified.Click
        PD_Welcome()
        With frmTransactLost
            Me.Hide()
            .cboVtype.Text = vbNullString
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = MainForm.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Private Sub txtPlate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                txtPlate.Focus()
            Case 33 To 47
                e.KeyChar = vbNullString
            Case 91 To 96
                e.KeyChar = vbNullString
            Case 58 To 64
                e.KeyChar = vbNullString
            Case 123 To 126
                e.KeyChar = vbNullString
            Case 8, 9, 27, 32  'backspace, tab, esc, space
        End Select
    End Sub

    Private Sub txtPlate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlate.TextChanged

    End Sub
End Class