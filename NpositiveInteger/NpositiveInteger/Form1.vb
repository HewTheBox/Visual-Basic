Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim N As Integer = Val(txtLimit.Text)
        Dim sum As Double = 0

        For i As Integer = 1 To N
            sum += 1 / i
        Next

        txtResults.Text = "Sum: " & sum.ToString("F2")
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Dim N As Integer = Val(txtLimit.Text)
        Dim product As Double = 1

        For i As Integer = 1 To N
            product *= 1 / i
        Next

        txtResults.Text = "Product: " & product.ToString("F2")
    End Sub
End Class
