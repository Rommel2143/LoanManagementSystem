Imports System
Public Class sub_FRAME


    Private Sub display_formsub(form As Form)

        With form
            .Refresh()
            .TopLevel = False
            Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        con.Close()
        Application.Exit()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        display_form(Login)
        Login.txt_user.Clear()
    End Sub

    Private Sub DeviceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceInfoToolStripMenuItem.Click
        MessageBox.Show("Mac:" & PCmac & "   /  Device:" & PCname & "", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CreateApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateApplicationToolStripMenuItem.Click
        display_formsub(loan_application)
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        display_formsub(test)
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        display_formsub(employee_add)
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        display_formsub(members_masterlist)
    End Sub
End Class