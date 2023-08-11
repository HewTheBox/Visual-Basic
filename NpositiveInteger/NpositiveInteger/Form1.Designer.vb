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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find the sum of 1+1/2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter a positive integer :"
        '
        'txtLimit
        '
        Me.txtLimit.Location = New System.Drawing.Point(369, 165)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(418, 38)
        Me.txtLimit.TabIndex = 2
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(142, 337)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(223, 71)
        Me.btnSum.TabIndex = 3
        Me.btnSum.Text = "SUM"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Location = New System.Drawing.Point(564, 337)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(223, 71)
        Me.btnProduct.TabIndex = 4
        Me.btnProduct.Text = "PRODUCT"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(352, 546)
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(418, 38)
        Me.txtResults.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 549)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Results: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 755)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents btnSum As Button
    Friend WithEvents btnProduct As Button
    Friend WithEvents txtResults As TextBox
    Friend WithEvents Label3 As Label
End Class
