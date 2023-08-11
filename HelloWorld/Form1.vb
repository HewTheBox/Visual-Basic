Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("Hello World")
        MsgBox("How are you doing?")
        MsgBox("I hope you are well!")


    End Sub

    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Dim stCountry As String
        stCountry = txtCounty.Text
        'stCountry = stCountry.ToUpper

        If stCountry.ToUpper = "GHANA" Then
            MsgBox("Good day Mate")
            MessageBox.Show("Go on ya")
            MessageBox.Show("No Worries")

        ElseIf stCountry.ToUpper = "TOGO" Then
            MsgBox("ayo nigga")

        ElseIf stCountry.ToUpper = "AMERICA" Then
            MessageBox.Show("Fuck You niga")
        Else
            MsgBox("Good day all of you")
        End If
        MessageBox.Show("You are from " & stCountry)

    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Dim decScore As Decimal
        If IsNumeric(txtScore.Text) = True Then
            decScore = CDec(txtScore.Text)
        Else
            MsgBox("You must enter a value")
            Exit Sub
        End If

        'decScore = CDec(txtScore.Text)
        If decScore < 0 Or decScore > 100 Then
            MsgBox("You entered an invalid score. Please enter a value between 0 and 100")

        ElseIf decScore >= 50 Then
            MsgBox("You passed")

        ElseIf decScore < 50 Then
            MsgBox("You failed")

        Else
            MsgBox("Wrong input")
        End If

        MsgBox("All Done")



    End Sub

    Private Sub btnTemperature_Click(sender As Object, e As EventArgs) Handles btnTemperature.Click
        Dim iTemp As Integer
        iTemp = txtTemperature.Text

        Select Case iTemp
            Case Is = 0
                MsgBox("freezing")

            Case < 0
                MsgBox("sub zero")

            Case 1 To 10
                MsgBox("cold")
            Case 11 To 20
                MsgBox("warm")
            Case Else
                MsgBox("Hot")
        End Select
    End Sub

    Private Sub btnLoop_Click(sender As Object, e As EventArgs) Handles btnLoop.Click
        Dim iCount As Integer
        Dim stOut As String
        For iCount = 50 To 0 Step -5
            stOut = stOut & iCount & vbNewLine


            'Beep()
            'Threading.Thread.Sleep(3000)
        Next
        MsgBox(stOut)
    End Sub

    Private Sub btnTryWork_Click(sender As Object, e As EventArgs) Handles btnTryWork.Click
        Dim iInput As Integer
        Dim stOdd_Even As String
        Dim iCount As Integer

        iInput = InputBox("How many do you want to count up to? ")
        stOdd_Even = InputBox("Do you want to count Odd or Even ")
        stOdd_Even = stOdd_Even.ToLower

        Select Case stOdd_Even
            Case "odd"
                For iCount = 1 To iInput Step 2
                    MsgBox(iCount)
                Next
            Case "even"
                For iInput = iInput To 2 Step -2
                    iCount = iCount + 2
                    MsgBox(iCount)
                Next
            Case Else
                MsgBox("Wrong choice")
        End Select



    End Sub

    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        Dim iCount As String
        Do

            MessageBox.Show("God is Good " & iCount)
            iCount += 1

        Loop Until iCount > 5
    End Sub

    Private Sub btnArray_Click(sender As Object, e As EventArgs) Handles btnArray.Click
        Dim astFruits(4) As String
        astFruits(0) = "strawberry"
        astFruits(1) = "apple"
        astFruits(2) = "mango"
        astFruits(3) = "banana"
        astFruits(4) = "orange"

        Dim i As Integer

        For i = 0 To 4
            MsgBox(astFruits(i))
        Next

        MessageBox.Show("All done")






    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Alright so here a simple linesearch program in vb.net

        Dim stFruits(5) As String
        Dim stLineSearch As String
        Dim iCount As Integer
        Dim blFound As Boolean


        stFruits(0) = "orange"
        stFruits(1) = "apple"
        stFruits(2) = "strawberry"
        stFruits(3) = "pineaple"
        stFruits(4) = "mango"
        stFruits(5) = "peal"

        stLineSearch = InputBox("What fruit do you want to search for? ")

        For iCount = 0 To 5
            If stLineSearch = stFruits(iCount) Then
                blFound = True
            End If
        Next

        If blFound Then
            MsgBox("Fruit found")
        Else
            MsgBox("Not found")
        End If









    End Sub
End Class
