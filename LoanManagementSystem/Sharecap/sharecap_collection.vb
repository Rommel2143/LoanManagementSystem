﻿Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class sharecap_collection
    Dim account_share As String
    Dim selected_trans As String

    Private Sub sharecap_collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loaddata(acc As String, fname As String)
        account_share = acc
        lbl_balance.Text = String.Format("₱{0:N2}", checksharecap(acc))
        lbl_accountname.Text = fname
        'reload("SELECT sharecap.id,`referenceno`, `amount` AS 'Amount', DATE_FORMAT(date_transac, '%M %d, %Y') AS Date,`status` AS 'Type', initials AS 'Teller' FROM `sharecap`
        'LEFT JOIN user ON sharecap.teller=user.account_no
        'WHERE sharecap.account_no='" & acc & "' 
        ' ORDER BY date_transac DESC", datagrid1)



        reload("SELECT sharecap.id,
    `referenceno` AS `Reference no`, 
    `date_transac`, 
    CASE 
        WHEN `status` IN ('ID' ,'CM','CD','ISC' ,'IPR' ,'C','CASHDEP','BEGBAL','CMEMO','CHKDEP','CSHAD1','INT') 
        THEN `amount` ELSE 0 END AS `Deposit`,
    CASE 
        WHEN `status` IN ('DM','CA','D','DMEMO','CHKWID','CSHWIT','CHKWIT') 
        THEN `amount` ELSE 0 END AS `Withdrawal`,
 SUM(
        CASE 
            WHEN `status` IN ('ID' ,'CM','CD','ISC' ,'IPR' ,'C','CASHDEP','BEGBAL','CMEMO','CHKDEP','CSHAD1','INT') 
            THEN `amount` 
            WHEN `status` IN ('DM','CA','D','DMEMO','CHKWID','CSHWIT','CHKWIT') 
            THEN -`amount`
            ELSE 0 
        END
    ) OVER (PARTITION BY sharecap.account_no ORDER BY sharecap.id) AS `Balance`,

status AS 'Transaction',
initials as 'Teller'
FROM `sharecap`
 LEFT JOIN user ON sharecap.teller=user.account_no
WHERE sharecap.account_no='" & acc & "'
ORDER BY id DESC;
", datagrid1)



        '  datagrid1.Columns("amount").DefaultCellStyle.Format = "₱#,##0.00"



        ' Check if "ActionImage" column already exists
        Dim columnExists As Boolean = False
        For Each column As DataGridViewColumn In datagrid1.Columns
            If column.Name = "ActionImage" Then
                columnExists = True
                Exit For
            End If
        Next

        ' Add an image column if not already added
        If Not columnExists Then
            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "ActionImage"
            imgColumn.HeaderText = "Action"
            imgColumn.Image = My.Resources.print ' Replace with your actual resource

            datagrid1.Columns.Insert(0, imgColumn) ' Insert at the first column
            datagrid1.Columns(0).Width = 30
            datagrid1.Columns("id").Visible = False
        End If
    End Sub
    Private Sub insertshare()
        Try

            If user_pass = txt_password.Text Then


                con.Close()
                con.Open()

                ' Use parameterized query
                Dim cmdinsert As New MySqlCommand("INSERT INTO sharecap (`referenceno`, `account_no`, `amount`, `date_transac`, `time`,`status`, `teller`)
                                                                VALUES ('" & GenerateReferenceNumber("SC") & "',
                                                                       '" & account_share & "',
                                                                        @amount,
                                                                       '" & datedb & "',
                                                                       '" & Date.Now.ToString("HH:mm") & "',
                                                                       '" & get_trans() & "',
                                                                       '" & user_account & "')", con)

                ' Add parameters
                cmdinsert.Parameters.AddWithValue("@amount", Convert.ToDecimal(txt_amountdeposit.Text))
                cmdinsert.ExecuteNonQuery()

                MessageBox.Show("Record saved successfully.")
                txt_amountdeposit.Clear()
                txt_password.Clear()
                loaddata(account_share, lbl_accountname.Text)
            Else
                display_error("Invalid Password!")
            End If
        Catch ex As Exception
            display_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function get_trans() As String
        Select Case cmb_transaction.Text.Trim()
            Case "Initial Deposit"
                Return "ID"
            Case "Cash Deposit"
                Return "CD"
            Case "Credit Memo"
                Return "CM"
            Case "Interest on Sharecapital"
                Return "ISC"
            Case "Patronage Refund"
                Return "IPR"
            Case "Debit Memo"
                Return "DM"
            Case "Closed account"
                Return "CA"
            Case Else
                Return "Unknown" ' Optional: Add default return value for unexpected cases
        End Select
    End Function

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub cmb_deptrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_transaction.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        insertshare()
    End Sub

    'Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amountdeposit.TextChanged

    '    Dim textBox As Guna.UI2.WinForms.Guna2TextBox = DirectCast(sender, Guna.UI2.WinForms.Guna2TextBox)


    '    Dim numericText As String = New String(textBox.Text.Where(Function(c) Char.IsDigit(c) Or c = "."c).ToArray())

    '    ' Remove existing event handler to prevent infinite loop
    '    RemoveHandler textBox.TextChanged, AddressOf txt_amount_TextChanged

    '    ' Format the numeric text as currency
    '    If Decimal.TryParse(numericText, NumberStyles.Any, CultureInfo.InvariantCulture, Nothing) Then
    '        Dim formattedText As String = String.Format(CultureInfo.CurrentCulture, "{0:N0}", Convert.ToDecimal(numericText))
    '        textBox.Text = formattedText
    '        ' Move the cursor to the end of the text
    '        textBox.SelectionStart = textBox.Text.Length
    '    End If

    '    ' Re-add the event handler
    '    AddHandler textBox.TextChanged, AddressOf txt_amount_TextChanged
    'End Sub

    Private Sub txt_amountdeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amountdeposit.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True ' Ignore the input
        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Guna2Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    'Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
    '    Dim printpass As New print_passbook
    '    printpass.print_pass(account_share)

    '    printpass.ShowDialog()
    'End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If check_access_user("print_sharecap") = True Then


            If e.ColumnIndex = datagrid1.Columns("ActionImage").Index AndAlso e.RowIndex >= 0 Then
                    Dim status As String = datagrid1.Rows(e.RowIndex).Cells("Transaction").Value.ToString()
                    Dim withdraw As String = datagrid1.Rows(e.RowIndex).Cells("withdrawal").Value.ToString()
                    Dim deposit As String = datagrid1.Rows(e.RowIndex).Cells("deposit").Value.ToString()
                    Dim balance As String = datagrid1.Rows(e.RowIndex).Cells("balance").Value.ToString()
                    Dim teller As String = datagrid1.Rows(e.RowIndex).Cells("Teller").Value.ToString()
                Dim date_transac As String = datagrid1.Rows(e.RowIndex).Cells("date_transac").Value.ToString()

                Dim printpass As New print_passbook
                printpass.loaddata(status, withdraw, deposit, balance, teller, date_transac, account_share, Regex.Replace(lbl_accountname.Text, "\(\d+\)", "").Trim())
                printpass.ShowDialog()
                End If


        End If

    End Sub
End Class