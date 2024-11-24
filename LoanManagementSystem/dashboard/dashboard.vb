Imports MySql.Data.MySqlClient
Imports Guna.Charts.WinForms
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_day.Text = Date.Now.ToString("dd")
        lbl_month.Text = Date.Now.ToString("MMMM")
        lbl_year.Text = Date.Now.ToString("yyyy")
        lbl_membercount.Text = membercount()
        lbl_active.Text = activecount()
        lbl_activeloan.Text = activeloan()
        lbl_pendingloan.Text = pendingloan()
        lbl_sharecap.Text = sharecap()
        lbl_sharecount.Text = sharecount()
        lbl_transaccount.Text = transac_count()
        lbl_collecttotal.Text = collectiontoday()
        lbl_releasedtotal.Text = releasedtoday()

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

    Private Function sharecap() As String
        Try


            Dim query As String = " SELECT 
            SUM(CASE WHEN `status` = 'ID' or status='CM' or status='CD' or status='ISC' or status='IPR' THEN `amount` ELSE 0 END) - 
            SUM(CASE WHEN `status` = 'DM' or status = 'CA' THEN `amount` ELSE 0 END) AS balance
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
            app.Label = "Applied" ' Set the label for the dataset
            app.PointRadius = 2
            app.PointFillColors = pointapp
            app.PointBorderColors = pointapp
            app.FillColor = Color.Blue
            ' Query for loan_app
            Using cmd As New MySqlCommand("SELECT `date_apply`, COUNT(*) AS `loan_count` FROM `loan_app` WHERE date_apply IS NOT NULL AND  YEAR(`date_apply`) = YEAR(CURDATE()) GROUP BY MONTH(date_apply) ORDER BY date_apply DESC", con)
                Using dr = cmd.ExecuteReader()
                    While dr.Read()
                        ' Convert date_apply to a formatted date and add the data points
                        Dim dateApply As String = DateTime.Parse(dr("date_apply")).ToString("MMM")
                        Dim loanCount As Integer = dr.GetInt32("loan_count")
                        app.DataPoints.Add(dateApply, loanCount)
                    End While
                End Using
            End Using




            Dim release As New GunaLineDataset() ' Initialize the dataset
            release.Label = "Released" ' Set the label for the dataset
            release.PointRadius = 2
            release.PointFillColors = pointrelease
            release.PointBorderColors = pointrelease
            release.FillColor = Color.Red
            ' Query for loan_app
            Using cmdrelease As New MySqlCommand("SELECT `date_release`, COUNT(*) AS `loan_count` FROM `loan_app` WHERE date_release IS NOT NULL AND  YEAR(`date_release`) = YEAR(CURDATE()) GROUP BY MONTH(date_release) ORDER BY date_release DESC", con)
                Using dr = cmdrelease.ExecuteReader()
                    While dr.Read()
                        ' Convert date_apply to a formatted date and add the data points
                        Dim dateApply As String = DateTime.Parse(dr("date_release")).ToString("MMM")
                        Dim loanCount As Integer = dr.GetInt32("loan_count")
                        release.DataPoints.Add(dateApply, loanCount)
                    End While
                End Using
            End Using


            Dim collection As New GunaLineDataset()
            collection.Label = "Collected"
            collection.PointRadius = 2
            collection.PointFillColors = pointcollect
            collection.PointBorderColors = pointcollect
            collection.FillColor = Color.Green

            ' Query for loan_collection
            Using collect As New MySqlCommand("SELECT date_paid, COUNT(*) AS totalcount FROM `loan_collection` WHERE date_paid IS NOT NULL AND YEAR(`date_paid`) = YEAR(CURDATE()) GROUP BY MONTH(date_paid) ORDER BY date_paid DESC", con)
                Using dr = collect.ExecuteReader()
                    While dr.Read()

                        Dim monthPaid As String = DateTime.Parse(dr("date_paid")).ToString("MMM")
                        Dim loanCount As Integer = dr.GetInt32("totalcount")

                        ' Add data points to the dataset
                        collection.DataPoints.Add(monthPaid, loanCount)
                    End While
                End Using
            End Using
            con.Close()

            ' Add the dataset to the chart
            GunaChart1.Datasets.Clear()
            GunaChart1.Datasets.Add(app)
            GunaChart1.Datasets.Add(release)
            GunaChart1.Datasets.Add(collection)

            GunaChart1.Update()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Function collectiontoday() As String
        Try


            Dim query As String = "SELECT SUM(ammortization + due_fines) FROM loan_collection WHERE date_paid IS NOT NULL and date_paid=CURDATE()"
            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return "Php " & dr.GetDecimal(0).ToString("N2")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function

    Private Function releasedtoday() As String
        Try


            Dim query As String = "SELECT SUM(amount - (service_fee + insurance_fee)) FROM loan_app WHERE date_release IS NOT NULL and date_release=CURDATE()"
            con.Close()
            con.Open()
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            If dr.Read = True Then


                Return "Php " & dr.GetDecimal(0).ToString("N2")
            Else
                Return "Unable to load data."
            End If
        Catch ex As Exception
            Return "Unable to load data."

        End Try
    End Function

    Private Sub Chart1_Click(sender As Object, e As EventArgs)

    End Sub

End Class