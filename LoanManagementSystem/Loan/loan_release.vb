﻿
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class loan_release
    Private Sub loan_approval(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMemberProfiles()
    End Sub

    Public Sub LoadMemberProfiles()
        Try
            flow_loan.Controls.Clear()
            con.Close()
            con.Open()
            Dim query As String = "SELECT la.id,la.amount, la.referenceno,la.purpose, la.account_no,  DATE_FORMAT(la.date_approved, '%M %d, %Y') AS date_approved,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 1 ORDER BY la.date_approved DESC"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Create a new Guna2Panel for each member
                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = (flow_loan.Width / 3)
                memberPanel.Height = 120
                memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                memberPanel.BorderRadius = 10
                memberPanel.Margin = New Padding(10)


                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 12)
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text = $"{reader("Fullname")} ({reader("account_no")})" & Environment.NewLine &
                                    $"  {reader("referenceno")}" & Environment.NewLine &
                                     $"  {reader("purpose")} - ({Convert.ToDecimal(reader("amount")).ToString("N0")} pesos)" & Environment.NewLine &
                                    $"  Date Approved: {reader("date_approved")}"

                memberLabel.Location = New Point(10, 15)



                ' Button for edit
                Dim editbtn As New Guna2Button() With {
                                .Text = "",
                                .Image = My.Resources.send_cash,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(40, 40),
                                .Dock = DockStyle.Right,
                                .Tag = reader("referenceno"),
                                .FillColor = Color.Transparent}



                ' Add PictureBox and Label to the Panel

                memberPanel.Controls.Add(memberLabel)
                memberPanel.Controls.Add(editbtn)
                ' Add Panel to the FlowLayoutPanel
                flow_loan.Controls.Add(memberPanel)

                ' Optional hover effect
                AddHandler memberPanel.MouseEnter, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(240, 240, 240)
                                                       memberLabel.ForeColor = Color.FromArgb(30, 30, 30)

                                                   End Sub

                AddHandler memberPanel.MouseLeave, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                                                       memberLabel.ForeColor = Color.FromArgb(50, 50, 50)

                                                   End Sub
                AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                              Dim btn As Guna2Button = CType(senderObj, Guna2Button)
                                              Dim loanreference As String = CType(btn.Tag, String)
                                              loan_release_set.loadprofile(loanreference)
                                              loan_release_set.ShowDialog()
                                              loan_release_set.BringToFront()

                                          End Sub
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally

            con.Close()

        End Try
    End Sub
    Private Sub SearchProfiles()
        Try
            flow_loan.Controls.Clear()
            con.Close()
            con.Open()
            Dim query As String = "SELECT la.id,la.amount, la.referenceno,la.purpose, la.account_no,  DATE_FORMAT(la.date_approved, '%M %d, %Y') AS date_approved,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 1 and (la.referenceno REGEXP '" & txt_search.Text & "' or mp.lastname='" & txt_search.Text & "' or la.account_no REGEXP '" & txt_search.Text & "')"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Create a new Guna2Panel for each member
                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = (flow_loan.Width / 3)
                memberPanel.Height = 120
                memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                memberPanel.BorderRadius = 10
                memberPanel.Margin = New Padding(10)


                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 12)
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text = $"{reader("Fullname")} ({reader("account_no")})" & Environment.NewLine &
                                    $"  {reader("referenceno")}" & Environment.NewLine &
                                     $"  {reader("purpose")} - ({Convert.ToDecimal(reader("amount")).ToString("N0")} pesos)" & Environment.NewLine &
                                    $"  Date Approved: {reader("date_approved")}"

                memberLabel.Location = New Point(10, 15)



                ' Button for edit
                Dim editbtn As New Guna2Button() With {
                                .Text = "",
                                .Image = My.Resources.send_cash,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(40, 40),
                                .Dock = DockStyle.Right,
                                .Tag = reader("referenceno"),
                                .FillColor = Color.Transparent}



                ' Add PictureBox and Label to the Panel

                memberPanel.Controls.Add(memberLabel)
                memberPanel.Controls.Add(editbtn)
                ' Add Panel to the FlowLayoutPanel
                flow_loan.Controls.Add(memberPanel)

                ' Optional hover effect
                AddHandler memberPanel.MouseEnter, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(240, 240, 240)
                                                       memberLabel.ForeColor = Color.FromArgb(30, 30, 30)

                                                   End Sub

                AddHandler memberPanel.MouseLeave, Sub(senderObj, eArgs)
                                                       memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                                                       memberLabel.ForeColor = Color.FromArgb(50, 50, 50)

                                                   End Sub
                AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                              Dim btn As Guna2Button = CType(senderObj, Guna2Button)
                                              Dim loanreference As String = CType(btn.Tag, String)
                                              loan_release_set.loadprofile(loanreference)
                                              loan_release_set.ShowDialog()
                                              loan_release_set.BringToFront()


                                          End Sub
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally

            con.Close()

        End Try
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then

            LoadMemberProfiles()
        Else

            SearchProfiles()
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class