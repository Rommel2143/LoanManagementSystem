Public Class loan_edit
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
End Class