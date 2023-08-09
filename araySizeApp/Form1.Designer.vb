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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstOriginal = New System.Windows.Forms.ListBox()
        Me.lstEven = New System.Windows.Forms.ListBox()
        Me.lstOdd = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstOriginal
        '
        Me.lstOriginal.FormattingEnabled = True
        Me.lstOriginal.ItemHeight = 16
        Me.lstOriginal.Location = New System.Drawing.Point(32, 34)
        Me.lstOriginal.Name = "lstOriginal"
        Me.lstOriginal.Size = New System.Drawing.Size(167, 244)
        Me.lstOriginal.TabIndex = 1
        '
        'lstEven
        '
        Me.lstEven.FormattingEnabled = True
        Me.lstEven.ItemHeight = 16
        Me.lstEven.Location = New System.Drawing.Point(289, 34)
        Me.lstEven.Name = "lstEven"
        Me.lstEven.Size = New System.Drawing.Size(167, 244)
        Me.lstEven.TabIndex = 2
        '
        'lstOdd
        '
        Me.lstOdd.FormattingEnabled = True
        Me.lstOdd.ItemHeight = 16
        Me.lstOdd.Location = New System.Drawing.Point(531, 34)
        Me.lstOdd.Name = "lstOdd"
        Me.lstOdd.Size = New System.Drawing.Size(167, 244)
        Me.lstOdd.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 656)
        Me.Controls.Add(Me.lstOdd)
        Me.Controls.Add(Me.lstEven)
        Me.Controls.Add(Me.lstOriginal)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lstOriginal As ListBox
    Friend WithEvents lstEven As ListBox
    Friend WithEvents lstOdd As ListBox
End Class
