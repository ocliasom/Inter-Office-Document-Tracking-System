Imports MySql.Data.MySqlClient
Public Class AddDocument

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Public Property Office As String



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
        Dim result As DialogResult = MessageBox.Show("Confirm update?",
                              "Title",
                              MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Dim Addpage As New AddDocument


            Dim command As New MySqlCommand("INSERT INTO `document` (current_office,date_received,description,doctype,source_office,status) values(@office,@date,@description,@doctype,@source,@status)", connection)

            command.Parameters.AddWithValue("@office", Officebox.Text)
            command.Parameters.AddWithValue("@date", Datebox.Text)
            command.Parameters.AddWithValue("@description", TextBox3.Text)
            command.Parameters.AddWithValue("@doctype", ComboBox1.SelectedValue)
            command.Parameters.AddWithValue("@source", Officebox.Text)
            command.Parameters.AddWithValue("@status", "pending")

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            Dim cell As String = TextBox1.Text

            Dim results = itexmo(cell, "Document Received Successfully!", "TR-INTER334992_FE7KH")
            If results = 0 Then
                MsgBox("Message Sent!")
            Else
                MsgBox("Error num " & results & " was encountered")
            End If

        Else

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Cancel update?",
                              "Cancel",
                              MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            Dashboard.Show()
            Me.Hide()
        End If

    End Sub

End Class