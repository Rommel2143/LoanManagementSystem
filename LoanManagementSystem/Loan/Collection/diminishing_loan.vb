Imports MySql.Data.MySqlClient
Public Class diminishing_loan
    Private Sub diminishing_loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub print_diminishing(referenceno As String)
        Dim myrpt As New diminishing_loan_rpt
        dt.Clear()

        Try
            con.Close()
            con.Open()

            Dim showreport As New MySqlCommand("SELECT lc.id, 
     ROW_NUMBER() OVER (ORDER BY lc.id ASC) AS Month, 
     
       lc.ammortization, 
      lc.principal, 
   lc.interest,
      lc.gross,
lc.loan_balance,
(lc.ammortization * la.months_count) AS gross_total,
la.amount AS loan_total,
CONCAT(lc.account_no,'-',mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS account
FROM loan_collection lc
lEFT JOIN loan_app la ON la.referenceno = lc.referenceno
LEFT JOIN member_profile mp ON lc.account_no = mp.account_no
WHERE lc.referenceno ='" & referenceno & "'
ORDER BY lc.id ASC", con)

            showreport.Parameters.AddWithValue("@referenceno", referenceno)
            Dim da As New MySqlDataAdapter(showreport)
            da.Fill(dt)
            myrpt.Database.Tables("diminishing").SetDataSource(dt)
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