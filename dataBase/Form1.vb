Public Class Form1
    Dim names(10) As String
    Dim marks(10) As Double
    Dim minMark As Double = Double.MaxValue
    Dim maxMark As Double = Double.MinValue
    Dim index As Integer = 0
    Dim total As Double

    'function for adding student
    Sub addStudent()
        ReDim Preserve names(index)
        ReDim Preserve marks(index)
        'Declaring variables to store input
        Dim name, markStr As String
        Dim mark As Double
        name = InputBox("Enter student name", "Fill this Form")
        markStr = InputBox("Enter mark for " & name, "Fill the Form")

        If Not IsNumeric(markStr) Then
            MessageBox.Show("Enter a valid mark", "Error")
        Else
            Double.TryParse(markStr, mark)
        End If
        names(index) = name
        marks(index) = mark
        dgvBox.Rows.Add(name, mark)
        index += 1
        'initializing minMark and maxMark
        If mark > maxMark Then
            maxMark = mark
        End If
        If mark < minMark Then
            minMark = mark
        End If
        total += mark
    End Sub
    'function for checking best grade
    Sub bestGrade()

        Dim maxIndex As Integer = 0
        For i As Integer = 0 To marks.Length - 1
            If marks(i) > maxMark Then
                maxMark = marks(i)
                maxIndex = i
            End If
        Next
        Dim bestStudent As String = names(maxIndex)
        MessageBox.Show("Student " & bestStudent & " had the best grade of " & maxMark & "%", "Best Grade")
    End Sub
    Sub worstGrade()
        Dim minIndex As Integer
        For i As Integer = 0 To marks.Length - 1
            If marks(i) < minMark Then
                maxMark = marks(i)
                minIndex = i
            End If
        Next

        Dim worstStudent As String = names(minIndex)
        MessageBox.Show("Student " & worstStudent & " had the worst grade of " & minMark & "%")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addStudent()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bestGrade()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        worstGrade()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Sub average()
        Dim average As Double = total / index



        MessageBox.Show("The average marks is " & average, "Average Score")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        average()
    End Sub
    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        addStudent()
    End Sub
    Private Sub FirstClassStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FirstClassStudentToolStripMenuItem.Click
        bestGrade()
    End Sub

    Private Sub AverageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AverageToolStripMenuItem.Click
        average()
    End Sub

    Private Sub PoorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoorToolStripMenuItem.Click
        worstGrade()
    End Sub
End Class
