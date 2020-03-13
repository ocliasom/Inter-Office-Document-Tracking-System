Public Class Dashboard


    Private Sub AddButton_Click_1(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim AddDocument As New AddDocument

        AddDocument.Show()
        Me.Close()
    End Sub

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

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
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