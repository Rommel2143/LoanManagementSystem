Imports MySql.Data.MySqlClient
Public Class loan_records_info


    Public Sub loaddata(referenceno As String)

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
        u.initials,
        u1.initials as ini_appr,
        u2.initials as ini_release,
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
        l.`account_no` = m.`account_no`
    LEFT JOIN user u
    ON l.teller = u.account_no
    LEFT JOIN user u1
    ON l.teller_approved = u1.account_no
    LEFT JOIN user u2
    ON l.teller_release = u2.account_no
    WHERE l.referenceno='" & referenceno & "'"

        con.Close()
        con.Open()
        Dim selectdata As New MySqlCommand(query, con)
        dr = selectdata.ExecuteReader
        If dr.Read() Then
            lbl_fullname.Text = dr.GetString("Fullname")
            lbl_purpose.Text = dr.GetString("purpose")
            lbl_reference.Text = dr.GetString("referenceno")
            lbl_term.Text = dr.GetInt32("months_count").ToString() & " months"
            lbl_loanamount.Text = "Php " & dr.GetDecimal("amount").ToString("N0")
            lbl_rate.Text = (dr.GetDecimal("interest_rate") * 100).ToString("N0") & "%"
            lbl_insurance.Text = "Php " & dr.GetDecimal("insurance_fee").ToString("N0")
            lbl_service.Text = "Php " & dr.GetDecimal("service_fee").ToString("N0")
            lbl_amortization.Text = "Php " & dr.GetDecimal("ammortization").ToString("N0")

            ' Handle possible null values for dates
            If Not dr.IsDBNull(dr.GetOrdinal("date_apply")) Then
                lbl_dtapplied.Text = dr.GetDateTime("date_apply").ToString("MMMM dd, yyyy")
                lbl_tellerapplied.Text = dr.GetString("initials")
            Else
                lbl_dtapplied.Text = "N/A"
                lbl_tellerapplied.Text = "N/A"
            End If



            If Not dr.IsDBNull(dr.GetOrdinal("date_approved")) Then
                lbl_dtappr.Text = dr.GetDateTime("date_approved").ToString("MMMM dd, yyyy")
                lbl_tellerappr.Text = dr.GetString("ini_appr")
            Else
                lbl_dtappr.Text = "N/A"
                lbl_tellerappr.Text = "N/A"
            End If



            ' Check if 'date_release' is null before assigning
            If Not dr.IsDBNull(dr.GetOrdinal("date_release")) Then
                lbl_dtrelease.Text = dr.GetDateTime("date_release").ToString("MMMM dd, yyyy")
                lbl_tellerrelease.Text = dr.GetString("ini_release")
                lbl_disbursed.Text = "Php " & (dr.GetDecimal("amount") - (dr.GetDecimal("insurance_fee") + dr.GetDecimal("service_fee"))).ToString("N0")
            Else
                lbl_dtrelease.Text = "N/A"
                lbl_tellerrelease.Text = "N/A"
                lbl_disbursed.Text = "N/A"
            End If


            ' Calculate disbursed amount

        End If

    End Sub

    Private Sub loan_records_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class