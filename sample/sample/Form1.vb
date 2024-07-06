Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TextBox2.Click, TextBox1.Click, Button1.Click
        Label3.Text = TextBox2.Text & " "


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label3.Text = TextBox1.Text & " "
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit Apllication??", "Exit apllication ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub


End Class
