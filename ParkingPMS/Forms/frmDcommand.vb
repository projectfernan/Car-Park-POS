Public Class frmDcommand

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub cmdRestartDev_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestartDev.Click
        SC_Connect(txtzoneIP.Text)
        Send_Data("RS")
    End Sub

    Private Sub cmdDevStatus_Click(sender As System.Object, e As System.EventArgs) Handles cmdDevStatus.Click
        SC_Connect(txtzoneIP.Text)
        Send_Data("DS")
    End Sub

    Private Sub frmDcommand_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SC_Connect(txtzoneIP.Text)
    End Sub

    Private Sub cmdOpenBarrier_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpenBarrier.Click
        SC_Connect(txtzoneIP.Text)
        Send_Data("OB")
    End Sub

    Private Sub cmdResetCam_Click(sender As System.Object, e As System.EventArgs) Handles cmdResetCam.Click
        SC_Connect(txtzoneIP.Text)
        Send_Data("CC")
    End Sub
End Class