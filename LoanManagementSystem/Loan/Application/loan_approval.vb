

Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class loan_approval


    Public Sub load_profiles()
        Dim query As String

        query = "SELECT la.id,la.amount, la.referenceno,la.purpose, la.account_no,  DATE_FORMAT(la.date_apply, '%M %d, %Y') AS date_apply,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 0 ORDER BY la.date_apply DESC"
        con.Close()
        con.Open()
        Dim loaddata As New MySqlCommand(query, con)
        dr = loaddata.ExecuteReader
        flow_loan.Controls.Clear()

        While dr.Read = True
            addobject_group(flow_loan, dr.GetString("referenceno"), dr.GetString("Fullname"), dr.GetString("date_apply"), dr.GetDecimal("amount"))
        End While
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim query As String
        If txt_search.Text = "" Then
            query = "SELECT la.id,la.amount, la.referenceno,la.purpose, la.account_no,  DATE_FORMAT(la.date_apply, '%M %d, %Y') AS date_apply,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 0 ORDER BY la.date_apply DESC"

        Else


            query = "SELECT la.id,la.amount, la.referenceno,la.purpose, la.account_no,  DATE_FORMAT(la.date_apply, '%M %d, %Y') AS date_apply,CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename) AS Fullname  FROM loan_app la
                                    JOIN member_profile mp ON mp.account_no = la.account_no WHERE la.status= 0 and (la.referenceno REGEXP '" & txt_search.Text & "' or mp.lastname='" & txt_search.Text & "' or la.account_no REGEXP '" & txt_search.Text & "')"

        End If
        con.Close()
        con.Open()
        Dim loaddata As New MySqlCommand(query, con)
        dr = loaddata.ExecuteReader
        flow_loan.Controls.Clear()

        While dr.Read = True
            addobject_group(flow_loan, dr.GetString("referenceno"), dr.GetString("Fullname"), dr.GetString("date_apply"), dr.GetDecimal("amount"))
        End While
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub flow_loan_Paint(sender As Object, e As PaintEventArgs) Handles flow_loan.Paint

    End Sub
End Class