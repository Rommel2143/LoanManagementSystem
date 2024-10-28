Imports MySql.Data.MySqlClient
Imports System.IO
Public Class member_info
    Private Sub member_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub member_load(accountno As String)
        Try
            con.Close()
            con.Open()

            ' Prepare the query to retrieve member details based on account_no
            Dim query As String = "SELECT `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `gender`, `place_birth`, `present_address`, `contact1`, `contact2`, `emp_status`, `idtype`, `idtype_no`, `image`, `status` FROM `member_profile` WHERE `account_no` = @accountno"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@accountno", accountno)

            ' Execute the command and retrieve the data
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then

                    lbl_account.Text = dr.GetString("account_no")


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
End Class