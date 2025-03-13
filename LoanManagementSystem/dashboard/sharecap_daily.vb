Imports MySql.Data.MySqlClient
Public Class sharecap_daily
    Private Sub sharecap_daily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker_from.Value = Date.Now
    End Sub

    Private Sub loaddaily()
        Dim myrpt As New share_daily
        dt.Clear()

        Try
            con.Close()
            con.Open()

            Dim showreport As New MySqlCommand("SELECT 
    sc.status,
    CASE 
        WHEN sc.status IN ('DM','CA','D','DMEMO','CHKWID','CSHWIT','CHKWIT') 
        THEN sc.amount ELSE 0 
    END AS Withdraw,
    CASE 
        WHEN sc.status IN ('ID', 'CM', 'CD', 'ISC', 'IPR', 'C', 'CASHDEP', 'BEGBAL', 'CMEMO', 'CHKDEP', 'CSHAD1', 'INT') 
        THEN sc.amount ELSE 0 
    END AS Deposit,
    sc.date_transac, 
    CONCAT(mp.lastname, ', ', mp.firstname, ' ', COALESCE(mp.middlename, ''), ' (', sc.account_no, ')') AS Fullname,
    user.initials AS Teller
FROM sharecap sc
JOIN member_profile mp ON mp.account_no = sc.account_no
LEFT JOIN user ON sc.teller = user.account_no
WHERE sc.date_transac = '" & dtpicker_from.Value.ToString("yyy-MM-dd") & "'", con)






            Dim da As New MySqlDataAdapter(showreport)
            da.Fill(dt)
            myrpt.Database.Tables("sharecap_daily").SetDataSource(dt)
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

    Private Sub dtpicker_from_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker_from.ValueChanged
        loaddaily()
    End Sub
End Class