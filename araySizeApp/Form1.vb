Public Class Form1

    Dim size As Integer = CInt(InputBox("Enter the size of the array: "))
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim orignalArrray() As Integer

        For i As Integer = 0 To size Step 1
            ReDim Preserve orignalArrray(size)
            orignalArrray(i) = CInt(InputBox("Enter the item for index " & i))
            lstOriginal.Items.Add(orignalArrray(i))
        Next
        MessageBox.Show(orignalArrray.Length)


        getEven(orignalArrray)
        getOdd(orignalArrray)
    End Sub
    Function getEven(ByVal even() As Integer) As Integer
        Dim evenNumbers() As Integer
        For Each num In even
            If num Mod 2 = 0 Then
                ReDim Preserve evenNumbers(size)
                evenNumbers(size - 1) = num
                lstEven.Items.Add(num)
            End If

        Next
        Return evenNumbers(size)
    End Function
    Function getOdd(ByVal Odd() As Integer) As Integer
        Dim OddNumbers() As Integer
        For Each num In Odd
            If num Mod 3 = 0 Then
                ReDim Preserve OddNumbers(size)
                OddNumbers(size - 1) = num
                lstOdd.Items.Add(num)
            End If

        Next
        Return OddNumbers(size)
    End Function
End Class
