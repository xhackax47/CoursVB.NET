<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secondaire
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BT_CLOSE = New System.Windows.Forms.Button()
        Me.LBL_SECOND = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_CLOSE
        '
        Me.BT_CLOSE.Location = New System.Drawing.Point(12, 12)
        Me.BT_CLOSE.Name = "BT_CLOSE"
        Me.BT_CLOSE.Size = New System.Drawing.Size(75, 23)
        Me.BT_CLOSE.TabIndex = 0
        Me.BT_CLOSE.Text = "Fermer"
        Me.BT_CLOSE.UseVisualStyleBackColor = True
        '
        'LBL_SECOND
        '
        Me.LBL_SECOND.AutoSize = True
        Me.LBL_SECOND.Location = New System.Drawing.Point(12, 38)
        Me.LBL_SECOND.Name = "LBL_SECOND"
        Me.LBL_SECOND.Size = New System.Drawing.Size(0, 13)
        Me.LBL_SECOND.TabIndex = 2
        '
        'Secondaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LBL_SECOND)
        Me.Controls.Add(Me.BT_CLOSE)
        Me.Name = "Secondaire"
        Me.Text = "Secondaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CLOSE As Button
    Friend WithEvents LBL_SECOND As Label
End Class
