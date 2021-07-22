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


    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub EntfillwStat()
        With frmPMSmain
            'On Error Resume Next
            .lstList2.Clear()
            .EntHeader()

            Dim rs As New Recordset
            Dim lup As Short
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tbldispensers")
            If rs.EOF = False Then
                For lup = 1 To rs.RecordCount
                    .lstList2.Refresh()
                    Dim viewlst As New ListViewItem
                    If PingMe(rs("IP").Value) = True Then
                        viewlst = .lstList2.Items.Add(rs("Zone").Value, .Image2.Images.Count - 1)
                        viewlst.SubItems.Add(rs("IP").Value)
                        viewlst.SubItems.Add("Active")
                        .Dstat = False
                    Else
                        viewlst = .lstList2.Items.Add(rs("Zone").Value, .Image2.Images.Count - 1)
                        viewlst.SubItems.Add(rs("IP").Value)
                        viewlst.SubItems.Add("Stop")
                        .Dstat = True
                    End If
                    rs.MoveNext()
                Next

            End If
        End With
    End Sub

    Private Sub cmdRestartDev_Click(sender As System.Object, e As System.EventArgs) Handles cmdRestartDev.Click
        'SC_Connect(txtzoneIP.Text)
        ' Send_Data("RS")'
        SendMsg(txtDispenser.Text, "RS")
        EntfillwStat()
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
End Class