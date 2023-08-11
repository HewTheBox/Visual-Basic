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
        Me.btnAddSales = New System.Windows.Forms.Button()
        Me.txtAddSales = New System.Windows.Forms.TextBox()
        Me.lblAddSales = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.btnTwoPercent = New System.Windows.Forms.Button()
        Me.bntFivePercent = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMinimumSale = New System.Windows.Forms.Label()
        Me.txtMinimumSale = New System.Windows.Forms.TextBox()
        Me.lblMaximumSale = New System.Windows.Forms.Label()
        Me.txtMaximumSale = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAddSales
        '
        Me.btnAddSales.BackColor = System.Drawing.Color.Cyan
        Me.btnAddSales.Location = New System.Drawing.Point(517, 33)
        Me.btnAddSales.Name = "btnAddSales"
        Me.btnAddSales.Size = New System.Drawing.Size(183, 75)
        Me.btnAddSales.TabIndex = 0
        Me.btnAddSales.Text = "Add Sales"
        Me.btnAddSales.UseVisualStyleBackColor = False
        '
        'txtAddSales
        '
        Me.txtAddSales.Location = New System.Drawing.Point(264, 57)
        Me.txtAddSales.Name = "txtAddSales"
        Me.txtAddSales.Size = New System.Drawing.Size(154, 22)
        Me.txtAddSales.TabIndex = 1
        '
        'lblAddSales
        '
        Me.lblAddSales.AutoSize = True
        Me.lblAddSales.Location = New System.Drawing.Point(154, 63)
        Me.lblAddSales.Name = "lblAddSales"
        Me.lblAddSales.Size = New System.Drawing.Size(42, 16)
        Me.lblAddSales.TabIndex = 2
        Me.lblAddSales.Text = "Sales"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(154, 109)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(76, 16)
        Me.lblTotalSales.TabIndex = 3
        Me.lblTotalSales.Text = "Total Sales"
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(264, 103)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(154, 22)
        Me.txtTotalSales.TabIndex = 4
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(154, 151)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(30, 16)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "Tax"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(264, 148)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(154, 22)
        Me.txtTax.TabIndex = 6
        '
        'btnTwoPercent
        '
        Me.btnTwoPercent.Location = New System.Drawing.Point(517, 122)
        Me.btnTwoPercent.Name = "btnTwoPercent"
        Me.btnTwoPercent.Size = New System.Drawing.Size(183, 75)
        Me.btnTwoPercent.TabIndex = 7
        Me.btnTwoPercent.Text = "2%"
        Me.btnTwoPercent.UseVisualStyleBackColor = True
        '
        'bntFivePercent
        '
        Me.bntFivePercent.Location = New System.Drawing.Point(517, 219)
        Me.bntFivePercent.Name = "bntFivePercent"
        Me.bntFivePercent.Size = New System.Drawing.Size(183, 75)
        Me.bntFivePercent.TabIndex = 8
        Me.bntFivePercent.Text = "5%"
        Me.bntFivePercent.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(577, 352)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(96, 39)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblMinimumSale
        '
        Me.lblMinimumSale.AutoSize = True
        Me.lblMinimumSale.Location = New System.Drawing.Point(154, 278)
        Me.lblMinimumSale.Name = "lblMinimumSale"
        Me.lblMinimumSale.Size = New System.Drawing.Size(91, 16)
        Me.lblMinimumSale.TabIndex = 10
        Me.lblMinimumSale.Text = "Minimum Sale"
        '
        'txtMinimumSale
        '
        Me.txtMinimumSale.Location = New System.Drawing.Point(264, 278)
        Me.txtMinimumSale.Name = "txtMinimumSale"
        Me.txtMinimumSale.Size = New System.Drawing.Size(154, 22)
        Me.txtMinimumSale.TabIndex = 11
        '
        'lblMaximumSale
        '
        Me.lblMaximumSale.AutoSize = True
        Me.lblMaximumSale.Location = New System.Drawing.Point(154, 318)
        Me.lblMaximumSale.Name = "lblMaximumSale"
        Me.lblMaximumSale.Size = New System.Drawing.Size(95, 16)
        Me.lblMaximumSale.TabIndex = 12
        Me.lblMaximumSale.Text = "Maximum Sale"
        '
        'txtMaximumSale
        '
        Me.txtMaximumSale.Location = New System.Drawing.Point(264, 318)
        Me.txtMaximumSale.Name = "txtMaximumSale"
        Me.txtMaximumSale.Size = New System.Drawing.Size(154, 22)
        Me.txtMaximumSale.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 594)
        Me.Controls.Add(Me.txtMaximumSale)
        Me.Controls.Add(Me.lblMaximumSale)
        Me.Controls.Add(Me.txtMinimumSale)
        Me.Controls.Add(Me.lblMinimumSale)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.bntFivePercent)
        Me.Controls.Add(Me.btnTwoPercent)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtTotalSales)
        Me.Controls.Add(Me.lblTotalSales)
        Me.Controls.Add(Me.lblAddSales)
        Me.Controls.Add(Me.txtAddSales)
        Me.Controls.Add(Me.btnAddSales)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddSales As Button
    Friend WithEvents txtAddSales As TextBox
    Friend WithEvents lblAddSales As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents btnTwoPercent As Button
    Friend WithEvents bntFivePercent As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblMinimumSale As Label
    Friend WithEvents txtMinimumSale As TextBox
    Friend WithEvents lblMaximumSale As Label
    Friend WithEvents txtMaximumSale As TextBox
End Class
