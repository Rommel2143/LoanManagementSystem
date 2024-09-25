Public Class member_options
    Dim accountno As String

    Private Sub member_options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub load_data(acc As String, member As String)
        accountno = acc
        lbl_fullname.Text = member

    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        display_formsub(sharecap_collection, "Share Capital")

        Me.Close()
    End Sub
End Class