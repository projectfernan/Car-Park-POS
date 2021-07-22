Public Class frmSystem
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAcc.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
            verClose = "Quit"
            RestartExplorer()
            Application.Exit()
        End If
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcc.Click
        frmAcc.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCharging.Click
        frmChargeCateg.ShowDialog()
    End Sub

    Private Sub frmSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cmdSS.Enabled = True Then
                frmLogo.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            If cmdSettings.Enabled = True Then
                frmSettings.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F3 Then
            If cmdAcc.Enabled = True Then
                frmAcc.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If cmdVehicle.Enabled = True Then
                frmVehicle.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F6 Then
            If cmdCharging.Enabled = True Then
                frmChargeCateg.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F7 Then
            If cmdReport.Enabled = True Then
                cmdReport.AllowDrop = True
            End If
        End If

        If e.KeyCode = Keys.F8 Then
            If cmdAbout.Enabled = True Then
                Try
                    Shell(Application.StartupPath & "\prjAbout.exe", AppWinStyle.NormalFocus)
                Catch
                End Try
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            If cmdExit.Enabled = True Then
                If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
                    verClose = "Quit"
                    RestartExplorer()
                    Application.Exit()
                End If
            End If
        End If
    End Sub

    Private Sub frmSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVehicle.Click
        frmVehicle.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGenCateg.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        Try
            Shell(Application.StartupPath & "\prjAbout.exe", AppWinStyle.NormalFocus)
        Catch
        End Try
    End Sub

    Private Sub cmdSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSS.Click
        frmLogo.ShowDialog()
    End Sub

    Private Sub ZReadingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZReadingReportToolStripMenuItem.Click
        frmZreport.ShowDialog()
    End Sub

    Private Sub CashierLogoutReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashierLogoutReportToolStripMenuItem.Click
        frmCashierLogout.ShowDialog()
    End Sub
End Class