﻿Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class AddDocument

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    'Public Property Office As String
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Datebox.Text = DateTime.Now.ToString("yyyy-MM-dd")
        HiddenDate.Text = DateTime.Now.ToString("yyyyMMdd")
    End Sub

    Private Sub AddDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Officebox.Text = Office


        Dim command As New MySqlCommand("SELECT * FROM `type` ", connection)



        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "doc_type"
        ComboBox1.ValueMember = "doc_abbrev"

    End Sub

    '########################################################################################
    'iTexmo API for C --> go to www.itexmo.com/developers.php for API Documentation
    '########################################################################################
    Function itexmo(ByVal Number As String, ByVal Message As String, ByVal API_CODE As String)
        Using client As New Net.WebClient
            Dim parameter As New Specialized.NameValueCollection
            Dim url As String = "https://www.itexmo.com/php_api/api.php"
            parameter.Add("1", Number)
            parameter.Add("2", Message)
            parameter.Add("3", API_CODE)
            Dim rpb = client.UploadValues(url, "POST", parameter)
            itexmo = (New System.Text.UTF8Encoding).GetString(rpb)
        End Using
    End Function
    '########################################################################################
    'API END     '###########################################################################
    '########################################################################################


    Private Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If emailaddresscheck(TextBox3.Text) = False Then
            MessageBox.Show("Please type the email correctly")

        ElseIf Number.Text.Length > 1 Then

            If Number.Text.Length <> 11 Then

                MessageBox.Show("Phone Number must be in 11 digit format.")

            Else 'IF NUMBER IS INPUTTED
                Dim result As DialogResult = MessageBox.Show("Add Document?",
                                          "Title",
                                          MessageBoxButtons.YesNo)

                If (result = DialogResult.Yes) Then
                    Try
                        Dim Addpage As New AddDocument


                        Dim command As New MySqlCommand("INSERT INTO `document` (trackingnum,current_office,date_received,description,doctype,source_office,status,email_address,number) values(@tracking,@office,@date,@description,@doctype,@source,@status,@email,@number)", connection)

                        command.Parameters.AddWithValue("@tracking", HiddenDate.Text)
                        command.Parameters.AddWithValue("@office", Officebox.Text)
                        command.Parameters.AddWithValue("@date", Datebox.Text)
                        command.Parameters.AddWithValue("@description", TextBox1.Text)
                        command.Parameters.AddWithValue("@doctype", ComboBox1.SelectedValue)
                        command.Parameters.AddWithValue("@source", Officebox.Text)
                        command.Parameters.AddWithValue("@status", "PENDING")
                        command.Parameters.AddWithValue("@email", TextBox3.Text)
                        command.Parameters.AddWithValue("@number", Number.Text)

                        connection.Open()
                        command.ExecuteNonQuery()
                        connection.Close()

                        Dim cell As String = Number.Text

                        Dim results = itexmo(cell, "Document Received Successfully!", "TR-MAVON636050_KG6XN")
                        If results = 0 Then
                            'MsgBox("Message Sent!")
                        Else
                            MsgBox("Error num " & results & " was encountered")
                        End If


                        Dim Smtp_server As New SmtpClient
                        Dim e_mail As New MailMessage
                        Smtp_server.UseDefaultCredentials = False
                        Smtp_server.Credentials = New Net.NetworkCredential("IODFSelecs3@gmail.com", "IODFStest123")
                        Smtp_server.Port = 587
                        Smtp_server.EnableSsl = True
                        Smtp_server.Host = "smtp.gmail.com"
                        e_mail = New MailMessage
                        e_mail.From = New MailAddress("PUP@gmail.com")
                        e_mail.To.Add(TextBox3.Text)
                        e_mail.Subject = "Document Update"
                        e_mail.Body = "Your document has been added"
                        Smtp_server.Send(e_mail)
                        MessageBox.Show("Document has been added")

                        'Yo Mavon, if nabasa mo ito, ginawa ko lang na comment muna yung email na part. highlight mo yung buong code sa email. CTRL + K then CTRL + U para mawala yung comment tag


                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If

            End If
        Else 'IF NUMBER IS NOT AVAILABLE

            Dim result As DialogResult = MessageBox.Show("Add Document?",
                             "Title",
                             MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then
                Try
                    Dim Addpage As New AddDocument


                    Dim command As New MySqlCommand("INSERT INTO `document` (trackingnum,current_office,date_received,description,doctype,source_office,status,email_address,number) values(@tracking,@office,@date,@description,@doctype,@source,@status,@email,@number)", connection)

                    command.Parameters.AddWithValue("@tracking", HiddenDate.Text)
                    command.Parameters.AddWithValue("@office", Officebox.Text)
                    command.Parameters.AddWithValue("@date", Datebox.Text)
                    command.Parameters.AddWithValue("@description", TextBox3.Text)
                    command.Parameters.AddWithValue("@doctype", ComboBox1.SelectedValue)
                    command.Parameters.AddWithValue("@source", Officebox.Text)
                    command.Parameters.AddWithValue("@status", "PENDING")
                    command.Parameters.AddWithValue("@email", TextBox3.Text)
                    command.Parameters.AddWithValue("@number", Number.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()


                    Dim Smtp_server As New SmtpClient
                    Dim e_mail As New MailMessage
                    Smtp_server.UseDefaultCredentials = False
                    Smtp_server.Credentials = New Net.NetworkCredential("IODFSelecs3@gmail.com", "IODFStest123")
                    Smtp_server.Port = 587
                    Smtp_server.EnableSsl = True
                    Smtp_server.Host = "smtp.gmail.com"
                    e_mail = New MailMessage
                    e_mail.From = New MailAddress("PUP@gmail.com")
                    e_mail.To.Add(TextBox3.Text)
                    e_mail.Subject = "Document Update"
                    e_mail.Body = "Your document has been added"
                    Smtp_server.Send(e_mail)
                    MessageBox.Show("Document has been added")

                    'Yo Mavon, if nabasa mo ito, ginawa ko lang na comment muna yung email na part. highlight mo yung buong code sa email. CTRL + K then CTRL + U para mawala yung comment tag




                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

        End If
        Dim AddDocumentDetails As New AddDocumentDetails

        AddDocumentDetails.Show()
        Me.Close()
    End Sub



    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dim result As DialogResult = MessageBox.Show("Cancel update?",
                             "Cancel",
                             MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            Dashboard.Show()
            'Dashboard.Label2.Text = Office
            Me.Close()
        End If
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Dim Dashboard As New Dashboard

        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub IncomingDocument_Click(sender As Object, e As EventArgs) Handles IncomingDocument.Click
        Dim IncomingDocument As New IncomingDocument


        IncomingDocument.Show()
        Me.Close()
    End Sub

    Private Sub PendingDocument_Click(sender As Object, e As EventArgs) Handles PendingDocument.Click
        Dim PendingDocument As New PendingDocument

        PendingDocument.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TrackDocument_Click(sender As Object, e As EventArgs) Handles TrackDocument.Click
        Dim TrackDocument As New TrackDocument

        TrackDocument.Show()
        Me.Close()
    End Sub
End Class