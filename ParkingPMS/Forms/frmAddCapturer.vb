Imports ADODB
Public Class frmAddCapturer

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub SaveCapturer()
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs.Open("select * from tblcapturer", conSqlLoc, 1, 2)
        rs.AddNew()
        rs("Zone").Value = cboZone.Text
        rs("IP").Value = txtZoneHost.Text
        rs("Status").Value = "Stop"
        rs.Update()
        MsgBox("Successfully saved! ", vbInformation, "Save")
        Me.Close()
    End Sub

    Sub UpdateCapturer(Zone As String)
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblcapturer where Zone = '" & Zone & "'", conSqlLoc, 1, 2)
        rs("IP").Value = txtZoneHost.Text
        rs("Status").Value = "Stop"
        rs.Update()
        MsgBox("Successfully updated! ", vbInformation, "Save")
        Me.Close()
    End Sub

    Function ChkZoneExist(Zone As String) As Boolean
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Function
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs = conSqlLoc.Execute("select * from tblcapturer where Zone = '" & Zone & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        If txtTitle.Text = "Add Capturer" Then
            If ChkZoneExist(cboZone.Text) = True Then
                MsgBox("Zone already exist! ", vbExclamation, "Save")
                Exit Sub
            End If
            SaveCapturer()
        Else
            UpdateCapturer(cboZone.Text)
        End If
        frmPMSmain.CapfillwStat()
    End Sub
End Class