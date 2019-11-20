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
        Me.BT_1 = New System.Windows.Forms.Button()
        Me.TXT_CHK = New System.Windows.Forms.TextBox()
        Me.TXT_RBNB = New System.Windows.Forms.TextBox()
        Me.BT_2 = New System.Windows.Forms.Button()
        Me.TXT_RBCOL = New System.Windows.Forms.TextBox()
        Me.BT_3 = New System.Windows.Forms.Button()
        Me.CHK_1 = New System.Windows.Forms.CheckBox()
        Me.CHK_2 = New System.Windows.Forms.CheckBox()
        Me.CHK_4 = New System.Windows.Forms.CheckBox()
        Me.CHK_8 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_4 = New System.Windows.Forms.RadioButton()
        Me.RB_3 = New System.Windows.Forms.RadioButton()
        Me.RB_2 = New System.Windows.Forms.RadioButton()
        Me.RB_1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RB_JAUNE = New System.Windows.Forms.RadioButton()
        Me.RB_ROUGE = New System.Windows.Forms.RadioButton()
        Me.RB_BLEU = New System.Windows.Forms.RadioButton()
        Me.RB_VERT = New System.Windows.Forms.RadioButton()
        Me.CB_CHOICE = New System.Windows.Forms.ComboBox()
        Me.TXT_CHOICE = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_1
        '
        Me.BT_1.Location = New System.Drawing.Point(37, 272)
        Me.BT_1.Name = "BT_1"
        Me.BT_1.Size = New System.Drawing.Size(100, 23)
        Me.BT_1.TabIndex = 0
        Me.BT_1.Text = "BT_1"
        Me.BT_1.UseVisualStyleBackColor = True
        '
        'TXT_CHK
        '
        Me.TXT_CHK.Location = New System.Drawing.Point(37, 316)
        Me.TXT_CHK.Name = "TXT_CHK"
        Me.TXT_CHK.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CHK.TabIndex = 1
        '
        'TXT_RBNB
        '
        Me.TXT_RBNB.Location = New System.Drawing.Point(184, 316)
        Me.TXT_RBNB.Name = "TXT_RBNB"
        Me.TXT_RBNB.Size = New System.Drawing.Size(100, 20)
        Me.TXT_RBNB.TabIndex = 3
        '
        'BT_2
        '
        Me.BT_2.Location = New System.Drawing.Point(184, 272)
        Me.BT_2.Name = "BT_2"
        Me.BT_2.Size = New System.Drawing.Size(100, 23)
        Me.BT_2.TabIndex = 2
        Me.BT_2.Text = "BT_2"
        Me.BT_2.UseVisualStyleBackColor = True
        '
        'TXT_RBCOL
        '
        Me.TXT_RBCOL.Location = New System.Drawing.Point(332, 316)
        Me.TXT_RBCOL.Name = "TXT_RBCOL"
        Me.TXT_RBCOL.Size = New System.Drawing.Size(100, 20)
        Me.TXT_RBCOL.TabIndex = 5
        '
        'BT_3
        '
        Me.BT_3.Location = New System.Drawing.Point(332, 272)
        Me.BT_3.Name = "BT_3"
        Me.BT_3.Size = New System.Drawing.Size(100, 23)
        Me.BT_3.TabIndex = 4
        Me.BT_3.Text = "BT_3"
        Me.BT_3.UseVisualStyleBackColor = True
        '
        'CHK_1
        '
        Me.CHK_1.AutoSize = True
        Me.CHK_1.Location = New System.Drawing.Point(6, 19)
        Me.CHK_1.Name = "CHK_1"
        Me.CHK_1.Size = New System.Drawing.Size(32, 17)
        Me.CHK_1.TabIndex = 6
        Me.CHK_1.Text = "1"
        Me.CHK_1.UseVisualStyleBackColor = True
        '
        'CHK_2
        '
        Me.CHK_2.AutoSize = True
        Me.CHK_2.Location = New System.Drawing.Point(6, 42)
        Me.CHK_2.Name = "CHK_2"
        Me.CHK_2.Size = New System.Drawing.Size(32, 17)
        Me.CHK_2.TabIndex = 7
        Me.CHK_2.Text = "2"
        Me.CHK_2.UseVisualStyleBackColor = True
        '
        'CHK_4
        '
        Me.CHK_4.AutoSize = True
        Me.CHK_4.Location = New System.Drawing.Point(6, 65)
        Me.CHK_4.Name = "CHK_4"
        Me.CHK_4.Size = New System.Drawing.Size(32, 17)
        Me.CHK_4.TabIndex = 8
        Me.CHK_4.Text = "4"
        Me.CHK_4.UseVisualStyleBackColor = True
        '
        'CHK_8
        '
        Me.CHK_8.AutoSize = True
        Me.CHK_8.Location = New System.Drawing.Point(6, 88)
        Me.CHK_8.Name = "CHK_8"
        Me.CHK_8.Size = New System.Drawing.Size(32, 17)
        Me.CHK_8.TabIndex = 9
        Me.CHK_8.Text = "8"
        Me.CHK_8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CHK_1)
        Me.GroupBox1.Controls.Add(Me.CHK_8)
        Me.GroupBox1.Controls.Add(Me.CHK_2)
        Me.GroupBox1.Controls.Add(Me.CHK_4)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(51, 114)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RB_4)
        Me.GroupBox2.Controls.Add(Me.RB_3)
        Me.GroupBox2.Controls.Add(Me.RB_2)
        Me.GroupBox2.Controls.Add(Me.RB_1)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(51, 114)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'RB_4
        '
        Me.RB_4.AutoSize = True
        Me.RB_4.Location = New System.Drawing.Point(6, 87)
        Me.RB_4.Name = "RB_4"
        Me.RB_4.Size = New System.Drawing.Size(31, 17)
        Me.RB_4.TabIndex = 3
        Me.RB_4.TabStop = True
        Me.RB_4.Text = "4"
        Me.RB_4.UseVisualStyleBackColor = True
        '
        'RB_3
        '
        Me.RB_3.AutoSize = True
        Me.RB_3.Location = New System.Drawing.Point(6, 64)
        Me.RB_3.Name = "RB_3"
        Me.RB_3.Size = New System.Drawing.Size(31, 17)
        Me.RB_3.TabIndex = 2
        Me.RB_3.TabStop = True
        Me.RB_3.Text = "3"
        Me.RB_3.UseVisualStyleBackColor = True
        '
        'RB_2
        '
        Me.RB_2.AutoSize = True
        Me.RB_2.Location = New System.Drawing.Point(6, 41)
        Me.RB_2.Name = "RB_2"
        Me.RB_2.Size = New System.Drawing.Size(31, 17)
        Me.RB_2.TabIndex = 1
        Me.RB_2.TabStop = True
        Me.RB_2.Text = "2"
        Me.RB_2.UseVisualStyleBackColor = True
        '
        'RB_1
        '
        Me.RB_1.AutoSize = True
        Me.RB_1.Location = New System.Drawing.Point(6, 18)
        Me.RB_1.Name = "RB_1"
        Me.RB_1.Size = New System.Drawing.Size(31, 17)
        Me.RB_1.TabIndex = 0
        Me.RB_1.TabStop = True
        Me.RB_1.Text = "1"
        Me.RB_1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_JAUNE)
        Me.GroupBox3.Controls.Add(Me.RB_ROUGE)
        Me.GroupBox3.Controls.Add(Me.RB_BLEU)
        Me.GroupBox3.Controls.Add(Me.RB_VERT)
        Me.GroupBox3.Location = New System.Drawing.Point(332, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(100, 114)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'RB_JAUNE
        '
        Me.RB_JAUNE.AutoSize = True
        Me.RB_JAUNE.Location = New System.Drawing.Point(6, 87)
        Me.RB_JAUNE.Name = "RB_JAUNE"
        Me.RB_JAUNE.Size = New System.Drawing.Size(54, 17)
        Me.RB_JAUNE.TabIndex = 5
        Me.RB_JAUNE.TabStop = True
        Me.RB_JAUNE.Text = "Jaune"
        Me.RB_JAUNE.UseVisualStyleBackColor = True
        '
        'RB_ROUGE
        '
        Me.RB_ROUGE.AutoSize = True
        Me.RB_ROUGE.Location = New System.Drawing.Point(6, 18)
        Me.RB_ROUGE.Name = "RB_ROUGE"
        Me.RB_ROUGE.Size = New System.Drawing.Size(57, 17)
        Me.RB_ROUGE.TabIndex = 4
        Me.RB_ROUGE.TabStop = True
        Me.RB_ROUGE.Text = "Rouge"
        Me.RB_ROUGE.UseVisualStyleBackColor = True
        '
        'RB_BLEU
        '
        Me.RB_BLEU.AutoSize = True
        Me.RB_BLEU.Location = New System.Drawing.Point(6, 64)
        Me.RB_BLEU.Name = "RB_BLEU"
        Me.RB_BLEU.Size = New System.Drawing.Size(46, 17)
        Me.RB_BLEU.TabIndex = 3
        Me.RB_BLEU.TabStop = True
        Me.RB_BLEU.Text = "Bleu"
        Me.RB_BLEU.UseVisualStyleBackColor = True
        '
        'RB_VERT
        '
        Me.RB_VERT.AutoSize = True
        Me.RB_VERT.Location = New System.Drawing.Point(6, 41)
        Me.RB_VERT.Name = "RB_VERT"
        Me.RB_VERT.Size = New System.Drawing.Size(44, 17)
        Me.RB_VERT.TabIndex = 1
        Me.RB_VERT.TabStop = True
        Me.RB_VERT.Text = "Vert"
        Me.RB_VERT.UseVisualStyleBackColor = True
        '
        'CB_CHOICE
        '
        Me.CB_CHOICE.FormattingEnabled = True
        Me.CB_CHOICE.Location = New System.Drawing.Point(184, 207)
        Me.CB_CHOICE.Name = "CB_CHOICE"
        Me.CB_CHOICE.Size = New System.Drawing.Size(121, 21)
        Me.CB_CHOICE.TabIndex = 12
        '
        'TXT_CHOICE
        '
        Me.TXT_CHOICE.Location = New System.Drawing.Point(184, 235)
        Me.TXT_CHOICE.Name = "TXT_CHOICE"
        Me.TXT_CHOICE.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CHOICE.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 348)
        Me.Controls.Add(Me.TXT_CHOICE)
        Me.Controls.Add(Me.CB_CHOICE)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TXT_RBCOL)
        Me.Controls.Add(Me.BT_3)
        Me.Controls.Add(Me.TXT_RBNB)
        Me.Controls.Add(Me.BT_2)
        Me.Controls.Add(Me.TXT_CHK)
        Me.Controls.Add(Me.BT_1)
        Me.Name = "Form1"
        Me.Text = "Programme Test"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_1 As Button
    Friend WithEvents TXT_CHK As TextBox
    Friend WithEvents TXT_RBNB As TextBox
    Friend WithEvents BT_2 As Button
    Friend WithEvents TXT_RBCOL As TextBox
    Friend WithEvents BT_3 As Button
    Friend WithEvents CHK_1 As CheckBox
    Friend WithEvents CHK_2 As CheckBox
    Friend WithEvents CHK_4 As CheckBox
    Friend WithEvents CHK_8 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RB_4 As RadioButton
    Friend WithEvents RB_1 As RadioButton
    Friend WithEvents RB_JAUNE As RadioButton
    Friend WithEvents RB_ROUGE As RadioButton
    Friend WithEvents RB_BLEU As RadioButton
    Friend WithEvents RB_VERT As RadioButton
    Friend WithEvents RB_2 As RadioButton
    Friend WithEvents RB_3 As RadioButton
    Friend WithEvents CB_CHOICE As ComboBox
    Friend WithEvents TXT_CHOICE As TextBox
End Class
