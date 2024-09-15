Public Class search_name
    Dim account As String
    Dim fullname As String
    Dim sharecap As Integer

    Private Sub search_name_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            reloadgrid()
        Else
            reload("SELECT account_no, CONCAT(lastname, ', ', firstname, ' ', middlename) AS Fullname, savings, sharecap FROM member_profile
                   
                 WHERE account_no REGEXP '" & txt_search.Text & "' or firstname  REGEXP '" & txt_search.Text & "' or lastname  REGEXP '" & txt_search.Text & "' ", datagrid1)
        End If

    End Sub

    Private Sub reloadgrid()
        reload("SELECT account_no, CONCAT(lastname, ', ', firstname, ' ', middlename) AS Fullname,savings, sharecap FROM member_profile", datagrid1)
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 Then
            account = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
            fullname = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
            sharecap = datagrid1.Rows(e.RowIndex).Cells(3).Value.ToString()
            lbl_fullname.Text = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With loan_application
            .lbl_account.Text = account
            .lbl_fullname.Text = fullname
            Me.Close()
            .lbl_reference.Text = GenerateReferenceNumber("L")

        End With
    End Sub

End Class