Public Class Dashboard
    Public Property Office As String
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim AddPage As New AddDocument


        AddPage.Office = Label2.Text
        AddPage.Show()
        Me.Dispose()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AddPage As New AddDocument

        Label2.Text = Office


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TrackButton_Click(sender As Object, e As EventArgs) Handles TrackButton.Click
        Dim TrackPage As New TrackDocument

        TrackDocument.Show()
        Me.Dispose()
    End Sub
End Class