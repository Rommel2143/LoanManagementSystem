Imports MySql.Data.MySqlClient
Imports System.IO
Public Class member_options
    Dim accountno As String

    Private Sub member_options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub load_data(acc As String, member As String)
        accountno = acc
        lbl_fullname.Text = member
        Try
            con.Close()
            con.Open()

            ' Prepare the query to retrieve member details based on account_no
            Dim query As String = "SELECT `image` FROM `member_profile` WHERE `account_no` = @accountno"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@accountno", accountno)

            ' Execute the command and retrieve the data
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If dr.Read() Then
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

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Dim sc As New sharecap_collection
        sc.loaddata(accountno, lbl_fullname.Text)
        display_formsub(sc, "Share Capital")

        Me.Close()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Dim sav As New savings
        sav.loaddata(accountno, lbl_fullname.Text)
        display_formsub(sav, "Savings")
        Me.Close()
    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Dim member As New member_info
        member.member_load(accountno)
        display_formsub(member, "Member Information")
        Me.Close()
    End Sub
End Class