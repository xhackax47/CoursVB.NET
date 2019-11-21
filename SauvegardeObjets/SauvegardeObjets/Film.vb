<Serializable()>
Public Class Film

    Public Titre As String
    Public Annee As Integer
    Public Description As String

    Sub New()

    End Sub

    Sub New(TitreFilm As String, AnneeFilm As Integer, DescriptionFilm As String)
        Titre = TitreFilm
        Annee = AnneeFilm
        Description = DescriptionFilm
    End Sub

End Class
