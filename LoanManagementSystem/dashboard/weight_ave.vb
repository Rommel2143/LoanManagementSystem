Public Class weight_ave
    Private Sub weight_ave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT 
    `account_no`, 
    SUM(monthly_total) / 12 AS avg_annual_total
FROM (
    SELECT 
        `account_no`, 
        SUM(`amount`) AS monthly_total 
    FROM `sharecap`
    GROUP BY `account_no`, YEAR(`date_transac`), MONTH(`date_transac`)
) AS monthly_sums
GROUP BY `account_no`;
", datagrid1)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        reload("SELECT 
    `account_no`, 
    ((SUM(quarterly_total) / 30) * 0.20) / 360 AS computed_value
FROM (
    SELECT 
        `account_no`, 
        SUM(`amount`) AS quarterly_total 
    FROM `sharecap`
    GROUP BY `account_no`, YEAR(`date_transac`), QUARTER(`date_transac`)
) AS quarterly_sums
GROUP BY `account_no`;
", datagrid1)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        reload("SELECT 
    `account_no`, 
    SUM(monthly_total) / 12 AS avg_annual_total
FROM (
    SELECT 
        `account_no`, 
        SUM(`amount`) AS monthly_total 
    FROM `sharecap`
    GROUP BY `account_no`, YEAR(`date_transac`), MONTH(`date_transac`)
) AS monthly_sums
GROUP BY `account_no`;
", datagrid1)
    End Sub
End Class