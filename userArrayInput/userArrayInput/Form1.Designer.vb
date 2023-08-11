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
        Me.lstOriginal = New System.Windows.Forms.ListBox()
        Me.txtSumEven = New System.Windows.Forms.TextBox()
        Me.txtProductOdd = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click Input to Enter values: "
        '
        'lstOriginal
        '
        Me.lstOriginal.FormattingEnabled = True
        Me.lstOriginal.ItemHeight = 31
        Me.lstOriginal.Location = New System.Drawing.Point(423, 53)
        Me.lstOriginal.Name = "lstOriginal"
        Me.lstOriginal.Size = New System.Drawing.Size(262, 314)
        Me.lstOriginal.TabIndex = 2
        '
        'txtSumEven
        '
        Me.txtSumEven.Location = New System.Drawing.Point(534, 708)
        Me.txtSumEven.Name = "txtSumEven"
        Me.txtSumEven.Size = New System.Drawing.Size(323, 38)
        Me.txtSumEven.TabIndex = 3
        '
        'txtProductOdd
        '
        Me.txtProductOdd.Location = New System.Drawing.Point(534, 800)
        Me.txtProductOdd.Name = "txtProductOdd"
        Me.txtProductOdd.Size = New System.Drawing.Size(323, 38)
        Me.txtProductOdd.TabIndex = 4
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(750, 303)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(223, 73)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "INPUT"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 708)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sum of Even Numbers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 800)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product of Odd Numbers:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(423, 510)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(223, 73)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 973)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtProductOdd)
        Me.Controls.Add(Me.txtSumEven)
        Me.Controls.Add(Me.lstOriginal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstOriginal As ListBox
    Friend WithEvents txtSumEven As TextBox
    Friend WithEvents txtProductOdd As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
End Class
