
Public Class Form1
    ' Declare a class-level variable for subSale
    Private subSale As Double = 0.0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare variables for item, price, tax, and total
        Dim item As String = txtItem.Text
        Dim price, tax, total As Double
        Dim product As String


        ' Try to parse the price from the input text box
        Double.TryParse(txtPrice.Text, price)
        'assign product and price to product
        product = "          " & item & "                                    ||                         " & FormatCurrency(price)


        ' Add the item and price to the list box
        lstListBox.Items.Add(product)

        ' Update the subtotal with the price of the new item
        subSale += price

        ' Calculate the tax and total
        tax = 0.062 * subSale
        total = subSale + tax

        ' Display the subtotal, tax, and total in their respective text boxes
        txtSubSale.Text = FormatCurrency(subSale.ToString)
        txtTax.Text = FormatCurrency(tax.ToString)
        txtTotal.Text = FormatCurrency(total.ToString)

        ' Clear the item and price text boxes for the next input
        txtItem.Text = ""
        txtPrice.Text = ""

        ' Set the focus to the item text box
        txtItem.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the header to the list box
        lstListBox.Items.Add("          PRODUCT                       ||                       PRICE")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
