

Imports MySql.Data.MySqlClient
    Imports Guna.UI2.WinForms
Public Class loan_approval
    Dim query As String


    Public Sub LoadMemberProfiles()
        query = "SELECT la.id,la.amount, la.referenceno,la.purpose, la.account_no,  DATE_FORMAT(la.date_apply, '%M %d, %Y') AS date_apply,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 0 ORDER BY la.date_apply DESC"
        displayrecord()
    End Sub
    Private Sub SearchProfiles()

        query = "SELECT la.id,la.amount, la.referenceno,la.purpose, la.account_no,  DATE_FORMAT(la.date_apply, '%M %d, %Y') AS date_apply,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 0 and (la.referenceno REGEXP '" & txt_search.Text & "' or mp.lastname='" & txt_search.Text & "' or la.account_no REGEXP '" & txt_search.Text & "')"
        displayrecord()
    End Sub
    Private Sub displayrecord()
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
                                    $"  Date Applied: {reader("date_apply")}"

                memberLabel.Location = New Point(10, 15)



                ' Button for edit
                Dim editbtn As New Guna2Button() With {
                                .Text = "",
                                .Image = My.Resources.approval,
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
                                              loan_approval_set.loadprofile(loanreference)
                                              loan_approval_set.ShowDialog()
                                              loan_approval_set.BringToFront()

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