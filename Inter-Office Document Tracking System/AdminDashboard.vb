Public Class AdminDashboard

    Dim X As Integer = 0
    Private Sub Logs_Click(sender As Object, e As EventArgs) Handles Logs.Click

        If X = 0 Then
            UserLogs.Visible = True
            DocHistory.Visible = True
            X = 1

        Else
            X = 0
            UserLogs.Visible = False
            DocHistory.Visible = False
        End If


    End Sub


    Private Sub DocumentType_Click(sender As Object, e As EventArgs) Handles DocumentType.Click
        AdminDocumentType.Show()
        Me.Close()
    End Sub

    Private Sub Offices_Click(sender As Object, e As EventArgs) Handles Offices.Click
        AdminOffices.Show()
        Me.Close()
    End Sub

    Private Sub UserInfo_Click(sender As Object, e As EventArgs) Handles UserInfo.Click
        AdminUserInfo.Show()
        Me.Close()
    End Sub

    Private Sub UserLogs_Click(sender As Object, e As EventArgs) Handles UserLogs.Click
        AdminUserLogs.Show()
        Me.Close()
    End Sub

    Private Sub DocHistory_Click(sender As Object, e As EventArgs) Handles DocHistory.Click
        AdminDocumentHistory.Show()
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