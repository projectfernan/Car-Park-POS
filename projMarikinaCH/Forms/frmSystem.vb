Imports ADODB
Public Class frmSystem
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If MsgBox("Are you sure do you want to quit?    ", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "System") = vbYes Then
            verClose = "Quit"

            enabledTaskMan()
            RestartExplorer()

            Process.GetCurrentProcess.Kill()
            Application.Exit()
        End If
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcc.Click
        frmAccSetting.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCharging.Click
        frmChargeCateg.ShowDialog()
    End Sub

    Private Sub frmSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cmdSettings.Enabled = True Then
                ToolStripButton1_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            If cmdAcc.Enabled = True Then
                ToolStripButton3_Click_1(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F3 Then
            If cmdCharging.Enabled = True Then
                ToolStripButton2_Click(sender, New System.EventArgs)
            End If
        End If

        'If e.KeyCode = Keys.F5 Then
        '    If cmdVehicle.Enabled = True Then
        '        frmVehicle.ShowDialog()
        '    End If
        'End If

        If e.KeyCode = Keys.F4 Then
            If cmdReport.Enabled = True Then
                cmdFlat.ShowDropDown()
            End If
        End If

        If e.KeyCode = Keys.F5 Then
            If cmdFlat.Enabled = True Then
                ToolStripButton1_Click_1(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F6 Then
            If cmdFlat.Enabled = True Then
                cmdCashOut_Click(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.F7 Then
            If cmdCashOut.Enabled = True Then
                cmdReport.ShowDropDown()
            End If
        End If

        If e.KeyCode = Keys.F8 Then
            If cmdAbout.Enabled = True Then
                ToolStripButton6_Click_1(sender, New System.EventArgs)
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            If cmdExit.Enabled = True Then
                ToolStripButton5_Click(sender, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub frmSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cmdSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLogo.ShowDialog()
    End Sub

    Private Sub ZReadingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZReadingReportToolStripMenuItem.Click
        frmZreport.ShowDialog()
    End Sub

    Private Sub CashierLogoutReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashierLogoutReportToolStripMenuItem.Click
        frmCashierLogout.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmFlatRateDay.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmFlatHoliday.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCutOff.Click
        frmBussDate.ShowDialog()
    End Sub

    Private Sub StationLogoutReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmStationOut.ShowDialog()
    End Sub

    Private Sub ReprintReceiptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprintReceiptToolStripMenuItem.Click
        frmReportDT.ShowDialog()
    End Sub

    Private Sub cmdCashOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashOut.Click
        frmCashOut.ShowDialog()
    End Sub

    Private Sub StayInReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StayInReportToolStripMenuItem.Click
        frmStayIn.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmSummRep.ShowDialog()
    End Sub

    Private Sub frmSystem_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ViewDesig(desig)
    End Sub

    Sub ViewDesig(ByVal Desig As String)
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblaccdesig where Desig = '" & Desig & "'")
            If rs.EOF = False Then

                'If rs("Logo").Value = 1 Then
                '    cmdLogo.Enabled = True
                'Else
                '    cmdLogo.Enabled = False
                'End If

                If rs("Settings").Value = 1 Then
                    cmdSettings.Enabled = True
                Else
                    cmdSettings.Enabled = False
                End If

                If rs("Accounts").Value = 1 Then
                    cmdAcc.Enabled = True
                Else
                    cmdAcc.Enabled = False
                End If

                'If rs("Vehicle").Value = 1 Then
                '    cmdVehicle.Enabled = True
                'Else
                '    cmdVehicle.Enabled = False
                'End If

                If rs("Charging").Value = 1 Then
                    cmdCharging.Enabled = True
                Else
                    cmdCharging.Enabled = False
                End If

                If rs("FlatRate").Value = 1 Then
                    cmdFlat.Enabled = True
                Else
                    cmdFlat.Enabled = False
                End If

                If rs("CutOff").Value = 1 Then
                    cmdCutOff.Enabled = True
                Else
                    cmdCutOff.Enabled = False
                End If

                If rs("CashOut").Value = 1 Then
                    cmdCashOut.Enabled = True
                Else
                    cmdCashOut.Enabled = False
                End If

                If rs("Reports").Value = 1 Then
                    cmdReport.Enabled = True
                Else
                    cmdReport.Enabled = False
                End If

                If rs("Terminate").Value = 1 Then
                    cmdExit.Enabled = True
                Else
                    cmdExit.Enabled = False
                End If
            Else
                'cmdLogo.Enabled = True
                cmdSettings.Enabled = True
                cmdAcc.Enabled = True
                'cmdVehicle.Enabled = True
                cmdCharging.Enabled = True
                cmdFlat.Enabled = True
                cmdCutOff.Enabled = True
                cmdCashOut.Enabled = True
                cmdReport.Enabled = True
                cmdExit.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, " ")
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class