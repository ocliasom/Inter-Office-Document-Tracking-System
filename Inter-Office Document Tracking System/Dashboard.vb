Public Class Dashboard
    Public Property Office As String
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim AddPage As New AddDocument


        AddPage.Office = Label2.Text
        AddPage.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AddPage As New AddDocument

        Label2.Text = Office


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?",
                              "Logout",
                              MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Login.Show()
            Me.Hide()
        End If

    End Sub
End Class