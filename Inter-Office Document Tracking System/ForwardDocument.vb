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







        Dim command As New MySqlCommand("SELECT * FROM `office`", connection)



        Dim adapter1 As New MySqlDataAdapter(command)
        Dim table1 As New DataTable()

        adapter1.Fill(table1)

        ComboBox1.DataSource = table1

        ComboBox1.DisplayMember = "officename"
        ComboBox1.ValueMember = "officecode"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


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
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class