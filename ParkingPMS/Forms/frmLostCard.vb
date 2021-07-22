Imports ADODB
Public Class frmLostCard
    Sub save()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from LostCardDb", conSqlPOS, 1, 2)
            rs("Amount").Value = txtAmount.Value
            rs.Update()
            MsgBox("New Lost card amount saved!    ", vbInformation, "Save")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from LostCardDb", conSqlLoc, 1, 2)
            rs("Amount").Value = txtAmount.Value
            rs.Update()
            MsgBox("New Lost card amount saved!    ", vbInformation, "Save")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If frmMain.dbstat2.Text = "Connected" Then
            saveL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub frmLostCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class