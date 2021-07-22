Imports ADODB
Imports System.Data.OleDb

Module MsAccessConn
    Public connMS As New Connection
    Public dtQ As DataTable = New DataTable
    Public dtDgv As DataTable = New DataTable
    Public fLogsPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\fLogs.accdb;jet OLEDB:Database Password=pr0J3ctf"

    Public Function ConnFLogs() As Boolean
        Try
            If connMS.State = ConnectionState.Open Then connMS.Close()
            connMS = New Connection
            connMS.CursorLocation = CursorLocationEnum.adUseClient
            connMS.Open(fLogsPath)
            Return True
        Catch ex As Exception
            errMsg = "fLogs Conn: " & ex.Message
            'MessageBox.Show(errMsg)
            Return False
        End Try
    End Function

    Public Function rsFlogsCUD(ByVal strQuery As String) As Boolean
        Try
            If ConnFLogs() = False Then
                Return False
            End If

            Dim rs As New Recordset
            rs = connMS.Execute(strQuery)
            Return True
        Catch ex As Exception
            errMsg = "fLogs query:" & ex.Message
            Return False
        End Try
    End Function

    Public Function rsFlogsQuery(ByVal strQuery As String) As DataTable
        Try
            dtQ = New DataTable

            If ConnFLogs() = False Then
                Return dtQ
            End If

            Dim OleAdapter As OleDbDataAdapter = New OleDbDataAdapter

            Dim rs As New Recordset
            rs = connMS.Execute(strQuery)

            OleAdapter.Fill(dtQ, rs)

            Return dtQ
        Catch ex As Exception
            errMsg = ex.Message
            dtQ = New DataTable
            Return dtQ
        End Try
    End Function

    Public Function LoadDgvData(ByVal dgv As DataGridView, ByVal query As String, ByVal HdAutoRez As Boolean) As Boolean
        Try
            dtDgv = New DataTable
            dtDgv = rsFlogsQuery(query)

            If dtDgv IsNot Nothing Then
                dgv.DataSource = dtDgv
            End If

            Dim HdCnt As Integer = dgv.Columns.Count
            Dim HdLup As Integer = 0
            Dim HdW As Integer = (dgv.Width - dgv.RowHeadersWidth) / HdCnt

            Do While HdLup <> HdCnt
                dgv.Columns(HdLup).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                If HdAutoRez = True Then
                    dgv.Columns(HdLup).Width = HdW
                End If
                HdLup = HdLup + 1
            Loop

            Return True
        Catch ex As Exception
            errMsg = "LoadDgvData: " & ex.Message
            Return False
        End Try
    End Function

End Module
