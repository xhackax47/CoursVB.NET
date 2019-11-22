Public Class AddEditionMovie

    Private _MovieToModif As Movie

    Sub New(MovieToModif As Movie)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _MovieToModif = MovieToModif

    End Sub
    Private Sub AddEditionMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _MovieToModif Is Nothing Then
            'Si _MovieToModif ne contient rien, création new
        Else
            'Sinon on récupère les infos
            Me.TXT_ACTORS.Text = _MovieToModif.Actors
            Me.TXT_PERSONAL_VIEW.Text = _MovieToModif.PersonalView
            Me.TXT_MOVIENAME.Text = _MovieToModif.Name
            Me.TXT_SYNOPSIS.Text = _MovieToModif.Synopsis
            Me.DDL_GENDER1.Text = _MovieToModif.Gender1
            Me.DDL_GENDER2.Text = _MovieToModif.Gender2
            Me.DDL_DIRECTOR.Text = _MovieToModif.Director
            Me.NUM_NOTE.Value = _MovieToModif.Note
            Me.DT_RELEASE_DATE.Value = _MovieToModif.ReleaseDate
        End If
    End Sub

    Private Sub BT_SAVE_Click(sender As Object, e As EventArgs) Handles BT_SAVE.Click
        If _MovieToModif Is Nothing Then
            'Enregistrement Movie
            Dim Movie As New Movie(
                Me.TXT_MOVIENAME.Text,
                Me.DT_RELEASE_DATE.Value,
                Me.DDL_DIRECTOR.Text,
                Me.DDL_GENDER1.Text,
                Me.DDL_GENDER2.Text,
                Me.TXT_ACTORS.Text,
                Me.TXT_SYNOPSIS.Text,
                Me.TXT_PERSONAL_VIEW.Text,
                Me.NUM_NOTE.Value)
            ZBiblio.MoviesList.Add(Movie)
            MsgBox("Fiche de film crée avec succès", vbOKOnly, "Confirmation")
        Else
            'Sinon on modifie en récupérant son index dans la liste
            ZBiblio.MoviesList(
                ZBiblio.MoviesList.IndexOf(_MovieToModif)).Update(
                Me.TXT_MOVIENAME.Text,
                Me.DT_RELEASE_DATE.Value,
                Me.DDL_DIRECTOR.Text,
                Me.DDL_GENDER1.Text,
                Me.DDL_GENDER2.Text,
                Me.TXT_ACTORS.Text,
                Me.TXT_SYNOPSIS.Text,
                Me.TXT_PERSONAL_VIEW.Text,
                Me.NUM_NOTE.Value
                )
        End If
        'Update list fenêtre mère
        ZBiblio.UpdateMoviesList()
        'Fermeture fenêtre enfant (edition)
        Me.Close()
    End Sub

    Private Sub PB_MOVIE_PICTURE_Click(sender As Object, e As EventArgs) Handles PB_MOVIE_PICTURE.Click

    End Sub
End Class