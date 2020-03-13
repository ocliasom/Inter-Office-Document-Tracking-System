Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class IncomingDocument
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand

    Private Sub IncomingDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If usertype <> "USER" Then

            AddDocument.Visible = False

        End If

        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select trackingnum, doctype, current_office,remark,email_address,Number from document WHERE forwarded_office ='" & Office & "' AND status = 'FORWARDED'"
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







    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        If usertype = "OFFICE" Then

            Dim OfficeDashboard As New OfficeDashboard

            OfficeDashboard.Show()
            Me.Close()

        Else
            Dim Dashboard As New Dashboard

            Dashboard.Show()
            Me.Close()

        End If
    End Sub

    Private Sub AddDocument_Click(sender As Object, e As EventArgs) Handles AddDocument.Click
        Dim AddDocument As New AddDocument

        AddDocument.Show()
        Me.Close()
    End Sub

    Private Sub PendingDocument_Click(sender As Object, e As EventArgs) Handles PendingDocument.Click
        Dim PendingDocument As New PendingDocument

        PendingDocument.Show()
        Me.Close()
    End Sub

    Private Sub TrackDocument_Click(sender As Object, e As EventArgs) Handles TrackDocument.Click
        Dim TrackDocument As New TrackDocument

        TrackDocument.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)


        If e.ColumnIndex = 6 AndAlso
       e.RowIndex >= 0 Then

            Dim result As DialogResult = MessageBox.Show("Receive Document?",
                              "Title",
                              MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then
                Try
                    Dim Addpage As New AddDocument

                    trackingnum = DataGridView1.Rows(e.RowIndex).Cells(0).Value

                    Dim command As New MySqlCommand("UPDATE `document` SET `current_office` = @office , `status` = @status WHERE trackingnum=@tracking", connection)

                    command.Parameters.AddWithValue("@tracking", trackingnum)
                    command.Parameters.AddWithValue("@office", Office)
                    command.Parameters.AddWithValue("@status", "PENDING")

                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()


                    Dim results = itexmo(DataGridView1.Rows(e.RowIndex).Cells(5).Value, "Document " & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "Received Successfully by " & Office, "TR-MAVON636050_KG6XN")
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
                    e_mail.To.Add(DataGridView1.Rows(e.RowIndex).Cells(4).Value)
                    e_mail.Subject = "Document Update"
                    e_mail.Body = "Your document " & DataGridView1.Rows(e.RowIndex).Cells(0).Value & " has been received by " & Office
                    Smtp_server.Send(e_mail)

                    'Yo Mavon, if nabasa mo ito, ginawa ko lang na comment muna yung email na part. highlight mo yung buong code sa email. CTRL + K then CTRL + U para mawala yung comment tag

                    MessageBox.Show("Document Received")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If


        End If




    End Sub
End Class