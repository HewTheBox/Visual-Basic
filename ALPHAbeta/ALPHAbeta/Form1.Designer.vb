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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBeta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter value for (a) :"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(348, 97)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(303, 38)
        Me.txtA.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 104)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBeta
        '
        Me.txtBeta.Location = New System.Drawing.Point(348, 180)
        Me.txtBeta.Name = "txtBeta"
        Me.txtBeta.Size = New System.Drawing.Size(303, 38)
        Me.txtBeta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter value for (beta) :"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(342, 590)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(211, 32)
        Me.lblResults.TabIndex = 5
        Me.lblResults.Text = "Display Results"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 701)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.txtBeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBeta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResults As Label
End Class
