Imports MySql.Data.MySqlClient
Public Class sharecap_collection
    Dim account As String
    Dim selected_trans As String
    Private Sub sharecap_collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_display("SELECT DISTINCT CONCAT(`type`,' (', `code`,')') AS `type_code` FROM `sharecap_transaction` ORDER BY `type_code` ASC", "type_code", cmb_purpose)
    End Sub
    Public Sub loaddata(id As String, member As String)
        account = id
        lbl_account.Text = member

    End Sub
    Private Sub insertshare()

    End Sub


End Class