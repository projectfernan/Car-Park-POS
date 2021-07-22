Imports ADODB
Module Charging_Data

#Region "Hourly Charging Info"
    Public Structure Charging_Hourly
        Public Grace As Long
        Public MinMins As Long
        Public MinAmt As Double
        Public IntAmt As Double
    End Structure

    Public Function Get_Charging_Hourly(ByVal Veh As String) As Charging_Hourly
        Dim f As New Charging_Hourly

        Try
            If conLocal() = False Then
                f.Grace = 0
                f.MinMins = 0
                f.MinAmt = 0
                f.IntAmt = 0
                Return f
            End If

            Dim rs As New Recordset
            rs = conSqlLoc.Execute("select * from tblcharge where VehicleType = '" & Veh & "'")
            If rs.EOF = False Then
                Dim MIN As Long = 0
                f.Grace = CLng(rs("GracePeriod").Value)
                f.MinMins = CLng(rs("MinMinutes").Value)
                f.MinAmt = CDbl(rs("MinAmount").Value)
                f.IntAmt = CDbl(rs("IntAmount").Value)
                Return f
            Else
                f.Grace = 0
                f.MinMins = 0
                f.MinAmt = 0
                f.IntAmt = 0
                Return f
            End If
        Catch ex As Exception
            Save_ErrLogs("[Get_Charging_Info]", ex.Message)
            Return f
        End Try
    End Function
#End Region

#Region "Overnight Charging Info"
    Public Structure Charging_Overnight
        Public OvCharge As Long
        Public OvStartTme As DateTime
        Public OvEndTme As DateTime
    End Structure

    Public Function Get_Charging_Overnight(ByVal Veh As String) As Charging_Overnight
        Dim f As New Charging_Overnight
        Try
            Dim rsOV As New Recordset

            rsOV = conSqlLoc.Execute("select * from tblovernigth where VType = '" & Veh & "'")
            If rsOV.EOF = False Then
                f.OvCharge = CDbl(rsOV("RateCharge").Value)
                f.OvStartTme = CDate(rsOV("TimeStart").Value)
                f.OvEndTme = CDate(rsOV("TimeEnd").Value)
                Return f
            Else
                f.OvCharge = CDbl(rsOV("RateCharge").Value)
                f.OvStartTme = CDate(rsOV("TimeStart").Value)
                f.OvEndTme = CDate(rsOV("TimeEnd").Value)
                Return f
            End If
        Catch ex As Exception
            Save_ErrLogs("[Get_Charging_Overnight]", ex.Message)
            Return f
        End Try
    End Function
#End Region

End Module
