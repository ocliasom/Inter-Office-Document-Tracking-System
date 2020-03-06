Imports MySql.Data.MySqlClient

Public Class PendingDocument
    'Public Property Offices As String
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand
    Dim Homepage As New Dashboard
    Dim ForwardPage As New ForwardDocument
    Dim ReleasePage As New ReleaseDocument
    Private Sub PendingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (X <> "CPE Department") Then

            DataGridView1.Columns(6).Visible = False


        End If

        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select trackingnum, doctype, date_received, source_office, description from `document`"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)


        If e.ColumnIndex = 5 AndAlso
       e.RowIndex >= 0 Then

            ForwardPage.tracknum = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            ForwardPage.Show()
            Me.Close()

        ElseIf e.ColumnIndex = 6 AndAlso
       e.RowIndex >= 0 Then

            ReleasePage.tracknum = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            ReleasePage.Show()
            Me.Close()
        End If

    End Sub

    Private Sub OfficeBox_Click(sender As Object, e As EventArgs)

    End Sub


End Class