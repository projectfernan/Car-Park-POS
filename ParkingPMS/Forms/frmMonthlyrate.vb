Imports ADODB
Public Class frmMonthlyrate

    Sub saveL()
        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs.Open("select * from tblmonthlyrate", conSqlLoc, 1, 2)
            If rs.EOF = False Then
                rs("MonthlyRate").Value = txtAmount.Value
                rs.Update()
            Else
                rs.AddNew()
                rs("MonthlyRate").Value = txtAmount.Value
                rs.Update()
            End If
            MsgBox("Monthly rate saved!    ", vbInformation, "Save")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Save")
        End Try
    End Sub

    Private Sub cmdsave_Click(sender As System.Object, e As System.EventArgs) Handles cmdsave.Click
        If conLocal() = True Then
            saveL()
        Else
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmConnDB.ShowDialog()
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub frmMonthlyrate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtAmount.Text = viewMonthly()
    End Sub
End Class