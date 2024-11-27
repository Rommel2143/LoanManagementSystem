Imports MySql.Data.MySqlClient
Public Class loan_records_info
    Public Property referenceno As String

    Public Sub loaddata(referenceno)
        Dim query As String = "SELECT 
    l.`id`, 
    l.`referenceno`, 
    l.`account_no`, 
    l.`amount`, 
    l.`ammortization`, 
    l.`interest_rate`, 
    l.`service_fee`, 
    l.`insurance_fee`, 
    l.`interest`, 
    l.`date_apply`, 
    l.`date_approved`, 
    l.`date_release`, 
    l.`months_count`, 
    l.`teller`, 
    l.`teller_approved`, 
    l.`teller_release`, 
    l.`mode`, 
    l.`purpose`, 
    l.`collateral`, 
    l.`collateral_value`, 
    l.`comaker_1`, 
    l.`comaker_2`, 
    l.`status`, 
    CONCAT(m.`firstname`, ' ', m.`middlename`, ' ', m.`lastname`) AS Fullname
FROM 
    `loan_app` l
LEFT JOIN 
    `member_profile` m
ON 
    l.`account_no` = m.`account_no`;
WHERE"

    End Sub

    Private Sub loan_records_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class