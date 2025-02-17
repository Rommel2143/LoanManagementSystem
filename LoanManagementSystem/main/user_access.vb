Imports MySql.Data.MySqlClient
Module user_access



    Public Function check_access_user(column As String) As Boolean
        Dim query As String = "SELECT " & column & " FROM user WHERE account_no = @idno"

        Try
            con.Close()
            con.Open()
            Using getdata As New MySqlCommand(query, con)
                getdata.Parameters.AddWithValue("@idno", user_account)

                Using reader As MySqlDataReader = getdata.ExecuteReader()
                    If reader.Read() Then
                        If reader.GetBoolean(0) Then
                            Return True ' User has access
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving access: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        ' Show error message only when access is denied
        display_error("You don't have access to this feature.")
        Return False
    End Function
End Module
