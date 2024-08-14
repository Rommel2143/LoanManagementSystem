﻿Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Module Module1

    Public Function connection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=lms;password=Magnaye2143@#;database=lms")
        'Return New MySqlConnection("server=localhost;user id=Inventorysystem;password=admin@2024;database=trcsystem")
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
    'credentials of PC used
    Public idno As String

    Public PCname As String = Environment.MachineName
    Public PCmac As String = GetMacAddress()


    Public date1 As String = Date.Now.ToString("MMMM-dd-yyyy")
    Public datedb As String = Date.Now.ToString("yyyy-MM-dd")
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


    Public Sub display_form(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            Inventory_Mainframe.Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            con.Close()
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()

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
End Module
