Imports ADODB
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
        frmAccSetting.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCharging.Click
        frmChargeCateg.ShowDialog()
    End Sub

    Private Sub frmSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            If cmdLogo.Enabled = True Then
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
                frmAccSetting.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F5 Then
           
        End If

        If e.KeyCode = Keys.F6 Then
            If cmdCharging.Enabled = True Then
                frmChargeCateg.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F7 Then
            If cmdReport.Enabled = True Then
                cmdFlat.ShowDropDown()
            End If
        End If

        If e.KeyCode = Keys.F8 Then
            If cmdFlat.Enabled = True Then
                frmBussDate.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F9 Then
            If cmdFlat.Enabled = True Then
                frmCashOut.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F10 Then
            If cmdCashOut.Enabled = True Then
                cmdReport.ShowDropDown()
            End If
        End If

        If e.KeyCode = Keys.F11 Then
            frmAbout.ShowDialog()
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

    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmVehicle.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGenCateg.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cmdSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogo.Click
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

    Private Sub StationLogoutReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StationLogoutReportToolStripMenuItem.Click
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

                If rs("Logo").Value = 1 Then
                    cmdLogo.Enabled = True
                Else
                    cmdLogo.Enabled = False
                End If

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
                cmdLogo.Enabled = True
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
End Class