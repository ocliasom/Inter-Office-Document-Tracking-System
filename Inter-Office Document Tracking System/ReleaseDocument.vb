Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class ReleaseDocument


    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand

    Private Sub ReleaseDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select trackingnum, doctype, remark, email_address, Number from document WHERE trackingnum ='" & trackingnum & "'"
            cmd = New MySqlCommand(Query, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            bind.DataSource = table
            DataGridView1.DataSource = bind
            adapter.Update(table)


            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try

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












    Private Sub Release_Click(sender As Object, e As EventArgs) Handles Release.Click
        Dim result As DialogResult = MessageBox.Show("Release Document?",
                            "Title",
                            MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try
                Dim Addpage As New AddDocument


                Dim command As New MySqlCommand("UPDATE `document` SET  status = @status , remark = @remark WHERE `trackingnum` = @trackingnum", connection)

                command.Parameters.AddWithValue("@trackingnum", trackingnum)
                command.Parameters.AddWithValue("@status", Status.Text)
                command.Parameters.AddWithValue("@remark", Remarks.Text)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()



                Dim results = itexmo(DataGridView1.Rows(0).Cells(3).Value, "Document has been released. Please claim it on your Department Office", "TR-INTER334992_FE7KH")
                If results = 0 Then
                    MsgBox("Message Sent!")
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
                e_mail.To.Add(DataGridView1.Rows(0).Cells(3).Value)
                e_mail.Subject = "Document Update"
                e_mail.Body = "Your document has been Forwarded"
                Smtp_server.Send(e_mail)
                MessageBox.Show("Document has been Released")

                'Yo Mavon, if nabasa mo ito, ginawa ko lang na comment muna yung email na part. highlight mo yung buong code sa email. CTRL + K then CTRL + U para mawala yung comment tag
                PendingDocument.Show()
                Me.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status.SelectedIndexChanged

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim result As DialogResult = MessageBox.Show("Cancel Releasing?",
                             "Cancel",
                             MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            PendingDocument.Show()
            Me.Close()
        End If

    End Sub
End Class