Public Class weight_ave
    Private Sub weight_ave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2NumericUpDown1.Value = Date.Now.ToString("yyyy")
        reload("SELECT sc.account_no,
CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname, YEAR(date_transac) AS Year,
       ( 
           SUM(CASE WHEN MONTH(date_transac) = 1 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 2 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 3 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 4 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 5 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 6 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 7 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 8 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 9 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 10 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 11 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 12 THEN amount ELSE 0 END)
       ) / 12 AS weighted_average
FROM sharecap sc
LEFT JOIN member_profile mp ON mp.account_no = sc.account_no
WHERE YEAR(date_transac) = " & Guna2NumericUpDown1.Value & "
GROUP BY sc.account_no;

", datagrid1)
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        reload("SELECT sc.account_no,
CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname, YEAR(date_transac) AS Year,
       ( 
           SUM(CASE WHEN MONTH(date_transac) = 1 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 2 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 3 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 4 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 5 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 6 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 7 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 8 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 9 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 10 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 11 THEN amount ELSE 0 END) +
           SUM(CASE WHEN MONTH(date_transac) = 12 THEN amount ELSE 0 END)
       ) / 12 AS weighted_average
FROM sharecap sc
LEFT JOIN member_profile mp ON mp.account_no = sc.account_no
WHERE YEAR(date_transac) = " & Guna2NumericUpDown1.Value & "
GROUP BY sc.account_no;

", datagrid1)
    End Sub

End Class