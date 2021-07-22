Imports ADODB
Module Tender_Module
    Function Get_ChangeAmt(ByVal total As Double, ByVal tender As Double) As Double
        Dim ch As Double
        ch = tender - total
        Return MakeMoney(ch)
    End Function

    Function Get_tender(ByVal total As Double, ByVal tenderAmt As Double) As Boolean
        If tenderAmt < total Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub printORticket(ByVal tenderAt As Double)
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
            P_CouponNo = frmRefNo.txtDocNo.Text

            P_HourLy = .lblAmountDue.Text
            P_Overnigth = .lblOvernigth.Text
            P_Lost = .lblLostCard.Text
            P_Total = .lblTotal.Text
            P_Vat = .lblVAT.Text
            P_Vatable = .lblSubTotal.Text
            P_VatExemp = .txtVatExempt.Text
            P_Tendered = MakeMoney(Val(tenderAt))
            P_Change = MakeMoney(Get_ChangeAmt(frmMain.lblTotal.Text, tenderAt))

            P_Discount = .lblDiscount.Text

            P_Teller = .TxtOp.Text
            P_Station = .txtStation.Text
            P_Machine = My.Settings.MACHINE
            P_Serial = My.Settings.SERIAL
            P_date = Format(Now, "yyyy-MM-dd")

            P_Msg = "THIS OFFICIAL RECEIPT SHALL BE VALID FOR" & vbNewLine & "          FIVE(5) YEARS FROM THE DATE OF" & vbNewLine & "                         THE PERMIT TO USE"
        End With
    End Sub

   
End Module
