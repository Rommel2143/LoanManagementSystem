Public Class loan_records
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Public Sub loadrecords()
        reload("SELECT la.referenceno,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Borrower, la.amount,  la.purpose, DATE_FORMAT(la.date_apply, '%M %d, %Y') AS date_apply,
                                                 CASE la.status
                                                        WHEN 0 THEN 'Pending'
                                                        WHEN 1 THEN 'Approved'
                                                        WHEN 2 THEN 'Released'
                                                        WHEN 3 THEN 'Declined'
                                                    END AS `status`
                                    FROM loan_app la
                                    Join member_profile mp On mp.account_no = la.account_no 
                                    ORDER BY la.date_apply DESC", datagrid1)
    End Sub

End Class