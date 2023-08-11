Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim unitPrice As Double
        Dim quantity As Integer

        ' Read input from user
        unitPrice = CDbl(txtUnitPrice.Text)
        quantity = CInt(txtQuantity.Text)

        discount(unitPrice, quantity)
    End Sub
    Function discount(ByVal price, ByVal quantity) As Double
        Dim totalAmount As Double
        Dim discountAmount As Double
        Dim discountedTotalAmount As Double
        totalAmount = price * quantity
        If totalAmount > 100 Then
            discountAmount = 0.15 * totalAmount
        Else
            discountAmount = 0.05 * totalAmount
        End If
        discountedTotalAmount = totalAmount - discountAmount
        lblResults.Text = discountedTotalAmount.ToString("C")

        Return totalAmount
    End Function
End Class
