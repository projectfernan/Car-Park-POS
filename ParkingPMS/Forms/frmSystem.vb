Public Class frmSystem
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAcc.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
            verClose = "Quit"
            Application.Exit()
        End If
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmAcc.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmChargeCateg.ShowDialog()
    End Sub

    Private Sub frmSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmLogo.ShowDialog()
        End If

        If e.KeyCode = Keys.F2 Then
            frmSettings.ShowDialog()

        End If

        If e.KeyCode = Keys.F3 Then
            frmAcc.ShowDialog()

        End If

        If e.KeyCode = Keys.F5 Then
            frmVehicle.ShowDialog()

        End If

        If e.KeyCode = Keys.F6 Then
            frmChargeCateg.ShowDialog()
        End If

        If e.KeyCode = Keys.F7 Then

        End If

        If e.KeyCode = Keys.F8 Then
            Try
                Shell(Application.StartupPath & "\prjAbout.exe", AppWinStyle.NormalFocus)
            Catch
            End Try
        End If

        If e.KeyCode = Keys.Escape Then
            If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
                verClose = "Quit"
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub frmSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmVehicle.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGenCateg.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Try
            Shell(Application.StartupPath & "\prjAbout.exe", AppWinStyle.NormalFocus)
        Catch
        End Try
    End Sub

    Private Sub cmdSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSS.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click

    End Sub
End Class