Imports MSWinsockLib.StateConstants
Module Socket_Function
    Public Sub SC_Listen()
        On Error Resume Next
        With frmPMSmain.Wns_Local
            If .CtlState = sckListening Then Exit Sub
            .LocalPort = My.Settings.S_Listener
            .Listen()
        End With
    End Sub

    Public Sub SC_Connect(IP As String)

        On Error Resume Next

        With frmPMSmain.Wns_Server

            Select Case .CtlState

                Case 0 'sckClosed
                    .Close()
                    .RemoteHost = IP
                    .RemotePort = My.Settings.S_ServerPort
                    .Connect()
                    'Send_Data(Status)
                Case 1 'sckClosing
                    'Send_Data("Stop")
                Case 2 'sckConnected
                    'Send_Data("Connected")
                Case 3 'sckConnecting

                Case 4 'sckConnectionPending

                Case 5 'sckError

                Case 6 'sckHostResolved

                Case 7 'sckListening
                    'Send_Data(Status)
                Case 8 'sckOpen
                    .Close()
                Case 9 'sckResolvingHost
                    .Close()
                    .RemoteHost = IP
                    .RemotePort = My.Settings.S_ServerPort
                    .Connect()
                    'Send_Data(Status)
            End Select
        End With

    End Sub

    Public Sub Send_Data(ByVal MSG As String)
        If frmPMSmain.Wns_Server.CtlState = sckConnected Then
            frmPMSmain.Wns_Server.SendData(MSG)
        End If
    End Sub

    Public Sub viewSocketSet()
        With My.Settings
            frmSocket.txtlistener.Value = .S_Listener
            frmSocket.txtServerHost.Text = .S_ServerHost
            frmSocket.txtServerPort.Value = .S_ServerPort
        End With
    End Sub
End Module
