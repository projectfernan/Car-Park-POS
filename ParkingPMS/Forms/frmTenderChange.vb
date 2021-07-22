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

    Sub save()
        Dim rs As New Recordset
        Try
            With frmMain
                rs = New Recordset
                rs.Open("select * from tblIncomeReport", conSqlPOS, 1, 2)
                rs.AddNew()
                rs("ID").Value = id()
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
                rs.Update()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub saveL()
        Dim rs As New Recordset
        Try
            With frmMain
                rs = New Recordset
                rs.Open("select * from tblIncomeReport", conSqlLoc, 1, 2)
                rs.AddNew()
                rs("ID").Value = idL()
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

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
       
        print()
        frmMain.TopMost = True
        If Prnt() = True Then

            PoleDisOpen()
            clear()
            displayBye()
            PoleDisClose()

            If conServer() = True Then
                save()
                Update_OR()
                frmMain.lblORno.Text = Ticket_OR_No()
                delIn()
                d8_AuthenWr()
                d8_LoadpassWr()
                D8_Write()
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
            trigerOff()
            triger()
            frmMain.TopMost = False
            Me.Close()

        Else
            frmMain.TopMost = False
        End If
    End Sub

    Private Sub frmTenderChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class