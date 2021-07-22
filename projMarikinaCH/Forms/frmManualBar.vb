Public Class frmManualBar
    Dim frm As New FormMove

    Private Sub txtDName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown

      
        If e.KeyCode = Keys.Enter Then
            Try

                HexCardID = vbNullString
                HexCardID = txtBarcode.Text

                If txtBarcode.Text = vbNullString Then Exit Sub

                If MainForm.getTimein(HexCardID) = False Then
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

                MainForm.InPic.Image = Get_PicIn(HexCardID)
                MainForm.DriverImage.Image = Get_PicDriver(HexCardID)

                With frmTransact
                    Me.Hide()
                    Me.Close()
                    .txtPlate.Text = MainForm.ViewPlate(HexCardID)
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

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub HeaderPanel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseDown
        frm = Form_Mouse_Down(Me, True)
    End Sub

    Private Sub HeaderPanel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseMove
        Set_Move_Drag(Me)
    End Sub

    Private Sub HeaderPanel_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseUp
        frm = Form_Mouse_Down(Me, False)
    End Sub
End Class