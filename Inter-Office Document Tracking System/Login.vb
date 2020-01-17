Imports MySql.Data.MySqlClient

Public Class Login

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim Homepage As New Dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sign_in.Click
        If Username.Text = "" Or Password.Text = "" Then
            MessageBox.Show("Please Fill in Empty Fields!")
        Else
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Try
                connection.Open()
                Dim query As String
                query = "select role from user_login where username = '" & Username.Text & "' and password = '" & Password.Text & "' "
                cmd = New MySqlCommand(query, connection)
                reader = cmd.ExecuteReader()

                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1

                End While
                If count = 1 Then
                    Dim usertype = reader.GetString("role")
                    If usertype = "admin" Then
                        connection.Close()

                        connection.Open()

                        Dim command2 As New MySqlCommand("SELECT `office` FROM `user` WHERE `username` = @username ", connection)
                        Dim reader2 As MySqlDataReader
                        command2.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username.Text


                        reader2 = command2.ExecuteReader()
                        reader2.Read()
                        If reader2.HasRows Then
                            Homepage.Office = reader2("office").ToString()
                        End If




                        Homepage.Show()
                        Me.Hide()
                    ElseIf usertype = "OFFICE" Then
                        Form1.Show()
                        Me.Hide()
                        connection.Close()
                    ElseIf usertype = "USER" Then
                        Homepage.Show()
                        Me.Hide()
                        connection.Close()
                    End If
                Else
                    MessageBox.Show("Invalid Username or Password")
                    connection.Close()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

End Class
