Public Class member_options
    Dim accountno As String

    Private Sub member_options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub load_data(acc As String, member As String)
        accountno = acc
        lbl_fullname.Text = member

    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Dim sc As New sharecap_collection
        sc.loaddata(accountno, lbl_fullname.Text)
        display_formsub(sc, "Share Capital")

        Me.Close()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Dim sav As New savings
        sav.loaddata(accountno)
        display_formsub(sav, "Savings")
        Me.Close()
    End Sub
End Class