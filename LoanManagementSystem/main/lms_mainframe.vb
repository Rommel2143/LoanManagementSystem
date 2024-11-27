Imports System.ComponentModel

Public Class lms_mainframe
    Private Sub Inventory_Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim testmode As Boolean = False


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

    Private Sub lms_mainframe_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            Panel1.Controls.Clear()
            ' Close the database connection if it's open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Dispose of the database connection object
            con.Dispose()

            ' Release data reader if it exists
            If dr IsNot Nothing Then
                dr.Close()
                dr.Dispose()
            End If

            ' Release any additional resources if necessary
            cmd.Dispose()
            da.Dispose()
            dt.Dispose()


        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show($"An error occurred while closing resources: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class