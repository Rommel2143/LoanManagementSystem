Public Class loan_records_select
    Public Property referenceno As String
    Private Sub loan_records_select_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub loan_records_select_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loaddata(referenceno)
    End Sub
    ' Button to print loan application
    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Dim loanrecord As New print_loanapp
        loanrecord.printapplication(referenceno)
        loanrecord.ShowDialog()
    End Sub
    Public Sub loaddata(ref As String)
        referenceno = ref
        lbl_fullname.Text = "Reference: " & referenceno
    End Sub
    ' Form load event to set reference number


    ' Button to print loan details
    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        Dim loanrecord As New print_loanapp
        loanrecord.printdetails(referenceno)
        loanrecord.ShowDialog()
    End Sub

    ' Button to print comaker information
    Private Sub Guna2TileButton4_Click(sender As Object, e As EventArgs) Handles Guna2TileButton4.Click
        Dim loanrecord As New print_loanapp
        loanrecord.printcomaker(referenceno)
        loanrecord.ShowDialog()
    End Sub

    ' Button to open loan records collection form
    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Dim loancollect As New loan_records_collection
        display_formsub(loancollect, "Loan Collection")
        loancollect.loadmonths(referenceno)
        Me.Close()
    End Sub

    ' Empty button handler (if needed in the future)
    Private Sub Guna2TileButton5_Click(sender As Object, e As EventArgs) Handles Guna2TileButton5.Click
        Dim loaninfo As New loan_records_info
        display_formsub(loaninfo, "Loan Collection")
        loaninfo.loaddata(referenceno)
        Me.Close()
    End Sub


End Class
