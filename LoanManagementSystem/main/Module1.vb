Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Reflection
Imports ClosedXML.Excel
Module Module1

    Public Function connection() As MySqlConnection
        '  Return New MySqlConnection("server=localhost;user id=lms;password=Magnaye2143@#;database=lms")
        ' Return New MySqlConnection("server=localhost;user id=root;password= ;database=lms")
        Return New MySqlConnection("server=192.168.1.26;user id=lcpmpc123;password=lcpmpc123;database=lms")

    End Function
    Public con As MySqlConnection = connection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable

    'credentials of user
    Public user_fullname As String
    Public user_firstname As String
    Public user_level As String
    Public user_pass As String
    Public user_initial As String
    Public user_account As String
    Public user_print As Boolean

    'credentials of PC used
    Public PCname As String = Environment.MachineName
    Public PCmac As String = GetMacAddress()
    Public systemversion As String = Assembly.GetExecutingAssembly().GetName().Version.ToString()

    Public date1 As String = Date.Now.ToString("MMMM dd, yyyy")
    Public datedb As String = Date.Now.ToString("yyyy-MM-dd")
    Public timedb As String = Date.Now.ToString("HH:mm:ss")
    Public shift1 As String



    Function GetMacAddress() As String
        Dim macAddress As String = ""

        ' Get all network interfaces
        Dim networkInterfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

        ' Loop through each network interface to find the MAC address
        For Each networkInterface As NetworkInterface In networkInterfaces
            ' Check if the network interface is operational and not a loopback or tunnel interface
            If networkInterface.OperationalStatus = OperationalStatus.Up AndAlso
               networkInterface.NetworkInterfaceType <> NetworkInterfaceType.Loopback AndAlso
               networkInterface.NetworkInterfaceType <> NetworkInterfaceType.Tunnel Then
                ' Get the physical address (MAC address) of the network interface
                Dim physicalAddress As PhysicalAddress = networkInterface.GetPhysicalAddress()
                macAddress = physicalAddress.ToString()
                Exit For ' Exit the loop once the MAC address is found
            End If
        Next

        Return macAddress
    End Function
    Function IsTrustedDevice() As Boolean

        Try
            Dim query As String = "SELECT * FROM trusted_devices WHERE PCname = @pcName AND PCmac = @pcMac"

            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@pcName", PCname)
                cmd.Parameters.AddWithValue("@pcMac", PCmac)
                con.Close()
                con.Open()
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    Return True
                Else
                    Return False
                End If

            End Using

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub display_mainframe(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            lms_mainframe.Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Public Sub display_formsub(form As Form, text As String)
        ' Clear all existing controls in Panel1
        subframe.Panel1.Controls.Clear()

        With form
            .Refresh()
            .TopLevel = False
            ' Make the form fill the panel
            .Dock = DockStyle.Fill
            ' Add the new form to Panel1
            subframe.Panel1.Controls.Add(form)
            ' Update the title label
            subframe.lbl_tittle.Text = text
            .BringToFront()
            .Show()
        End With
    End Sub


    Public Sub display_error(text As String)
        ShowSnackbar(text)
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            ' Declare the necessary objects
            Dim dt As New DataTable
            Dim cmd As New MySqlCommand(sql, con)
            Dim da As New MySqlDataAdapter(cmd)
            con.Close()
            ' Open the connection
            con.Open()

            ' Fill the DataTable with data from the query
            da.Fill(dt)

            ' Bind the DataTable to the DataGridView
            DTG.DataSource = dt

        Catch ex As Exception
            ' Display error message
            MessageBox.Show(ex.Message)
        Finally
            ' Ensure the connection is closed after use
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Dispose of the DataAdapter and DataTable
            da.Dispose()
            dt.Dispose()
        End Try
    End Sub

    Public Sub exportexcel(datagrid As Guna.UI2.WinForms.Guna2DataGridView)
        Try
            If datagrid.Rows.Count > 0 Then
                Dim dt As New DataTable()

                ' Adding the Columns
                For Each column As DataGridViewColumn In datagrid.Columns
                    Dim colType As Type = If(column.ValueType IsNot Nothing, column.ValueType, GetType(String))
                    dt.Columns.Add(column.HeaderText, colType)
                Next

                ' Adding the Rows
                For Each row As DataGridViewRow In datagrid.Rows
                    If Not row.IsNewRow Then
                        Dim newRow As DataRow = dt.NewRow()
                        For Each cell As DataGridViewCell In row.Cells
                            newRow(cell.ColumnIndex) = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                        Next
                        dt.Rows.Add(newRow)
                    End If
                Next

                ' Save the data to an Excel file
                Using sfd As New SaveFileDialog()
                    sfd.Filter = "Excel Workbook|*.xlsx"
                    sfd.Title = "Save an Excel File"
                    If sfd.ShowDialog() = DialogResult.OK AndAlso sfd.FileName <> "" Then
                        Using wb As New XLWorkbook()
                            wb.Worksheets.Add(dt, "Sheet1")
                            wb.SaveAs(sfd.FileName)
                        End Using
                        MessageBox.Show("Data successfully exported to Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Else
                MessageBox.Show("No data available to export.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub cmb_display(sql As String, column As String, cmb As Guna.UI2.WinForms.Guna2ComboBox)
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand(sql, con)
            dr = cmdselect.ExecuteReader
            cmb.Items.Clear()
            While (dr.Read())
                cmb.Items.Add(dr.GetString(column))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Function GenerateReferenceNumber(transcode As String) As String
        Dim letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim digits As String = "0123456789"
        Dim reference As New StringBuilder()
        Dim datecode As String = Date.Now.ToString("yy")
        Dim rand As New Random()

        reference.Append(transcode) ' Add hyphen separator
        reference.Append("-") ' Add hyphen separator

        For i As Integer = 1 To 3
            reference.Append(letters(rand.Next(letters.Length)))
        Next

        For i As Integer = 1 To 3
            reference.Append(digits(rand.Next(digits.Length)))
        Next
        reference.Append("-") ' Add hyphen separator
        reference.Append(datecode)
        Return reference.ToString()
    End Function

    Public Sub ShowSnackbar(message As String)
        ' Create a new Form to act as the snackbar
        Dim snackbarForm As New Form()

        ' Set basic properties
        snackbarForm.FormBorderStyle = FormBorderStyle.None
        snackbarForm.StartPosition = FormStartPosition.Manual
        snackbarForm.BackColor = Color.FromArgb(60, 63, 65) ' Dark background
        snackbarForm.ForeColor = Color.White ' White text
        snackbarForm.Height = 40 ' Set the height of the snackbar
        snackbarForm.Width = Screen.PrimaryScreen.Bounds.Width ' Set the width to screen width
        snackbarForm.TopMost = True ' Ensure it's on top
        snackbarForm.ShowInTaskbar = False

        ' Set the position at the top of the screen (90 pixels from the top)
        snackbarForm.Location = New Point(0, 90) ' Start at the top-left corner of the screen

        ' Add a label to display the message
        Dim messageLabel As New Label()
        messageLabel.Text = message
        messageLabel.Font = New Font("Segoe UI", 10)
        messageLabel.ForeColor = Color.White ' White text for better contrast
        messageLabel.AutoSize = False
        messageLabel.TextAlign = ContentAlignment.MiddleCenter
        messageLabel.Dock = DockStyle.Fill ' Fill the entire form with the label
        snackbarForm.Controls.Add(messageLabel)



        snackbarForm.Show()


        ' Set up a timer to close the snackbar after a few seconds
        Dim closeTimer As New Timer()
        AddHandler closeTimer.Tick, Sub(sender, e)
                                        ' Fade out effect
                                        For i As Integer = 10 To 0 Step -1
                                            snackbarForm.Opacity = i / 10.0
                                            Threading.Thread.Sleep(30)
                                        Next
                                        snackbarForm.Close() ' Close the snackbar
                                        closeTimer.Stop()
                                    End Sub
        closeTimer.Interval = 3000 ' Show for specified duration
        closeTimer.Start()
    End Sub

    Public Function checksavings(accountno As String) As Decimal
        Try
            ' Ensure the connection is closed before opening it
            con.Close()
            con.Open()

            ' Define the SQL command to check balance
            Dim check As New MySqlCommand("SELECT 
            SUM(CASE WHEN `status` = 'ID'
                        or status='CHKD'
                        or status='CD'
                     THEN `amount` ELSE 0 END) 
                    - 
            SUM(CASE WHEN `status` = 'CW'
                        or status = 'CHKW'
                     THEN `amount` ELSE 0 END) AS balance
            FROM `savings`
            WHERE `account_no` = @accountno", con)

            ' Add the parameter for account number
            check.Parameters.AddWithValue("@accountno", accountno)

            ' Execute the command and retrieve the balance
            Dim balance As Object = check.ExecuteScalar()

            ' Check if the result is not null and return the balance as Decimal
            If balance IsNot DBNull.Value Then
                Return Convert.ToDecimal(balance)
            Else
                Return 0 ' Return 0 if no balance is found
            End If
        Catch ex As Exception
            ' Handle any errors that occur during the execution
            MessageBox.Show("Error: " & ex.Message)
            Return 0 ' Return 0 in case of an error
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Function


    Public Function checksharecap(accountno As String) As Decimal
        Try
            ' Ensure the connection is closed before opening it
            con.Close()
            con.Open()

            ' Define the SQL command to check balance
            Dim check As New MySqlCommand("SELECT 
            SUM(CASE WHEN `status` = 'ID' or status='CM' or status='CD' or status='ISC' or status='IPR' THEN `amount` ELSE 0 END) - 
            SUM(CASE WHEN `status` = 'DM' or status = 'CA' THEN `amount` ELSE 0 END) AS balance
            FROM `sharecap`
            WHERE `account_no` = @accountno", con)

            ' Add the parameter for account number
            check.Parameters.AddWithValue("@accountno", accountno)

            ' Execute the command and retrieve the balance
            Dim balance As Object = check.ExecuteScalar()

            ' Check if the result is not null and return the balance as Decimal
            If balance IsNot DBNull.Value Then
                Return Convert.ToDecimal(balance)
            Else
                Return 0 ' Return 0 if no balance is found
            End If
        Catch ex As Exception
            ' Handle any errors that occur during the execution
            MessageBox.Show("Error: " & ex.Message)
            Return 0 ' Return 0 in case of an error
        Finally
            con.Close() ' Ensure the connection is closed
        End Try
    End Function
    Public Sub Format_currency(column As String, dt As Object)
        ' Set currency format for Sharecap column in datagrid1
        If dt.Columns.Contains(column) Then
            dt.Columns(column).DefaultCellStyle.Format = "₱#,##0.00"
        End If
    End Sub
End Module
