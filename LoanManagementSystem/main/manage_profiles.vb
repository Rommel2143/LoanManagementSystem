Imports MySql.Data.MySqlClient
Public Class manage_profiles
    Private Sub Guna2ImageButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseDown
        ' Show password characters
        txt_password.PasswordChar = ""
    End Sub

    ' This event will trigger when the button is released
    Private Sub Guna2ImageButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseUp
        ' Hide password characters
        txt_password.PasswordChar = "*"c
    End Sub

    Private Sub Guna2ImageButton2_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton2.MouseDown
        txt_newpass.PasswordChar = ""
    End Sub

    Private Sub Guna2ImageButton2_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton2.MouseUp
        txt_newpass.PasswordChar = "*"c
    End Sub

    Private Sub manage_profiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.PasswordChar = "*"c
        txt_newpass.PasswordChar = "*"c
        txt_confirmpass.PasswordChar = "*"c
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Changepass()

    End Sub

    Public Sub Changepass()
        Try
            con.Close()
            con.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM user WHERE account_no = @idno and pass = @password ", con)
            With cmd.Parameters
                .AddWithValue("@idno", user_account)
                .AddWithValue("@password", txt_password.Text)

            End With
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                con.Close()
                con.Open()
                ' Update the status_inspect for the selected row
                Dim cmdUpdateStatus As New MySqlCommand("UPDATE user SET pass = @newpass WHERE account_no = @id", con)
                cmdUpdateStatus.Parameters.AddWithValue("@newpass", txt_newpass.Text)
                cmdUpdateStatus.Parameters.AddWithValue("@id", user_account)
                cmdUpdateStatus.ExecuteNonQuery()

                subframe.Panel1.Controls.Clear()
                subframe.logout.PerformClick()
                Me.Close()
            Else
                ShowSnackbar("Invalid Credentials")
            End If
        Catch ex As Exception
            ShowSnackbar("Unable to Change Password")

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txt_confirmpass_TextChanged(sender As Object, e As EventArgs) Handles txt_confirmpass.TextChanged
        If txt_confirmpass.Text = "" Then
            img_notequal.Visible = False
        Else
            If txt_confirmpass.Text = txt_newpass.Text Then
                img_notequal.Visible = False
                btn_login.Enabled = True
            Else
                img_notequal.Visible = True
                btn_login.Enabled = False
            End If
        End If
    End Sub
End Class