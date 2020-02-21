Public Class Dashboard
    Public Property Office As String
    Private Sub AddButton_Click(sender As Object, e As EventArgs)
        Dim AddPage As New AddDocument


        AddPage.Office = Label2.Text
        AddPage.Show()
        Me.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Label2.Text = Office


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TrackButton_Click(sender As Object, e As EventArgs)
        Dim TrackPage As New TrackDocument

        TrackPage.Show()
        Me.Close()
    End Sub

    Private Sub PendingButton_Click(sender As Object, e As EventArgs)
        Dim PendingPage As New PendingDocument

        PendingPage.Show()
        Me.Close()
    End Sub

    Private Sub AddButton_Click_1(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim AddPage As New AddDocument


        AddPage.Office = Label2.Text
        AddPage.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim TrackPage As New TrackDocument

        TrackPage.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim PendingPage As New PendingDocument

        PendingPage.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class