Public Class Form1
    Private students() As String
    Private marks() As Integer
    Private count As Integer = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add student and mark to arrays '
        ReDim Preserve students(count)
        ReDim Preserve marks(count)


        students(count) = txtStudent.Text
        marks(count) = Convert.ToInt32(txtMarks.Text)

        count += 1

        ' Add row to DataGridView '
        DataGridView1.Rows.Add(students(count - 1), marks(count - 1))

        ' Clear text boxes '
        txtStudent.Clear()
        txtMarks.Clear()
    End Sub

    Private Sub btnBest_Click(sender As Object, e As EventArgs) Handles btnBest.Click
        ' Find student with highest mark '
        Dim maxMark As Integer = marks.Max()
        Dim index As Integer = Array.IndexOf(marks, maxMark)
        Dim bestStudent As String = students(index)

        ' Display result in form2 '

        Dim form2 As New Form2(bestStudent, maxMark)
        Dim displayMax As String = "Student" & " " & bestStudent & " had the Maximum Marks"
        form2.lblDisplay.Text = displayMax
        form2.Show()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        ' Find student with lowest mark '
        Dim minMark As Integer = marks.Min()
        Dim index As Integer = Array.IndexOf(marks, minMark)
        Dim lastStudent As String = students(index)

        ' Display result in form3 '
        Dim form3 As New Form3(lastStudent, minMark)
        Dim displayMax As String = "Student" & " " & lastStudent & " had the Minimum Marks"
        form3.lblDisplay.Text = displayMax


        form3.Show()
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        ' Calculate average class score '
        Dim total As Integer = marks.Sum()
        Dim average As Double = total / count

        ' Display result in form4 '
        Dim form4 As New Form4(average)
        Dim displayMax As String = "The average mark is " & " " & average
        form4.lblDisplay.Text = displayMax
        form4.Show()
    End Sub
End Class
