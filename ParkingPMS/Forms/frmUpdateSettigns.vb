Imports ADODB
Public Class frmUpdateSettigns

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Sub delAcc()
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlClient.Execute("delete from tbluseracc")
        Catch ex As Exception

        End Try
    End Sub

    Sub delVehicle()
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlClient.Execute("delete from tblvehicle")
        Catch ex As Exception

        End Try
    End Sub

    Sub delcharging()
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlClient.Execute("delete from tblcharge")
        Catch ex As Exception

        End Try
    End Sub

    Sub delOvernight()
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlClient.Execute("delete from tblovernigth")
        Catch ex As Exception

        End Try
    End Sub

    Sub delDoscount()
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlClient.Execute("delete from tbldiscount")
        Catch ex As Exception

        End Try
    End Sub

    Sub upLoadAcc()
        Try
            Dim rs1 As New Recordset
            Dim rs2 As New Recordset
            Dim lup As Long

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblUserAcc")
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            lup = 0
            Do While rs1.EOF = False
                rs2 = New Recordset
                rs2.Open("select * from tblUserAcc", conSqlClient, 1, 2)
                rs2.AddNew()
                rs2("Username").Value = rs1("Username").Value
                rs2("Password").Value = rs1("Password").Value
                rs2("Name").Value = rs1("Name").Value
                rs2("Designation").Value = rs1("Designation").Value
                rs2.Update()
                lup = lup + 1
                Progbar.Value = lup
                rs1.MoveNext()
            Loop
            lstLoad.Items.Add("* Account settings successfully uploaded *")
            lstLoad.Items.Add(" ")
        Catch ex As Exception
            lstLoad.Items.Add(ex.Message)
        End Try
    End Sub

    Sub upLoadVehicle()
        Try
            Dim rs1 As New Recordset
            Dim rs2 As New Recordset
            Dim lup As Long

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblVehicle")
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            lup = 0
            Do While rs1.EOF = False
                rs2 = New Recordset
                rs2.Open("select * from tblvehicle", conSqlClient, 1, 2)
                rs2.AddNew()
                rs2("Vehicle").Value = rs1("Vehicle").Value
                rs2.Update()
                lup = lup + 1
                Progbar.Value = lup
                rs1.MoveNext()
            Loop

            lstLoad.Items.Add("* Vehicle Type settings successfully uploaded *")
            lstLoad.Items.Add(" ")
        Catch ex As Exception
            lstLoad.Items.Add(ex.Message)
        End Try
    End Sub

    Sub upLoadCharging()
        Try
            Dim rs1 As New Recordset
            Dim rs2 As New Recordset
            Dim lup As Long

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblcharge")
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            lup = 0
            Do While rs1.EOF = False
                rs2 = New Recordset
                rs2.Open("select * from tblcharge", conSqlClient, 1, 2)
                rs2.AddNew()
                rs2("VehicleType").Value = rs1("VehicleType").Value
                rs2("GracePeriod").Value = rs1("GracePeriod").Value
                rs2("MinMinutes").Value = rs1("MinMinutes").Value
                rs2("MinAmount").Value = rs1("MinAmount").Value
                rs2("IntAmount").Value = rs1("IntAmount").Value
                rs2("FlatRate").Value = rs1("FlatRate").Value
                rs2("LostCard").Value = rs1("LostCard").Value
                rs2.Update()
                lup = lup + 1
                Progbar.Value = lup
                rs1.MoveNext()
            Loop

            lstLoad.Items.Add("* Charging Rules successfully uploaded *")
            lstLoad.Items.Add(" ")
        Catch ex As Exception
            lstLoad.Items.Add(ex.Message)
        End Try
    End Sub

    Sub upLoadOvernigth()
        Try
            Dim rs1 As New Recordset
            Dim rs2 As New Recordset
            Dim lup As Long

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblovernigth")
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            lup = 0
            Do While rs1.EOF = False
                rs2 = New Recordset
                rs2.Open("select * from tblovernigth", conSqlClient, 1, 2)
                rs2.AddNew()
                rs2("VType").Value = rs1("VType").Value
                rs2("TimeStart").Value = rs1("TimeStart").Value
                rs2("TimeEnd").Value = rs1("TimeEnd").Value
                rs2("RateCharge").Value = rs1("RateCharge").Value
                rs2.Update()
                lup = lup + 1
                Progbar.Value = lup
                rs1.MoveNext()
            Loop

            lstLoad.Items.Add("* Overnight Charges successfully uploaded *")
            lstLoad.Items.Add(" ")
        Catch ex As Exception
            lstLoad.Items.Add(ex.Message)
        End Try
    End Sub

    Sub upLoadVat()
        Try
            Dim rs1 As New Recordset
            Dim rs2 As New Recordset
            Dim lup As Long

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblVat")
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            lup = 0
            If rs1.EOF = False Then
                rs2 = New Recordset
                rs2.Open("select * from tblvat", conSqlClient, 1, 2)
                rs2("Vat").Value = rs1("Vat").Value
                rs2.Update()
                lup = lup + 1
                Progbar.Value = lup
            End If

            lstLoad.Items.Add("* Vat Settings successfully uploaded *")
            lstLoad.Items.Add(" ")
        Catch ex As Exception
            lstLoad.Items.Add(ex.Message)
        End Try
    End Sub

    Sub upLoadDiscount()
        Try
            Dim rs1 As New Recordset
            Dim rs2 As New Recordset
            Dim lup As Long

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tbldiscount")
            Progbar.Value = 0
            Progbar.Maximum = rs1.RecordCount
            lup = 0
            Do While rs1.EOF = False
                rs2 = New Recordset
                rs2.Open("select * from tbldiscount", conSqlClient, 1, 2)
                rs2.AddNew()
                rs2("DiscountName").Value = rs1("DiscountName").Value
                rs2("Percentage").Value = rs1("Percentage").Value
                rs2("DiscountOption").Value = rs1("DiscountOption").Value
                rs2("VAToption").Value = rs1("VAToption").Value
                rs2.Update()
                lup = lup + 1
                Progbar.Value = lup
                rs1.MoveNext()
            Loop

            lstLoad.Items.Add("* Discount settings successfully uploaded *")
            lstLoad.Items.Add(" ")
        Catch ex As Exception
            lstLoad.Items.Add(ex.Message)
        End Try
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        If PingMe(C_ip) = True Then
            If conClient(C_ip, C_uid, C_pwd, C_port, C_db) = True Then
                If conLocal() = True Then
                    If chkSystemAcc.Checked = True Then
                        delAcc()
                        upLoadAcc()
                    End If

                    If chkVehicle.Checked = True Then
                        delVehicle()
                        upLoadVehicle()
                    End If

                    If chkCharging.Checked = True Then
                        delcharging()
                        upLoadCharging()
                    End If

                    If chkOverNigth.Checked = True Then
                        delOvernight()
                        upLoadOvernigth()
                    End If

                    If chkVat.Checked = True Then
                        upLoadVat()
                    End If

                    If chkDiscount.Checked = True Then
                        delDoscount()
                        upLoadDiscount()
                    End If

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

    Private Sub frmUpdateSettigns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdFinish.Visible = False
        cmdLoad.Visible = True

        chkCharging.Checked = False
        chkOverNigth.Checked = False
        chkSystemAcc.Checked = False
        chkVat.Checked = False
        chkVehicle.Checked = False
        chkDiscount.Checked = False

        lstLoad.Items.Clear()
        Progbar.Value = 0
    End Sub
End Class