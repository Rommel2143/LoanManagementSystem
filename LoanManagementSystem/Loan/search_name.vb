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
            reload("Select account_no AS Account_no, 
                       CONCAT(lastname, ', ', firstname, ' ', middlename) AS Fullname, 
                       sharecap AS Share_Capital,
                       TIMESTAMPDIFF(Year, birthdate, CURDATE()) AS Age
                From member_profile
                Where account_no REGEXP '" & txt_search.Text & "' 
                   Or firstname REGEXP '" & txt_search.Text & "' 
                   Or lastname REGEXP '" & txt_search.Text & "' ", datagrid1)
        End If

    End Sub

    Private Sub reloadgrid()
        reload("Select account_no AS Account_no, 
                       CONCAT(lastname, ', ', firstname, ' ', middlename) AS Fullname, 
                       sharecap AS Share_Capital,
                       TIMESTAMPDIFF(Year, birthdate, CURDATE()) AS Age
                From member_profile", datagrid1)
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
            Select Case lbl_who.Text
                Case "Borrower :"
                    .lbl_account.Text = account
                    .lbl_fullname.Text = fullname
                    .lbl_reference.Text = GenerateReferenceNumber("L")
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

End Class