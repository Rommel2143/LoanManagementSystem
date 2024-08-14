Imports MySql.Data.MySqlClient
Imports System.Reflection
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtpcname.Text = PCname
            txtpcmac.Text = PCmac
            Dim version As String = Assembly.GetExecutingAssembly().GetName().Version.ToString()
            lblversion.Text = version
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT * FROM computer_location WHERE `PCname`='" & PCname & "' and `PCmac`='" & PCmac & "'", con)
            dr = cmdselect.ExecuteReader
            If dr.Read = True Then
                txt_idno.Enabled = True
                txt_idno.Focus()


            Else
                Dim result As DialogResult = MessageBox.Show("Machine not Verified!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                If result = DialogResult.OK Then
                    display_form(Register_PC)

                ElseIf result = DialogResult.Cancel Then
                    con.Close()
                    Application.Exit()
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txt_idno.Clear()

        End Try
    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txt_idno.TextChanged

    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_idno.KeyDown



    End Sub
    Private Sub noid()
        Try
            labelerror.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Guna2ImageButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseDown
        ' Show password characters
        password.PasswordChar = ""
    End Sub

    ' This event will trigger when the button is released
    Private Sub Guna2ImageButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2ImageButton1.MouseUp
        ' Hide password characters
        password.PasswordChar = "*"c
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        login()

    End Sub

    Private Sub login()
        Try

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT u.IDno, u.pass, CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,mp.firstname  FROM `user` u
                                        JOIN member_profile mp ON u.IDno= mp.IDno
                                        WHERE (u.IDno = '" & txt_idno.Text & "') and u.pass = '" & password.Text & "' ", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                idno = dr("IDno").ToString

                user_fullname = dr.GetString("fullname")
                user_firstname = dr.GetString("firstname")
                display_form(sub_FRAME)
                sub_FRAME.userstrip.Text = "Hello, " & user_firstname
                labelerror.Visible = False
            Else
                noid()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txt_idno.Clear()

        End Try
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class