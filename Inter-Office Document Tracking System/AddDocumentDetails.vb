Imports MySql.Data.MySqlClient


Public Class AddDocumentDetails
    Private Sub AddDocumentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
        Dim cmd As MySqlCommand
        Dim rolereader As MySqlDataReader

        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select trackingnum,doctype,date_received,source_office,description from document WHERE id in (select max(id) from document)"
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

    Private Sub AddDocButton_Click(sender As Object, e As EventArgs) Handles AddDocButton.Click
        Dim AddDocument As New AddDocument

        AddDocument.Show()
        Me.Close()
    End Sub

    Private Sub TrackDocButton_Click(sender As Object, e As EventArgs) Handles TrackDocButton.Click
        Dim TrackDocument As New TrackDocument

        TrackDocument.Show()
        Me.Close()
    End Sub
End Class