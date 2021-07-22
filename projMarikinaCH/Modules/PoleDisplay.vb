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
        frmPoleDisplay.SerialPort1.Write("  Thank you for          Parking!")
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
        frmPoleDisplay.SerialPort1.Write("Tender:" & tender & "        Change:" & change & "")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub displayChange100(ByVal change As String, ByVal tender As String)
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("Tender:" & tender & "       Change:" & change & "")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub displayChange1k(ByVal change As String, ByVal tender As String)
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("Tender:" & tender & "       Change:" & change & "")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub displayBye()
        On Error Resume Next
        frmPoleDisplay.SerialPort1.Open()
        frmPoleDisplay.SerialPort1.Write("     Thank you!      Please come again.   ")
        frmPoleDisplay.SerialPort1.Close()
    End Sub

    Public Sub PD_Connect()
        Try
            With MainForm.SerialPort1
                .PortName = My.Settings.PD_Com
                If .IsOpen = False Then
                    .Open()
                End If
            End With
            errMsg = vbNullString
        Catch ex As Exception
            errMsg = "Pole Display: " & ex.Message
            Save_ErrLogs("[PD_Connect]", errMsg)
        End Try
    End Sub

    Public Sub PD_Disconnect()
        Try
            With MainForm.SerialPort1
                If .IsOpen = True Then .Close()
            End With
            errMsg = vbNullString
        Catch ex As Exception
            errMsg = "Pole Display: " & ex.Message
            Save_ErrLogs("[PD_Disconnect]", errMsg)
        End Try
    End Sub

    Public Sub PD_Display_Total(ByVal Data As String)
        Try
            PD_Connect()
            With MainForm.SerialPort1
                Dim s As String = New String(" ", 43)
                .WriteLine(s)
                .Write(Chr(12))
                .WriteLine("Total :    P " & Data & vbNewLine)
            End With
            PD_Disconnect()
            errMsg = vbNullString
        Catch ex As Exception
            errMsg = "Pole Display: " & ex.Message
            Save_ErrLogs("[PD_Display_Total]", errMsg)
        End Try
    End Sub

    Public Sub PD_Welcome()
        Try

            PD_Connect()

            Dim strL1 As String = "Thank you for"
            Dim strL2 As String = "Parking!"

            Dim L As Integer = strL1.Length
            Dim L2 As Integer = strL2.Length

            Dim Scp As String = vbNullString
            Dim scp2 As String = vbNullString

            If L >= 20 Then
            Else
                Dim i As Double = (20 - L) / 2
                Scp = New String(" ", i)
            End If

            If L2 >= 20 Then
            Else
                Dim i As Double = (20 - L2) / 2
                scp2 = New String(" ", i)
            End If

            With MainForm.SerialPort1
                Dim s As String = New String(" ", 43)
                .WriteLine(s)
                .Write(Chr(12))
                .WriteLine(My.Settings.PDwelcome1)
                .WriteLine(vbNewLine)
                .WriteLine(My.Settings.PDwelcome2)
            End With

            PD_Disconnect()
            errMsg = vbNullString
        Catch ex As Exception
            errMsg = "Pole Display: " & ex.Message
            Save_ErrLogs("[PD_Welcome]", errMsg)
        End Try
    End Sub

    Public Sub PD_Display_Change(ByVal Change As String, ByVal Tender As String)
        Try

            PD_Connect()

            With MainForm.SerialPort1
                Dim s As String = New String(" ", 43)
                .WriteLine(s)
                .WriteLine(Chr(12))
                .WriteLine("Tender :   P " & Tender)
                .WriteLine(vbNewLine)
                '.WriteLine(Chr(12))
                .WriteLine("Change :   P " & Change)
            End With

            PD_Disconnect()
            errMsg = vbNullString
        Catch ex As Exception
            errMsg = "Pole Display: " & ex.Message
            Save_ErrLogs("[PD_Display_Change]", errMsg)
        End Try
    End Sub

    Public Sub PD_Offline()
        Try

            PD_Connect()

            With MainForm.SerialPort1
                Dim s As String = New String(" ", 43)
                .WriteLine(s)
                .WriteLine(Chr(12))
                .WriteLine("      OFF-LINE      " & vbNewLine)
                .WriteLine("POS IS NOT AVAILABLE ")
            End With

            PD_Disconnect()
            errMsg = vbNullString
        Catch ex As Exception
            errMsg = "Pole Display: " & ex.Message
            Save_ErrLogs("[PD_Offline]", errMsg)
        End Try

    End Sub

End Module
