﻿Imports MySql.Data.MySqlClient
Public Class search_name
    Dim account As String
    Dim fullname As String
    Dim sharecap As Integer
    Dim age As Integer

    Private Sub search_name_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reloadgrid(1)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    'Private Sub reloadgrid(search As String)
    '    Dim query As String = "SELECT mp.account_no AS Account_no, 
    '                                  CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname, 
    '                                  TIMESTAMPDIFF(YEAR, mp.birthdate, CURDATE()) AS Age,
    '                                  COALESCE(SUM(CASE WHEN sc.status IN ('ID', 'CM', 'CD', 'ISC', 'IPR') THEN sc.amount ELSE 0 END) - 
    '                                           SUM(CASE WHEN sc.status IN ('DM', 'CA') THEN sc.amount ELSE 0 END), 0) AS Sharecap,
    '                                    COUNT(id)
    '                                    FROM member_profile mp

    '                               LEFT JOIN sharecap sc ON sc.account_no = mp.account_no
    '                                LEFT JOIN loan_collection lc ON lc.account_no = mp.account_no
    '                                WHERE " & search & "
    '                                 GROUP BY mp.account_no"
    '    reload(query, datagrid1)
    '    Format_currency("Sharecap", datagrid1) ' Format Sharecap column
    'End Sub

    Private Sub reloadgrid(search As String)
        Dim query As String = "
        SELECT 
            mp.account_no AS Account_no, 
            CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname, 
            TIMESTAMPDIFF(YEAR, mp.birthdate, CURDATE()) AS Age,
            COALESCE(
                SUM(CASE WHEN sc.status IN ('ID', 'CM', 'CD', 'ISC', 'IPR') THEN sc.amount ELSE 0 END) - 
                SUM(CASE WHEN sc.status IN ('DM', 'CA') THEN sc.amount ELSE 0 END), 
                0
            ) AS Sharecap,  
            COUNT(DISTINCT CASE WHEN EXISTS (
            SELECT 1 
            FROM loan_collection lc_sub 
            WHERE lc_sub.referenceno = lc.referenceno AND lc_sub.status = 0
        ) THEN lc.referenceno END) AS Pending_Loans
        FROM 
            member_profile mp
        LEFT JOIN 
            sharecap sc ON sc.account_no = mp.account_no
        LEFT JOIN 
            loan_collection lc ON lc.account_no = mp.account_no
        WHERE 
            " & search & "
        GROUP BY 
            mp.account_no"

        ' Reload the DataGridView with the query
        reload(query, datagrid1)

        ' Format the Sharecap column as currency
        Format_currency("Sharecap", datagrid1)
    End Sub





    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 Then
            account = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
            fullname = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
            sharecap = datagrid1.Rows(e.RowIndex).Cells(3).Value.ToString()
            lbl_fullname.Text = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
            age = datagrid1.Rows(e.RowIndex).Cells(2).Value.ToString
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        With loan_application
            Select Case lbl_who.Text
                Case "Borrower :"
                    .lbl_account.Text = account
                    .lbl_fullname.Text = fullname
                    .lbl_reference.Text = GenerateReferenceNumber("L")
                    .lbl_sharecap.Text = "Php " & sharecap.ToString("N0")
                    .lbl_age.Text = age.ToString
                Case "Co-maker 1 :"
                    .lbl_cm1.Text = fullname & " (" & account & ")"
                    .comaker1 = account
                Case "Co-maker 2 :"
                    .lbl_cm2.Text = fullname & " (" & account & ")"
                    .comaker2 = account
            End Select
            Me.Close()
        End With
    End Sub

    Private Sub datagrid1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles datagrid1.MouseDoubleClick

    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub txt_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txt_search.Text = "" Then
                    ' reloadgrid(1)
                    datagrid1.DataSource = Nothing
                Else
                    reloadgrid("mp.account_no REGEXP '" & txt_search.Text & "' OR firstname REGEXP '" & txt_search.Text & "'  OR lastname REGEXP '" & txt_search.Text & "'")
                    'Dim query As String = "SELECT mp.account_no AS Account_no, 
                    '                      CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname, 
                    '                      TIMESTAMPDIFF(YEAR, mp.birthdate, CURDATE()) AS Age,
                    '                      COALESCE(SUM(CASE WHEN sc.status IN ('ID', 'CM', 'CD', 'ISC', 'IPR') THEN sc.amount ELSE 0 END) - 
                    '                               SUM(CASE WHEN sc.status IN ('DM', 'CA') THEN sc.amount ELSE 0 END), 0) AS Sharecap
                    '                   FROM member_profile mp
                    '                   LEFT JOIN sharecap sc ON sc.account_no = mp.account_no
                    '                  WHERE mp.account_no REGEXP '" & txt_search.Text & "' 
                    '   OR firstname REGEXP '" & txt_search.Text & "' 
                    '   OR lastname REGEXP '" & txt_search.Text & "'
                    '                   GROUP BY mp.account_no"

                    'reload(query, datagrid1)
                    'Format_currency("Sharecap", datagrid1) ' Format Sharecap column
                End If
            Catch ex As Exception
                ' Handle the exception, e.g., display a custom message or log the error
                MessageBox.Show("An error occurred while searching. Please try again.")
            End Try
        End If
    End Sub
End Class