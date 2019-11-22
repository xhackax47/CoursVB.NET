<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditionMovie
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
        Me.PB_MOVIE_PICTURE = New System.Windows.Forms.PictureBox()
        Me.TXT_MOVIENAME = New System.Windows.Forms.TextBox()
        Me.ACTORS = New System.Windows.Forms.Label()
        Me.GENDER2 = New System.Windows.Forms.Label()
        Me.GENDER1 = New System.Windows.Forms.Label()
        Me.DIRECTOR_CARD = New System.Windows.Forms.Label()
        Me.RELEASE_DATE = New System.Windows.Forms.Label()
        Me.DT_RELEASE_DATE = New System.Windows.Forms.DateTimePicker()
        Me.DDL_DIRECTOR = New System.Windows.Forms.ComboBox()
        Me.DDL_GENDER1 = New System.Windows.Forms.ComboBox()
        Me.DDL_GENDER2 = New System.Windows.Forms.ComboBox()
        Me.TXT_ACTORS = New System.Windows.Forms.TextBox()
        Me.SUR20 = New System.Windows.Forms.Label()
        Me.NOTE = New System.Windows.Forms.Label()
        Me.PERSONAL_VIEW = New System.Windows.Forms.Label()
        Me.SYNOPSIS = New System.Windows.Forms.Label()
        Me.BT_SAVE = New System.Windows.Forms.Button()
        Me.NUM_NOTE = New System.Windows.Forms.NumericUpDown()
        Me.TXT_SYNOPSIS = New System.Windows.Forms.TextBox()
        Me.TXT_PERSONAL_VIEW = New System.Windows.Forms.TextBox()
        CType(Me.PB_MOVIE_PICTURE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_MOVIE_PICTURE
        '
        Me.PB_MOVIE_PICTURE.BackColor = System.Drawing.Color.White
        Me.PB_MOVIE_PICTURE.Location = New System.Drawing.Point(12, 12)
        Me.PB_MOVIE_PICTURE.Name = "PB_MOVIE_PICTURE"
        Me.PB_MOVIE_PICTURE.Size = New System.Drawing.Size(174, 212)
        Me.PB_MOVIE_PICTURE.TabIndex = 46
        Me.PB_MOVIE_PICTURE.TabStop = False
        '
        'TXT_MOVIENAME
        '
        Me.TXT_MOVIENAME.Location = New System.Drawing.Point(198, 12)
        Me.TXT_MOVIENAME.Name = "TXT_MOVIENAME"
        Me.TXT_MOVIENAME.Size = New System.Drawing.Size(318, 20)
        Me.TXT_MOVIENAME.TabIndex = 47
        '
        'ACTORS
        '
        Me.ACTORS.AutoSize = True
        Me.ACTORS.Location = New System.Drawing.Point(195, 160)
        Me.ACTORS.Name = "ACTORS"
        Me.ACTORS.Size = New System.Drawing.Size(49, 13)
        Me.ACTORS.TabIndex = 52
        Me.ACTORS.Text = "Acteurs :"
        '
        'GENDER2
        '
        Me.GENDER2.AutoSize = True
        Me.GENDER2.Location = New System.Drawing.Point(195, 133)
        Me.GENDER2.Name = "GENDER2"
        Me.GENDER2.Size = New System.Drawing.Size(51, 13)
        Me.GENDER2.TabIndex = 51
        Me.GENDER2.Text = "Genre 2 :"
        '
        'GENDER1
        '
        Me.GENDER1.AutoSize = True
        Me.GENDER1.Location = New System.Drawing.Point(195, 106)
        Me.GENDER1.Name = "GENDER1"
        Me.GENDER1.Size = New System.Drawing.Size(48, 13)
        Me.GENDER1.TabIndex = 50
        Me.GENDER1.Text = "Genre1 :"
        '
        'DIRECTOR_CARD
        '
        Me.DIRECTOR_CARD.AutoSize = True
        Me.DIRECTOR_CARD.Location = New System.Drawing.Point(195, 79)
        Me.DIRECTOR_CARD.Name = "DIRECTOR_CARD"
        Me.DIRECTOR_CARD.Size = New System.Drawing.Size(66, 13)
        Me.DIRECTOR_CARD.TabIndex = 49
        Me.DIRECTOR_CARD.Text = "Réalisateur :"
        '
        'RELEASE_DATE
        '
        Me.RELEASE_DATE.AutoSize = True
        Me.RELEASE_DATE.Location = New System.Drawing.Point(195, 56)
        Me.RELEASE_DATE.Name = "RELEASE_DATE"
        Me.RELEASE_DATE.Size = New System.Drawing.Size(79, 13)
        Me.RELEASE_DATE.TabIndex = 48
        Me.RELEASE_DATE.Text = "Date de sortie :"
        '
        'DT_RELEASE_DATE
        '
        Me.DT_RELEASE_DATE.Location = New System.Drawing.Point(280, 50)
        Me.DT_RELEASE_DATE.Name = "DT_RELEASE_DATE"
        Me.DT_RELEASE_DATE.Size = New System.Drawing.Size(200, 20)
        Me.DT_RELEASE_DATE.TabIndex = 53
        '
        'DDL_DIRECTOR
        '
        Me.DDL_DIRECTOR.FormattingEnabled = True
        Me.DDL_DIRECTOR.Location = New System.Drawing.Point(280, 76)
        Me.DDL_DIRECTOR.Name = "DDL_DIRECTOR"
        Me.DDL_DIRECTOR.Size = New System.Drawing.Size(200, 21)
        Me.DDL_DIRECTOR.TabIndex = 54
        '
        'DDL_GENDER1
        '
        Me.DDL_GENDER1.FormattingEnabled = True
        Me.DDL_GENDER1.Location = New System.Drawing.Point(280, 103)
        Me.DDL_GENDER1.Name = "DDL_GENDER1"
        Me.DDL_GENDER1.Size = New System.Drawing.Size(200, 21)
        Me.DDL_GENDER1.TabIndex = 55
        '
        'DDL_GENDER2
        '
        Me.DDL_GENDER2.FormattingEnabled = True
        Me.DDL_GENDER2.Location = New System.Drawing.Point(280, 130)
        Me.DDL_GENDER2.Name = "DDL_GENDER2"
        Me.DDL_GENDER2.Size = New System.Drawing.Size(200, 21)
        Me.DDL_GENDER2.TabIndex = 56
        '
        'TXT_ACTORS
        '
        Me.TXT_ACTORS.Location = New System.Drawing.Point(280, 157)
        Me.TXT_ACTORS.Multiline = True
        Me.TXT_ACTORS.Name = "TXT_ACTORS"
        Me.TXT_ACTORS.Size = New System.Drawing.Size(200, 67)
        Me.TXT_ACTORS.TabIndex = 57
        '
        'SUR20
        '
        Me.SUR20.AutoSize = True
        Me.SUR20.Location = New System.Drawing.Point(144, 553)
        Me.SUR20.Name = "SUR20"
        Me.SUR20.Size = New System.Drawing.Size(24, 13)
        Me.SUR20.TabIndex = 63
        Me.SUR20.Text = "/20"
        '
        'NOTE
        '
        Me.NOTE.AutoSize = True
        Me.NOTE.Location = New System.Drawing.Point(12, 551)
        Me.NOTE.Name = "NOTE"
        Me.NOTE.Size = New System.Drawing.Size(93, 13)
        Me.NOTE.TabIndex = 62
        Me.NOTE.Text = "Note personnelle :"
        '
        'PERSONAL_VIEW
        '
        Me.PERSONAL_VIEW.AutoSize = True
        Me.PERSONAL_VIEW.Location = New System.Drawing.Point(12, 396)
        Me.PERSONAL_VIEW.Name = "PERSONAL_VIEW"
        Me.PERSONAL_VIEW.Size = New System.Drawing.Size(82, 13)
        Me.PERSONAL_VIEW.TabIndex = 60
        Me.PERSONAL_VIEW.Text = "Avis personnel :"
        '
        'SYNOPSIS
        '
        Me.SYNOPSIS.AutoSize = True
        Me.SYNOPSIS.Location = New System.Drawing.Point(12, 240)
        Me.SYNOPSIS.Name = "SYNOPSIS"
        Me.SYNOPSIS.Size = New System.Drawing.Size(55, 13)
        Me.SYNOPSIS.TabIndex = 58
        Me.SYNOPSIS.Text = "Synopsis :"
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Location = New System.Drawing.Point(385, 623)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(130, 23)
        Me.BT_SAVE.TabIndex = 64
        Me.BT_SAVE.Text = "Enregistrer et fermer"
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'NUM_NOTE
        '
        Me.NUM_NOTE.Location = New System.Drawing.Point(111, 551)
        Me.NUM_NOTE.Name = "NUM_NOTE"
        Me.NUM_NOTE.Size = New System.Drawing.Size(27, 20)
        Me.NUM_NOTE.TabIndex = 65
        '
        'TXT_SYNOPSIS
        '
        Me.TXT_SYNOPSIS.Location = New System.Drawing.Point(15, 256)
        Me.TXT_SYNOPSIS.Multiline = True
        Me.TXT_SYNOPSIS.Name = "TXT_SYNOPSIS"
        Me.TXT_SYNOPSIS.Size = New System.Drawing.Size(468, 136)
        Me.TXT_SYNOPSIS.TabIndex = 66
        '
        'TXT_PERSONAL_VIEW
        '
        Me.TXT_PERSONAL_VIEW.Location = New System.Drawing.Point(15, 412)
        Me.TXT_PERSONAL_VIEW.Multiline = True
        Me.TXT_PERSONAL_VIEW.Name = "TXT_PERSONAL_VIEW"
        Me.TXT_PERSONAL_VIEW.Size = New System.Drawing.Size(468, 136)
        Me.TXT_PERSONAL_VIEW.TabIndex = 67
        '
        'AddEditionMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 658)
        Me.Controls.Add(Me.TXT_PERSONAL_VIEW)
        Me.Controls.Add(Me.TXT_SYNOPSIS)
        Me.Controls.Add(Me.NUM_NOTE)
        Me.Controls.Add(Me.BT_SAVE)
        Me.Controls.Add(Me.SUR20)
        Me.Controls.Add(Me.NOTE)
        Me.Controls.Add(Me.PERSONAL_VIEW)
        Me.Controls.Add(Me.SYNOPSIS)
        Me.Controls.Add(Me.TXT_ACTORS)
        Me.Controls.Add(Me.DDL_GENDER2)
        Me.Controls.Add(Me.DDL_GENDER1)
        Me.Controls.Add(Me.DDL_DIRECTOR)
        Me.Controls.Add(Me.DT_RELEASE_DATE)
        Me.Controls.Add(Me.ACTORS)
        Me.Controls.Add(Me.GENDER2)
        Me.Controls.Add(Me.GENDER1)
        Me.Controls.Add(Me.DIRECTOR_CARD)
        Me.Controls.Add(Me.RELEASE_DATE)
        Me.Controls.Add(Me.TXT_MOVIENAME)
        Me.Controls.Add(Me.PB_MOVIE_PICTURE)
        Me.Name = "AddEditionMovie"
        Me.Text = "Edition Film"
        CType(Me.PB_MOVIE_PICTURE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PB_MOVIE_PICTURE As PictureBox
    Friend WithEvents TXT_MOVIENAME As TextBox
    Friend WithEvents ACTORS As Label
    Friend WithEvents GENDER2 As Label
    Friend WithEvents GENDER1 As Label
    Friend WithEvents DIRECTOR_CARD As Label
    Friend WithEvents RELEASE_DATE As Label
    Friend WithEvents DT_RELEASE_DATE As DateTimePicker
    Friend WithEvents DDL_DIRECTOR As ComboBox
    Friend WithEvents DDL_GENDER1 As ComboBox
    Friend WithEvents DDL_GENDER2 As ComboBox
    Friend WithEvents TXT_ACTORS As TextBox
    Friend WithEvents SUR20 As Label
    Friend WithEvents NOTE As Label
    Friend WithEvents PERSONAL_VIEW As Label
    Friend WithEvents SYNOPSIS As Label
    Friend WithEvents BT_SAVE As Button
    Friend WithEvents NUM_NOTE As NumericUpDown
    Friend WithEvents TXT_SYNOPSIS As TextBox
    Friend WithEvents TXT_PERSONAL_VIEW As TextBox
End Class
