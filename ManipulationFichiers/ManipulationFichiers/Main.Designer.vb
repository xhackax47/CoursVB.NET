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
        Me.GB_READ = New System.Windows.Forms.GroupBox()
        Me.BT_CLEAN_READ = New System.Windows.Forms.Button()
        Me.BT_READ = New System.Windows.Forms.Button()
        Me.TXT_READ = New System.Windows.Forms.TextBox()
        Me.GB_WRITE = New System.Windows.Forms.GroupBox()
        Me.TXT_WRITE = New System.Windows.Forms.TextBox()
        Me.CHK_START = New System.Windows.Forms.CheckBox()
        Me.BT_WRITE = New System.Windows.Forms.Button()
        Me.BT_CLEAN_WRITE = New System.Windows.Forms.Button()
        Me.BT_CLEARFILE = New System.Windows.Forms.Button()
        Me.GB_READ.SuspendLayout()
        Me.GB_WRITE.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_READ
        '
        Me.GB_READ.Controls.Add(Me.BT_CLEAN_READ)
        Me.GB_READ.Controls.Add(Me.BT_READ)
        Me.GB_READ.Controls.Add(Me.TXT_READ)
        Me.GB_READ.Location = New System.Drawing.Point(24, 23)
        Me.GB_READ.Name = "GB_READ"
        Me.GB_READ.Size = New System.Drawing.Size(923, 307)
        Me.GB_READ.TabIndex = 0
        Me.GB_READ.TabStop = False
        Me.GB_READ.Text = "Lecture"
        '
        'BT_CLEAN_READ
        '
        Me.BT_CLEAN_READ.Location = New System.Drawing.Point(473, 278)
        Me.BT_CLEAN_READ.Name = "BT_CLEAN_READ"
        Me.BT_CLEAN_READ.Size = New System.Drawing.Size(75, 23)
        Me.BT_CLEAN_READ.TabIndex = 4
        Me.BT_CLEAN_READ.Text = "Vider"
        Me.BT_CLEAN_READ.UseVisualStyleBackColor = True
        '
        'BT_READ
        '
        Me.BT_READ.Location = New System.Drawing.Point(341, 278)
        Me.BT_READ.Name = "BT_READ"
        Me.BT_READ.Size = New System.Drawing.Size(75, 23)
        Me.BT_READ.TabIndex = 3
        Me.BT_READ.Text = "Lire"
        Me.BT_READ.UseVisualStyleBackColor = True
        '
        'TXT_READ
        '
        Me.TXT_READ.Location = New System.Drawing.Point(7, 20)
        Me.TXT_READ.Multiline = True
        Me.TXT_READ.Name = "TXT_READ"
        Me.TXT_READ.ReadOnly = True
        Me.TXT_READ.Size = New System.Drawing.Size(910, 252)
        Me.TXT_READ.TabIndex = 0
        '
        'GB_WRITE
        '
        Me.GB_WRITE.Controls.Add(Me.TXT_WRITE)
        Me.GB_WRITE.Controls.Add(Me.CHK_START)
        Me.GB_WRITE.Controls.Add(Me.BT_WRITE)
        Me.GB_WRITE.Controls.Add(Me.BT_CLEAN_WRITE)
        Me.GB_WRITE.Location = New System.Drawing.Point(24, 346)
        Me.GB_WRITE.Name = "GB_WRITE"
        Me.GB_WRITE.Size = New System.Drawing.Size(923, 173)
        Me.GB_WRITE.TabIndex = 1
        Me.GB_WRITE.TabStop = False
        Me.GB_WRITE.Text = "Ecriture"
        '
        'TXT_WRITE
        '
        Me.TXT_WRITE.Location = New System.Drawing.Point(7, 19)
        Me.TXT_WRITE.Multiline = True
        Me.TXT_WRITE.Name = "TXT_WRITE"
        Me.TXT_WRITE.Size = New System.Drawing.Size(910, 119)
        Me.TXT_WRITE.TabIndex = 1
        '
        'CHK_START
        '
        Me.CHK_START.AutoSize = True
        Me.CHK_START.Location = New System.Drawing.Point(160, 149)
        Me.CHK_START.Name = "CHK_START"
        Me.CHK_START.Size = New System.Drawing.Size(111, 17)
        Me.CHK_START.TabIndex = 4
        Me.CHK_START.Text = "Réecrire au début"
        Me.CHK_START.UseVisualStyleBackColor = True
        '
        'BT_WRITE
        '
        Me.BT_WRITE.Location = New System.Drawing.Point(341, 144)
        Me.BT_WRITE.Name = "BT_WRITE"
        Me.BT_WRITE.Size = New System.Drawing.Size(75, 23)
        Me.BT_WRITE.TabIndex = 2
        Me.BT_WRITE.Text = "Ecrire"
        Me.BT_WRITE.UseVisualStyleBackColor = True
        '
        'BT_CLEAN_WRITE
        '
        Me.BT_CLEAN_WRITE.Location = New System.Drawing.Point(473, 144)
        Me.BT_CLEAN_WRITE.Name = "BT_CLEAN_WRITE"
        Me.BT_CLEAN_WRITE.Size = New System.Drawing.Size(75, 23)
        Me.BT_CLEAN_WRITE.TabIndex = 3
        Me.BT_CLEAN_WRITE.Text = "Vider"
        Me.BT_CLEAN_WRITE.UseVisualStyleBackColor = True
        '
        'BT_CLEARFILE
        '
        Me.BT_CLEARFILE.Location = New System.Drawing.Point(421, 554)
        Me.BT_CLEARFILE.Name = "BT_CLEARFILE"
        Me.BT_CLEARFILE.Size = New System.Drawing.Size(97, 23)
        Me.BT_CLEARFILE.TabIndex = 5
        Me.BT_CLEARFILE.Text = "Vider le fichier"
        Me.BT_CLEARFILE.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 619)
        Me.Controls.Add(Me.BT_CLEARFILE)
        Me.Controls.Add(Me.GB_WRITE)
        Me.Controls.Add(Me.GB_READ)
        Me.Name = "Main"
        Me.Text = "Manipulation Fichiers"
        Me.GB_READ.ResumeLayout(False)
        Me.GB_READ.PerformLayout()
        Me.GB_WRITE.ResumeLayout(False)
        Me.GB_WRITE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_READ As GroupBox
    Friend WithEvents TXT_READ As TextBox
    Friend WithEvents GB_WRITE As GroupBox
    Friend WithEvents BT_WRITE As Button
    Friend WithEvents BT_CLEAN_WRITE As Button
    Friend WithEvents TXT_WRITE As TextBox
    Friend WithEvents CHK_START As CheckBox
    Friend WithEvents BT_CLEAN_READ As Button
    Friend WithEvents BT_READ As Button
    Friend WithEvents BT_CLEARFILE As Button
End Class
