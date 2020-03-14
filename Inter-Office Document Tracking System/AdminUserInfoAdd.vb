Imports MySql.Data.MySqlClient

Imports System.Text
Imports System.Security.Cryptography
Public Class AdminUserInfoAdd
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
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

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim result As DialogResult = MessageBox.Show("Add User?",
                    "Title",
                    MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try

                Dim checker As MySqlDataReader
                Dim checkcommand As New MySqlCommand("SELECT `username` FROM `user` WHERE `username`='" & UserName.Text & "'", connection)
                connection.Open()
                checker = checkcommand.ExecuteReader()

                Dim count As Integer = 0

                While checker.Read
                    count += 1

                End While

                If count > 0 Then
                    connection.Close()
                    MessageBox.Show("The User Already Exists!")

                Else
                    connection.Close()

                    Dim command As New MySqlCommand("INSERT INTO `user` (name,username,office,email,lname,fullname) values(@FirstName,@UserName,@Office,@Email,@Lname,@Fullname)", connection)

                    command.Parameters.AddWithValue("@FirstName", FirstName.Text)
                    command.Parameters.AddWithValue("@UserName", UserName.Text)
                    command.Parameters.AddWithValue("@Office", Office.Text)
                    command.Parameters.AddWithValue("@Email", Email.Text)
                    command.Parameters.AddWithValue("Lname", LastName.Text)
                    command.Parameters.AddWithValue("@Fullname", FirstName.Text & " " & LastName.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                    Dim command2 As New MySqlCommand("INSERT INTO `user_login` (username,password,role) values(@username,@password,@role)", connection)

                    command2.Parameters.AddWithValue("@username", UserName.Text)
                    command2.Parameters.AddWithValue("@password", GenerateSHA256String(Password.Text))
                    command2.Parameters.AddWithValue("@role", Role.Text)

                    connection.Open()
                    command2.ExecuteNonQuery()
                    connection.Close()



                    MessageBox.Show("User has been added.")
                    AdminUserInfo.Show()
                    Me.Close()

                End If






            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub


    Private Sub Home_Click(sender As Object, e As EventArgs)
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub DocumentType_Click(sender As Object, e As EventArgs) Handles DocumentType.Click
        AdminDocumentType.Show()
        Me.Close()
    End Sub

    Private Sub Offices_Click(sender As Object, e As EventArgs) Handles Offices.Click
        AdminOffices.Show()
        Me.Close()
    End Sub

    Private Sub UserInfo_Click(sender As Object, e As EventArgs) Handles UserInfo.Click
        AdminUserInfo.Show()
        Me.Close()
    End Sub

    Private Sub UserLogs_Click(sender As Object, e As EventArgs) Handles UserLogs.Click
        AdminUserLogs.Show()
        Me.Close()
    End Sub

    Private Sub DocHistory_Click(sender As Object, e As EventArgs) Handles DocHistory.Click
        AdminDocumentHistory.Show()
        Me.Close()
    End Sub


    Dim X As Integer = 0
    Private Sub Logs_Click(sender As Object, e As EventArgs) Handles Logs.Click

        If X = 0 Then
            UserLogs.Visible = True
            DocHistory.Visible = True
            X = 1

        Else
            X = 0
            UserLogs.Visible = False
            DocHistory.Visible = False
        End If


    End Sub


    Private Sub AdminUserInfoAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand("SELECT `officecode`,`officename` FROM `office` ", connection)



        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        Office.DataSource = table

        Office.DisplayMember = "officename"
        Office.ValueMember = "officecode"
    End Sub
End Class