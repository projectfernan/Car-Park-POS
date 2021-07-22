Imports System
Imports System.IO.Ports
Imports System.Threading

Public Class frmPoleDisplay
    Shared _continue As Boolean
    Shared _serialPort As SerialPort
    Public instance As SerialPort
    Public tt As String

    Private Sub cmdTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTest.Click
        save()
        PD_Welcome()
    End Sub

    Sub save()
        With My.Settings
            .PD_Com = cboCom.Text
            .PDwelcome1 = txtGreetL1.Text
            .PDwelcome2 = txtGreetL2.Text
            .Save()
        End With
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

    Sub viewPDcom()
        With My.Settings
            cboCom.Text = .PD_Com
            txtGreetL1.Text = .PDwelcome1
            txtGreetL2.Text = .PDwelcome2
        End With
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save()
        MsgBox("Pole diplay settings saved!    ", MsgBoxStyle.Information, "Pole display settings")
        Me.Close()
    End Sub

    Private Sub cmdTestTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestTotal.Click
        save()
        PD_Display_Total(1000)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        save()
        PD_Display_Change(500, 1000)
    End Sub
End Class