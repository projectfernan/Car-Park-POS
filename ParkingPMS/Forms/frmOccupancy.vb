Imports ADODB
Public Class frmOccupancy

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmLengthStay_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        PMSmain.tmeSlot.Enabled = True
        PMSmain.TmrRead.Enabled = True
    End Sub

    Private Sub frmLengthStay_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        PMSmain.tmeSlot.Enabled = False
        PMSmain.TmrRead.Enabled = False
        ProgBar.Value = 0
    End Sub

    Function VehTotalIn() As Integer
        If conLocal() = False Then
            Return 0
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from timeindb")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function VehTotalInLogs(dtF As Date, dtT As Date) As Integer
        ' If conLocal() = False Then
        'Return 0
        ' End If

        Dim p1 As String = Format(dtF, "yyyy-MM-dd HH:mm:ss")
        Dim p2 As String = Format(dtT, "yyyy-MM-dd HH:mm:ss")

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from timeindb where TimeIn between '" & p1 & "' and '" & p2 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function VehTotalInNow(dtF As Date, dtT As Date) As Integer
        ' If conLocal() = False Then
        'Return 0
        ' End If

        Dim p1 As String = Format(dtF, "yyyy-MM-dd HH:mm:ss")
        Dim p2 As String = Format(dtT, "yyyy-MM-dd HH:mm:ss")

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from tblincomereport where TimeIn between '" & p1 & "' and '" & p2 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function VehTotalInLogs(dtF As Date) As Integer
        '' If conLocal() = False Then
        'Return 0
        ' End If

        Dim p1 As String = Format(dtF, "yyyy-MM-dd HH:mm:ss")
        ' Dim p2 As String = Format(dtT, "yyyy-MM-dd HH:mm:ss")

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from timeindb where TimeIn like '" & p1 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function VehTotalOut(dtF As Date, dtT As Date) As Integer
        If conLocal() = False Then
            Return 0
        End If

        Dim p1 As String = Format(dtF, "yyyy-MM-dd HH:mm:ss")
        Dim p2 As String = Format(dtT, "yyyy-MM-dd HH:mm:ss")

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from vwetrcntperhr where TimeHR Between '" & p1 & "' and '" & p2 & "'")
            If rs.EOF = False Then
                Return rs.RecordCount
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function TotalSlot() As Integer
        If conLocal() = False Then
            Return 0
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from parkingslot")
            Return rs("TOTAL").Value
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Sub delOccTbl()
        If conLocal() = False Then
            Exit Sub
        End If

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("delete from tbloccupancy")
        Catch ex As Exception

        End Try
    End Sub

    Sub SaveOccu(dtF As Date, dtT As Date)
        If conLocal() = False Then
            Exit Sub
        End If

        Dim p1 As String = Format(dtF, "yyyy-MM-dd HH:mm:ss")
        Dim p2 As String = Format(dtT, "yyyy-MM-dd HH:mm:ss")
        Dim Tslot As Integer = TotalSlot()
        Dim totalin As Integer = VehTotalIn()

        Dim sTme As Date = dtF
        Dim CntStat As Long = 0

        Dim lup As Long = 0

        Try
            Dim rs As New Recordset
            rs = New Recordset
            rs = conSqlLoc.Execute("select * from vwetrcntperhr where TimeHR Between '" & p1 & "' and '" & p2 & "'")

            If rs.EOF = False Then
                Me.Cursor = Cursors.WaitCursor
                ProgBar.Maximum = rs.RecordCount
            End If

            Do While rs.EOF = False


                Dim rs1 As New Recordset
                rs1 = New Recordset
                Dim TotalTR As Integer = rs("TotalOut").Value
                Dim oras As Date = rs("TimeHr").Value
                Dim totalInNow As Integer = CntStat + VehTotalInNow(sTme, oras) + VehTotalInLogs(sTme, oras)

                Dim totalInDpat As Integer = VehTotalInNow(sTme, oras) + VehTotalInLogs(sTme, oras)

                rs1.Open("select * from tbloccupancy where 1=0", conSqlLoc, 1, 2)
                rs1.AddNew()
                rs1("Time").Value = oras
                rs1("TotalSlot").Value = Tslot
                rs1("TotalIn").Value = totalInDpat
                rs1("TotalOut").Value = TotalTR
                Dim Occu As Integer = totalInNow - TotalTR
                rs1("Occupancy").Value = Occu
                rs1.Update()

                sTme = oras
                CntStat = Occu

                lup = lup + 1

                ProgBar.Value = lup

                rs.MoveNext()
            Loop
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click
        Dim dF As String = Format(Da1.Value, "yyyy-MM-dd HH:mm:ss")
        Dim dT As String = Format(Da2.Value, "yyyy-MM-dd HH:mm:ss")
        Dim Rpath As String = Application.StartupPath & "\Reports\crOccupancy.rpt"
        Dim rs As New Recordset

        If conLocal() = False Then Exit Sub

        delOccTbl()
        SaveOccu(Da1.Value, Da2.Value)

        Try
            rs = conSqlLoc.Execute("Select * From tbloccupancy")
            If rs.EOF = False Then

                Dim RR As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                RR.Load(Rpath)
                RR.SetDataSource(rs)

                Dim a As New frmPrevPrint
                With a
                    .CrystalReportViewer1.ReportSource = RR
                    .ShowDialog()
                End With

            Else
                MsgBox("No Record Found", MsgBoxStyle.Information, "Pickload Report")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Pickload Report")
        End Try
    End Sub
End Class