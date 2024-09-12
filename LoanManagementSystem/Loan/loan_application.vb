Imports MySql.Data.MySqlClient
Public Class loan_application
    Dim rad_state As Integer = 0
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        search_name.Show()
        search_name.BringToFront()
    End Sub

    Private Sub loan_application_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            Dim month_count As Integer
            Select Case rad_state
                Case 0
                    month_count = num_plan.Value
                Case 1
                    month_count = num_plan.Value * 12
            End Select

            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("INSERT INTO `loan_app`  (`referenceno`,
                                                                    `account_no`,
                                                                    `amount`,
                                                                    `ammortization`,
                                                                    `date_apply`,
                                                                    `date_approved`,
                                                                    `date_start`,
                                                                    `months_count`,
                                                                    `teller`,
                                                                    `teller_approved`,
                                                                    `mode`,
                                                                    `purpose`,
                                                                    `comaker_1`,
                                                                    `comaker_2`) 
                                                            VALUES ('" & lbl_reference.Text & "',
                                                                    '" & lbl_account.Text & "',
                                                                    '" & txt_amount.Text & "',
                                                                    '[value-4]',
                                                                    '" & datedb & "',
                                                                    NULL,
                                                                   NULL,
                                                                    '" & month_count & "',
                                                                   '" & user_account & "',
                                                                    '',
                                                                    '" & cmb_mode.Text & "',
                                                                    '" & cmb_purpose.Text & "',
                                                                    '[value-13]',
                                                                    '[value-14]')", con)
            dr = cmdselect.ExecuteReader
            MessageBox.Show("recorded")
        Catch ex As Exception
            display_error("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub btn_month_CheckedChanged(sender As Object, e As EventArgs) Handles btn_month.CheckedChanged
        rad_state = 0
    End Sub

    Private Sub btn_year_CheckedChanged(sender As Object, e As EventArgs) Handles btn_year.CheckedChanged
        rad_state = 1
    End Sub
End Class