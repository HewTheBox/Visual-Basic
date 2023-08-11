Public Class Form1
    Dim names(10) As String
    Dim marks(10) As Integer
    Dim maxMark As Double = Double.MinValue
    Dim minMark As Double = Double.MaxValue
    Dim index As Integer = 0
    Dim total As Double

    'Function for add student
    Sub addStudent()
        Dim name As String = InputBox("Enter student name", "student name")
        Dim mark As Integer = InputBox("Enter mark for " & name, "student mark")

        ReDim Preserve names(index)
        ReDim Preserve marks(index)
        names(index) = name
        marks(index) = mark
        dvgBox.Rows.Add(name, mark)
        index += 1
        'or index = names.Length
        If mark < minMark Then
            minMark = mark
        End If
        If mark > maxMark Then
            maxMark = mark
        End If
        total += mark
    End Sub
    'Function for worst Grade
    Sub worstGrade()
        Dim minIndex As Integer
        Dim i As Integer

        For i = 0 To marks.Length - 1
            If marks(i) < minMark Then
                minMark = marks(i)
            End If
            minIndex = i
        Next
        Dim worstStudent As String = names(minIndex)
        MessageBox.Show("Student " & worstStudent & " had the worst grade of " & minMark & "%", "Results")
    End Sub
    'Function for average
    Sub averageCheck()
        Dim average As Double = total / index
        MessageBox.Show("The average mark is " & average, "Results")
    End Sub
    'Function for good grade or good student
    Sub goodStudent()

        Dim maxindex As Integer

        For i As Integer = 0 To marks.Length - 1
            If marks(i) > maxMark Then
                maxMark = marks(i)

            End If
            maxindex = i
        Next
        Dim student As String = names(maxindex)

        MessageBox.Show("Student " & student & " had the Best Grade of " & maxMark & "%", "Results")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addStudent()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        worstGrade()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        goodStudent()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        averageCheck()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
