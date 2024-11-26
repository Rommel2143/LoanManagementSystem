Imports MySql.Data.MySqlClient
Public Class user_management
    Private Sub user_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmb_fullname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_fullname.SelectedIndexChanged
        Dim query As String = "SELECT * 
                    FROM user u 
                    JOIN member_profile mp ON mp.account_no=u.account_no
                    WHERE CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', u.account_no,')')='" & cmb_fullname.Text & "'"
        con.Close()
        con.Open()
        Dim selectuser As New MySqlCommand(query, con)
        dr = selectuser.ExecuteReader
        If dr.Read = True Then
            lbl_account.Text = dr.GetString("account_no")
        End If
    End Sub

    Private Sub cmb_fullname_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_fullname.MouseClick
        cmb_display("SELECT CONCAT(mp.lastname, ', ', mp.firstname, ' ', mp.middlename,' (', u.account_no,')') AS Fullname
                    FROM user u JOIN member_profile mp ON mp.account_no=u.account_no", "Fullname", cmb_fullname)
    End Sub
End Class