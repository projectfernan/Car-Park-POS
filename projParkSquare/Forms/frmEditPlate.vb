Imports ADODB
Public Class frmEditPlate
    Public CodePlate As String

    Sub loc()
        Me.Top = Screen.PrimaryScreen.Bounds.Height - 335
        Dim w As Integer = frmMain.CamEntry.Width + 17
        Me.Left = Screen.PrimaryScreen.Bounds.Left + w
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        Dim w2 As Integer = lstList.Width / 3
        Dim w3 As Integer = w - w2
        lstList.Columns.Add("CardCode", w2, HorizontalAlignment.Left)
        lstList.Columns.Add("Time In", w3, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlPOS.Execute("select * from timeindb where Plate='-' or Plate='Empty'")

        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("CardCode").Value, lup)
                viewlst.SubItems.Add(rs("Timein").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Private Sub frmEditPlate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEditPlate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()
        fillL()

        loc()
    End Sub

    Function EditPlate(ByVal Code As String) As String
        If conServer() = False Then Return vbNullString

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlPOS.Execute("select * from timeindb where CardCode = '" & Code & "'")
            If rs.EOF = False Then
                Return rs("Plate").Value
            Else
                Return vbNullString
            End If
        Catch ex As Exception
            Return vbNullString
        End Try

    End Function

    Private Sub lstList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstList.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPlate.Focus()
        End If
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                CodePlate = viewlst.SubItems(0).Text
                txtPlate.Text = EditPlate(viewlst.SubItems(0).Text)
                frmMain.InPic.Image = Get_PicIn(CodePlate)
                frmMain.DriverImage.Image = Get_PicDriver(CodePlate)
            End If
        Next
    End Sub

    Sub updatePlate()
        If conServer() = False Then Exit Sub

        Try
            Dim rs As Recordset
            rs = New Recordset

            rs.Open("select * from timeindb where CardCode = '" & CodePlate & "'", conSqlPOS, 1, 2)
            rs("Plate").Value = txtPlate.Text
            rs.Update()
            txtPlate.Text = vbNullString
            txtPlate.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPlate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPlate.Text = vbNullString Or txtPlate.TextLength <> 6 Then Exit Sub
            updatePlate()

            lstList.Clear()
            header()
            fillL()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class