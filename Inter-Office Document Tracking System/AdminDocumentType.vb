Imports MySql.Data.MySqlClient

Public Class AdminDocumentType

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand
    Private Sub AdminDocumentType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select doc_abbrev, doc_type from `type`"
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

    Private Sub DocumentType_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.ClearSelection()
    End Sub

    Private Sub TypeAdd_Click(sender As Object, e As EventArgs) Handles TypeAdd.Click
        AdminDocumentTypeAdd.Show()
        Me.Close()
    End Sub


    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        AdminDashboard.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to logout??",
                     "Cancel",
                     MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then

            Login.Show()
            'Dashboard.Label2.Text = Office
            Me.Close()
        End If
    End Sub
End Class