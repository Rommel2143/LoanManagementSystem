

Imports MySql.Data.MySqlClient
    Imports Guna.UI2.WinForms
Public Class loan_active
    Dim query As String
    Private Sub loan_approval(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub LoadMemberProfiles()
        query = "SELECT lc.id,la.amount, lc.referenceno,la.purpose, lc.account_no,  DATE_FORMAT(la.date_approved, '%M %d, %Y') AS date_approved,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname,la.months_count  FROM loan_collection lc
                                    JOIN member_profile mp ON mp.account_no = lc.account_no
                                    JOIN loan_app la ON la.account_no = lc.account_no
                                    WHERE lc.status= 0
                                    GROUP BY lc.referenceno"
        displayrecords()
    End Sub
    Private Sub SearchProfiles()

        query = "SELECT lc.id,la.amount, lc.referenceno,la.purpose, lc.account_no,  DATE_FORMAT(la.date_approved, '%M %d, %Y') AS date_approved,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname,la.months_count  FROM loan_collection lc
                                    JOIN member_profile mp ON mp.account_no = lc.account_no
                                    JOIN loan_app la ON la.account_no = lc.account_no
                                    WHERE lc.status= 0 and lc.referenceno REGEXP '" & txt_search.Text & "'
                                    GROUP BY lc.referenceno"
        displayrecords()
    End Sub
    Private Sub displayrecords()
        Try
            flow_loan.Controls.Clear()
            con.Close()
            con.Open()

            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()



                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = 400
                memberPanel.Height = 120
                memberPanel.FillColor = Color.White
                memberPanel.Margin = New Padding(10)
                memberPanel.ShadowDecoration.Enabled = True
                memberPanel.ShadowDecoration.Color = Color.Silver


                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 10)
                memberLabel.BackColor = Color.White
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text = $"{reader("Fullname")} ({reader("account_no")})" & Environment.NewLine &
                                    $"  {reader("referenceno")}" & Environment.NewLine &
                                     $"  {reader("purpose")} - ({Convert.ToDecimal(reader("amount")).ToString("N0")} pesos)" & Environment.NewLine &
                                    $"  Term: {reader("months_count").ToString}  months"

                memberLabel.Location = New Point(10, 15)


                ' Button for edit
                Dim editbtn As New Guna2Button() With {
                                .Text = "",
                                .Image = My.Resources.collect,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(30, 30),
                                .Dock = DockStyle.Right,
                                .Tag = reader("referenceno"),
                                .FillColor = Color.MidnightBlue}





                ' Add PictureBox and Label to the Panel

                memberPanel.Controls.Add(memberLabel)
                memberPanel.Controls.Add(editbtn)
                ' Add Panel to the FlowLayoutPanel
                flow_loan.Controls.Add(memberPanel)


                AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                              Dim btn As Guna2Button = CType(senderObj, Guna2Button)
                                              Dim loanreference As String = CType(btn.Tag, String)
                                              Dim loancollect As New loan_collection
                                              display_formsub(loancollect, "Loan Collection")
                                              loancollect.loadmonths(loanreference)

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

    Private Sub flow_loan_Paint(sender As Object, e As PaintEventArgs) Handles flow_loan.Paint

    End Sub
End Class