Module MAIN_SECURITY
    Public nem As String
    'Public RegistryKey As Object

    Public Sub disableExplorer()
        Dim taskKill As ProcessStartInfo = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
        taskKill.WindowStyle = ProcessWindowStyle.Hidden
        Dim Process As Process = New Process()
        Process.StartInfo = taskKill
        Process.Start()
        Process.WaitForExit()
    End Sub

    Public Sub disabledTaskMan()
        'Dim RegistryKey As Object
        'RegistryKey = CreateObject("WScript.Shell")
        'RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 1, "REG_DWORD")
    End Sub

    Public Sub enabledTaskMan()
        'Dim RegistryKey As Object
        'RegistryKey = CreateObject("WScript.Shell")
        'RegistryKey.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskMgr", 0, "REG_DWORD")
    End Sub


    Public Sub RestartExplorer()
        Dim ExProcess = New Process()
        ExProcess.StartInfo.UseShellExecute = True
        ExProcess.StartInfo.CreateNoWindow = True
        ExProcess.StartInfo.FileName = "c:\windows\explorer.exe"
        ExProcess.StartInfo.WorkingDirectory = Application.StartupPath
        ExProcess.Start()
        'System.Diagnostics.Process.Start("explorer.exe")
    End Sub

    Public Const SPI_SCREENSAVERRUNNING = 97&
    Public Declare Function SystemParametersInfo Lib "User32" _
    Alias "SystemParametersInfoA" _
    (ByVal uAction As Long, _
    ByVal uParam As Long, _
    ByVal lpvParam As Long, _
    ByVal fuWinIni As Long) As Long

    Public Sub disabled()
        Dim lngRet As Long
        Dim blnOld As Boolean
        lngRet = SystemParametersInfo(SPI_SCREENSAVERRUNNING, True, _
        blnOld, 0&)
    End Sub

    Public Sub Enabled()
        Dim lngRet As Long
        Dim blnOld As Boolean
        lngRet = SystemParametersInfo(SPI_SCREENSAVERRUNNING, False, _
        blnOld, 0&)
    End Sub


    Public Sub SuperV()
        With frmSystem
            '.cmdLogo.Enabled = False
            .cmdSettings.Enabled = False
            .cmdAcc.Enabled = False
            '.cmdVehicle.Enabled = False
            .cmdCharging.Enabled = False
            .cmdReport.Enabled = True
            .cmdAbout.Enabled = True
            .cmdExit.Enabled = False
        End With
    End Sub

    Public Sub AdminAcc()
        With frmSystem
            '.cmdLogo.Enabled = True
            .cmdSettings.Enabled = True
            .cmdAcc.Enabled = True
            '.cmdVehicle.Enabled = True
            .cmdCharging.Enabled = True
            .cmdReport.Enabled = True
            .cmdAbout.Enabled = True
            .cmdExit.Enabled = True
        End With
    End Sub
End Module
