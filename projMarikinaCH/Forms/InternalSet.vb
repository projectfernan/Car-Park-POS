Imports ADODB
Public Class InternalSet

    Private Sub frmOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ViewInternal()
    End Sub

    Sub ViewInternal()
        Try
            'If conLocal() = False Then Exit Sub

            'Dim rs As New Recordset
            'rs = conSqlLoc.Execute("select * from tblsetpos")
            'If rs.EOF = False Then
            '    txtOR.Value = CInt(rs("ORseries").Value)
            '    txtZread.Value = CInt(rs("ZreadCount").Value)
            '    cboPOSVer.Text = rs("PosVer").Value
            '    cboMode.Text = rs("Mode").Value
            'Else
            '    setDefault()
            'End If

            With My.Settings
                txtOR.Value = .OR_Number
                txtZread.Value = .ZRead_Cnt
                cboPOSVer.Text = .POS_VER
                cboMode.Text = .Operation
                chkCardData.Checked = .CardDataBckup
                chkEntryLogDb.Checked = .EntryLogDb
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub setDefault()
        Try
            If conLocal() = False Then Exit Sub
            Dim rs As New Recordset
            rs.Open("select * from tblsetpos where 1=0", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("ORseries").Value = 1
            rs("ZreadCount").Value = 1
            rs("PosVer").Value = "BIR BASED"
            rs("Mode").Value = "SINGLE"
            rs.Update()

            ViewInternal()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub setPos()
        Try
            'If conLocal() = False Then Exit Sub
            'Dim rs As New Recordset
            'rs.Open("select * from tblsetpos", conSqlLoc, 1, 2)
            'rs("ORseries").Value = txtOR.Value
            'rs("ZreadCount").Value = txtZread.Value
            'rs("PosVer").Value = cboPOSVer.Text
            'rs("Mode").Value = cboMode.Text
            'rs.Update()
            With My.Settings
                .OR_Number = txtOR.Value
                .ZRead_Cnt = txtZread.Value
                .POS_VER = cboPOSVer.Text
                .Operation = cboMode.Text
                .Save()

                If .POS_VER = "GOVERNMENT BASED" Then
                    setVat0()
                End If
            End With

            MsgBox("Internal settings successfully set!", vbInformation, "Internal Settings")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdT.Click
        setPos()
    End Sub

    Sub setVat0()
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblvat", conSqlLoc, 1, 2)
            If rs.EOF = False Then
                rs("Vat").Value = 0
                rs.Update()
            Else
                rs.AddNew()
                rs("Vat").Value = 0
                rs.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ErrorLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrorLogsToolStripMenuItem.Click
        Dim f As New ErrLogs
        f.ShowDialog()
    End Sub

    Private Sub ResetErrorLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetErrorLogsToolStripMenuItem.Click
        If MessageBox.Show("Are you sure do you want to reset error logs?", "Reset Error Logs", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Application.DoEvents()
            If resetFlogs() = True Then
                MessageBox.Show("Error logs has been reset successfully!", "Reset Error Logs", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub chkDataPool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCardData.CheckedChanged
        My.Settings.CardDataBckup = chkCardData.Checked
        My.Settings.Save()
    End Sub

    Private Sub chkEntryLogDb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEntryLogDb.CheckedChanged
        My.Settings.EntryLogDb = chkEntryLogDb.Checked
        My.Settings.Save()
    End Sub
End Class