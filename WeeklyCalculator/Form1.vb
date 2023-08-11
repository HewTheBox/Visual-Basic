Public Class Form1
    Dim sales As Decimal
    Dim totalSale As String
    Dim numbers As New List(Of Double)
    Dim number As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sales = txtSales.Text
        totalSale = sales + totalSale
        txtTotalSales.Text = "GHC " + CStr(totalSale)

        If Double.TryParse(sales, number) Then
            numbers.Add(number)
            txtMaximum.Text = "GHC " + CStr(findMaxValue(numbers))
            txtMinimum.Text = "GHC " + CStr(findMinValue(numbers))
        End If
    End Sub
    Private Function findMaxValue(numbers As List(Of Double)) As Double
        Dim maxValue As Double = Double.MinValue
        For Each number In numbers

            If number > maxValue Then
                maxValue = number
            End If
        Next
        Return maxValue
    End Function
    Private Function findMinValue(numbers As List(Of Double)) As Double
        Dim minValue As Double = Double.MaxValue
        For Each number In numbers
            If number < minValue Then
                minValue = number
            End If
        Next
        Return minValue
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tax As Decimal
        tax = 0.02 * totalSale
        txtTax.Text = "GHC " + CStr(tax)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tax As Decimal
        tax = 0.05 * totalSale
        txtTax.Text = "GHC " + CStr(tax)
    End Sub
End Class
