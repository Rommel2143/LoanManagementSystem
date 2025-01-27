
Imports MySql.Data.MySqlClient
Public Class loan_collection_set
    Dim collection_id As Integer
    Dim duefines As Decimal
    Private Sub loan_approval_set_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.UseSystemPasswordChar = True
    End Sub

    Public Sub loadprofile(reference As String, id As Integer, collectdate As Date, payment As Decimal, account As String)
        Try
            ' Populate labels with provided information
            lbl_reference.Text = reference
            collection_id = id
            lbl_account.Text = account
            lbl_cdate.Text = collectdate.ToString("MMMM dd, yyyy")
            lbl_payment.Text = payment.ToString("N2")

            ' Check if collection date is within the past 5 days
            If collectdate < Date.Today.AddDays(-5) Then
                duefines = payment * 0.02 ' Apply 2% fine for overdue payments
            Else
                duefines = 0.00 ' No fine for payments on time or in advance
            End If

            ' Display calculated due fines
            lbl_duefines.Text = duefines.ToString("N2")
        Catch ex As Exception
            display_error(ex.Message) ' Handle and display exceptions
        Finally
            ' Close the connection if it's open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If txt_password.Text = user_pass Then
            con.Close()
            con.Open()
            ' Update the status_inspect for the selected row
            Dim cmdUpdateStatus As New MySqlCommand("UPDATE loan_collection SET status = 1,due_fines='" & duefines & "', teller='" & user_account & "',date_paid='" & datedb & "',mode='" & cmb_mode.text.Split(" "c)(0) & "' WHERE id = '" & collection_id & "'", con)
            cmdUpdateStatus.ExecuteNonQuery()
            Dim printpass As New collection_print
            printpass.print_collection(collection_id)

            printpass.ShowDialog()
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        duefines = 0
        lbl_duefines.Text = "0.00"
    End Sub
End Class