Imports ADODB
Public Class frmAccDesig

    Private Sub frmAccDesig_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstList.Clear()
        header()

        If conLocal() = True Then
            fillL()
        End If

        Reset()
        resetAdd()
        txtDesig.Enabled = False
    End Sub

    Sub header()
        Dim w As Integer = lstList.Width
        lstList.Columns.Add("Account Designation", w, HorizontalAlignment.Left)
    End Sub

    Sub fillL()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = conSqlLoc.Execute("select * from tblaccdesig")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Desig").Value, lup)
                rs.MoveNext()
            Next
        End If
    End Sub

    Function chkExist(ByVal desig As String) As Boolean
        If conLocal() = False Then Return False

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblaccdesig where Desig = '" & desig & "'")
            If rs.EOF = False Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try
    End Function

    Sub SaveDesig()
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim C_Logo As Integer
            Dim C_setting As Integer
            Dim C_SystemAcc As Integer
            Dim C_Vehicle As Integer
            Dim C_Charging As Integer
            Dim C_FlatRate As Integer
            Dim C_CutOff As Integer
            Dim C_CashOut As Integer
            Dim C_Reports As Integer
            Dim C_Terminate As Integer

            If chkLogo.Checked = True Then
                C_Logo = 1
            Else
                C_Logo = 0
            End If

            If chkSettings.Checked = True Then
                C_setting = 1
            Else
                C_setting = 0
            End If

            If chkAccSetting.Checked = True Then
                C_SystemAcc = 1
            Else
                C_SystemAcc = 0
            End If

            If chkVehicle.Checked = True Then
                C_Vehicle = 1
            Else
                C_Vehicle = 0
            End If

            If chkCharging.Checked = True Then
                C_Charging = 1
            Else
                C_Charging = 0
            End If

            If chkFlatSched.Checked = True Then
                C_FlatRate = 1
            Else
                C_FlatRate = 0
            End If

            If chkCutOff.Checked = True Then
                C_CutOff = 1
            Else
                C_CutOff = 0
            End If

            If chkCashOut.Checked = True Then
                C_CashOut = 1
            Else
                C_CashOut = 0
            End If

            If chkReports.Checked = True Then
                C_Reports = 1
            Else
                C_Reports = 0
            End If

            If chkTerminate.Checked = True Then
                C_Terminate = 1
            Else
                C_Terminate = 0
            End If

            Dim rs As New Recordset
            rs = New Recordset

            rs.Open("select * from tblaccdesig", conSqlLoc, 1, 2)
            rs.AddNew()
            rs("Desig").Value = txtDesig.Text
            rs("Logo").Value = C_Logo
            rs("Settings").Value = C_setting
            rs("Accounts").Value = C_SystemAcc
            rs("Vehicle").Value = C_Vehicle
            rs("Charging").Value = C_Charging
            rs("FlatRate").Value = C_FlatRate
            rs("CutOff").Value = C_CutOff
            rs("CashOut").Value = C_CashOut
            rs("Reports").Value = C_Reports
            rs("Terminate").Value = C_Terminate
            rs.Update()

            MsgBox("Successfully saved!", vbInformation, "Save")
        Catch ex As Exception

        End Try
    End Sub

    Sub ViewDesig(ByVal Desig As String)
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset

            rs = conSqlLoc.Execute("select * from tblaccdesig where Desig = '" & Desig & "'")
            If rs.EOF = False Then
                txtDesig.Text = rs("Desig").Value

                If rs("Logo").Value = 1 Then
                    chkLogo.Checked = True
                Else
                    chkLogo.Checked = False
                End If

                If rs("Settings").Value = 1 Then
                    chkSettings.Checked = True
                Else
                    chkSettings.Checked = False
                End If

                If rs("Accounts").Value = 1 Then
                    chkAccSetting.Checked = True
                Else
                    chkAccSetting.Checked = False
                End If

                If rs("Vehicle").Value = 1 Then
                    chkVehicle.Checked = True
                Else
                    chkVehicle.Checked = False
                End If

                If rs("Charging").Value = 1 Then
                    chkCharging.Checked = True
                Else
                    chkCharging.Checked = False
                End If

                If rs("FlatRate").Value = 1 Then
                    chkFlatSched.Checked = True
                Else
                    chkFlatSched.Checked = False
                End If

                If rs("CutOff").Value = 1 Then
                    chkCutOff.Checked = True
                Else
                    chkCutOff.Checked = False
                End If

                If rs("CashOut").Value = 1 Then
                    chkCashOut.Checked = True
                Else
                    chkCashOut.Checked = False
                End If

                If rs("Reports").Value = 1 Then
                    chkReports.Checked = True
                Else
                    chkReports.Checked = False
                End If

                If rs("Terminate").Value = 1 Then
                    chkTerminate.Checked = True
                Else
                    chkTerminate.Checked = False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, " ")
        End Try
    End Sub

    Sub reset()
        cmdAdd.Text = "&Add"

        chkLogo.Checked = False

        chkSettings.Checked = False

        chkAccSetting.Checked = False

        chkVehicle.Checked = False

        chkCharging.Checked = False

        chkFlatSched.Checked = False

        chkCutOff.Checked = False

        chkCashOut.Checked = False

        chkReports.Checked = False

        chkTerminate.Checked = False

        txtDesig.Text = vbNullString
    End Sub

    Sub resetAdd()

        chkLogo.Enabled = False

        chkSettings.Enabled = False

        chkAccSetting.Enabled = False

        chkVehicle.Enabled = False

        chkCharging.Enabled = False

        chkFlatSched.Enabled = False

        chkCutOff.Enabled = False

        chkCashOut.Enabled = False

        chkReports.Enabled = False

        chkTerminate.Enabled = False

    End Sub

    Sub AbleAdd()

        chkLogo.Enabled = True

        chkSettings.Enabled = True

        chkAccSetting.Enabled = True

        chkVehicle.Enabled = True

        chkCharging.Enabled = True

        chkFlatSched.Enabled = True

        chkCutOff.Enabled = True

        chkCashOut.Enabled = True

        chkReports.Enabled = True

        chkTerminate.Enabled = True

    End Sub

    Sub delDesig(ByVal desig As String)
        If conLocal() = False Then
            MsgBox("Please connect to database! ", vbExclamation, "Save")
            frmConnDB.ShowDialog()
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tblaccdesig where Desig = '" & desig & "'")

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Delete")
        End Try
    End Sub

    Private Sub cmdAdd_Click(sender As System.Object, e As System.EventArgs) Handles cmdAdd.Click
        If cmdAdd.Text = "&Add" Then
            txtDesig.Enabled = True
            txtDesig.Focus()
            reset()
            AbleAdd()
            cmdAdd.Text = "&Save"
        Else
            If txtDesig.Text = vbNullString Then
                MsgBox("Please input designation! ", vbExclamation, "Add")
                txtDesig.Focus()
                Exit Sub
            End If

            If txtDesig.Text = "Admin" Then
                MsgBox("Designation cannot be added, It's default designation that system already used! ", vbExclamation, "Add")
                txtDesig.Text = vbNullString
                txtDesig.Focus()
                Exit Sub
            End If

            If txtDesig.Text = "Operator" Then
                MsgBox("Designation cannot be added, It's default designation that system already used! ", vbExclamation, "Add")
                txtDesig.Text = vbNullString
                txtDesig.Focus()
                Exit Sub
            End If

            If chkExist(txtDesig.Text) = True Then
                MsgBox("Account designation already exist! ", vbExclamation, "Add")
                txtDesig.Text = vbNullString
                txtDesig.Focus()
                Exit Sub
            End If

            SaveDesig()
            lstList.Clear()
            header()
            fillL()
            reset()
            resetAdd()
            txtDesig.Enabled = False
            cmdAdd.Text = "&Add"
        End If
    End Sub

    Private Sub cmdDel_Click(sender As System.Object, e As System.EventArgs) Handles cmdDel.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Ate you sure do you want to delete this account designation? ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    delDesig(viewlst.SubItems(0).Text)
                    lstList.Clear()
                    header()
                    fillL()
                    reset()
                End If
            End If
        Next
    End Sub

    Private Sub cmdReset_Click(sender As System.Object, e As System.EventArgs) Handles cmdReset.Click
        reset()
        resetAdd()
        txtDesig.Enabled = False
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        Me.Close()
    End Sub

    Private Sub lstList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                resetAdd()
                txtDesig.Enabled = False
                ViewDesig(viewlst.SubItems(0).Text)
            End If
        Next
    End Sub
End Class