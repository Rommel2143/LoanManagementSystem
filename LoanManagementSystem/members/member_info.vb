Imports MySql.Data.MySqlClient
Imports System.IO
Public Class member_info


    Public Sub member_load(accountno As String)
        Try
            con.Close()
            con.Open()

            ' Prepare the query to retrieve member details based on account_no
            Dim query As String = "SELECT `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `gender`, `place_birth`, `present_address`, `contact1`, `contact2`,`email`, `emp_status`, `idtype`, `idtype_no`, `image`, `status` FROM `member_profile` WHERE `account_no` = @accountno"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@accountno", accountno)

            ' Execute the command and retrieve the data
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then

                    lbl_account.Text = dr.GetString("account_no")
                    txt_firstname.Text = dr.GetString("firstname")
                    txt_midlename.Text = dr.GetString("middlename")
                    txt_lastname.Text = dr.GetString("lastname")
                    dtpicker1.Value = dr.GetDateTime("birthdate")

                    Select Case dr.GetString("civilstatus")
                        Case "S"
                            cmb_civil.SelectedItem = "Single"
                        Case "M"
                            cmb_civil.SelectedItem = "Married"
                        Case "D"
                            cmb_civil.SelectedItem = "Divorced"
                        Case "W"
                            cmb_civil.SelectedItem = "Widowed"
                        Case "O"
                            cmb_civil.SelectedItem = "Other"
                    End Select

                    Select Case dr.GetString("gender")
                        Case "M"
                            cmb_gender.SelectedItem = "Male"
                        Case "F"
                            cmb_gender.SelectedItem = "Female"
                        Case "O"
                            cmb_gender.SelectedItem = "Other"
                    End Select

                    txt_birthplace.Text = dr.GetString("place_birth")
                    txt_presentadd.Text = dr.GetString("present_address")
                    txt_contact1.Text = dr.GetString("contact1")
                    txt_contact2.Text = dr.GetString("contact2")
                    txt_email.Text = dr.GetString("email")

                    Select Case dr.GetString("emp_status")
                        Case "E"
                            cmb_empstatus.SelectedItem = "Employed"
                        Case "S"
                            cmb_empstatus.SelectedItem = "Self-Employed"
                        Case "U"
                            cmb_empstatus.SelectedItem = "Unemployed"
                        Case "R"
                            cmb_empstatus.SelectedItem = "Retired"
                        Case "F"
                            cmb_empstatus.SelectedItem = "Freelancer"
                        Case "O"
                            cmb_empstatus.SelectedItem = "Other"
                    End Select

                    Select Case dr.GetString("idtype")
                        Case "T"
                            cmb_idtype.SelectedItem = "TIN"
                        Case "D"
                            cmb_idtype.SelectedItem = "Driver's License"
                        Case "N"
                            cmb_idtype.SelectedItem = "National ID"
                        Case "S"
                            cmb_idtype.SelectedItem = "SSS"
                        Case "U"
                            cmb_idtype.SelectedItem = "UMID"
                        Case "P"
                            cmb_idtype.SelectedItem = "Passport"
                        Case "O"
                            cmb_idtype.SelectedItem = "Other"
                    End Select

                    txt_id.Text = dr.GetString("idtype_no")

                    'for image
                    ' Check if image column is not DBNull before attempting to read
                    If Not IsDBNull(dr("image")) Then
                        Dim imageData As Byte() = CType(dr("image"), Byte())

                        ' Convert the byte array back to an image
                        Using ms As New MemoryStream(imageData)
                            pic_user.Image = Image.FromStream(ms)
                        End Using
                    Else
                        ' Set default image if no image found in the database
                        pic_user.Image = My.Resources.DefaultProfileImage
                    End If







                Else
                    display_error("Account not found.")
                End If

            End Using

        Catch ex As Exception
            display_error("Oops! Something Went Wrong")
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub LoadImage(accountNo As String)

    End Sub

    Private Sub pic_user_Click(sender As Object, e As EventArgs) Handles pic_user.Click

    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged

    End Sub

    Private Sub member_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class