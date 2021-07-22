Imports ADODB
Public Class frmDownload

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Function checkExist(ByVal ORno As String) As Boolean
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblincomereport where ORno = '" & ORno & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub PushToServer()
        Dim rs1 As New Recordset
        Dim rs As New Recordset
        Dim lup As Long
        Try

            rs1 = New Recordset
            rs1 = conSqlClient.Execute("select * from tblincomereport")
            lup = 0
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            Do While rs1.EOF = False
                rs = New Recordset
                rs.Open("select * from incomereport", conSqlLoc, 1, 2)

                If checkExist(rs1("TRno").Value) = True Then
                    rs1.MoveNext()
                    lup = lup + 1
                    Progbar.Value = lup

                Else
                    rs.AddNew()
                    rs("TRno").Value = rs1("ORno").Value
                    rs("CardCode").Value = rs1("CardCode").Value
                    rs("Plate").Value = rs1("Plate").Value
                    rs("Operator").Value = rs1("Operator").Value
                    rs("PC").Value = rs1("Station").Value
                    rs("TimeIn").Value = rs1("TimeIn").Value
                    rs("TimeOut").Value = rs1("TimeOut").Value
                    rs("TotalTime").Value = rs1("TotalTime").Value
                    rs("InOutTotal").Value = rs1("InOutTotal").Value
                    rs("Regular").Value = rs1("Hourly").Value
                    rs("Overnight").Value = rs1("Overnigth").Value
                    rs("LostCard").Value = rs1("LostCard").Value
                    rs("DiscountAmount").Value = rs1("Discount").Value
                    rs("Total").Value = rs1("Total").Value
                    rs("VAT").Value = rs1("VAT").Value
                    rs("NonVat").Value = rs1("SubTotal").Value
                    rs("VatExempt").Value = rs1("VatExempt").Value
                    rs("Tender").Value = rs1("Tendered").Value
                    rs("Change").Value = rs1("Change").Value
                    rs("Type").Value = rs1("VehicleType").Value
                    rs("Payment").Value = rs1("PayType").Value
                    rs("DiscountReference").Value = rs1("RefNum").Value
                    rs("DiscParkerName").Value = rs1("DiscParkerName").Value
                    rs("Status").Value = rs1("Status").Value
                    rs("BusnessDate").Value = rs1("BussDate").Value
                    rs.Update()
                    DelClient(rs1("TRno").Value)
                    rs1.MoveNext()
                    lup = lup + 1
                    Progbar.Value = lup
                    txtTrec2.Text = txtTRec.Text & "/" & lup.ToString
                End If
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub PushToServer2()
        Dim rs1 As New Recordset
        Dim rs As New Recordset
        Dim lup As Long
        Try

            rs1 = New Recordset
            rs1 = conSqlClient.Execute("select * from incomereport")
            lup = 0
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            Do While rs1.EOF = False
                rs = New Recordset
                rs.Open("select * from incomereport", conSqlLoc, 1, 2)

                If checkExist(rs1("TRno").Value) = True Then
                    rs1.MoveNext()
                    lup = lup + 1
                    Progbar.Value = lup

                Else
                    rs.AddNew()
                    rs("TRno").Value = rs1("TRno").Value
                    rs("CardCode").Value = rs1("CardCode").Value
                    rs("Plate").Value = rs1("Plate").Value
                    rs("Operator").Value = rs1("Operator").Value
                    rs("PC").Value = rs1("PC").Value
                    rs("TimeIn").Value = rs1("TimeIn").Value
                    rs("TimeOut").Value = rs1("TimeOut").Value
                    rs("TotalTime").Value = rs1("TotalTime").Value
                    rs("Regular").Value = rs1("Regular").Value
                    rs("Overnight").Value = rs1("Overnight").Value
                    rs("LostCard").Value = rs1("LostCard").Value
                    rs("DiscountAmount").Value = rs1("DiscountAmount").Value
                    rs("Total").Value = rs1("Total").Value
                    rs("VAT").Value = rs1("VAT").Value
                    rs("NonVat").Value = rs1("NonVat").Value
                    rs("VatExempt").Value = rs1("VatExemp").Value
                    rs("Tender").Value = rs1("Tender").Value
                    rs("Change").Value = rs1("Change").Value
                    rs("Type").Value = rs1("Type").Value
                    rs("Payment").Value = rs1("Payment").Value
                    rs("DiscountReference").Value = rs1("DiscountReference").Value
                    rs("Status").Value = rs1("Status").Value
                    rs("BusnessDate").Value = rs1("BusnessDate").Value
                    rs.Update()
                    DelClient(rs1("TRno").Value)
                    rs1.MoveNext()
                    lup = lup + 1
                    Progbar.Value = lup
                    txtTrec2.Text = txtTRec.Text & " / " & lup.ToString
                End If
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Sub DelClient(ornum As String)
        Try
            Dim rs As New Recordset

            rs = New Recordset
            rs = conSqlClient.Execute("delete from tblincomereport where ORno = '" & ornum & "'")
        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmDownload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdLoad.Visible = True
        cmdFinish.Visible = False
        Progbar.Value = 0
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        If txtTRec.Text = "0" Then
            MsgBox("No data to be download!", vbExclamation)
            Exit Sub
        End If

        If PingMe(C_ip) = True Then
            If conClient(C_ip, C_uid, C_pwd, C_port, C_db) = True Then
                If conLocal() = True Then
                    Dim identi As String = Trim(Mid(txtStation.Text, 1, 3))
                    If identi = "RPT" Then
                        PushToServer2()
                        cmdLoad.Visible = False
                        cmdFinish.Visible = True
                    Else
                        PushToServer()
                        cmdLoad.Visible = False
                        cmdFinish.Visible = True
                    End If
                Else
                    MsgBox("Please connect to database! ", vbExclamation, "Upload")
                End If
            Else
                MsgBox("Failed to connect!    ", vbExclamation, "Upload")
            End If
        Else
            MsgBox("Failed to connect!    ", vbExclamation, "Upload")
        End If
    End Sub

    Private Sub cmdFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinish.Click
        Me.Close()
    End Sub
End Class