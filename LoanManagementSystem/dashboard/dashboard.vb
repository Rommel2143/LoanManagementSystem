Imports MySql.Data.MySqlClient
Imports Guna.Charts.WinForms
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub loaddata()
        lbl_day.Text = Date.Now.ToString("dd")
        lbl_month.Text = Date.Now.ToString("MMMM")
        lbl_year.Text = Date.Now.ToString("yyyy")
        lbl_membercount.Text = membercount()
        ' lbl_active.Text = activecount()
        lbl_activeloan.Text = activeloan()
        lbl_pendingloan.Text = pendingloan()
        lbl_sharecap.Text = sharecap()
        ' lbl_sharecount.Text = sharecount()
        lbl_transaccount.Text = transac_count()
        lbl_collecttotal.Text = collectiontoday()
        lbl_releasedtotal.Text = releasedtoday()
        lbl_funds.Text = checkfunds()
        lbl_savings.Text = chksavings()
    End Sub

    Private Function membercount() As String
        Try


            Dim query As String = "SELECT COUNT(id) FROM member_profile"
            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return dr.GetInt32(0).ToString("N0")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function

    Private Function chksavings() As String
        Try


            Dim query As String = "Select 
            SUM(CASE WHEN `status` = 'ID'
                        Or status='CHKD'
                        Or status='CD' 
                        Or status='CM'
                      Or status='CSHDEP'
                      Or status='BEGBAL'
                      Or status='TIMDEP'
                      Or status='CMEMO'
                      Or status='CHKDEP'
                      Or status='CSHADJ'
                      Or status='CSHAD1'
                      Or status='INT'
THEN `amount` ELSE 0 END) 
                    - 
            SUM(CASE WHEN `status` = 'CW'
                        Or status = 'CHKW' 
                        Or status = 'DM'
  Or status='DAMAY'
  Or status='DMEMO'
  Or status='DEDB'
  Or status='CSHWIT'
  Or status='CHKBON'
  Or status='TAXWIT'
  Or status='CHKWIT'
                     THEN `amount` ELSE 0 END) AS balance
            FROM `savings`"
            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return dr.GetInt32(0).ToString("N0")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function

    Private Function activecount() As String
        Try


            Dim query As String = "SELECT COUNT(id) FROM member_profile WHERE status='1'"
            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return dr.GetInt32(0).ToString("N0")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function

    Private Function activeloan() As String
        Try


            Dim query As String = "SELECT COUNT(*) AS row_count 
FROM (
    SELECT lc.id 
    FROM loan_collection lc
    
    WHERE lc.status = 0
    GROUP BY lc.referenceno
) AS grouped_data;
"
            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return dr.GetInt32(0).ToString("N0")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function

    Private Function pendingloan() As String
        Try


            Dim query As String = "SELECT COUNT(id) FROM loan_app where status='0'"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return dr.GetInt32(0).ToString("N0")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function


    Private Function checkfunds() As String
        Try
            Dim share As Decimal
            Dim savings As Decimal
            Dim collection As Decimal

            con.Close()
            con.Open()
            ' Define the SQL command to check balance
            Dim check As New MySqlCommand("SELECT 
            SUM(CASE WHEN `status` = 'ID' 
or status='CM'
or status='CD'
or status='ISC' 
or status='IPR' 
or status='C'
or status='CASHDEP'
or status='BEGBAL'
or status='CMEMO'
or status='CHKDEP'
or status='CSHAD1'
or status='INT'

THEN `amount` ELSE 0 END) - 

            SUM(CASE WHEN `status` = 'DM' 
or status = 'CA' 
or status='D'
or status='DMEMO'
or status='CHKWID'
or status='CSHWIT'
or status='CHKWIT'

THEN `amount` ELSE 0 END) AS balance
            FROM `sharecap`", con)
            ' Execute the command and retrieve the balance
            Dim balance As Object = check.ExecuteScalar()
            If balance IsNot DBNull.Value Then
                share = Convert.ToDecimal(balance)
            Else
                share = 0 ' Return 0 if no balance is found
            End If



            con.Close()
            con.Open()
            ' Define the SQL command to check balance
            Dim checksavings As New MySqlCommand("Select 
            SUM(CASE WHEN `status` = 'ID'
                        Or status='CHKD'
                        Or status='CD' 
                        Or status='CM'
                      Or status='CSHDEP'
                      Or status='BEGBAL'
                      Or status='TIMDEP'
                      Or status='CMEMO'
                      Or status='CHKDEP'
                      Or status='CSHADJ'
                      Or status='CSHAD1'
                      Or status='INT'
THEN `amount` ELSE 0 END) 
                    - 
            SUM(CASE WHEN `status` = 'CW'
                        Or status = 'CHKW' 
                        Or status = 'DM'
  Or status='DAMAY'
  Or status='DMEMO'
  Or status='DEDB'
  Or status='CSHWIT'
  Or status='CHKBON'
  Or status='TAXWIT'
  Or status='CHKWIT'
                     THEN `amount` ELSE 0 END) AS balance
            FROM `savings`", con)

            ' Execute the command and retrieve the balance
            Dim balance2 As Object = checksavings.ExecuteScalar()

            ' Check if the result is not null and return the balance as Decimal
            If balance2 IsNot DBNull.Value Then
               savings= Convert.ToDecimal(balance2)
            Else
              savings = 0 ' Return 0 if no balance is found
            End If



            Dim query As String = "SELECT IFNULL(SUM(amount - (service_fee + insurance_fee)), 0) " &
                                  "FROM loan_app WHERE date_release IS NOT NULL "

            con.Close()
                con.Open()
                Dim selectdata As New MySqlCommand(query, con)
                dr = selectdata.ExecuteReader

                If dr.Read() Then
                collection = dr.GetDecimal(0)

            Else
                collection = 0
            End If









            Return (share + savings + collection).ToString("N0")





        Catch ex As Exception
            ' Handle any errors that occur during the execution
            MessageBox.Show("Error: " & ex.Message)
            Return 0 ' Return 0 in case of an error
        Finally
            con.Close() ' Ensure the connection is closed
        End Try

    End Function




    Private Function sharecap() As String
        Try


            Dim query As String = " SELECT 
            SUM(CASE WHEN `status` = 'ID' 
or status='CM'
or status='CD'
or status='ISC' 
or status='IPR' 
or status='C'
or status='CASHDEP'
or status='BEGBAL'
or status='CMEMO'
or status='CHKDEP'
or status='CSHAD1'
or status='INT'

THEN `amount` ELSE 0 END) - 

            SUM(CASE WHEN `status` = 'DM' 
or status = 'CA' 
or status='D'
or status='DMEMO'
or status='CHKWID'
or status='CSHWIT'
or status='CHKWIT'

THEN `amount` ELSE 0 END) AS balance
            FROM `sharecap`"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return dr.GetInt32(0).ToString("N0")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function
    Private Function sharecount() As String
        Try
            Dim query As String = " SELECT 
            (SUM(CASE WHEN `status` = 'ID' or status='CM' or status='CD' or status='ISC' or status='IPR' THEN `amount` ELSE 0 END) - 
            SUM(CASE WHEN `status` = 'DM' or status = 'CA' THEN `amount` ELSE 0 END))/100 AS balance
            FROM `sharecap`"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader()
            If dr.Read() = True Then
                Return dr.GetInt32(0).ToString("N0") ' Format as a number with commas
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."
        Finally
            con.Close() ' Ensure the connection is closed in all scenarios
        End Try
    End Function

    Private Function transac_count() As String

        Dim loanAppCount As Integer
        Dim loanCollectionCount As Integer
        Dim savingscount As Integer
        Dim sharecapcount As Integer
        Dim totalCount As Integer
        con.Close()
        con.Open()

        ' Query for loan_app
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM `loan_app` WHERE `date_apply` = CURDATE() OR `date_approved` = CURDATE() OR `date_release` = CURDATE() OR `date_start` = CURDATE();", con)
            loanAppCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        ' Query for loan_collection
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM `loan_collection` WHERE `date_paid` = CURDATE();", con)
            loanCollectionCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM `sharecap` WHERE `date_transac` = CURDATE();", con)
            sharecapcount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using

        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM `savings` WHERE `date_transac` = CURDATE();", con)
            savingscount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        ' Combine counts
        totalCount = loanAppCount + loanCollectionCount + sharecapcount + savingscount
        lbl_loantranscount.Text = loanAppCount + loanCollectionCount
        lbl_savingstranscount.Text = savingscount
        lbl_sharetranscount.Text = sharecapcount
        ' Return total count as string
        Return totalCount.ToString()
    End Function



    Private Sub GunaChart1_Load(sender As Object, e As EventArgs) Handles GunaChart1.Load
        Try
            Dim pointcollect As New Guna.Charts.WinForms.ColorCollection()
            Dim pointrelease As New Guna.Charts.WinForms.ColorCollection()
            Dim pointapp As New Guna.Charts.WinForms.ColorCollection()
            pointcollect.Add(System.Drawing.Color.Green)
            pointrelease.Add(System.Drawing.Color.Red)
            pointapp.Add(System.Drawing.Color.Blue)

            con.Close()
            con.Open()




            Dim app As New GunaLineDataset() ' Initialize the dataset
            app.Label = "Total"
            app.PointRadius = 2
            app.PointFillColors = pointapp
            app.PointBorderColors = pointapp
            app.FillColor = Color.Blue
            ' Query for loan_app


            Using cmd As New MySqlCommand("SELECT 
    CONCAT(YEAR(date_column), '-', LPAD(MONTH(date_column), 2, '0')) AS month,
    SUM(transaction_count) AS total_transactions
FROM (
    -- Transactions from loan_app
    SELECT 
        date_apply AS date_column, COUNT(*) AS transaction_count
    FROM loan_app
    WHERE date_apply IS NOT NULL
    GROUP BY YEAR(date_apply), MONTH(date_apply)
    
    UNION ALL
    
    SELECT 
        date_approved AS date_column, COUNT(*) AS transaction_count
    FROM loan_app
    WHERE date_approved IS NOT NULL
    GROUP BY YEAR(date_approved), MONTH(date_approved)
    
    UNION ALL
    
    SELECT 
        date_release AS date_column, COUNT(*) AS transaction_count
    FROM loan_app
    WHERE date_release IS NOT NULL
    GROUP BY YEAR(date_release), MONTH(date_release)
    
    UNION ALL
    
    -- Transactions from loan_collection
    SELECT 
        date_paid AS date_column, COUNT(*) AS transaction_count
    FROM loan_collection
    WHERE date_paid IS NOT NULL
    GROUP BY YEAR(date_paid), MONTH(date_paid)
) AS combined_data
GROUP BY YEAR(date_column), MONTH(date_column)
ORDER BY YEAR(date_column), MONTH(date_column);

", con)
                Using dr = cmd.ExecuteReader()
                    While dr.Read()
                        ' Convert date_apply to a formatted date and add the data points
                        Dim dateApply As String = DateTime.Parse(dr("month")).ToString("MMM")
                        Dim loanCount As Integer = dr.GetInt32("total_transactions")
                        app.DataPoints.Add(dateApply, loanCount)
                    End While
                End Using
            End Using


            con.Close()

            ' Add the dataset to the chart
            GunaChart1.Datasets.Clear()
            GunaChart1.Datasets.Add(app)

            GunaChart1.Update()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Function collectiontoday() As String
        Try
            Dim query As String = "SELECT IFNULL(SUM(ammortization + due_fines), 0) FROM loan_collection WHERE date_paid IS NOT NULL AND DATE(date_paid) = CURDATE()"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader

            If dr.Read() Then
                Dim totalCollection As Decimal = dr.GetDecimal(0)
                Return "Php " & totalCollection.ToString("N2")
            Else
                Return "Php 0.00"
            End If
        Catch ex As Exception
            Return "Unable to load data"
        Finally
            If dr IsNot Nothing Then dr.Close()
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function


    Private Function releasedtoday() As String
        Try
            Dim query As String = "SELECT IFNULL(SUM(amount - (service_fee + insurance_fee)), 0) " &
                              "FROM loan_app WHERE date_release IS NOT NULL AND DATE(date_release) = CURDATE()"

            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader

            If dr.Read() Then
                Dim totalReleased As Decimal = dr.GetDecimal(0)
                Return "Php " & totalReleased.ToString("N2")
            Else
                Return "Php 0.00"
            End If
        Catch ex As Exception
            Return "Unable to load data."
        Finally
            If dr IsNot Nothing Then dr.Close()
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel10.Paint

    End Sub

    Private Sub Guna2Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel7.Paint

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub

    Private Sub Guna2Panel3_Click(sender As Object, e As EventArgs) Handles Guna2Panel3.Click
        If check_access_user("admin") = True Then
            Guna2Panel3.ContextMenuStrip.Show(Guna2Panel3, 0, Guna2Panel3.Height)

        End If
    End Sub

    Private Sub WeightedAverageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeightedAverageToolStripMenuItem.Click
        display_formsub(weight_ave, "Weighted Average")
    End Sub

    Private Sub QuarterlyRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuarterlyRateToolStripMenuItem.Click
        display_formsub(quarter_rate, "Quarterly rate")
    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub

    Private Sub Guna2Panel4_Click(sender As Object, e As EventArgs) Handles Guna2Panel4.Click
        If check_access_user("admin") = True Then
            display_formsub(transact_today, "Transaction Summary")

        End If
    End Sub

    Private Sub btn_totalfunds_Click(sender As Object, e As EventArgs) Handles btn_totalfunds.Click
        loaddata()
    End Sub
End Class