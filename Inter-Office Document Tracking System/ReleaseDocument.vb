Imports MySql.Data.MySqlClient
Public Class ReleaseDocument
    Public Property tracknum As String

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand
    Dim Homepage As New Dashboard
    Dim Adminpage As New AdminDashboard
    Private Sub ReleaseDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource
        tracking.Text = tracknum
        Try
            connection.Open()
            Dim Query As String
            Query = "select trackingnum, doctype, date_received, description, source_office from document WHERE trackingnum ='" & tracking.Text & "'"
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

End Class