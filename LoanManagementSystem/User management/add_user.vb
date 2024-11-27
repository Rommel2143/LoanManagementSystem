Imports MySql.Data.MySqlClient
Public Class add_user
    Dim crypto As New CryptoHelper
    Private Sub cmb_fullname_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname, account_no 
                    FROM member_profile mp", datagrid1)
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        reload("SELECT CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname, account_no 
                    FROM member_profile mp WHERE account_no REGEXP'" & txt_search.Text & "' or CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) REGEXP '" & txt_search.Text & "' ", datagrid1)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try

            ' Validate if username, password, and initials are filled
            If String.IsNullOrEmpty(lbl_fullname.Text) OrElse String.IsNullOrEmpty(txt_username.Text) OrElse String.IsNullOrEmpty(txt_password.Text) OrElse String.IsNullOrEmpty(txt_initials.Text) Then
                MessageBox.Show("Please fill in all required fields (Account,Username, Password, Initials).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub ' Exit the subroutine if validation fails
            End If

            ' Proceed with the insert if all required fields are filled
            Dim query As String = "INSERT INTO user (account_no,level,username, pass, initials, loan_apply, loan_approve, loan_release, loan_collection, add_member) 
                       VALUES (@account_no,@level,@username, @password, @initials, @loan_apply, @loan_approve, @loan_release, @loan_collection, @add_member)"

            ' Ensure to use parameterized queries to avoid SQL injection
            con.Close()
            con.Open()

            Dim insertUser As New MySqlCommand(query, con)
            insertUser.Parameters.AddWithValue("@account_no", lbl_account.Text)
            insertUser.Parameters.AddWithValue("@level", cmb_level.SelectedIndex)
            insertUser.Parameters.AddWithValue("@username", txt_username.Text)
            insertUser.Parameters.AddWithValue("@password", crypto.Encrypt(txt_password.Text))
            insertUser.Parameters.AddWithValue("@initials", txt_initials.Text)
            insertUser.Parameters.AddWithValue("@loan_apply", If(chk_app.Checked, 1, 0))
            insertUser.Parameters.AddWithValue("@loan_approve", If(chk_appr.Checked, 1, 0))
            insertUser.Parameters.AddWithValue("@loan_release", If(chk_release.Checked, 1, 0))
            insertUser.Parameters.AddWithValue("@loan_collection", If(chk_coll.Checked, 1, 0))
            insertUser.Parameters.AddWithValue("@add_member", If(chk_reg.Checked, 1, 0))

            ' Execute the insert query for user table
            insertUser.ExecuteNonQuery()


            display_error("Data has been inserted successfully.")

            ' Close the connection after the insert
            con.Close()

            Me.Close()
        Catch ex As Exception
            display_error(ex.Message)
        End Try
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 Then
            lbl_account.Text = datagrid1.Rows(e.RowIndex).Cells(1).Value.ToString()
            lbl_fullname.Text = datagrid1.Rows(e.RowIndex).Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_level.SelectedIndexChanged

    End Sub
End Class