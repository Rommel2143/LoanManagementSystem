Imports MySql.Data.MySqlClient
Public Class member_accounts

    Public Sub LoadData()

        Dim query As String = "SELECT  account_no, CONCAT(lastname, ', ', firstname, ' ', middlename, ' (',account_no,')') AS Member,  `birthdate`,TIMESTAMPDIFF(Year, birthdate, CURDATE()) AS Age, `civilstatus`, `sharecap`, `savings` FROM `member_profile`"

        Using command As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind the DataTable to datagrid1
            datagrid1.DataSource = table
        End Using

        ' Check if the "Edit" column already exists to avoid duplication
        If datagrid1.Columns("Edit") Is Nothing Then
            Dim editButton As New DataGridViewImageColumn()
            editButton.Name = "Edit"
            editButton.HeaderText = "Action"

            editButton.ImageLayout = DataGridViewImageCellLayout.Zoom ' Optional: Adjust the image layout

            ' Add the column to the DataGridView
            datagrid1.Columns.Add(editButton)
            datagrid1.Columns("Edit").DefaultCellStyle.Padding = New Padding(10)
            datagrid1.Columns("Edit").Width = 60
            datagrid1.Columns(0).Visible = False
        End If

    End Sub

    Private Sub datagrid1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles datagrid1.CellPainting
        ' Check if the current cell is in the "Edit" column
        If e.ColumnIndex = datagrid1.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            ' Get the icon (image) from your resources
            Dim icon As Image = My.Resources.info

            ' Define the icon size and calculate position to center the image
            Dim iconSize As New Size(25, 25) ' Adjust the size as needed
            Dim iconX As Integer = e.CellBounds.Left + (e.CellBounds.Width - iconSize.Width) \ 2
            Dim iconY As Integer = e.CellBounds.Top + (e.CellBounds.Height - iconSize.Height) \ 2

            ' Draw the icon in the calculated position
            e.Graphics.DrawImage(icon, New Rectangle(iconX, iconY, iconSize.Width, iconSize.Height))

            ' Prevent default painting to avoid overriding the icon
            e.Handled = True
        End If
    End Sub
    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick
        ' Check if the click was in the "Edit" column and not the header row
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = datagrid1.Columns("Edit").Index Then
            ' Get the account_no of the clicked row
            Dim accountNo As String = datagrid1.Rows(e.RowIndex).Cells("account_no").Value.ToString()
            Dim member As String = datagrid1.Rows(e.RowIndex).Cells("Member").Value.ToString()

            Dim options As New member_options

            options.load_data(accountNo, member)
            options.ShowDialog()

        End If
    End Sub

End Class