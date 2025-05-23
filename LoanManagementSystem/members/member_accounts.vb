﻿Imports MySql.Data.MySqlClient
Public Class member_accounts

    Public Sub LoadData()
        Try
            reload("SELECT mp.account_no, CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename, ' (', mp.account_no, ')') AS Member, DATE_FORMAT(mp.birthdate, '%M %d, %Y') AS Birthday, TIMESTAMPDIFF(Year, mp.birthdate, CURDATE()) AS Age, mp.contact1 AS Primary_Contact, mp.email AS Email FROM `member_profile` mp", datagrid1)

            ' Add handler for DataBindingComplete to hide the account_no column
            AddHandler datagrid1.DataBindingComplete, AddressOf OnDataBindingComplete

        Catch ex As Exception
            display_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub OnDataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        ' Hide the account_no column after data binding is complete
        datagrid1.Columns("account_no").Visible = False
    End Sub




    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try

            If txt_search.Text = "" Then
                LoadData()
            Else
                con.Close()
                con.Open()
                Dim query As String = "SELECT mp.account_no, CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename, ' (', mp.account_no, ')') AS Member, DATE_FORMAT(mp.birthdate, '%M %d, %Y') AS Birthday, TIMESTAMPDIFF(Year, mp.birthdate, CURDATE()) AS Age, mp.contact1 AS Primary_Contact, mp.email AS Email FROM `member_profile` mp
                                WHERE account_no REGEXP '" & txt_search.Text & "' or lastname REGEXP '" & txt_search.Text & "'"

                Using command As New MySqlCommand(query, con)
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Bind the DataTable to datagrid1
                    datagrid1.DataSource = table
                    datagrid1.Columns(0).Visible = False
                End Using
            End If

        Catch ex As Exception
            display_error("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub datagrid1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagrid1.CellMouseClick
        Try


            ' Get the account_no of the clicked row
            Dim accountNo As String = datagrid1.Rows(e.RowIndex).Cells("account_no").Value.ToString()
            Dim member As String = datagrid1.Rows(e.RowIndex).Cells("Member").Value.ToString()

            Dim options As New member_options

            options.load_data(accountNo, member)
            options.Show()


        Catch ex As Exception

        End Try
    End Sub



    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_addmember.Click
        If check_access_user("add_member") = True Then
            display_formsub(New add_member, "Add Member")
        End If

    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub
End Class