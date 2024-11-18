Imports MySql.Data.MySqlClient
Public Class print_loanapp
    Private Sub print_loanapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Sub viewdata(reference As String)
        Dim myrpt As New loanapplication_rpt
        dt.Clear()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname,
la.account_no,
la.referenceno,
la.date_apply,
la.purpose,
la.amount,
la.ammortization,
la.months_count,
la.service_fee,
la.comaker_1,
la.comaker_2,
 SUM(CASE WHEN sc.status = 'ID' or sc.status='CM' or sc.status='CD' or sc.status='ISC' or sc.status='IPR' THEN sc.amount ELSE 0 END) - 
            SUM(CASE WHEN sc.status = 'DM' or sc.status = 'CA' THEN sc.amount ELSE 0 END) AS sharecap,
 SUM(CASE WHEN sv.status = 'ID'
                        or sv.status='CHKD'
                        or sv.status='CD'
                     THEN sv.amount ELSE 0 END) 
                    - 
            SUM(CASE WHEN sv.status = 'CW'
                        or sv.status = 'CHKW'
                     THEN sv.amount ELSE 0 END) AS savings,
 CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                         WHEN 2 THEN 'Released'
                       WHEN 3 THEN 'Declined'
                   END AS `status`
FROM loan_app la
JOIN
member_profile mp ON mp.account_no=la.account_no
JOIN 
sharecap sc ON sc.account_no=la.account_no
JOIN 
savings sv ON sv.account_no=la.account_no

WHERE la.referenceno = '" & reference & "'", con)




        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()


        myrpt.Database.Tables("Loanapp").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class