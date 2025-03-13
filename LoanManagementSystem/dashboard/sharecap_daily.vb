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
    status,
    account_no,
    CASE 
        WHEN status IN ('DM','CA','D','DMEMO','CHKWID','CSHWIT','CHKWIT') THEN amount 
        ELSE 0 
    END AS withdraw_amount,
    CASE 
        WHEN status IN ('ID', 'CM', 'CD', 'ISC', 'IPR', 'C', 'CASHDEP', 'BEGBAL', 'CMEMO', 'CHKDEP', 'CSHAD1', 'INT') THEN amount 
        ELSE 0 
    END AS deposit_amount,
    date_transac
FROM sharecap  
WHERE date_transac = '2025-02-25';", con)






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