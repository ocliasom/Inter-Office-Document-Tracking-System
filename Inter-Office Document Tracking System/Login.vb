Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Login

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sign_in.Click
        If Username.Text = "" Or Password.Text = "" Then
            MessageBox.Show("Please Fill in Empty Fields!")
        Else
            Dim cmd As MySqlCommand
            Dim rolereader As MySqlDataReader
            Try
                connection.Open()
                Dim query As String
                'query = "select role from user_login where username = '" & Username.Text & "' and password = '" & GenerateSHA256String(Password.Text) & "' " FOR HASHING
                query = "select role from user_login where username = '" & Username.Text & "' and password = '" & Password.Text & "' "
                cmd = New MySqlCommand(query, connection)
                rolereader = cmd.ExecuteReader()

                Dim count As Integer = 0

                While rolereader.Read
                    count += 1

                End While
                If count = 1 Then
                    usertype = rolereader.GetString("role")
                    If usertype = "admin" Then
                        Dim AdminDocumentType As New AdminDocumentType
                        AdminDocumentType.Show()
                        Me.Close()
                        connection.Close()


                    ElseIf usertype = "OFFICE" Then
                        connection.Close()
                        connection.Open()

                        Dim command2 As New MySqlCommand("SELECT `office` FROM `user` WHERE `username` = @username ", connection)
                        Dim reader As MySqlDataReader
                        command2.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username.Text


                        reader = command2.ExecuteReader()
                        reader.Read()
                        If reader.HasRows Then
                            Office = reader("office").ToString()

                        End If

                        OfficeDashboard.Show()
                        Me.Close()
                        connection.Close()

                        'DEPARTMENTS
                    ElseIf usertype = "USER" Then
                        connection.Close()
                        connection.Open()

                        Dim command2 As New MySqlCommand("SELECT `office` FROM `user` WHERE `username` = @username ", connection)
                        Dim reader As MySqlDataReader
                        command2.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username.Text


                        reader = command2.ExecuteReader()
                        reader.Read()
                        If reader.HasRows Then
                            Office = reader("office").ToString()
                        End If
                        Dashboard.Show()
                        Me.Close()
                        connection.Close()
                    End If
                Else
                    MessageBox.Show("Invalid Username or Password")
                    connection.Close()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                connection.Dispose()
            End Try
        End If

    End Sub


    Public Shared Function GenerateSHA256String(ByVal inputString) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
