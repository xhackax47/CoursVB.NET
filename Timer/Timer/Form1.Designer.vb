<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TIM_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.BT_START = New System.Windows.Forms.Button()
        Me.BT_RAZ = New System.Windows.Forms.Button()
        Me.PGB_TIMER = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'TIM_TIMER
        '
        Me.TIM_TIMER.Interval = 20
        '
        'BT_START
        '
        Me.BT_START.Location = New System.Drawing.Point(114, 12)
        Me.BT_START.Name = "BT_START"
        Me.BT_START.Size = New System.Drawing.Size(120, 23)
        Me.BT_START.TabIndex = 0
        Me.BT_START.Text = "Démarrer"
        Me.BT_START.UseVisualStyleBackColor = True
        '
        'BT_RAZ
        '
        Me.BT_RAZ.Location = New System.Drawing.Point(332, 12)
        Me.BT_RAZ.Name = "BT_RAZ"
        Me.BT_RAZ.Size = New System.Drawing.Size(120, 23)
        Me.BT_RAZ.TabIndex = 1
        Me.BT_RAZ.Text = "RAZ"
        Me.BT_RAZ.UseVisualStyleBackColor = True
        '
        'PGB_TIMER
        '
        Me.PGB_TIMER.Location = New System.Drawing.Point(12, 86)
        Me.PGB_TIMER.Name = "PGB_TIMER"
        Me.PGB_TIMER.Size = New System.Drawing.Size(572, 23)
        Me.PGB_TIMER.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 135)
        Me.Controls.Add(Me.PGB_TIMER)
        Me.Controls.Add(Me.BT_RAZ)
        Me.Controls.Add(Me.BT_START)
        Me.Name = "Form1"
        Me.Text = "Timer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TIM_TIMER As System.Windows.Forms.Timer
    Friend WithEvents BT_START As Button
    Friend WithEvents BT_RAZ As Button
    Friend WithEvents PGB_TIMER As ProgressBar
End Class
