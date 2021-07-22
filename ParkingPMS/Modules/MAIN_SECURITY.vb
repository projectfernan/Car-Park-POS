Module MAIN_SECURITY
    Public Sub LockPms()
        With frmPMSmain
            .ControlPanel.Enabled = False
            .POSpanel.Enabled = False
            .DispenserPanel.Enabled = False
        End With
    End Sub

    Public Sub UnlockLockPms()
        With frmPMSmain
            .ControlPanel.Enabled = True
            .POSpanel.Enabled = True
            .DispenserPanel.Enabled = True
        End With
    End Sub
End Module
