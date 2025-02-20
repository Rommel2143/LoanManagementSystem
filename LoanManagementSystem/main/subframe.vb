Public Class subframe

    Private Sub subframe_load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_calendar.Text = date1
        display_formsub(New dashboard, "Dashboard")
        Timer1.Start()
    End Sub
    Private Sub MasterlistToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles logout.Click
        display_mainframe(Login)
        Login.txt_password.Clear()
    End Sub



    'Private Sub DeviceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceInfoToolStripMenuItem.Click
    '    MessageBox.Show("Mac:" & PCmac & "   /  Device:" & PCname & "", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub


    Private Sub ManageMyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageMyProfileToolStripMenuItem.Click
        display_formsub(manage_profiles, "Manage my profile")
    End Sub

    Private Sub LoanApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_loan_apply.Click

        display_formsub(loan_application, "Loan Application")
    End Sub


    Private Sub LoanApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_loan_approve.Click
        display_formsub(loan_approval, "Loan Approval")
        loan_approval.load_profiles()
    End Sub

    Private Sub ReleaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnloan_release.Click
        display_formsub(loan_release, "Release Loan")
        loan_release.LoadMemberProfiles()
    End Sub

    Private Sub LoanRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnloan_collection.Click
        display_formsub(loan_active, "Active Loan")
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

    Private Sub SuggestImprovementToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_calendar.Text = Date.Now.ToString("MMMM dd, yyyy  h:m tt")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LoanRecordsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoanRecordsToolStripMenuItem1.Click
        display_formsub(loan_records, "Loan Records")
        loan_records.loadrecords()
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btn_manageuser.Click
        display_formsub(New user_management, "User Management")
    End Sub
End Class