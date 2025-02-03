Imports MySql.Data.MySqlClient
Public Class loan_edit
    Dim referenceno As String
    Dim rad_state As Integer = 0
    Dim loan_amount As Decimal
    Dim interest_rate As Decimal = 0.00
    Dim monthly_ammo As Decimal
    Dim month_count As Integer
    Public comaker1 As String = ""
    Public comaker2 As String = ""
    Private Sub num_plan_ValueChanged(sender As Object, e As EventArgs) Handles num_plan.ValueChanged, num_plan.TextChanged, btn_month.CheckedChanged, btn_year.CheckedChanged, txt_amount.TextChanged
        Try

            If txt_amount.Text = "" Then
                txt_amount.Text = "0"
            Else
                Select Case rad_state
                    Case 0
                        month_count = num_plan.Value
                    Case 1
                        month_count = num_plan.Value * 12
                End Select

                Dim monthly_interest_rate As Decimal = interest_rate / 12D
                Dim loan_amount As Decimal = Convert.ToDecimal(txt_amount.Text)


                ' Calculate monthly amortization
                monthly_ammo = Math.Round((loan_amount * monthly_interest_rate) / (1 - (1 + monthly_interest_rate) ^ -month_count), 2)
                txt_ma.Text = monthly_ammo.ToString("N2") & "/ month"
                lbl_percentinterest.Text = (interest_rate * 100) & "%"
                'service fee
                If month_count <= 6 Then
                    lbl_servicefee.Text = loan_amount * 0.015
                Else
                    lbl_servicefee.Text = loan_amount * 0.03
                End If
                lbl_interest.Text = Convert.ToDecimal((monthly_ammo * month_count) - loan_amount).ToString("N2")

            End If
        Catch ex As OverflowException

        Catch ex As Exception
            display_error("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub loan_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub load_data(reference As String)
        referenceno = reference
        lblreference.Text = reference
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

                num_plan.Value = dr.GetInt32("months_count")
                txt_ma.Text = dr.GetDecimal("ammortization")
                Dim disburse As Decimal = dr.GetDecimal("amount") - (dr.GetDecimal("service_fee") + dr.GetDecimal("insurance_fee"))
                '  lbl_fullname.Text = dr.GetString("fullname") & "(" & dr.GetString("account_no") & ")"
                'lbl_reference.Text = dr.GetString("referenceno")
                'loan_amount = dr.GetDecimal("amount")
                'lbl_loanamount.Text = loan_amount.ToString("N0")
                'lbl_disbursement.Text = disburse.ToString("N0")
                'lbl_processfee.Text = dr.GetDecimal("service_fee").ToString("N0") * -1
                'lbl_insurance.Text = dr.GetDecimal("insurance_fee").ToString("N0") * -1
                'lbl_purpose.Text = dr.GetString("purpose")
                'lbl_transfer.Text = dr.GetString("mode")
                interest_rate = dr.GetDecimal("interest_rate")
            End If
        Catch ex As Exception
            display_error(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class