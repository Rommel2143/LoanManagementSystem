Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.IO
Public Class loan_approval
    Private Sub loan_approval(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMemberProfiles()
    End Sub

    Private Sub LoadMemberProfiles()
        Try
            con.Open()
            Dim query As String = "SELECT la.id,la.amount, la.referenceno, la.account_no,  DATE_FORMAT(la.date_apply, '%M %d, %Y') AS date_apply,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 0"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Create a new Guna2Panel for each member
                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = flow_loan.Width - 20
                memberPanel.Height = 140
                memberPanel.BackColor = Color.FromArgb(250, 250, 250)
                memberPanel.BorderRadius = 10
                memberPanel.Margin = New Padding(10)


                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 12)
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text =
                                   $"Reference No. : {reader("referenceno")}" & Environment.NewLine &
                                   $"Borrower: {reader("Fullname")} ({reader("account_no")})" & Environment.NewLine &
                                     $"Loan Amount: Php {Convert.ToDecimal(reader("amount")).ToString("N0")}" & Environment.NewLine &
                                    $"Date Entry: {reader("date_apply")}"

                memberLabel.Location = New Point(80, 10)



                ' Button for edit
                Dim editbtn As New Guna2ImageButton() With {
                                .Text = "Edit",
                                .Image = My.Resources.edit,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(30, 30),
                                .Dock = DockStyle.Right,
                                .Tag = reader("id")}



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
                                              Dim btn As Guna2ImageButton = CType(senderObj, Guna2ImageButton)
                                              Dim loanid As String = CType(btn.Tag, String)
                                              MessageBox.Show($"id No: {loanid}")

                                          End Sub
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally

            con.Close()

        End Try
    End Sub
End Class