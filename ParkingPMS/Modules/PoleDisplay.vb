Module PoleDisplay
    Public Function PoleDisOpen() As Boolean
        Try
            frmPoleDisplay.SerialPort1.PortName = frmPoleDisplay.cboCom.Text
            'frmPoleDisplay.SerialPort1.Open()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Sub PoleDisClose()
        Try
            frmPoleDisplay.SerialPort1.PortName = frmPoleDisplay.cboCom.Text
            frmPoleDisplay.SerialPort1.BaudRate = 9600
            frmPoleDisplay.SerialPort1.Parity = IO.Ports.Parity.None
            frmPoleDisplay.SerialPort1.StopBits = IO.Ports.StopBits.One
            frmPoleDisplay.SerialPort1.Close()
        Catch

        End Try
    End Sub

    Public Sub clear()
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write(Chr(12))
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub display()
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("  Welcome to Asian    Hospital Parking!")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub displayTotal(ByVal total As String)
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("Total Amount:" & total & "")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub displayChange(ByVal change As String, ByVal tender As String)
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("Tender:" & tender & "       Change:" & change & "")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub displayChange1k(ByVal change As String, ByVal tender As String)
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("Tender:" & tender & "      Change:" & change & "")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub displayBye()
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("     Thank you!      Please come again.   ")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Sub viewPDcom()
        On Error Resume Next
        With My.Settings
            frmPoleDisplay.cboCom.Text = .PD_Com
        End With
    End Sub
End Module
