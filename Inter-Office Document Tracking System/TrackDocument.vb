Imports MySql.Data.MySqlClient

Public Class TrackDocument

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=iods")
    Dim cmd As MySqlCommand







    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TrackDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usertype <> "USER" Then

            AddDocButton.Visible = False

        End If
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim bind As New BindingSource

        Try
            connection.Open()
            Dim Query As String
            Query = "select trackingnum, doctype, current_office, date_received, status from `document`"
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



        Dim Date1 = DateTime.Now.ToString("yyyy-MM-dd")
        Dim dates1 As Date = Date.ParseExact(Date1, "yyyy-MM-dd",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)



        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim Date2 = row.Cells(3).Value

            Dim dates2 As Date = Date.ParseExact(Date2, "yyyy-MM-dd",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)

            If (dates1 - dates2).Days > 3 And (dates1 - dates2).Days < 7 Then
                row.Cells(3).Style.BackColor = Color.Yellow

            ElseIf (dates1 - dates2).Days > 6 Then
                row.Cells(3).Style.BackColor = Color.Red

            End If
        Next

        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)


        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
       e.RowIndex >= 0 Then
            MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        End If


    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click

        If usertype = "OFFICE" Then

            Dim OfficeDashboard As New OfficeDashboard

            OfficeDashboard.Show()
            Me.Close()

        Else
            Dim Dashboard As New Dashboard

            Dashboard.Show()
            Me.Close()

        End If



    End Sub

    Private Sub AddDocButton_Click(sender As Object, e As EventArgs) Handles AddDocButton.Click
        Dim AddDocument As New AddDocument

        AddDocument.Show()
        Me.Close()
    End Sub

    Private Sub IncomingDocument_Click(sender As Object, e As EventArgs) Handles IncomingDocument.Click
        Dim IncomingDocument As New IncomingDocument

        IncomingDocument.Show()
        Me.Close()
    End Sub

    Private Sub PendingDocument_Click(sender As Object, e As EventArgs) Handles PendingDocument.Click
        Dim PendingDocument As New PendingDocument

        PendingDocument.Show()
        Me.Close()
    End Sub

End Class