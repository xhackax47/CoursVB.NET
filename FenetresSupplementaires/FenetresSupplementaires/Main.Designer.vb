<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.BT_OPEN = New System.Windows.Forms.Button()
        Me.LBL_MAIN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_OPEN
        '
        Me.BT_OPEN.Location = New System.Drawing.Point(12, 12)
        Me.BT_OPEN.Name = "BT_OPEN"
        Me.BT_OPEN.Size = New System.Drawing.Size(75, 23)
        Me.BT_OPEN.TabIndex = 0
        Me.BT_OPEN.Text = "Ouvrir"
        Me.BT_OPEN.UseVisualStyleBackColor = True
        '
        'LBL_MAIN
        '
        Me.LBL_MAIN.AutoSize = True
        Me.LBL_MAIN.Location = New System.Drawing.Point(12, 38)
        Me.LBL_MAIN.Name = "LBL_MAIN"
        Me.LBL_MAIN.Size = New System.Drawing.Size(0, 13)
        Me.LBL_MAIN.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.LBL_MAIN)
        Me.Controls.Add(Me.BT_OPEN)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_OPEN As Button
    Friend WithEvents LBL_MAIN As Label
End Class
