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
        Me.radioSum = New System.Windows.Forms.RadioButton()
        Me.radioQuot = New System.Windows.Forms.RadioButton()
        Me.radioProduct = New System.Windows.Forms.RadioButton()
        Me.radioDiff = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.txtSecondNum = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radioSum
        '
        Me.radioSum.AutoSize = True
        Me.radioSum.Location = New System.Drawing.Point(318, 315)
        Me.radioSum.Name = "radioSum"
        Me.radioSum.Size = New System.Drawing.Size(110, 36)
        Me.radioSum.TabIndex = 0
        Me.radioSum.TabStop = True
        Me.radioSum.Text = "Sum"
        Me.radioSum.UseVisualStyleBackColor = True
        '
        'radioQuot
        '
        Me.radioQuot.AutoSize = True
        Me.radioQuot.Location = New System.Drawing.Point(601, 390)
        Me.radioQuot.Name = "radioQuot"
        Me.radioQuot.Size = New System.Drawing.Size(161, 36)
        Me.radioQuot.TabIndex = 1
        Me.radioQuot.TabStop = True
        Me.radioQuot.Text = "Quotient"
        Me.radioQuot.UseVisualStyleBackColor = True
        '
        'radioProduct
        '
        Me.radioProduct.AutoSize = True
        Me.radioProduct.Location = New System.Drawing.Point(318, 390)
        Me.radioProduct.Name = "radioProduct"
        Me.radioProduct.Size = New System.Drawing.Size(150, 36)
        Me.radioProduct.TabIndex = 2
        Me.radioProduct.TabStop = True
        Me.radioProduct.Text = "Product"
        Me.radioProduct.UseVisualStyleBackColor = True
        '
        'radioDiff
        '
        Me.radioDiff.AutoSize = True
        Me.radioDiff.Location = New System.Drawing.Point(601, 304)
        Me.radioDiff.Name = "radioDiff"
        Me.radioDiff.Size = New System.Drawing.Size(166, 36)
        Me.radioDiff.TabIndex = 3
        Me.radioDiff.TabStop = True
        Me.radioDiff.Text = "Diffrence"
        Me.radioDiff.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Second Number"
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Location = New System.Drawing.Point(341, 60)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(337, 38)
        Me.txtFirstNum.TabIndex = 6
        '
        'txtSecondNum
        '
        Me.txtSecondNum.Location = New System.Drawing.Point(335, 155)
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(337, 38)
        Me.txtSecondNum.TabIndex = 7
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(414, 712)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(211, 32)
        Me.lblResults.TabIndex = 8
        Me.lblResults.Text = "Display Results"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(398, 512)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(237, 80)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 882)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.txtSecondNum)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radioDiff)
        Me.Controls.Add(Me.radioProduct)
        Me.Controls.Add(Me.radioQuot)
        Me.Controls.Add(Me.radioSum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioSum As RadioButton
    Friend WithEvents radioQuot As RadioButton
    Friend WithEvents radioProduct As RadioButton
    Friend WithEvents radioDiff As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents lblResults As Label
    Friend WithEvents btnCalculate As Button
End Class
