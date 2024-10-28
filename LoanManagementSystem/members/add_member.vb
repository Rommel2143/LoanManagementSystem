Imports MySql.Data.MySqlClient
Imports System.IO

Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class add_member
    Private videoSource As VideoCaptureDevice
    Private isCameraOpen As Boolean = False
    Private iswbackground As Boolean = True
    Private toolTip As New ToolTip()
    Private Sub add_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolTip.SetToolTip(open_cam, "Camera")
        toolTip.SetToolTip(upload_pic, "Upload from File")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles upload_pic.Click
        ' Create and configure OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" ' Filter to only allow image files
        openFileDialog.Title = "Select an Image"

        ' Show the dialog and if the user selects a file, display it in the PictureBox
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into the PictureBox

            Select Case iswbackground
                Case True
                    ChangeBackgroundToWhite(Image.FromFile(openFileDialog.FileName))
                Case False
                    pic_user.Image = Image.FromFile(openFileDialog.FileName)
            End Select



        End If
    End Sub

    Private Sub pic_user_Click(sender As Object, e As EventArgs) Handles pic_user.Click

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            Dim missingFields As New List(Of String)

            If lbl_account.Text = "---" Then missingFields.Add("Account Number")
            If lbl_birthdate.Text = "---" Then missingFields.Add("Birthdate")
            If lbl_fullname.Text = "---" Then missingFields.Add("Full Name")
            If lbl_civil.Text = "---" Then missingFields.Add("Civil Status")
            If lbl_gender.Text = "---" Then missingFields.Add("Gender")
            If lbl_contact1.Text = "---" Then missingFields.Add("Contact 1")

            If missingFields.Count > 0 Then
                display_error("The following information is missing: " & String.Join(", ", missingFields) & ". Please review and complete all required fields.")
                Exit Sub
            End If
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
            lms_mainframe.message_success.Show("The new member has been added successfully.", "Account Created!")


        Catch ex As MySqlException When ex.Number = 1062
            ' Handle duplicate entry error
            display_error("A record with this information already exists. No changes were made.")
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

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub



    Private Sub open_cam_Click(sender As Object, e As EventArgs) Handles open_cam.Click
        If Not isCameraOpen Then
            Try
                ' Select the video device (camera)
                Dim videoDevices As New FilterInfoCollection(FilterCategory.VideoInputDevice)
                If videoDevices.Count = 0 Then
                    display_error("No camera detected. Please check your camera connection.")
                    Exit Sub
                End If

                ' Use the first available camera
                videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)

                ' Handle the NewFrame event to get the image from the camera
                AddHandler videoSource.NewFrame, AddressOf Video_NewFrame

                ' Start the video capture
                videoSource.Start()
                isCameraOpen = True
                open_cam.Image = My.Resources.lens

            Catch ex As Exception
                display_error("Error opening camera: " & ex.Message)
            End Try
        Else



            ' Capture the image and close the camera
            If pic_user.Image IsNot Nothing Then
                ' Create a new bitmap from the current image in the PictureBox
                Dim capturedImage As Bitmap = DirectCast(pic_user.Image.Clone(), Bitmap)

                Select Case iswbackground
                    Case True
                        ChangeBackgroundToWhite(capturedImage)
                    Case False
                        pic_user.Image = capturedImage

                End Select

                ' Display the captured image in the previously opened add_member form's pic_user PictureBox

                isCameraOpen = False
                open_cam.Image = My.Resources.camera
            Else
                display_error("No image available to capture.")
            End If

            ' Stop the camera
            If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
                videoSource.SignalToStop()
                videoSource.WaitForStop()
            End If


        End If
    End Sub
    Private Sub ChangeBackgroundToWhite(originalImage As Bitmap)
        Dim width As Integer = originalImage.Width
        Dim height As Integer = originalImage.Height
        Dim newImage As New Bitmap(width, height)

        For x As Integer = 0 To width - 1
            For y As Integer = 0 To height - 1
                Dim pixelColor As Color = originalImage.GetPixel(x, y)

                ' Assuming the background is a certain color (e.g., close to white)
                ' You can adjust the RGB values based on your background color
                If pixelColor.A > 0 AndAlso (pixelColor.R < 200 Or pixelColor.G < 200 Or pixelColor.B < 200) Then
                    ' If the pixel is not close to white, retain its color
                    newImage.SetPixel(x, y, pixelColor)
                Else
                    ' Change the background to white
                    newImage.SetPixel(x, y, Color.White)
                End If
            Next
        Next

        pic_user.Image = newImage
    End Sub
    Private Sub Video_NewFrame(sender As Object, eventArgs As NewFrameEventArgs)
        ' Capture the current frame from the camera
        Dim frame As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        ' Display the captured frame in pic_user PictureBox
        pic_user.Image = frame
    End Sub



    Private Sub Guna2CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles whiteb.CheckedChanged
        If whiteb.Checked = True Then
            iswbackground = True
        Else
            iswbackground = False
        End If
    End Sub

    Private Sub Guna2CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles Guna2CheckBox2.CheckedChanged
        If Guna2CheckBox2.Checked Then
            txt_presentadd.Text = txt_birthplace.Text
        Else
            txt_presentadd.Clear()
        End If
    End Sub

    Private Sub Guna2Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel12.Paint

    End Sub
End Class