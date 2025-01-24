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
            Dim newprint As Boolean
            If num_count.Value = 1 Then
                newprint = 1
            Else
                newprint = 0
            End If

            Dim showreport As New MySqlCommand(" SELECT   IF(@newprint = 1, UPPER(CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename)), '') AS Fullname,
                                                               IF(@newprint = 1,  sc.account_no,'') AS account_no,
                                                                sc.status, 
                                                        CASE 
                                                            WHEN sc.status IN ('CW', 'CHKW') THEN sc.amount 
                                                            ELSE 0 
                                                        END AS `withdraw`,

                                                        CASE 
                                                            WHEN sc.status NOT IN ('CW', 'CHKW') THEN sc.amount 
                                                            ELSE 0 
                                                        END AS `deposit`,
            
                                               ( SELECT SUM(
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
           u.initials as teller,
           sc.date_transac,
           @num_count AS number,
           sc.id
        FROM savings sc
        JOIN member_profile mp ON mp.account_no = sc.account_no
        JOIN user u ON u.account_no = sc.account_no
        WHERE sc.id = @id", con)

            ' Add parameters
            showreport.Parameters.AddWithValue("@id", id)
            showreport.Parameters.AddWithValue("@newprint", newprint)
            showreport.Parameters.AddWithValue("@num_count", Convert.ToInt32(num_count.Value))

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
            myrpt.Database.Tables("savings_transact").SetDataSource(dt)
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


    Private Sub Guna2NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles num_count.ValueChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        print_savings(savings_id)
    End Sub
End Class