Imports ADODB
Public Class frmAddDispenser

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmAddDispenser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub SaveDispenser()
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset

        rs.Open("select * from tbldispensers", conSqlLoc, 1, 2)
        rs.AddNew()
        rs("Zone").Value = cboZone.Text
        rs("IP").Value = txtZoneHost.Text
        rs("Status").Value = "Stop"
        rs.Update()
        MsgBox("Successfully saved! ", vbInformation, "Save")
        Me.Close()
    End Sub

    Sub UpdateDispenser(Zone As String)
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tbldispensers where Zone = '" & Zone & "'", conSqlLoc, 1, 2)
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

        rs = conSqlLoc.Execute("select * from tbldispensers where Zone = '" & Zone & "'")
        If rs.EOF = False Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        If txtTitle.Text = "     Add Dispenser" Then
            If ChkZoneExist(cboZone.Text) = True Then
                MsgBox("Zone already exist! ", vbExclamation, "Save")
                Exit Sub
            End If
            SaveDispenser()
        Else
            UpdateDispenser(cboZone.Text)
        End If
        PMSmain.EntfillwStat()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class