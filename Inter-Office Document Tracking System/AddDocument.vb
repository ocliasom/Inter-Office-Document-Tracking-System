Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class AddDocument

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Public Property Office As String
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Datebox.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub AddDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Officebox.Text = Office


        Dim command As New MySqlCommand("SELECT * FROM `type`", connection)



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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Add Document?",
                              "Title",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try
                Dim Addpage As New AddDocument


                Dim command As New MySqlCommand("INSERT INTO `document` (current_office,date_received,description,doctype,source_office,status,email_address) values(@office,@date,@description,@doctype,@source,@status,@email)", connection)

                command.Parameters.AddWithValue("@office", Officebox.Text)
                command.Parameters.AddWithValue("@date", Datebox.Text)
                command.Parameters.AddWithValue("@description", TextBox3.Text)
                command.Parameters.AddWithValue("@doctype", ComboBox1.SelectedValue)
                command.Parameters.AddWithValue("@source", Officebox.Text)
                command.Parameters.AddWithValue("@status", "pending")
                command.Parameters.AddWithValue("@email", TextBox3.Text)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()

                Dim cell As String = TextBox2.Text

                Dim results = itexmo(cell, "Document Received Successfully!", "TR-INTER334992_FE7KH")
                If results = 0 Then
                    MsgBox("Message Sent!")
                Else
                    MsgBox("Error num " & results & " was encountered")
                End If


                Dim Smtp_server As New SmtpClient
                Dim e_mail As New MailMessage
                Smtp_server.UseDefaultCredentials = False
                Smtp_server.Credentials = New Net.NetworkCredential("ocliasomavon@gmail.com", "Kiritetsuya1011")
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
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Cancel update?",
                             "Cancel",
                             MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            Dashboard.Show()
            Dashboard.Label2.Text = Office
            Me.Hide()
        End If
    End Sub
End Class