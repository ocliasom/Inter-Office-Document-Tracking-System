Imports MySql.Data.MySqlClient

Public Class Login

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sign_in.Click

        Dim Homepage As New Dashboard
        Dim Addpage As New AddDocument

        Dim command As New MySqlCommand("SELECT `username`,`password` FROM `user_login` WHERE `username` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username or Password")

        Else

            connection.Open()

            Dim command2 As New MySqlCommand("SELECT `office` FROM `user` WHERE `username` = @username ", connection)
            Dim reader As MySqlDataReader
            command2.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username.Text


            reader = command2.ExecuteReader()
            reader.Read()
            If reader.HasRows Then
                Homepage.Office = reader("office").ToString()
            End If




            Homepage.Show()
                Me.Hide()

            End If

    End Sub


End Class
