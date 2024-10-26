Imports MySql.Data.MySqlClient
Imports System.IO
Public Class add_member
    Private Sub add_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Create and configure OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" ' Filter to only allow image files
        openFileDialog.Title = "Select an Image"

        ' Show the dialog and if the user selects a file, display it in the PictureBox
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into the PictureBox
            pic_user.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub pic_user_Click(sender As Object, e As EventArgs) Handles pic_user.Click

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            con.Close()
            con.Open()

            ' Prepare the query to include the image parameter
            Dim query As String = "INSERT INTO `member_profile` ( `account_no`, `firstname`, `middlename`, `lastname`, `birthdate`, `civilstatus`, `gender`, `place_birth`, `present_address`, `contact1`, `contact2`, `emp_status`, `idtype`, `idtype_no`, `image`, `status`) 
                               VALUES (@account_no, @firstname, @middlename, @lastname, @birthdate, @civilstatus, @gender, @place_birth, @present_address, @contact1, @contact2, @emp_status, @idtype, @idtype_no, @image, 1)"

            Dim insertaccount As New MySqlCommand(query, con)

            ' Add the parameters for the other fields
            insertaccount.Parameters.AddWithValue("@account_no", txt_account.Text)
            insertaccount.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            insertaccount.Parameters.AddWithValue("@middlename", txt_midlename.Text)
            insertaccount.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            insertaccount.Parameters.AddWithValue("@birthdate", dtpicker1.Value.ToString("yyyy-MM-dd"))
            insertaccount.Parameters.AddWithValue("@civilstatus", cmb_civil.Text.Substring(0, 1))
            insertaccount.Parameters.AddWithValue("@gender", cmb_gender.Text.Substring(0, 1))
            insertaccount.Parameters.AddWithValue("@place_birth", txt_birthplace.Text)
            insertaccount.Parameters.AddWithValue("@present_address", txt_presentadd.Text)
            insertaccount.Parameters.AddWithValue("@contact1", txt_contact1.Text)
            insertaccount.Parameters.AddWithValue("@contact2", txt_contact2.Text)
            insertaccount.Parameters.AddWithValue("@emp_status", cmb_empstatus.Text)
            insertaccount.Parameters.AddWithValue("@idtype", cmb_idtype.Text)
            insertaccount.Parameters.AddWithValue("@idtype_no", txt_id.Text)

            ' Convert the image in the PictureBox to a byte array and add it as a parameter
            insertaccount.Parameters.AddWithValue("@image", ImageToByteArray(pic_user.Image))

            ' Execute the query
            insertaccount.ExecuteNonQuery()

        Catch ex As MySqlException When ex.Number = 1062
            ' Handle duplicate entry error
            display_error("Duplicate entry detected: " & ex.Message)
        Catch ex As Exception
            ' Handle other errors
            display_error(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Method to convert Image to Byte Array
    Private Function ImageToByteArray(image As Image) As Byte()
        If image Is Nothing Then Return Nothing
        Using ms As New MemoryStream()
            image.Save(ms, Imaging.ImageFormat.Jpeg) ' You can change the format if needed
            Return ms.ToArray()
        End Using
    End Function


    Private Sub txt_account_TextChanged(sender As Object, e As EventArgs) Handles txt_account.TextChanged
        lbl_account.Text = txt_account.Text
    End Sub

    Private Sub txt_firstname_TextChanged(sender As Object, e As EventArgs) Handles txt_firstname.TextChanged, txt_lastname.TextChanged, txt_midlename.TextChanged
        lbl_fullname.Text = txt_lastname.Text & ", " & txt_firstname.Text & " " & txt_midlename.Text
    End Sub

    Private Sub dtpicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker1.ValueChanged
        lbl_birthdate.Text = dtpicker1.Value.ToString("MMMM dd, yyyy")
    End Sub

    Private Sub cmb_civil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_civil.SelectedIndexChanged
        lbl_civil.Text = cmb_civil.Text
    End Sub

    Private Sub cmb_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_gender.SelectedIndexChanged
        lbl_gender.Text = cmb_gender.Text
    End Sub

    Private Sub txt_birthplace_TextChanged(sender As Object, e As EventArgs) Handles txt_birthplace.TextChanged
        lbl_birthplace.Text = txt_birthplace.Text
    End Sub

    Private Sub txt_presentadd_TextChanged(sender As Object, e As EventArgs) Handles txt_presentadd.TextChanged
        lbl_present.Text = txt_presentadd.Text
    End Sub

    Private Sub txt_contact1_TextChanged(sender As Object, e As EventArgs) Handles txt_contact1.TextChanged
        lbl_contact1.Text = txt_contact1.Text

    End Sub

    Private Sub txt_contact2_TextChanged(sender As Object, e As EventArgs) Handles txt_contact2.TextChanged
        lbl_contact2.Text = txt_contact2.Text
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged
        lbl_email.Text = txt_email.Text
    End Sub

    Private Sub cmb_empstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_empstatus.SelectedIndexChanged
        lbl_employ.Text = cmb_empstatus.Text
    End Sub

    Private Sub cmb_idtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_idtype.SelectedIndexChanged
        lbl_idtype.Text = cmb_idtype.Text
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged
        lbl_id.Text = txt_id.Text
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked Then
            txt_presentadd.Text = txt_birthplace.Text
        Else
            txt_presentadd.Clear()
        End If
    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class