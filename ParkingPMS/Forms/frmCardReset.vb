Imports ADODB
Public Class frmCardReset

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If btnReset.Text = "&Read" Then
            txtCardCode.Text = "---"
            txtPlate.Text = "---"
            txtTimeIn.Text = "---"

re:         If d8_conn() = False Then
                MessageBox.Show("Device is not connected!", "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            txtCardCode.Text = d8_ReadOL()

            d8_Beep()

            If d8_Card() = False Then
                MessageBox.Show("Please place you card to reader!", "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                btnReset.Text = "&Read"

                txtCardCode.Text = "---"
                txtPlate.Text = "---"
                txtTimeIn.Text = "---"
                Exit Sub
            End If

            If readReset() = True Then
                MessageBox.Show("Card is already reset! Please try other card.", "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If delIn(txtCardCode.Text) = False Then
                End If

                txtCardCode.Text = "---"

                btnReset.Text = "&Read"
                Exit Sub
            End If

            Try
                txtPlate.Text = Mid(d8_ReadCardSector(14), 1, 7)
                txtTimeIn.Text = Format(CDate(d8_ReadCardSector(12)), "yyyy-MM-dd HH:mm")


                'If Len(txtCardCode.Text) > 3 Then
                '    retTimeIndb(txtCardCode.Text)
                'End If

                If txtCardCode.Text = "00000000" Then
                    GoTo re
                End If

                btnReset.Text = "&Reset"
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            If txtCardCode.Text <> d8_ReadOL() Then
                MessageBox.Show("Failed to reset card! Please don't remove the card after you read it.", "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                txtCardCode.Text = "---"
                txtPlate.Text = "---"
                txtTimeIn.Text = "---"

                btnReset.Text = "&Read"
                Exit Sub
            End If

            If d8_Card() = False Then
                MessageBox.Show("Please place you card to reader!", "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                txtCardCode.Text = "---"
                txtPlate.Text = "---"
                txtTimeIn.Text = "---"

                btnReset.Text = "&Read"
                Exit Sub
            End If

            If readReset() = True Then
                MessageBox.Show("Card is already reset! Please try other card.", "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If delIn(txtCardCode.Text) = False Then
                End If

                txtCardCode.Text = "---"
                txtPlate.Text = "---"
                txtTimeIn.Text = "---"

                btnReset.Text = "&Read"
                Exit Sub
            End If

            If MessageBox.Show("Are you sure do you want to reset this card?", "Card Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                If cardReset() = False Then Exit Sub

                If delIn(txtCardCode.Text) = False Then

                End If

                MessageBox.Show("Card is successfully reset!", "Card Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

                d8_halt()

                txtCardCode.Text = "---"
                txtPlate.Text = "---"
                txtTimeIn.Text = "---"

                btnReset.Text = "&Read"
            End If
        End If
    End Sub

    Function delIn(ByVal cardCode As String) As Boolean
        If conLocal() = False Then
            Return False
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from timeindb where CardCode='" & cardCode & "'")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function cardReset() As Boolean

        If D8_LoadKey(3) = False Then
            MsgBox("Failed to reset card data!")
            Return False
        End If

        If D8_Authenticate(3) = False Then
            MsgBox("Failed to reset card data!")
            Return False
        End If

        If D8_ResetCard(12) = False Then
            MsgBox("Failed to reset card data!")
            Return False
        End If

        If D8_ResetCard(13) = False Then
            MsgBox("Failed to reset card data!")
            Return False
        End If

        If D8_ResetCard(14) = False Then
            MsgBox("Failed to reset card data!")
            Return False
        End If

        d8_Beep()
        rd.dc_halt()

        Return True
    End Function

    Sub retTimeIndb(ByVal code As String)
        Try
            If conLocal() = False Then
                Exit Sub
            End If

            Dim rs As New Recordset

            rs = conSqlLoc.Execute("select Plate,TimeIn from timeindb where CardCode = '" & code & "'")

            If rs.EOF = False Then
                txtPlate.Text = rs("Plate").Value
                txtTimeIn.Text = Format(CDate(rs("TimeIn").Value), "yyyy-MM-dd HH:mm")
            Else
                If readReset() = True Then
                    txtPlate.Text = "Empty"
                    txtTimeIn.Text = "Empty"
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Reurn Timeindb", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function readReset() As Boolean
        If d8_Loadpass() = False Then
            Return False
        End If
        If d8_Authen() = False Then
            Return False
        End If

        If readCard() = False Then
            Return True
        End If
    End Function
End Class