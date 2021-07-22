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
            Me.Cursor = Cursors.WaitCursor
            rs1 = New Recordset
            rs1 = conSqlClient.Execute("select * from tblincomereport")
            lup = 0
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            Do While rs1.EOF = False
                If checkExist(rs1("ORno").Value) = True Then
                    rs1.MoveNext()
                    lup = lup + 1
                    Progbar.Value = lup
                    txtCnt.Text = lup
                Else
                    Dim INoutTotal As Long = rs1("InOutTotal").Value
                    Dim tendered As Double = rs1("Tendered").Value
                    Dim changes As Double = rs1("Change").Value
                    Dim LocTimeIn As String = Format(CDate(rs1("TimeIn").Value), "yyyy-MM-dd HH:mm:ss")
                    Dim LocTimeOut As String = Format(CDate(rs1("TimeIn").Value), "yyyy-MM-dd HH:mm:ss")
                    Dim LocBussDate As String = Format(CDate(rs1("BussDate").Value), "yyyy-MM-dd HH:mm:ss")

                    rs = New Recordset
                    rs = conSqlLoc.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,InOutTotal,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,Tendered,`Change`,VehicleType,PayType,RefNum,BussDate)VALUES('" _
                         & rs1("ORno").Value & _
                   "','" & rs1("CardCode").Value & _
                   "','" & rs1("Plate").Value & _
                   "','" & rs1("Operator").Value & _
                   "','" & rs1("Station").Value & _
                   "','" & LocTimeIn & _
                   "','" & LocTimeOut & _
                   "','" & rs1("TotalTime").Value & _
                   "','" & INoutTotal & _
                   "','" & CDbl(rs1("Hourly").Value) & _
                   "','" & CDbl(rs1("Overnigth").Value) & _
                   "','" & CDbl(rs1("LostCard").Value) & _
                   "','" & CDbl(rs1("Discount").Value) & _
                   "','" & CDbl(rs1("Total").Value) & _
                   "','" & CDbl(rs1("VAT").Value) & _
                   "','" & CDbl(rs1("SubTotal").Value) & _
                   "','" & tendered & _
                   "','" & changes & _
                   "','" & rs1("VehicleType").Value & _
                   "','" & rs1("PayType").Value & _
                   "','" & rs1("RefNum").Value & _
                   "','" & LocBussDate & "')")

                    'rs = New Recordset
                    'rs = conSqlLoc.Execute("select * from tblIncomeReport")

                    'rs.AddNew()
                    'rs("ORno").Value = rs1("ORno").Value
                    'rs("CardCode").Value = rs1("CardCode").Value
                    'rs("Plate").Value = rs1("Plate").Value
                    'rs("Operator").Value = rs1("Operator").Value
                    'rs("Station").Value = rs1("Station").Value
                    'rs("TimeIn").Value = rs1("TimeIn").Value
                    'rs("TimeOut").Value = rs1("TimeOut").Value
                    'rs("TotalTime").Value = rs1("TotalTime").Value
                    'rs("InOutTotal").Value = rs1("InOutTotal").Value
                    'rs("Hourly").Value = rs1("Hourly").Value
                    'rs("Overnigth").Value = rs1("Overnigth").Value
                    'rs("LostCard").Value = rs1("LostCard").Value
                    'rs("Discount").Value = rs1("Discount").Value
                    'rs("Total").Value = rs1("Total").Value
                    'rs("VAT").Value = rs1("VAT").Value
                    'rs("SubTotal").Value = rs1("SubTotal").Value
                    'rs("Tendered").Value = rs1("Tendered").Value
                    'rs("Change").Value = rs1("Change").Value
                    'rs("VehicleType").Value = rs1("VehicleType").Value
                    'rs("Discount").Value = rs1("Discount").Value
                    'rs("PayType").Value = rs1("PayType").Value
                    'rs("RefNum").Value = rs1("RefNum").Value
                    'rs("BussDate").Value = rs1("BussDate").Value
                    'rs.Update()
                    DelClient(rs1("ORno").Value)
                    rs1.MoveNext()
                    lup = lup + 1
                    Progbar.Value = lup
                    txtCnt.Text = lup
                End If
            Loop
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
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
        txtCnt.Text = 0
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
                    PushToServer()
                    cmdLoad.Visible = False
                    cmdFinish.Visible = True
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