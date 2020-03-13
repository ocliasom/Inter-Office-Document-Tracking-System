Public Class Refresh
    Private Sub Refresh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Previous = "ADD" Then
            Dim AddDocument As New AddDocument

            AddDocument.Show()
            Me.Close()

        ElseIf Previous = "INCOMING" Then

            Dim IncomingDocument As New IncomingDocument

            IncomingDocument.Show()
            Me.Close()
        End If

    End Sub
End Class