Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim radius, base, lenght, width, area As Double

        radius = txtRadius.Text
        base = txtBase.Text
        lenght = txtLenght.Text
        width = txtWidth.Text
        base = txtBase.Text

        'Calculate area based on selected figure
        Select Case True
            Case radioCircle.Checked
                area = Math.PI * radius * radius
            Case radioTriangle.Checked
                area = 0.5 * base * Height
            Case radioRectangle.Checked
                area = lenght * width
        End Select

        'Display area in label
        lblArea.Text = "Area: " & area.ToString("F2")

    End Sub
End Class
