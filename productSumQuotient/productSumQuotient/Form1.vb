Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim num1 As Double = CDbl(txtFirstNum.Text)
        Dim num2 As Double = CDbl(txtSecondNum.Text)
        Dim result As Double

        ' Perform calculation based on selected radio button
        If radioSum.Checked Then
            result = num1 + num2
        ElseIf radioProduct.Checked Then
            result = num1 * num2
        ElseIf radioDiff.Checked Then
            If num1 > num2 Then
                result = num1 - num2
            Else
                result = num2 - num1
            End If
        ElseIf radioQuot.Checked Then
            If num1 > num2 Then
                result = num1 / num2
            Else
                result = num2 / num1
            End If
        End If

        ' Display result
        lblResults.Text = "Result: " & result.ToString()
    End Sub
End Class

