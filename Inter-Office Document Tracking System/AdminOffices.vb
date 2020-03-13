Imports MySql.Data.MySqlClient

Public Class AdminOffices


    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand
    Private Sub AdminOffices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select officecode,officename,officetype from `office`"
            cmd = New MySqlCommand(Query, connection)
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            bind.DataSource = table
            DataGridView1.DataSource = bind
            adapter.Update(table)


            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub OfficeAdd_Click(sender As Object, e As EventArgs) Handles OfficeAdd.Click
        AdminOfficesAdd.Show()
        Me.Close()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    Private Sub DocumentType_Click(sender As Object, e As EventArgs) Handles DocumentType.Click
        AdminDocumentType.Show()
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