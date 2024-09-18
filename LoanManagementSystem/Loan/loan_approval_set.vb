Imports MySql.Data.MySqlClient
Public Class loan_approval_set
    Private Sub loan_approval_set_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub loadprofile(reference As String)
        Try

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT u.account_no,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,u.amount,u.ammortization,u.referenceno  FROM `loan_app` u
                                        JOIN member_profile mp ON u.account_no= mp.account_no
                                        WHERE u.referenceno='" & reference & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lbl_account.Text = dr.GetString("account_no")
                lbl_fullname.Text = dr.GetString("fullname")
                lbl_reference.Text = dr.GetString("referenceno")
                lbl_loanamount.Text = dr.GetDecimal("amount")
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
            txt_password.Clear()
        Else
            display_error("Invalid Password!")
        End If
    End Sub
End Class