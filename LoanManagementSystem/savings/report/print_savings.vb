Imports MySql.Data.MySqlClient
Public Class print_savings
    Dim savings_id As Integer
    Dim dt_savings As New DataTable

    Dim status As String
    Dim withdraw As String
    Dim deposit As String
    Dim balance As String
    Dim teller As String
    Dim date_transac As String

    Private Sub print_savings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dt_savings
            .Columns.Add("status", GetType(String))
            .Columns.Add("withdraw", GetType(String))
            .Columns.Add("deposit", GetType(String))
            .Columns.Add("balance", GetType(String))
            .Columns.Add("teller", GetType(String))
            .Columns.Add("date_transac", GetType(String))
            .Columns.Add("number", GetType(Int32))

        End With

    End Sub
    Public Sub loaddata(stat As String, withd As String, dep As String, bal As String, tel As String, datet As String)
        status = stat
        withdraw = withd
        deposit = dep
        balance = bal
        teller = tel
        date_transac = datet

    End Sub

    Private Sub loadrpt_small()
        'Dim myrpt As New print_serial
        Dim myrpt As New savings_transac
        ' Check if dt_records contains data
        If dt_savings Is Nothing OrElse dt_savings.Rows.Count = 0 Then
            MessageBox.Show("No data available for the report.")
            Exit Sub
        End If

        ' Clear existing report source
        CrystalReportViewer1.ReportSource = Nothing

        Try
            myrpt.SetDataSource(dt_savings)
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error setting report data source: " & ex.Message)
        End Try
    End Sub


    'Private Sub PrintReport(id As String)
    '    Try
    '        dt_savings.Clear()

    '        ' Add empty rows
    '        For i As Integer = 1 To Convert.ToInt32(num_count.Value)
    '            Dim emptyRow As DataRow = dt_savings.NewRow()
    '            dt_savings.Rows.InsertAt(emptyRow, 0)
    '        Next

    '        'Dim myrpt As New print_serial
    '        Dim myrpt As New boxQR
    '        ' Check if dt_records contains data
    '        If dt_small Is Nothing OrElse dt_small.Rows.Count = 0 Then
    '            MessageBox.Show("No data available for the report.")
    '            Exit Sub
    '        End If

    '        ' Clear existing report source
    '        CrystalReportViewer1.ReportSource = Nothing

    '        Try
    '            myrpt.SetDataSource(dt_small)
    '            CrystalReportViewer1.ReportSource = myrpt
    '        Catch ex As Exception
    '            MessageBox.Show("Error setting report data source: " & ex.Message)
    '        End Try
    'End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        dt_savings.Clear()


        ' Generate QR codes and fill DataTable
        For i As Integer = 1 To Convert.ToInt32(num_count.Value) - 1
            Dim emptyRow As DataRow = dt_savings.NewRow()
            dt_savings.Rows.InsertAt(emptyRow, 0)
        Next
        dt_savings.Rows.Add(status, withdraw, deposit, balance, teller, date_transac, num_count.Value)
        loadrpt_small()
    End Sub
End Class