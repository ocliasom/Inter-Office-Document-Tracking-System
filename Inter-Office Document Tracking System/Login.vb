Imports MySql.Data.MySqlClient

Public Class Login

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub
    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sign_in.Click

        Dim command As New MySqlCommand("SELECT `username`,`password` FROM `user_login` WHERE `username` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username or Password")

        Else

            MessageBox.Show("You are Logged in")


        End If

    End Sub


End Class
