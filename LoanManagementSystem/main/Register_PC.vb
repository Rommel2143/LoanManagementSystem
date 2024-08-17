Imports MySql.Data.MySqlClient
Public Class Register_PC
    Private Sub Register_PC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpcname.Text = PCname
        txtpcmac.Text = PCmac
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If txtuser.Text = "PTRCI" And txtpassword.Text = "redhorsE" Then
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("INSERT INTO `computer_location`(`PCname`, `PCmac`) VALUES ('" & PCname & "','" & PCmac & "')", con)
            dr = cmdselect.ExecuteReader
            Dim result As DialogResult = MessageBox.Show("Machine Verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If result = DialogResult.OK Then
                With Login
                    .Refresh()
                    .TopLevel = False
                    lms_mainframe.Panel1.Controls.Add(Login)

                    .txt_user.Enabled = True
                    .txt_user.Focus()
                    .BringToFront()
                    .Show()

                End With
            End If
        Else
            MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmblocation_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class