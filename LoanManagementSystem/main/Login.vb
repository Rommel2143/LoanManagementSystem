Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_password.UseSystemPasswordChar = True

            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT * FROM trusted_devices WHERE `PCname`='" & PCname & "' and `PCmac`='" & PCmac & "'", con)
            dr = cmdselect.ExecuteReader
            If dr.Read = True Then
                txt_user.Enabled = True
                txt_user.Focus()


            Else
                Dim result As DialogResult = MessageBox.Show("Machine not Verified!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                If result = DialogResult.OK Then
                    display_mainframe(Register_PC)

                ElseIf result = DialogResult.Cancel Then
                    con.Close()
                    Application.Exit()
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txt_user.Clear()

        End Try



    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        login()

    End Sub

    Private Sub login()
        If String.IsNullOrWhiteSpace(txt_user.Text) OrElse String.IsNullOrWhiteSpace(txt_password.Text) Then
            ShowSnackbar("Please enter both username and password.")
            Exit Sub
        End If

        Try
            con.Close()
            con.Open()

            Dim query As String = "SELECT u.account_no, u.username, u.pass, CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname, mp.firstname, u.loan_apply, u.loan_approve " &
                              "FROM `user` u " &
                              "JOIN member_profile mp ON u.account_no = mp.account_no " &
                              "WHERE (u.username = @username OR u.account_no = @username) AND u.pass = @password"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", txt_user.Text.Trim())
            cmd.Parameters.AddWithValue("@password", txt_password.Text.Trim()) ' Replace with hashed password in a real implementation

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                user_account = dr("account_no").ToString()
                user_fullname = dr.GetString("fullname")
                user_firstname = dr.GetString("firstname")
                user_pass = dr.GetString("pass") ' Remove if unnecessary



                subframe.btn_loan_apply.Visible = (dr.GetInt32("loan_apply") = 1)
                subframe.btn_loan_approve.Visible = (dr.GetInt32("loan_approve") = 1)




                display_mainframe(subframe)
                subframe.userstrip.Text = "Hello, " & user_firstname
            Else
                ShowSnackbar("Invalid credentials.")
                txt_password.Clear()
            End If
        Catch ex As Exception
            ShowSnackbar("An error occurred. Please try again later.")
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub



    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub
End Class