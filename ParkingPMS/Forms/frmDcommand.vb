Imports ADODB
Public Class frmDcommand

    Public Sub EntZone(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * from tbldispensers")

        While rs.EOF = False
            cbo.Items.Add(rs("Zone").Value)
            rs.MoveNext()
        End While
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdRestartDev_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestartDev.Click
        'SC_Connect(txtzoneIP.Text)
        ' Send_Data("RS")'
        PMSmain.EntfillwStat()
        SendMsg(txtDispenser.Text, "RS")
    End Sub

    Private Sub cmdDevStatus_Click(sender As System.Object, e As System.EventArgs) Handles cmdDevStatus.Click
        'SC_Connect(txtzoneIP.Text)
        'Send_Data("DS")
        SendMsg(txtDispenser.Text, "DS")
    End Sub

    Private Sub frmDcommand_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub cmdOpenBarrier_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpenBarrier.Click
        'SC_Connect(txtzoneIP.Text)
        'Send_Data("OB")
        SendMsg(txtDispenser.Text, "OB")
    End Sub

    Private Sub cmdResetCam_Click(sender As System.Object, e As System.EventArgs) Handles cmdResetCam.Click
        'SC_Connect(txtzoneIP.Text)
        'Send_Data("CC")
        SendMsg(txtDispenser.Text, "CC")
    End Sub

    Private Sub frmDcommand_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        txtStat.Text = vbNullString
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class