
Public Class quarter_rate
    Private Sub weight_ave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2NumericUpDown1.Value = Date.Now.ToString("yyyy")
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Ensure txt_rate contains a valid numeric value
        Dim rateValue As Decimal
        If Not Decimal.TryParse(txt_rate.Text, rateValue) Then
            MessageBox.Show("Please enter a valid numeric rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Convert percentage rate to decimal (e.g., 6% -> 0.06)
        Dim rateDecimal As Decimal = rateValue / 100

        ' SQL Query for Quarter 1
        Dim query As String = "SELECT 
        sc.account_no,
        CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,
        YEAR(sc.date_transac) AS year,
        QUARTER(sc.date_transac) AS quarter,
        CONCAT(" & rateValue & ", ' %') as Rate,
        SUM(sc.amount) AS quarterly_total,
        ((SUM(sc.amount) / 90) * " & rateDecimal & ") / 360 AS computed_value
    FROM savings sc
    LEFT JOIN member_profile mp ON mp.account_no = sc.account_no
    WHERE YEAR(sc.date_transac) = " & Guna2NumericUpDown1.Value & "
    AND QUARTER(sc.date_transac) = " & cmb_quarter.Text & "
    GROUP BY sc.account_no, fullname, YEAR(sc.date_transac), QUARTER(sc.date_transac)
    ORDER BY fullname, year, quarter;"

        ' Execute the query
        reload(query, datagrid1)
    End Sub




    Private Sub txt_rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rate.KeyPress
        ' Allow only numbers, one decimal point, and control keys (e.g., backspace)
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If

        ' Prevent multiple decimal points
        If e.KeyChar = "."c AndAlso txt_rate.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub


    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub

    Private Sub txt_rate_TextChanged(sender As Object, e As EventArgs) Handles txt_rate.TextChanged

    End Sub
End Class