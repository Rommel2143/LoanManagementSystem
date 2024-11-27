Imports MySql.Data.MySqlClient

Public Class Login
    Dim crypto As New CryptoHelper
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_password.UseSystemPasswordChar = True

            If IsTrustedDevice() Then
                txt_user.Enabled = True
                txt_user.Focus()
            Else
                Dim result As DialogResult = MessageBox.Show("Machine not Verified!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                If result = DialogResult.OK Then
                    display_mainframe(Register_PC)
                Else
                    Application.Exit()
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("An error occurred while verifying the machine.")
        End Try
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        login()
    End Sub

    Private Sub login()
        Try


            Dim query As String = "SELECT u.account_no, u.username, u.pass,u.initials,
                          CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname, mp.firstname, 
                          u.loan_apply, u.loan_approve, u.loan_collection, u.loan_release, u.add_member, u.level 
                          FROM `user` u 
                          JOIN member_profile mp ON u.account_no = mp.account_no  WHERE (username = @username OR u.account_no = @username) AND pass = @password "

            ' Dim query As String = "SELECT * FROM user WHERE (username = @username OR account_no = @username) AND pass = @password"

            con.Close()
            con.Open()
            Dim logincred As New MySqlCommand(query, con)
            logincred.Parameters.AddWithValue("@username", txt_user.Text)
            logincred.Parameters.AddWithValue("@password", crypto.Encrypt(txt_password.Text))

            dr = logincred.ExecuteReader()


            If dr.Read() = True Then
                Dim apply As Integer = dr.GetInt32("loan_apply")
                Dim approve As Integer = dr.GetInt32("loan_approve")
                Dim collection As String = dr.GetInt32("loan_collection")
                Dim release As Integer = dr.GetInt32("loan_release")
                Dim addmember As Integer = dr.GetInt32("add_member")
                Dim manage As Integer = dr.GetInt32("level")
                user_fullname = dr.GetString("fullname")
                user_firstname = dr.GetString("firstname")
                user_level = manage
                user_pass = crypto.Decrypt(dr.GetString("pass"))
                user_initial = dr.GetString("initials")
                user_account = dr.GetString("account_no")

                subframe.btn_loan_apply.Visible = (apply = 1)
                subframe.btn_loan_approve.Visible = (approve = 1)
                subframe.btnloan_collection.Visible = (Collection = 1)
                subframe.btnloan_release.Visible = (release = 1)
                member_accounts.btn_addmember.Visible = (addmember = 1)
                subframe.btn_manageuser.Visible = (manage = 1)

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
