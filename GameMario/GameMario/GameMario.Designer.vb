<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameMario
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
        Me.GB_CONTROLS = New System.Windows.Forms.GroupBox()
        Me.BT_DOWN = New System.Windows.Forms.Button()
        Me.BT_LEFT = New System.Windows.Forms.Button()
        Me.BT_UP = New System.Windows.Forms.Button()
        Me.BT_RIGHT = New System.Windows.Forms.Button()
        Me.PIC_MARIO = New System.Windows.Forms.PictureBox()
        Me.GB_CONTROLS.SuspendLayout()
        CType(Me.PIC_MARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_CONTROLS
        '
        Me.GB_CONTROLS.Controls.Add(Me.BT_DOWN)
        Me.GB_CONTROLS.Controls.Add(Me.BT_LEFT)
        Me.GB_CONTROLS.Controls.Add(Me.BT_UP)
        Me.GB_CONTROLS.Controls.Add(Me.BT_RIGHT)
        Me.GB_CONTROLS.Location = New System.Drawing.Point(13, 433)
        Me.GB_CONTROLS.Name = "GB_CONTROLS"
        Me.GB_CONTROLS.Size = New System.Drawing.Size(709, 125)
        Me.GB_CONTROLS.TabIndex = 1
        Me.GB_CONTROLS.TabStop = False
        Me.GB_CONTROLS.Text = "Contrôles"
        '
        'BT_DOWN
        '
        Me.BT_DOWN.Location = New System.Drawing.Point(328, 96)
        Me.BT_DOWN.Name = "BT_DOWN"
        Me.BT_DOWN.Size = New System.Drawing.Size(20, 23)
        Me.BT_DOWN.TabIndex = 3
        Me.BT_DOWN.Text = "↓"
        Me.BT_DOWN.UseVisualStyleBackColor = True
        '
        'BT_LEFT
        '
        Me.BT_LEFT.Location = New System.Drawing.Point(227, 63)
        Me.BT_LEFT.Name = "BT_LEFT"
        Me.BT_LEFT.Size = New System.Drawing.Size(20, 23)
        Me.BT_LEFT.TabIndex = 2
        Me.BT_LEFT.Text = "←"
        Me.BT_LEFT.UseVisualStyleBackColor = True
        '
        'BT_UP
        '
        Me.BT_UP.Location = New System.Drawing.Point(328, 19)
        Me.BT_UP.Name = "BT_UP"
        Me.BT_UP.Size = New System.Drawing.Size(20, 23)
        Me.BT_UP.TabIndex = 1
        Me.BT_UP.Text = "↑"
        Me.BT_UP.UseVisualStyleBackColor = True
        '
        'BT_RIGHT
        '
        Me.BT_RIGHT.Location = New System.Drawing.Point(420, 63)
        Me.BT_RIGHT.Name = "BT_RIGHT"
        Me.BT_RIGHT.Size = New System.Drawing.Size(20, 23)
        Me.BT_RIGHT.TabIndex = 0
        Me.BT_RIGHT.Text = "→"
        Me.BT_RIGHT.UseVisualStyleBackColor = True
        '
        'PIC_MARIO
        '
        Me.PIC_MARIO.Image = Global.GameMario.My.Resources.Resources.mario2d
        Me.PIC_MARIO.Location = New System.Drawing.Point(341, 227)
        Me.PIC_MARIO.Name = "PIC_MARIO"
        Me.PIC_MARIO.Size = New System.Drawing.Size(20, 20)
        Me.PIC_MARIO.TabIndex = 2
        Me.PIC_MARIO.TabStop = False
        '
        'GameMario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 570)
        Me.Controls.Add(Me.PIC_MARIO)
        Me.Controls.Add(Me.GB_CONTROLS)
        Me.Name = "GameMario"
        Me.Text = "Mario"
        Me.GB_CONTROLS.ResumeLayout(False)
        CType(Me.PIC_MARIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_CONTROLS As GroupBox
    Friend WithEvents BT_RIGHT As Button
    Friend WithEvents BT_DOWN As Button
    Friend WithEvents BT_LEFT As Button
    Friend WithEvents BT_UP As Button
    Friend WithEvents PIC_MARIO As PictureBox
End Class
