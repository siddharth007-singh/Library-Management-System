<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class password
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
        Me.ch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ch
        '
        Me.ch.AutoSize = True
        Me.ch.Location = New System.Drawing.Point(74, 52)
        Me.ch.Name = "ch"
        Me.ch.Size = New System.Drawing.Size(147, 13)
        Me.ch.TabIndex = 0
        Me.ch.Text = "Change Your Paswword Here"
        '
        'password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ch)
        Me.Name = "password"
        Me.Text = "password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ch As System.Windows.Forms.Label
End Class
