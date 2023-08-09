Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim number1 As Integer = 2
        Dim number2 As Integer = 1
        Dim result As Integer

        Select Case True
            Case rdbSum.Checked
                result = number1 + number2

            Case rdbProduct.Checked
                result = number1 * number2

            Case rdbQuotient.Checked
                result = number1 / number2

            Case rdbDifference.Checked
                result = number1 - number2

        End Select
        txtResult.Text = result.ToString


    End Sub
End Class
