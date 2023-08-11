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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubSale = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lstListBox = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(202, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 71)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Product"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(65, 56)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(172, 27)
        Me.txtItem.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(339, 56)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(172, 27)
        Me.txtPrice.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sub Sale"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(189, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sale Tax(6.,5%)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(271, 533)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total"
        '
        'txtSubSale
        '
        Me.txtSubSale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubSale.Location = New System.Drawing.Point(358, 464)
        Me.txtSubSale.Name = "txtSubSale"
        Me.txtSubSale.Size = New System.Drawing.Size(182, 27)
        Me.txtSubSale.TabIndex = 8
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(358, 497)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(182, 27)
        Me.txtTax.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(358, 530)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(182, 27)
        Me.txtTotal.TabIndex = 10
        '
        'lstListBox
        '
        Me.lstListBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstListBox.FormattingEnabled = True
        Me.lstListBox.ItemHeight = 20
        Me.lstListBox.Location = New System.Drawing.Point(47, 214)
        Me.lstListBox.Name = "lstListBox"
        Me.lstListBox.Size = New System.Drawing.Size(511, 244)
        Me.lstListBox.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(16, 611)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(572, 51)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(600, 674)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lstListBox)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtSubSale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSubSale As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lstListBox As ListBox
    Friend WithEvents Button2 As Button
End Class
