Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Linq
Public Class loan_application
    Dim rad_state As Integer = 0
    Dim loan_amount As Decimal
    Dim interest_rate As Decimal = 0.00
    Dim monthly_ammo As Decimal
    Dim month_count As Integer
    Public comaker1 As String = ""
    Public comaker2 As String = ""

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim search As New search_name
        With search
            .lbl_who.Text = "Borrower :"
            .Show()
            .BringToFront()

        End With

    End Sub

    Private Sub loan_application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_display("SELECT type from loan_types", "type", cmb_purpose)


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try

            Select Case rad_state
                Case 0
                    month_count = num_plan.Value
                Case 1
                    month_count = num_plan.Value * 12
            End Select

            con.Close()
            con.Open()

            ' Use parameterized query
            Dim cmdinsert As New MySqlCommand("INSERT INTO `loan_app` (`referenceno`,
                                                                        `account_no`,
                                                                        `amount`,
                                                                        `ammortization`,
                                                                        `date_apply`,
                                                                        `date_approved`,
                                                                        `date_start`,
                                                                        `months_count`,
                                                                        `teller`,
                                                                        `teller_approved`,
                                                                         `teller_release`, 
                                                                        `mode`,
                                                                        `purpose`,
                                                                        `comaker_1`,
                                                                        `comaker_2`,
                                                                        `interest_rate`,
                                                                        `service_fee`,
                                                                        `insurance_fee`,
                                                                        `interest`,
                                                                        `collateral`,
                                                                        `collateral_value`,
                                                                        `status`)
                                                                VALUES (@referenceno,
                                                                        @account_no,
                                                                        @amount,
                                                                        @ammortization,
                                                                        @date_apply,
                                                                        @date_approved,
                                                                        @date_start,
                                                                        @months_count,
                                                                        @teller,
                                                                        @teller_approved,
                                                                        @teller_release,
                                                                        @mode, @purpose,
                                                                        @comaker_1,
                                                                        @comaker_2,
                                                                        @interest_rate,
                                                                        @service_fee,
                                                                        @insurance_fee,
                                                                        @interest,
                                                                        @collateral,
                                                                        @collateral_value,
                                                                        @status)", con)

            ' Add parameters
            cmdinsert.Parameters.AddWithValue("@referenceno", lbl_reference.Text)
            cmdinsert.Parameters.AddWithValue("@account_no", lbl_account.Text)
            cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amount.Text))
            cmdinsert.Parameters.AddWithValue("@ammortization", monthly_ammo)
            cmdinsert.Parameters.AddWithValue("@date_apply", datedb)
            cmdinsert.Parameters.AddWithValue("@date_approved", DBNull.Value)
            cmdinsert.Parameters.AddWithValue("@date_start", DBNull.Value)
            cmdinsert.Parameters.AddWithValue("@months_count", month_count)
            cmdinsert.Parameters.AddWithValue("@teller", user_account)
            cmdinsert.Parameters.AddWithValue("@teller_approved", String.Empty)
            cmdinsert.Parameters.AddWithValue("@teller_release", String.Empty)
            cmdinsert.Parameters.AddWithValue("@mode", cmb_mode.Text)
            cmdinsert.Parameters.AddWithValue("@purpose", cmb_purpose.Text)
            cmdinsert.Parameters.AddWithValue("@comaker_1", comaker1)
            cmdinsert.Parameters.AddWithValue("@comaker_2", comaker2)
            cmdinsert.Parameters.AddWithValue("@interest_rate", interest_rate)
            cmdinsert.Parameters.AddWithValue("@service_fee", Convert.ToDecimal(lbl_servicefee.Text))
            cmdinsert.Parameters.AddWithValue("@insurance_fee", Convert.ToDecimal(txt_insurance.Text))
            cmdinsert.Parameters.AddWithValue("@interest", Convert.ToDecimal(lbl_interest.Text))
            cmdinsert.Parameters.AddWithValue("@collateral", cmb_collateral.Text)
            cmdinsert.Parameters.AddWithValue("@collateral_value", Convert.ToDecimal(txt_collavalue.Text))
            cmdinsert.Parameters.AddWithValue("@status", 0)
            cmdinsert.ExecuteNonQuery()

            If MessageBox.Show("Application saved. Do you want to print info?", "Print info?", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                Dim print As New print_loanapp
                print.printapplication(lbl_reference.Text)
                print.ShowDialog()

            Else
                ' Code to execute if the user clicks "No" (optional)
            End If

            txt_amount.Clear()
            lbl_account.Text = "---"
            lbl_fullname.Text = "---"
            lbl_reference.Text = "---"
            num_plan.Value = 1
            lbl_cm1.Text = "Please select name..."
            lbl_cm2.Text = "Please select name..."
            lbl_comaker1.Text = ""
            lbl_comaker2.Text = ""

            Me.Close()
        Catch ex As Exception
            display_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btn_month_CheckedChanged(sender As Object, e As EventArgs) Handles btn_month.CheckedChanged
        rad_state = 0
    End Sub

    Private Sub btn_year_CheckedChanged(sender As Object, e As EventArgs) Handles btn_year.CheckedChanged
        rad_state = 1
    End Sub

    Private Sub cmb_purpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_purpose.SelectedIndexChanged
        Try
            con.Close()
            con.Open()

            Dim cmdselect As New MySqlCommand("SELECT * FROM `loan_types` WHERE type = @type", con)
            cmdselect.Parameters.AddWithValue("@type", cmb_purpose.Text)

            dr = cmdselect.ExecuteReader()
            If dr.Read() Then
                interest_rate = dr.GetDecimal(dr.GetOrdinal("interest"))
                lbl_rate.Text = (interest_rate * 100) & "%"
            Else
                MessageBox.Show("No matching loan type found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amount.TextChanged
        Dim textBox As Guna.UI2.WinForms.Guna2TextBox = DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox)


        Dim numericText As String = New String(textBox.Text.Where(Function(c) Char.IsDigit(c) Or c = "."c).ToArray())

        ' Remove existing event handler to prevent infinite loop
        RemoveHandler textBox.TextChanged, AddressOf txt_amount_TextChanged

        ' Format the numeric text as currency
        If Decimal.TryParse(numericText, NumberStyles.Any, CultureInfo.InvariantCulture, Nothing) Then
            Dim formattedText As String = String.Format(CultureInfo.CurrentCulture, "{0:N0}", Convert.ToDecimal(numericText))
            textBox.Text = formattedText
            ' Move the cursor to the end of the text
            textBox.SelectionStart = textBox.Text.Length
        End If

        ' Re-add the event handler
        AddHandler textBox.TextChanged, AddressOf txt_amount_TextChanged

    End Sub
    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress, txt_insurance.KeyPress
        ' Allow only digits, one decimal point, and backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If (e.KeyChar = "."c) AndAlso (txt_amount.Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If

    End Sub
    Private Sub num_plan_ValueChanged(sender As Object, e As EventArgs) Handles num_plan.ValueChanged, num_plan.TextChanged, btn_month.CheckedChanged, btn_year.CheckedChanged, txt_amount.TextChanged, cmb_purpose.SelectedIndexChanged, txt_otheramount1.TextChanged, txt_otheramount2.TextChanged
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


                lbl_loanamount.Text = loan_amount.ToString("N0")
                lbl_processfee.Text = "-" & Convert.ToDecimal(lbl_servicefee.Text).ToString("N0")
                lbl_purpose.Text = cmb_purpose.Text

                lbl_disbursement.Text = (loan_amount - (Convert.ToDecimal(lbl_servicefee.Text) + Convert.ToDecimal(txt_insurance.Text) + Convert.ToDecimal(txt_otheramount1.Text) + Convert.ToDecimal(txt_otheramount2.Text))).ToString("N0")
                lbl_term.Text = month_count & " months"
                lbl_ma.Text = txt_ma.Text
            End If
        Catch ex As OverflowException

        Catch ex As Exception
            display_error("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub lbl_account_Click(sender As Object, e As EventArgs) Handles lbl_account.Click

    End Sub

    Private Sub lbl_account_TextChanged(sender As Object, e As EventArgs) Handles lbl_account.TextChanged
        If lbl_account.Text = "---" Then
            tabcontrol.Enabled = False
        Else
            tabcontrol.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_collateral_SelectedIndexChanged(sender As Object, e As EventArgs)
        lbl_collateral.Text = cmb_collateral.Text
    End Sub

    Private Sub cmb_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mode.SelectedIndexChanged
        lbl_transfer.Text = cmb_mode.Text
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles lbl_cm1.Click

    End Sub

    Private Sub Label29_TextChanged(sender As Object, e As EventArgs) Handles lbl_cm1.TextChanged
        lbl_comaker1.Text = lbl_cm1.Text
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles lbl_cm2.Click

    End Sub

    Private Sub Label30_TextChanged(sender As Object, e As EventArgs) Handles lbl_cm2.TextChanged
        lbl_comaker2.Text = lbl_cm2.Text
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        Dim search As New search_name
        With search
            .lbl_who.Text = "Co-maker 1 :"
            .Show()
            .BringToFront()

        End With
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim search As New search_name
        With search
            .lbl_who.Text = "Co-maker 2 :"
            .Show()
            .BringToFront()

        End With
    End Sub

    Private Sub panel_details_Click(sender As Object, e As EventArgs) Handles panel_details.Click

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_collavalue.TextChanged
        Dim textBox As Guna.UI2.WinForms.Guna2TextBox = DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox)


        Dim numericText As String = New String(textBox.Text.Where(Function(c) Char.IsDigit(c) Or c = "."c).ToArray())

        ' Remove existing event handler to prevent infinite loop
        RemoveHandler textBox.TextChanged, AddressOf txt_amount_TextChanged

        ' Format the numeric text as currency
        If Decimal.TryParse(numericText, NumberStyles.Any, CultureInfo.InvariantCulture, Nothing) Then
            Dim formattedText As String = String.Format(CultureInfo.CurrentCulture, "{0:N0}", Convert.ToDecimal(numericText))
            textBox.Text = formattedText
            ' Move the cursor to the end of the text
            textBox.SelectionStart = textBox.Text.Length
        End If

        ' Re-add the event handler
        AddHandler textBox.TextChanged, AddressOf txt_amount_TextChanged
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub txt_insurance_TextChanged(sender As Object, e As EventArgs) Handles txt_insurance.TextChanged
        If txt_insurance.Text = "" Then

        Else
            lbl_insurancefee.Text = (Convert.ToDecimal(txt_insurance.Text) * -1).ToString("N0")
        End If
    End Sub

    Private Sub lbl_loanamount_Click(sender As Object, e As EventArgs) Handles lbl_loanamount.Click

    End Sub

    Private Sub lbl_loanamount_TextChanged(sender As Object, e As EventArgs) Handles lbl_loanamount.TextChanged

    End Sub

    Private Sub cmb_collateral_TextChanged(sender As Object, e As EventArgs) Handles cmb_collateral.TextChanged
        lbl_collateral.Text = cmb_collateral.Text
    End Sub

    Private Sub txt_otheramount1_TextChanged(sender As Object, e As EventArgs) Handles txt_otheramount1.TextChanged
        lbl_otherfee1.Text = txt_otheramount1.Text

    End Sub

    Private Sub txt_otheramount2_TextChanged(sender As Object, e As EventArgs) Handles txt_otheramount2.TextChanged
        lbl_otherfee2.Text = txt_otheramount2.Text
    End Sub

    Private Sub lbl_disbursement_Click(sender As Object, e As EventArgs) Handles lbl_disbursement.Click

    End Sub

    Private Sub panel_apply_Click(sender As Object, e As EventArgs) Handles panel_apply.Click

    End Sub
End Class
