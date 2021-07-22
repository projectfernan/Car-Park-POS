Public Class frmCompanyRef

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Function saveCompRef()
        Try
            With My.Settings
                .COMPANY = txtCompName.Text
                .CompAddr = txtAddress.Text
                .TIN = txtTIN.Text
                .PERMIT = txtPermit.Text
                .Save()
            End With
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub returnCompRef()
        With My.Settings
            txtCompName.Text = .COMPANY
            txtAddress.Text = .CompAddr
            txtTIN.Text = .TIN
            txtPermit.Text = .PERMIT
        End With
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If saveCompRef() Then
            MessageBox.Show("Company refence successfully saved!", "Company Reference", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub frmCompanyRef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        returnCompRef()
    End Sub
End Class