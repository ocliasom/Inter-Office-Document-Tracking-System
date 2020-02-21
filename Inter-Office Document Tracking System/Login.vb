Imports MySql.Data.MySqlClient

Public Class Login

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim Homepage As New Dashboard
    Dim Adminpage As New AdminDashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sign_in.Click
        If Username.Text = "" Or Password.Text = "" Then
            MessageBox.Show("Please Fill in Empty Fields!")
        Else
            Dim cmd As MySqlCommand
            Dim rolereader As MySqlDataReader
            Try
                connection.Open()
                Dim query As String
                query = "select role from user_login where username = '" & Username.Text & "' and password = '" & Password.Text & "' "
                cmd = New MySqlCommand(query, connection)
                rolereader = cmd.ExecuteReader()

                Dim count As Integer
                count = 0
                While rolereader.Read
                    count = count + 1

                End While
                If count = 1 Then
                    Dim usertype = rolereader.GetString("role")
                    If usertype = "admin" Then
                        Adminpage.Show()
                        Me.Hide()
                        connection.Close()
                    ElseIf usertype = "OFFICE" Then
                        Adminpage.Show()
                        Me.Hide()
                        connection.Close()
                    ElseIf usertype = "USER" Then
                        connection.Close()
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
                        Me.Close()
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
