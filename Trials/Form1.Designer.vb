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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.btnArithmetic = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(85, 33)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(234, 87)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Click Here"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(362, 45)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(188, 74)
        Me.btnVariables.TabIndex = 1
        Me.btnVariables.Text = "Varibles Declaration"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(93, 152)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(225, 69)
        Me.btnDataTypes.TabIndex = 2
        Me.btnDataTypes.Text = "Data Tytpes"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(388, 152)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(225, 69)
        Me.btnInput.TabIndex = 3
        Me.btnInput.Text = "User Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(388, 284)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(202, 22)
        Me.txtInput.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(293, 290)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(69, 16)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(293, 331)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(69, 16)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "LastName"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(388, 325)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 22)
        Me.txtLastName.TabIndex = 7
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(293, 375)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(52, 16)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(388, 369)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(144, 22)
        Me.txtGender.TabIndex = 9
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 16
        Me.lstOccupation.Items.AddRange(New Object() {"Gammer ", "Dancer", "Singer", "Progammer", "Teacher", "Billonaire", "Teacher", "Runner", "Student"})
        Me.lstOccupation.Location = New System.Drawing.Point(666, 278)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(101, 148)
        Me.lstOccupation.TabIndex = 10
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(674, 249)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(75, 16)
        Me.lblOccupation.TabIndex = 11
        Me.lblOccupation.Text = "Occupation"
        '
        'btnArithmetic
        '
        Me.btnArithmetic.Location = New System.Drawing.Point(93, 405)
        Me.btnArithmetic.Name = "btnArithmetic"
        Me.btnArithmetic.Size = New System.Drawing.Size(179, 82)
        Me.btnArithmetic.TabIndex = 12
        Me.btnArithmetic.Text = "Arithmetic"
        Me.btnArithmetic.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(456, 521)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 712)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnArithmetic)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
    Friend WithEvents btnArithmetic As Button
    Friend WithEvents btnClose As Button
End Class
