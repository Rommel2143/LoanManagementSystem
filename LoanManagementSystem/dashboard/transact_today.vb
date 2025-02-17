Imports MySql.Data.MySqlClient
Public Class transact_today
    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_transact.SelectedIndexChanged
        Dim query As String = ""
        Select Case cmb_transact.SelectedIndex
            Case 0
                query = "SELECT `referenceno`, `account_no`, `ammortization`,  `due_fines`, `teller`, date_paid FROM `loan_collection` WHERE date_paid BETWEEN '" & dtpicker_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker_to.Value.ToString("yyyy-MM-dd") & "'"
            Case 1
                query = "SELECT  `referenceno`, `account_no`, `amount`,teller,date_apply FROM loan_app WHERE date_apply BETWEEN '" & dtpicker_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker_to.Value.ToString("yyyy-MM-dd") & "'"
            Case 2
                query = "SELECT `referenceno`, `account_no`, `amount`, `teller`,date_transac FROM `sharecap` WHERE date_transac BETWEEN '" & dtpicker_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker_to.Value.ToString("yyyy-MM-dd") & "'"
            Case 3
                query = "SELECT `referenceno`, `account_no`, `amount`, `teller`,date_transac FROM `savings` WHERE date_transac BETWEEN '" & dtpicker_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpicker_to.Value.ToString("yyyy-MM-dd") & "'"
        End Select
        reload(query, datagrid1)
    End Sub

    Private Sub transact_today_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker_from.Value = Date.Now
        dtpicker_to.Value = Date.Now
    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exportexcel(datagrid1)
    End Sub
End Class