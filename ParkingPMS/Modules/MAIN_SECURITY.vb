Module MAIN_SECURITY
    Public Sub LockPms()
        With PMSmain
            .ControlPanel.Enabled = False
            .POSpanel.Enabled = False
            .DispenserPanel.Enabled = False
        End With
    End Sub

    Public Sub UnlockLockPms()
        With PMSmain
            .ControlPanel.Enabled = True
            .POSpanel.Enabled = True
            .DispenserPanel.Enabled = True
        End With
    End Sub

    Public Sub disableExplorer()
        Dim taskKill As ProcessStartInfo = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
        taskKill.WindowStyle = ProcessWindowStyle.Hidden
        Dim Process As Process = New Process()
        Process.StartInfo = taskKill
        Process.Start()
        Process.WaitForExit()
    End Sub

    Public Sub RestartExplorer()
        System.Diagnostics.Process.Start("explorer.exe")
    End Sub
End Module
