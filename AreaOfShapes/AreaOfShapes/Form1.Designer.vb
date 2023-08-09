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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radioTriangle = New System.Windows.Forms.RadioButton()
        Me.radioRectangle = New System.Windows.Forms.RadioButton()
        Me.radioCircle = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLenght = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select what you want calculate"
        '
        'radioTriangle
        '
        Me.radioTriangle.AutoSize = True
        Me.radioTriangle.Location = New System.Drawing.Point(32, 557)
        Me.radioTriangle.Name = "radioTriangle"
        Me.radioTriangle.Size = New System.Drawing.Size(254, 36)
        Me.radioTriangle.TabIndex = 1
        Me.radioTriangle.TabStop = True
        Me.radioTriangle.Text = "Area of Triangle"
        Me.radioTriangle.UseVisualStyleBackColor = True
        '
        'radioRectangle
        '
        Me.radioRectangle.AutoSize = True
        Me.radioRectangle.Location = New System.Drawing.Point(762, 557)
        Me.radioRectangle.Name = "radioRectangle"
        Me.radioRectangle.Size = New System.Drawing.Size(279, 36)
        Me.radioRectangle.TabIndex = 2
        Me.radioRectangle.TabStop = True
        Me.radioRectangle.Text = "Area of Rectangle"
        Me.radioRectangle.UseVisualStyleBackColor = True
        '
        'radioCircle
        '
        Me.radioCircle.AutoSize = True
        Me.radioCircle.Location = New System.Drawing.Point(426, 557)
        Me.radioCircle.Name = "radioCircle"
        Me.radioCircle.Size = New System.Drawing.Size(223, 36)
        Me.radioCircle.TabIndex = 3
        Me.radioCircle.TabStop = True
        Me.radioCircle.Text = "Area of Circle"
        Me.radioCircle.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Radius: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Base: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Height:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Lenght"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 32)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Width"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(326, 128)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(323, 38)
        Me.txtRadius.TabIndex = 9
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(326, 409)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(323, 38)
        Me.txtWidth.TabIndex = 10
        '
        'txtLenght
        '
        Me.txtLenght.Location = New System.Drawing.Point(326, 330)
        Me.txtLenght.Name = "txtLenght"
        Me.txtLenght.Size = New System.Drawing.Size(323, 38)
        Me.txtLenght.TabIndex = 11
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(326, 270)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(323, 38)
        Me.txtHeight.TabIndex = 12
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(326, 192)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(323, 38)
        Me.txtBase.TabIndex = 13
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(385, 670)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(249, 67)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(397, 855)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(211, 32)
        Me.lblArea.TabIndex = 15
        Me.lblArea.Text = "Display Results"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 969)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtLenght)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radioCircle)
        Me.Controls.Add(Me.radioRectangle)
        Me.Controls.Add(Me.radioTriangle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radioTriangle As RadioButton
    Friend WithEvents radioRectangle As RadioButton
    Friend WithEvents radioCircle As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLenght As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtBase As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblArea As Label
End Class
