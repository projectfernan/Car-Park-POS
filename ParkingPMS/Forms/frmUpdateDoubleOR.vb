Imports ADODB
Public Class frmUpdateDoubleOR


    Public Function Ticket_OR_No(ORno As Long, st As String) As String

        Dim Ticket As String = ORno
        Dim x As Integer = 1

        If Ticket.Length > 10 Then

            For x = 1 To 100
                Dim ss As String = "Station " & x
                If ss = st Then
                    Exit For
                End If
            Next
            Return x.ToString & "-" & Ticket
        Else

            If Ticket = 0 Then Ticket = 1

            Dim i As Integer = 8 - Ticket.Length
            Dim Nticket As String = New String("0", i)

            For x = 1 To 100
                Dim ss As String = "Station " & x
                If ss = st Then
                    Exit For
                End If
            Next

            Return x.ToString & "-" & Nticket & Ticket
        End If

    End Function

    Public Sub Update_OR(ORno As Long)
        Dim i As Long = ORno
        Dim s As Long = i + 1
        txtORCount.Value = s
    End Sub

    Public Sub Restore_OR()
        With My.Settings
            .OR_Number = 1
            .Save()
        End With
    End Sub

    Sub UpdateOR(ByVal st As String, ByVal ORNo As Long, ByVal dtFrm As Date, ByVal dtTo As Date)
        If conLocal() = False Then Exit Sub

        Dim lup As Long
        Dim petsaFrm As String = Format(dtFrm, "yyyy-MM-dd HH:mm:ss")
        Dim petsaTo As String = Format(dtTo, "yyyy-MM-dd HH:mm:ss")

        Dim ORnoIns As String

        Dim rs1 As New Recordset
        rs1 = New Recordset

        rs1 = conSqlLoc.Execute("select ID,ORno from tblincomereport where Station = '" & st & "' and TimeOut between '" & petsaFrm & "' and '" & petsaTo & "'")
        If rs1.EOF = False Then
            ProgBar.Maximum = rs1.RecordCount

            For lup = 1 To rs1.RecordCount
                ORnoIns = Ticket_OR_No(txtORCount.Value, st)

                Dim rs2 As New Recordset
                rs2 = New Recordset
                rs2 = conSqlLoc.Execute("update tblincomereport SET ORno = '" & ORnoIns & "' where ID =" & rs1("ID").Value & "")
                Update_OR(txtORCount.Value)
                ProgBar.Value = lup
                rs1.MoveNext()
            Next
            MsgBox("Doubled OR updated! ", vbInformation, "Update")
        End If
       
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        UpdateOR(cboStation.Text, txtORCount.Value, Da1.Value, Da2.Value)
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub frmUpdateDoubleOR_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProgBar.Value = 0
    End Sub
End Class