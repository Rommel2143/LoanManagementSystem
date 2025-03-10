Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_password.UseSystemPasswordChar = True


            txt_user.Enabled = True
            txt_user.Focus()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        login()
    End Sub

    Private Sub login()
        Try


            Dim query As String = "SELECT u.account_no, u.username, u.pass,u.initials,
                          CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname, mp.firstname, 
                          u.loan_apply, u.loan_approve, u.loan_collection, u.loan_release, u.add_member
                          FROM `user` u 
                          JOIN member_profile mp ON u.account_no = mp.account_no  WHERE (username = @username OR u.account_no = @username) AND pass =@password"



            con.Close()
            con.Open()
            Dim logincred As New MySqlCommand(query, con)
            logincred.Parameters.AddWithValue("@username", txt_user.Text)
            logincred.Parameters.AddWithValue("@password", txt_password.Text)

            dr = logincred.ExecuteReader()


            If dr.Read() = True Then

                user_fullname = dr.GetString("fullname")
                user_firstname = dr.GetString("firstname")

                user_pass = dr.GetString("pass")
                user_initial = dr.GetString("initials")
                user_account = dr.GetString("account_no")


                subframe.userstrip.Text = "Hello, " & user_firstname
                display_mainframe(subframe)
            Else
                ShowSnackbar("Invalid credentials.")
                txt_password.Clear()
            End If
        Catch ex As Exception
            ShowSnackbar("An error occurred. Please try again later. " & ex.Message)
        Finally
            ' Ensure the connection is properly closed
            If Not (dr Is Nothing OrElse dr.IsClosed) Then dr.Close()
            con.Close()
        End Try

    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then login()
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        TogglePasswordVisibility(Guna2CheckBox1.Checked)
    End Sub

    Private Sub TogglePasswordVisibility(isVisible As Boolean)
        txt_password.UseSystemPasswordChar = Not isVisible
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub
End Class
