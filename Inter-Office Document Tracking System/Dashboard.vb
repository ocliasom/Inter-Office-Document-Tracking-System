Public Class Dashboard


    Private Sub AddButton_Click_1(sender As Object, e As EventArgs) Handles AddButton.Click

        AddDocument.Show()
        Me.Close()
    End Sub

    Private Sub TrackButton_Click(sender As Object, e As EventArgs) Handles TrackButton.Click

        TrackDocument.Show()
        Me.Close()
    End Sub

    Private Sub PendingButton_Click(sender As Object, e As EventArgs) Handles PendingButton.Click

        PendingDocument.Show()
        Me.Close()
    End Sub

    Private Sub IncomingButton_Click(sender As Object, e As EventArgs) Handles IncomingButton.Click

        IncomingDocument.Show()
        Me.Close()
    End Sub


End Class