Public Class Form1
    'Variables
    Dim Sales1 As Double
    Dim numbers As New List(Of Double)
    Dim sales As Decimal
    Dim totalSale As Decimal
    Dim tax As Decimal
    Dim minimumSale As Decimal
    Dim maximumSale As Decimal
    Dim compare As String
    Dim seperator As Char = ","c

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAddSales_Click(sender As Object, e As EventArgs) Handles btnAddSales.Click
        sales = txtAddSales.Text
        totalSale = sales + totalSale
        txtTotalSales.Text = "GHC " + CStr(totalSale)
        txtMaximumSale.Text = compare
        Sales1 = txtAddSales.Text

        If Double.TryParse(sales, Sales1) Then
            numbers.Add(Sales1)
            txtMaximumSale.Text = "GHC " + CStr(FindMaxValue(numbers))
            txtMinimumSale.Text = "GHC " + CStr(FindMinValue(numbers))
        End If
        'compare += CStr(sales) + ","
        'Dim compareArray() As String = compare.Split(seperator)

    End Sub
    Private Function FindMaxValue(numbers As List(Of Double)) As Double
        Dim maxValue As Double = Double.MinValue
        For Each number In numbers
            If number > maxValue Then
                maxValue = number
            End If
        Next
        Return maxValue
    End Function

    Private Function FindMinValue(numbers As List(Of Double)) As Double
        Dim minValue As Double = Double.MaxValue
        For Each number In numbers
            If number < minValue Then
                minValue = number
            End If
        Next
        Return minValue
    End Function




    Private Sub btnTwoPercent_Click(sender As Object, e As EventArgs) Handles btnTwoPercent.Click
        Dim taxAmount As Decimal
        taxAmount = 0.02
        taxAmount = taxAmount * totalSale
        txtTax.Text = "GHC " + CStr(taxAmount)


    End Sub

    Private Sub bntFivePercent_Click(sender As Object, e As EventArgs) Handles bntFivePercent.Click
        Dim taxAmount As Decimal
        taxAmount = 0.05
        taxAmount = taxAmount * totalSale
        txtTax.Text = "GHC " + CStr(taxAmount)
    End Sub

End Class
