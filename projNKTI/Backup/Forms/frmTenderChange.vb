Imports ADODB
Public Class frmTenderChange
    Function id() As String
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblIncomeReport", conSqlPOS, 1, 2)
        id = rs.RecordCount + 1
    End Function

    Function idL() As String
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblIncomeReport", conSqlLoc, 1, 2)
        idL = rs.RecordCount + 1
    End Function

    Sub saveToServer()
        Dim rs As New Recordset
        Try
            With frmMain
                rs = New Recordset
                rs = conSqlPOS.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,Tendered,`Change`,VehicleType,RefNum)VALUES('" _
                        & .lblORno.Text & _
                  "','" & HexCardID & _
                  "','" & .lblPlate.Text & _
                  "','" & .TxtOp.Text & _
                  "','" & .txtStation.Text & _
                  "','" & .lblTimeIn.Text & _
                  "','" & .lblTimeOut.Text & _
                  "','" & .lblTotalTime.Text & _
                  "','" & CInt(.lblAmountDue.Text) & _
                  "','" & CInt(.lblOvernigth.Text) & _
                  "','" & CInt(.lblLostCard.Text) & _
                  "','" & CInt(.lblDiscount.Text) & _
                  "','" & CInt(.lblTotal.Text) & _
                  "','" & CInt(.lblVAT.Text) & _
                  "','" & CInt(.lblSubTotal.Text) & _
                  "','" & CInt(lblTender.Text) & _
                  "','" & CInt(lblChange.Text) & _
                  "','" & .lblVtype.Text & _
                  "','" & frmAddDiscount.txtRef.Text & "')")
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub save()
        Dim rs As New Recordset
        Try
            With frmMain
                rs = New Recordset
                rs.Open("select * from tblIncomeReport where 1=0", conSqlPOS, 1, 2)
                rs.AddNew()
                rs("ORno").Value = .lblORno.Text
                rs("CardCode").Value = HexCardID
                rs("Plate").Value = .lblPlate.Text
                rs("Operator").Value = .TxtOp.Text
                rs("Station").Value = .txtStation.Text
                rs("TimeIn").Value = .lblTimeIn.Text
                rs("TimeOut").Value = .lblTimeOut.Text
                rs("TotalTime").Value = .lblTotalTime.Text
                rs("Hourly").Value = .lblAmountDue.Text
                rs("Overnigth").Value = .lblOvernigth.Text
                rs("LostCard").Value = .lblLostCard.Text
                rs("Discount").Value = .lblDiscount.Text
                rs("Total").Value = .lblTotal.Text
                rs("VAT").Value = .lblVAT.Text
                rs("SubTotal").Value = .lblSubTotal.Text
                rs("Tendered").Value = lblTender.Text
                rs("Change").Value = lblChange.Text
                rs("VehicleType").Value = .lblVtype.Text
                rs("Discount").Value = .lblDiscount.Text
                rs("RefNum").Value = frmAddDiscount.txtRef.Text
                rs.Update()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Function chkExistOR(ByVal orNumber As String) As Boolean
        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlPOS.Execute("select ORno from tblincomereport where ORno = '" & orNumber & "' limit 1;")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function

    Sub PushToServer()
        Dim rs1 As New Recordset
        Dim rs As New Recordset
        Try

            rs1 = New Recordset
            rs1 = conSqlLoc.Execute("select * from tblincomereport")
            Do While rs1.EOF = False
                If chkExistOR(rs1("ORno").Value) = False Then

                    Dim inOras As String = Format(CDate(rs1("TimeIn").Value), "yyyy-MM-dd HH:mm:ss")
                    Dim outOras As String = Format(CDate(rs1("TimeOut").Value), "yyyy-MM-dd HH:mm:ss")

                    rs = New Recordset
                    rs = conSqlPOS.Execute("insert into tblincomereport(ORno,CardCode,Plate,Operator,Station,TimeIn,TimeOut,TotalTime,Hourly,Overnigth,LostCard,Discount,Total,VAT,SubTotal,Tendered,`Change`,VehicleType,RefNum)VALUES('" _
                          & rs1("ORno").Value & _
                    "','" & rs1("CardCode").Value & _
                    "','" & rs1("Plate").Value & _
                    "','" & rs1("Operator").Value & _
                    "','" & rs1("Station").Value & _
                    "','" & inOras & _
                    "','" & outOras & _
                    "','" & rs1("TotalTime").Value & _
                    "','" & rs1("Hourly").Value & _
                    "','" & rs1("Overnigth").Value & _
                    "','" & rs1("LostCard").Value & _
                    "','" & rs1("Discount").Value & _
                    "','" & rs1("Total").Value & _
                    "','" & rs1("VAT").Value & _
                    "','" & rs1("SubTotal").Value & _
                    "','" & rs1("Tendered").Value & _
                    "','" & rs1("Change").Value & _
                    "','" & rs1("VehicleType").Value & _
                    "','" & rs1("RefNum").Value & "')")

                    DelLocal(rs1("ORno").Value)

                    rs1.MoveNext()
                End If
            Loop
        Catch ex As Exception

        End Try
    End Sub

    Sub saveL()
        Dim rs As New Recordset
        Try
            With frmMain
                rs = New Recordset
                rs.Open("select * from tblIncomeReport where 1=0", conSqlLoc, 1, 2)
                rs.AddNew()
                rs("ORno").Value = .lblORno.Text
                rs("CardCode").Value = HexCardID
                rs("Plate").Value = .lblPlate.Text
                rs("Operator").Value = .TxtOp.Text
                rs("Station").Value = .txtStation.Text
                rs("TimeIn").Value = .lblTimeIn.Text
                rs("TimeOut").Value = .lblTimeOut.Text
                rs("TotalTime").Value = .lblTotalTime.Text
                rs("Hourly").Value = .lblAmountDue.Text
                rs("Overnigth").Value = .lblOvernigth.Text
                rs("LostCard").Value = .lblLostCard.Text
                rs("Discount").Value = .lblDiscount.Text
                rs("Total").Value = .lblTotal.Text
                rs("VAT").Value = .lblVAT.Text
                rs("SubTotal").Value = .lblSubTotal.Text
                rs("Tendered").Value = lblTender.Text
                rs("Change").Value = lblChange.Text
                rs("VehicleType").Value = .lblVtype.Text
                rs("Discount").Value = .lblDiscount.Text
                rs("RefNum").Value = frmAddDiscount.txtRef.Text
                rs.Update()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub print()
        With frmMain
            P_ORno = .lblORno.Text
            P_Permit = My.Settings.PERMIT
            P_TIN = My.Settings.TIN
            P_ACCR = My.Settings.ACCR
            P_CardCode = HexCardID
            P_EntTime = .lblTimeIn.Text
            P_ExtTime = .lblTimeOut.Text
            P_TotalTime = .lblTotalTime.Text
            P_Vehicle = .lblVtype.Text
            P_PlateNo = .lblPlate.Text

            P_HourLy = .lblAmountDue.Text
            P_Overnigth = .lblOvernigth.Text
            P_Lost = .lblLostCard.Text
            P_Total = .lblTotal.Text
            P_Vat = .lblVAT.Text
            P_Vatable = .lblSubTotal.Text
            P_Tendered = lblTender.Text
            P_Change = lblChange.Text

            P_Discount = .lblDiscount.Text

            P_Teller = .TxtOp.Text
            P_Station = .txtStation.Text
            P_Machine = My.Settings.MACHINE
            P_Serial = My.Settings.SERIAL
            P_date = Format(Now, "General Date")

            P_Msg = "* THIS SERVES AS AN OFFICIAL RECEIPT *"
        End With
    End Sub

    Sub updateSlot()
        Dim rs As New Recordset
        Try
            rs = New Recordset

            rs.Open("select * from ParkingSlot", conSqlPOS, 1, 2)
            rs("TOTAL").Value = Val(rs("TOTAL").Value) + 1
            rs.Update()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Update Parking Slot")
        End Try
    End Sub

    Sub delIn()
        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlPOS.Execute("delete from timeindb where CardCode='" & HexCardID & "'")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Delete")
        End Try
    End Sub

    Public Sub DelLocal(ByVal orNum As String)

        Dim rs As New Recordset
        Try
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblincomereport where ORno = '" & orNum & "'")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
       
        'print()
        frmMain.TopMost = True
        'Prnt()

        PoleDisOpen()
        clear()
        displayBye()
        PoleDisClose()

        triger()

        If conServer() = True Then
            saveToServer()
            If My.Settings.DataPool = False Then
                PushToServer()
            End If
            Update_OR()
            frmMain.lblORno.Text = Ticket_OR_No()
            delIn()
            d8_AuthenWr()
            d8_LoadpassWr()
            D8_Write()
            frmMain.txtSlot.Text = slot()
        Else
            If conLocal() = True Then
                saveL()
                Update_OR()
                frmMain.lblORno.Text = Ticket_OR_No()
                d8_AuthenWr()
                d8_LoadpassWr()
                D8_Write()
            Else
                MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                frmConnDB.ShowDialog()
                Exit Sub
            End If
        End If

        kansela()
        'triger()
        frmMain.TopMost = False
        Me.Close()

    End Sub
End Class