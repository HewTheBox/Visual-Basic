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
        Me.rdbSum = New System.Windows.Forms.RadioButton()
        Me.rdbDifference = New System.Windows.Forms.RadioButton()
        Me.rdbQuotient = New System.Windows.Forms.RadioButton()
        Me.rdbProduct = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdbSum
        '
        Me.rdbSum.AutoSize = True
        Me.rdbSum.Location = New System.Drawing.Point(73, 60)
        Me.rdbSum.Name = "rdbSum"
        Me.rdbSum.Size = New System.Drawing.Size(59, 21)
        Me.rdbSum.TabIndex = 0
        Me.rdbSum.TabStop = True
        Me.rdbSum.Text = "SUM"
        Me.rdbSum.UseVisualStyleBackColor = True
        '
        'rdbDifference
        '
        Me.rdbDifference.AutoSize = True
        Me.rdbDifference.Location = New System.Drawing.Point(73, 255)
        Me.rdbDifference.Name = "rdbDifference"
        Me.rdbDifference.Size = New System.Drawing.Size(94, 21)
        Me.rdbDifference.TabIndex = 1
        Me.rdbDifference.TabStop = True
        Me.rdbDifference.Text = "Difference"
        Me.rdbDifference.UseVisualStyleBackColor = True
        '
        'rdbQuotient
        '
        Me.rdbQuotient.AutoSize = True
        Me.rdbQuotient.Location = New System.Drawing.Point(73, 199)
        Me.rdbQuotient.Name = "rdbQuotient"
        Me.rdbQuotient.Size = New System.Drawing.Size(83, 21)
        Me.rdbQuotient.TabIndex = 2
        Me.rdbQuotient.TabStop = True
        Me.rdbQuotient.Text = "Quotient"
        Me.rdbQuotient.UseVisualStyleBackColor = True
        '
        'rdbProduct
        '
        Me.rdbProduct.AutoSize = True
        Me.rdbProduct.Location = New System.Drawing.Point(73, 129)
        Me.rdbProduct.Name = "rdbProduct"
        Me.rdbProduct.Size = New System.Drawing.Size(78, 21)
        Me.rdbProduct.TabIndex = 3
        Me.rdbProduct.TabStop = True
        Me.rdbProduct.Text = "Product"
        Me.rdbProduct.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 70)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(245, 93)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(247, 22)
        Me.txtResult.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 380)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdbProduct)
        Me.Controls.Add(Me.rdbQuotient)
        Me.Controls.Add(Me.rdbDifference)
        Me.Controls.Add(Me.rdbSum)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbSum As RadioButton
    Friend WithEvents rdbDifference As RadioButton
    Friend WithEvents rdbQuotient As RadioButton
    Friend WithEvents rdbProduct As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
End Class
