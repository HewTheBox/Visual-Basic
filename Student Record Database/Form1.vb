Imports System.Runtime.CompilerServices

Public Class Form1
    Private students As New List(Of Student)()
    Dim totalMark As Integer


    Public Class Student
        Public Property Name As String
        Public Property Mark As Double
    End Class

    Sub addStudent()
        Dim name As String = InputBox("Enter student name", "Fill this Form")
        If name <> "" Then
            Dim markStr As String = InputBox("Enter mark for " & name, "Fill the Form")
            Dim mark As Double
            If Double.TryParse(markStr, mark) AndAlso mark >= 0 AndAlso mark <= 100 Then
                students.Add(New Student With {.Name = name, .Mark = mark})
                dgvBox.Rows.Add(name, mark)
                totalMark += mark
            Else
                MessageBox.Show("Enter a valid mark between 0 and 100", "Error")
            End If
        End If
    End Sub
    Sub bestGrade()
        Dim maxMark As Double = students.Max(Function(s) s.Mark)
        Dim bestStudent As String = students.First(Function(s) s.Mark = maxMark).Name
        MessageBox.Show("Student " & bestStudent & " had the best grade of " & maxMark & "%", "Best Grade")
    End Sub

    Sub worstGrade()
        Dim minMark As Double = students.Min(Function(s) s.Mark)
        Dim worstStudent As String = students.First(Function(s) s.Mark = minMark).Name
        MessageBox.Show("Student " & worstStudent & " had the worst grade of " & minMark & "%", "Worst Grade")
    End Sub
    Sub AverageGrade()
        Dim lenght As Integer = Len(students)
        Dim total = lenght / totalMark
        MessageBox.Show("The average mark is " & total)
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


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AverageGrade()
    End Sub

End Class
