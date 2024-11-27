Imports MySql.Data.MySqlClient
Public Class user_management
    Dim crypto As New CryptoHelper
    Private Sub user_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmb_fullname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_fullname.SelectedIndexChanged
        Dim query As String = "SELECT * 
                    FROM user u 
                    JOIN member_profile mp ON mp.account_no=u.account_no
                    WHERE CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', u.account_no,')')='" & cmb_fullname.Text & "'"
        con.Close()
        con.Open()
        Dim selectuser As New MySqlCommand(query, con)
        dr = selectuser.ExecuteReader
        If dr.Read = True Then
            lbl_account.Text = dr.GetString("account_no")
            txt_username.Text = dr.GetString("username")
            txt_password.Text = crypto.Decrypt(dr.GetString("pass"))
            txt_initials.Text = dr.GetString("initials")
            chk_app.Checked = (dr.GetInt32("loan_apply") = 1)
            chk_appr.Checked = (dr.GetInt32("loan_approve") = 1)
            chk_release.Checked = (dr.GetInt32("loan_release") = 1)
            chk_coll.Checked = (dr.GetInt32("loan_collection") = 1)
            chk_reg.Checked = (dr.GetInt32("add_member") = 1)
            cmb_level.SelectedIndex = dr.GetInt32("level")
        End If
    End Sub

    Private Sub cmb_fullname_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_fullname.MouseClick
        cmb_display("SELECT CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', u.account_no,')') AS Fullname
                    FROM user u JOIN member_profile mp ON mp.account_no=u.account_no", "Fullname", cmb_fullname)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim query As String = "UPDATE user u 
                      
                        SET u.username = @username, 
                            u.level = @level, 
                            u.pass = @password, 
                            u.initials = @initials,
                            u.loan_apply = @loan_apply, 
                            u.loan_approve = @loan_approve, 
                            u.loan_release = @loan_release, 
                            u.loan_collection = @loan_collection, 
                            u.add_member = @add_member
                        WHERE u.account_no = @account_no"

        ' Ensure to use parameterized queries to avoid SQL injection
        con.Close()
        con.Open()

        Dim updateUser As New MySqlCommand(query, con)
        updateUser.Parameters.AddWithValue("@username", txt_username.Text)
        updateUser.Parameters.AddWithValue("@level", cmb_level.SelectedIndex)
        updateUser.Parameters.AddWithValue("@password", crypto.Encrypt(txt_password.Text))
        updateUser.Parameters.AddWithValue("@initials", txt_initials.Text)
        updateUser.Parameters.AddWithValue("@loan_apply", If(chk_app.Checked, 1, 0))
        updateUser.Parameters.AddWithValue("@loan_approve", If(chk_appr.Checked, 1, 0))
        updateUser.Parameters.AddWithValue("@loan_release", If(chk_release.Checked, 1, 0))
        updateUser.Parameters.AddWithValue("@loan_collection", If(chk_coll.Checked, 1, 0))
        updateUser.Parameters.AddWithValue("@add_member", If(chk_reg.Checked, 1, 0))
        updateUser.Parameters.AddWithValue("@account_no", lbl_account.Text)

        ' Execute the update query
        updateUser.ExecuteNonQuery()
        display_error("Data has been updated successfully.")

        ' Close the connection after the update
        con.Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim newuser As New add_user
        newuser.ShowDialog()
        newuser.BringToFront()
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub
End Class