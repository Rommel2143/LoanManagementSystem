Public Class registeraccount
    Dim civil_status As String
    Dim income_source As String
    Dim monthly_income As String
    Dim gender As String
    Dim idtype As String
    Dim relation As String
    Private Sub registeraccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateofbirth.Value = Date.Now
    End Sub
    Private Sub Guna2CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkaddress.CheckedChanged
        If checkaddress.Checked = True Then
            txtcurrentadd.Text = placeofbirth.Text
        Else
            txtcurrentadd.Text = ""
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Try
            Dim dob As Date = dateofbirth.Value
            create("INSERT INTO         `account_masterlist`
                                                   (`IDno`,
                                                    `fullname`,
                                                    `dob`,
                                                    `placeofbirth`,
                                                    `civilstatus`, 
                                                    `gender`, 
                                                    `idtype`, 
                                                    `valididno`, 
                                                    `currentaddress`,
                                                    `phone`,
                                                    `email`,
                                                    `incomesource`,
                                                    `monthlyincome`,
                                                    `emergencyname`,
                                                    `emergencyrelation`,
                                                    `emergencyphone`,
                                                       `status`,
                                                           `dateregistered`)

                                        VALUES  (   '" & idno_display.Text & "',
                                                    '" & fname_display.Text & "',
                                                    '" & dob.ToString("yyyy-MM-dd") & "',
                                                    '" & placeofbirth.Text & "',
                                                    '" & civil_status & "',
                                                    '" & gender & "',
                                                    '" & idtype & "',
                                                    '" & txtidno.Text & "',
                                                    '" & txtcurrentadd.Text & "',
                                                    '" & txtphoneno.Text & "',
                                                    '" & txtemail.Text & "',
                                                    '" & income_source & "',
                                                    '" & monthly_income & "',
                                                    '" & txtemergencycontact.Text & "',
                                                    '" & relation & "',
                                                    '" & txtemergencynumber.Text & "',
                                                            'active',
                                                    '" & Date.Now.ToString("yyyy-MM-dd") & "')")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbidtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbidtype.SelectedIndexChanged
        check_id()
        group1check()

        Select Case cmbidtype.SelectedIndex
            Case 0
                idtype = "UMID"
            Case 1
                idtype = "license"
            Case 2
                idtype = "SSS"
            Case 3
                idtype = "PHealth"
            Case 4
                idtype = "TIN"
            Case 5
                idtype = "Other"

        End Select


    End Sub

    Private Sub cmbcivil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcivil.SelectedIndexChanged
        check_gender()
        group1check()

        Select Case cmbcivil.SelectedIndex
            Case 0
                civil_status = "S"
            Case 1
                civil_status = "M"
            Case 2
                civil_status = "D"
            Case 3
                civil_status = "W"
            Case 4
                civil_status = "O"

        End Select

    End Sub

    Private Sub cmbgender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgender.SelectedIndexChanged
        check_gender()
        group1check()

        Select Case cmbgender.SelectedIndex
            Case 0
                gender = "M"
            Case 1
                gender = "F"
            Case 2
                gender = "O"
        End Select

    End Sub

    Private Sub cmbincomesource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbincomesource.SelectedIndexChanged
        check_financial()

        Select Case cmbincomesource.SelectedIndex
            Case 0
                income_source = "Emp"
            Case 1
                income_source = "SelfEmp"
            Case 2
                income_source = "Invest"
            Case 3
                income_source = "Retire"
            Case 4
                income_source = "Rental"
            Case 5
                income_source = "Other"

        End Select
    End Sub

    Private Sub cmbmonthlyincome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmonthlyincome.SelectedIndexChanged
        check_financial()

        Select Case cmbmonthlyincome.SelectedIndex
            Case 0
                monthly_income = "10K below"
            Case 1
                monthly_income = "10-25K"
            Case 2
                monthly_income = "25K-50K"
            Case 3
                monthly_income = "50-100K"
            Case 4
                monthly_income = "100K up"

        End Select
    End Sub

    Private Sub cmbrelationship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbrelationship.SelectedIndexChanged
        check_emergency_credential()

        Select Case cmbrelationship.SelectedIndex
            Case 0
                relation = "P"
            Case 1
                relation = "S"
            Case 2
                relation = "R"
            Case 3
                relation = "F"
            Case 4
                relation = "O"
        End Select
    End Sub

    Private Sub group1check()
        If txtfirstname.Text = "" Or txtlastname.Text = "" Or placeofbirth.Text = "" Or dateofbirth.Value = Date.Now Or txtidno.Text = "" Or cmbcivil.Text = "" Or cmbgender.Text = "" Or cmbidtype.Text = "" Then
            group_address.Enabled = False
            group_financial.Enabled = False
            group_emergency.Enabled = False
        Else
            group_address.Enabled = True
            group_financial.Enabled = True
            group_emergency.Enabled = True
        End If
    End Sub
    Private Sub check_fullname()
        If txtfirstname.Text = "" Or txtlastname.Text = "" Then
            If fullname_done.Visible = False Then
            Else
                fullname_done.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If fullname_done.Visible = True Then
            Else
                fullname_done.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub
    Private Sub check_birth()
        If placeofbirth.Text = "" Or dateofbirth.Value.ToString("MMMM dd yyyy") = Date.Now.ToString("MMMM dd yyyy") Then
            If birth_done.Visible = False Then
            Else
                birth_done.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If birth_done.Visible = True Then
            Else
                birth_done.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub
    Private Sub check_gender()
        If cmbcivil.Text = "" Or cmbgender.Text = "" Then
            If gender_done.Visible = False Then
            Else
                gender_done.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If gender_done.Visible = True Then
            Else
                gender_done.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub
    Private Sub check_id()
        If cmbidtype.Text = "" Or txtidno.Text = "" Then
            If id_done.Visible = False Then
            Else
                id_done.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If id_done.Visible = True Then
            Else
                id_done.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub
    Private Sub check_financial()
        If cmbincomesource.Text = "" Or cmbmonthlyincome.Text = "" Then

            If done_financial.Visible = False Then
            Else
                done_financial.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If done_financial.Visible = True Then
            Else
                done_financial.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub
    Private Sub check_emergency_credential()
        If cmbrelationship.Text = "" Or txtemergencynumber.Text = "" Then

            If done_emergency_credential.Visible = False Then
            Else
                done_emergency_credential.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If done_emergency_credential.Visible = True Then
            Else
                done_emergency_credential.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub
    Private Sub txtfirstname_TextChanged(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged
        check_fullname()
        group1check()
    End Sub
    Private Sub txtlastname_TextChanged(sender As Object, e As EventArgs) Handles txtlastname.TextChanged
        check_fullname()
        group1check()
    End Sub
    Private Sub txtidno_TextChanged(sender As Object, e As EventArgs) Handles txtidno.TextChanged
        check_id()
        group1check()
    End Sub



    Private Sub placeofbirth_TextChanged(sender As Object, e As EventArgs) Handles placeofbirth.TextChanged
        check_birth()
        group1check()
    End Sub

    Private Sub dateofbirth_ValueChanged(sender As Object, e As EventArgs) Handles dateofbirth.ValueChanged
        check_birth()
        group1check()
    End Sub



    Private Sub txtcurrentadd_TextChanged(sender As Object, e As EventArgs) Handles txtcurrentadd.TextChanged
        If txtcurrentadd.Text = "" Then
            If done_current_address.Visible = False Then
            Else
                done_current_address.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If done_current_address.Visible = True Then
            Else
                done_current_address.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub

    Private Sub txtphoneno_TextChanged(sender As Object, e As EventArgs) Handles txtphoneno.TextChanged
        If txtphoneno.Text = "" Then
            If done_phone.Visible = False Then
            Else
                done_phone.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If done_phone.Visible = True Then
            Else
                done_phone.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged
        If txtemail.Text = "" Then
            If done_email.Visible = False Then
            Else
                done_email.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If done_email.Visible = True Then
            Else
                done_email.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles done_emergency_credential.Click

    End Sub

    Private Sub txtemergencynumber_TextChanged(sender As Object, e As EventArgs) Handles txtemergencynumber.TextChanged
        check_emergency_credential()
    End Sub

    Private Sub txtemergencycontact_TextChanged(sender As Object, e As EventArgs) Handles txtemergencycontact.TextChanged
        If txtemergencycontact.Text = "" Then
            If done_emergency_name.Visible = False Then
            Else
                done_emergency_name.Visible = False
                progress_registration.Value -= 1
            End If
        Else
            If done_emergency_name.Visible = True Then
            Else
                done_emergency_name.Visible = True
                progress_registration.Value += 1
            End If
        End If
    End Sub

    Private Sub GetIDno()
        Dim getdate As String = Date.Now.ToString("HHMMdd-yymmss")
        idno_display.Text = "LP-" & getdate
    End Sub
    Private Sub progress_registration_ValueChanged(sender As Object, e As EventArgs) Handles progress_registration.ValueChanged
        If progress_registration.Value = "10" Then
            btnregister.Enabled = True

            Dim firstName As String = txtfirstname.Text
            Dim middleInitial As String = txtxtmiddleinitial.Text
            Dim lastName As String = txtlastname.Text

            Dim capitalizedFirstName As String = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower()
            Dim capitalizedMiddleInitial As String = middleInitial.ToUpper()
            Dim capitalizedLastName As String = lastName.Substring(0, 1).ToUpper() + lastName.Substring(1).ToLower()

            Dim fname As String
            If txtxtmiddleinitial.Text = "" Then
                fname = capitalizedFirstName & " " & capitalizedMiddleInitial & " " & capitalizedLastName
                fname_display.Text = fname
            Else
                fname = capitalizedFirstName & " " & capitalizedMiddleInitial & ". " & capitalizedLastName
            End If
            fname_display.Text = fname
            GetIDno()

        Else
            fname_display.Text = ""
            btnregister.Enabled = False
        End If
    End Sub

    Private Sub fname_display_Click(sender As Object, e As EventArgs) Handles fname_display.Click


    End Sub
End Class