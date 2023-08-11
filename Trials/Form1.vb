Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        MsgBox("Helo")
        MessageBox.Show("Hello World")
    End Sub


    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Bright"
        stLastName = "Kumi"

        MessageBox.Show("Hello and Welcome " & stFirstName & " " & stLastName & ", I hope you are fine")

        stFirstName = "Steve"
        stLastName = "Crap"

        MessageBox.Show("Hello and Welcome " & stFirstName & " " & stLastName & ", I hope you are fine")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date



        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "red"
        bTaxed = True
        iEngineSize = 3200
        decPrice = 999.99
        dtDateRegistered = #11/2/2022#

        MsgBox("The car is " & stMake & vbNewLine & stModel &
               vbNewLine & iDoors & vbNewLine & stColor & vbNewLine &
               bTaxed & vbNewLine & iEngineSize & vbNewLine & decPrice &
               vbNewLine & dtDateRegistered)





    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String
        Dim stOccupation As String

        stFirstName = txtInput.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text
        stOccupation = lstOccupation.SelectedItem

        MsgBox("Hello " & stFirstName & " " & stLastName & " you are a " & stGender & " " & stOccupation)
        MessageBox.Show("Who is this motherfucker")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOccupation.Items.Add("Cook")
        lstOccupation.Items.Add("Pastor")
        lstOccupation.Items.Add("Farmer")
        lstOccupation.Items.Add("Banker")


    End Sub

    Private Sub btnArithmetic_Click(sender As Object, e As EventArgs) Handles btnArithmetic.Click
        Dim decPrice As Decimal
        Dim iquantity As Integer
        Dim decTotalPrice As Decimal
        Dim decDiscount As Decimal

        decPrice = 5
        iquantity = 10
        decDiscount = 2
        'decTotalPrice = decPrice * iquantity
        '(Take note of BODMAS) - Bracket order devision multiplication Addition Subtration
        decTotalPrice = (decPrice - decDiscount) * iquantity
        MsgBox(decTotalPrice)
        Dim finNumber As Integer = myname(3, 4, 5)
        MessageBox.Show("The big number is " & finNumber)




    End Sub
    Function myname(ByVal number1, ByVal number2, ByVal number3) As Integer
        If (number1 > number2 And number1 > number3) Then
            Return number1
        ElseIf (number2 > number3) Then
            Return number2
        Else
            Return number3
        End If
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
