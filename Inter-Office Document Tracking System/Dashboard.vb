Public Class Dashboard
    Public Property Office As String
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim AddPage As New AddDocument


        AddPage.Office = Label2.Text
        AddPage.Show()
        Me.Dispose()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label2.Text = Office


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TrackButton_Click(sender As Object, e As EventArgs) Handles TrackButton.Click
        Dim TrackPage As New TrackDocument

        TrackPage.Show()
        Me.Dispose()
    End Sub

    Private Sub PendingButton_Click(sender As Object, e As EventArgs) Handles PendingButton.Click
        Dim PendingPage As New PendingDocument

        PendingPage.Show()
        Me.Dispose()
    End Sub
End Class