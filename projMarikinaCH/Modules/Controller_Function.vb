Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WG3000_COMM.Core

Module Controller_Function
    Public PCip As String
    Public controler As New wgMjController
    Public watching As New wgWatchingService
    Dim cStat As Boolean = True
    Dim conCtrlStat As Boolean = False

    Public Function connController(ctrlSN As Integer, ctrlIP As String, ctrlPort As String)
        Try
            If PingMe(ctrlIP) = False Then
                Return False
            End If

            controler.ControllerSN = ctrlSN
            controler.IP = ctrlIP
            controler.PORT = ctrlPort
            Return True
        Catch ex As Exception
            errMsg = "Controller: " & ex.Message
            Save_ErrLogs("[connController]", errMsg)
            Return False
        End Try
    End Function

    Public Function TriggerUp(ByVal ctrlSN As Integer, ByVal ctrlIP As String, ByVal ctrlPort As String, ByVal Door As Integer)

        Try
            If connController(ctrlSN, ctrlIP, ctrlPort) = False Then
                Return False
            End If

            If controler.RemoteOpenDoorIP(Door) > 0 Then
                errMsg = vbNullString
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            errMsg = "Controller: " & ex.Message
            Save_ErrLogs("[TriggerUp]", errMsg)
            Return False
        End Try
    End Function

    Public Function OpenBarrierEnt() As Boolean
        Try
            Dim barUp As Boolean
            With My.Settings
                barUp = TriggerUp(.ctrl_SN, .ctrl_Ip, .ctrl_Port, 1)

                If barUp = False Then
                    errMsg = "Failed to open entry barrier."
                    Return barUp
                Else
                    errMsg = vbNullString
                    Return barUp
                End If
            End With
        Catch ex As Exception
            errMsg = "Controller: " & ex.Message
            Save_ErrLogs("[OpenBarrierEnt]", errMsg)
            Return False
        End Try
    End Function

    Public Function OpenBarrierExt() As Boolean
        Try
            Dim barUp As Boolean
            With My.Settings
                barUp = TriggerUp(.ctrl_SN, .ctrl_Ip, .ctrl_Port, 2)

                If barUp = False Then
                    errMsg = "Failed to open entry barrier."
                    Return barUp
                Else
                    errMsg = vbNullString
                    Return barUp
                End If
            End With
        Catch ex As Exception
            errMsg = "Controller: " & ex.Message
            Save_ErrLogs("[OpenBarrierExt]", errMsg)
            Return False
        End Try
    End Function

    Public Sub updateControllerStatus(ByVal ctrlSN As String, ByVal ctrlIP As String, ByVal ctrlPort As String)
        Try
            If conCtrlStat = False Then
                If connController(ctrlSN, ctrlIP, ctrlPort) = False Then
                    errMsg = "Controller: Disconnected"
                    cStat = False
                    conCtrlStat = False
                    Exit Sub
                Else
                    conCtrlStat = True
                End If
            End If
           
            'If watching IsNot Nothing Then
            '    Dim conRunInfo As wgMjControllerRunInformation = Nothing
            '    Dim commStatus As Integer
            '    commStatus = watching.CheckControllerCommStatus(CInt(ctrlSN), conRunInfo)

            '    If commStatus <= 0 Then
            '        errMsg = "Controller: Disconnected"
            '        cStat = False
            '    ElseIf commStatus = 1 Then
            '        If cStat = False Then
            '            errMsg = vbNullString
            '            cStat = True
            '        End If
            '    End If
            'End If

        Catch ex As Exception
            errMsg = "Controller: " & ex.Message
            Save_ErrLogs("[updateControllerStatus]", errMsg)
        End Try
    End Sub
End Module
