Imports MySql.Data.MySqlClient
Imports System.IO
Public Class member_info
    Private Sub member_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub member_load(accountno As String)
        LoadImage(accountno)


    End Sub




    Private Sub LoadImage(accountNo As String)
        Try
            con.Close()
            con.Open()

            ' Prepare the query to retrieve the image based on account_no
            Dim query As String = "SELECT `image` FROM `member_profile` WHERE `account_no` = @account_no"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@account_no", accountNo)

            ' Execute the command and retrieve the image
            Dim imageData As Byte() = CType(cmd.ExecuteScalar(), Byte())

            ' Check if the image data is not null
            If imageData IsNot Nothing Then
                ' Convert the byte array back to an image
                Using ms As New MemoryStream(imageData)
                    pic_user.Image = Image.FromStream(ms)
                End Using
            Else
                ' Set default image if no image found in the database
                pic_user.Image = Image.FromFile("resources.defaultprofileimage.png")
            End If

        Catch ex As Exception

            pic_user.Image = My.Resources.DefaultProfileImage
        Finally
            con.Close()
        End Try
    End Sub
End Class