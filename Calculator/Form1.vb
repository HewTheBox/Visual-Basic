Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim word As String
        word = txtInput.Text
        word = InputBox("")
        MsgBox(word)
    End Sub
End Class
