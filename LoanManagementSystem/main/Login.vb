﻿Imports MySql.Data.MySqlClient
Imports System.Reflection
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_password.UseSystemPasswordChar = True
            txtpcname.Text = PCname
            txtpcmac.Text = PCmac
            Dim version As String = Assembly.GetExecutingAssembly().GetName().Version.ToString()
            lblversion.Text = version
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT * FROM computer_location WHERE `PCname`='" & PCname & "' and `PCmac`='" & PCmac & "'", con)
            dr = cmdselect.ExecuteReader
            If dr.Read = True Then
                txt_user.Enabled = True
                txt_user.Focus()


            Else
                Dim result As DialogResult = MessageBox.Show("Machine not Verified!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                If result = DialogResult.OK Then
                    display_mainframe(Register_PC)

                ElseIf result = DialogResult.Cancel Then
                    con.Close()
                    Application.Exit()
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txt_user.Clear()

        End Try



    End Sub

    Private Sub Guna2ImageButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_see.MouseDown
        txt_password.UseSystemPasswordChar = False
    End Sub

    ' This event will trigger when the button is released
    Private Sub Guna2ImageButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_see.MouseUp
        txt_password.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        login()

    End Sub

    Private Sub login()
        Try

            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT u.account_no,u.username, u.pass, CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS fullname,mp.firstname, u.loan_apply,u.loan_approve  FROM `user` u
                                        JOIN member_profile mp ON u.account_no= mp.account_no
                                        WHERE (u.username = '" & txt_user.Text & "' or u.account_no= '" & txt_user.Text & "') and u.pass = '" & txt_password.Text & "' ", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                user_account = dr("account_no").ToString
                user_fullname = dr.GetString("fullname")
                user_firstname = dr.GetString("firstname")
                user_pass = dr.GetString("pass")
                If dr.GetInt32("loan_apply") = 1 Then
                    subframe.btn_loan_apply.Visible = True
                Else
                    subframe.btn_loan_apply.Visible = False
                End If

                If dr.GetInt32("loan_approve") = 1 Then
                    subframe.btn_loan_approve.Visible = True
                Else
                    subframe.btn_loan_approve.Visible = False
                End If







                display_mainframe(subframe)
                    subframe.userstrip.Text = "Hello, " & user_firstname
                    error_panel.Visible = False
                Else
                    error_panel.Visible = True
                txt_password.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()


        End Try
    End Sub


    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub btn_see_Click(sender As Object, e As EventArgs) Handles btn_see.Click

    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub
End Class