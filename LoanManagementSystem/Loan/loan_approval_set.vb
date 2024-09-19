Imports MySql.Data.MySqlClient
Public Class loan_approval_set
    Private Sub loan_approval_set_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.UseSystemPasswordChar = True
    End Sub

    Public Sub loadprofile(reference As String)
        Try

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT u.account_no,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,u.amount,u.ammortization,u.referenceno,mp.sharecap FROM `loan_app` u
                                        JOIN member_profile mp ON u.account_no= mp.account_no
                                        WHERE u.referenceno='" & reference & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lbl_account.Text = dr.GetString("account_no")
                lbl_fullname.Text = dr.GetString("fullname")
                lbl_reference.Text = dr.GetString("referenceno")
                lbl_loanamount.Text = dr.GetDecimal("amount").ToString("N0")
                lbl_share.Text = dr.GetDecimal("sharecap").ToString("N0")
            End If
        Catch ex As Exception
            display_error(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("SELECT u.account_no,u.username, u.pass, CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,mp.firstname, u.loan_apply,u.loan_approve  FROM `user` u
                                        JOIN member_profile mp ON u.account_no= mp.account_no
                                        WHERE ( u.account_no= '" & user_account & "') and u.pass = '" & txt_password.Text & "' ", con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            con.Close()
            con.Open()
            ' Update the status_inspect for the selected row
            Dim cmdUpdateStatus As New MySqlCommand("UPDATE loan_app SET status = 1, date_approved='" & datedb & "', teller_approved='" & user_account & "' WHERE referenceno = '" & lbl_reference.Text & "'", con)
            cmdUpdateStatus.ExecuteNonQuery()
            Me.Close()
            loan_approval.LoadMemberProfiles()
            loan_release.LoadMemberProfiles()
            txt_password.Clear()
        Else
            display_error("Invalid Password!")
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("SELECT u.account_no,u.username, u.pass, CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,mp.firstname, u.loan_apply,u.loan_approve  FROM `user` u
                                    JOIN member_profile mp ON u.account_no= mp.account_no
                                    WHERE ( u.account_no= '" & user_account & "') and u.pass = '" & txt_password.Text & "' ", con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            ' Prompt the user with a confirmation message before declining
            Dim result As DialogResult = MessageBox.Show("Decline this application?", "Decline Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                con.Close()
                con.Open()
                ' Update the status_inspect for the selected row
                Dim cmdUpdateStatus As New MySqlCommand("UPDATE loan_app SET status = 3, date_approved='" & datedb & "', teller_approved='" & user_account & "' WHERE referenceno = '" & lbl_reference.Text & "'", con)
                cmdUpdateStatus.ExecuteNonQuery()
                Me.Close()
                loan_approval.LoadMemberProfiles()
                loan_release.LoadMemberProfiles()
                txt_password.Clear()
            End If
        Else
            display_error("Invalid Password!")
        End If
    End Sub


    Private Sub Guna2ImageButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_see.MouseUp
        txt_password.UseSystemPasswordChar = True
    End Sub
    Private Sub Guna2ImageButton1_Mousedown(sender As Object, e As MouseEventArgs) Handles btn_see.MouseDown
        txt_password.UseSystemPasswordChar = False
    End Sub
End Class