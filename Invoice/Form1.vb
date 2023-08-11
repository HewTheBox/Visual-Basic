Public Class Form1
    Dim subsale, tax, total, price As Double
    'This function is suppose to end the execution of the program
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    'This is the form function, this information will be added at runtime
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBox.Items.Add("PRODUCT      ||          PRICE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim output, item As String

        item = txtItem.Text
        price = CDbl(txtPrice.Text)
        output = item & "                 ||                " & FormatCurrency(price)
        lstBox.Items.Add(output)

        'calculation for subSale,tax and total
        subsale += price '//the same as: subsale = subsale + price
        tax = (0.062 * subsale)
        total = tax + subsale

        'Printing subsale,tax and total out
        txtSubTotal.Text = FormatCurrency((subsale).ToString)
        txtTax.Text = FormatCurrency((tax).ToString)
        txtTotal.Text = FormatCurrency((total).ToString)

        'clearing the text box
        txtItem.Text = ""
        txtPrice.Text = ""

        'setting the focus on txtItem
        txtItem.Focus()
    End Sub
End Class
