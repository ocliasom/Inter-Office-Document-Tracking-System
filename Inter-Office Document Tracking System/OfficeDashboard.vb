Public Class OfficeDashboard
    Private Sub TrackButton_Click(sender As Object, e As EventArgs) Handles TrackButton.Click
        Dim TrackDocument As New TrackDocument

        TrackDocument.Show()
        Me.Close()
    End Sub

    Private Sub PendingButton_Click(sender As Object, e As EventArgs) Handles PendingButton.Click
        Dim PendingDocument As New PendingDocument


        PendingDocument.Show()
        Me.Close()
    End Sub

    Private Sub IncomingButton_Click(sender As Object, e As EventArgs) Handles IncomingButton.Click
        Dim IncomingDocument As New IncomingDocument


        IncomingDocument.Show()
        Me.Close()
    End Sub
End Class