Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text = txtInput.Text
        lblLabel.Text = text
    End Sub
End Class
