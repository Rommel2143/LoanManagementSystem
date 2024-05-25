Imports MySql.Data.MySqlClient

Public Class accounts
    Private Sub accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reloadgrid()
    End Sub




    Private Sub reloadgrid()
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT  `id`,
                                                            `fullname`,
                                                            `dob`,
                                                            `placeofbirth`, 
                                                            `civilstatus`,
                                                            `gender`,
                                                            `idtype`,
                                                            `valididno`,
                                                            `currentaddress`,
                                                            `phone`,
                                                            `email`,
                                                            `incomesource`,
                                                            `monthlyincome`,
                                                            `emergencyname`,
                                                            `emergencyrelation`,
                                                            `emergencyphone`

                                                            FROM `account_masterlist`
                                                            ORDER BY `fullname`", con)
            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()

        End Try
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub
End Class