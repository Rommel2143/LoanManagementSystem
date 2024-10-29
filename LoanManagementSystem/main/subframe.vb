Public Class subframe

    Private Sub subframe_load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_calendar.Text = date1
        display_formsub(New dashboard, "Dashboard")
    End Sub
    Private Sub MasterlistToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logout.Click
        display_mainframe(Login)
        Login.txt_password.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        con.Close()
        Application.Exit()

    End Sub

    Private Sub DeviceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceInfoToolStripMenuItem.Click
        MessageBox.Show("Mac:" & PCmac & "   /  Device:" & PCname & "", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub ManageMyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMyProfileToolStripMenuItem.Click
        display_formsub(manage_profiles, "Manage my profile")
    End Sub

    Private Sub LoanApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_loan_apply.Click

        display_formsub(loan_application, "Loan Application")
    End Sub


    Private Sub LoanApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_loan_approve.Click
        display_formsub(loan_approval, "Loan Approval")
        loan_approval.LoadMemberProfiles()
    End Sub

    Private Sub ReleaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseToolStripMenuItem.Click
        display_formsub(loan_release, "Release Loan")
        loan_release.LoadMemberProfiles()
    End Sub

    Private Sub LoanRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanRecordsToolStripMenuItem.Click
        display_formsub(loan_records, "Loan Records")
        loan_records.loadrecords()
    End Sub

    Private Sub CollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionToolStripMenuItem.Click
        display_formsub(loan_active, "Acive Loan")
        loan_active.LoadMemberProfiles()
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembersToolStripMenuItem.Click
        display_formsub(member_accounts, "Accounts")
        member_accounts.LoadData()
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        display_formsub(New dashboard, "Dashboard")
    End Sub
End Class