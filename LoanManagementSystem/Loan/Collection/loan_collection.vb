Imports MySql.Data.MySqlClient
Public Class loan_collection
    Dim referenceno As String

    Public Sub loadmonths(reference As String)
        Try
            referenceno = reference
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
     ROW_NUMBER() OVER (ORDER BY lc.id ASC) AS Month, 
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
WHERE referenceno ='" & reference & "'
ORDER BY lc.id ASC", datagrid1)
                datagrid1.Columns("id").Visible = False
                datagrid1.Columns("Status").Visible = False

                If Not datagrid1.Columns.Contains("StatusIcon") Then
                    Dim imgCol As New DataGridViewImageColumn()
                    imgCol.Name = "StatusIcon"
                    imgCol.HeaderText = "Payment_Status"
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                    ' imgCol.Width = 40
                    datagrid1.Columns.Add(imgCol)
                End If

                ' Flag to track if the first unpaid record is found
                Dim firstUnpaidFound As Boolean = False

                For Each row As DataGridViewRow In datagrid1.Rows
                    Dim status As String = row.Cells("Status").Value.ToString()

                    If status = "Unpaid" Then
                        If Not firstUnpaidFound Then
                            ' Assign "process" icon to the first unpaid record
                            row.Cells("StatusIcon").Value = My.Resources.process
                            firstUnpaidFound = True
                        Else

                            row.Cells("StatusIcon").Value = My.Resources.clock
                        End If
                    ElseIf status = "Paid" Then
                        ' Assign "paid" icon to paid records
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

    Private Sub loan_collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Check if the clicked column is the "StatusIcon" column
            If datagrid1.Columns(e.ColumnIndex).Name = "StatusIcon" Then
                ' Flag to identify if the first unpaid record has been clicked
                Dim firstUnpaidFound As Boolean = False

                ' Loop through the rows to find the first unpaid record
                For i As Integer = 0 To datagrid1.Rows.Count - 1
                    Dim status As String = datagrid1.Rows(i).Cells("Status").Value.ToString()

                    If status = "Unpaid" Then
                        ' If the first unpaid record is found, check if it's the clicked row
                        If Not firstUnpaidFound Then
                            firstUnpaidFound = True
                            ' Check if the clicked row is the first unpaid record
                            If i = e.RowIndex Then
                                ' Proceed with opening the form for the first unpaid record
                                Dim id As String = datagrid1.Rows(e.RowIndex).Cells("id").Value.ToString()
                                Dim datepay As Date = Date.Parse(datagrid1.Rows(e.RowIndex).Cells("Due_Date").Value.ToString())
                                Dim payment As String = datagrid1.Rows(e.RowIndex).Cells("Payment").Value.ToString()

                                ' Open the loan collection form
                                loan_collection_set.loadprofile(lbl_reference.Text, id, datepay, payment, lbl_fullname.Text)
                                loan_collection_set.ShowDialog()
                                loan_collection_set.BringToFront()
                            End If
                        End If
                        Exit For
                    End If
                Next

                ' Optional: If any other unpaid record or paid records are clicked
                If Not firstUnpaidFound Then
                    ' Display a message if the user clicks on any other record
                    MessageBox.Show("You can only click the first unpaid record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub



    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        diminishing_loan.print_diminishing(referenceno)
        MessageBox.Show(referenceno)
        diminishing_loan.Show()
        diminishing_loan.BringToFront()
    End Sub
End Class