Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim beta As Double
        Dim z As Double

        ' Read input from user
        a = CDbl(txtA.Text)
        beta = CDbl(txtBeta.Text)

        ' Calculate z
        z = ((Math.Cos(a) + Math.Cos(beta)) / 2) * a - 2 * Math.Cos(0.5 * (a + beta)) * Math.Cos(0.5 * (a - beta))

        ' Display result
        lblResults.Text = z.ToString()
    End Sub
End Class
