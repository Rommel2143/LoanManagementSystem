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
        Login.txt_idno.Clear()
    End Sub

    Private Sub DeviceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceInfoToolStripMenuItem.Click
        MessageBox.Show("Mac:" & PCmac & "   /  Device:" & PCname & "", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class