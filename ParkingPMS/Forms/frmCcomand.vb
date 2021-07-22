Imports ADODB
Public Class frmCcomand

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub CapfillwStat()
        With frmPMSmain
            'On Error Resume Next
            .ListView1.Clear()
            .CapHeader()

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblcapturer")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    .ListView1.Refresh()
                    Dim viewlst As New ListViewItem
                    If PingMe(rs("IP").Value) = True Then
                        viewlst = .ListView1.Items.Add(rs("Zone").Value, .Image1.Images.Count - 2)
                        viewlst.SubItems.Add(rs("IP").Value)
                        viewlst.SubItems.Add("Active")
                        .Dstat = False
                    Else
                        viewlst = .ListView1.Items.Add(rs("Zone").Value, .Image1.Images.Count - 2)
                        viewlst.SubItems.Add(rs("IP").Value)
                        viewlst.SubItems.Add("Stop")
                        .Dstat = True
                    End If
                    rs.MoveNext()
                Next

            End If
        End With
    End Sub

    Private Sub cmdRestartUnit_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestartUnit.Click
        SendCapMsg(txtCapturer.Text, "RS")
    End Sub

    Private Sub cmdShutdown_Click(sender As System.Object, e As System.EventArgs) Handles cmdShutdown.Click
        SendCapMsg(txtCapturer.Text, "SH")
    End Sub

    Private Sub cmdResetCam_Click(sender As System.Object, e As System.EventArgs) Handles cmdResetCam.Click
        SendCapMsg(txtCapturer.Text, "CC")
    End Sub

    Private Sub cmdOpenBarrier_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpenBarrier.Click
        SendCapMsg(txtCapturer.Text, "OB")
    End Sub

    Private Sub cmdGraceStat_Click(sender As System.Object, e As System.EventArgs) Handles cmdGraceStat.Click
        SendCapMsg(txtCapturer.Text, "EN" & cboGraceStat.Text)
    End Sub

    Private Sub cmdGraceMin_Click(sender As System.Object, e As System.EventArgs) Handles cmdGraceMin.Click
        SendCapMsg(txtCapturer.Text, "GP" & txtGraceMin.Value.ToString)
    End Sub
End Class