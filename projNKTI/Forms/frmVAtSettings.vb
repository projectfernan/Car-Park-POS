Imports ADODB
Public Class frmVAtSettings

    Sub saveVat()
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New recordset
            rs = New Recordset

            rs.Open("select * from tblvat", conSqlLoc, 1, 2)
            If rs.EOF = False Then
                rs("Vat").Value = txtSetVat.Text
                rs.Update()
            Else
                rs.AddNew()
                rs("Vat").Value = txtSetVat.Text
                rs.Update()
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cmdCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompute.Click
        saveVat()
        txtVat.Text = VAT(txtAmount.Value)
        txtVatSale.Text = MakeMoney(Val(txtAmount.Value - Val(txtVat.Text)))
        saveAudiUpdate(str_SysUser, str_SysPosi, "Update vat settings")
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Sub viewVatSettings()
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblvat")
            txtSetVat.Text = rs("Vat").Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmVAtSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewVatSettings()
    End Sub
End Class