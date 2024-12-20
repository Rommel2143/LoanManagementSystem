﻿Imports MySql.Data.MySqlClient
Public Class print_savings
    Private Sub print_savings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub print_savings(referenceno As String)
        Dim myrpt As New savings_transac
        dt.Clear()

        Try
            con.Close()
            con.Open()

            Dim showreport As New MySqlCommand("SELECT 
    UPPER(CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename)) AS Fullname,
    sc.account_no,
    sc.status,  -- Transaction Code = Status
    -- Withdrawals: Amounts where status is 'DM' or 'CA'

    CASE 
        WHEN sc.status IN ('CW', 'CHKW') THEN sc.amount 
        ELSE 0 
    END AS `withdraw`,


    -- Deposits: Amounts where status is NOT 'DM' or 'CA'
    CASE 
        WHEN sc.status NOT IN ('CW', 'CHKW') THEN sc.amount 
        ELSE 0 
    END AS `deposit`,
    -- Balance: Running total of withdrawals and deposits
    (
        SELECT SUM(
            CASE 
                WHEN t2.status IN ('CW', 'CHKW') THEN -t2.amount  -- Withdrawals decrease balance
                ELSE t2.amount  -- Deposits increase balance
            END
        ) 
        FROM savings AS t2 
        WHERE t2.account_no = sc.account_no 
          AND t2.date_transac <= sc.date_transac
          AND t2.id <= sc.id  -- Ensure the running balance is calculated up to this transaction
    ) AS `balance`,
   u.initials,
sc.date_transac
FROM savings sc
JOIN member_profile mp ON mp.account_no = sc.account_no
JOIN user u ON u.account_no = sc.account_no
WHERE sc.account_no = @referenceno  -- Parameterized query to avoid SQL injection
ORDER BY sc.date_transac, sc.id;
", con)

            showreport.Parameters.AddWithValue("@referenceno", referenceno)
            Dim da As New MySqlDataAdapter(showreport)
            da.Fill(dt)
            myrpt.Database.Tables("savings_transact").SetDataSource(dt)
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class