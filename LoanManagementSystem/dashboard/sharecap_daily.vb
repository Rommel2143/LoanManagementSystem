﻿Imports MySql.Data.MySqlClient
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
        Case 
            WHEN sc.status IN ('DM','CA','D','DMEMO','CHKWID','CSHWIT','CHKWIT') THEN amount 
            Else 0 
        End As withdraw,
        Case 
            WHEN sc.status IN ('ID', 'CM', 'CD', 'ISC', 'IPR', 'C', 'CASHDEP', 'BEGBAL', 'CMEMO', 'CHKDEP', 'CSHAD1', 'INT') THEN amount 
            Else 0 
        End As deposit,
        sc.date_transac,
   account_no as Fullname,
    sc.teller
    FROM sharecap sc

    WHERE date_transac ='" & dtpicker_from.Value.ToString("yyyy-MM-dd") & "'", con)






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

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        loaddaily()
    End Sub
End Class