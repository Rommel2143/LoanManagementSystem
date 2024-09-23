Imports MySql.Data.MySqlClient
Public Class loan_collection
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
            Dim cmd As New MySqlCommand("SELECT u.account_no,u.mode,u.service_fee,u.purpose,u.insurance_fee,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,u.amount,u.ammortization,u.referenceno,mp.sharecap,u.months_count FROM `loan_app` u
                                        JOIN member_profile mp ON u.account_no= mp.account_no
                                        WHERE u.referenceno='" & reference & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then


                lbl_fullname.Text = dr.GetString("fullname") & "(" & dr.GetString("account_no") & ")"
                lbl_reference.Text = dr.GetString("referenceno")
                lbl_loanamount.Text = dr.GetDecimal("amount").ToString("N0")
                lbl_purpose.Text = dr.GetString("purpose")
                reload("SELECT `id`, DATE_FORMAT(date_month, '%M %d, %Y') AS Due_Date, `ammortization` AS Payment, `due_fines` AS Due_Fines,
                        CASE status
                        WHEN 0 THEN 'Unpaid'
                        WHEN 1 THEN 'Paid'
                         END AS Status
                        FROM `loan_collection`
                        WHERE referenceno ='" & reference & "'", datagrid1)
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

    Private Sub loan_collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Check if the clicked column is the "StatusIcon" column
            If datagrid1.Columns(e.ColumnIndex).Name = "StatusIcon" Then
                ' Retrieve the value of the "id" column in the clicked row

                Dim id As String = datagrid1.Rows(e.RowIndex).Cells("id").Value.ToString()
                Dim datepay As Date = datagrid1.Rows(e.RowIndex).Cells("Due_date").Value.ToString()
                Dim payment As String = datagrid1.Rows(e.RowIndex).Cells("Payment").Value.ToString()
                loan_collection_set.loadprofile(lbl_reference.Text, id, datepay, payment, lbl_fullname.Text)
                loan_collection_set.ShowDialog()
                loan_collection_set.BringToFront()
            End If
            End If
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub
End Class