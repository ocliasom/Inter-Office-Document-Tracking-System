Imports MySql.Data.MySqlClient


Public Class AdminOfficesAdd

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Private Sub AdminOfficesAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim result As DialogResult = MessageBox.Show("Add Office?",
                     "Title",
                     MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Try

                Dim checker As MySqlDataReader
                Dim checkcommand As New MySqlCommand("SELECT `officecode` FROM `office` WHERE `officecode`='" & OfficeCode.Text & "'", connection)
                connection.Open()
                checker = checkcommand.ExecuteReader()

                Dim count As Integer = 0

                While checker.Read
                    count += 1

                End While

                connection.Close()
                Dim checker2 As MySqlDataReader
                Dim checkcommand2 As New MySqlCommand("SELECT `officename` FROM `office` WHERE `officename`='" & OfficeName.Text & "'", connection)
                connection.Open()
                checker2 = checkcommand2.ExecuteReader()


                While checker2.Read
                    count += 1

                End While

                If count > 0 Then
                    connection.Close()
                    MessageBox.Show("The Office Already Exists!")

                Else
                    connection.Close()

                    Dim command As New MySqlCommand("INSERT INTO `office` (officecode,officename,officetype) values(@OfficeCode,@OfficeName,@OfficeType)", connection)

                    command.Parameters.AddWithValue("@OfficeCode", OfficeCode.Text)
                    command.Parameters.AddWithValue("@OfficeName", OfficeName.Text)
                    command.Parameters.AddWithValue("@OfficeType", OfficeType.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()

                    MessageBox.Show("Office has been added.")
                    AdminOffices.Show()
                    Me.Close()

                End If






            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
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


End Class