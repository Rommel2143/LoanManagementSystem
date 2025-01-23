Imports MySql.Data.MySqlClient
Public Class print_savings
    Dim savings_id As Integer
    Private Sub print_savings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub print_savings(id As String)
        savings_id = id
        Dim myrpt As New savings_transac
        Dim dt As New DataTable
        Dim datagridview1 As New DataGridView
        Try
            ' Clear and set up the DataGridView
            datagridview1.DataSource = Nothing
            datagridview1.Rows.Clear()

            con.Close()
            con.Open()

            Dim showreport As New MySqlCommand("
            SELECT 
                UPPER(CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename)) AS Fullname,
                sc.account_no,
                sc.status,  -- Transaction Code = Status
                CASE 
                    WHEN sc.status IN ('CW', 'CHKW') THEN sc.amount 
                    ELSE 0 
                END AS `withdraw`,
                CASE 
                    WHEN sc.status NOT IN ('CW', 'CHKW') THEN sc.amount 
                    ELSE 0 
                END AS `deposit`,
                (
                    SELECT SUM(
                        CASE 
                            WHEN t2.status IN ('CW', 'CHKW') THEN -t2.amount  
                            ELSE t2.amount  
                        END
                    ) 
                    FROM savings AS t2 
                    WHERE t2.account_no = sc.account_no 
                      AND t2.date_transac <= sc.date_transac
                      AND t2.id <= sc.id  
                ) AS `balance`,
               u.initials,
               sc.date_transac
            FROM savings sc
            JOIN member_profile mp ON mp.account_no = sc.account_no
            JOIN user u ON u.account_no = sc.account_no
            WHERE sc.id = @id  
            ORDER BY sc.date_transac, sc.id;
        ", con)

            showreport.Parameters.AddWithValue("@id", id)
            Dim da As New MySqlDataAdapter(showreport)
            da.Fill(dt)

            ' Add three blank rows to the DataTable
            For i As Integer = 0 To num_count.Value
                Dim emptyRow As DataRow = dt.NewRow()
                dt.Rows.InsertAt(emptyRow, 0)
            Next

            ' Bind the updated DataTable to the DataGridView
            datagridview1.DataSource = dt

            ' Load the updated data into the Crystal Report
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


    Private Sub Guna2NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles num_count.ValueChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        print_savings(savings_id)
    End Sub
End Class