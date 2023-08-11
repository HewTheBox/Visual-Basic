<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Student = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Student_marks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStudent = New System.Windows.Forms.TextBox()
        Me.txtMarks = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnBest = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Student, Me.Student_marks})
        Me.DataGridView1.Location = New System.Drawing.Point(86, 76)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(467, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'Student
        '
        Me.Student.HeaderText = "Student Name"
        Me.Student.Name = "Student"
        '
        'Student_marks
        '
        Me.Student_marks.HeaderText = "Student Marks"
        Me.Student_marks.Name = "Student_marks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 380)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 339)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add Student Names and Marks Below"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 421)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student Marks :"
        '
        'txtStudent
        '
        Me.txtStudent.Location = New System.Drawing.Point(180, 379)
        Me.txtStudent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(257, 22)
        Me.txtStudent.TabIndex = 4
        '
        'txtMarks
        '
        Me.txtMarks.Location = New System.Drawing.Point(180, 421)
        Me.txtMarks.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMarks.Name = "txtMarks"
        Me.txtMarks.Size = New System.Drawing.Size(257, 22)
        Me.txtMarks.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(164, 460)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(286, 44)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add student Name And Marks"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(164, 595)
        Me.btnAverage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(286, 38)
        Me.btnAverage.TabIndex = 7
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnBest
        '
        Me.btnBest.Location = New System.Drawing.Point(32, 531)
        Me.btnBest.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBest.Name = "btnBest"
        Me.btnBest.Size = New System.Drawing.Size(260, 41)
        Me.btnBest.TabIndex = 8
        Me.btnBest.Text = "Who is the Best?"
        Me.btnBest.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(328, 536)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(260, 41)
        Me.btnLast.TabIndex = 9
        Me.btnLast.Text = "Who is Last?"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 695)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnBest)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMarks)
        Me.Controls.Add(Me.txtStudent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStudent As TextBox
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnBest As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents Student As DataGridViewTextBoxColumn
    Friend WithEvents Student_marks As DataGridViewTextBoxColumn
End Class
