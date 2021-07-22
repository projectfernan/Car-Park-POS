Imports System
Imports System.IO.Ports
Imports System.Threading

Public Class frmPoleDisplay
    Shared _continue As Boolean
    Shared _serialPort As SerialPort
    Public instance As SerialPort
    Public tt As String

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        PoleDisOpen()
        clear()
        display()
        'displayBye()
        PoleDisClose()

        saveAudiUpdate(str_SysUser, str_SysPosi, "Test Pole Display Settings")

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save()
        saveAudiUpdate(str_SysUser, str_SysPosi, "Update Pole display settings")

        MsgBox("Pole diplay settings saved!    ", MsgBoxStyle.Information, "Pole display settings")
        Me.Close()
    End Sub

    Sub save()
        With My.Settings
            .PD_Com = cboCom.Text
            .Save()
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cboCom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCom.KeyPress
        If Asc(e.KeyChar) > 1 Then
            e.KeyChar = vbNullString
            cboCom.Focus()
        End If
    End Sub

    Sub get_serial()
        Dim a As String = vbNullString
        For Each a In My.Computer.Ports.SerialPortNames
            cboCom.Items.Add(a)
        Next
    End Sub

    Private Sub frmPoleDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_serial()
        viewPDcom()
    End Sub

End Class