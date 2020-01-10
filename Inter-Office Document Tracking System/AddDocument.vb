Imports MySql.Data.MySqlClient
Public Class AddDocument

    Public Property Office As String
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Datebox.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub AddDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Officebox.Text = Office
    End Sub

    Private Sub Datebox_Click(sender As Object, e As EventArgs) Handles Datebox.Click




    End Sub

    Private Sub Officebox_Click(sender As Object, e As EventArgs) Handles Officebox.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class