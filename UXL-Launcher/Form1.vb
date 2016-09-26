Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Remember to actually make this code look good and put in all the code to make everything work right.

        'Make it so that I can show when this app was built right in the software itself.
        Dim InsertBuildDate As String = My.Resources.BuildDate
        TextBox1.Text = ("App compiled at UTC " + InsertBuildDate)
    End Sub

End Class
