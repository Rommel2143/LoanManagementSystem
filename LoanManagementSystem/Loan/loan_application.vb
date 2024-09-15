Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Linq
Public Class loan_application
    Dim rad_state As Integer = 0
    Dim loan_amount As Decimal
    Dim interest_rate As Decimal = 0.00
    Dim monthly_ammo As Decimal
    Dim month_count As Integer

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        search_name.Show()
        search_name.BringToFront()
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
                                                                        `mode`, `purpose`,
                                                                        `comaker_1`,
                                                                        `comaker_2`,
                                                                         `interest`)
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
                                                                        @mode, @purpose,
                                                                        @comaker_1,
                                                                        @comaker_2,
                                                                        @interest)", con)

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
            cmdinsert.Parameters.AddWithValue("@mode", cmb_mode.Text)
            cmdinsert.Parameters.AddWithValue("@purpose", cmb_purpose.Text)
            cmdinsert.Parameters.AddWithValue("@comaker_1", String.Empty)
            cmdinsert.Parameters.AddWithValue("@comaker_2", String.Empty)
            cmdinsert.Parameters.AddWithValue("@interest", interest_rate)
            cmdinsert.ExecuteNonQuery()
            MessageBox.Show("Record saved successfully.")

            txt_amount.Clear()
            lbl_account.Text = "---"
            lbl_fullname.Text = "---"
            lbl_reference.Text = "---"
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
    Private Sub num_plan_ValueChanged(sender As Object, e As EventArgs) Handles num_plan.ValueChanged, btn_month.CheckedChanged, btn_year.CheckedChanged, txt_amount.TextChanged, cmb_purpose.SelectedIndexChanged
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
                txt_ma.Text = monthly_ammo.ToString("N2") & "/Month"

            End If
        Catch ex As OverflowException

        Catch ex As Exception
            display_error("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress

    End Sub

    Private Sub lbl_account_Click(sender As Object, e As EventArgs) Handles lbl_account.Click

    End Sub

    Private Sub lbl_account_TextChanged(sender As Object, e As EventArgs) Handles lbl_account.TextChanged
        If lbl_account.Text = "---" Then
            panel_apply.Enabled = False
        Else
            panel_apply.Enabled = True
        End If
    End Sub

    Private Sub lbl_fullname_Click(sender As Object, e As EventArgs) Handles lbl_fullname.Click

    End Sub
End Class
