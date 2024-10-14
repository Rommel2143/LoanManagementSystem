Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class savings
    Dim account_no As String
    Private Sub savings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loaddata(account As String)
        account_no = account
        lbl_balance.Text = checksavings(account)
        reload("SELECT `referenceno`, `amount`, DATE_FORMAT(date_transac, '%M %d, %Y') AS Date,time,`status`, `teller` FROM `savings` WHERE account_no='" & account & "' ", datagrid1)
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try

            If user_pass = txt_password.Text Then


                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO savings (`referenceno`, `account_no`, `amount`, `date_transac`, `time`,`status`, `teller`)
                                                                VALUES ('" & GenerateReferenceNumber("D") & "',
                                                                       '" & account_no & "',
                                                                        @amount,
                                                                       '" & datedb & "',
                                                                       '" & Date.Now.ToString("HH:mm") & "',
                                                                       'D',
                                                                       '" & user_account & "')", con)

                ' Add parameters
                cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amountdeposit.Text))
                cmdinsert.ExecuteNonQuery()
                hide_error()
                MessageBox.Show("Record saved successfully.")
                txt_amountdeposit.Clear()
                txt_password.Clear()
                loaddata(account_no)
            Else
                display_error("Invalid Password!")
            End If
        Catch ex As Exception
            display_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btn_withdraw_Click(sender As Object, e As EventArgs) Handles btn_withdraw.Click
        Try

            If user_pass = txt_passwithdraw.Text Then

                If Convert.ToDecimal(txt_amountwithdraw.Text) > Convert.ToDecimal(lbl_balance.Text) Then
                    display_error("Available balance to low!")
                    Exit Sub
                End If
                con.Close()
                    con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO savings (`referenceno`, `account_no`, `amount`, `date_transac`, `time`, `status`, `teller`)
                                                                VALUES ('" & GenerateReferenceNumber("W") & "',
                                                                       '" & account_no & "',
                                                                        @amount,
                                                                       '" & datedb & "',
                                                                       '" & Date.Now.ToString("HH:mm") & "',
                                                                       'W',
                                                                       '" & user_account & "')", con)

                ' Add parameters
                cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amountwithdraw.Text))
                cmdinsert.ExecuteNonQuery()
                hide_error()
                MessageBox.Show("Record saved successfully.")
                    txt_amountwithdraw.Clear()
                    txt_passwithdraw.Clear()
                    loaddata(account_no)


            Else
                    display_error("Invalid Password!")
            End If
        Catch ex As Exception
            display_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amountdeposit.TextChanged, txt_amountwithdraw.TextChanged

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
    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amountwithdraw.KeyPress, txt_amountdeposit.KeyPress
        ' Allow only digits, one decimal point, and backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If


    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub
End Class