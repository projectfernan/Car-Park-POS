Imports com.epson.pos.driver
Module Cash_Drawer
    Private DR_obj As New StatusAPI

    Public Function Kick_Drawer() As Boolean

        'ErrMSG = vbNullString

        Dim pname As String = My.Settings.PrinterDriver

        Try

            If DR_obj.OpenMonPrinter(OpenType.TYPE_PRINTER, pname) = ErrorCode.SUCCESS Then

                DR_obj.OpenDrawer(Drawer.EPS_BI_DRAWER_1, Pulse.EPS_BI_PULSE_100)

                DR_obj.CloseMonPrinter()

                Return True

            Else

                'ErrMSG = "Unable to Trigger the Cash Drawer"

                DR_obj.CloseMonPrinter()

                Return False

            End If

        Catch ex As Exception
            'ErrMSG = ex.Message
            Return False
        End Try

    End Function
End Module
