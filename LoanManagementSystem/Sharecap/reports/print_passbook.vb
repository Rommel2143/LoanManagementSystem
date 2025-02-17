﻿Imports MySql.Data.MySqlClient
Public Class print_passbook
    Dim passbook_id As Integer
    Private Sub print_passbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub print_pass(id As String)
        passbook_id = id
        Dim myrpt As New sharecappassbook
        Dim dt As New DataTable
        Dim datagridview1 As New DataGridView
        Try
            ' Clear and set up the DataGridView
            datagridview1.DataSource = Nothing
            datagridview1.Rows.Clear()

            con.Close()
            con.Open()
            Dim newprint As Boolean
            If num_count.Value = 1 Then
                newprint = 1
            Else
                newprint = 0
            End If

            Dim showreport As New MySqlCommand("SELECT 
   IF(@newprint = 1, UPPER(CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename)),'') AS Fullname,
    IF(@newprint = 1,sc.account_no,'') AS account_no,
    sc.status,  -- Transaction Code = Status
    -- Withdrawals: Amounts where status is 'DM' or 'CA'
    CASE 
        WHEN sc.status IN ('DM', 'CA') THEN sc.amount 
        ELSE 0 
    END AS `withdraw`,
    -- Deposits: Amounts where status is NOT 'DM' or 'CA'
    CASE 
        WHEN sc.status NOT IN ('DM', 'CA') THEN sc.amount 
        ELSE 0 
    END AS `deposit`,
    -- Balance: Running total of withdrawals and deposits
    (
        SELECT SUM(
            CASE 
                WHEN t2.status IN ('DM', 'CA') THEN -t2.amount  -- Withdrawals decrease balance
                ELSE t2.amount  -- Deposits increase balance
            END
        ) 
        FROM sharecap AS t2 
        WHERE t2.account_no = sc.account_no 
          AND t2.date_transac <= sc.date_transac
          AND t2.id <= sc.id  -- Ensure the running balance is calculated up to this transaction
    ) AS `balance`,
  u.initials AS teller
FROM sharecap sc
JOIN member_profile mp ON mp.account_no = sc.account_no
JOIN user u ON u.account_no = sc.teller
WHERE sc.id = @id -- Parameterized query to avoid SQL injection
ORDER BY sc.date_transac, sc.id;
", con)

            ' Add parameters
            showreport.Parameters.AddWithValue("@id", id)
            showreport.Parameters.AddWithValue("@newprint", newprint)
            Dim da As New MySqlDataAdapter(showreport)
            da.Fill(dt)

            ' Add empty rows
            For i As Integer = 1 To Convert.ToInt32(num_count.Value)
                Dim emptyRow As DataRow = dt.NewRow()
                dt.Rows.InsertAt(emptyRow, 0)
            Next

            ' Bind data to the DataGridView
            datagridview1.DataSource = dt

            ' Load data into the Crystal Report
            myrpt.Database.Tables("sharecap_passbook").SetDataSource(dt)
            If CrystalReportViewer1.ReportSource IsNot Nothing Then
                CType(CrystalReportViewer1.ReportSource, IDisposable).Dispose()
            End If
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        print_pass(passbook_id)
    End Sub
End Class