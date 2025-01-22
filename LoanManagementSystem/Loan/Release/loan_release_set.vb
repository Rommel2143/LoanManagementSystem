
Imports MySql.Data.MySqlClient
Public Class loan_release_set
    Dim referenceno As String
    Dim account_no As String
    Dim ammortization As Decimal
    Dim months_count As Integer

    Dim loan_amount As Decimal
    Dim interest_rate As Decimal
    Private Sub loan_approval_set_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_password.UseSystemPasswordChar = True
        dtpicker1.Value = Date.Now
    End Sub

    Public Sub loadprofile(reference As String)
        Try
            Dim currentDate As Date = Date.Now
            Dim currentDay As Integer = currentDate.Day
            Dim currentMonth As Integer = currentDate.Month
            Dim currentYear As Integer = currentDate.Year


            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT u.account_no,u.mode,u.service_fee,u.purpose,u.insurance_fee,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,u.amount,u.ammortization,u.referenceno,u.months_count,u.interest_rate FROM `loan_app` u
                                        JOIN member_profile mp ON u.account_no= mp.account_no
                                        WHERE u.referenceno='" & reference & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                referenceno = dr.GetString("referenceno")
                account_no = dr.GetString("account_no")
                months_count = dr.GetInt32("months_count")
                ammortization = dr.GetDecimal("ammortization")
                Dim disburse As Decimal = dr.GetDecimal("amount") - (dr.GetDecimal("service_fee") + dr.GetDecimal("insurance_fee"))
                lbl_fullname.Text = dr.GetString("fullname") & "(" & dr.GetString("account_no") & ")"
                lbl_reference.Text = dr.GetString("referenceno")
                loan_amount = dr.GetDecimal("amount")
                lbl_loanamount.Text = loan_amount.ToString("N0")
                lbl_disbursement.Text = disburse.ToString("N0")
                lbl_processfee.Text = dr.GetDecimal("service_fee").ToString("N0") * -1
                lbl_insurance.Text = dr.GetDecimal("insurance_fee").ToString("N0") * -1
                lbl_purpose.Text = dr.GetString("purpose")
                lbl_transfer.Text = dr.GetString("mode")
                interest_rate = dr.GetDecimal("interest_rate")
                MessageBox.Show(interest_rate & "--" & loan_amount)
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
        If txt_password.Text = user_pass Then
            con.Close()
            con.Open()
            ' Update the status_inspect for the selected row
            Dim cmdUpdateStatus As New MySqlCommand("UPDATE loan_app SET status = 2, date_release='" & datedb & "', teller_release='" & user_account & "' WHERE referenceno = '" & lbl_reference.Text & "'", con)
            cmdUpdateStatus.ExecuteNonQuery()
            insert_monthly()

            If lbl_transfer.Text = "Savings" Then

                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinserttosavings As New MySqlCommand("INSERT INTO savings (`referenceno`, `account_no`, `amount`, `date_transac`, `time`,`status`, `teller`)
                                                                VALUES ('" & GenerateReferenceNumber("S") & "',
                                                                       '" & account_no & "',
                                                                        @amount,
                                                                       CURDATE(),
                                                                       '" & Date.Now.ToString("HH:mm") & "',
                                                                       'CD',
                                                                       '" & user_account & "')", con)

                ' Add parameters
                cmdinserttosavings.Parameters.AddWithValue("@amount", Convert.ToDecimal(lbl_loanamount.Text))
                cmdinserttosavings.ExecuteNonQuery()
            End If


            Me.Close()

            loan_release.LoadMemberProfiles()
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
    Private Sub insert_monthly()
        con.Close()
        con.Open()

        ' Get the current date from dtpicker1
        Dim startDate As Date = dtpicker1.Value
        Dim startDay As Integer = startDate.Day
        Dim startMonth As Integer = startDate.Month
        Dim startYear As Integer = startDate.Year

        Using transaction As MySqlTransaction = con.BeginTransaction()
            Try
                Dim loan_bal As Decimal = (loan_amount - ammortization) + (loan_amount * (interest_rate / 12))
                Dim loan_gross As Decimal = (ammortization * 12) - ammortization
                Dim loan_interest As Decimal = loan_amount * (interest_rate / 12)
                Dim principal As Decimal = loan_bal

                For i As Integer = 0 To months_count - 1 ' Start from 0 to include the first date
                    Dim month As Integer = (startMonth + i - 1) Mod 12 + 1
                    Dim year As Integer = startYear + (startMonth + i - 1) \ 12

                    ' Clamp day to valid range
                    Dim daysInMonth As Integer = Date.DaysInMonth(year, month)
                    Dim validDay As Integer = Math.Min(startDay, daysInMonth)
                    Dim date_month As Date = New Date(year, month, validDay)



                    cmd.CommandText = "INSERT INTO loan_collection (referenceno, account_no, date_month, ammortization,principal,interest,gross,loan_balance, due_fines,teller,date_paid, status) " &
                                      "VALUES (@referenceno, @account_no, @date_month, @ammortization,@principal,@interest,@gross,@loan_balance, @due_fines,NULL,NULL, @status)"
                    cmd.Connection = con

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@referenceno", referenceno)
                    cmd.Parameters.AddWithValue("@account_no", account_no)
                    cmd.Parameters.AddWithValue("@date_month", date_month)
                    cmd.Parameters.AddWithValue("@ammortization", ammortization)
                    cmd.Parameters.AddWithValue("@principal", principal)
                    cmd.Parameters.AddWithValue("@interest", loan_interest)
                    cmd.Parameters.AddWithValue("@gross", loan_gross)
                    cmd.Parameters.AddWithValue("@loan_balance", loan_bal)
                    cmd.Parameters.AddWithValue("@due_fines", 0)
                    cmd.Parameters.AddWithValue("@status", 0)

                    cmd.ExecuteNonQuery()

                    loan_interest = (loan_bal + ammortization) * (interest_rate / 12)
                    principal -= loan_bal
                    loan_bal -= ammortization
                    loan_gross -= ammortization


                Next

                transaction.Commit()
                MessageBox.Show("Records inserted successfully.")
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error during insertion: " & ex.Message)
            End Try
        End Using

        con.Close()
    End Sub


End Class