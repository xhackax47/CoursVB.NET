<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZBiblio
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
        Me.GB_ZBIBLIO = New System.Windows.Forms.GroupBox()
        Me.GB_MOVIESLIST = New System.Windows.Forms.GroupBox()
        Me.LB_LIST_MOVIES = New System.Windows.Forms.ListBox()
        Me.GB_MOVIESEARCH = New System.Windows.Forms.GroupBox()
        Me.DDL_ACTOR = New System.Windows.Forms.ComboBox()
        Me.DDL_DIRECTOR = New System.Windows.Forms.ComboBox()
        Me.DDL_GENDER = New System.Windows.Forms.ComboBox()
        Me.DDL_YEAR = New System.Windows.Forms.ComboBox()
        Me.TXT_TITLE = New System.Windows.Forms.TextBox()
        Me.LBL_YEAR = New System.Windows.Forms.Label()
        Me.LBL_GENDER = New System.Windows.Forms.Label()
        Me.DIRECTOR = New System.Windows.Forms.Label()
        Me.LBL_ACTOR = New System.Windows.Forms.Label()
        Me.TITLE = New System.Windows.Forms.Label()
        Me.BT_SEARCH = New System.Windows.Forms.Button()
        Me.BT_DELETE_SEARCH = New System.Windows.Forms.Button()
        Me.GB_CARD = New System.Windows.Forms.GroupBox()
        Me.PB_MOVIE_PICTURE = New System.Windows.Forms.PictureBox()
        Me.BT_UPDATE_CARD = New System.Windows.Forms.Button()
        Me.BT_NEW_CARD = New System.Windows.Forms.Button()
        Me.BT_DELETE_CARD = New System.Windows.Forms.Button()
        Me.LBL_NOTE = New System.Windows.Forms.Label()
        Me.SUR20 = New System.Windows.Forms.Label()
        Me.NOTE = New System.Windows.Forms.Label()
        Me.LBL_PERSONAL_VIEW = New System.Windows.Forms.TextBox()
        Me.PERSONAL_VIEW = New System.Windows.Forms.Label()
        Me.LBL_SYNOPSIS = New System.Windows.Forms.TextBox()
        Me.SYNOPSIS = New System.Windows.Forms.Label()
        Me.LBL_ACTORS = New System.Windows.Forms.Label()
        Me.LBL_GENDER2 = New System.Windows.Forms.Label()
        Me.LBL_GENDER1 = New System.Windows.Forms.Label()
        Me.LBL_DIRECTOR = New System.Windows.Forms.Label()
        Me.LBL_RELEASE_DATE = New System.Windows.Forms.Label()
        Me.ACTORS = New System.Windows.Forms.Label()
        Me.GENDER2 = New System.Windows.Forms.Label()
        Me.GENDER1 = New System.Windows.Forms.Label()
        Me.DIRECTOR_CARD = New System.Windows.Forms.Label()
        Me.RELEASE_DATE = New System.Windows.Forms.Label()
        Me.LBL_TITLE = New System.Windows.Forms.Label()
        Me.GB_ZBIBLIO.SuspendLayout()
        Me.GB_MOVIESLIST.SuspendLayout()
        Me.GB_MOVIESEARCH.SuspendLayout()
        Me.GB_CARD.SuspendLayout()
        CType(Me.PB_MOVIE_PICTURE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_ZBIBLIO
        '
        Me.GB_ZBIBLIO.Controls.Add(Me.GB_MOVIESLIST)
        Me.GB_ZBIBLIO.Controls.Add(Me.GB_MOVIESEARCH)
        Me.GB_ZBIBLIO.Controls.Add(Me.GB_CARD)
        Me.GB_ZBIBLIO.Location = New System.Drawing.Point(13, 13)
        Me.GB_ZBIBLIO.Name = "GB_ZBIBLIO"
        Me.GB_ZBIBLIO.Size = New System.Drawing.Size(906, 633)
        Me.GB_ZBIBLIO.TabIndex = 1
        Me.GB_ZBIBLIO.TabStop = False
        '
        'GB_MOVIESLIST
        '
        Me.GB_MOVIESLIST.Controls.Add(Me.LB_LIST_MOVIES)
        Me.GB_MOVIESLIST.Location = New System.Drawing.Point(7, 349)
        Me.GB_MOVIESLIST.Name = "GB_MOVIESLIST"
        Me.GB_MOVIESLIST.Size = New System.Drawing.Size(451, 252)
        Me.GB_MOVIESLIST.TabIndex = 3
        Me.GB_MOVIESLIST.TabStop = False
        Me.GB_MOVIESLIST.Text = "Liste des films"
        '
        'LB_LIST_MOVIES
        '
        Me.LB_LIST_MOVIES.FormattingEnabled = True
        Me.LB_LIST_MOVIES.Location = New System.Drawing.Point(7, 20)
        Me.LB_LIST_MOVIES.Name = "LB_LIST_MOVIES"
        Me.LB_LIST_MOVIES.Size = New System.Drawing.Size(438, 225)
        Me.LB_LIST_MOVIES.TabIndex = 0
        '
        'GB_MOVIESEARCH
        '
        Me.GB_MOVIESEARCH.Controls.Add(Me.DDL_ACTOR)
        Me.GB_MOVIESEARCH.Controls.Add(Me.DDL_DIRECTOR)
        Me.GB_MOVIESEARCH.Controls.Add(Me.DDL_GENDER)
        Me.GB_MOVIESEARCH.Controls.Add(Me.DDL_YEAR)
        Me.GB_MOVIESEARCH.Controls.Add(Me.TXT_TITLE)
        Me.GB_MOVIESEARCH.Controls.Add(Me.LBL_YEAR)
        Me.GB_MOVIESEARCH.Controls.Add(Me.LBL_GENDER)
        Me.GB_MOVIESEARCH.Controls.Add(Me.DIRECTOR)
        Me.GB_MOVIESEARCH.Controls.Add(Me.LBL_ACTOR)
        Me.GB_MOVIESEARCH.Controls.Add(Me.TITLE)
        Me.GB_MOVIESEARCH.Controls.Add(Me.BT_SEARCH)
        Me.GB_MOVIESEARCH.Controls.Add(Me.BT_DELETE_SEARCH)
        Me.GB_MOVIESEARCH.Location = New System.Drawing.Point(7, 19)
        Me.GB_MOVIESEARCH.Name = "GB_MOVIESEARCH"
        Me.GB_MOVIESEARCH.Size = New System.Drawing.Size(451, 324)
        Me.GB_MOVIESEARCH.TabIndex = 2
        Me.GB_MOVIESEARCH.TabStop = False
        Me.GB_MOVIESEARCH.Text = "Recherche"
        '
        'DDL_ACTOR
        '
        Me.DDL_ACTOR.FormattingEnabled = True
        Me.DDL_ACTOR.Location = New System.Drawing.Point(103, 75)
        Me.DDL_ACTOR.Name = "DDL_ACTOR"
        Me.DDL_ACTOR.Size = New System.Drawing.Size(267, 21)
        Me.DDL_ACTOR.TabIndex = 11
        '
        'DDL_DIRECTOR
        '
        Me.DDL_DIRECTOR.FormattingEnabled = True
        Me.DDL_DIRECTOR.Location = New System.Drawing.Point(103, 125)
        Me.DDL_DIRECTOR.Name = "DDL_DIRECTOR"
        Me.DDL_DIRECTOR.Size = New System.Drawing.Size(267, 21)
        Me.DDL_DIRECTOR.TabIndex = 10
        '
        'DDL_GENDER
        '
        Me.DDL_GENDER.FormattingEnabled = True
        Me.DDL_GENDER.Location = New System.Drawing.Point(103, 170)
        Me.DDL_GENDER.Name = "DDL_GENDER"
        Me.DDL_GENDER.Size = New System.Drawing.Size(267, 21)
        Me.DDL_GENDER.TabIndex = 9
        '
        'DDL_YEAR
        '
        Me.DDL_YEAR.FormattingEnabled = True
        Me.DDL_YEAR.Location = New System.Drawing.Point(103, 216)
        Me.DDL_YEAR.Name = "DDL_YEAR"
        Me.DDL_YEAR.Size = New System.Drawing.Size(81, 21)
        Me.DDL_YEAR.TabIndex = 8
        '
        'TXT_TITLE
        '
        Me.TXT_TITLE.Location = New System.Drawing.Point(103, 28)
        Me.TXT_TITLE.Name = "TXT_TITLE"
        Me.TXT_TITLE.Size = New System.Drawing.Size(267, 20)
        Me.TXT_TITLE.TabIndex = 7
        '
        'LBL_YEAR
        '
        Me.LBL_YEAR.AutoSize = True
        Me.LBL_YEAR.Location = New System.Drawing.Point(17, 219)
        Me.LBL_YEAR.Name = "LBL_YEAR"
        Me.LBL_YEAR.Size = New System.Drawing.Size(44, 13)
        Me.LBL_YEAR.TabIndex = 6
        Me.LBL_YEAR.Text = "Année :"
        '
        'LBL_GENDER
        '
        Me.LBL_GENDER.AutoSize = True
        Me.LBL_GENDER.Location = New System.Drawing.Point(17, 173)
        Me.LBL_GENDER.Name = "LBL_GENDER"
        Me.LBL_GENDER.Size = New System.Drawing.Size(42, 13)
        Me.LBL_GENDER.TabIndex = 5
        Me.LBL_GENDER.Text = "Genre :"
        '
        'DIRECTOR
        '
        Me.DIRECTOR.AutoSize = True
        Me.DIRECTOR.Location = New System.Drawing.Point(17, 128)
        Me.DIRECTOR.Name = "DIRECTOR"
        Me.DIRECTOR.Size = New System.Drawing.Size(66, 13)
        Me.DIRECTOR.TabIndex = 4
        Me.DIRECTOR.Text = "Réalisateur :"
        '
        'LBL_ACTOR
        '
        Me.LBL_ACTOR.AutoSize = True
        Me.LBL_ACTOR.Location = New System.Drawing.Point(17, 78)
        Me.LBL_ACTOR.Name = "LBL_ACTOR"
        Me.LBL_ACTOR.Size = New System.Drawing.Size(44, 13)
        Me.LBL_ACTOR.TabIndex = 3
        Me.LBL_ACTOR.Text = "Acteur :"
        '
        'TITLE
        '
        Me.TITLE.AutoSize = True
        Me.TITLE.Location = New System.Drawing.Point(17, 28)
        Me.TITLE.Name = "TITLE"
        Me.TITLE.Size = New System.Drawing.Size(34, 13)
        Me.TITLE.TabIndex = 2
        Me.TITLE.Text = "Titre :"
        '
        'BT_SEARCH
        '
        Me.BT_SEARCH.Location = New System.Drawing.Point(295, 295)
        Me.BT_SEARCH.Name = "BT_SEARCH"
        Me.BT_SEARCH.Size = New System.Drawing.Size(75, 23)
        Me.BT_SEARCH.TabIndex = 1
        Me.BT_SEARCH.Text = "Recherche"
        Me.BT_SEARCH.UseVisualStyleBackColor = True
        '
        'BT_DELETE_SEARCH
        '
        Me.BT_DELETE_SEARCH.Location = New System.Drawing.Point(68, 295)
        Me.BT_DELETE_SEARCH.Name = "BT_DELETE_SEARCH"
        Me.BT_DELETE_SEARCH.Size = New System.Drawing.Size(104, 23)
        Me.BT_DELETE_SEARCH.TabIndex = 0
        Me.BT_DELETE_SEARCH.Text = "Effacer les critères"
        Me.BT_DELETE_SEARCH.UseVisualStyleBackColor = True
        '
        'GB_CARD
        '
        Me.GB_CARD.Controls.Add(Me.PB_MOVIE_PICTURE)
        Me.GB_CARD.Controls.Add(Me.BT_UPDATE_CARD)
        Me.GB_CARD.Controls.Add(Me.BT_NEW_CARD)
        Me.GB_CARD.Controls.Add(Me.BT_DELETE_CARD)
        Me.GB_CARD.Controls.Add(Me.LBL_NOTE)
        Me.GB_CARD.Controls.Add(Me.SUR20)
        Me.GB_CARD.Controls.Add(Me.NOTE)
        Me.GB_CARD.Controls.Add(Me.LBL_PERSONAL_VIEW)
        Me.GB_CARD.Controls.Add(Me.PERSONAL_VIEW)
        Me.GB_CARD.Controls.Add(Me.LBL_SYNOPSIS)
        Me.GB_CARD.Controls.Add(Me.SYNOPSIS)
        Me.GB_CARD.Controls.Add(Me.LBL_ACTORS)
        Me.GB_CARD.Controls.Add(Me.LBL_GENDER2)
        Me.GB_CARD.Controls.Add(Me.LBL_GENDER1)
        Me.GB_CARD.Controls.Add(Me.LBL_DIRECTOR)
        Me.GB_CARD.Controls.Add(Me.LBL_RELEASE_DATE)
        Me.GB_CARD.Controls.Add(Me.ACTORS)
        Me.GB_CARD.Controls.Add(Me.GENDER2)
        Me.GB_CARD.Controls.Add(Me.GENDER1)
        Me.GB_CARD.Controls.Add(Me.DIRECTOR_CARD)
        Me.GB_CARD.Controls.Add(Me.RELEASE_DATE)
        Me.GB_CARD.Controls.Add(Me.LBL_TITLE)
        Me.GB_CARD.Location = New System.Drawing.Point(464, 19)
        Me.GB_CARD.Name = "GB_CARD"
        Me.GB_CARD.Size = New System.Drawing.Size(429, 608)
        Me.GB_CARD.TabIndex = 1
        Me.GB_CARD.TabStop = False
        Me.GB_CARD.Text = "Fiche détaillée"
        '
        'PB_MOVIE_PICTURE
        '
        Me.PB_MOVIE_PICTURE.BackColor = System.Drawing.Color.White
        Me.PB_MOVIE_PICTURE.Location = New System.Drawing.Point(7, 20)
        Me.PB_MOVIE_PICTURE.Name = "PB_MOVIE_PICTURE"
        Me.PB_MOVIE_PICTURE.Size = New System.Drawing.Size(174, 212)
        Me.PB_MOVIE_PICTURE.TabIndex = 45
        Me.PB_MOVIE_PICTURE.TabStop = False
        '
        'BT_UPDATE_CARD
        '
        Me.BT_UPDATE_CARD.Location = New System.Drawing.Point(284, 559)
        Me.BT_UPDATE_CARD.Name = "BT_UPDATE_CARD"
        Me.BT_UPDATE_CARD.Size = New System.Drawing.Size(122, 23)
        Me.BT_UPDATE_CARD.TabIndex = 44
        Me.BT_UPDATE_CARD.Text = "Modifier cette fiche"
        Me.BT_UPDATE_CARD.UseVisualStyleBackColor = True
        '
        'BT_NEW_CARD
        '
        Me.BT_NEW_CARD.Location = New System.Drawing.Point(156, 559)
        Me.BT_NEW_CARD.Name = "BT_NEW_CARD"
        Me.BT_NEW_CARD.Size = New System.Drawing.Size(122, 23)
        Me.BT_NEW_CARD.TabIndex = 43
        Me.BT_NEW_CARD.Text = "Créer une nouvelle fiche"
        Me.BT_NEW_CARD.UseVisualStyleBackColor = True
        '
        'BT_DELETE_CARD
        '
        Me.BT_DELETE_CARD.Location = New System.Drawing.Point(28, 559)
        Me.BT_DELETE_CARD.Name = "BT_DELETE_CARD"
        Me.BT_DELETE_CARD.Size = New System.Drawing.Size(122, 23)
        Me.BT_DELETE_CARD.TabIndex = 42
        Me.BT_DELETE_CARD.Text = "Supprimer cette fiche"
        Me.BT_DELETE_CARD.UseVisualStyleBackColor = True
        '
        'LBL_NOTE
        '
        Me.LBL_NOTE.AutoSize = True
        Me.LBL_NOTE.ForeColor = System.Drawing.Color.Red
        Me.LBL_NOTE.Location = New System.Drawing.Point(111, 511)
        Me.LBL_NOTE.Name = "LBL_NOTE"
        Me.LBL_NOTE.Size = New System.Drawing.Size(0, 13)
        Me.LBL_NOTE.TabIndex = 41
        '
        'SUR20
        '
        Me.SUR20.AutoSize = True
        Me.SUR20.Location = New System.Drawing.Point(117, 511)
        Me.SUR20.Name = "SUR20"
        Me.SUR20.Size = New System.Drawing.Size(24, 13)
        Me.SUR20.TabIndex = 40
        Me.SUR20.Text = "/20"
        '
        'NOTE
        '
        Me.NOTE.AutoSize = True
        Me.NOTE.Location = New System.Drawing.Point(12, 511)
        Me.NOTE.Name = "NOTE"
        Me.NOTE.Size = New System.Drawing.Size(93, 13)
        Me.NOTE.TabIndex = 39
        Me.NOTE.Text = "Note personnelle :"
        '
        'LBL_PERSONAL_VIEW
        '
        Me.LBL_PERSONAL_VIEW.Location = New System.Drawing.Point(15, 415)
        Me.LBL_PERSONAL_VIEW.Multiline = True
        Me.LBL_PERSONAL_VIEW.Name = "LBL_PERSONAL_VIEW"
        Me.LBL_PERSONAL_VIEW.Size = New System.Drawing.Size(408, 93)
        Me.LBL_PERSONAL_VIEW.TabIndex = 38
        '
        'PERSONAL_VIEW
        '
        Me.PERSONAL_VIEW.AutoSize = True
        Me.PERSONAL_VIEW.Location = New System.Drawing.Point(12, 399)
        Me.PERSONAL_VIEW.Name = "PERSONAL_VIEW"
        Me.PERSONAL_VIEW.Size = New System.Drawing.Size(82, 13)
        Me.PERSONAL_VIEW.TabIndex = 37
        Me.PERSONAL_VIEW.Text = "Avis personnel :"
        '
        'LBL_SYNOPSIS
        '
        Me.LBL_SYNOPSIS.Location = New System.Drawing.Point(15, 260)
        Me.LBL_SYNOPSIS.Multiline = True
        Me.LBL_SYNOPSIS.Name = "LBL_SYNOPSIS"
        Me.LBL_SYNOPSIS.Size = New System.Drawing.Size(408, 136)
        Me.LBL_SYNOPSIS.TabIndex = 36
        '
        'SYNOPSIS
        '
        Me.SYNOPSIS.AutoSize = True
        Me.SYNOPSIS.Location = New System.Drawing.Point(12, 243)
        Me.SYNOPSIS.Name = "SYNOPSIS"
        Me.SYNOPSIS.Size = New System.Drawing.Size(55, 13)
        Me.SYNOPSIS.TabIndex = 35
        Me.SYNOPSIS.Text = "Synopsis :"
        '
        'LBL_ACTORS
        '
        Me.LBL_ACTORS.AutoSize = True
        Me.LBL_ACTORS.BackColor = System.Drawing.Color.Aqua
        Me.LBL_ACTORS.Location = New System.Drawing.Point(299, 216)
        Me.LBL_ACTORS.Name = "LBL_ACTORS"
        Me.LBL_ACTORS.Size = New System.Drawing.Size(76, 13)
        Me.LBL_ACTORS.TabIndex = 33
        Me.LBL_ACTORS.Text = "LBL_ACTORS"
        '
        'LBL_GENDER2
        '
        Me.LBL_GENDER2.AutoSize = True
        Me.LBL_GENDER2.BackColor = System.Drawing.Color.Aqua
        Me.LBL_GENDER2.Location = New System.Drawing.Point(299, 178)
        Me.LBL_GENDER2.Name = "LBL_GENDER2"
        Me.LBL_GENDER2.Size = New System.Drawing.Size(84, 13)
        Me.LBL_GENDER2.TabIndex = 32
        Me.LBL_GENDER2.Text = "LBL_GENDER2"
        '
        'LBL_GENDER1
        '
        Me.LBL_GENDER1.AutoSize = True
        Me.LBL_GENDER1.BackColor = System.Drawing.Color.Aqua
        Me.LBL_GENDER1.Location = New System.Drawing.Point(299, 133)
        Me.LBL_GENDER1.Name = "LBL_GENDER1"
        Me.LBL_GENDER1.Size = New System.Drawing.Size(84, 13)
        Me.LBL_GENDER1.TabIndex = 31
        Me.LBL_GENDER1.Text = "LBL_GENDER1"
        '
        'LBL_DIRECTOR
        '
        Me.LBL_DIRECTOR.AutoSize = True
        Me.LBL_DIRECTOR.BackColor = System.Drawing.Color.Aqua
        Me.LBL_DIRECTOR.Location = New System.Drawing.Point(299, 102)
        Me.LBL_DIRECTOR.Name = "LBL_DIRECTOR"
        Me.LBL_DIRECTOR.Size = New System.Drawing.Size(60, 13)
        Me.LBL_DIRECTOR.TabIndex = 30
        Me.LBL_DIRECTOR.Text = "LBL_REAL"
        '
        'LBL_RELEASE_DATE
        '
        Me.LBL_RELEASE_DATE.AutoSize = True
        Me.LBL_RELEASE_DATE.BackColor = System.Drawing.Color.Aqua
        Me.LBL_RELEASE_DATE.Location = New System.Drawing.Point(299, 75)
        Me.LBL_RELEASE_DATE.Name = "LBL_RELEASE_DATE"
        Me.LBL_RELEASE_DATE.Size = New System.Drawing.Size(116, 13)
        Me.LBL_RELEASE_DATE.TabIndex = 29
        Me.LBL_RELEASE_DATE.Text = "LBL_RELEASE_DATE"
        '
        'ACTORS
        '
        Me.ACTORS.AutoSize = True
        Me.ACTORS.Location = New System.Drawing.Point(187, 216)
        Me.ACTORS.Name = "ACTORS"
        Me.ACTORS.Size = New System.Drawing.Size(49, 13)
        Me.ACTORS.TabIndex = 28
        Me.ACTORS.Text = "Acteurs :"
        '
        'GENDER2
        '
        Me.GENDER2.AutoSize = True
        Me.GENDER2.Location = New System.Drawing.Point(187, 178)
        Me.GENDER2.Name = "GENDER2"
        Me.GENDER2.Size = New System.Drawing.Size(51, 13)
        Me.GENDER2.TabIndex = 27
        Me.GENDER2.Text = "Genre 2 :"
        '
        'GENDER1
        '
        Me.GENDER1.AutoSize = True
        Me.GENDER1.Location = New System.Drawing.Point(187, 133)
        Me.GENDER1.Name = "GENDER1"
        Me.GENDER1.Size = New System.Drawing.Size(48, 13)
        Me.GENDER1.TabIndex = 26
        Me.GENDER1.Text = "Genre1 :"
        '
        'DIRECTOR_CARD
        '
        Me.DIRECTOR_CARD.AutoSize = True
        Me.DIRECTOR_CARD.Location = New System.Drawing.Point(187, 102)
        Me.DIRECTOR_CARD.Name = "DIRECTOR_CARD"
        Me.DIRECTOR_CARD.Size = New System.Drawing.Size(66, 13)
        Me.DIRECTOR_CARD.TabIndex = 25
        Me.DIRECTOR_CARD.Text = "Réalisateur :"
        '
        'RELEASE_DATE
        '
        Me.RELEASE_DATE.AutoSize = True
        Me.RELEASE_DATE.Location = New System.Drawing.Point(187, 75)
        Me.RELEASE_DATE.Name = "RELEASE_DATE"
        Me.RELEASE_DATE.Size = New System.Drawing.Size(79, 13)
        Me.RELEASE_DATE.TabIndex = 24
        Me.RELEASE_DATE.Text = "Date de sortie :"
        '
        'LBL_TITLE
        '
        Me.LBL_TITLE.AutoSize = True
        Me.LBL_TITLE.BackColor = System.Drawing.Color.Aqua
        Me.LBL_TITLE.Location = New System.Drawing.Point(222, 28)
        Me.LBL_TITLE.Name = "LBL_TITLE"
        Me.LBL_TITLE.Size = New System.Drawing.Size(62, 13)
        Me.LBL_TITLE.TabIndex = 23
        Me.LBL_TITLE.Text = "LBL_TITLE"
        Me.LBL_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZBiblio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 658)
        Me.Controls.Add(Me.GB_ZBIBLIO)
        Me.Name = "ZBiblio"
        Me.Text = "ZBiblio"
        Me.GB_ZBIBLIO.ResumeLayout(False)
        Me.GB_MOVIESLIST.ResumeLayout(False)
        Me.GB_MOVIESEARCH.ResumeLayout(False)
        Me.GB_MOVIESEARCH.PerformLayout()
        Me.GB_CARD.ResumeLayout(False)
        Me.GB_CARD.PerformLayout()
        CType(Me.PB_MOVIE_PICTURE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_ZBIBLIO As GroupBox
    Friend WithEvents GB_CARD As GroupBox
    Friend WithEvents GB_MOVIESLIST As GroupBox
    Friend WithEvents GB_MOVIESEARCH As GroupBox
    Friend WithEvents LB_LIST_MOVIES As ListBox
    Friend WithEvents BT_SEARCH As Button
    Friend WithEvents BT_DELETE_SEARCH As Button
    Friend WithEvents LBL_YEAR As Label
    Friend WithEvents LBL_GENDER As Label
    Friend WithEvents DIRECTOR As Label
    Friend WithEvents LBL_ACTOR As Label
    Friend WithEvents TITLE As Label
    Friend WithEvents TXT_TITLE As TextBox
    Friend WithEvents DDL_ACTOR As ComboBox
    Friend WithEvents DDL_DIRECTOR As ComboBox
    Friend WithEvents DDL_GENDER As ComboBox
    Friend WithEvents DDL_YEAR As ComboBox
    Friend WithEvents LBL_ACTORS As Label
    Friend WithEvents LBL_GENDER2 As Label
    Friend WithEvents LBL_GENDER1 As Label
    Friend WithEvents LBL_DIRECTOR As Label
    Friend WithEvents LBL_RELEASE_DATE As Label
    Friend WithEvents ACTORS As Label
    Friend WithEvents GENDER2 As Label
    Friend WithEvents GENDER1 As Label
    Friend WithEvents DIRECTOR_CARD As Label
    Friend WithEvents RELEASE_DATE As Label
    Friend WithEvents LBL_TITLE As Label
    Friend WithEvents SYNOPSIS As Label
    Friend WithEvents PERSONAL_VIEW As Label
    Friend WithEvents LBL_SYNOPSIS As TextBox
    Friend WithEvents LBL_PERSONAL_VIEW As TextBox
    Friend WithEvents NOTE As Label
    Friend WithEvents SUR20 As Label
    Friend WithEvents LBL_NOTE As Label
    Friend WithEvents BT_UPDATE_CARD As Button
    Friend WithEvents BT_NEW_CARD As Button
    Friend WithEvents BT_DELETE_CARD As Button
    Friend WithEvents PB_MOVIE_PICTURE As PictureBox
End Class
