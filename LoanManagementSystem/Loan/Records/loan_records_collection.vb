Imports MySql.Data.MySqlClient
Public Class loan_records_collection
    Dim referenceno As String

    Public Sub loadmonths(reference As String)
        Try
            datagrid1.Controls.Clear()
            Dim currentDate As Date = Date.Now
            Dim currentDay As Integer = currentDate.Day
            Dim currentMonth As Integer = currentDate.Month
            Dim currentYear As Integer = currentDate.Year


            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT u.account_no,u.mode,u.service_fee,u.purpose,u.insurance_fee,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,u.amount,u.ammortization,u.referenceno,u.months_count FROM `loan_app` u
                                        JOIN member_profile mp ON u.account_no= mp.account_no
                                        WHERE u.referenceno='" & reference & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then


                lbl_fullname.Text = dr.GetString("fullname") & "(" & dr.GetString("account_no") & ")"
                lbl_reference.Text = dr.GetString("referenceno")
                lbl_loanamount.Text = dr.GetDecimal("amount").ToString("N0")
                lbl_purpose.Text = dr.GetString("purpose")
                lbl_term.Text = dr.GetInt32("months_count") & " month/s"
                reload("SELECT lc.id, 
       DATE_FORMAT(date_month, '%M %d, %Y') AS Due_Date, 
       `ammortization` AS Payment, 
       `due_fines` AS Penalty, 
       CONCAT(initials,' (',date_paid,')') AS Teller,
       CASE status
            WHEN 0 THEN 'Unpaid'
            WHEN 1 THEN 'Paid'
       END AS Status
FROM loan_collection lc
LEFT JOIN user u ON u.account_no = lc.teller
WHERE referenceno ='" & reference & "' and status='1'
", datagrid1)
                datagrid1.Columns("id").Visible = False
                datagrid1.Columns("Status").Visible = False

                If Not datagrid1.Columns.Contains("StatusIcon") Then
                    Dim imgCol As New DataGridViewImageColumn()
                    imgCol.Name = "StatusIcon"
                    imgCol.HeaderText = "Payment_Status"
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                    imgCol.Width = 40
                    datagrid1.Columns.Add(imgCol)
                End If

                ' Set the appropriate icons for the status
                For Each row As DataGridViewRow In datagrid1.Rows
                    Dim status As String = row.Cells("Status").Value.ToString()
                    If status = "Unpaid" Then
                        row.Cells("StatusIcon").Value = My.Resources.process
                    ElseIf status = "Paid" Then
                        row.Cells("StatusIcon").Value = My.Resources.paid
                    End If
                Next

            End If


        Catch ex As Exception
            display_error(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub
End Class