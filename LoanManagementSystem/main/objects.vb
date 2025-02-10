Imports Guna.UI2.WinForms
Module objects


    Public Sub addobject_group(parentPanel As Panel, partname As String, partcode As String, qty As Integer)
        ' Create a new panel
        Dim childPanel As New Guna2Panel()

        ' Set properties for the child panel
        With childPanel

            .Width = 400
            .Height = 120
            .FillColor = Color.White
            .Margin = New Padding(10)
            .BorderThickness = 1
            .BorderRadius = 5
            .BorderColor = Color.MidnightBlue
        End With

        Dim partnameLabel As New Label()
        With partnameLabel
            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = partname

            .Location = New Point(10, 15)
        End With

        Dim partcodeLabel As New Label()
        With partcodeLabel
            .Font = New Font("Segoe UI", 12)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = partcode

            .Location = New Point(10, 35)
        End With

        Dim qtyLabel As New Label()
        With qtyLabel
            .Font = New Font("Segoe UI", 15)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = "Total : " & qty.ToString
            .Location = New Point(15, 65)
        End With

        ' Button for edit
        Dim editbtn As New Guna2Button() With {
                                .Text = "",
                                .Image = My.Resources.approval,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(30, 30),
                                .Dock = DockStyle.Right,
                                .Tag = dr("referenceno"),
                                .FillColor = Color.MidnightBlue}

        childPanel.Controls.Add(partnameLabel)
        childPanel.Controls.Add(partcodeLabel)
        childPanel.Controls.Add(qtyLabel)
        childPanel.Controls.Add(editbtn)
        parentPanel.Controls.Add(childPanel)

    End Sub


    'Private Sub displayrecord()
    '    Try
    '        flow_loan.Controls.Clear()
    '        con.Close()
    '        con.Open()
    '        Dim cmd As New MySqlCommand(query, con)
    '        dr = cmd.ExecuteReader()

    '        While dr.Read()
    '            Dim memberPanel As New Guna2Panel()
    '            memberPanel.Width = 400
    '            memberPanel.Height = 120
    '            memberPanel.FillColor = Color.White
    '            memberPanel.Margin = New Padding(10)
    '            memberPanel.ShadowDecoration.Enabled = True
    '            memberPanel.ShadowDecoration.Color = Color.Silver

    '            ' Label for member information
    '            Dim memberLabel As New Label()
    '            memberLabel.Font = New Font("Segoe UI", 10)
    '            memberLabel.BackColor = Color.White
    '            memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
    '            memberLabel.AutoSize = True
    '            memberLabel.Text = $"{dr("Fullname")} ({dr("account_no")})" & Environment.NewLine &
    '                                $"  {dr("referenceno")}" & Environment.NewLine &
    '                                 $"  {dr("purpose")} - ({Convert.ToDecimal(dr("amount")).ToString("N0")} pesos)" & Environment.NewLine &
    '                                $"  Date Applied: {dr("date_apply")}"

    '            memberLabel.Location = New Point(10, 15)



    '            ' Button for edit
    '            Dim editbtn As New Guna2Button() With {
    '                            .Text = "",
    '                            .Image = My.Resources.approval,
    '                            .Width = 65,
    '                            .Height = 30,
    '                            .ImageSize = New Size(30, 30),
    '                            .Dock = DockStyle.Right,
    '                            .Tag = dr("referenceno"),
    '                            .FillColor = Color.MidnightBlue}


    '            ' Add PictureBox and Label to the Panel

    '            memberPanel.Controls.Add(memberLabel)
    '            memberPanel.Controls.Add(editbtn)
    '            ' Add Panel to the FlowLayoutPanel
    '            flow_loan.Controls.Add(memberPanel)


    '            AddHandler editbtn.Click, Sub(senderObj, eArgs)
    '                                          Dim btn As Guna2Button = CType(senderObj, Guna2Button)
    '                                          Dim loanreference As String = CType(btn.Tag, String)
    '                                          loan_approval_set.loadprofile(loanreference)
    '                                          loan_approval_set.ShowDialog()
    '                                          loan_approval_set.BringToFront()

    '                                      End Sub
    '        End While


    '        dr.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    Finally
    '        ' Cleanup resources
    '        If dr IsNot Nothing Then dr.Close()
    '        If cmd IsNot Nothing Then cmd.Dispose()
    '        If con.State = ConnectionState.Open Then con.Close()
    '    End Try
    'End Sub
End Module
