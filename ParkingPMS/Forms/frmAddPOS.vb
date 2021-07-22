Imports ADODB
Public Class frmAddPOS

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub frmAddPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub saveSDB()
        If MsgBox("Are you sure your entries are correct?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Save") = vbYes Then
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblPOS", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("Station").Value = cboStation.Text
            rs("Location").Value = txtArea.Text
            rs("Ipadd").Value = txtIp1.Text
            rs("Username").Value = txtUser.Text
            rs("Password").Value = txtPwd.Text
            rs("Port").Value = txtSPort.Text
            rs("Database").Value = cboSdb.Text
            rs.Update()
            MsgBox("New POS successfully added!    ", vbInformation, "Save")
            frmPMSmain.lstList.Clear()
            frmPMSmain.PosHeader()
            frmPMSmain.fill()
            Me.Close()
        End If
    End Sub

    Sub EditSDB()
        If MsgBox("Are you sure do you want to save changes?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Save") = vbYes Then
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblPOS where Station = '" & cboStation.Text & "'", conSqlLoc, 1, 2)
            rs("Location").Value = txtArea.Text
            rs("Ipadd").Value = txtIp1.Text
            rs("Username").Value = txtUser.Text
            rs("Password").Value = txtPwd.Text
            rs("Port").Value = txtSPort.Text
            rs("Database").Value = cboSdb.Text
            rs.Update()
            MsgBox("POS successfully updated!    ", vbInformation, "Save")
            frmPMSmain.lstList.Clear()
            frmPMSmain.PosHeader()
            frmPMSmain.fill()
            Me.Close()
        End If
    End Sub

    Sub viewDB()
        Dim dbshw As New Recordset
        dbshw = New Recordset
        dbshw = conDbSlct.Execute("show databases")
        Do While dbshw.EOF = False
            cboSdb.Items.Add(dbshw("Database").Value)
            dbshw.MoveNext()
        Loop
    End Sub

    Function VerStNo() As Boolean
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblPOS where Station = '" & cboStation.Text & "'", conSqlLoc, 1, 2)
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Function verBlank() As Boolean
        If cboStation.Text = vbNullString Or txtArea.Text = vbNullString Or txtIp1.Text = vbNullString Or txtUser.Text = vbNullString Or txtSPort.Text = vbNullString Or cboSdb.Text = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cboSdb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSdb.Click
        If PingMe(frmConnDB.txtIp1.Text) = True Then
            If POSdbSlct() = True Then
                cboSdb.Items.Clear()
                viewDB()
            Else
                MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "MySQL Connection")
                txtUser.Focus()
            End If
        Else
            MsgBox("Failed to connect!    ", MsgBoxStyle.Exclamation, "MySQL Connection")
            txtIp1.Focus()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        

        If verBlank() = True Then
            MsgBox("Please fill up the blanks!    ", vbExclamation, "Add POS")
            Exit Sub
        End If

        If lblTitle.Text = "New POS" Then

            If VerStNo() = True Then
                MsgBox("Station already exist!    ", vbExclamation, "Add POS")
                cboStation.Focus()
                Exit Sub
            End If
            saveSDB()
        Else
            EditSDB()
        End If
        
    End Sub

    Private Sub cboSdb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSdb.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VerStNo() = True Then
                MsgBox("Station already exist!    ", vbExclamation, "Add POS")
                cboStation.Focus()
                Exit Sub
            End If

            If verBlank() = True Then
                MsgBox("Please fill up the blanks!    ", vbExclamation, "Add POS")
                Exit Sub
            End If

            saveSDB()
            frmPMSmain.lstList.Clear()
            frmPMSmain.PosHeader()
            frmPMSmain.fill()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub frmAddPOS_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If lblTitle.Text = "New POS" Then
            cboStation.Focus()
        Else
            txtArea.Focus()
        End If
    End Sub

    Private Sub txtArea_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtArea.TextChanged

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
End Class