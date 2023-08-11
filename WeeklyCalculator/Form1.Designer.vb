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
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtMinimum = New System.Windows.Forms.TextBox()
        Me.txtMaximum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sale"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(275, 63)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(184, 22)
        Me.txtSales.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(575, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 89)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Sales"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(275, 149)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(184, 22)
        Me.txtTotalSales.TabIndex = 3
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(275, 227)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(184, 22)
        Me.txtTax.TabIndex = 4
        '
        'txtMinimum
        '
        Me.txtMinimum.Location = New System.Drawing.Point(275, 387)
        Me.txtMinimum.Name = "txtMinimum"
        Me.txtMinimum.Size = New System.Drawing.Size(184, 22)
        Me.txtMinimum.TabIndex = 5
        '
        'txtMaximum
        '
        Me.txtMaximum.Location = New System.Drawing.Point(275, 449)
        Me.txtMaximum.Name = "txtMaximum"
        Me.txtMaximum.Size = New System.Drawing.Size(184, 22)
        Me.txtMaximum.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TotalSale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Minimun Sale"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 449)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Maximun Sale"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(575, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(212, 89)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "2% Tax"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(575, 284)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 89)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "5% Tax"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(622, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 63)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 550)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaximum)
        Me.Controls.Add(Me.txtMinimum)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtMinimum As TextBox
    Friend WithEvents txtMaximum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
