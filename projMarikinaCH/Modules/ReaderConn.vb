Module ReaderConn
    Sub viewDev()
        With My.Settings
            'frmReader.txtReaderIP.Text = .DEV_con
        End With
    End Sub
    Sub devDisCon()
        With MainForm
            ' .Dev1.EndInit()
            '  .Dev1.Disconnect()
        End With
    End Sub
    Public Function devcon() As Boolean
        'If PingMe(frmReader.txtReaderIP.Text) = True Then
        ' frmMain.StatDev1.Text = "Connected"
        '  frmMain.StatDev1.ForeColor = Color.Blue
        ' frmMain.Dev1.BeginInit()
        ' frmMain.Dev1.Connect_Net(frmReader.txtReaderIP.Text, 4370)
        'frmMain.Dev1.BASE64 = 0
        'frmMain.Dev1.RegEvent(1, 32767)
        'frmMain.tmrPingDev1.Enabled = True
        'Return True
        'Else
        ' frmMain.StatDev1.Text = "Disconnected"
        ' frmMain.StatDev1.ForeColor = Color.Red
        'frmMain.tmrPingDev1.Enabled = False
        'Return False
        'End If
    End Function
End Module
