Imports MySql.Data.MySqlClient
Imports System.IO

Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class member_info
    Private videoSource As VideoCaptureDevice
    Private isCameraOpen As Boolean = False
    Private iswbackground As Boolean = True
    Private ispicture As Boolean = False
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

                    Select Case dr.GetInt32("status")
                        Case 0
                            toogle_active.Checked = False
                            lbl_status.Text = "Inactive"
                        Case 1
                            toogle_active.Checked = True
                            lbl_status.Text = "Active"
                    End Select





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



    Private Sub member_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Try

            con.Close()
            con.Open()

            ' Update query to modify an existing record based on account_no
            Dim query As String = "UPDATE `member_profile` SET `firstname` = @firstname, `middlename` = @middlename, `lastname` = @lastname, 
                               `birthdate` = @birthdate, `civilstatus` = @civilstatus, `gender` = @gender, `place_birth` = @place_birth, 
                               `present_address` = @present_address, `contact1` = @contact1, `contact2` = @contact2, `email` = @email, 
                               `emp_status` = @emp_status, `idtype` = @idtype, `idtype_no` = @idtype_no, `image` = @image, `status` = @status
                               WHERE `account_no` = @account_no"

            Dim updateAccount As New MySqlCommand(query, con)

            ' Add parameters for the fields
            updateAccount.Parameters.AddWithValue("@account_no", lbl_account.Text)
            updateAccount.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            updateAccount.Parameters.AddWithValue("@middlename", txt_midlename.Text)
            updateAccount.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            updateAccount.Parameters.AddWithValue("@birthdate", dtpicker1.Value.ToString("yyyy-MM-dd"))
            updateAccount.Parameters.AddWithValue("@civilstatus", cmb_civil.Text.Substring(0, 1))
            updateAccount.Parameters.AddWithValue("@gender", cmb_gender.Text.Substring(0, 1))
            updateAccount.Parameters.AddWithValue("@place_birth", txt_birthplace.Text)
            updateAccount.Parameters.AddWithValue("@present_address", txt_presentadd.Text)
            updateAccount.Parameters.AddWithValue("@contact1", txt_contact1.Text)
            updateAccount.Parameters.AddWithValue("@contact2", txt_contact2.Text)
            updateAccount.Parameters.AddWithValue("@email", txt_email.Text)
            updateAccount.Parameters.AddWithValue("@emp_status", cmb_empstatus.Text.Substring(0, 1))
            updateAccount.Parameters.AddWithValue("@idtype", cmb_idtype.Text.Substring(0, 1))
            updateAccount.Parameters.AddWithValue("@idtype_no", txt_id.Text)

            If ispicture AndAlso pic_user.Image IsNot Nothing Then
                updateAccount.Parameters.AddWithValue("@image", ImageToByteArray(pic_user.Image))
            Else
                updateAccount.Parameters.AddWithValue("@image", DBNull.Value)
            End If

            Select Case toogle_active.Checked
                Case True
                    updateAccount.Parameters.AddWithValue("@status", 1)
                Case False
                    updateAccount.Parameters.AddWithValue("@status", 0)
            End Select


            ' Convert the image in the PictureBox to a byte array and add it as a parameter


            ' Execute the query
            updateAccount.ExecuteNonQuery()
            lms_mainframe.message_success.Show("The member information has been updated successfully.", "Account Updated!")

        Catch ex As MySqlException
            display_error("Oops! Something Went Wrong")
        Catch ex As Exception
            ' Handle other errors
            display_error(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function ImageToByteArray(image As Image) As Byte()
        If image Is Nothing Then Return Nothing
        Using ms As New MemoryStream()
            image.Save(ms, Imaging.ImageFormat.Jpeg) ' You can change the format if needed
            Return ms.ToArray()
        End Using
    End Function




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
                ispicture = True
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



    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles whiteb.CheckedChanged
        If whiteb.Checked = True Then
            iswbackground = True
        Else
            iswbackground = False
        End If
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

            ispicture = True

        End If
    End Sub
End Class