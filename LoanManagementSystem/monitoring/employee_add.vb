Imports MySql.Data.MySqlClient
Imports System.IO

Public Class employee_add
    Dim civil_status As String
    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pic1.Image = Image.FromFile(openFileDialog.FileName)
            pic1.Tag = openFileDialog.FileName ' Store the file path in the tag for later use
        End If
    End Sub

    ' Method to save employee data, including the image, to the database
    Private Sub SaveEmployee()

        Try
            con.Close()
            con.Open()

            ' Convert the image to a byte array
            Dim imgData As Byte() = Nothing
            If pic1.Tag IsNot Nothing Then
                Using fs As New FileStream(pic1.Tag.ToString(), FileMode.Open, FileAccess.Read)
                    Using br As New BinaryReader(fs)
                        imgData = br.ReadBytes(CInt(fs.Length))
                    End Using
                End Using
            End If

            ' Insert employee data into the database
            Dim cmd As New MySqlCommand("INSERT INTO member_profile (account_no, firstname, middlename, lastname, image, birthdate, civilstatus) VALUES (@accountno, @first, @middle, @last, @image,@bithdate, @civil)", con)
            cmd.Parameters.AddWithValue("@accountno", txt_accountno.Text)
            cmd.Parameters.AddWithValue("@first", txt_first.Text)
            cmd.Parameters.AddWithValue("@middle", txt_middle.Text)
            cmd.Parameters.AddWithValue("@last", txt_last.Text)
            cmd.Parameters.AddWithValue("@image", imgData)
            cmd.Parameters.AddWithValue("@bithdate", dtpicker1.Value.ToString("yyy-MM-dd"))
            cmd.Parameters.AddWithValue("@civil", civil_status)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Employee added successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SaveEmployee()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_civil.SelectedIndexChanged
        Select Case cmb_civil.Text
            Case "Married"
                civil_status = "M"
            Case "Single"
                civil_status = "S"
            Case "Divorced"
                civil_status = "D"
            Case "Widowed"
                civil_status = "W"
            Case "Others"
                civil_status = "O"
        End Select
    End Sub

    Private Sub employee_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic1.Image = My.Resources.addimage
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged

    End Sub
End Class
