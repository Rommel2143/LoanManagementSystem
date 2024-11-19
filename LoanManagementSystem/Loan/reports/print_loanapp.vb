Imports MySql.Data.MySqlClient
Public Class print_loanapp
    Private Sub print_loanapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub viewdata(referenceno As String)
        Dim myrpt As New loanapplication_rpt
        dt.Clear()

        Try
            con.Close()
            con.Open()

            Dim showreport As New MySqlCommand("
              SELECT CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname,
       la.account_no,
       la.referenceno,
       la.date_apply,
       la.purpose,
       la.amount,
       la.ammortization,
       CONCAT(la.months_count , ' month/s') AS months_count,
      la.service_fee,
       CONCAT(mp1.lastname, ', ', mp1.firstname, ' ', mp1.middlename) AS comaker_1,
CONCAT(mp2.lastname, ', ', mp2.firstname, ' ', mp2.middlename) AS comaker_2,
  
       SUM(COALESCE(CASE 
           WHEN sc.status IN ('ID', 'CM', 'CD', 'ISC', 'IPR') THEN sc.amount 
           ELSE 0 END, 0)) 
       - 
       SUM(COALESCE(CASE 
           WHEN sc.status IN ('DM', 'CA') THEN sc.amount 
           ELSE 0 END, 0)) AS sharecap,
       SUM(COALESCE(CASE 
           WHEN sv.status IN ('ID', 'CHKD', 'CD') THEN sv.amount 
           ELSE 0 END, 0)) 
       - 
       SUM(COALESCE(CASE 
           WHEN sv.status IN ('CW', 'CHKW') THEN sv.amount 
           ELSE 0 END, 0)) AS savings,
       CASE la.status
           WHEN 0 THEN 'Pending'
           WHEN 1 THEN 'Approved'
           WHEN 2 THEN 'Released'
           WHEN 3 THEN 'Declined'
       END AS `status`
FROM loan_app la
JOIN member_profile mp ON mp.account_no = la.account_no
LEFT JOIN sharecap sc ON sc.account_no = la.account_no
LEFT JOIN savings sv ON sv.account_no = la.account_no
LEFT JOIN member_profile mp1 ON mp1.account_no = la.comaker_1
LEFT JOIN member_profile mp2 ON mp2.account_no = la.comaker_2
WHERE la.referenceno = @referenceno
", con)
            showreport.Parameters.AddWithValue("@referenceno", referenceno)
            Dim da As New MySqlDataAdapter(showreport)
            da.Fill(dt)
            myrpt.Database.Tables("Loanapp").SetDataSource(dt)
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
