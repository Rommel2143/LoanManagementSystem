Public Class Mainframe
    Private Sub RegisterAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        registeraccount.Show()
        registeraccount.BringToFront()

    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        With accounts
            .Refresh()
            .TopLevel = False
            panel1.Controls.Add(accounts)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayForm(Dashboard, panel1)
    End Sub
    Private Sub DisplayForm(ByVal form As Form, ByVal panel As Panel)
        ' Set properties for the form
        With form
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill

            ' Add the form to the panel controls collection
            panel.Controls.Clear() ' Clear existing controls in the panel
            panel.Controls.Add(form)

            ' Show the form
            .Show()

        End With
    End Sub
End Class