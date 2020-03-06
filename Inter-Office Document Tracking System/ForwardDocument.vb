Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class ForwardDocument
    Public Property tracknum As String

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand
    Dim rolereader As MySqlDataReader

    Dim Homepage As New Dashboard
    Dim Adminpage As New AdminDashboard


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ForwardDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OfficeBox.Text = X

        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select trackingnum, doctype, date_received, description, source_office, email_address from document WHERE trackingnum ='" & tracknum & "'"
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

        tracking.Text = DataGridView1.Rows(0).Cells(5).Value







        Dim command As New MySqlCommand("SELECT * FROM `office` WHERE `officecode` NOT IN ('" & OfficeBox.Text & "')", connection)



        Dim adapter1 As New MySqlDataAdapter(command)
        Dim table1 As New DataTable()

        adapter1.Fill(table1)

        DestOffice.DataSource = table1

        DestOffice.DisplayMember = "officename"
        DestOffice.ValueMember = "officecode"


    End Sub

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click
        Dim result As DialogResult = MessageBox.Show("Forward Document?",
                              "Title",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try
                Dim Addpage As New AddDocument


                Dim command As New MySqlCommand("UPDATE `document` SET  forwarded_office = @office, status = @status , remark = @remark", connection)

                command.Parameters.AddWithValue("@office", DestOffice.Text)
                command.Parameters.AddWithValue("@status", "FORWARDED")
                command.Parameters.AddWithValue("@remark", Remarks.Text)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()


                'Dim cell As String = TextBox2.Text

                'Dim results = itexmo(cell, "Document Received Successfully!", "TR-INTER334992_FE7KH")
                'If results = 0 Then
                '    MsgBox("Message Sent!")
                'Else
                '    MsgBox("Error num " & results & " was encountered")
                'End If


                Dim Smtp_server As New SmtpClient
                Dim e_mail As New MailMessage
                Smtp_server.UseDefaultCredentials = False
                Smtp_server.Credentials = New Net.NetworkCredential("ocliasomavon@gmail.com", "Kiritetsuya1011")
                Smtp_server.Port = 587
                Smtp_server.EnableSsl = True
                Smtp_server.Host = "smtp.gmail.com"
                e_mail = New MailMessage
                e_mail.From = New MailAddress("PUP@gmail.com")
                e_mail.To.Add(tracking.Text)
                e_mail.Subject = "Document Update"
                e_mail.Body = "Your document has been Forwarded"
                Smtp_server.Send(e_mail)
                MessageBox.Show("Document has been Forwarded")

                'Yo Mavon, if nabasa mo ito, ginawa ko lang na comment muna yung email na part. highlight mo yung buong code sa email. CTRL + K then CTRL + U para mawala yung comment tag


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If



    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DestOffice.SelectedIndexChanged

    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim Pendingpage As New PendingDocument


    End Sub
End Class