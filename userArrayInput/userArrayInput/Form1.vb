Public Class Form1
    Dim arr(9) As Integer ' declare an array of size 10
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        ' input the array values from the user using an input box
        For i = 0 To 9
            arr(i) = CInt(InputBox("Enter value for element " & i + 1))
        Next

        ' display the original array in the list box
        For i = 0 To 9
            lstOriginal.Items.Add(arr(i))
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim sumEven As Integer = 0
        Dim productOdd As Integer = 1

        ' calculate the sum of all even numbers and the product of all odd numbers
        For i = 0 To 9
            If arr(i) Mod 2 = 0 Then ' check if the number is even
                sumEven += arr(i)
            Else
                productOdd *= arr(i)
            End If
        Next

        ' display the results in the text boxes
        txtSumEven.Text = sumEven.ToString()
        txtProductOdd.Text = productOdd.ToString()
    End Sub
End Class
