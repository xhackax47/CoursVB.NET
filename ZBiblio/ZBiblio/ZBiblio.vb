Imports System.Xml.Serialization
Imports System.IO

Public Class ZBiblio

    Private _AddWindow As AddEditionMovie
    Private _MovieInVisualisation As Movie
    Private _MoviesList As List(Of Movie)
    Public Property MoviesList As List(Of Movie)
        Get
            Return _MoviesList
        End Get
        Set(value As List(Of Movie))
            _MoviesList = value
        End Set
    End Property

    Private Sub MoviesList_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        'Instance New List
        _MoviesList = New List(Of Movie)

        'Récupération infos
        Deserialisation()

        'Update Movies List
        UpdateMoviesList()

    End Sub

    Private Sub MoviesList_FormClosing(sender As Object, e As System.EventArgs) Handles MyBase.FormClosing
        'Serialise les films à la fermeture
        Serialisation()
    End Sub


    Private Sub LB_LIST_MOVIES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_LIST_MOVIES.SelectedIndexChanged
        'Vérification selection
        If Not Me.LB_LIST_MOVIES.SelectedItem Is Nothing Then
            'Cherche film par le name
            For Each MovieToList As Movie In _MoviesList
                If MovieToList.Name = LB_LIST_MOVIES.SelectedItem.ToString Then
                    'Insertion dans Var globale
                    Me._MovieInVisualisation = MovieToList
                End If
            Next

            'Update infos fiche
            Me.LBL_TITLE.Text = Me._MovieInVisualisation.Name
            Me.LBL_RELEASE_DATE.Text = Me._MovieInVisualisation.ReleaseDate
            Me.LBL_GENDER1.Text = Me._MovieInVisualisation.Gender1
            Me.LBL_GENDER2.Text = Me._MovieInVisualisation.Gender2
            Me.LBL_DIRECTOR.Text = Me._MovieInVisualisation.Director
            Me.LBL_ACTORS.Text = Me._MovieInVisualisation.Actors
            Me.LBL_SYNOPSIS.Text = Me._MovieInVisualisation.Synopsis
            Me.LBL_PERSONAL_VIEW.Text = Me._MovieInVisualisation.PersonalView
            Me.LBL_NOTE.Text = Me._MovieInVisualisation.Note
        End If
    End Sub

    Public Sub UpdateMoviesList()
        'Clean List and Fill
        Me.LB_LIST_MOVIES.Items.Clear()
        'Parcours des movies de la bilbiotheque
        For Each MovieToList As Movie In _MoviesList
            'Remplit la liste en se basant sur le nom (vu que j'ai surchargé ToString)
            'A le même effet que FilmALister.Nom sans la surcharge.
            Me.LB_LIST_MOVIES.Items.Add(MovieToList)
        Next
    End Sub

#Region "Modification fiches"

    Private Sub BT_DELETE_CARD_Click(sender As Object, e As EventArgs) Handles BT_DELETE_CARD.Click
        'Confirmation
        If MsgBox("Etes-vous sûr de vouloir supprimer cette fiche film ?", vbYesNoCancel, "Confirmation") Then
            'Suppression
            Me._MoviesList.Remove(_MovieInVisualisation)
        End If

        'Update
        UpdateMoviesList()
    End Sub

    Private Sub BT_NEW_CARD_Click(sender As Object, e As EventArgs) Handles BT_NEW_CARD.Click
        'Si nouveau film, on passe null
        _AddWindow = New AddEditionMovie(Nothing)
        _AddWindow.Show()
    End Sub

    Private Sub BT_UPDATE_CARD_Click(sender As Object, e As EventArgs) Handles BT_UPDATE_CARD.Click
        _AddWindow = New AddEditionMovie(_MovieInVisualisation)
        _AddWindow.Show()
    End Sub

#End Region

#Region "Sauvegarde et Récupération"

    Private Sub Serialisation()
        ' Ouverture fichier et récup du flux
        Dim FluxFichier As FileStream = File.Create("BibliothequeFilms.xml")
        Dim Serialzer As New XmlSerializer(GetType(List(Of Movie)))

        'Désérialisation et conversion
        Serialzer.Serialize(FluxFichier, _MoviesList)

        'Fermeture flux
        FluxFichier.Close()
    End Sub

    Private Sub Deserialisation()
        If File.Exists("BibliothequeFilms.xml") Then
            ' Ouverture fichier et récup du flux
            Dim FluxFichier As Stream = File.OpenRead("BibliothequeFilms.xml")
            Dim Deserialzer As New XmlSerializer(GetType(List(Of Movie)))

            'Désérialisation et conversion
            _MoviesList = Deserialzer.Deserialize(FluxFichier)

            'Fermeture flux
            FluxFichier.Close()
        End If
    End Sub

#End Region

#Region "Recherche"

    Private Sub FillingSearchFields()

    End Sub

    Private Sub Search()
        'Clean List
        Me.LB_LIST_MOVIES.Items.Clear()

        'Parcours des movies
        For Each MovieToList As Movie In _MoviesList

            If Me.TXT_TITLE.Text <> "" Then
                If MovieToList.Name.Contains(Me.TXT_TITLE.Text) Then
                    Me.LB_LIST_MOVIES.Items.Add(MovieToList)
                End If
            End If

            If Me.DDL_ACTOR.Text <> "" Then
                If MovieToList.Actors.Contains(Me.DDL_ACTOR.Text) Then
                    Me.LB_LIST_MOVIES.Items.Add(MovieToList)
                End If
            End If

            If Me.DDL_DIRECTOR.Text <> "" Then
                If MovieToList.Director.Contains(Me.DDL_DIRECTOR.Text) Then
                    Me.LB_LIST_MOVIES.Items.Add(MovieToList)
                End If
            End If

            If Me.DDL_GENDER.Text <> "" Then
                If MovieToList.Gender1.Contains(Me.DDL_GENDER.Text) Or MovieToList.Gender2.Contains(Me.DDL_GENDER.Text) Then
                    Me.LB_LIST_MOVIES.Items.Add(MovieToList)
                End If
            End If

            If Me.DDL_YEAR.Text <> "" Then
                If CDate(MovieToList.ReleaseDate).Year = Me.DDL_YEAR.Text Then
                    Me.LB_LIST_MOVIES.Items.Add(MovieToList)
                End If
            End If
        Next
    End Sub

    Private Sub BT_SEARCH_Click(sender As Object, e As EventArgs) Handles BT_SEARCH.Click
        Search()
    End Sub

    Private Sub BT_DELETE_SEARCH_Click(sender As Object, e As EventArgs) Handles BT_DELETE_SEARCH.Click
        Me.TXT_TITLE.Text = ""
        Me.DDL_ACTOR.Text = ""
        Me.DDL_DIRECTOR.Text = ""
        Me.DDL_GENDER.Text = ""
        Me.DDL_YEAR.Text = ""

        UpdateMoviesList()
    End Sub

#End Region
End Class
