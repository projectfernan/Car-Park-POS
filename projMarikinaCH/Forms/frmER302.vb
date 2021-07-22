Public Class frmER302
    Sub get_serial()
        Dim a As String = vbNullString
        For Each a In My.Computer.Ports.SerialPortNames
            cboCom.Items.Add(a)
        Next
    End Sub

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        Dim com As String = Replace(cboCom.Text, "COM", "")
        If ER302_Conn(Convert.ToInt32(com)) = False Then
            MessageBox.Show("Failed to connect to the selected port!", "Test Connect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            MessageBox.Show("Successfully connected!", "Test Connect", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmER302_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_serial()
        cboCom.Text = "COM" & My.Settings.Er302Com.ToString
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveCom()
    End Sub

    Sub SaveCom()
        Try
            Dim com As String = Replace(cboCom.Text, "COM", "")

            My.Settings.Er302Com = Convert.ToInt32(com)
            My.Settings.Save()

            MessageBox.Show("ER302 settings successfully saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class