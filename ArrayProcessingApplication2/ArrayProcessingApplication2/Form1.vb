Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the size of the array from the user
        ' Dim size As Integer = InputBox("Enter the size of the array:")
        Dim size As Integer = txtArraySize.Text


        ' Create the original array and fill it with random numbers
        Dim originalArray(size - 1) As Integer
        Dim rand As New Random()
        For i As Integer = 0 To size - 1
            originalArray(i) = rand.Next(1, 101)
        Next

        ' Display the original array
        ListBox1.Items.Clear()
        For Each num As Integer In originalArray
            ListBox1.Items.Add(num)
        Next

        ' Call the functions to generate the odd and even arrays
        Dim oddArray() As Integer = GetOddArray(originalArray)
        Dim evenArray() As Integer = GetEvenArray(originalArray)

        ' Display the odd and even arrays
        ListBox2.Items.Clear()
        For Each num As Integer In oddArray
            ListBox2.Items.Add(num)
        Next

        ListBox3.Items.Clear()
        For Each num As Integer In evenArray
            ListBox3.Items.Add(num)
        Next
    End Sub

    ' Function to get an array of only odd numbers from the original array
    Private Function GetOddArray(originalArray() As Integer) As Integer()
        Dim oddList As New List(Of Integer)
        For Each num As Integer In originalArray
            If num Mod 2 = 1 Then
                oddList.Add(num)
            End If
        Next
        Return oddList.ToArray()
    End Function

    ' Function to get an array of only even numbers from the original array
    Private Function GetEvenArray(originalArray() As Integer) As Integer()
        Dim evenList As New List(Of Integer)
        For Each num As Integer In originalArray
            If num Mod 2 = 0 Then
                evenList.Add(num)
            End If
        Next
        Return evenList.ToArray()
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtArraySize.TextChanged

    End Sub
End Class
