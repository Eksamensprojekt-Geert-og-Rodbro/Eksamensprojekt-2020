<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.But_tilbage = New System.Windows.Forms.Button()
        Me.Lbl_vis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'But_tilbage
        '
        Me.But_tilbage.Location = New System.Drawing.Point(748, 426)
        Me.But_tilbage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.But_tilbage.Name = "But_tilbage"
        Me.But_tilbage.Size = New System.Drawing.Size(100, 28)
        Me.But_tilbage.TabIndex = 0
        Me.But_tilbage.Text = "Tilbage"
        Me.But_tilbage.UseVisualStyleBackColor = True
        '
        'Lbl_vis
        '
        Me.Lbl_vis.AutoSize = True
        Me.Lbl_vis.Location = New System.Drawing.Point(75, 59)
        Me.Lbl_vis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_vis.Name = "Lbl_vis"
        Me.Lbl_vis.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_vis.TabIndex = 1
        Me.Lbl_vis.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 553)
        Me.Controls.Add(Me.Lbl_vis)
        Me.Controls.Add(Me.But_tilbage)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents But_tilbage As Button
    Friend WithEvents Lbl_vis As Label
End Class
