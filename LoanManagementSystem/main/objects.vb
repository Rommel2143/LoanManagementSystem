Imports Guna.UI2.WinForms
Module objects


    Public Sub addobject_group(parentPanel As Panel, referenceno As String, fullname As String, datetransac As String, amount As Decimal)

        ' Create a new panel
        Dim childPanel As New Guna2Panel()

        ' Set properties for the child panel
        With childPanel

            .Width = 300
            .Height = 120
            .FillColor = Color.White
            .Margin = New Padding(10)
            .BorderThickness = 1
            .BorderRadius = 5
            .BorderColor = Color.MidnightBlue
        End With

        Dim referencelabel As New Label()
        With referencelabel
            .Font = New Font("Segoe UI", 13, FontStyle.Bold)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = referenceno

            .Location = New Point(10, 15)
        End With

        Dim fullnamelabel As New Label()
        With fullnamelabel
            .Font = New Font("Segoe UI", 12)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = fullname

            .Location = New Point(10, 35)
        End With


        Dim datelabel As New Label()
        With datelabel
            .Font = New Font("Segoe UI", 10)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = datetransac
            .Location = New Point(15, 60)
        End With

        Dim amountLabel As New Label()
        With amountLabel
            .Font = New Font("Segoe UI", 10)
            .BackColor = Color.White
            .ForeColor = Color.Black
            .AutoSize = True
            .Text = "Php " & amount.ToString("N0")
            .Location = New Point(15, 75)
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

        childPanel.Controls.Add(referencelabel)
        childPanel.Controls.Add(fullnamelabel)
        childPanel.Controls.Add(datelabel)
        childPanel.Controls.Add(amountLabel)
        childPanel.Controls.Add(editbtn)
        parentPanel.Controls.Add(childPanel)


        AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                      Dim btn As Guna2Button = CType(senderObj, Guna2Button)
                                      Dim loanreference As String = CType(btn.Tag, String)
                                      loan_approval_set.loadprofile(loanreference)
                                      loan_approval_set.Show()
                                      loan_approval_set.BringToFront()
                                  End Sub
    End Sub

End Module
