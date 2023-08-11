Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim number As String = " "

        Dim numbers() As Integer = Array.ConvertAll(InputBox("Enter a set of numbers seperated by space: ", "input numbers").Split(number), Function(x) CInt(x))
        GetOddNumbers(numbers)
        GetEvenNumbers(numbers)

        Dim size = numbers.Length - 1
        For i As Integer = 0 To size Step 1
            lstDisplay.Items.Add(numbers(i))
        Next
    End Sub
    Function GetEvenNumbers(ByVal numbers() As Integer) As Integer()
        Dim evenNumbers() As Integer

        For Each num As Integer In numbers
            If num Mod 2 = 0 Then
                'num is even, add it to the evenNumbers array
                Dim index As Integer = 10
                ReDim Preserve evenNumbers(index)
                evenNumbers(index - 1) = num
                lstEven.Items.Add(num)
            End If
        Next
        Return evenNumbers
    End Function
    Function GetOddNumbers(ByVal numbers() As Integer) As Integer()
        Dim OddNumbers() As Integer

        For Each num As Integer In numbers
            If num Mod 3 = 0 Then
                'num is even, add it to the evenNumbers array
                Dim index As Integer = 10
                ReDim Preserve OddNumbers(index)
                OddNumbers(index - 1) = num
                lstOdd.Items.Add(num)
            End If
        Next
        Return OddNumbers
    End Function

End Class

