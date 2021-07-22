Public Class frmManualBar

    Private Sub txtDName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown

      
        If e.KeyCode = Keys.Enter Then
            Try

                HexCardID = vbNullString
                HexCardID = txtBarcode.Text

                If txtBarcode.Text = vbNullString Then Exit Sub

                If frmMain.getTimein(HexCardID) = False Then
                    Try
                        Dim yr As String = Trim(Mid(HexCardID, 1, 4))
                        Dim mm As String = Trim(Mid(HexCardID, 5, 2))
                        Dim arw As String = Trim(Mid(HexCardID, 7, 2))

                        Dim H As String = Trim(Mid(HexCardID, 9, 2))
                        Dim Mn As String = Trim(Mid(HexCardID, 11, 2))

                        tmeIn = yr & "-" & mm & "-" & DD & " " & H & ":" & Mn & ":00"
                        EntryTime = vbNullString
                        EntryTime = Format(CDate(tmeIn), "yyyy-MM-dd HH:mm:ss")
                    Catch ex As Exception
                        txtBarcode.Text = vbNullString
                        Exit Sub
                    End Try
                End If

                frmMain.InPic.Image = Get_PicIn(HexCardID)
                frmMain.DriverImage.Image = Get_PicDriver(HexCardID)

                With frmTransact
                    Me.Hide()
                    Me.Close()
                    .txtPlate.Text = frmMain.ViewPlate(HexCardID)
                    .ShowDialog()
                End With
            Catch ex As Exception
                txtBarcode.Text = vbNullString
            End Try

            txtBarcode.Text = vbNullString

         
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

End Class