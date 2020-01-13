Imports MySql.Data.MySqlClient
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

    Private Sub Datebox_Click(sender As Object, e As EventArgs) Handles Datebox.Click




    End Sub

    Private Sub Officebox_Click(sender As Object, e As EventArgs) Handles Officebox.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

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

        Else

        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class