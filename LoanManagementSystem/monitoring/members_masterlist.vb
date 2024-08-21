Imports MySql.Data.MySqlClient
Public Class members_masterlist
    Private Sub members_masterlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        datagrid1.RowTemplate.Height = 40
    End Sub
    Private Sub LoadData()

        Dim query As String = "SELECT `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `sharecap`, `savings` FROM `member_profile`"

        Using command As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind the DataTable to datagrid1
            datagrid1.DataSource = table
        End Using

        Dim editButton As New DataGridViewImageColumn()
        editButton.Name = "Edit"
        editButton.HeaderText = "Action"
        editButton.Image = My.Resources.edit ' Use the image from your resources
        editButton.ImageLayout = DataGridViewImageCellLayout.Zoom ' Optional: Adjust the image layout


        ' Add the columns to the DataGridView
        datagrid1.Columns.Add(editButton)
        datagrid1.Columns("Edit").DefaultCellStyle.Padding = New Padding(10)
    End Sub

    ' Handle the Edit button click event
    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        ' Check if the Edit button is clicked
        If e.ColumnIndex = datagrid1.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            Dim account_no As String = datagrid1.Rows(e.RowIndex).Cells("account_no").Value.ToString()
            MessageBox.Show("Edit button clicked for Account No: " & account_no)
            ' You can add more logic here to open the edit form or perform other actions.
        End If
    End Sub

End Class