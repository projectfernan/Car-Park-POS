Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports WG3000_COMM.Core
Imports ADODB

Public Class frmFindControler

    Dim frm As New FormMove

    Sub Header()
        lstList.Columns.Clear()
        lstList.Columns.Add("Serial Number", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("IP Address", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Mask", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Gateway", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Port", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("MAC Address", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("PC IP", 180, HorizontalAlignment.Left)
    End Sub

    Sub FindController()
        Try
            Cursor = Cursors.WaitCursor 'and some various me.Cursor / current.cursor 
            Application.DoEvents()

            Dim Clist As New ArrayList
            controler = New wgMjController
            controler.SearchControlers(Clist)

            lstList.Clear()
            Header()

            If Clist.Count <> 0 Then
                Dim conf As New wgMjControllerConfigure
                Dim cnt As Integer
                For cnt = 0 To Clist.Count - 1
                    conf = Clist.Item(cnt)
                    lstList.Refresh()
                    Dim viewlst As New ListViewItem
                    viewlst = lstList.Items.Add(conf.controllerSN.ToString)
                    viewlst.SubItems.Add(conf.ip.ToString)
                    viewlst.SubItems.Add(conf.mask.ToString)
                    viewlst.SubItems.Add(conf.gateway.ToString)
                    viewlst.SubItems.Add(conf.port.ToString)
                    viewlst.SubItems.Add(conf.MACAddr)
                    viewlst.SubItems.Add(conf.pcIPAddr)
                    txtStat.Text = "Controller found!"
                    Cursor = Cursors.Default
                Next cnt
            Else
                txtStat.Text = "No Controller found!"
                Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Save_ErrLogs("[FindController]", ex.Message)
        End Try
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtStat.Text = "Please wait for about 5 seconds..."
        FindController()
    End Sub

    Private Sub frmFindControler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        Header()
        txtStat.Text = "Please wait for about 5 seconds..."
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
       
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                With frmSetController
                    .txtSN.Text = viewlst.SubItems(0).Text
                    .txtIP.Text = viewlst.SubItems(1).Text

                    .txtSubnet.Text = viewlst.SubItems(2).Text
                    .txtGateway.Text = viewlst.SubItems(3).Text
                    .txtPort.Text = viewlst.SubItems(4).Text
                    .txtMack.Text = viewlst.SubItems(5).Text
                    .txtPcIp.Text = viewlst.SubItems(6).Text
                    .cmdSave.Enabled = True
                    .btnTrigger.Enabled = True
                    .btnFind.Enabled = False
                    .txtSN.Focus()
                    Me.Close()
                End With
            End If
        Next
    End Sub

    Private Sub HeaderPanel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseDown
        frm = Form_Mouse_Down(Me, True)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub HeaderPanel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseMove
        Set_Move_Drag(Me)
    End Sub

    Private Sub HeaderPanel_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseUp
        frm = Form_Mouse_Down(Me, False)
    End Sub
End Class