Imports ADODB
Module MAIN_SECURITY
    Public str_SysUser As String
    Public str_SysPosi As String

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
            .cmdSS.Enabled = False
            .cmdSettings.Enabled = False
            .cmdAcc.Enabled = False
            .cmdVehicle.Enabled = False
            .cmdCharging.Enabled = False
            .cmdReport.Enabled = True
            .cmdAbout.Enabled = True
            .cmdExit.Enabled = False
        End With
    End Sub

    Public Sub AdminAcc()
        With frmSystem
            .cmdSS.Enabled = True
            .cmdSettings.Enabled = True
            .cmdAcc.Enabled = True
            .cmdVehicle.Enabled = True
            .cmdCharging.Enabled = True
            .cmdReport.Enabled = True
            .cmdAbout.Enabled = True
            .cmdExit.Enabled = True
        End With
    End Sub

    Sub saveAudiUpdate(ByVal sysUser As String, ByVal SysPosi As String, ByVal modi As String)
        If conLocal() = False Then
            Exit Sub
        End If

        Dim dtngaun As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("insert into tblauditlogs(Username,Designation,DateModified,Modifieds)values('" & sysUser & "','" & SysPosi & "','" & dtngaun & "','" & modi & "')")
        Catch ex As Exception
            'frmMain.txtSystemErr.Text = ex.Message
        End Try
    End Sub
End Module
