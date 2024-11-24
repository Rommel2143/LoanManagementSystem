Public Class lms_mainframe
    Private Sub Inventory_Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim testmode As Boolean = True


        If testmode = True Then
            error_panel.Visible = True
            display_mainframe(subframe)
            user_account = "03200728"
            user_fullname = "Rommel Cueto Magnaye"
            user_firstname = "Dev Rommel"
            user_pass = "123"
            display_mainframe(subframe)
            subframe.userstrip.Text = "Hello, " & user_firstname

        Else
            display_mainframe(Login)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datedb = Date.Now.ToString("yyyy-MM-dd")
        timedb = Date.Now.ToString("HH:mm:ss")
    End Sub
End Class