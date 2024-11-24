Public Class loan_records_select
    Public Property referenceno As String

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Dim loanrecord As New print_loanapp
        loanrecord.printapplication(referenceno)
        loanrecord.ShowDialog()
    End Sub

    Private Sub loan_records_select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_fullname.Text = "Reference:" & referenceno
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Dim loanrecord As New print_loanapp
        loanrecord.printdetails(referenceno)
        loanrecord.ShowDialog()
    End Sub
End Class