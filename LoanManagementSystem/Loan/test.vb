Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.IO

Public Class test

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMemberProfiles()
    End Sub

    Private Sub LoadMemberProfiles()
        Try
            con.Open()
            Dim query As String = "SELECT `id`, `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `sharecap`, `savings`, `image` FROM `member_profile`   ORDER BY firstname"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Create a new Guna2Panel for each member
                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = FlowLayoutPanel1.Width - 20
                memberPanel.Height = 140
                memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                memberPanel.BorderRadius = 10
                memberPanel.Margin = New Padding(10)

                ' Debug: Check if the image data is not null
                Dim profileImage As Image = Nothing
                If Not IsDBNull(reader("image")) Then
                    Dim imageData As Byte() = CType(reader("image"), Byte())

                    ' Debug: Check the length of the image data
                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Try
                            ' Specify the directory and file path
                            Dim directoryPath As String = "C:\temp"
                            Dim filePath As String = Path.Combine(directoryPath, "output_image.jpg")

                            ' Create the directory if it doesn't exist
                            If Not Directory.Exists(directoryPath) Then
                                Directory.CreateDirectory(directoryPath)
                            End If

                            ' Save the image data to the file for debugging
                            File.WriteAllBytes(filePath, imageData)

                            ' Convert byte array to image
                            Using ms As New MemoryStream(imageData)
                                profileImage = Image.FromStream(ms)
                            End Using
                        Catch ex As Exception
                            ' Handle and log the detailed exception
                            '  MessageBox.Show("Failed to load image: " & ex.Message)
                            profileImage = My.Resources.DefaultProfileImage ' Use a default image
                        End Try
                    Else
                        'Set a default image if the image data Is empty Or invalid
                        profileImage = My.Resources.DefaultProfileImage
                    End If
                Else
                    ' Set a default image if the image column is NULL
                    profileImage = My.Resources.DefaultProfileImage
                End If

                ' PictureBox for profile image
                Dim pictureBox As New PictureBox()
                pictureBox.Width = 60
                pictureBox.Height = 60
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                pictureBox.Image = profileImage
                pictureBox.Location = New Point(10, 10)

                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 12)
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text =
                                   $"Name: {reader("firstname")} {reader("middlename")} {reader("lastname")}     Share Capital: {reader("sharecap")} Savings: {reader("savings")}" & Environment.NewLine &
                                   $"Account No: {reader("account_no")}" & Environment.NewLine &
                                   $"Birthdate: {Convert.ToDateTime(reader("birthdate")).ToString("MM/dd/yyyy")}" & Environment.NewLine &
                                   $"Civil Status: {reader("civilstatus")}"


                memberLabel.Location = New Point(80, 10)



                ' Button for edit
                Dim editbtn As New Guna2ImageButton() With {
                                .Text = "Edit",
                                .Image = My.Resources.edit,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(30, 30),
                                .Dock = DockStyle.Right,
                                .Tag = reader("account_no")}



                ' Add PictureBox and Label to the Panel
                memberPanel.Controls.Add(pictureBox)
                memberPanel.Controls.Add(memberLabel)
                memberPanel.Controls.Add(editbtn)
                ' Add Panel to the FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(memberPanel)

                ' Optional hover effect
                AddHandler memberPanel.MouseEnter, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(240, 240, 240)
                                                       memberLabel.ForeColor = Color.FromArgb(30, 30, 30)

                                                   End Sub

                AddHandler memberPanel.MouseLeave, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                                                       memberLabel.ForeColor = Color.FromArgb(50, 50, 50)

                                                   End Sub
                AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                              Dim btn As Guna2ImageButton = CType(senderObj, Guna2ImageButton)
                                              Dim accountNo As String = CType(btn.Tag, String)
                                              MessageBox.Show($"Account No: {accountNo}")
                                          End Sub
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally

            con.Close()

        End Try
    End Sub


    Private Sub Searchmembers()
        Try
            FlowLayoutPanel1.SuspendLayout()
            FlowLayoutPanel1.Controls.Clear()

            con.Open()
            Dim query As String = "SELECT `id`, `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `sharecap`, `savings`, `image` FROM `member_profile` WHERE account_no REGEXP '" & txt_search.Text & "' or firstname REGEXP '" & txt_search.Text & "' or lastname REGEXP '" & txt_search.Text & "'
                                    ORDER BY firstname"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Create a new Guna2Panel for each member
                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = FlowLayoutPanel1.Width - 20
                memberPanel.Height = 140
                memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                memberPanel.BorderRadius = 10
                memberPanel.Margin = New Padding(10)

                ' Debug: Check if the image data is not null
                Dim profileImage As Image = Nothing
                If Not IsDBNull(reader("image")) Then
                    Dim imageData As Byte() = CType(reader("image"), Byte())

                    ' Debug: Check the length of the image data
                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Try
                            ' Specify the directory and file path
                            Dim directoryPath As String = "C:\temp"
                            Dim filePath As String = Path.Combine(directoryPath, "output_image.jpg")

                            ' Create the directory if it doesn't exist
                            If Not Directory.Exists(directoryPath) Then
                                Directory.CreateDirectory(directoryPath)
                            End If

                            ' Save the image data to the file for debugging
                            File.WriteAllBytes(filePath, imageData)

                            ' Convert byte array to image
                            Using ms As New MemoryStream(imageData)
                                profileImage = Image.FromStream(ms)
                            End Using
                        Catch ex As Exception
                            ' Handle and log the detailed exception
                            '  MessageBox.Show("Failed to load image: " & ex.Message)
                            profileImage = My.Resources.DefaultProfileImage ' Use a default image
                        End Try
                    Else
                        'Set a default image if the image data Is empty Or invalid
                        profileImage = My.Resources.DefaultProfileImage
                    End If
                Else
                    ' Set a default image if the image column is NULL
                    profileImage = My.Resources.DefaultProfileImage
                End If

                ' PictureBox for profile image
                Dim pictureBox As New PictureBox()
                pictureBox.Width = 60
                pictureBox.Height = 60
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                pictureBox.Image = profileImage
                pictureBox.Location = New Point(10, 10)

                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 12)
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text =
                                   $"Name: {reader("firstname")} {reader("middlename")} {reader("lastname")}     Share Capital: {reader("sharecap")} Savings: {reader("savings")}" & Environment.NewLine &
                                   $"Account No: {reader("account_no")}" & Environment.NewLine &
                                   $"Birthdate: {Convert.ToDateTime(reader("birthdate")).ToString("MM/dd/yyyy")}" & Environment.NewLine &
                                   $"Civil Status: {reader("civilstatus")}"


                memberLabel.Location = New Point(80, 10)



                ' Button for edit
                Dim editbtn As New Guna2ImageButton() With {
                                .Text = "Edit",
                                .Image = My.Resources.edit,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(30, 30),
                                .Dock = DockStyle.Right,
                                .Tag = reader("account_no")}



                ' Add PictureBox and Label to the Panel
                memberPanel.Controls.Add(pictureBox)
                memberPanel.Controls.Add(memberLabel)
                memberPanel.Controls.Add(editbtn)
                ' Add Panel to the FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(memberPanel)

                ' Optional hover effect
                AddHandler memberPanel.MouseEnter, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(240, 240, 240)
                                                       memberLabel.ForeColor = Color.FromArgb(30, 30, 30)

                                                   End Sub

                AddHandler memberPanel.MouseLeave, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                                                       memberLabel.ForeColor = Color.FromArgb(50, 50, 50)

                                                   End Sub
                AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                              Dim btn As Guna2ImageButton = CType(senderObj, Guna2ImageButton)
                                              Dim accountNo As String = CType(btn.Tag, String)
                                              MessageBox.Show($"Account No: {accountNo}")
                                          End Sub
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            FlowLayoutPanel1.ResumeLayout()
            con.Close()

        End Try
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then

            LoadMemberProfiles()
        Else

            Searchmembers()

        End If
    End Sub
End Class
