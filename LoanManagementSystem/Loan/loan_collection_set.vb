
Imports MySql.Data.MySqlClient
Public Class loan_collection_set
    Dim collection_id As Integer
    Dim duefines As Decimal
    Private Sub loan_approval_set_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.UseSystemPasswordChar = True
    End Sub

    Public Sub loadprofile(reference As String, id As Integer, collectdate As Date, payment As Decimal, account As String)
        Try
            lbl_reference.Text = reference
            collection_id = id
            lbl_account.Text = account
            lbl_cdate.Text = collectdate.ToString("MMMM dd, yyyy")
            lbl_payment.Text = payment.ToString("N2")

            ' Check if collection date is in the past
            If collectdate < Date.Today Then
                duefines = payment * 0.02 ' Apply 2% fine if the due date is in the past
            Else
                duefines = 0.00 ' No fine if the due date is today or in the future
            End If


            lbl_duefines.Text = duefines.ToString("N2")
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
            Dim cmdUpdateStatus As New MySqlCommand("UPDATE loan_collection SET status = 1,due_fines='" & duefines & "', teller='" & user_account & "',date_paid='" & datedb & "' WHERE id = '" & collection_id & "'", con)
            cmdUpdateStatus.ExecuteNonQuery()
            display_formsub(loan_active, "Acive Loan")

            display_formsub(loan_collection, "Loan Collection")
            loan_collection.loadmonths(lbl_reference.Text)
            Me.Close()
            txt_password.Clear()
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