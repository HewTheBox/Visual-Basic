Public Class Form1

    Dim sale, min, max, saleCount, totalSale As Double

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tax As Double = 0.02 * totalSale
        txtTax.Text = "GH₵ " + CStr(tax)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tax As Double = 0.05 * totalSale
        txtTax.Text = "GH₵ " + CStr(tax)
    End Sub

    Dim count As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Double.TryParse(txtSale.Text, sale)
        totalSale += sale
        txtTotalSale.Text = "GH₵ " + CStr(totalSale)

        txtMin.Text = "GH₵ " + CStr(getMin())
        txtMax.Text = "GH₵ " + CStr(getMax())
    End Sub

    'The Functions to calculate for min and max sales

    Private Function getMax() As Double
        Double.TryParse(txtSale.Text, sale)
        saleCount += 1
        If saleCount <= 1 Then
            max = sale
        Else
            If sale > max Then
                max = sale
            End If
        End If
        Return max
    End Function

    Private Function getMin() As Double
        Double.TryParse(txtSale.Text, sale)
        count += 1
        saleCount += 1
        If count <= 1 Then
            min = sale
        Else
            If sale < min Then
                min = sale
            End If
        End If
        Return min
    End Function
End Class
