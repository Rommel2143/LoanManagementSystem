Imports MySql.Data.MySqlClient
Public Class user_management

    Private Sub user_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadusers(1)
    End Sub

    'Private Sub cmb_fullname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_fullname.SelectedIndexChanged
    '    Dim query As String = "SELECT * 
    '                FROM user u 
    '                JOIN member_profile mp ON mp.account_no=u.account_no
    '                WHERE CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', u.account_no,')')='" & cmb_fullname.Text & "'"
    '    con.Close()
    '    con.Open()
    '    Dim selectuser As New MySqlCommand(query, con)
    '    dr = selectuser.ExecuteReader
    '    If dr.Read = True Then
    '        lbl_account.Text = dr.GetString("account_no")
    '        txt_username.Text = dr.GetString("username")
    '        txt_password.Text = (dr.GetString("pass"))
    '        txt_initials.Text = dr.GetString("initials")
    '        chk_app.Checked = (dr.GetInt32("loan_apply") = 1)
    '        chk_appr.Checked = (dr.GetInt32("loan_approve") = 1)
    '        chk_release.Checked = (dr.GetInt32("loan_release") = 1)
    '        chk_coll.Checked = (dr.GetInt32("loan_collection") = 1)
    '        chk_reg.Checked = (dr.GetInt32("add_member") = 1)
    '        cmb_level.SelectedIndex = dr.GetInt32("level")
    '    End If
    'End Sub



    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
    '    Dim query As String = "UPDATE user u 

    '                    SET u.username = @username, 
    '                        u.level = @level, 
    '                        u.pass = @password, 
    '                        u.initials = @initials,
    '                        u.loan_apply = @loan_apply, 
    '                        u.loan_approve = @loan_approve, 
    '                        u.loan_release = @loan_release, 
    '                        u.loan_collection = @loan_collection, 
    '                        u.add_member = @add_member
    '                    WHERE u.account_no = @account_no"

    '    ' Ensure to use parameterized queries to avoid SQL injection
    '    con.Close()
    '    con.Open()

    '    Dim updateUser As New MySqlCommand(query, con)
    '    updateUser.Parameters.AddWithValue("@username", txt_username.Text)
    '    updateUser.Parameters.AddWithValue("@level", cmb_level.SelectedIndex)
    '    updateUser.Parameters.AddWithValue("@password", txt_password.Text)
    '    updateUser.Parameters.AddWithValue("@initials", txt_initials.Text)
    '    updateUser.Parameters.AddWithValue("@loan_apply", If(chk_app.Checked, 1, 0))
    '    updateUser.Parameters.AddWithValue("@loan_approve", If(chk_appr.Checked, 1, 0))
    '    updateUser.Parameters.AddWithValue("@loan_release", If(chk_release.Checked, 1, 0))
    '    updateUser.Parameters.AddWithValue("@loan_collection", If(chk_coll.Checked, 1, 0))
    '    updateUser.Parameters.AddWithValue("@add_member", If(chk_reg.Checked, 1, 0))
    '    updateUser.Parameters.AddWithValue("@account_no", lbl_account.Text)

    '    ' Execute the update query
    '    updateUser.ExecuteNonQuery()
    '    display_error("Data has been updated successfully.")

    '    ' Close the connection after the update
    '    con.Close()

    'End Sub


    Private Sub loadusers(text As String)
        reload("SELECT `id`, `account_no`, `username`, `initials`, `pass`, `admin`, `loan_apply`, `loan_approve`, `loan_release`, `loan_collection`, `add_member`, `print_savings`, `print_sharecap`, `savings`, `sharecap`,`dashboard` FROM `user` WHERE " & text & "", datagrid1)
        If datagrid1.Columns.Contains("id") Then
            datagrid1.Columns("id").Visible = False
        End If

        For Each colName As String In {"loan_apply", "loan_approve", "loan_release", "loan_collection", "add_member", "admin", "print_savings", "print_sharecap", "savings", "sharecap", "dashboard"}
            If datagrid1.Columns.Contains(colName) Then
                Dim chkColumn As New DataGridViewCheckBoxColumn()
                With chkColumn
                    .HeaderText = colName
                    .Name = colName
                    .DataPropertyName = colName
                    .TrueValue = 1
                    .FalseValue = 0
                    .ThreeState = False
                End With

                ' Replace existing column with CheckBox column
                Dim index As Integer = datagrid1.Columns(colName).Index
                datagrid1.Columns.Remove(colName)
                datagrid1.Columns.Insert(index, chkColumn)
            End If
        Next
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        Dim newuser As New add_user
        newuser.ShowDialog()
        newuser.BringToFront()
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            For Each row As DataGridViewRow In datagrid1.Rows
                If Not row.IsNewRow Then
                    Dim id As Integer = Convert.ToInt32(row.Cells("id").Value)
                    Dim loan_username As String = row.Cells("username").Value.ToString
                    Dim loan_initials As String = row.Cells("initials").Value.ToString
                    Dim loan_pass As String = row.Cells("pass").Value.ToString

                    Dim loan_apply As Integer = If(Convert.ToBoolean(row.Cells("loan_apply").Value), 1, 0)
                    Dim loan_approve As Integer = If(Convert.ToBoolean(row.Cells("loan_approve").Value), 1, 0)
                    Dim loan_release As Integer = If(Convert.ToBoolean(row.Cells("loan_release").Value), 1, 0)
                    Dim loan_collection As Integer = If(Convert.ToBoolean(row.Cells("loan_collection").Value), 1, 0)
                    Dim add_member As Integer = If(Convert.ToBoolean(row.Cells("add_member").Value), 1, 0)
                    Dim admin As Integer = If(Convert.ToBoolean(row.Cells("admin").Value), 1, 0)

                    Dim print_savings As Integer = If(Convert.ToBoolean(row.Cells("print_savings").Value), 1, 0)
                    Dim print_sharecap As Integer = If(Convert.ToBoolean(row.Cells("print_sharecap").Value), 1, 0)
                    Dim savings As Integer = If(Convert.ToBoolean(row.Cells("savings").Value), 1, 0)
                    Dim sharecap As Integer = If(Convert.ToBoolean(row.Cells("sharecap").Value), 1, 0)
                    Dim dashboard As Integer = If(Convert.ToBoolean(row.Cells("dashboard").Value), 1, 0)

                    Dim query As String = "UPDATE user SET `username`=@username, `initials`=@initials, `pass`=@pass, loan_apply=@loan_apply, loan_approve=@loan_approve, loan_release=@loan_release, loan_collection=@loan_collection, add_member=@add_member, admin=@admin,
                                            `print_savings`=" & print_savings & ",
                                            `print_sharecap`=" & print_sharecap & ",
                                            `savings`=" & savings & ",
                                            `sharecap` =" & sharecap & ",
                                            `dashboard` =" & dashboard & "
                                            WHERE id=@id"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", id)
                        cmd.Parameters.AddWithValue("@username", loan_username)
                        cmd.Parameters.AddWithValue("@initials", loan_initials)
                        cmd.Parameters.AddWithValue("@pass", loan_pass)
                        cmd.Parameters.AddWithValue("@loan_apply", loan_apply)
                        cmd.Parameters.AddWithValue("@loan_approve", loan_approve)
                        cmd.Parameters.AddWithValue("@loan_release", loan_release)
                        cmd.Parameters.AddWithValue("@loan_collection", loan_collection)
                        cmd.Parameters.AddWithValue("@add_member", add_member)
                        cmd.Parameters.AddWithValue("@admin", admin)

                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            display_error("Changes saved successfully!")
        Catch ex As Exception
            display_error("Error saving changes: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text.Trim = "" Then
            loadusers(1)
        Else
            loadusers("`account_no` REGEXP '" & txt_search.Text & "'")
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        add_user.Show()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class