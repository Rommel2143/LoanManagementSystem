﻿Public Class loan_records
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            If txt_search.Text = "" Then
                loadrecords()
            Else


                reload("SELECT la.referenceno,
                   CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', la.account_no,')') AS Borrower,
                   FORMAT(la.amount, 0) AS Loan_Amount,
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
                   FORMAT(la.amount, 0) AS Loan_Amount,
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
End Class