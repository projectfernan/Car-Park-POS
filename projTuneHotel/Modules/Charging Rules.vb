Imports ADODB
Module Charging_Rules
    Public Sub vtyp(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSqlPOS.Execute("SELECT * from tblvehicle")

        While rs.EOF = False
            cbo.Items.Add(rs("Vehicle").Value)
            rs.MoveNext()
        End While
    End Sub

    Public Sub vtypL(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * from tblVehicle")

        While rs.EOF = False
            cbo.Items.Add(rs("Vehicle").Value)
            rs.MoveNext()
        End While
    End Sub

    Public Sub vehicleCharging(ByVal cbo As ComboBox)
        If conLocal() = False Then Exit Sub

        Try
            Dim rs As New Recordset
            cbo.Items.Clear()

            rs = New Recordset
            rs = conSqlLoc.Execute("SELECT * from tblCharge order by KeyCode")

            While rs.EOF = False
                cbo.Items.Add(rs("VehicleType").Value)
                rs.MoveNext()
            End While

        Catch

        End Try
    End Sub

    Public Sub Discount(ByVal cbo As ComboBox)
        If conLocal() = False Then Exit Sub
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * from tblDiscount")

        While rs.EOF = False
            cbo.Items.Add(rs("DiscountName").Value)
            rs.MoveNext()
        End While
    End Sub

    Public Sub DiscountL(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = conSqlLoc.Execute("SELECT * from tblDiscount")

        While rs.EOF = False
            cbo.Items.Add(rs("DiscountName").Value)
            rs.MoveNext()
        End While
    End Sub
End Module
