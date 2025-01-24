Imports MySql.Data.MySqlClient
Public Class collection_print
    Dim collection_id As Integer
    Private Sub print_passbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub print_collection(id As String)
        collection_id = id
        Dim myrpt As New collection_rpt
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
sc.id,
   IF(@newprint = 1, UPPER(CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename)),'') AS Fullname,
    IF(@newprint = 1,sc.account_no,'') AS account_no,
   sc.referenceno AS reference,
   la.amount,
sc.ammortization,
sc.interest,
sc.due_fines,
sc.loan_balance,
 @num_count AS number,
sc.date_paid
FROM loan_collection sc
JOIN member_profile mp ON mp.account_no = sc.account_no
LEFT JOIN loan_app la ON la.referenceno=sc.referenceno
WHERE sc.id = @id 
", con)

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
            myrpt.Database.Tables("collection").SetDataSource(dt)
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
        print_collection(collection_id)
    End Sub
End Class