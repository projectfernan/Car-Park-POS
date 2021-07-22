Imports ADODB
Public Class frmGuestRate

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblguestrate", conSqlLoc, 1, 2)
            If rs.EOF = False Then
                rs("GuestRate").Value = txtAmount.Value
                rs.Update()
            Else
                rs.AddNew()
                rs("GuestRate").Value = txtAmount.Value
                rs.Update()
            End If
            MsgBox("In-House rate saved!    ", vbInformation, "Save")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If conLocal() = True Then
            saveL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub frmGuestRate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAmount.Value = viewInhouse()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class