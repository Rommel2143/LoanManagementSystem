Public Class loan_records
    Dim queryfiltered As String
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            If txt_search.Text = "" Then
                loadrecords()
            Else


                reload("SELECT la.referenceno,
                   CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   FORMAT(la.amount, 0) AS Loan_Amount,la.months_count AS Term,la.ammortization AS Amortization,
                   la.purpose, 
                   DATE_FORMAT(la.date_apply, '%M %d, %Y') AS Date_Applied,
                   CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                       WHEN 2 THEN CONCAT('Released (',la.date_release,')')
                       WHEN 3 THEN 'Declined'
                   END AS `status`
            FROM loan_app la
            JOIN member_profile mp ON mp.account_no = la.account_no 
            WHERE la.referenceno REGEXP '" & txt_search.Text & "' or la.account_no REGEXP '" & txt_search.Text & "'
            ORDER BY la.date_apply DESC", datagrid1)
            End If
        Catch ex As Exception
            display_error("Error:" & ex.Message)
        End Try
    End Sub

    Public Sub loadrecords()
        Try


            reload("SELECT la.referenceno,
                  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   FORMAT(la.amount, 0) AS Loan_Amount,la.months_count AS Term,la.ammortization AS Amortization,
                   la.purpose, 
                   DATE_FORMAT(la.date_apply, '%M %d, %Y') AS Date_Applied,
                   CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                         WHEN 2 THEN CONCAT('Released (',la.date_release,')')
                       WHEN 3 THEN 'Declined'
                   END AS `status`
            FROM loan_app la
            JOIN member_profile mp ON mp.account_no = la.account_no 
            ORDER BY la.date_apply DESC", datagrid1)

        Catch ex As Exception
            display_error("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 Then
            ' Get the reference number from the selected row
            Dim referenceNo As String = datagrid1.Rows(e.RowIndex).Cells("referenceno").Value.ToString()

            ' Create an instance of loan_records_select
            Dim showoption As New loan_records_select

            ' Set the reference number property before showing the form

            showoption.referenceno = (referenceNo)
            ' Show the form
            showoption.Show()
            showoption.BringToFront()

        End If
    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filter.SelectedIndexChanged

        Select Case cmb_filter.Text
            Case "All"
                queryfiltered = "SELECT la.referenceno,
                  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   FORMAT(la.amount, 0) AS Loan_Amount,la.months_count AS Term,la.ammortization AS Amortization,
                   la.purpose, 
                   DATE_FORMAT(la.date_apply, '%M %d, %Y') AS Date_Applied,
                   CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                         WHEN 2 THEN CONCAT('Released (',la.date_release,')')
                       WHEN 3 THEN 'Declined'
                   END AS `status`
            FROM loan_app la
            JOIN member_profile mp ON mp.account_no = la.account_no 
            ORDER BY la.date_apply DESC"

            Case "Pending"
                queryfiltered = "SELECT la.referenceno,
                  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   Format(la.amount, 0) As Loan_Amount, la.months_count As Term, la.ammortization As Amortization,
                   la.purpose,
                   DATE_FORMAT(la.date_apply, '%M %d, %Y') AS Date_Applied,
                   CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                         WHEN 2 THEN CONCAT('Released (',la.date_release,')')
                       WHEN 3 THEN 'Declined'
                   End As `status`
            From loan_app la
            Join member_profile mp ON mp.account_no = la.account_no 
WHERE la.status='0'
            Order By la.date_apply DESC"
            Case "Approved"
                queryfiltered = "SELECT la.referenceno,
                  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   Format(la.amount, 0) As Loan_Amount, la.months_count As Term, la.ammortization As Amortization,
                   la.purpose,
                   DATE_FORMAT(la.date_apply, '%M %d, %Y') AS Date_Applied,
                   CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                         WHEN 2 THEN CONCAT('Released (',la.date_release,')')
                       WHEN 3 THEN 'Declined'
                   End As `status`
            From loan_app la
            Join member_profile mp ON mp.account_no = la.account_no 
WHERE la.status='1'
            Order By la.date_apply DESC"
            Case "Released"
                queryfiltered = "SELECT la.referenceno,
                  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   Format(la.amount, 0) As Loan_Amount, la.months_count As Term, la.ammortization As Amortization,
                   la.purpose,
                   DATE_FORMAT(la.date_apply, '%M %d, %Y') AS Date_Applied,
                   CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                         WHEN 2 THEN CONCAT('Released (',la.date_release,')')
                       WHEN 3 THEN 'Declined'
                   End As `status`
            From loan_app la
            Join member_profile mp ON mp.account_no = la.account_no 
WHERE la.status='2'
            Order By la.date_apply DESC"
            Case "Declined"
                queryfiltered = "SELECT la.referenceno,
                  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   Format(la.amount, 0) As Loan_Amount, la.months_count As Term, la.ammortization As Amortization,
                   la.purpose,
                   DATE_FORMAT(la.date_apply, '%M %d, %Y') AS Date_Applied,
                   CASE la.status
                       WHEN 0 THEN 'Pending'
                       WHEN 1 THEN 'Approved'
                         WHEN 2 THEN CONCAT('Released (',la.date_release,')')
                       WHEN 3 THEN 'Declined'
                   End As `status`
            From loan_app la
            Join member_profile mp ON mp.account_no = la.account_no 
WHERE la.status='3'
            Order By la.date_apply DESC"
        End Select

        reload(queryfiltered, datagrid1)
    End Sub
End Class