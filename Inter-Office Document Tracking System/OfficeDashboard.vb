Public Class OfficeDashboard
    Private Sub TrackButton_Click(sender As Object, e As EventArgs) Handles TrackButton.Click

        TrackPage.Show()
        Me.Close()
    End Sub

    Private Sub PendingButton_Click(sender As Object, e As EventArgs) Handles PendingButton.Click

        PendingPage.Show()
        Me.Close()
    End Sub

    Private Sub IncomingButton_Click(sender As Object, e As EventArgs) Handles IncomingButton.Click
        IncomingPage.Show()
        Me.Close()
    End Sub
End Class